
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






Admin admin = new Admin("vasia@mial.com", 34, "read");
admin.Render();


internal class User
{
    private string email = string.Empty;
    public string Email { get => email; set => email = value; }
    public int Age { get; set; }
    public User()
    { }
    public User(int age)
    {
        Age = age;
        Console.WriteLine("User(int age)");
    }
    public User(string email, int age):
        this(age)                                   // Делегирование
    {
        Email = email;
        Console.WriteLine("User(string email, int age)");
    }
    public void Render()
    {
        Console.WriteLine($"Email: {Email}");
    }
}

internal class Admin: User
{
    public string Permission { get; set; }
    public Admin(string email, int age, string permission):
        base(email, age)
    {
        Permission = permission;
        Console.WriteLine("Admin(string email, int age, string permission)");
    }
    public Admin(string permission)
    {
        Permission = permission;
    }
    public void Render()
    {
        base.Render();
        Console.WriteLine($"Email: {Email}");
    }

}

#endregion


