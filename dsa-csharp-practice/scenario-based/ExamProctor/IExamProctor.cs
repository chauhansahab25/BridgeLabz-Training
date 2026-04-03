using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CG_Practice.dsascenario.ExamProctor
{
    interface IExamProctor
    {
        void VisitQuestion(int qid);
        void AnswerQuestion(int qid, string answer);
        void ShowLastVisited();
        void SubmitExam();
    }
}
