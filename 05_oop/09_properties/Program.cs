
#region Intro

//User a = new User();
//a.Id = 101;
//Console.WriteLine(a.Id);

//a.Id = -2;

//class User
//{
//    private int id;
//    private string email;

//    public int Id
//    {
//        get
//        {
//            return id;
//        }
//        set
//        {
//            id = value < 0 ? 0 : value;
//        }
//    }

//    public string Email
//    {
//        get
//        {
//            return email;
//        }
//        set
//        {
//            email = value;
//        }
//    }

//    public void Render() => Console.WriteLine($"{Id}\t{Email}");
//}

#endregion


#region Partial properties

//User user = new User();

//user.Email = "vasia@mail.com";
////Console.WriteLine(user.Email);      // ERROR

////user.Id = 101;                          // ERROR
//Console.WriteLine(user.Id);

//Console.WriteLine(user.Info);



//class User
//{
//    private int id;
//    private string email;

//    public int Id
//    {
//        get
//        {
//            return id;
//        }
//    }

//    public string Email
//    {
//        set
//        {
//            email = value;
//        }
//    }

//    public string Info
//    {
//        get
//        {
//            return $"INFO: ID: {id}, EMAIL: {email}";
//        }
//    }

//    public void Render() => Console.WriteLine($"{Id}\t{email}");
//}


#endregion


#region modificators

//Console.WriteLine();

//class User
//{
//    private string email = "no_email";
//    private int age = 0;

//    public string Email
//    {
//        get
//        {
//            return email;
//        }
//        protected set           // Модификатор блока должен быть более строгим (ограничивающим)
//        {
//            email = value;
//        }
//    }

//    //public int Age              // ERROR (модификатор блока только у полного св-сва)
//    //{
//    //    private get                 
//    //    {
//    //        return age;
//    //    }
//    //}
// }

#endregion


#region AutoProperties

//Console.WriteLine();
//class User
//{
//    public int Id { get; set; }     // auto prop
//    public int Age { get; } = 18;
//    public string Name { get; private set; }
//    public string Password { get; set; } = "no_password";

//    public User(int age)
//    {
//        Age = age;
//    }
//    public void Execute()
//    {
//        // Age = 23;               // ERROR
//    }

//}

#endregion


#region init block

//User user1 = new();
//User user2 = new("vasia@mail.com");
//User user3 = new() { Email = "petya@mail.com" };
//User user4 = new() { Username = "chack_norris" };

//class User
//{
//    private string username;
//    public string Email { get; set; } = "no_email";
//    public string Username
//    {
//        get
//        {
//            return username;
//        }
//        init        // Можно использовать в: определение дефолтного значения, конструкторе, инициализаторе
//        {
//            username = value;
//            Email = $"{username}@mail.com";
//        }
//    }

//    public string Role { get; init; } = "guest";

//    public string Password { get; } = "no_password";

//    public User()
//    { }
//    public User(string email)
//    {
//        Username = "const_default_username";
//    }
//}

#endregion


#region Practice

//// User a = new() { Id = 303 };    // ERROR
//// User b = new() { Email = "no_email" };
//User c = new() { Password = "password" };
//// User d = new() { Level = 14 };   // ERROR
//class User
//{
//    private int Id { get; } = 101;
//    public string Email { get; private set; } = "vasia@mail.com";
//    public string Password { private get; init; } = "123123123";
//    public int Level { get; private init; } = 10;
//    public User()
//    {
//        Id = 202;
//        Email = "petya@mail.com";
//        Password = "56756567567";
//        Level = 12;
//    }
//}

#endregion


#region BUNS :-)

//class User
//{
//    private string email;
//    private string password;

//    public string Email
//    {
//        get => email;
//        set => email = value;
//    }

//    //public string Password
//    //{
//    //    get => password;
//    //}
//    // >>> EQUALS <<<
//    public string Password => password;
//}

#endregion


#region required

//User a = new User();                    // ERROR

//User b = new User("vasia@mail.com");    // ERROR

//User c = new User("petya@mail.com")     // ERROR
//{
//    Age = 23,
//};

//User d = new User("petya@mail.com")
//{
//    Age = 23,
//    Email = "chack@mail.com",
//};

//class User
//{
//    public required int Age { get; set; }
//    public required string Email { get; set; }
//    public User()
//    { }
//    public User(string email)
//    {
//        Email = email;
//    }
//}

#endregion


#region field   FROM C#14

//class User
//{
//    private int id;
//    public int Id 
//    { 
//        get => id; 
//        set => id = value < 0 ? 0 : value ;
//    }



//    public string Email
//    {
//        get => field;
//        set => field = value;
//    }
//}

#endregion


