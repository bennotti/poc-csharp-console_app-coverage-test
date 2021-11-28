using Microsoft.Extensions.DependencyInjection;
using SampleProject;
using System;
using Xunit;

namespace SampleProjectxUnitTest.Infraestructure
{
    public class ServiceProviderTest
    {
        private IServiceProvider _serviceProvider;

        public ServiceProviderTest(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        [Fact(DisplayName = "should be pass with defined")]
        [Trait("ServiceProvider", "ServiceProvider defined")]
        public void ServiceProviderTest_with_defined_result()
        {
            Assert.NotNull(_serviceProvider);
        }
    }
}
