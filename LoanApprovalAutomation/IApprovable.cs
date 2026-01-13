using System;
using System.Collections.Generic;
using System.Text;

namespace CG_Practice.dsascenario.LoanApprovalAutomation
{
    interface IApprovable
    {
        bool ApproveLoan();
        double CalculateEMI();
    }
}
