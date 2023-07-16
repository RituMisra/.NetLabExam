namespace DaysOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = new string[]
             {
            "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"
             };

            var daysQuery = from day in daysOfWeek
                            select day;

            foreach (var day in daysQuery)
            {
                Console.WriteLine(day);
            }
        }
}
}