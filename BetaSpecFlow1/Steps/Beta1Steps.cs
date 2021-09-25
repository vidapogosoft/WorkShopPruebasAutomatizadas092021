using System;
using TechTalk.SpecFlow;

namespace BetaSpecFlow1.Steps
{
    [Binding]
    public class Beta1Steps
    {
        [Given(@"el numero uno es (.*)")]
        public void GivenElNumeroUnoEs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"el numero dos es (.*)")]
        public void GivenElNumeroDosEs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"se procede a realizar la suma")]
        public void WhenSeProcedeARealizarLaSuma()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"el resultado es (.*)")]
        public void ThenElResultadoEs(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
