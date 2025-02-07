using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    public abstract class Exam
    {
        #region Props

        public int Time { get; set; }
        public int NumberOfQuestion { get; set; }
        public List<Questions> ExamQuestion { get; set; }
        public List<int> Answer { get; set; }

        #endregion


        #region Methods
        public Exam(int _Time, int _NumberOfQuestion)
        {
            Time = _Time;
            NumberOfQuestion = _NumberOfQuestion;
            ExamQuestion = new List<Questions>(_NumberOfQuestion);
            Answer = new List<int>(_NumberOfQuestion);
        }
        public void DisplayExamQuestionAndChosenAnswer()
        {
            Console.Clear();

            for (int i = 0; i < ExamQuestion.Count; i++)
            {
                Console.WriteLine(ExamQuestion[i].ToString());
                int answer;
                int.TryParse(Console.ReadLine(), out answer);
                Answer.Add(answer);
            }
        }
        public abstract void DisplayFinallAnswers(); 

        #endregion
    }
}
