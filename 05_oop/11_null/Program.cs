
//string? name = null;

//string? input = Console.ReadLine();


//void Render(string? str)
//{
//    if (str ==null)
//        Console.WriteLine("NULL !!!");
//    else
//        Console.WriteLine(str);
//}

//string? input = null;
//Render(input);



//void Render(string str)
//{
//    Console.WriteLine(str.ToLower());
//}

//string? input = null;
//Render(input);





//int t = 34;

//int? k = null;          // Nullable<int> k = null




// ======= null guard =======

//void Render(string? message)
//{
//    //if (message == null)
//    //    return;
//    //Console.WriteLine(message);



//    //if (message is null)
//    //    return;
//    //Console.WriteLine(message);



//    //if (message is not null)
//    //    Console.WriteLine(message);


//    if (message is string)
//        Console.WriteLine(message);
//}




// ====== null union =======

//Console.Write("Enter your name: ");

//// 1.
////string? input = Console.ReadLine();
////string value = input ?? "no_name";

//// 2.
//// string value = Console.ReadLine() ?? "no_name";

//// 3.
//string? input = Console.ReadLine();
//input ??= "no_name";                    // EQUALS     input = input ?? "no_name"


//Console.WriteLine($"Hello {input}");




// ====== Условный null ======

//void Process(User? user)
//{
//    //if (user is not null && user.Role is not null && user.Role.Title is not null)
//    //    user.Role.Render();

//    user?.Role?.Render();
//}

//class Role
//{
//    public string? Title { get; set; }
//    public void Render() => Console.WriteLine($"Title = {Title}");
//}

//class User
//{
//    public Role? Role { get; set; }
//}




// ======= null-forgiven =======


//class User
//{
//    public string Email { get; set; } = null!;     
//}



//string? input = null;

//Render(input!);

//void Render(string message)
//{
//    Console.WriteLine(message);
//}






//#nullable disable
//string value = null;
//#nullable enable

//string? value2 = null;


