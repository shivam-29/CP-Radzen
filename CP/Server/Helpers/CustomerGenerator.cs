﻿using Bogus;
using CP.Shared.Models;

namespace CP.Server.Helpers;

public static class CustomerGenerator
{
   public static List<T> GenerateUsers<T>(Faker faker, int count, CustomerType userType,int StartID) where T : BaseUser, new()
   {
        var users = new List<T>();

        for (int i = 0; i < count; i++)
        {
            var user = new T()
            {
                Id = Guid.NewGuid(),
                FirstName = faker.Person.FirstName,
                LastName = faker.Person.LastName,
                Email = faker.Person.Email,
                AddressId = StartID + (i + 1),
                Street = faker.Address.StreetAddress(),
                City = faker.Address.City(),
                State = faker.Address.State(),
                ZipCode = faker.Address.ZipCode(),
                Country = faker.Address.Country(),

            };
            if (user is Customer customer)
            {
                customer.CustomerType = userType;
            }
            users.Add(user);
        }

        return users;
    }

}
