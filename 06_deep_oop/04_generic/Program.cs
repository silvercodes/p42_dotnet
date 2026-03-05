
#region Generic class

//User<int> a = new User<int>();
//User<string> b = new User<string>();

//User<int>.maxId = 100;
//User<string>.maxId = "200";
//Console.WriteLine(User<int>.maxId);

//class User<T>
//{
//    public static T maxId;
//    public T Id { get; set; }
//    public string Email { get; set; }
//}


// ====== generic in outher generic ======


//Role<int> role = new Role<int>();

//User<string, Role<int>> user = new User<string, Role<int>>()
//{
//    Role = new Role<int>()
//};

//class Role<T>
//{
//    public T Id { get; set; }
//    public string Title { get; set; }
//}

//class User<K, T>
//{
//    public K Id { get; set; }
//    public string? Email { get; set; }
//    public required T Role { get; set; }
//}

#endregion


#region Generic methods

//Logger.Execute<int>(34);
//Logger.Execute<Entry>(new Entry() { Data = "JSON_MODIFY data" });

//class Entry
//{
//    public string Data { get; set; }
//    public override string ToString()
//    {
//        return $"Data: {Data}";
//    }
//}

//class Logger
//{
//    //
//    //
//    //
//    public static void Execute<T>(T val)
//    {
//        Console.WriteLine(val);
//    }
//}

#endregion



#region Generic methods constraints

//Archer a = new Archer(100);
//Renderer.Render<Unit>(a);
//Renderer.Render<Archer>(a);


//class Unit
//{
//    public int Hp { get; set; }
//    public Unit(int hp) => Hp = hp;
//}
//class Warrior: Unit
//{
//    public Warrior(int hp) : base(hp)
//    {}
//}
//class Archer : Unit
//{
//    public Archer(int hp) : base(hp)
//    { }
//}


////// ===== via type checking          :-|
////class Renderer
////{
////    public static void Render<T>(T obj)
////    {
////        if (obj is Unit u)
////            Console.WriteLine($"Renderer: {u.Hp}");
////    }
////}


//// ===== via constraints          :-)))
//class Renderer
//{
//    public static void Render<T>(T obj)
//        where T : Unit
//    {
//        Console.WriteLine($"Renderer: {obj.Hp}");
//    }
//}

#endregion


#region Generic constraints types

// where T : s1, s2, s3

// === s1 ===
// Конкретный класс
//      или
// class
//      или
// struct

// === s2 ===
// Конкретный интерфейс

// === s3 ===
// new()


//class Document
//{
//    public int Id { get; set; }
//    public Document(int id) => Id = id;
//    public Document() 
//    { }
//}

//class Logger<T>
//    // where T : Document
//    // where T : class
//    // where T : struct
//    where T : class, new()
//{
//    public void Execute()
//    {
//        T obj = new T();
//    }
//}

//class Compressor<T, K>
//    where T : class
//    where K : Logger<Document>
//{}

#endregion


#region Inheritance




class Identity
{
    public Identity()
    { }
}

class Unit<T>
    where T: new()
{
    public T Id { get; set; }
    public Unit(T id) => Id = id;
}

// ----- 1. Обобщённый наследник с тем же типом ----
//class Archer<K> : Unit<K>
//    where K : new()
//{
//    public Archer(K id)
//        : base(id)
//    {}
//}
//Unit<Identity> u = new Unit<Identity>(new Identity());
//Archer<Identity> a = new Archer<Identity>(new Identity());
//Unit<Identity> b = new Archer<Identity>(new Identity());

// ----- 2. Обычный (необобщённый) наследник
//class Warrior: Unit<Identity>
//{
//    public Warrior(Identity id) : base(id)
//    {}
//}
//Warrior a = new Warrior(new Identity());
//Unit<Identity> b = new Warrior(new Identity());

// ----- 3. Обобщённый наследник с собственным типом
//class Archer<T> : Unit<Identity>
//{
//    public T? Value { get; set; }
//    public Archer(Identity id):
//        base(id)
//    { }
//}
//Archer<string> a = new Archer<string>(new Identity());
//Unit<Identity> b = new Archer<string>(new Identity());
//Unit<Identity> c = new Archer<int>(new Identity());
//Unit<Identity> d = new Archer<bool>(new Identity());

// ----- 4. Сочетание вариантов
//class Archer<T, K>: Unit<K>
//    where K : new()
//{
//    public Archer(K id)
//        : base(id) 
//    { }
//}
//Archer<int, Identity> a = new Archer<int, Identity>(new Identity());

#endregion
