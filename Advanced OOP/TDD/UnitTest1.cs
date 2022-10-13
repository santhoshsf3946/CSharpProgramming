namespace TDD;

[TestFixture]
public class Tests
{
    Maths operation = null;
    Maths operation1 = null;
    Maths operation2 = null;


    [SetUp]
    public void Setup()
    {
        operation = new Maths();
        operation1 = new Maths();
        operation2 = new Maths();
    }

    [Test]
    public void Test1()
    {
        int result = operation.Addition(10, 11);

        Assert.That(result, Is.EqualTo(21));
    }

    [TestCase(10, 20, 30)]
    [TestCase(1, 2, 3)]
    public void IsAdditionOk(int value1, int value2, int result)
    {
        int output = operation.Addition(value1, value2);
        Assert.AreEqual(output, result);
    }

    [TestCase(1.2, 2.1, 3.3)]
    public void IsAdditionOk(double value1, double value2, double result)
    {
        double output = operation.Addition(value1, value2);
        Assert.AreEqual(output, result);
    }
    
    [TestCase("Ravi", "Chandran", "RaviChandran")]
    public void IsAdditionOk(string value1, string value2, string result)
    {
        string output = operation.Addition(value1, value2);
        Assert.AreEqual(output, result);
    }
}
