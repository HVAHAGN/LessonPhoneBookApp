using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Lesson.Dictionary.PhoneBook
{
   class Generator 
    {
        private static int[] codes = { 91, 93, 94, 95, 96, 55, 98, 99, 44, 43, 41};
        private static string[] gender = { "male", "female" };
        private static string[] professions = { "Lawyer", "Engineer", "Pharmacist", "Notarie", "Dentist" };
        private static string[] emails = { "@gmail.com", "@mail.ru", "@yahoo.com" };
         private static string[] regions = { "Aragatsotn", "Ararat", "Armavir", "Gegharkunik", "Kotayk","Lori","Shirak","Syunik","Tavush","Vayots Dzor", "Yerevan" };
       
       
        public static Dictionary<int, string> CreatePhonebook(int count)
        {
            Random rnd = new Random();
            Dictionary<int, string> phoneDic = new Dictionary<int, string>(count);
          

            for (int i = 0; i < count; i++)
            {
                Contact contact = new Contact();


                contact.Name = $"A{i}A";
                contact.Surname = $"A{i}Ayan";
                contact.Regions=regions[rnd.Next(0,regions.Length)];
                contact.Gender = gender[rnd.Next(0, gender.Length)];
                contact.Code = codes[rnd.Next(0, codes.Length)];
                contact.Profession = professions[rnd.Next(0, professions.Length)];
                contact.PhoneNumber = $" (+374) {codes[rnd.Next(0, codes.Length)]} {string.Format("{0:##-##-##}", rnd.Next(100000, 999999))}";
               contact.Email = $"A{i}_A{i}yan{emails[rnd.Next(0, emails.Length)]}";
                contact.Country="Armenia";
                
                while(phoneDic.Contains(contact.Number))
                {
                   contact.Number = rnd.Next(100000, 999999);
                }
                phoneDic.Add(contact.Number, contact.ContacFullData);
              
            }
            return phoneDic;
            
        }      
        
     }
}
