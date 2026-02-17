

#region Overloading
// 1. Имя должно совпадать
// 2. Другое кол-во параметров
// 3. Тип или порядок параметров
// 4. Модификаторы параметров

//class Container
//{
//    public void Method(int a, int b)
//    { }

//    public void Method(int a, int b, int c)
//    { }

//    public void Method(int a, string b)
//    { }

//    public void Method(ref int a, ref readonly int b)
//    { }
//}

#endregion


#region Static

User a = new User();
User b = new User();

Console.WriteLine($"{a.id} {b.id}");
Console.WriteLine($"MaxId = {User.MaxId}");
Console.WriteLine($"Count = {User.InstanceCount}");

class User
{
    // Статическое поле (НЕ является частью состояния объекта)
    private static int maxId;

    // обычное поле (является частью состояния объекта)
    public int id;

    // Статический конструктор (инициализирует статические поля и св-ва)
    // 1. Нельзя использовать модификатор доступа
    // 2. Нет this
    // 3. Нельзя вызвать явно (вызываетс автоматически при создании класса)
    static User()
    {
        MaxId = 100;
    }

    // Статический метод
    // 1. Нет this
    // 2. Можно использовать только статические поля и св-ва
    public static void ResetMaxId() => User.maxId = 0;

    // Статическое св-во
    public static int MaxId
    {
        get => User.maxId;
        set => User.maxId = value;
    }

    // Статическое автосв-во
    public static int InstanceCount { get; set; } = 0;

    // Обычный конструктор
    public User()
    {
        this.id = ++User.MaxId;
        User.InstanceCount++;
    }
}





#endregion

