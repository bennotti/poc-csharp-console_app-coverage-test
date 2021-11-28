using SampleProject;
using SampleProject.Infrastructure.Repository;
using System;
using Xunit;

namespace SampleProjectxUnitTest.Infraestructure
{
    public class DbContextTest
    {
        private DatabaseContext _db;
        public DbContextTest(DatabaseContext db)
        {
            _db = db;
        }

        [Fact(DisplayName = "should be pass with a DatabaseContext instance defined")]
        [Trait("DbContextTest", "DatabaseContext defined")]
        public void DbContextTest_valid_databaseContext()
        {
            Assert.NotNull(_db);
        }
    }
}
