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
    public partial class Membership : Form
    {
        Functions con;
        public Membership()
        {
            InitializeComponent();
            con = new Functions();
            ShowMShips();
        }
        private void ShowMShips()
        {
            String Query = "Select * From MembershipsTbl";
            MShipList.DataSource = con.GetData(Query);
        }

        private void Membership_Load(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            MNameTb.Text = "";
            CostTb.Text = "";
            MDurationTb.Text = "";
            GoalTb.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MNameTb.Text == "" || MDurationTb.Text == "" || GoalTb.Text == "" || CostTb.Text == "")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    String MName = MNameTb.Text;
                    int Duration = Convert.ToInt32(MDurationTb.Text);
                    String Goal = GoalTb.Text;
                    int Cost = Convert.ToInt32(CostTb.Text);
                    string Query = "insert into MembershipsTbl values('{0}',{1},'{2}',{3})";
                    Query = String.Format(Query, MName, Duration,Goal, Cost);
                    con.setData(Query);
                    ShowMShips();
                    MessageBox.Show("Membership Added!!!");
                    Reset();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        int Key = 0;
        private void MShipList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MNameTb.Text = MShipList.SelectedRows[0].Cells[1].Value.ToString();
            MDurationTb.Text = MShipList.SelectedRows[0].Cells[2].Value.ToString();
            GoalTb.Text = MShipList.SelectedRows[0].Cells[3].Value.ToString();
            CostTb.Text = MShipList.SelectedRows[0].Cells[4].Value.ToString();
            if (MNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(MShipList.SelectedRows[0].Cells[0].Value.ToString());
            }

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("Select a Membership!!!");
                }
                else
                {
                    String Qurey = "delete from MembershipsTbl where MShipId={0}";
                    Qurey = String.Format(Qurey, Key);
                    con.setData(Qurey);
                    ShowMShips();
                    MessageBox.Show("Membership Deleted!!!");
                    Reset();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MNameTb.Text == "" || MDurationTb.Text == "" || GoalTb.Text == "" || CostTb.Text == "")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    String MName = MNameTb.Text;
                    int Duration = Convert.ToInt32(MDurationTb.Text);
                    String Goal = GoalTb.Text;
                    int Cost = Convert.ToInt32(CostTb.Text);
                    string Query = "update MembershipsTbl set MName='{0}',MDuration={1},MGoal='{2}',MCost={3}";
                    Query = String.Format(Query, MName, Duration, Goal, Cost,Key);
                    con.setData(Query);
                    ShowMShips();
                    MessageBox.Show("Membership Upadated!!!");
                    Reset();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void CoachLbl_Click(object sender, EventArgs e)
        {
            Coach obj = new Coach();
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
