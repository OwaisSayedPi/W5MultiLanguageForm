using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5MultiLanguageForm
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string QuestionString { get; set; }
        public int LanguageID { get; set; }
        public string Answer { get; set; } = "";
    }
}
