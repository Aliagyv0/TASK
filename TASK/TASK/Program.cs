using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK
{
    internal class Program
    {
        static void Main(string args)
        {
            // Get user information
            Console.Write("adiniz: ");
            string firstName = Console.ReadLine();

            Console.Write("soyadiniz: ");
            string lastName = Console.ReadLine();

            Console.Write("cinsiyyetiniz: ");
            string gender = Console.ReadLine();

            Console.Write("dogum tarixiniz (YYYY-MM-DD): ");
            string birthDateString = Console.ReadLine();

            Console.Write("unvaniniz: ");
            string address = Console.ReadLine();

            // Parse date of birth
            DateTime birthDate;
            if (!DateTime.TryParseExact(birthDateString, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out birthDate))
            {
                Console.WriteLine("Invalid date format. Please enter your date of birth in the format YYYY-MM-DD.");
                return;
            }

            // Calculate age
            int age = DateTime.Now.Year - birthDate.Year;
            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
            {
                age--;
            }

            // Determine life period
            string lifePeriod;
            if (age < 12)
                lifePeriod = "usaqliq";
            else if (age < 18)
                lifePeriod = "yeniyetmelik";
            else if (age < 25)
                lifePeriod = "erken genclik";
            else if (age < 35)
                lifePeriod = "genclik";
            else if (age < 60)
                lifePeriod = "orta yas";
            else
                lifePeriod = "qocaliq";

            // Determine registration status
            Console.Write("qeydiyyatdan keçmisiz? (beli/xeyr): ");
            string registrationStatus = Console.ReadLine().ToLower();

            // Display the generated text
            Console.WriteLine($"siz indi {age} doğulduğunuz üçün yaşınız var {lastName}, {firstName}, {gender}, {birthDate.ToString("yyyy-MM-dd")}. Azərbaycan qanunvericiliyinə görə, siz öz həyatınızı yaşayırsınız {lifePeriod} dövrunuzu yasayirsiniz.Bu işə yalnız gənclər müraciət edə bilər . Bu xahişi nəzərə alaraq, sizin istəyinizdir{(registrationStatus == "beli" ? "qeydiyyatdan kecmisdir" : "qeydiyyatdan kecmemisdir")}");
        }
    }

    class program
    {
        static void Main()
        {
            // Get user information
            Console.Write("adiniz: ");
            string firstName = Console.ReadLine();

            Console.Write("soyadiniz: ");
            string lastName = Console.ReadLine();

            Console.Write("cinsiyyetiniz: ");
            string gender = Console.ReadLine();

            Console.Write("dogum tarixiniz (yyyy-MM-dd): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.Write("unvaniniz: ");
            string address = Console.ReadLine();

            // Calculate age
            int age = CalculateAge(birthDate);

            // Determine life period based on age
            string lifePeriod = GetLifePeriod(age);

            // Check eligibility for the job
            string registrationStatus = (age <= 30) ? "registered" : "not registered";

            // Display generated text
            Console.WriteLine($"siz indi {age} yaşınız var, çünki siz doğulmusunuz {lastName}, {firstName}, {gender}, {birthDate:yyyy-MM-dd}. Azərbaycan qanunvericiliyinə görə, siz öz  {lifePeriod} dovrunuzu yasayirsiniz.Bu işə yalnız gənclər müraciət edə bilər . Bu xahişi nəzərə alaraq, sizin istəyinizdir {registrationStatus}.");

            Console.ReadLine(); // Keep console window open
        }

        // Function to calculate age based on the birthdate
        static int CalculateAge(DateTime birthDate)
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - birthDate.Year;

            // Adjust age if birthday hasn't occurred yet this year
            if (currentDate.Month < birthDate.Month || (currentDate.Month == birthDate.Month && currentDate.Day < birthDate.Day))
            {
                age--;
            }

            return age;
        }

        // Function to determine life period based on age
        static string GetLifePeriod(int age)
        {
            if (age <= 12)
            {
                return "usaqliq";
            }
            else if (age <= 18)
            {
                return "yeniyetmelik";
            }
            else if (age <= 24)
            {
                return "erken genclik";
            }
            else if (age <= 35)
            {
                return "genclik";
            }
            else if (age <= 60)
            {
                return "orta yas";
            }
            else
            {
                return "qocaliq";
            }
        }
    }
}
    

