
#region Intro

User user = new User();
user.id = 101;
user.email = "vasia@mail.com";

user.Render();




class User
{
    public int id;
    public string email;

    public void Render()
    {
        Console.WriteLine($"User info: {id} --> {email}");
    }
}



#endregion


