
#region Inheritance
// Ограничения

// 1. Только одиночное наследование

// 2. В терминах C++ наследование public

// 3. Модификатор класса-наследника ---> такой же или более строгий, чем у базового
//internal class A
//{ }
//public class B: A           // ERROR
//{ }

// 4. Клас можно сделать sealed (запечатанным) (в терминах C++ ---> финализированный)
//sealed class A
//{ }
//class B: A 
//{ }

// 5. Наследование от статического класса запрещено
//static class Tools
//{
//    static int level = 1;
//    static void Render() { }
//}
//class Manager: Tools            // ERROR
//{ }






//Admin admin = new Admin("vasia@mial.com", 34, "read");
//admin.Render();


//internal class User
//{
//    private string email = string.Empty;
//    public string Email { get => email; set => email = value; }
//    public int Age { get; set; }
//    public User()
//    { }
//    public User(int age)
//    {
//        Age = age;
//        Console.WriteLine("User(int age)");
//    }
//    public User(string email, int age):
//        this(age)                                   // Делегирование
//    {
//        Email = email;
//        Console.WriteLine("User(string email, int age)");
//    }
//    public void Render()
//    {
//        Console.WriteLine($"Email: {Email}");
//    }
//}

//internal class Admin: User
//{
//    public string Permission { get; set; }
//    public Admin(string email, int age, string permission):
//        base(email, age)
//    {
//        Permission = permission;
//        Console.WriteLine("Admin(string email, int age, string permission)");
//    }
//    public Admin(string permission)
//    {
//        Permission = permission;
//    }
//    public void Render()
//    {
//        base.Render();
//        Console.WriteLine($"Email: {Email}");
//    }

//}

#endregion


#region Type casting

// ====== upcasting (восходящее преобразование / "упаковка объекта" / обобщение)

//Warrior warrior = new Warrior(100, 300);

//Unit unit = warrior;                        // upcasting

//// Console.WriteLine(unit.Force);              // ERROR

//object obj = warrior;


// ====== downcasting (нисходящее преобразование / "распаковка объекта")

//Archer archer = new Archer(120, 30);
//Unit unit = archer;                         // upcasting

//Archer archer2 = (Archer)unit;
//Console.WriteLine(archer2.ArrCount);

//Unit u = new Archer(120, 30);
//Archer a = (Archer)u;

//object obj = new Warrior(100, 200);
//Unit u = (Unit)obj;
//Warrior w = (Warrior)obj;

//Archer a = (Archer)obj;         // FU FU FU ERROR


//Unit a = new Unit(100);
//object b = (object)a;
//// Archer c = (Archer)a;            // ERROR
//// Warrior d = (Warrior)a;           // ERROR



// ========= as / is ==========

//Unit u = new Archer(130, 20);

////Archer? a = u as Archer;            // NO EXCEPTION!!!
////a?.Render();

//if (u is Archer)
//    u.Render();

//if (u is Archer archer)
//    archer.ArrCount = 50;


//class Unit
//{
//    public int Hp { get; set; }
//    public Unit(int hp)
//    {
//        Hp = hp;
//    }

//    public void Render() => Console.WriteLine($"hp: {Hp}");
//}

//class Archer: Unit
//{
//    public int ArrCount { get; set; }
//    public Archer(int hp, int arrCount):
//        base(hp)
//    {
//        ArrCount = arrCount;
//    }
//}

//class Warrior : Unit
//{
//    public int Force { get; set; }
//    public Warrior(int hp, int force) :
//        base(hp)
//    {
//        Force = force;
//    }
//}

#endregion


#region virtual / override


//Student a = new Student(101);
//a.Show();
//User b = a;
//b.Show();


//Student a = new Student(101, 23);
//a.Age = 34;
//a.Show();
//a.Age = 15;
//a.Show();


using System.Runtime.InteropServices.Marshalling;

User b = new Student(101, 23);
b.Age = 34;
b.Show();
b.Age = 15;
b.Show();



class User
{
    public int Id { get; set; }
    public virtual int Age { get; set; }
    public User(int id, int age)
    {
        Id = id;
        Age = age;
    }

    public virtual void Show()
    {
        Console.WriteLine("User::Show()");
        Console.WriteLine($"id: {Id}, age: {Age}");
    }

    //public static virtual void Method()       // Не имеет смысла
    //{ 
    //}
}

class Student: User
{
    // public override int Age { get; set; }        // :-( (дублируется поле age....)
    public override int Age
    {
        get => base.Age;
        set
        {
            base.Age = value >= 18 ? value : 18;
        }
    }
    public Student(int id, int age) : 
        base(id, age)
    {}
    public override sealed void Show()
    {
        Console.WriteLine("Student::Show()");
        Console.WriteLine($"id: {Id}, age: {Age}");
    }
}

#endregion

