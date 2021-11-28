using Microsoft.EntityFrameworkCore;
using SampleProject.Domain.Repository.Entity;
using SampleProject.Infrastructure.Repository;
using SampleProject.Infrastructure.Repository.Config;
using SampleProject.Infrastructure.Repository.Seeds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProjectxUnitTest.Infrastructure.Repository
{
    public partial class DatabaseContextMock : DatabaseContext
    {
        public DatabaseContextMock(DbContextOptions options) : base(options)
        {
            SeedMockAsync().GetAwaiter().GetResult();
        }

        private async Task SeedMockAsync()
        {
            await this.Tasks.AddRangeAsync(
                new TaskEntity() { Id = 1, Title = "Earth" }
            );
            await this.SaveChangesAsync();
        }
    }
}
