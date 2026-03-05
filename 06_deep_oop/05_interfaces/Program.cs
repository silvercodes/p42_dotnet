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

interface ILogger
{
    //public int val;       // ERROR
    public const double PI = 3.1415;
    public static int count = 0;
    public void Log(string message);
    public string Path { get; set; }
}






#endregion
