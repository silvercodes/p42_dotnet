

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





void F4()
{
    int a = 0;
    int result = 4 / a;
    Console.WriteLine("End of F4()");
}

void F3()
{
    F4();
    Console.WriteLine("End of F3()");
}
void F2()
{
    F3();
    Console.WriteLine("End of F2()");
}

void F1()
{
    F2();
    Console.WriteLine("End of F1()");
}

F1();

