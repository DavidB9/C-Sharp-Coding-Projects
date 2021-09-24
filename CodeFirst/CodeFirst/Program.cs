using System;

namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "David" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
