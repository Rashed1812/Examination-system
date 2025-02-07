using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    public class Practical_Exam : Exam
    {
        public Practical_Exam(int _Time, int _NumberQuestion) : base(_Time, _NumberQuestion)
        {

        }

        public override void DisplayFinallAnswers()
        {
            DisplayExamQuestionAndChosenAnswer();
            Console.Clear();

            Console.WriteLine("Right Answers");
            for (int i = 0; i < ExamQuestion.Count; i++)
            {
                Console.WriteLine($"Question {i + 1} : {ExamQuestion[i].Body} \nYour Answer => {ExamQuestion[i].Answer[Answer[i] - 1].Text}\nRight Answer => {ExamQuestion[i].Answer[i].Text}");
            }
        }
    }
}
