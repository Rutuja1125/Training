using GradeBook.Enums;
using System;
using System.Linq;
using System.Net.Http.Headers;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name,bool isWeighted) : base(name, isWeighted)
        {
            Type = GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("Ranked-grading requires a minimum of 5 students to work");
            }
          
            if (averageGrade >= 80)
                return 'A';

            else if (( 80 > averageGrade) &&(averageGrade >= 60))
                return 'B';

            else if ((60 > averageGrade) && (averageGrade >= 40))
                return 'C';


            else if ((40 > averageGrade) && (averageGrade >= 20))
                return 'D';

            else
                return 'F';
        }
        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading atleast 5 students");
                return;
            }
            base.CalculateStatistics();
        }
        public override void CalculateStudentStatistics(string name)
        {
            if(Students.Count < 5) 
            {
                Console.WriteLine("Ranked grading atleast 5 students");
                return;
            }
            base.CalculateStudentStatistics(name);
        }
    }
}
