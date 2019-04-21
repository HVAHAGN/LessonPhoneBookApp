using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Lesson.Dictionary.PhoneBook
{
    public static class PhoneBook
    {

        public static void SearchByGender(Dictionary<int, string> phoneDic, string gender)
        {
            for (int i = 0; i < phoneDic.Count; i++)
            {
                foreach (var contact in phoneDic)
                {
                    string[] contacts = contact.Value.Split('-');

                    if (contacts[9] == region)
                    {
                        Console.WriteLine(contact.Value);
                    }
                }
                break;
            }
        }

        public static void SearchByRegion (Dictionary<int, string> phoneDic, string region)
        {
            for (int i = 0; i < phoneDic.Count; i++)
            {
                foreach (var contact in phoneDic)
                {
                    string[] contacts = contact.Value.Split('-');

                    if (contacts[7] == gender)
                    {
                        Console.WriteLine(contact.Value);
                    }
                }
                break;
            }
        }

        public static void SearchByOperator(Dictionary<int, string> phoneDic, string opCode)
        {
            for (int i = 0; i < phoneDic.Count; i++)
            {
                foreach (var contact in phoneDic)
                {
                    string[] contacts = contact.Value.Split(' ');


                    switch (opCode)
                    {
                        case "Viva":

                            if (contacts[2] == "93" || contacts[2] == "77" || contacts[2] == "94" || contacts[2] == "98")
                                Console.WriteLine(contact.Value);
                            break;
                        case "Beeline":
                            if (contacts[2] == "91" || contacts[2] == "96" || contacts[2] == "99" || contacts[2] == "43")
                                Console.WriteLine(contact.Value);
                            break;
                        case "Ucom":
                            if (contacts[2] == "55" || contacts[2] == "95" || contacts[2] == "44" || contacts[2] == "41")
                                Console.WriteLine(contact.Value);
                            break;

                        default:
                            Console.WriteLine("Entered operator does not exist in RA");
                            break;
                    }
                }
                break;
            }
        }
       
        public static void SearchByProffesion(Dictionary<int, string> phoneDic, string prof)
        {

            for (int i = 0; i < phoneDic.Count; i++)
            {
                foreach (var contact in phoneDic)
                {
                    string[] contacts = contact.Value.Split('-');
                    if (contacts[5] == prof)
                    {
                        Console.WriteLine(contact.Value);

                    }

                }
                break;
            }
        }
       /* public void PrintContact(Contact con)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(con.FullNumber + " (" + con.Operator+ ")\t " + con.FullName + "\t" + con.Gender +"\t\t" + con.Country + ",  " + con.Regions);
        }
        */
    }
}

    

