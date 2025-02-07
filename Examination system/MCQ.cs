using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    public class MCQ : Questions
    {
        public override string Header
        {
            set
            {
            }
            get
            {
                return "MCQ Question";
            }
        }

        public MCQ(int _Grade, Answer[] _Answer) : base(_Grade, _Answer)
        {


        }

        public override string ToString()
        {
            return $"{Header}\t\tMarks{Mark}\n{Body}\n 1. {Answer[0].Text}\n 2. {Answer[1].Text}\n 3. {Answer[2].Text}";
        }

        public override Questions DisplayQuestions()
        {
            int mark; 
            int rightAnswer;
            string body;
            Console.WriteLine(Header);
            Console.WriteLine("Please Enter Question Body");
            body = Console.ReadLine();

            Console.WriteLine("Please Enter Question Mark");
            int.TryParse(Console.ReadLine(), out mark);
            
            Answer[] MCQ = new Answer[4];
            Console.WriteLine("Choices Of Question");
            
            for (int i = 0; i < 3; i++)
            {
                string Choose;
                Console.WriteLine($"Please Enter Choice Number {i + 1}:");
                Choose = Console.ReadLine();
                MCQ[i] = new Answer(i + 1, Choose);
            }

            Console.WriteLine("Please Enter Right Answer Id");
            int.TryParse(Console.ReadLine(), out rightAnswer);
            MCQ[3] = MCQ[rightAnswer - 1];
            this.Body = body;
            this.Mark = mark;
            this.Answer = MCQ;
            return this;
        }
    }
}
