


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

//Account acc = new Account(1000);
//acc.AddSubscriber(new Logger("app.log"));
//acc.AddSubscriber(new TelegramNotifier());
//acc.AddSubscriber(new EmailNotifier());

//acc.Add(100);
//acc.Withdraw(500);
//acc.Withdraw(1000);


//interface ISubscriber
//{
//    void Update(string message);
//}

//class TelegramNotifier : ISubscriber
//{
//    public void Update(string message)
//    {
//        Console.ForegroundColor = ConsoleColor.Green;
//        Console.WriteLine($"Telegram: {message}");
//        Console.ResetColor();
//    }
//}
//class EmailNotifier : ISubscriber
//{
//    public void Update(string message)
//    {
//        Console.ForegroundColor = ConsoleColor.Blue;
//        Console.WriteLine($"Email: {message}");
//        Console.ResetColor();
//    }
//}
//class SmsNotifier : ISubscriber
//{
//    public void Update(string message)
//    {
//        Console.ForegroundColor = ConsoleColor.Red;
//        Console.WriteLine($"SMS: {message}");
//        Console.ResetColor();
//    }
//}
//class Logger : ISubscriber
//{
//    public string Path { get; set; }
//    public Logger(string path) => Path = path;
//    public void Update(string message)
//    {
//        Console.WriteLine($"Logging to {Path}: {message}");
//    }
//}

//class Account
//{
//    private int sum;
//    private List<ISubscriber> subscribers = new List<ISubscriber>();
//    public Account(int sum) => this.sum = sum;
//    public void AddSubscriber(ISubscriber subscriber) => subscribers.Add(subscriber);

//    public void Add(int val)
//    {
//        sum += val;

//        Emit($"ADDED: {val}");
//    }

//    public void Withdraw(int val)
//    {
//        if (sum >= val)
//        {
//            sum -= val;

//            Emit($"WITHDRAWEN: {val}");
//        }
//        else
//        {
//            Emit($"ERROR: {val}");
//        }
//    }

//    private void Emit(string message)
//    {
//        foreach (ISubscriber subscriber in subscribers)
//        {
//            subscriber.Update(message);
//        }
//    }
//}

#endregion

#region Anonymus methods

//NotifyHandler handler = delegate (string message)
//{
//    Console.WriteLine($"From anonymus method: {message}");
//};

//handler?.Invoke("Vasia");


//delegate void NotifyHandler(string message);





//int factor = 4;

//ValueBuilder vb = delegate (int a, int b)
//{
//    return (a + b) * factor;
//};

//Console.WriteLine(vb(3, 4));

//delegate int ValueBuilder(int a, int b);







//Executor BuildExecutor(int factor)
//{
//    return delegate (int a, int b)
//    {
//        return (a + b) * factor;
//    };
//}

//Executor ex1 = BuildExecutor(2);
//Console.WriteLine(ex1(1, 1));
//Console.WriteLine(ex1(2, 2));

//Executor ex2 = BuildExecutor(100);
//Console.WriteLine(ex2(1, 1));
//Console.WriteLine(ex2(2, 2));


//delegate int Executor(int a, int b);







//Counter BuildCounter(int initValue, int step = 1)
//{
//    int count = initValue;

//    return delegate ()
//    {
//        Console.WriteLine($"Count = {count}");

//        count += step;
//    };
//}

//Counter c1 = BuildCounter(0);
//c1();
//c1();
//c1();
//c1();

//Counter c2 = BuildCounter(100, 7);
//c2();
//c2();
//c2();
//c2();


//delegate void Counter();


#endregion

#region Lambda functions

//Handler h1 = new Handler(Method1);

//Handler h2 = Method1;

//Handler h3 = delegate ()
//{
//    Console.WriteLine($"From anonymus method");
//};

//Handler h4 = () => { Console.WriteLine("from lambda"); };

//Handler h5 = () => Console.WriteLine("from lambda 1");
//h5 += Method1;
//h5 += () => Console.WriteLine("from lambda 2");

//h5?.Invoke();

//void Method1()
//{
//    Console.WriteLine("Method1");
//}

//delegate void Handler();



// ================ parameters / returns ==============


//OperationHandler operation1 = (int a, int b) => { return a + b; };          // :-|
//// >>> EQUALS <<<
//OperationHandler operation2 = (a, b) => a + b;                              // :-)


//RenderHandler rh1 = (string message) => { Console.WriteLine($"Message: {message}"); };      // :-|
//// >>> EQUALS <<<
//RenderHandler rh2 = m => Console.WriteLine($"Message: {m}");                                // :-)


//OperationHandler sumHandler = (a, b) => a + b;
//OperationHandler divHandler = (a, b) => a / b;
//OperationHandler mulHandler = (a, b) => a * b;


//delegate int OperationHandler(int a, int b);
//delegate void RenderHandler(string message);


#endregion

#region Practice_1
// Создать метод, который суммирует элементы по условию, которое определяется вне метода

//int[] arr = { 4, 6, 7, 3, 2, 1, 7, 9 };

//int Sum(int[] arr, Predicate predicate)
//{
//    int sum = 0;

//    foreach(int n in arr)
//    {
//        if (predicate(n))
//            sum += n;
//    }

//    return sum;
//}

//Console.WriteLine(Sum(arr, n => n % 2 == 0 ));
//Console.WriteLine(Sum(arr, n => n > 0 ));
//Console.WriteLine(Sum(arr, n => n % 7 == 0));

//delegate bool Predicate(int val);


#endregion

#region Practice_2

// Написать метод для поиска пользователя(-ей) по любым критериям

//// =============== Простой способ =============

//List<User> users = new List<User>()
//{
//    new User(110, "vasia@mail.com", 34),
//    new User(45, "petya@mail.com", 24),
//    new User(112, "dima@mail.com", 15),
//    new User(165, "kolya@mail.com", 21),
//    new User(110, "bogdan@mail.com", 23),
//};

//List<User> Find(List<User> users, Predicate predicate)
//{
//    List<User> result = new List<User>();

//    foreach (User user in users)
//        if (predicate(user))
//            result.Add(user);

//    return result;
//}

//List<User> res1 = Find(users, u => u.Id == 110);
//foreach (User user in res1)
//    Console.WriteLine(user);

//List<User> res2 = Find(users, u => u.Age < 18);
//foreach (User user in res2)
//    Console.WriteLine(user);

//class User
//{
//    public int Id { get; set; }
//    public string? Email { get; set; }
//    public int Age { get; set; }
//    public User(int id, string? email, int age)
//    {
//        Id = id;
//        Email = email;
//        Age = age;
//    }
//    public override string ToString()
//    {
//        return $"id: {Id}, email: {Email}, age: {Age}";
//    }
//}

//delegate bool Predicate(User user);




// =============== Продвинутый способ =============

//List<User> users = new List<User>()
//{
//    new User(110, "vasia@mail.com", 34),
//    new User(45, "petya@mail.com", 24),
//    new User(112, "dima@mail.com", 15),
//    new User(165, "kolya@mail.com", 21),
//    new User(110, "bogdan@mail.com", 23),
//};

//List<T> Find<T>(List<T> items, Predicate<T> predicate)
//{
//    List<T> result = new List<T>();

//    foreach (T item in items)
//        if (predicate(item))
//            result.Add(item);

//    return result;
//}

//List<User> res1 = Find<User>(users, u => u.Id == 110);
//foreach (User user in res1)
//    Console.WriteLine(user);

//List<User> res2 = Find<User>(users, u => u.Age < 18);
//foreach (User user in res2)
//    Console.WriteLine(user);

//class User
//{
//    public int Id { get; set; }
//    public string? Email { get; set; }
//    public int Age { get; set; }
//    public User(int id, string? email, int age)
//    {
//        Id = id;
//        Email = email;
//        Age = age;
//    }
//    public override string ToString()
//    {
//        return $"id: {Id}, email: {Email}, age: {Age}";
//    }
//}

//delegate bool Predicate<T>(T item);

#endregion

#region Imbedded delegates

// === Action / Action<T> ===

//Action a = () => Console.WriteLine();
//Action<int, string> b = (n, s) => Console.WriteLine();


// === Predicate<T> ===
// Predicate<int> p = n => true;


// === Func<T...., TResult> ===

//Func<int> f1 = () => 1;
//Func<int, int, string> f2 = (a, b) => $"{a}-{b}";

//void Method(int num, string email, Func<int, List<string>, double> func)
//{

//}

//Method(12, "message", (n, list) => 1.0);

#endregion

#region Events


Server server = new Server();
server.UserConnected += u => Console.WriteLine($"Logging user connected: {u}");
server.UserConnected += u =>
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Send to Admin telegram: connected: {u}");
    Console.ResetColor();
};

server.UserDisconnected += u => Console.WriteLine($"Logging user disconnected: {u}");


User a = new User(101, "vasia@mail.com", 21);
User b = new User(202, "petya@mail.com", 34);

server.Connect(a);
server.Connect(b);

server.Disconnect(a);


class Server
{
    public event Action<User> UserConnected;
    public event Action<User> UserDisconnected;

    public List<User> Users { get; set; } = new List<User>();
    public void Connect(User user)
    {
        //
        Users.Add(user);
        UserConnected?.Invoke(user);
    }
    public void Disconnect(User user) 
    { 
        //
        Users.Remove(user);
        UserDisconnected?.Invoke(user);
    }
}

class User
{
    public int Id { get; set; }
    public string? Email { get; set; }
    public int Age { get; set; }
    public User(int id, string? email, int age)
    {
        Id = id;
        Email = email;
        Age = age;
    }
    public override string ToString()
    {
        return $"id: {Id}, email: {Email}, age: {Age}";
    }
}

#endregion




