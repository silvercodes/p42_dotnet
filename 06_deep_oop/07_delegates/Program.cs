


#region Intro
//ExecuteDelegate del = new ExecuteDelegate(f1);
//del += f1;
//del += f1;
//del += f1;

//// del += f2;      // ERROR

//del();
//del?.Invoke();


//ExecuteDelegate del1 = new ExecuteDelegate(f1);
//ExecuteDelegate del2 = new ExecuteDelegate(f1);

//ExecuteDelegate del3 = del1 + del2;
//del3.Invoke();


//void f1()
//{
//    Console.WriteLine("f1");
//}

//void f2(int x = 0)
//{
//    Console.WriteLine($"x = {x}");
//}


//delegate void ExecuteDelegate(); 
#endregion

#region Example_1

//User u = new User();
//u.Process("Hello user");

//class User
//{
//    private delegate void NotifyHandler(string message);

//    public void Process(string message)
//    {
//        NotifyHandler handler;
//        handler = Notify;
//        handler += TelegramNotify;

//        //
//        //

//        handler?.Invoke(message);
//    }

//    private void Notify(string message)
//    {
//        Console.WriteLine($"Notify: {message}");
//    }
//    private void TelegramNotify(string message)
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine($"Telegram: {message}");
//        Console.ResetColor();
//    }
//}





//NotifyHandler? notifier = SendEmail;
//notifier += SendSms;
//notifier += SendTelegram;

//notifier -= SendSms;

//notifier?.Invoke("Content");


//void SendEmail(string content) => Console.WriteLine($"Email: {content}");
//void SendTelegram(string content) => Console.WriteLine($"Telegram: {content}");
//void SendSms(string content) => Console.WriteLine($"Sms: {content}");


//delegate void NotifyHandler(string content);

#endregion

#region Generic delegates


//Operation<string, int> op = Process;
//Console.WriteLine(op(5, 6));

//string Process(int x, int y) => $"{x} + {y} = {x + y}";

//delegate T Operation<T, K>(K a, K b);

// ----------------------------------------------------------------

//int? Execute(int a, int b, Operation<int> op)
//{
//    return op?.Invoke(a, b);
//}

//// Console.WriteLine(Execute(3, 4, Add));
//Console.WriteLine(Execute(3, 4, new Operation<int>(Mul)));



//Operation<int> GetOperation(OpType opType) => opType switch
//{
//    OpType.Add => Add,
//    OpType.Mult => Mul,
//    OpType.Sub => Sub,
//    OpType.Division => Div,
//    _ => throw new NotSupportedException()
//};

//Operation<int> operation = GetOperation(OpType.Mult);
//Console.WriteLine(operation?.Invoke(3, 4));


//int Add(int a, int b) => a + b;
//int Sub(int a, int b) => a - b;
//int Mul(int a, int b) => a * b;
//int Div(int a, int b) => a / b;

//enum OpType
//{
//    Add,
//    Mult,
//    Sub,
//    Division,
//}


//delegate T Operation<T>(T a, T b);


#endregion



#region Practice Observer pattern

// === Классическая реализация

Account acc = new Account(1000);
acc.AddSubscriber(new Logger("app.log"));
acc.AddSubscriber(new TelegramNotifier());
acc.AddSubscriber(new EmailNotifier());

acc.Add(100);
acc.Withdraw(500);
acc.Withdraw(1000);


interface ISubscriber
{
    void Update(string message);
}

class TelegramNotifier : ISubscriber
{
    public void Update(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Telegram: {message}");
        Console.ResetColor();
    }
}
class EmailNotifier : ISubscriber
{
    public void Update(string message)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"Email: {message}");
        Console.ResetColor();
    }
}
class SmsNotifier : ISubscriber
{
    public void Update(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"SMS: {message}");
        Console.ResetColor();
    }
}
class Logger : ISubscriber
{
    public string Path { get; set; }
    public Logger(string path) => Path = path;
    public void Update(string message)
    {
        Console.WriteLine($"Logging to {Path}: {message}");
    }
}

class Account
{
    private int sum;
    private List<ISubscriber> subscribers = new List<ISubscriber>();
    public Account(int sum) => this.sum = sum;
    public void AddSubscriber(ISubscriber subscriber) => subscribers.Add(subscriber);

    public void Add(int val)
    {
        sum += val;

        Emit($"ADDED: {val}");
    }

    public void Withdraw(int val)
    {
        if (sum >= val)
        {
            sum -= val;

            Emit($"WITHDRAWEN: {val}");
        }
        else
        {
            Emit($"ERROR: {val}");
        }
    }

    private void Emit(string message)
    {
        foreach (ISubscriber subscriber in subscribers)
        {
            subscriber.Update(message);
        }
    }
}


#endregion


