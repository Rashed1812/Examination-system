using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    public abstract class Questions
    {
        public abstract string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }
        public Answer[] Answer { get; set; }
        public Questions(int _Mark, Answer[] _Answer)
        {
            Mark = _Mark;   
            Answer = _Answer;
        }
        public abstract Questions DisplayQuestions();
    }
}
