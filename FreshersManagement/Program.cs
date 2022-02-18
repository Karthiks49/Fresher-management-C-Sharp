using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace FreshersManagement
{
	public class Program
	{
        private static Program program = new Program();
        public static void Main(String[] args)
		{
            bool isValid = false;
            Console.WriteLine("!!!   FRESHER'S MANAGEMENT   !!!\n\nChoose any option:");
            do
            {
                Console.WriteLine("\n1.Create    2.View    3.Search    4.Exit");
                try
                {
                    int option = Convert.ToInt16(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            program.Create();
                            break;
                        case 2:
                            program.View();
                            break;
                        case 3:
                            program.Search();
                            break;
                        case 4:
                            isValid = true;
                            break;
                        default:
                            Console.WriteLine("\n*** Select given options ***\n");
                            break;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("\n*** Enter valid number ***\n");
                }

            } while (!isValid);
        }

        private void Create()
        {
            bool isValid = false;

            do
            {
                Console.WriteLine("\nEnter number of freshers to add: ");
                try
                {
                    int fresherstotal = int.Parse(Console.ReadLine());
                    program.AddDetails(fresherstotal);
                    isValid = true;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("\n*** Enter valid number ***\n");
                }

            } while (!isValid);
        }

        private void AddDetails(int total)
        {
            string name;
            string dateOfBirth;
            DateOnly date;
            long mobileNumber;
            string address;
            int count = 1;

            string filePath = @"C:\Text\text.txt";
            List<Fresher> freshersList = new List<Fresher>();


            for (int i = 0; i < total; i++)
        	{
        		Console.Write("\nDetails of Fresher {0}:\nName: ", count);
        		name = Console.ReadLine();
                date = GetAge();
                
        		Console.Write("Mobile number: ");
        		mobileNumber = long.Parse(Console.ReadLine());
        		Console.Write("Address: ");
        		address = Console.ReadLine();

                Fresher fresher = new Fresher(name, date, mobileNumber, address);

                freshersList.Add(fresher);

                count++;

            }
            FileStream fileStream = new FileStream(@"C:\Text\text.txt", FileMode.Append);
            StreamWriter streamWriter = new StreamWriter(fileStream);

            foreach (var candidate in freshersList)
            {
                streamWriter.WriteLine(candidate);
            }
            streamWriter.Close();
            fileStream.Close();
        }

        public void View()
        {
            FileStream fileStream = new FileStream(@"C:\Text\text.txt", FileMode.OpenOrCreate);
            StreamReader streamReader = new StreamReader(fileStream);
            string freshersList = "";
            while ((freshersList = streamReader.ReadLine()) != null) {
                string[] fresherList = freshersList.Split("\n");


                foreach (string fresher in fresherList)
                {

                    string[] field = fresher.Split(", ");
                    DateOnly dateOfBirth = DateOnly.Parse(field[1]);
                    int age = CalculateAge(dateOfBirth.Year);

                    Console.WriteLine("\nName: {0}\nDate of birth: {1}\nAge: {2}\nMobile number: {3}\nAddress: {4}\n"
                        , field[0], field[1], age, field[2], field[3]);
                }
            }

            streamReader.Close();
            fileStream.Close();
        }

        private DateOnly GetAge()
        {
            bool isAgeValid = false;
            DateOnly date;
            do
            {
                Console.Write("Date of birth: ");
                string dateOfBirth = Console.ReadLine();
                date = DateOnly.Parse(dateOfBirth);
                int age = CalculateAge(date.Year);
                if (age < 18)
                {
                    Console.WriteLine("\n*** Candidate age is {0}. Minimum age requirement is above 18 ***\n", age);
                    
                } else
                {
                    isAgeValid = true;
                }
            } while (!isAgeValid);
            return date;
        }

        private int CalculateAge(int year)
        {
            DateTime currentDate = DateTime.Today;
            int currentYear = currentDate.Year;
            int age = (currentYear - year);
            return age;
        }

        private void Search()
        {
            Console.Write("\nEnter first letter of name: ");
            string nameFirstLetter = Console.ReadLine();
            Console.WriteLine();
            FileStream fileStream = new FileStream(@"C:\Text\text.txt", FileMode.OpenOrCreate);
            StreamReader streamReader = new StreamReader(fileStream);
            bool isFound = false;
            string freshersList = "";
            while ((freshersList = streamReader.ReadLine()) != null)
            {
                string[] fresherList = freshersList.Split("\n");
                
                foreach (string fresher in fresherList)
                {
                    string[] field = fresher.Split(", ");
                    for (int i = 0; i < fresher.Length; i++)
                    {
                        if (fresher[i].ToString().Equals(nameFirstLetter.ToUpper()))
                        {
                            Console.WriteLine("\nName: {0}\nDate of birth: {1}\nMobile number: {2}\nAddress: {3}\n"
                                               , field[0], field[1], field[2], field[3]);
                            isFound = true;
                            break;
                        }
                    }
                }
            }

            if (!isFound)
            {
                Console.WriteLine("\n*** NOT FOUND ***");
            }

            streamReader.Close();
            fileStream.Close();
        }

    }
}


