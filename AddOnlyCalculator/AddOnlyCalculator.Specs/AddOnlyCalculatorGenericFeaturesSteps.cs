using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace AddOnlyCalculator.Specs
{
    [Binding]
    public class AddOnlyCalculatorGenericFeaturesSteps
    {
        private Calculator calculator = new Calculator();
        private int result;
        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            calculator.First = p0;
        }

        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int p0)
        {
            calculator.Second = p0;
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            result = calculator.add();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.AreEqual(result, p0);
        }
    }
}
