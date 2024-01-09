using GymManagerDatabase.Datas;
using GymManagerLogic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace kondi
{
    public partial class MainWindow : Form
    {
        Logic logic = new();
        List<Member> members = new();
        Member Selectedmember = new();
        public MainWindow()
        {
            InitializeComponent();
        }

        //Opens window for adding new members
        private void button1_Click(object sender, EventArgs e)
        {
            AddMemberWindow nw = new();
            nw.ShowDialog();
        }

        //Opens window for manageing excisting members
        private void buttonManageMembers_Click(object sender, EventArgs e)
        {
            MemberManagerWindow nw = new();
            nw.ShowDialog();
        }

        //Lists the member(s) in the database
        private void buttonShowAllMembers_Click(object sender, EventArgs e)
        {
            members = logic.AllMembers();
            listBox1.Items.Clear();
            foreach (var member in members)
            {
                listBox1.Items.Add(member);
            }
        }

        //Lists the active member(s) (An active member is a member who has a valid membership at the time off the querry)
        private void buttonShowActiveMembers_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in logic.ActiveMembers())
            {
                listBox1.Items.Add(item);
            }
        }

        //Lists the passive member(s) (A passive member is a member who doesent have a valid mebmership at the time of the querry)
        private void buttonShowPassiveMembers_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in logic.PassiveMembers())
            {
                listBox1.Items.Add(item);
            }
        }

        //Lists the valid membership(s)
        private void buttonValidMemberships_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in logic.ValidMemberships())
            {
                listBox1.Items.Add(item);
            }
        }

        //Lists the expired membership(s)
        private void buttonExpiredMemberships_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in logic.ExpiredMemberships())
            {
                listBox1.Items.Add(item);
            }
        }

        //If the selected item is a member the button for listing the memberships of the selected member is enabled
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Selectedmember = (Member)listBox1.SelectedItem;

                if (logic.IsGoodInput(Selectedmember))
                {
                    buttonMembershipsOfSelected.Enabled = true;
                }
                else
                {
                    buttonMembershipsOfSelected.Enabled = false;
                }
            }
            catch (Exception)
            {
                buttonMembershipsOfSelected.Enabled = false;
            }
        }

        //Lists the membership(s) of the selected person
        private void buttonMembershipsOfSelected_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in logic.MembershipsOfMember(Selectedmember))
            {
                listBox1.Items.Add(item);
            }
        }

        //Chart update
        private void MainWindow_Activated(object sender, EventArgs e)
        {
            chartSales.Series["Sales"].Points.Clear();

            foreach (var item in logic.GetChartData())
            {
                chartSales.Series["Sales"].Points.AddXY(item.Key, item.Value);
            }
        }
    }
}