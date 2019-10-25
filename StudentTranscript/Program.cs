using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTranscript
{
    class Program
    {
        static void Main(string[] args)
        {
            Department cet = new Department();
            cet.Code = "CET";
            cet.Name = "Bilgisayar ve Öğretim Teknolojileri";
            cet.CreditCount = 5;
           // cet.HeadOfDepartment = "Diler Öner";

            Department fled = new Department();
            fled.Code = "FLED";
            fled.Name = "Yabancı Diller Eğitimi";
            fled.CreditCount = 10;

           
            //s1.GPA = 3;

            Student s2 = new Student();
            s2.StudentNumber = "9999";
            s2.NameSurname = "Hüseyin Şimşek";
            s2.Department = fled;

            Course cet301 = new Course();
            cet301.Code = "cet 301";
            cet301.Name = "C# Programming";
            cet301.Credit = 2;


            Course math101 = new Course();
            math101.Code = "mat 101";
            math101.Name = "Calculus1";
            math101.Credit = 4;

            Student s1 = new Student();
            s1.StudentNumber = "124512";
            s1.NameSurname = "Deniz Dikbıyık";
            //s1.mininumGPAForGraduation = 1.0f;
            s1.Department = cet;

            StudentCourse DenizCet301 = new StudentCourse(cet301, LetterGrade.BA );
           
            s1.Courses.Add(DenizCet301);
            s1.Courses.Add(new StudentCourse(math101, LetterGrade.BA));

            StudentCourse huseyinCet301 = new StudentCourse(cet301, LetterGrade.AA);
            //huseyinCet301.Course = cet301;
            //huseyinCet301.Grade = LetterGrade.CB;

            s2.Courses.Add(huseyinCet301);
            s2.Courses.Add(new StudentCourse(math101, LetterGrade.F));

            Student s3 = new Student();
            s3.NameSurname = "Ahmet";
            s3.Department = cet;
            Console.WriteLine(s1.NameSurname + " GPA =" +s1.CalculateGPA() +" Can Graduate " + s1.CanGraduate());
            Console.WriteLine(s2.NameSurname + " GPA =" + s2.CalculateGPA() + " Can Graduate " + s2.CanGraduate());
            Console.WriteLine(s3.NameSurname + " GPA =" + s3.CalculateGPA() + " Can Graduate " + s3.CanGraduate());
           
            

            MasterStudent ms = new MasterStudent();
            ms.NameSurname = "Furkan ";
            ms.Department = cet;
            ms.Courses.Add(new StudentCourse(cet301, LetterGrade.BB));
            ms.Courses.Add(new StudentCourse(math101, LetterGrade.BA));
            ms.ThesisTopic = "Programming";
            ms.IsThesisCompleted = true;

            Console.WriteLine(ms.NameSurname + " GPA =" + ms.CalculateGPA() + " Can Graduate " + ms.CanGraduate());

            Console.ReadLine();


        }
    }
}
