using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    public class Answer
    {
        #region Props
        public int Id { get; set; }
        public string Text { get; set; }
        #endregion

        #region Constructor

        public Answer(int _Id, string _Text)
        {
            Id = _Id;
            Text = _Text;
        } 

        #endregion
    }
}
