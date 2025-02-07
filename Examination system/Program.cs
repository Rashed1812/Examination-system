using System.Diagnostics;
using static System.Net.Mime.MediaTypeNames;


namespace Examination_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject(101, "Programming");
            subject.CreateExam();
            Console.Clear();
            Console.Write("Do You Want To Start Exam (Y|N)");
            if (char.Parse(Console.ReadLine()) == 'y')
            {
                Stopwatch timer = new Stopwatch();
                timer.Start();
                subject.Exam.DisplayFinallAnswers();
                Console.WriteLine($"Time = {timer.Elapsed}");
                Console.WriteLine("Thank You!");
            }

        }
    }
}
