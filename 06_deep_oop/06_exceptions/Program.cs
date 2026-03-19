

//Console.Write("Enter first number: ");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter second number: ");
//int b = Convert.ToInt32(Console.ReadLine());

////int result = a / b;
////Console.WriteLine($"Result: {result}");

//if (b == 0)
//    Console.WriteLine("Invalid b");
//else
//{
//    int result = a / b;
//    Console.WriteLine($"Result: {result}");
//}


// ===== try catch finally throw ======


//Console.Write("Enter first number: ");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.Write("Enter second number: ");
//int b = Convert.ToInt32(Console.ReadLine());

//try
//{
//    int result = a / b;
//    Console.WriteLine($"Result: {result}");
//}
//catch (NullReferenceException ex)
//{

//}
//catch (Exception ex)
//{
//    Console.WriteLine($"ERROR: {ex.Message}");
//}
//finally
//{
//    Console.WriteLine("Finally");
//}



//try
//{
//    //
//    //
//    //
//    throw new DivideByZeroException("Test exception");
//    //
//    //


//}
//catch (Exception ex)
//{
//    Console.WriteLine($"ERROR: {ex.Message}");

//}





//void F4()
//{
//    int a = 0;
//    int result = 4 / a;
//    Console.WriteLine("End of F4()");
//}

//void F3()
//{
//    F4();
//    Console.WriteLine("End of F3()");
//}
//void F2()
//{
//    F3();
//    Console.WriteLine("End of F2()");
//}

//void F1()
//{
//    F2();
//    Console.WriteLine("End of F1()");
//}

//F1();





// =========================



using System.Data;

Account acc = new Account(1000);

try
{
    acc.Withdraw(2000);
}
catch (AccountException ex)
{
    Console.WriteLine($"System error: {ex.Message}, your sum is {ex.Sum}");
}
catch (AppException ex)
{
    Console.WriteLine($"ERROR: {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"Internal server error");
}
finally
{
    Console.WriteLine("finally");
}



class AppException : Exception
{
    public AppException(string? message) : base(message)
    { }
}
class AccountException : AppException
{
    public int Sum { get; set; }
    public AccountException(string? message, int sum) 
        : base(message)
    {
        Sum = sum;
    }
}



class Account
{
    public int Balance { get; set; }
    public Account(int sum) => Balance = sum;
    public void Withdraw(int sum)
    {
        try
        {
            if (sum > Balance)
                throw new AccountException("Sum is unvaliable", sum);

            Balance -= sum;

            Console.WriteLine("All OK");
        }
        catch (AccountException ex)
        {
            Console.WriteLine("Account exception LOG handler");

            // throw new AppException("APP ERROR");
            throw;
        }
    }
}
