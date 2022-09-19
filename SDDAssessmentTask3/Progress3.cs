using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDDAssessmentTask3
{
    public class Progress3
    {
        public int answered1;
        public int answeredCorrect1;
        public string name;
        public Progress3(int _answered1, int _answeredCorrect1, string _name)
        {
            answered1 = _answered1;
            answeredCorrect1 = _answeredCorrect1;
            name = _name;
        }
        public string reportMe()
        {
            return "My score is  " + answeredCorrect1 + " out of " + answered1 + " in Additions and my name is " + name;
        }

        
    }
}
