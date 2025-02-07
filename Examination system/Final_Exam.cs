using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    public class Final_Exam : Exam
    {
        public Final_Exam(int _Time, int _NumberQuestion) : base(_Time, _NumberQuestion)
        {

        }

        public override void DisplayFinallAnswers()
        {
            DisplayExamQuestionAndChosenAnswer();
            Console.Clear();
            int TotalMark = 0, StudentMark = 0;
            for (int i = 0; i < ExamQuestion.Count; i++)
            {
                int rightanswerId = ExamQuestion[i].Answer.Length;
                Console.WriteLine($"Question {i + 1}:    {ExamQuestion[i].Body} \nYour Answer => {ExamQuestion[i].Answer[Answer[i] - 1].Text}\nRight Answer => {ExamQuestion[i].Answer[rightanswerId - 1].Text}");
                
                if (Answer[i] == ExamQuestion[i].Answer[rightanswerId - 1].Id) 
                    StudentMark += ExamQuestion[i].Mark;
                

                TotalMark += ExamQuestion[i].Mark;
            }
            Console.WriteLine($"Your Grade is {StudentMark} from {TotalMark}");
        }
    }
}
