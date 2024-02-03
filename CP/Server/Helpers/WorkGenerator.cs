using Bogus;
using CP.Shared;

namespace CP.Server.Helpers;

public static class WorkGenerator
{
   public static List<Work> GenerateWorkList(Faker faker, int count)
   {
        var workList = new List<Work>();

        for (int i = 0; i < count; i++)
        {
            var work = new Work
            {
                Id = Guid.NewGuid(),
                Name = faker.Random.Word(),
                RequestType = faker.PickRandom<RequestType>(),
                ChangeType = faker.PickRandom<RequestType>(),
                Status = faker.PickRandom<Status>(),
                RequestedBy = faker.Name.FullName(),
                RepresentativeName =faker.Name.FullName(),
                ReviewerName = faker.Name.FirstName(),

            };

            workList.Add(work);
        }

        return workList;
    }
}
