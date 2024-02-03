using Bogus;
using CP.Server.Helpers;
using CP.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace CP.Server.Data;

public class ApplicationDbContext :DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
            
    }

    public DbSet<User> Users { get; set; }

    public DbSet<Customer> Customers { get; set; }

    public DbSet<Work> Works { get; set; }

    public DbSet<CustomerRequestModel> CustomerRequests { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        SeedData(modelBuilder);

        base.OnModelCreating(modelBuilder);
    }

    private static void SeedData(ModelBuilder modelBuilder)
    {
       

        // Create a Faker instance for generating fake data
        var faker = new Faker();

        var customers = CustomerGenerator.GenerateUsers<Customer>(faker, 100, CustomerType.Customer, 1);
        var vendors = CustomerGenerator.GenerateUsers<Customer>(faker, 100, CustomerType.Vendor, 100);

        customers.AddRange(vendors);

        modelBuilder.Entity<Customer>().HasData(customers);



        // Seed Users
        var users = UserGenerator.GenerateUsers<User>(faker, 100, Role.Admin, 1);
        var representatives = UserGenerator.GenerateUsers<User>(faker, 100, Role.Representative, 100);
        var reviewers = UserGenerator.GenerateUsers<User>(faker, 100, Role.Reviewer, 200);
        users.AddRange(representatives);
        users.AddRange(reviewers);


        modelBuilder.Entity<User>().HasData(users);



        // Seed Works
        var works = WorkGenerator.GenerateWorkList(faker, 500);
        modelBuilder.Entity<Work>().HasData(works);

        var requests = CustomerRequestGenerator.Generate(faker);
        modelBuilder.Entity<CustomerRequestModel>().HasData(requests);

    }


}
