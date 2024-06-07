using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace June03_Labsheet03
{
    public class course
    {
        private string courseName;
        private string instructorName;
        private double grade;

        public course(string CourseName, double Grade)
        {
            this.courseName = CourseName;
            this.grade = Grade;
        }
        public string CourseName
        {
            get { return this.courseName; }
        }

        public double Grade
        {
            get { return this.grade; }
            set
            {
                if (this.grade != value)
                {
                }
            }
        }






        internal class Program
        {
            static void Main(string[] args)
            {
            }
        }
    }
}
