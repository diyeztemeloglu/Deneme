using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTranscript
{
    public enum LetterGrade { F, DD=2, DC, CC, CB, BB, BA , AA}
    public class StudentCourse
    {
        public StudentCourse(Course course, LetterGrade grade)
        {
            Course = course;
            Grade = grade;
        }
        public Course Course { get; set; }
        public LetterGrade Grade { get; set; }
        public float GradeValue
        {
            get
            {
                return ((int)Grade) / 2f;
            }
        }
    }

}
