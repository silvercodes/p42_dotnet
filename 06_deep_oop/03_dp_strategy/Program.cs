

//Archiver archiver = new Archiver(12);
//archiver.Strategy = new ZipStrategy();

//archiver.CreateArchive("project1.cs");
//archiver.CreateArchive("project2.cs");
//archiver.CreateArchive("project3.cs");

//archiver.Strategy = new RarStrategy();

//archiver.CreateArchive("project1.cs");
//archiver.CreateArchive("project2.cs");
//archiver.CreateArchive("project3.cs");

//archiver.Strategy = new DeflateStrategy();
//archiver.CreateArchive("project1.cs");
//archiver.CreateArchive("project2.cs");
//archiver.CreateArchive("project3.cs");



//abstract class Strategy
//{
//    public abstract void Compress(string filePath);
//    public abstract void Decompress(string filePath);
//}

//class ZipStrategy : Strategy
//{
//    public override void Compress(string filePath)
//    {
//        Console.WriteLine($"File {filePath} was compressed by ZIP");
//    }

//    public override void Decompress(string filePath)
//    {
//        Console.WriteLine($"File {filePath} was decompressed from ZIP");
//    }
//}

//class RarStrategy : Strategy
//{
//    public override void Compress(string filePath)
//    {
//        Console.WriteLine($"File {filePath} was compressed by RAR");
//    }

//    public override void Decompress(string filePath)
//    {
//        Console.WriteLine($"File {filePath} was decompressed from RAR");
//    }
//}

//class DeflateStrategy: Strategy
//{
//    public override void Compress(string filePath)
//    {
//        Console.WriteLine($"File {filePath} was compressed by DEFLATE");
//    }

//    public override void Decompress(string filePath)
//    {
//        Console.WriteLine($"File {filePath} was decompressed from DEFLATE");
//    }
//}


//class Archiver
//{
//    public int Level { get; set; }
//    public Strategy Strategy { get; set; }

//    public Archiver(int level)
//    {
//        Level = level;
//    }

//    public void CreateArchive(string filePath)
//    {
//        Strategy.Compress(filePath);
//    }
//}



// ===============================


abstract class Behavior
{
    public abstract void Animate();
    public abstract void Attack();
}

class LightBehavior : Behavior
{
    public override void Animate()
    {
        Console.WriteLine("LightBehavior.Animate()");
    }

    public override void Attack()
    {
        Console.WriteLine("LightBehavior.Attack()");
    }
}
class StrongBehavior : Behavior
{
    public override void Animate()
    {
        Console.WriteLine("StrongBehavior.Animate()");
    }

    public override void Attack()
    {
        Console.WriteLine("StrongBehavior.Attack()");
    }
}



class Bot
{
    public int Radius { get; set; }
    public int Speed { get; set; }
    public Behavior Behavior { get; set; }

    public void Activate()
    {
        Behavior.Animate();
        Behavior.Attack();
    }
}
