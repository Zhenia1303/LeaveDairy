using System.Diagnostics.Metrics;

internal class Program
{
    private static void Main(string[] args)
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
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        private static int Counter = 0;

        public static int GetCounter()
        {
            Console.WriteLine(Counter);
            return Counter;
        }

        public User()
        {
            Counter++;
        }
    }

    public class LeaveRequest
    {
        public int Id { get; set; }
        public string Who { get; set; } = string.Empty;
        public DateTime When { get; set; }

        public DateTime ComeBack { get; set; }
        public bool IsApproved { get; set; }
    }
}