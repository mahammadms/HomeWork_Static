using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_Static
{
    internal class Student
    {
        public string Name;
        public string Surname;
        public string GroupNo;
        public int Age;

        public bool CheckGroupNo(string groupno)
        {
            bool hasUpper=false;
            bool hasDigit=false;
            if (groupno.Length == 4)
            {
                for (int i = 0; i < groupno.Length; i++)
                {
                    if (char.IsUpper(groupno [0])&&char.IsDigit(groupno [1])&& char.IsDigit(groupno [2])&&char.IsDigit(groupno [3]))
                    {
                        hasDigit=true;
                        hasUpper =true;
                    }
                }
                bool resault = hasDigit&&hasUpper;
                return resault;

            } 
            return false;
        }
        public bool Fullname(string name, string surname)
        {
            bool hasUpper = false;
            bool hasUpper1=false;
            for (int i = 0; i < name.Length; i++)
            {
                if (char.IsUpper(name [0]))
                {
                    hasUpper=   true;
                }
            
            }
            for (int i = 0; i < surname.Length; i++)
            {
                if (char.IsUpper(surname [0]))
                {
                    hasUpper1=true; 
                }
            }
            bool resault = hasUpper&&hasUpper1;
            return resault;
        }
        

        
    }

    
}
