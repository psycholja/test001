using System;
using System.Collections.Generic;
using System.Text;

namespace testConsole
{
    class Student
    {
        public string name;
        public int rating;
        public int grants;

        public Student(string a,int b) { name = a;rating = b;}
        public void ReWrite()
        {
            Console.WriteLine($"Имя:{name}\nБалл:{rating}");
        }

        public int GetGrants()
        {
            {
                if (rating < 8)
                {
                    grants = 20;
                }
                if ((rating >= 8) && (rating < 10))
                {
                    grants = 30;
                }

                if (rating == 10)
                {
                    grants = 35;
                }
                return grants;
            }
           
        }
       
        

    }
}
