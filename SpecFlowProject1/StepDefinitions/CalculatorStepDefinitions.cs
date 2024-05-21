using FluentAssertions;
using TechTalk.SpecFlow;
using SampleConsoleApp;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private int _firstNumber;
        private int _secondNumber;
        private int _result;
        private readonly Calculator _calculator;

        public CalculatorStepDefinitions()
        {
            _calculator = new Calculator();
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _firstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _secondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add(_firstNumber, _secondNumber);
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int expectedResult)
        {
            _result.Should().Be(expectedResult);
        }
    }
}

