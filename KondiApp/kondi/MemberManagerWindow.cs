using GymManagerDatabase.Datas;
using GymManagerLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace kondi
{
    public partial class MemberManagerWindow : Form
    {
        Logic logic = new();
        List<Member> members = new();
        Member SelectedMember = new();
        public MemberManagerWindow()
        {
            InitializeComponent();
            textBoxName.Enabled = false;
            textBoxAddress.Enabled = false;
            textBoxPhone.Enabled = false;
            textBoxEmail.Enabled = false;
            buttonAddMembership.Enabled = false;

            listBox1.Items.Clear();
            members = logic.AllMembers();
            foreach (Member member in members)
            {
                listBox1.Items.Add(member);
            }
        }

        private void buttonListMembers_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            members = logic.AllMembers();
            foreach (Member member in members)
            {
                listBox1.Items.Add(member);
            }

        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            SelectedMember = (Member)listBox1.SelectedItem;
            if (logic.IsGoodInput(SelectedMember))
            {
                textBoxName.Enabled = true;
                textBoxAddress.Enabled = true;
                textBoxPhone.Enabled = true;
                textBoxEmail.Enabled = true;

                textBoxName.Text = SelectedMember.Name;
                textBoxAddress.Text = SelectedMember.Address;
                textBoxPhone.Text = SelectedMember.Phone;
                textBoxEmail.Text = SelectedMember.EMail;

                buttonAddMembership.Enabled = true;
            }
            else
            {
                textBoxName.Enabled = false;
                textBoxAddress.Enabled = false;
                textBoxPhone.Enabled = false;
                textBoxEmail.Enabled = false;

                textBoxName.Text = "";
                textBoxAddress.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";

                buttonAddMembership.Enabled = false;
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SelectedMember.Name = textBoxName.Text;
            SelectedMember.Address = textBoxAddress.Text;
            SelectedMember.Phone = textBoxPhone.Text;
            SelectedMember.EMail = textBoxEmail.Text;

            if (logic.ModifyMember(SelectedMember, out string message))
            {
                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show(message);
            }
        }

        private void buttonAddMembership_Click(object sender, EventArgs e)
        {
            AddMembershipWindow nw = new(SelectedMember);
            nw.ShowDialog();
        }
    }
}
