using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    class Students
    {
        int id;
        string RegisterationNo;
        string FirstName;
        string LastName;
        string Contact;
        string Email;
        DateTime DateOfBirth;
        string gender;

        public int Id { get => id; set => id = value; }
        public string RegisterationNo1 { get => RegisterationNo; set => RegisterationNo = value; }
        public string FirstName1 { get => FirstName; set => FirstName = value; }
        public string LastName1 { get => LastName; set => LastName = value; }
        public string Contact1 { get => Contact; set => Contact = value; }
        public string Email1 { get => Email; set => Email = value; }
        public DateTime DateOfBirth1 { get => DateOfBirth; set => DateOfBirth = value; }
        public string Gender { get => gender; set => gender = value; }
    }
}
