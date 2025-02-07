using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Exam Exam { get; set; }

        public Subject(int _Id, string _Name)
        {
            Id = _Id;
            Name = _Name;
        }

        public void CreateExam()
        {
            Console.WriteLine("Please Enter Type Of Exam (1 for Practical | 2 for Final)");
            int ChooseExam, TimeExam, NumberOfQuestions;
            int.TryParse(Console.ReadLine(), out ChooseExam);

            Console.WriteLine("Please Enter The Time Of Exam From(30 min To 180 min)");
            int.TryParse(Console.ReadLine(), out TimeExam);
            if (TimeExam < 30 || TimeExam > 180) { throw new Exception("Invalid Must Time Be Between 30 MIN And 180 MIN"); }

            Console.WriteLine("Please Enter The Number of the Questions");
            int.TryParse(Console.ReadLine(), out NumberOfQuestions);
            Console.Clear();

            Questions QuestionType;

            if (ChooseExam == 1)
            {
                Exam = new Practical_Exam(TimeExam, NumberOfQuestions);

                for (int i = 0; i < NumberOfQuestions; i++)
                {
                    QuestionType = new MCQ(0, new Answer[4]);
                    Exam.ExamQuestion.Add((MCQ)QuestionType.DisplayQuestions());
                    Console.Clear();
                }

            }
            else if (ChooseExam == 2)
            {
                Exam = new Final_Exam(TimeExam, NumberOfQuestions);

                for (int i = 0; i < NumberOfQuestions; i++)
                {
                    int QuesionType;
                    Console.WriteLine($"Please Enter Type Of Question (1 for MCQ || 2 for True Or False):");

                    int.TryParse(Console.ReadLine(), out QuesionType);
                    Console.Clear();

                    if (QuesionType == 1)
                    {
                        QuestionType = new MCQ(0, new Answer[4]);
                        Exam.ExamQuestion.Add((MCQ)QuestionType.DisplayQuestions());
                    }
                    else if (QuesionType == 2)
                    {
                        QuestionType = new True_Or_False(0, new Answer(0, ""));
                        Exam.ExamQuestion.Add((True_Or_False)QuestionType.DisplayQuestions());
                    }
                    else
                        Console.WriteLine("Not Valid");
                    Console.Clear();
                }
            }
            else
                Console.WriteLine("InValid");
        }
    }
}
