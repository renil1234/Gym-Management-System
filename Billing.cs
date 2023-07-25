using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_management
{
    public partial class Billing : Form
    {
        Functions con;
        public Billing()
        {
            InitializeComponent();
            con = new Functions();
            ShowBills();
            GetMembers();
        }
        private void ShowBills()
        {
            String Query = "Select * from FinanceTbl";
            BillingList.DataSource = con.GetData(Query);

        }
        private void GetMembers()
        {
            String Query = "Select * from MembersTbl";
            MemberCb.DisplayMember = con.GetData(Query).Columns["MName"].ToString();
            MemberCb.ValueMember = con.GetData(Query).Columns["MId"].ToString();
            MemberCb.DataSource = con.GetData(Query);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MemberCb.Text == "" || AmountTb.Text == "" )
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    int Agent = Login.UserId;
                    String Member = MemberCb.SelectedValue.ToString();
                    String Period = PeriodTb.Value.Date.Month+"-"+ PeriodTb.Value.Date.Year;
                    String BDate = BDateTb.Value.Date.ToString("dd-MMMM-yyyy");
                    String Amount = AmountTb.Text;
                    string Query = "insert into FinanceTbl values({0},'{1}','{2}','{3}',{4})";
                    Query = String.Format(Query, Agent, Member, Period, BDate, Amount);
                    con.setData(Query);
                    ShowBills();
                    MessageBox.Show("Bill Added!!!");

                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Member obj = new Member();
            obj.Show();
            this.Hide();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            AmountTb.Text = "";
            MemberCb.SelectedIndex = -1;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Coach obj = new Coach();
            obj.Show();
            this.Hide();

        }

        private void label15_Click(object sender, EventArgs e)
        {
            Membership obj = new Membership();
            obj.Show();
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Receptionists obj = new Receptionists();
            obj.Show();
            this.Hide();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Billing obj = new Billing();
            obj.Show();
            this.Hide();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
