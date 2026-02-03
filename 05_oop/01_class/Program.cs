
#region Intro

//User user = new User();
//user.id = 101;
//user.email = "vasia@mail.com";

//user.Render();

//class User
//{
//    public int id;
//    public string email;

//    public void Render()
//    {
//        Console.WriteLine($"User info: {id} --> {email}");
//    }
//}





//User user = new User();
//user.Render();

//user.id = 101;
//user.email = "vasia@mail.com";

//user.Render();

//class User
//{
//    public int id = 100;
//    public string email = "no_email";

//    public void Render()
//    {
//        Console.WriteLine($"User info: {id} --> {email}");
//    }
//}

#endregion


#region ctor

// User a = new User();
//User b = new User(101);

//class User
//{
//    public int id;
//    public string email;

//    public User(int id = 0, string email = "no_email")
//    {
//        this.id = id;
//        this.email = email;
//        Console.WriteLine("First ctor");
//    }

//    public User(int id):
//        this(id, "no_email")                    // Делегирование
//    {
//        Console.WriteLine("Second ctor");
//    }
//}



// FROM C# 12 !!!
// --- Primary constructor (Первичный конструктор)



//User a = new User(101, "vasia@mail.com");
//a.Render();

//class User(int id, string email)
//{
//    public User(int id) :
//        this(id, "no_email")
//    { }

//    public void Render() => Console.WriteLine($"{id} {email}");
//}

#endregion


#region Initializer

//Unit a = new Unit("archer", 100)
//{
//    hp = 300,
//    title = "warrior",
//};

//a.Render();

//Logger loggerA = new Logger()
//{
//    filePath = "/usr/bin",
//    depth = 100,
//};

//class Unit
//{
//    public string title;
//    public int hp;

//    public Unit(string title, int hp)
//    {
//        this.title = title;
//        this.hp = hp;
//    }
//    public void Render() => Console.WriteLine($"{title} {hp}");
//}

//class Logger
//{
//    public required string filePath;
//    public bool recursive = false;
//    public int depth = 500;
//    public string level = "warning";
//}

#endregion


#region Deconstructor (ЭТО НЕ ДЕСТРУКТОР!!!)

using _01_class;

Role role = new Role(101, "admin");

User a = new User(101, "vasia@mail.com");

// (int id, string email) = a;
// >>> EQUALS <<<
// a.Deconstruct(out int id, out string email);

(_, string email) = a;

class User
{
    private int id;
    private string email;

    public User(int id, string email)
    {
        this.id = id;
        this.email = email;
    }

    public void Deconstruct(out int id, out string email)
    {
        id = this.id;
        email = this.email;
    }
}


#endregion



