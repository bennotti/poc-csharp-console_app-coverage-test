using SampleProject.Core.BusinessRules.Interfaces;
using SampleProject;
using System;
using Xunit;

namespace SampleProjectxUnitTest.Application
{
    public class BusinessRulesTest
    {
        private readonly IGreeterBusinessRule _greeterBusinessRule;
        public BusinessRulesTest(IGreeterBusinessRule greeterBusinessRule)
        {
            _greeterBusinessRule = greeterBusinessRule;
        }
        [Fact(DisplayName = "should be pass and defined greeterBusinessRule instance")]
        [Trait("BusinessRulesTest", "Defined")]
        public void ServiceTest_with_service_defined()
        {
            Assert.NotNull(_greeterBusinessRule);
        }
    }
}
