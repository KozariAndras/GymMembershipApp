using GymManagerDatabase.Datas;
using GymManagerLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kondi
{
    public partial class AddMembershipWindow : Form
    {
        Logic logic = new();
        Member SelectedMember = new();
        public AddMembershipWindow(Member member)
        {
            InitializeComponent();
            SelectedMember = member;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            bool daily = radioButtonDaily.Checked;
            bool monthly = radioButtonMonthly.Checked;
            bool annual = radioButtonAnnual.Checked;
            DateTime startdate = dateTimePickerStartDate.Value;
            DateTime enddate = dateTimePickerEndDate.Value;

            if (logic.AddNewMembership(SelectedMember, daily, monthly, annual, startdate, enddate, out string message))
            {
                MessageBox.Show(message);
                this.Close();
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Automatic value changer for better UX
        private void dateTimePickerStartDate_ValueChanged(object sender, EventArgs e)
        {
            if (radioButtonDaily.Checked)
            {
                dateTimePickerEndDate.Value = dateTimePickerStartDate.Value.AddDays(1);
            }
            else if (radioButtonMonthly.Checked)
            {
                dateTimePickerEndDate.Value = dateTimePickerStartDate.Value.AddMonths(1);
            }
            else if (radioButtonAnnual.Checked)
            {
                dateTimePickerEndDate.Value = dateTimePickerEndDate.Value.AddYears(1);
            }

        }

        private void radioButtonDaily_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDaily.Checked)
            {
                dateTimePickerEndDate.Value = dateTimePickerStartDate.Value.AddDays(1);
            }
        }

        private void radioButtonMonthly_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonMonthly.Checked)
            {
                dateTimePickerEndDate.Value = dateTimePickerStartDate.Value.AddMonths(1);
            }
        }

        private void radioButtonAnnual_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonAnnual.Checked)
            {
                dateTimePickerEndDate.Value = dateTimePickerEndDate.Value.AddYears(1);
            }
        }
    }
}
