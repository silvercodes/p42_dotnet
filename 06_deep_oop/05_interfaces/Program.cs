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






interface IRenderable
{
    public void Render();
}

class Shape: IRenderable
{
    public void Render() => Console.WriteLine("Shape.Render()");
}

class Rect : Shape, IRenderable
{
    public new void Render() => Console.WriteLine("Rect.Render()");
}



//
//



#endregion



