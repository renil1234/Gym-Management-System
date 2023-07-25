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
    public partial class Login : Form
    {
        Functions con;
        public Login()
        {
            InitializeComponent();
            con = new Functions();
        }
        public static int UserId;

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void AdmLbl_Click(object sender, EventArgs e)
        {
            Receptionists obj = new Receptionists();
            obj.Show();
            this.Hide();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if(UNameTb.Text==""||PasswordTb.Text=="")
            {
                MessageBox.Show("Missing Information!!!");
            }
            else
            {
                try
                {
                    String Query = "Select * from ReceptionistTbl where RecepName='{0}' and RecepPass='{1}'";
                    Query = String.Format(Query, UNameTb.Text, PasswordTb.Text);
                    DataTable dt = con.GetData(Query);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Invalid Information!!!");
                    }
                    else
                    {
                        UserId = Convert.ToInt32(dt.Rows[0][0].ToString());
                        Member obj = new Member();
                        obj.Show();
                        this.Hide();
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
