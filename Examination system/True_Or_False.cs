using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    public class True_Or_False : Questions
    {
        #region Override ToString For Header
        public override string Header
        {
            set{ }
            get{return "True | False Question";}
        }
        #endregion

        #region Constructor
        public True_Or_False(int _Mark, Answer rightAnswer) : base(_Mark, new Answer[3] { new Answer(1, "True"), new Answer(2, "False"), rightAnswer })
        {

        } 
        #endregion

        public override string ToString()
        {
            return $"{Header}\t\tMarks{Mark}\n{Body}\n 1. True\n 2. False";
        }

        #region Create Questions
        public override Questions DisplayQuestions()
        {
            int mark, rightAnswer;
            string body;
            Console.WriteLine(Header);
            Console.WriteLine("Please Enter Question Body");
            body = Console.ReadLine();
            Console.WriteLine("Please  Enter Question Mark");
            int.TryParse(Console.ReadLine(), out mark);
            Console.WriteLine("Please enter the Right Answer Id (1 for True | 2 for False):");
            int.TryParse(Console.ReadLine(), out rightAnswer);
            Mark = mark;
            Body = body;
            Answer = new Answer[3]
            {
                new Answer(1, "True"),
                new Answer(2, "False"),
                new Answer(rightAnswer,rightAnswer == 1 ? "True" : "False")
            };
            return this;

        } 
        #endregion
    }
}
