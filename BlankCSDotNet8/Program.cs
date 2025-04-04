namespace BlankCSDotNet8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime current = DateTime.Now;
            DateTime target = new DateTime(2025, 4, 4, 15, 15, 0);
            TimeSpan difference = target - current;
            Console.WriteLine(difference.ToString());
            while (true)
            {
                Console.WriteLine(difference.ToString());
                Thread.Sleep(1000);
            }
        }
    }
}
