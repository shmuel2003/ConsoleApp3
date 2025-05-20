using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    static class UppDateStudent
    {
        public static void UppDateStudentResult(Student student)
        {
            if (student.Grade >= 90)
            {
                student.result = "Excellent";
            }
            else if (student.Grade >= 75)
            {
                student.result = "Good";
            }
            else if (student.Grade >= 60)
            {
                student.result = "Pass";
            }
            else
            {
                student.result = "Fail";
            }
        }
    }
}
