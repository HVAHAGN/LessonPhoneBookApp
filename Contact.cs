using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.Lesson.Dictionary.PhoneBook
{
   public class Contact
    {
    
        public string Name { get; set; }
      
      
   
        public string Surname { get; set; }
       
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public int Code { get; set; }
        public string Profession { get; set; }
        public string Email { get; set; }
        public string Regions { get; set; }
        public string Country { get; set; }
       
        public int Number { get; set; }
        public string ContacFullData => $"{PhoneNumber}-{Name}-{Surname}-{Profession}-{Email}-{Gender}-{Country}-{Regions}";

        /*public Contact(string name, string surname, string gender, string code, string proffesion, string phoneNumber)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
            this.Code = code;
            this.Proffesion = proffesion;
            this.PhoneNumber = phoneNumber;
        }*/
        public override string ToString()
        {
            return PhoneNumber;
        }
    }
}
