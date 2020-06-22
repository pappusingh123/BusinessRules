/*Created By: Pappu Singh
  Created Date: 22June200
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessRulesEngine.Payments
{
    public class EmployeePayment : IPayment
    {
        public bool GenerateDuplicatePackagingSlip()
        {
            Console.WriteLine( "Created Duplicate Packaging slip for royalty employee department successfully");
            return CommisionToAgent();
        }

        private bool CommisionToAgent()
        {
            Console.WriteLine("Commssion Payment to agent done successfully");
            return true;
        }

        public bool ProcessPayment()
        {
            return GenerateDuplicatePackagingSlip();
        }
    }
}
