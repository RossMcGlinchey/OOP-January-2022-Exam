using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class JuniorMember : Member
    {
        //Constant
        private const decimal AnnualFeeAdjustment = 0.50m;

        //Constant
        public JuniorMember(string Name, DateTime JoinDate, decimal Fee, PaymentSchedule PaymentType)
            : base(Name, JoinDate, Fee, PaymentType) { }

        


        public override void AnnualFee()
        {
            Fee -= Fee * AnnualFeeAdjustment;
        }
    }
}
