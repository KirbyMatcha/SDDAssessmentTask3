using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDDAssessmentTask3
{
    public class Progress2
    {
        public int answered2;
        public int answeredCorrect2;
        public string name;
        public Progress2(int _answered2, int _answeredCorrect2, string _name)
        {
            answered2 = _answered2;
            answeredCorrect2 = _answeredCorrect2;
            name = _name;
        }
        public string reportMe2()
        {
            return "My score is  " + answeredCorrect2 + " out of " + answered2 + " in Subtraction and my name is " + name;
        }

        
    }
}
