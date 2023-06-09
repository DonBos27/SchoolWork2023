using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UJExamPortalSystem
{
    internal class StudentClass
    {
        public string studentNum;
        public int studentTestMark;
        public int studentExamMark;
        public int studentAssignmentMark;

        public StudentClass(string stuNum, int stuTestMark, int stuExamMark, int stuAssMark) 
        { 
            studentNum= stuNum;
            studentTestMark= stuTestMark;
            studentExamMark= stuExamMark;
            studentAssignmentMark= stuAssMark;
        }
    }
}
