
namespace loanSystem
{
    class Program
    {
        static void Main (string[] args)
        {
            UserClass user = new UserClass("lol hansen", "123243435", "sdsd@sdsd.adsd", AdminClass.role.Admin);
            global::System.Console.WriteLine(  user.Role);
        }
    }
}
