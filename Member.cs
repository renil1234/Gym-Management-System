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
    public partial class Member : Form
    {
        Functions con;
        public Member()
        {
            InitializeComponent();
            con = new Functions();
            ShowMembers();
            GetCoaches();
            GetMShips();
        }
        private void ShowMembers()
        {
            String Query = "Select * from MembersTbl";
            MembersList.DataSource = con.GetData(Query);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CoachLbl_Click(object sender, EventArgs e)
        {
            Coach obj = new Coach();
            obj.Show();
            this.Hide();
        }
        private void GetCoaches()
        {
            String Query = "Select * from CoachsTbl";
            CoachCb.DisplayMember = con.GetData(Query).Columns["CName"].ToString();
            CoachCb.ValueMember = con.GetData(Query).Columns["CId"].ToString();
            CoachCb.DataSource = con.GetData(Query);
        }
        private void GetMShips()
        {
            String Query = "Select * from MembershipsTbl";
            MShipCb.DisplayMember = con.GetData(Query).Columns["MName"].ToString();
            MShipCb.ValueMember = con.GetData(Query).Columns["MShipId"].ToString();
            MShipCb.DataSource = con.GetData(Query);
        }
        private void Reset()
        {
            MNameTB.Text = "";
            PhoneTb.Text = "";
            CoachCb.SelectedIndex = -1;
            GenCb.SelectedIndex = -1;
            MShipCb.SelectedIndex = -1;
            StatusCb.SelectedIndex = -1;
            TimingCb.SelectedIndex = -1;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MNameTB.Text == "" || PhoneTb.Text == "" || CoachCb.SelectedIndex == -1 || GenCb.SelectedIndex == -1 || MShipCb.SelectedIndex == -1 || StatusCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    String MName = MNameTB.Text;
                    String Gender = GenCb.SelectedItem.ToString();
                    String Phone = PhoneTb.Text;
                    String DOB = DOBTb.Value.Date.ToString("dd-MMMM-yyyy");
                    String MJDate = JDateTb.Value.Date.ToString("dd-MMMM-yyyy");
                    String MShip = MShipCb.SelectedIndex.ToString();
                    String Coach = CoachCb.SelectedIndex.ToString();
                    String Timing = TimingCb.SelectedIndex.ToString();
                    String Status = StatusCb.SelectedIndex.ToString();
                    string Query = "insert into MembersTbl values('{0}','{1}','{2}','{3}',{4},'{5}','{6}','{7}','{8}')";
                    Query = String.Format(Query, MName, Gender, DOB,MJDate,MShip,Coach,Phone, Timing, Status);
                    con.setData(Query);
                    ShowMembers();
                    Reset();
                    MessageBox.Show("Memebers Added!!!");

                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int Key = 0;
        private void MembersList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MNameTB.Text = MembersList.SelectedRows[0].Cells[1].Value.ToString();
            GenCb.SelectedItem = MembersList.SelectedRows[0].Cells[2].Value.ToString();
            DOBTb.Text = MembersList.SelectedRows[0].Cells[3].Value.ToString();
            JDateTb.Text = MembersList.SelectedRows[0].Cells[4].Value.ToString();
            MShipCb.Text = MembersList.SelectedRows[0].Cells[5].Value.ToString();
            CoachCb.Text = MembersList.SelectedRows[0].Cells[6].Value.ToString();
            PhoneTb.Text = MembersList.SelectedRows[0].Cells[7].Value.ToString();
            TimingCb.Text = MembersList.SelectedRows[0].Cells[8].Value.ToString();
            StatusCb.Text = MembersList.SelectedRows[0].Cells[9].Value.ToString();

            if (MNameTB.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(MembersList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (MNameTB.Text == "" || PhoneTb.Text == "" || CoachCb.SelectedIndex == -1 || GenCb.SelectedIndex == -1 || MShipCb.SelectedIndex == -1 || StatusCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    String MName = MNameTB.Text;
                    String Gender = GenCb.SelectedItem.ToString();
                    String Phone = PhoneTb.Text;
                    String DOB = DOBTb.Value.Date.ToString("dd-MMMM-yyyy");
                    String MJDate = JDateTb.Value.Date.ToString("dd-MMMM-yyyy");
                    String MShip = MShipCb.SelectedIndex.ToString();
                    String Coach = CoachCb.SelectedIndex.ToString();
                    String Timing = TimingCb.SelectedIndex.ToString();
                    String Status = StatusCb.SelectedIndex.ToString();
                    string Query = "update MembersTbl set MName='{0}',MGen='{1}',MDOB='{2}',MDate='{3}',MMembership={4},MCoach='{5}',MPhone='{6}',MTiming='{7}',MStatus='{8}' where MId={9}";
                    Query = String.Format(Query, MName, Gender, DOB, MJDate, MShip, Coach, Phone, Timing, Status,Key);
                    con.setData(Query);
                    ShowMembers();
                    Reset();
                    MessageBox.Show("Memebers Updated!!!");

                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("Select a Members!");
                }
                else
                {
                    string Query = "delete from MembersTbl where MId={0}";
                    Query = String.Format(Query, Key);
                    con.setData(Query);
                    ShowMembers();
                    MessageBox.Show("Members Deleted!!!");

                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {
            Billing obj = new Billing();
            obj.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Member obj = new Member();
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

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
