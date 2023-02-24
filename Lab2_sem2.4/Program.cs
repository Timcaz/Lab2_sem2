namespace Lab2_sem2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> stringLengthDelegate = s => s.Length;
            List<string> strings = new List<string> { "фільм", "земля", "2003", "дивитись", "усім"};
            foreach (string s in strings)
            {
                int length = stringLengthDelegate(s);
                Console.WriteLine("{0} - {1} символів", s, length);
            }
        }
    }
}