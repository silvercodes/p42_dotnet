//      C++                                 C#
// чистая виртуальная ф-ция         абстракный метод (является виртуальным)
// абстрактный класс                абстрактный класс
// интерфейсный класс               интерфейс

// Абстрктные члены классы
// 1. Методы
// 2. Свойства
// 3. Соытия
// 4. Индексаторы


//abstract class Unit
//{
//    public int Hp { get; protected set; }       // АВТОСВОЙСТВО
//    public abstract int Force { get; set; }     // НЕ АВТОСВОЙСТВО (поле не создаётся, разворачивается в 2 абстрактных метода)
//    public abstract int Points { get; set; }    // НЕ АВТОСВОЙСТВО (поле не создаётся, разворачивается в 2 абстрактных метода)
//    public abstract void Defence();
//    public virtual void Move()
//    {
//        Console.WriteLine("Unit Move()");
//    }
//    public void Attack()
//    {
//        Console.WriteLine("Unit Attack()");
//    }
//}

//class Warrior: Unit
//{
//    public override int Force { get; set; }     // АВТОСВОЙСТВО

//    private int points;
//    public override int Points
//    {
//        get => points;
//        set => points = value;
//    }
//    public override void Defence()
//    {
//        Console.WriteLine("Warrior Defence()");
//    }
//    public override void Move()
//    {
//        Console.WriteLine("Warrior Move()");
//    }
//}

//class SuperWarrior: Warrior
//{
//    public override void Defence()
//    {
//        Console.WriteLine("SuperWarrior Defence()");
//    }
//}


//abstract class Archer: Unit
//{

//}



// =========== Object class virtual methods

object p = new Product()
{
    Id = 101,
    Title = "Apple"
};

Console.WriteLine(p);

class Product
{
    public int Id { get; set; }
    public string Title { get; set; } = "no_title";

    public override string ToString()
    {
        return $"id: {Id}, title: {Title}";
    }
}
