using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Lesson.Dictionary.PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> phoneDic = Generator.CreatePhonebook(10);

            Print(phoneDic);

           
/*          Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("***Filter By Profession****");
            Console.WriteLine("\tPhone Number\t Name  Surname\t Profession\t E-mail\t Gender" + "\n");
            PhoneBook.SearchByProffesion(phoneDic, "Dentist");
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("***Filter By Operator***");
            Console.WriteLine("\tPhone Number\t Name  Surname\t Profession\t E-mail\t Gender" + "\n");
            PhoneBook.SearchByOperator(phoneDic, "Beeline");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("***Filter By Gender***");
            Console.WriteLine("\tPhone Number\t Name  Surname\t Profession\t E-mail\t Gender" + "\n");
            PhoneBook.SearchByGender(phoneDic, "male");
            Console.ResetColor();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("***Filter by operator***");
            Console.WriteLine("\tPhone Number\t Name  Surname\t Profession\t E-mail\t Gender" + "\n");
            PhoneBook.SearchByOperator(phoneDic, "Ucom");
            Console.ResetColor();*/

            Console.ReadLine();
        }


        public static void Print(Dictionary<int, string> contacts)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("\tPhone Number\t Name  Surname\t Profession\t E-mail\t Gender+\t Country \t Region" + "\n");
            Console.ResetColor();
            foreach(var contact in contacts)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(contact.Value);
                Console.ResetColor();
            }
        }
      
       public static void PaintStartPage()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(55, 4);
            Console.WriteLine("Hello, user!");
            Console.SetCursorPosition(40, 7);
            Console.WriteLine("1) If You Want To Open Phonebook Please Enter '1'");
            Console.SetCursorPosition(40, 8);
            Console.WriteLine("2) For Search By Number Please Enter '2'");
            Console.SetCursorPosition(40, 9);
            Console.WriteLine("3) For Search By Name Please Enter '3'");
            Console.SetCursorPosition(40, 10);
            Console.WriteLine("4) For Search By Gender Please Enter '4'");
            Console.SetCursorPosition(40, 11);
            Console.WriteLine("5) For Search By Code Please Enter '5'");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(57, 12);
            Console.WriteLine("________");
            Console.SetCursorPosition(1, 13);
            Console.WriteLine(new string('_',118));
            Console.SetCursorPosition(60, 12);
        }


    }
}
