using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo.Forms
{
    public partial class AutorisationForm : Form
    {
        string code;
        public AutorisationForm()
        {
            InitializeComponent();
            Random rnd = new Random();
            int cd = rnd.Next(1000, 9999);
            code = cd.ToString();
            CAPTCHA.Text = code;
        }

        private void btAutorisation_Click(object sender, EventArgs e)
        {
            string login = tbID.Text;
            string password = tbPassword.Text;
            string captcha = tbCapcha.Text;
            if (captcha == code)
            {
                string connString = Classes.ConnectionString.strConn;
                SqlConnection sqlConnection = new SqlConnection(connString);
                sqlConnection.Open();
                SqlCommand sqlCheck1 = new SqlCommand("SELECT * FROM Организаторы where [ID Организатора] = '" + login + "' and пароль = '" + password + "'", sqlConnection);
                SqlDataReader sqlDataReader1 = sqlCheck1.ExecuteReader();
                if (sqlDataReader1.Read())
                {
                    //creator
                    OrganizationForm fm3 = new OrganizationForm();
                    fm3.ShowDialog();
                    this.Close();
                }
                sqlDataReader1.Close();
                SqlCommand sqlCheck2 = new SqlCommand("SELECT * FROM Жюри where [ID Жюри] = '" + login + "' and пароль = '" + password + "'", sqlConnection);
                SqlDataReader sqlDataReader2 = sqlCheck2.ExecuteReader();
                if (sqlDataReader2.Read())
                {
                    //jurys
                    JuryForm fm4 = new JuryForm();
                    fm4.ShowDialog();
                    this.Close();
                }
                sqlDataReader2.Close();
                SqlCommand sqlCheck3 = new SqlCommand("SELECT * FROM Модераторы where [ID Модератора] = '" + login + "' and пароль = '" + password + "'", sqlConnection);
                SqlDataReader sqlDataReader3 = sqlCheck3.ExecuteReader();
                if (sqlDataReader3.Read())
                {
                    //moderators
                    ModeratorForm fm5 = new ModeratorForm();
                    fm5.ShowDialog();
                    this.Close();
                }
                sqlDataReader3.Close();
                SqlCommand sqlCheck4 = new SqlCommand("SELECT * FROM Участники where [ID участника] = '" + login + "' and пароль = '" + password + "'", sqlConnection);
                SqlDataReader sqlDataReader4 = sqlCheck4.ExecuteReader();
                if (sqlDataReader4.Read())
                {
                    //users
                    UserForm fm6 = new UserForm();
                    fm6.ShowDialog();
                    this.Close();
                }
                sqlDataReader4.Close();
            }
            else
            {
                MessageBox.Show("Неверный код");
            }
            }
        }
    }

