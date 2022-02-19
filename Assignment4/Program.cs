using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            var adonetexample = new AdoNetTest();
            AdoNetTest.CreateStudents();
            AdoNetTest.CreateCourse();
            AdoNetTest.CreateProgram();
            AdoNetTest.CreateCourse();
        }
    }
}
