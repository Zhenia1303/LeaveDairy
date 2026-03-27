using System.Diagnostics.Metrics;

internal partial class Program
{
    public static void Main(string[] args)
    {;
        User.GetCounter();
        var user1 = new User();
        User.GetCounter();
        var user2 = new User();
        User.GetCounter();

        var request = new LeaveRequest();

        user1.Id = 1;
        user2.Id = 2;
        user1.Name = "Yevhenii";
        user2.Name = "Arsenii";

        Console.WriteLine($"{user1.Id}, {user1.Name}");
        Console.WriteLine($"{user2.Id}, {user2.Name}");


        
    }
}