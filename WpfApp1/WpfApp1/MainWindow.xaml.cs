using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Github Link: https://github.com/RossMcGlinchey/OOP-January-2022-Exam
    /// </summary>
    public partial class MainWindow : Window
    {
        //List for all Members
        List<Member> Members = new List<Member>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            JuniorMember jm1 = new JuniorMember() { Name = "Jack Murphy", Fee = 1000, JoinDate = new DateTime(2020, 5, 7), PaymentType = PaymentSchedule.Annual };
            JuniorMember jm2 = new JuniorMember() { Name = "Emily Kelly", Fee = 1000, JoinDate = new DateTime(2021, 1, 10), PaymentType = PaymentSchedule.Biannual };
            JuniorMember jm3 = new JuniorMember() { Name = "Daniel Ryan", Fee = 1000, JoinDate = new DateTime(2020, 11, 30), PaymentType = PaymentSchedule.Monthly };

            Member m1 = new Member() { Name = "Ella Doyle", Fee = 1000, JoinDate = new DateTime(2019, 3, 20), PaymentType = PaymentSchedule.Annual };
            Member m2 = new Member() { Name = "Fionn Kennedy", Fee = 1000, JoinDate = new DateTime(2018, 8, 15), PaymentType = PaymentSchedule.Biannual };
            Member m3 = new Member() { Name = "Louise Moore", Fee = 1000, JoinDate = new DateTime(2017, 2, 10), PaymentType = PaymentSchedule.Monthly };

            SeniorMember sm1 = new SeniorMember() { Name = "Cian Daly", Fee = 1000, JoinDate = new DateTime(2015, 4, 24), PaymentType = PaymentSchedule.Annual };
            SeniorMember sm2 = new SeniorMember() { Name = "Bobby Quinn", Fee = 1000, JoinDate = new DateTime(2014, 12, 1), PaymentType = PaymentSchedule.Biannual };
            SeniorMember sm3 = new SeniorMember() { Name = "Eve Gallagher", Fee = 1000, JoinDate = new DateTime(2013, 6, 1), PaymentType = PaymentSchedule.Monthly };

            //Stores all Members in listbox
            lbxMemberList.ItemsSource = Members;
        }

        private void UpdateDisplay(Member selected)
        {
            tbName.Text = selected.Name;
            tbJoinDate.Text = selected.JoinDate.ToString();
            tbBasicFee.Text = selected.Fee.ToString("c");  //currency formatting
            tbPaymentSchedule.Text = selected.PaymentType.ToString();     //gets the name of the class
            tbRenewalDate.Text = selected.RenewalDate.ToString();    //short date time formatting
            //tbDaysToRenewal.Text
            //tbMemberType
        }
    }
}
