using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountRegistration
{
    public class StudentInfoClass
    {
        public delegate long DelegateNumber(long num);
        public delegate string Delegatetext(string txt);

        public static string FirstName = " ";
        public static string LastName = " ";
        public static string MiddleName = " ";
        public static string Address = " ";
        public static string Program = " ";

        public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;

        public static string GetFirstName(string firstName) { return FirstName = firstName; }
        public static string GetLastName(string lastName) { return LastName = lastName; }
        public static string GetMiddletName(string middleName) { return MiddleName = middleName; } 
        public static string GetProgram(string program) { return Program = program; }
        public static string GetAddress(string address) { return Address = address; }
        public static long GetAge(long age) { return Age = age; }
        public static long GetContactNo(long contactNo) { return ContactNo = contactNo; }
        public static long GetStundentNo(long studentNo) { return StudentNo = studentNo; }

    }
}
