namespace Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici kursu";
            string kurs2 = "Programlamaya başlangıç kursu";

            //arrays - diziler

            string[] courses = new string[] { "Yazılım geliştirici kursu" , "Programlamaya başlangıç kursu" , "Java" };



            for (int i = 0; i < courses.Length; i++)
            {
                Console.WriteLine(courses[i]);
            }

            foreach (string cours in courses)
            {
                Console.WriteLine(cours);
            }

            Console.WriteLine("Sayfa sonu");
        }
    }
}