using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            using(DBEntities db = new DBEntities())
            {
                student student = new student
                {
                    name = "sumanth",
                    branch = "cse"
                };
                db.students.Add(student);
                db.SaveChanges();
            }
        }
    }
}
