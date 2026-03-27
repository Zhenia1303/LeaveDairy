internal partial class Program
{
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

        public override string ToString()
        {
            return $"{this.Id}, {this.Name}";
        }
    }
}