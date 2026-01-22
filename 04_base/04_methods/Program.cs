
#region Intro

////[modifier] <return_type> TitleTitle([parameters])
////{
////}

//// Полная форма
//int Add(int a, int b)
//{
//    return a + b;
//}

//// Сокращённая форма (для 1 стейтмента)
//int Add2(int a, int b) => a + b;


//// Полная форма
//void RenderMessage(string message)
//{
//    Console.WriteLine($"Message: {message}");
//}

//// Сокращённая форма (для 1 стейтмента)
//void RenderMessage2(string message) => Console.WriteLine($"Message: {message}");


//int result = Add(23, 45);
//RenderMessage("Vasia");
//RenderMessage2("Petya");

#endregion


#region Parameters

//// Обязательные параметры
//void Render(string message, int count)
//{
//    for (int i = 0; i < count; i++)
//        Console.WriteLine(message);
//}
//Render("Vasia", 5);

//// Необязательные параметры
//void Render2(string message, int count = 3)
//{
//    for (int i = 0; i < count; i++)
//        Console.WriteLine(message);
//}
//Render2("Petya", 5);
//Render2("Kolia");


// Именованные параметры

//void Render(string message = "no_message", int count = 3, ConsoleColor color = ConsoleColor.Red)
//{
//    Console.ForegroundColor = color;
//    for (int i = 0; i < count; i++)
//        Console.WriteLine(message);
//    Console.ResetColor();
//}

//Render("no_message", 3, ConsoleColor.Green);
//Render(color: ConsoleColor.Red, count: 10);
//Render("Vasia", color: ConsoleColor.Blue);




// ============ по-значению / по-ссылке

// 1. по-значению
//void Render(int n)
//{
//    n *= 2;
//    Console.WriteLine($"Result: {n}");
//}
//int val = 10;
//Render(val);
//Console.WriteLine($"val: {val}");


// 2. по-ссылке(ref)
//void Render(ref int n)
//{
//    n *= 2;
//    Console.WriteLine($"Result: {n}");
//}
//int val = 10;
//Render(ref val);
//Console.WriteLine($"val: {val}");


// 2.1 входной параметр (in)
//void RenderArea(in int w, in int h)             // void renderArea(const int* a, const int* b) --> FOR C++ 
//{
//    // w = 1;      // ERROR

//    int area = w * h;
//    Console.WriteLine($"Area: {area}");
//}


// 2.2 выходной параметр (out)
//void CalcArea(int w, int h, out int area)
//{
//    area = w * h;
//}

////int area = 0;
////CalcArea(2, 4, out area);
////Console.WriteLine(area);

//// >>> EQUALS <<<

//CalcArea(2, 4, out int area);
//Console.WriteLine(area);


// ====== общий пример ======
//bool CalcRectangle(in int w, in int h, out int area, out int perimeter)
//{
//    //w = 12;     // ERROR
//    //h = 34;     // ERROR

//    area = w * h;
//    perimeter = 2 * (w + h);

//    return true;
//}

//int w = 10;
//int h = 12;

//bool result = CalcRectangle(w, h, out int area, out int perimeter);

//Console.WriteLine($"{w} {h} {area} {perimeter}");



// 2.3 ref readonly  (FROM .NET 12)

// TODO: ????
//void A(in int val) { }
//void B(ref readonly int val) { }

//int value = 12;
//A(42);
//A(in value);

//// B(ref readonly 42);
//B(value);


//void A(in int val) { }
//void A(ref readonly int val) { }
//void A(ref int a) { }
//void A(in int a) { }

#endregion


#region Local functions

//public class Programm
//{
//    static void Main()      // <-- method
//    {
//        int a = 45;
//        int b = 12;

//        Console.WriteLine(Sum1());

//        int Sum1()                  // <-- local function
//        {
//            return a + b;
//        }

//        static int Sum2()           // <-- local function
//        {
//            // return a + b;       // ERROR
//        }
//    }
//}


//int a = 45;
//int b = 12;

//Console.WriteLine(Sum1());

//int Sum1()                  // <-- local function
//{
//    return a + b;
//}

//static int Sum2()           // <-- local function
//{
//    // return a + b;       // ERROR
//}

#endregion


#region Enum

//Status status = Status.Running;
//if (status == Status.Stopped)
//    Console.WriteLine("Stop");

//Console.WriteLine(status);
//Console.WriteLine((int)status);


//enum Status : byte
//{
//    Running = 2,
//    Stopped = 4,
//    Pending = 8,
//    Started = 2,
//    Wait = Pending,
//}

#endregion


#region switch

//Status status = Status.Running;

//switch(status)
//{
//    case Status.Pending:
//    case Status.Running:
//        Console.WriteLine("Running");
//        goto case Status.Stopped;           // :-(((

//    case Status.Stopped:
//        Console.WriteLine("STOP");
//    break;
//    default:
//        Console.WriteLine("Default");
//    break;
//}


//enum Status : byte
//{
//    Running = 2,
//    Stopped = 4,
//    Pending = 8,
//}





//int Execute(Operation op, int a, int b)
//{
//    switch(op)
//    {
//        case Operation.Sum:
//            return a + b;
//        case Operation.Div:
//            return a / b;
//        case Operation.Mul:
//            return a * b;
//        case Operation.Sub:
//            return a - b;
//        default:
//            return -1;
//    }
//}

// >>> EQUALS <<<

//int Execute(Operation op, int a, int b)
//{
//    int result = op switch
//    {
//        Operation.Sum => a + b,
//        Operation.Sub => a - b,
//        Operation.Mul => a * b,
//        Operation.Div => a / b,
//        _ => -1,
//    };

//    return result;
//}

// >>> EQUALS <<<

//int Execute(Operation op, int a, int b)
//{
//    return op switch
//    {
//        Operation.Sum => a + b,
//        Operation.Sub => a - b,
//        Operation.Mul => a * b,
//        Operation.Div => a / b,
//        _ => -1,
//    };
//}

// >>> EQUALS <<<
int Execute(Operation op, int a, int b) => op switch
{
    Operation.Sum => a + b,
    Operation.Sub => a - b,
    Operation.Mul => a * b,
    Operation.Div => a / b,
    _ => -1,
};

enum Operation
{
    Sum,
    Sub,
    Mul,
    Div,
}

#endregion
