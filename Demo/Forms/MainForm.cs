using Demo.Forms;
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

namespace Demo
{
    public partial class Form1 : Form
    {
        String connString = Classes.ConnectionString.strConn;
        DataSet ds;
        public void populatecbEvent()
        {
            
            string sql = "SELECT DISTINCT [Событие] FROM [Мероприятия]";

            using (SqlConnection connection = new SqlConnection(connString))
            {

                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader rd = cmd.ExecuteReader();
                cbEvent.Items.Add("Все типы");
                if (rd.HasRows == true)
                {
                    while (rd.Read())
                    {
                        cbEvent.Items.Add(rd["Событие"]);
                    }
                }
            }
        }
        public void populatecbDate()
        {

            string sql = "SELECT DISTINCT [DATE] FROM [Мероприятия]";

            using (SqlConnection connection = new SqlConnection(connString))
            {

                connection.Open();
                SqlCommand cmd = new SqlCommand(sql, connection);
                SqlDataReader rd = cmd.ExecuteReader();
                cbDate.Items.Add("Все типы");
                if (rd.HasRows == true)
                {
                    while (rd.Read())
                    {
                        cbDate.Items.Add(rd["DATE"]);
                    }
                }
            }
        }
        public void populategrid(string sql)
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                ds = new DataSet();
                adapter.Fill(ds);
                dgEvent.DataSource = ds.Tables[0];
                connection.Close();
            }
        }

            public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM [Мероприятия]";
            populatecbEvent();
            populatecbDate();
            populategrid(sql);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "piniginiaDataSet.Мероприятия". При необходимости она может быть перемещена или удалена.
            this.мероприятияTableAdapter.Fill(this.piniginiaDataSet.Мероприятия);

        }
        private void cbEvent_SelectedIndexChanged(object sender, EventArgs e)
        { 
            String sql = " ";
            string type = cbEvent.Items[cbEvent.SelectedIndex].ToString();
            if (type == "Все типы")
               
            {
                sql = "select * FROM [Мероприятия]";
            }
            else
            {
                 sql = "select * FROM [Мероприятия] where Событие = '" + type + "'";
            }
            cbDate.SelectedIndex = 0;
            populategrid("SELECT * FROM [Мероприятия]");
            populategrid(sql);

        }
        private void cbDate_SelectedIndexChanged(object sender, EventArgs e)
        {
            String sql = " ";
            string type = cbDate.Items[cbDate.SelectedIndex].ToString();
            if (type == "Все типы")

            {
                sql = "select * FROM [Мероприятия]";
            }
            else
            {
                sql = "select * FROM [Мероприятия] where DATE = '" + type + "'";
            }
            cbEvent.SelectedIndex = 0;
            populategrid("SELECT * FROM [Мероприятия]");
            populategrid(sql);
        }

        private void btRegistration_Click(object sender, EventArgs e)
        {
            AutorisationForm newForm = new AutorisationForm();
            newForm.ShowDialog();
            this.Close();
        }

        private void btInfoActivity_Click(object sender, EventArgs e)
        {
            int[] arr = new int[6]; 
            dgEvent.SelectedRows.CopyTo(arr, 0);


           Console.Write("ds");
        }
    }
}
