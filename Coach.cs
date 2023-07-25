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
    public partial class Coach : Form
    {
        Functions con;
        public Coach()
        {
            InitializeComponent();
            con = new Functions();
            ShowCoach();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Coach_Load(object sender, EventArgs e)
        {

        }
        private void ShowCoach()
        {
            String Query = "Select*From CoachsTbl";
            CoachsList.DataSource = con.GetData(Query);
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (ChNameTb.Text == "" || PhoneTb.Text == "" || ExpTb.Text == "" || PassTb.Text == "" || GenCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    String CName = ChNameTb.Text;
                    String Gender = GenCb.SelectedItem.ToString();
                    String Phone = PhoneTb.Text;
                    int experience = Convert.ToInt32(ExpTb.Text);
                    String Add = AddTb.Text;
                    String Password = PassTb.Text;
                    string Query = "insert into CoachsTbl values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')";
                    Query = String.Format(Query, CName, Gender, DOBTb.Value.Date, Phone, experience, Add, Password);
                    con.setData(Query);
                    ShowCoach();
                    MessageBox.Show("Coach Added!!!");

                }
                
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        int Key = 0;
        private void CoachsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ChNameTb.Text = CoachsList.SelectedRows[0].Cells[1].Value.ToString();
            GenCb.SelectedItem = CoachsList.SelectedRows[0].Cells[2].Value.ToString();
            DOBTb.Text = CoachsList.SelectedRows[0].Cells[3].Value.ToString();
            PhoneTb.Text = CoachsList.SelectedRows[0].Cells[4].Value.ToString();
            ExpTb.Text = CoachsList.SelectedRows[0].Cells[5].Value.ToString();
            AddTb.Text = CoachsList.SelectedRows[0].Cells[6].Value.ToString();
            PassTb.Text = CoachsList.SelectedRows[0].Cells[7].Value.ToString();

            if(ChNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CoachsList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {
            Billing obj = new Billing();
            obj.Show();
            this.Hide();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            Receptionists obj = new Receptionists();
            obj.Show();
            this.Hide();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Membership obj = new Membership();
            obj.Show();
            this.Hide();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Member obj = new Member();
            obj.Show();
            this.Hide();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            Coach obj = new Coach();
            obj.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("Select a Coatch!");
                }
                else
                {
                    String CName = ChNameTb.Text;
                    String Gender = GenCb.SelectedItem.ToString();
                    String Phone = PhoneTb.Text;
                    int experience = Convert.ToInt32(ExpTb.Text);
                    String Add = AddTb.Text;
                    String Password = PassTb.Text;
                    string Query = "delete from CoachsTbl where CId={0}";
                    Query = String.Format(Query, Key);
                    con.setData(Query);
                    ShowCoach();
                    MessageBox.Show("Coach Deleted!!!");

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
                if (ChNameTb.Text == "" || PhoneTb.Text == "" || ExpTb.Text == "" || PassTb.Text == "" || GenCb.SelectedIndex == -1)
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    String CName = ChNameTb.Text;
                    String Gender = GenCb.SelectedItem.ToString();
                    String Phone = PhoneTb.Text;
                    int experience = Convert.ToInt32(ExpTb.Text);
                    String Add = AddTb.Text;
                    String Password = PassTb.Text;
                    string Query = "update CoachsTbl set Cname='{0}',CGen='{1}',CDOB='{2}',CPhone='{3}',CExperience={4},CAddress='{5}',CPass='{6}' where CId={7}";
                    Query = String.Format(Query, CName, Gender, DOBTb.Value.Date, Phone, experience, Add, Password,Key);
                    con.setData(Query);
                    ShowCoach();
                    MessageBox.Show("Coach Updated!!!");

                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void PassTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void l7_Click(object sender, EventArgs e)
        {

        }

        private void AddTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void l6_Click(object sender, EventArgs e)
        {

        }

        private void ExpTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void l5_Click(object sender, EventArgs e)
        {

        }

        private void PhoneTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void l4_Click(object sender, EventArgs e)
        {

        }

        private void DOBTb_ValueChanged(object sender, EventArgs e)
        {

        }

        private void l3_Click(object sender, EventArgs e)
        {

        }

        private void GenCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void l2_Click(object sender, EventArgs e)
        {

        }

        private void ChNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void l1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
