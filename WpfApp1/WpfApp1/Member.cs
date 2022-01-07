using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public enum PaymentSchedule { Annual, Biannual, Monthly}

    public class Member
    {
        private DateTime renewalDate;
        #region Properties

        public string Name { get; set; }
        public DateTime JoinDate { get; set; }
        public decimal Fee { get; set; }
        public PaymentSchedule PaymentType { get; set; }

        public DateTime RenewalDate
        {
            get
            {
                DateTime currentYear = DateTime.Now;
                if (PaymentType == PaymentSchedule.Annual)
                {
                    var newdate = new DateTime(DateTime.Now.Year, JoinDate.Month, JoinDate.Day);
                    JoinDate = newdate;
                    
                }
                else if (PaymentType == PaymentSchedule.Biannual)
                {
                    JoinDate.AddMonths(6);
                    var newdate = new DateTime(DateTime.Now.Year, JoinDate.Month, JoinDate.Day);
                    JoinDate = newdate;
                }
                else if (PaymentType == PaymentSchedule.Monthly)
                {
                    JoinDate.AddMonths(1);
                    var newdate = new DateTime(DateTime.Now.Year, JoinDate.Month, JoinDate.Day);
                    JoinDate = newdate;
                }
                return JoinDate;
            }
        }
        #endregion Properties

        #region Constructor

        public Member()
        {

        }

        public Member(string name, DateTime joinDate, decimal fee, PaymentSchedule paymentType)
        {
            Name = name;
            JoinDate = joinDate;
            Fee = fee;
            PaymentType = paymentType;
        }

        #endregion Constructor

        #region Methods
        private void CalculateFees(PaymentSchedule paymentType)
        {
            decimal amount;
            if (PaymentType == PaymentSchedule.Annual)
            {
                amount = Fee;
            }
            else if (PaymentType == PaymentSchedule.Biannual)
            {
                amount = Fee / 2;
            }
            else if (PaymentType == PaymentSchedule.Monthly)
            {
                amount = Fee / 12;
            }
            
        }

        public abstract void AnnualFee();
        #endregion Methods
    }
}
