namespace SpecFlowCalculator.Specs.StepDefinitions;

[Binding]
public sealed class CalculatorStepDefinitions
{
    // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
    private readonly Calculator calculator =
            new Calculator();

    [Given("the first number is (.*)")]
    public void GivenTheFirstNumberIs(int number)
    {
        calculator.FirstNumber = number;
    }

    [Given("the second number is (.*)")]
    public void GivenTheSecondNumberIs(int number)
    {
        calculator.SecondNumber = number;
    }

    private int result;

    [When("the two numbers are added")]
    public void WhenTheTwoNumbersAreAdded()
    {
        result = calculator.Add();
    }

    [Then("the result should be (.*)")]
    public void ThenTheResultShouldBe(int result)
    {
        result.Should().Be(result);
    }
}