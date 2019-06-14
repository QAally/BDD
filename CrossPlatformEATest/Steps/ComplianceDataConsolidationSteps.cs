using System;
using EAAutoFramework.Base;
using TechTalk.SpecFlow;

namespace CrossPlatformEATest
{
    [Binding]
    class ComplianceDataConsolidationSteps: BaseStep
    { 
    //Context injection
    private readonly ParallelConfig _parallelConfig;

    public ComplianceDataConsolidationSteps(ParallelConfig parellelConfig) : base(parellelConfig)
    {
    _parallelConfig = parellelConfig;
    }

        [Given(@"I click on the uploads button")]
        public void GivenIClickOnTheUploadsButton()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
