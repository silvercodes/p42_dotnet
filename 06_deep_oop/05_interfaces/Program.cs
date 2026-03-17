#region Intro

//interface IRenderable { }
//interface IMovable { }
//interface ILoggable { }
//interface ILogger { }
//interface IShape { }

// Интерфейсы могут содержать
// 1. Методы
// 2. Свойства
// 3. События
// 4. Индексаторы
// 5. Статика (константы) FROM C#8

//interface ILogger
//{
//    //public int val;       // ERROR
//    public const double PI = 3.1415;
//    public static int count = 0;
//    public void Log(string message);
//    public string Path { get; set; }
//}





//Shape a = new Shape();
//// a.Render();                 // !!! ERROR     НЕТ НАСЛЕДОВАНИЯ

//IRenderable b = new Shape();
//b.Render();

//IRenderable c = new Unit();
//c.Render();

//interface IRenderable
//{
//    private const double PI = 3.1415;
//    private static int count = 0;
//    private void Info()
//    {
//        Console.WriteLine("Info()");
//    }
//    public void Render()
//    {
//        Console.WriteLine("Render");
//        Console.WriteLine(count);
//        Info();
//    }
//    public int Ratio { get => 0; }
//    public double Factor => PI;
//    public int Count
//    {
//        get => IRenderable.count;
//        set => IRenderable.count = value < 0 ? 0 : value;
//    }
//}

//class Shape: IRenderable
//{

//}

//class Unit: IRenderable
//{
//    public void Render()
//    {
//        Console.WriteLine("Unit.Render()");
//    }
//}

#endregion


#region Practice


//Unit a = new Unit();
//a.Render();

//IRenderable b = new Unit();
//b.Render();

//IRenderable c = new Mesh();
//c.WriteLogs();

//IRenderable d = new Unit();
//d.WriteLogs();

//Mesh e = new Mesh();
//// e.WriteLogs();           // ERROR


//interface IRenderable
//{
//    public void Render();
//    public void WriteLogs()
//    {
//        Console.WriteLine("IRenderable.WriteLogs()");
//    }
//}

//class Unit : IRenderable
//{
//    public void Render()
//    {
//        Console.WriteLine("Unit.Render()");
//    }
//    public void WriteLogs()
//    {
//        Console.WriteLine("Unit.WriteLogs()");
//    }
//}

//class Mesh: IRenderable
//{
//    public void Render()
//    {
//        Console.WriteLine("Mesh.Render()");
//    }
//}


#endregion


#region Multiple implementation


////Db db = new Db();

////IWritable a = new Db();
////a.Write();
////IComparable b = new Db();
////b.Compare(null);

//IWritable iw = new Db();

//if (iw is IComparable ic)
//    ic.Compare(null);

//if (iw is Db db)
//    db.Compare(null);


//interface IWritable
//{
//    public void Write();
//}
//interface IComparable
//{
//    public bool Compare(object obj);
//}

//class Db : IWritable, IComparable
//{
//    public bool Compare(object? obj)
//    {
//        return true;
//    }

//    public void Write()
//    {
//        Console.WriteLine("Write to db...");
//    }
//    public void Save()
//    {
//        Console.WriteLine("db.Save()");
//    }
//}

#endregion


#region Explicit realization (явная реализация)

// Неявная реализация (Обычная, классическая, общая)
// 1. Когда методы интерфейсов не конфликтуют
// 2. Может быть переопределена в наследниках

// Явная реализация
// 1. Когда есть явные конфликты и неоднозначность в именах / сигнатурах
// 2. НЕ Может быть переопределена в наследниках


//Db db = new Db();
//db.Write();

//IWritable a = new Db();
//a.Write();

//ISaver b = new FileManager();
//b.Write();
//FileManager c = new FileManager();
//c.Write();

//IWritable d = new Db();
//d.Write();
//ISaver e = new Db();
//e.Write();


//Db db = new Db();

//((IWritable)db).Write();        // :-(

//if (db is IWritable wdb)        // :-)
//    wdb.Write();

//IWritable w = db;               // :-)
//w.Write();


//interface IWritable
//{
//    public void Write();
//}
//interface ISaver
//{
//    public void Write();
//}

//class Db : IWritable, ISaver
//{
//    // === Общая неявная реализация (одна на все интерфейсы)
//    // 1. Является членом класса
//    public void Write()
//    {
//        Console.WriteLine("Common relization");
//    }

//    // === Явная реализация
//    // 1. НЕ ЯВЛЯЮТСЯ ЧЛЕНАМИ КЛАССА!!!
//    // 2. Нельзя сделать public
//    void IWritable.Write()
//    {
//        Console.WriteLine("Db.IWritable.Write()");
//    }
//    void ISaver.Write()
//    {
//        Console.WriteLine("Db.ISaver.Write()");
//    }

//}

//class FileManager : ISaver
//{
//    public void Write()
//    {
//        Console.WriteLine("FileManager.Write()");
//    }
//    void ISaver.Write()
//    {
//        Console.WriteLine("FileManager.ISaver.Write()");
//    }
//}

#endregion


#region Interface with inheritance

//interface IRenderable
//{
//    public void Render();
//    public void Calc();
//    public void Update();
//}

//abstract class Shape: IRenderable
//{
//    public abstract void Render();
//    public virtual void Calc() => Console.WriteLine("Shape.Calc()");
//    public void Update() => Console.WriteLine("Shape.Update()");
//}

//class Rect: Shape
//{
//    public override void Render() => Console.WriteLine("Rect.Render()");
//    public override void Calc() => Console.WriteLine("Rect.Calc()");
//    public new void Update() => Console.WriteLine("Rect.Update()");
//}






//interface IRenderable
//{
//    public void Render();
//}

//class Shape: IRenderable
//{
//    public void Render() => Console.WriteLine("Shape.Render()");
//}

//class Rect : Shape, IRenderable
//{
//    public new void Render() => Console.WriteLine("Rect.Render()");
//}



//Rect a = new Rect();
//a.Render();                     // 2

//Shape b = new Rect();
//b.Render();                     // 1

//IRenderable c = new Rect();     // 3
//c.Render();

//IRenderable d = new Shape();    // 1
//d.Render();



//interface IRenderable
//{
//    public void Render();
//}

//class Shape : IRenderable
//{
//    public virtual void Render() => Console.WriteLine("1. Shape.Render()");
//}

//class Rect : Shape, IRenderable
//{
//    public new void Render() => Console.WriteLine("2. new Rect.Render()");
//    void IRenderable.Render() => Console.WriteLine("3. Explicit IRenderable.Render() from Rect");
//}

#endregion


#region Interfaces inheritance


//IWritable a = new FileManager();
//a.Write();                              // 6

//IFileSaver b = new FileManager();
//b.Write();                              // 7
//b.Save();                               // 8

//IWritable c = new FileManager();
//// c.Save();        // ERROR
//if (c is IFileSaver ifs)
//    ifs.Save();                         // 8

//if (c is FileManager fm)
//    fm.Save();                          // 4



//interface IWritable
//{
//    // public void Write();
//    public void Write() => Console.WriteLine("1. default Write() from IWritable");
//}

//interface IFileSaver: IWritable
//{
//    // public void Save();
//    public void Save() => Console.WriteLine("2. default save() from IFileSaver");
//    public new void Write() => Console.WriteLine("3. new Write from IFileSaver");
//}

//class FileManager : IFileSaver
//{
//    public void Save() => Console.WriteLine("4. FileManager.Save");

//    public void Write() => Console.WriteLine("5. FileManager.Write");

//    void IWritable.Write() => Console.WriteLine("6. Explicit FileManager.IWritable.Write");
//    void IFileSaver.Write() => Console.WriteLine("7. Explicit FileManager.IFileSaver.Write");
//    void IFileSaver.Save() => Console.WriteLine("8. Explicit FileManager.IFileSaver.Save");
//}

#endregion


#region Generic interface

//Author a = new Author("101");

//User<string> b = new Author("102");

//IAuthenticator<string> c = new Author("103");

//object d = new Author("104");

//interface IAuthenticator<T>
//{
//    public T Id { get; }
//}

//class User<T>: IAuthenticator<T>
//{
//    public T Id { get; }
//    public User(T id) => Id = id;
//}

//class Admin : IAuthenticator<string>
//{
//    public string Id { get; }
//    public Admin(string id) => Id = id;
//}

//class Author : User<string>
//{
//    public Author(string id) 
//        : base(id)
//    {}
//}

#endregion


#region IComparable / IComparable<T>

//List<int> nums = new List<int>() { 4, 7, 8, 2, 4, 6, 7, 9, 0 };
//nums.Sort();
//foreach(int num in nums)
//    Console.Write($"{num} ");
//Console.WriteLine();

//List<User> users = new List<User>()
//{
//    new User() {Id = 101, Email = "email1@mail.com", Age = 43},
//    new User() {Id = 102, Email = "email2@mail.com", Age = 21},
//    new User() {Id = 103, Email = "email3@mail.com", Age = 32},
//    new User() {Id = 104, Email = "email4@mail.com", Age = 20},
//};
//users.Sort();
//foreach (User u in users)
//    Console.WriteLine($"{u} ");
//Console.WriteLine();



//class User: IComparable
//{
//    public int Id { get; set; }
//    public string? Email { get; set; }
//    public int Age { get; set; }

//    public int CompareTo(object? obj)
//    {
//        // -1 || 0 || 1

//        if (obj is null)
//            throw new NullReferenceException();

//        if (obj is User u)
//            return u.Age - Age;

//        throw new ArgumentException();
//    }

//    public override string ToString()
//    {
//        return $"id: {Id}, email: {Email}, age: {Age}";
//    }
//}



//class User : IComparable<User>
//{
//    public int Id { get; set; }
//    public string? Email { get; set; }
//    public int Age { get; set; }

//    public int CompareTo(User? u)
//    {
//        // -1 || 0 || 1

//        if (u is null)
//            throw new NullReferenceException();

//        return Age - u.Age;
//    }

//    public override string ToString()
//    {
//        return $"id: {Id}, email: {Email}, age: {Age}";
//    }
//}





#endregion


#region IComparer / IComparer<T>

//List<User> users = new List<User>()
//{
//    new User() {Id = 101, Email = "email1@mail.com", Age = 43},
//    new User() {Id = 102, Email = "email2@mail.com", Age = 21},
//    new User() {Id = 103, Email = "email3@mail.com", Age = 32},
//    new User() {Id = 104, Email = "email4@mail.com", Age = 20},
//};

//users.Sort(new UserAgeComparer(Direction.Asc));
//foreach (User u in users)
//    Console.WriteLine($"{u} ");
//Console.WriteLine();


//class User
//{
//    public int Id { get; set; }
//    public string? Email { get; set; }
//    public int Age { get; set; }

//    public override string ToString()
//    {
//        return $"id: {Id}, email: {Email}, age: {Age}";
//    }
//}

//enum Direction
//{
//    Asc,
//    Desc,
//}
//class UserAgeComparer : IComparer<User>
//{
//    private Direction direction;
//    public UserAgeComparer(Direction direction = Direction.Asc)
//    {
//        this.direction = direction;
//    }

//    public int Compare(User? x, User? y)
//    {
//        if (x is null || y is null)
//            throw new NullReferenceException();

//        return direction == Direction.Asc ? x.Age - y.Age : y.Age - x.Age;
//    }
//}


#endregion


#region ICloneable

// ICloneable
// HW*

#endregion


#region *** invariance / covariance / contravariance

// ===== invariance =====

//List<Animal> animals = new List<Animal>();
//List<Dog> dogs = new List<Dog>();

//// animals = dogs;          ERROR
//// dogs = animals;          ERROR


//class Animal { }
//class Dog: Animal { }
//class Cat : Animal { }

//--------------

//MySqlManager manager = new MySqlManager();

//IConnectionManager<MySqlConnection> manager_0 = manager;

//IConnectionManager<MySqlConnection> manager_1 = new MySqlManager();

//// IConnectionManager<Connection> manager_2 = new MySqlManager();                           // ERROR

////List<IConnectionManager<Connection>> list = new List<IConnectionManager<Connection>>()    // ERROR
////{
////    new MySqlManager()
////};


//class Connection
//{
//    public string? Config { get; set; }
//    public Connection(string? config) => Config = config;
//}
//class MySqlConnection: Connection
//{
//    public MySqlConnection(string? config) : base(config)
//    {}
//}


//interface IConnectionManager<T>
//    where T: Connection
//{
//    public T CreateConnection(string? config);
//}

//class MySqlManager : IConnectionManager<MySqlConnection>
//{
//    public MySqlConnection CreateConnection(string? config)
//    {
//        return new MySqlConnection(config);
//    }
//}




// ===== covariance =====

//Animal[] animals = new Dog[10];         // :-|
//// animals[0] = new Cat();                 // RUNTIME ERROR

//class Animal { }
//class Dog : Animal { }
//class Cat : Animal { }




// --------------- ex 1

//MySqlManager manager_0 = new MySqlManager();

//IConnectionManager<MySqlConnection> manager_1 = new MySqlManager();

//IConnectionManager<Connection> manager_2 = new MySqlManager();
//Connection conn_1 = manager_2.CreateConnection("config 2 string");
//Console.WriteLine(conn_1.Config);

//IConnectionManager<Connection> manager_3 = new SqlServerManager();
//Connection conn_2 = manager_3.CreateConnection("config 3 string");
//Console.WriteLine(conn_2.Config);

//List<IConnectionManager<Connection>> list = new List<IConnectionManager<Connection>>()
//{
//    new MySqlManager(),
//    new SqlServerManager()
//};

//foreach(IConnectionManager<Connection> conn in list)
//    Console.WriteLine(conn.CreateConnection("main config").Config);


//class Connection
//{
//    public string? Config { get; set; }
//    public Connection(string? config) => Config = config;
//}
//class MySqlConnection : Connection
//{
//    public MySqlConnection(string? config) : base(config)
//    { }
//}
//class SqlServerConnection: Connection
//{
//    public SqlServerConnection(string? config) : base(config)
//    { }
//}


//interface IConnectionManager<out T>
//    where T : Connection
//{
//    public T CreateConnection(string? config);
//}

//class MySqlManager : IConnectionManager<MySqlConnection>
//{
//    public MySqlConnection CreateConnection(string? config)
//    {
//        return new MySqlConnection(config);
//    }
//}

//class SqlServerManager : IConnectionManager<SqlServerConnection>
//{
//    public SqlServerConnection CreateConnection(string? config)
//    {
//        return new SqlServerConnection(config);
//    }
//}




// ------------------- ex 2

//IUnitBuilder<Unit> a = new ArcherBuilder();
//IUnitBuilder<Unit> b = new AssasinBuilder();
//IUnitBuilder<Unit> c = new WarriorBuilder();



//class Unit
//{
//    public string Title { get; set; }
//    public int Hp { get; set; }
//    public Unit(string title, int hp)
//    {
//        Title = title;
//        Hp = hp;
//    }
//}

//class Archer : Unit
//{
//    public Archer(string title, int hp) : base(title, hp)
//    {}
//}
//class Assasin : Unit
//{
//    public Assasin(string title, int hp) : base(title, hp)
//    { }
//}
//class Warrior : Unit
//{
//    public Warrior(string title, int hp) : base(title, hp)
//    { }
//}


//interface IUnitBuilder<out T>
//{
//    T Build(string title, int hp);
//}

//class ArcherBuilder: IUnitBuilder<Archer>
//{
//    public Archer Build(string title, int hp)
//    {
//        return new Archer(title, hp);
//    }
//}
//class AssasinBuilder : IUnitBuilder<Assasin>
//{
//    public Assasin Build(string title, int hp)
//    {
//        return new Assasin(title, hp);
//    }
//}
//class WarriorBuilder : IUnitBuilder<Warrior>
//{
//    public Warrior Build(string title, int hp)
//    {
//        return new Warrior(title, hp);
//    }
//}


// ===== contravariance =====

// TODO: HOME

// ==========================

#endregion
