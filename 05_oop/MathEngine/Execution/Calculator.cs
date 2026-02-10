namespace MathEngine.Execution;

public class Calculator
{
    public int Execute(int a, int b, Operation op) => op switch
    { 
        Operation.Add => a + b,
        Operation.Subtract => a - b,
        Operation.Multiplication => a * b,
        Operation.Divide => a / b,
    };
}
