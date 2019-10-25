using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module1assignment
{
    
    class Program
    {
        //enum declarations
       public enum days
        {
            //enum data members 
            Saturday,
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday
        }

        static void Main(string[] args)
        {
           
            showTheEntryTime();
            SetTheWeek();
            GetStudentInformation();
            GetTeacherInformation();
            GetCourseInformation();



        }
        public static void SetTheWeek()
        {
            //finding the day
            DayOfWeek week = DateTime.Today.DayOfWeek;
            //comparing with enum 
            if (week == DayOfWeek.Saturday)
            {
                Console.WriteLine("Hola, Feliz sabado");
                Console.ReadKey();
            }
            else if(week == DayOfWeek.Sunday)
            {
                //Today is sunday
                Console.WriteLine("Bonjour, Aujourd'hui est dimanche");
                Console.ReadKey();
            }
            else if (week == DayOfWeek.Monday)
            {
                //happy monday
                Console.WriteLine("Salve, Felice lunedi");
                Console.ReadKey();
            }
            else if (week == DayOfWeek.Tuesday)
            {
                //Happy Tuesday
                Console.WriteLine("Konnichiwa,haengboghan hwayoil");
                Console.ReadKey();
            }
            else if (week == DayOfWeek.Wednesday)
            {
                //happy Wednesday
                Console.WriteLine("Guten Tag, Schonen Mittwoch");
                Console.ReadKey();
            }
            else if (week == DayOfWeek.Thursday)
            {
                //Today is sunday
                Console.WriteLine("Merhaba, Bugun persembe");
                Console.ReadKey();
            }
            else if (week == DayOfWeek.Friday)
            {
                //Today is sunday
                Console.WriteLine("Hola;Viernes,felices fiestas");
                Console.ReadKey();
            }
        }

        static void showTheEntryTime()
        {
            DateTime datetime = DateTime.Now;
            //DayOfWeek week = DateTime.Today.DayOfWeek;
            Console.WriteLine("The entry time is: {0}", datetime);
            //Console.WriteLine(week);
            Console.ReadKey();

        }

        static void GetStudentInformation()
        {

            Console.WriteLine("----Student Information ----");
            Console.WriteLine("Enter the Student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the Student's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the Student's birthdate (DD/MM/YYYY): ");
            string date = Console.ReadLine();
            DateTime birthday = validateLeagalAge(date);
            DateTime birthDate = Convert.ToDateTime(birthday);
            Console.WriteLine("Enter your Address: ");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter your city: ");
            string City = Console.ReadLine();
            Console.WriteLine("Enter your state/province: ");
            string State = Console.ReadLine();
            Console.WriteLine("Enter your zip/Postal Code: ");
            string Zip = Console.ReadLine();
            Console.WriteLine("Enter your Country name: ");
            string CountryName = Console.ReadLine();

            bool isStudent = true;
            string isThisAstudent;
            if(isStudent)
            {
                isThisAstudent = "Student";
            }
            else
            {
                isThisAstudent = "Teacher";
            }

            int count = 01;
            string formatRandomIDCardNumber = string.Format("ID{0:00000000}", count);

            PrintStudentDetails(isThisAstudent, count, firstName, lastName, birthDate, Address, City, State,Zip,CountryName);

        }

        static void PrintStudentDetails(string isThisAstudent, int count, string firstName, string lastName, DateTime birthDate, string Address, string City, string State, string Zip, string CountryName)
        {
            Console.WriteLine("\r\n{0} Name: {1} {2}\r\nID number: {3}\r\nwas born in {4}\r\nAddress is {5}\r\nCity Name is {6}\r\nState is {7}\r\nZipcode is {8}\r\nCountry Name {9}", isThisAstudent, firstName, lastName, count, birthDate.Year, Address, City, State, Zip, CountryName);
            Console.ReadKey();
        }

        static void GetTeacherInformation()
        {

            Console.WriteLine("----Teacher Information ----");
            Console.WriteLine("Teacher's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the Teacher's last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the Teacher's birthdate (DD/MM/YYYY): ");
            string date = Console.ReadLine();
            DateTime birthday = validateLeagalAge(date);
            DateTime birthDate = Convert.ToDateTime(birthday);
            Console.WriteLine("Enter your Address: ");
            string Address = Console.ReadLine();
            Console.WriteLine("Enter your city: ");
            string City = Console.ReadLine();
            Console.WriteLine("Enter your state/province: ");
            string State = Console.ReadLine();
            Console.WriteLine("Enter your zip/Postal Code: ");
            string Zip = Console.ReadLine();
            Console.WriteLine("Enter your Country name: ");
            string CountryName = Console.ReadLine();

            bool isStudent = true;
            string isThisAstudent;
            if (isStudent)
            {
                isThisAstudent = "Student";
            }
            else
            {
                isThisAstudent = "Teacher";
            }

            PrintTeacherDetails(isThisAstudent, firstName, lastName, birthDate, Address, City, State, Zip, CountryName);

        }

        static void PrintTeacherDetails(string isThisAstudent,string firstName, string lastName, DateTime birthDate, string Address, string City, string State, string Zip, string CountryName)
        {
            Console.WriteLine("\r\n{0} Name: {1} {2}\r\nwas born in {3}\r\nAddress is {4}\r\nCity Name is {5}\r\nState is {6}\r\nZipcode is {7}\r\nCountry Name {8}", isThisAstudent, firstName, lastName, birthDate.Year, Address, City, State, Zip, CountryName);
            Console.ReadKey();
        } 

        static void GetCourseInformation()
        {
            //Get course information input form the user
            Console.WriteLine("---Course Information---");
            Console.WriteLine("Enter the Program name: ");
            string ProgramName = Console.ReadLine();

            switch (ProgramName)
            {
                case "CSE":
                    Console.WriteLine("CSE and You have in toal 148 Credits including internship");
                    break;

                case "CSSE":
                    Console.WriteLine("CSSE and You have total 142 Credits including internship");
                    break;

                case "EEE":
                    Console.WriteLine("EEE and You have in total 145 Credits and no internship required");
                    break;

                case "BBA":
                    Console.WriteLine("BBA and You have 123 Credits");
                    break;
                default:
                    Console.WriteLine("Invalid Course Selection");
                    break;

            }
            Console.WriteLine("You are enrolled in {0} ", ProgramName);
            Console.ReadKey();
            Console.WriteLine("Enter the Course Name: ");
            string CourseName = Console.ReadLine();
            Console.WriteLine("Enter the number of credits you have completed successfully:  ");
            int courseCreditsCompleted = Convert.ToInt16(Console.ReadLine());

            int TotalcreditsinCSE = 148;
            int TotalcreditsinEEE = 145;
            int TotalcreditsinCSSE = 142;
            int TotalcreditsinBBA = 123;
            int RemainingCourseCredits = 0;

            if(ProgramName == "CSE")
            {
                RemainingCourseCredits = TotalcreditsinCSE - courseCreditsCompleted;
                Console.WriteLine("Your Remaining Course credit to be Completed is: {0}", Convert.ToInt16(RemainingCourseCredits));
                Console.ReadKey();
            }
            else if(ProgramName == "CSSE")
            {
                RemainingCourseCredits = TotalcreditsinCSSE - courseCreditsCompleted;
                Console.WriteLine("Your Remaining Course credit to be Completed is: {0}", Convert.ToInt16(RemainingCourseCredits));
                Console.ReadKey();
            }
            else if (ProgramName == "EEE")
            {
                RemainingCourseCredits = TotalcreditsinEEE - courseCreditsCompleted;
                Console.WriteLine("Your Remaining Course credit to be Completed is: {0}", Convert.ToInt16(RemainingCourseCredits));
                Console.ReadKey();
            }
            else if (ProgramName == "BBA")
            {
                RemainingCourseCredits = TotalcreditsinBBA - courseCreditsCompleted;
                Console.WriteLine("Your Remaining Course credit to be Completed is: {0}", Convert.ToInt16(RemainingCourseCredits));
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Invalid Course information");
                Console.ReadKey();
            }

           

            Console.WriteLine("Enter your Department Head Name: ");
            string DepartmentheadName = Console.ReadLine();

            PrintCourseDetails(ProgramName, CourseName, courseCreditsCompleted, RemainingCourseCredits, DepartmentheadName);


        }

        static void PrintCourseDetails(string ProgramName, string CourseName, int courseCreditsCompleted, int RemainingCourseCredits, string DepartmentheadName)
        {
            Console.WriteLine("\r\nProgram Name: {0}\r\nCourse Name: {1}\r\nTotal Credits Completed in the course: {2}\r\nTotal Remaining credits: {3}\r\nThe name of the department head: {4}\r\n", ProgramName, CourseName, courseCreditsCompleted, RemainingCourseCredits, DepartmentheadName);
            Console.ReadKey();
        }

        static DateTime validateLeagalAge(string date)
        {
            try
            {
                DateTime legalAge = DateTime.Parse(date);
                DateTime currentDate = DateTime.Today;

                //validate student birth date input
                if(legalAge > currentDate)
                {
                    Console.WriteLine("Invalid birthdate provided");
                }
                if(legalAge.AddYears(18).CompareTo(DateTime.Today)>0)
                {
                    int age = currentDate.Year - legalAge.Year;

                    if(legalAge.Month > currentDate.Month)
                    {
                        age--;
                    }

                    Console.WriteLine("The student is not legal age.\r\nThe student's age is {0}", age);
                }
                else
                {
                    int age = currentDate.Year - legalAge.Year;

                    if(legalAge.Month > currentDate.Month)
                    {
                        age--;
                    }
                    Console.WriteLine("The student's age is {0}", age);
                    return legalAge;
                }

                return legalAge;

            }

            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message + "\r\nInvalid birthdate(DD/MM/YYYY) format");
                return DateTime.Today;

            }
        }
    }
}
