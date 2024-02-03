
using Bogus;
using CP.Shared.Models;
using System;
using System.Collections.Generic;

namespace CP.Server.Helpers;
public static class AddressGenerator
{
    public static List<Address> GenerateUserAddresses(Faker faker,int count, int? userId = null, int? customerId = null)
    {
        var addresslist =new List<Address>();
        for (int i = 0; i < count; i++)
        {
            var address = new Address()
            {
                AddressId = faker.UniqueIndex,
                Country =faker.Address.Country(),
                City =faker.Address.City(),
                State =faker.Address.State(),
                Street = faker.Address.StreetAddress(),
                ZipCode =faker.Address.ZipCode(),
           

            };

          
            addresslist.Add(address);
        }
       
        return addresslist;
    }

}

