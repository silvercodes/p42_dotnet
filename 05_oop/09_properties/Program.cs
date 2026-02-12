
#region Intro

//User a = new User();
//a.Id = 101;
//Console.WriteLine(a.Id);

//a.Id = -2;

//class User
//{
//    private int id;
//    private string email;

//    public int Id
//    {
//        get
//        {
//            return id;
//        }
//        set
//        {
//            id = value < 0 ? 0 : value;
//        }
//    }

//    public string Email
//    {
//        get
//        {
//            return email;
//        }
//        set
//        {
//            email = value;
//        }
//    }

//    public void Render() => Console.WriteLine($"{Id}\t{Email}");
//}

#endregion


#region Partial properties

//User user = new User();

//user.Email = "vasia@mail.com";
////Console.WriteLine(user.Email);      // ERROR

////user.Id = 101;                          // ERROR
//Console.WriteLine(user.Id);

//Console.WriteLine(user.Info);



//class User
//{
//    private int id;
//    private string email;

//    public int Id
//    {
//        get
//        {
//            return id;
//        }
//    }

//    public string Email
//    {
//        set
//        {
//            email = value;
//        }
//    }

//    public string Info
//    {
//        get
//        {
//            return $"INFO: ID: {id}, EMAIL: {email}";
//        }
//    }

//    public void Render() => Console.WriteLine($"{Id}\t{email}");
//}


#endregion


#region modificators

//Console.WriteLine();

//class User
//{
//    private string email = "no_email";
//    private int age = 0;

//    public string Email
//    {
//        get
//        {
//            return email;
//        }
//        protected set           // Модификатор блока должен быть более строгим (ограничивающим)
//        {
//            email = value;
//        }
//    }

//    //public int Age              // ERROR (модификатор блока только у полного св-сва)
//    //{
//    //    private get                 
//    //    {
//    //        return age;
//    //    }
//    //}
// }

#endregion


#region AutoProperties
Console.WriteLine();
class User
{
    public int Id { get; set; }     // auto prop
    public int Age { get; } = 18;
	


}


#endregion
