namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Taha";
            int yas = 20;

            Course kurs = new Course();
            kurs.CourseName1 = "C#";
            kurs.CourseTeacher = "EnginDemiog";
            kurs.RatingOfCourse = 70;

            Course kurs2 = new Course();
            kurs2.CourseTeacher = "Taha";
            kurs2.CourseName1 = "Pyhton";
            kurs2.RatingOfCourse = 85;

            Course kurs3 = new Course();
            kurs3.CourseTeacher = "Berkay";
            kurs3.CourseName1 = "C";
            kurs3.RatingOfCourse = 45;

            Course[] kurslar = new Course[] {kurs,kurs2,kurs3};

            foreach (var course in kurslar)
            {
                Console.WriteLine(course.CourseName1 + "  " + course.CourseTeacher);
            }

            

        }
    }

    class Course
    {
        public string CourseName1 { get; set; }

        public string CourseTeacher { get; set; }

        public int RatingOfCourse { get; set; }
    }
}