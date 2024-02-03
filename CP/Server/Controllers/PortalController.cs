using Bogus;
using CP.Server.Data;
using CP.Server.Helpers;
using CP.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CP.Server.Controllers;

[ApiController]
[Route("[controller]")]
public class PortalController : Controller
{
    private readonly ApplicationDbContext _db;
    public PortalController(ApplicationDbContext db)
    {
            _db = db;
    }


    [HttpGet("Customers")]

    public async Task<List<Customer>> GetCustomers()
    {


        return await _db.Customers
                    .Where(x => x.CustomerType == CustomerType.Customer)
                    .ToListAsync();
    }

    [HttpGet("Vendors")]

    public async Task<List<Customer>> GetVendors()
    {
        return await _db.Customers
                     .AsNoTracking()
                    .AsSplitQuery()
                    .Where(x => x.CustomerType == CustomerType.Vendor)
                    .ToListAsync();
    }

    [HttpGet("Users")]

    public async Task<List<User>> GetUsers()
    {
        return await _db.Users
                         .AsNoTracking()
                         .AsSplitQuery()
                         .ToListAsync();
    }


    [HttpGet("Works")]
    public async Task<List<Work>> GetWorkList()
    {
        var result = await _db.Works
                        .AsNoTracking()
                        .AsSplitQuery()
                        .ToListAsync();
        return result;
    }

    [HttpPost("Requests")]
    public IQueryable<CustomerRequestModel> GetRequests([FromBody] PagingParameters pagingParameters)
    {
        
            var query = _db.CustomerRequests.AsNoTracking().AsSplitQuery().AsQueryable();

            // Apply any additional filters, ordering, etc. to the query
            query = query.OrderBy(x => x.GUID)
                         .Skip(pagingParameters.Skip)
                         .Take(pagingParameters.Take);

            return query;
        
       
    }




    [HttpPost("seed")]
    public IActionResult SeedData()
    {
        using (var transaction = _db.Database.BeginTransaction())
        {
            try
            {
                // Seed Customers and Vendors
                var customers = CustomerGenerator.GenerateUsers<Customer>(new Faker(), 100, CustomerType.Customer, 1);
                var vendors = CustomerGenerator.GenerateUsers<Customer>(new Faker(), 100, CustomerType.Vendor, 100);
                customers.AddRange(vendors);
                _db.Customers.AddRange(customers);
                _db.SaveChanges();

                // Seed Users
                var users = UserGenerator.GenerateUsers<User>(new Faker(), 100, Role.Admin, 1);
                var representatives = UserGenerator.GenerateUsers<User>(new Faker(), 100, Role.Representative, 100);
                var reviewers = UserGenerator.GenerateUsers<User>(new Faker(), 100, Role.Reviewer, 200);
                users.AddRange(representatives);
                users.AddRange(reviewers);
                _db.Users.AddRange(users);
                _db.SaveChanges();

                transaction.Commit();
                return Ok("Data seeded successfully!");
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                return BadRequest($"Error: {ex.Message}");
            }
        }
    }
}
