
// Значимые типы
// 1. Все целочисленные примитивные типы
// 2. Все типы с плавающей запятой
// 3. bool
// 4. enum
// 5. char
// 6. struct   <--- !

// Ссылочные типы
// Классы (string, object.....)
// Интерфейсы
// Делегат


//Unit a = new Unit();
//object b = new Unit();

//class Unit
//{
//    public void Render()
//    { }
//}



#region EXAMPLE_1

//void Execute()
//{
//    Point a = new Point() { x = 2, y = 3 };
//    Unit b = new Unit() { x = 20, y = 30 };

//    Point c = a;
//    Unit d = b;
//}

//Execute();

//struct Point
//{
//    public int x;
//    public int y;
//}

//class Unit
//{
//    public int x;
//    public int y;
//}

#endregion


#region EXAMPLE_2

//void Execute()
//{
//    Role a = new Role() { id = 101, level = 3 };
//    User b = new User() { id = 202, role = new Role() { id = 102, level = 2 } };

//    Role c = a;
//    User d = b;
//}

//Execute();

//struct Role
//{
//    public int id;        
//    public int level;         
//}

//class User
//{
//    public int id;
//    public Role role;
//}

#endregion


#region EXAMPLE_3

//void Execute()
//{
//    Role a = new Role();
//    User b = new User();

//    Role c = a;
//    User d = b;
//}

//class Role
//{
//    public int id;
//    public int level;
//}

//struct User
//{
//    public int id;
//    public Role role;
//}

#endregion


#region EXAMPLE_4

//void Execute()
//{
//    Data data = new Data()
//    {
//        payload = new Payload()
//        {
//            protocol = new Protocol()
//            {
//                title = "HTTP"
//            }
//        }
//    };
//}

//class Protocol
//{
//    public string title;
//}
//class Payload
//{
//    public Protocol protocol;
//}
//struct Data
//{
//    public Payload payload;
//}

#endregion


#region Practice

//void Func1(Role role)
//{ }

//void Func2(ref Role role)
//{ }

//void Func3(User user)
//{ }

//void Func4(ref User user)
//{ }




//Role role = new Role();
//User user = new User();

//Func1(role);
//Func2(ref role);
//Func3(user);
//Func4(ref user);


//class Role
//{ }

//struct User
//{ }

#endregion


#region EXAMPLE_5

void Method1(Point p)
{
    p.x = 100;

    p = new Point(20, 30);      // Создаётся новый объект Point под локальную ссылку p
}

void Method2(ref Point p)
{
    p.x = 100;

    p = new Point(20, 30);
}

Point a = new Point(1, 1);
a.Render();

//Method1(a);
//a.Render();

Method2(ref a);
a.Render();

class Point
{
    public int x;
    public int y;
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void Render()
    {
        Console.WriteLine($"Point: ({x};{y})");
    }
}

#endregion

