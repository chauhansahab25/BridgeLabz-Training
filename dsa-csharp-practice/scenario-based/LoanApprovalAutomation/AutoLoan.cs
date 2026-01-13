using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.dsascenario.LoanApprovalAutomation
{
    class AutoLoan : LoanApplication
    {
        public AutoLoan(Applicant applicant, int months) : base(applicant, months, 9.5)

        {
        }
        protected override bool CheckEligibility()
        {
            return applicant.GetCreditScore() >= 600;
        }
    }
}
