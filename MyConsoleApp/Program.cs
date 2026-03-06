internal class Program
{
    private static void Main(string[] args)
    {
        var user1 = new User();
        var user2 = new User();

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
    }

    public class LeaveRequest
    {
        public int Id { get; set; }
        public string Who { get; set; } = string.Empty;
        public DateTime When { get; set; }

        public string ComeBack { get; set; } = string.Empty;
        public bool IsApproved { get; set; }
    }
}