using System;

namespace CsharpTrabalhandoComDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DateTime Principais Métodos
            var now = DateTime.Now;
            var today = DateTime.Today;

            var threeDaysAgo = today.AddDays(-3);
            var sixMonthsLater = today.AddMonths(6);
            var twoYearsLater = today.AddYears(2);

            var shortDate = now.ToShortDateString();
            var longDate = now.ToLongDateString();

            var shortTime = now.ToShortTimeString();
            var longTime = now.ToLongTimeString();

            var date = now.Date;
            var day = now.Day;
            var month = now.Month;
            var year = now.Year;
            var hour = now.Hour;
            var minute = now.Minute;
            var second = now.Second;

            var dayOfWeek = now.DayOfWeek;

            if (dayOfWeek == DayOfWeek.Saturday || dayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("É fim de semana!");
            }

            var dayOfYear = now.DayOfYear;

            #endregion DateTime Principais Métodos

            #region DateTime Formatação
            Console.WriteLine("Formatos: ");

            var formats = new string[] { "d", "D", "f", "F", "g", "G", "m", "o", "r", "s", "t", "T", "u", "U", "Y" };

            foreach (var format in formats)
            {
                Console.WriteLine("Data no Formato {0}: {1}", format, now.ToString(format));
                //Interpolação de string
                //Console.WriteLine($"Data no Formato {format}: {now.ToString(format)}");
            }

            Console.WriteLine("Diferente maneiras de formatar manualmente.");
            Console.WriteLine($"Data no Formato d: {now:d}");
            Console.WriteLine($"Data no Formato MM-dd-yyyy: {now:MM-dd-yyyy}");
            var dateFormat = now.ToString("MM-dd-yyyy");
            var dateFormatBr = now.ToString("dd/MM/yyyy");

            #endregion DateTime Formatação

            Console.ReadKey();
        }
    }
}
