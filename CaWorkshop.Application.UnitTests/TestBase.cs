using AutoMapper;
using CaWorkshop.Infrastructure.Persistence;
using System;

namespace CaWorkshop.Application.UnitTests
{
    public class TestBase : IDisposable
    {
        public TestBase()
        {
            Context = DbContextFactory.Create();
            Mapper = MapperFactory.Create();
        }

        public ApplicationDbContext Context { get; }

        public IMapper Mapper { get; }

        public void Dispose()
        {
            DbContextFactory.Destroy(Context);
        }
    }
}