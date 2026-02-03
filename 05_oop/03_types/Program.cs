
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

void Execute()
{
    Point a = new Point() { x = 2, y = 3 };
    Unit b = new Unit() { x = 20, y = 30 };

    Point c = a;
    Unit d = b;
}

Execute();

struct Point
{
    public int x;
    public int y;
}

class Unit
{
    public int x;
    public int y;
}





#endregion
