using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDDAssessmentTask3
{
    public class Progress3
    {
        public int answered3;
        public int answeredCorrect3;
        public string name;
        public Progress3(int _answered3, int _answeredCorrect3, string _name)
        {
            answered3 = _answered3;
            answeredCorrect3 = _answeredCorrect3;
            name = _name;
        }
        public string reportMe3()
        {
            return "My score is  " + answeredCorrect3 + " out of " + answered3 + " in Multiplication and my name is " + name;
        }

        
    }
}
