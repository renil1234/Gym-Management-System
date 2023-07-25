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
    public partial class Receptionists : Form
    {
        Functions con;
        public Receptionists()
        {
            InitializeComponent();
            con = new Functions();
            ShowReceptionist();
        }
        private void ShowReceptionist()
        {
            String Query = "Select * from ReceptionistTbl";
            RecepList.DataSource = con.GetData(Query);
        }
        private void Reset()
        {
            RecepNameTb.Text = "";
            PhoneTb.Text = "";
            PasswordTb.Text = "";
            RecepAddTb.Text = "";
            GenCb.SelectedIndex = -1;
        } 

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Key == 0)
                {
                    MessageBox.Show("Select a Receptionist!");
                }
                else
                {
                    string Query = "delete from ReceptionistTbl where RecepId={0}";
                    Query = String.Format(Query, Key);
                    con.setData(Query);
                    ShowReceptionist();
                    MessageBox.Show("Receptionist Deleted!!!");

                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (RecepNameTb.Text == "" || PhoneTb.Text == "" || RecepAddTb.Text == "" || PhoneTb.Text == "" || GenCb.SelectedIndex == -1||PasswordTb.Text =="")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    String RName = RecepNameTb.Text;
                    String Gender = GenCb.SelectedItem.ToString();
                    String DOB = RecepDOBTb.Value.Date.ToString("dd-MMMM-yyyy");
                    String Add = RecepAddTb.Text;
                    String Phone = PhoneTb.Text;
                    String Password = PasswordTb.Text;
                    string Query = "insert into ReceptionistTbl values('{0}','{1}','{2}','{3}',{4},'{5}')";
                    Query = String.Format(Query, RName, Gender, DOB, Add, Phone, Password);
                    con.setData(Query);
                    ShowReceptionist();
                    MessageBox.Show("Receptionis Added!!!");
                    Reset();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (RecepNameTb.Text == "" || PhoneTb.Text == "" || RecepAddTb.Text == "" || PhoneTb.Text == "" || GenCb.SelectedIndex == -1 || PasswordTb.Text == "")
                {
                    MessageBox.Show("Missing Data!");
                }
                else
                {
                    String RName = RecepNameTb.Text;
                    String Gender = GenCb.SelectedItem.ToString();
                    String DOB = RecepDOBTb.Value.Date.ToString("dd-MMMM-yyyy");
                    String Add = RecepAddTb.Text;
                    String Phone = PhoneTb.Text;
                    String Password = PasswordTb.Text;
                    string Query = "update ReceptionistTbl set RecepName='{0}',RecepGen='{1}',RecepDOB='{2}',RecepAdd='{3}',RecepPhone={4},RecepPass='{5}' where RecepId={6}";
                    Query = String.Format(Query, RName, Gender, DOB, Add, Phone, Password,Key);
                    con.setData(Query);
                    ShowReceptionist();
                    MessageBox.Show("Receptionis Updated!!!");
                    Reset();
                }

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

        private void pictureBox5_Click(object sender, EventArgs e)
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

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
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

        private void label10_Click(object sender, EventArgs e)
        {

        }
        int Key = 0;
        private void RecepList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            RecepNameTb.Text = RecepList.SelectedRows[0].Cells[1].Value.ToString();
            GenCb.SelectedItem = RecepList.SelectedRows[0].Cells[2].Value.ToString();
            RecepDOBTb.Text = RecepList.SelectedRows[0].Cells[3].Value.ToString();
            RecepAddTb.Text = RecepList.SelectedRows[0].Cells[4].Value.ToString();
            PhoneTb.Text = RecepList.SelectedRows[0].Cells[5].Value.ToString();
            PasswordTb.Text = RecepList.SelectedRows[0].Cells[6].Value.ToString();
       
            if (RecepNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(RecepList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }
    }
}
