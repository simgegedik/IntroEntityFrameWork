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

namespace IntroEntityFrameWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            #region Eski Yöntemler
            //SqlConnection cnn = new SqlConnection("data source =.; initial catalog = Northwind; integrated security = True; MultipleActiveResultSets = True; App = EntityFramework");

            //SqlCommand cmd = new SqlCommand("Select * From Customers", cnn);
            //if (cnn.State==ConnectionState.Closed)
            //{
            //    cnn.Open();
            //}
            //SqlDataReader dr   =  cmd.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(dr);
            //cnn.Close();
            //dvgMusteri.DataSource = dt;

            //SqlDataAdapter dap = new SqlDataAdapter("Select * From Products", "data source =.; initial catalog = Northwind; integrated security = True; MultipleActiveResultSets = True; App = EntityFramework");
            //DataTable dt = new DataTable();
            //dap.Fill(dt);
            //dvgMusteri.DataSource = dt;

            //Entity Frameworkle de aşağıdaki şekilde getirilmiş oldu.

            NorthwindEntities db = new NorthwindEntities();
            dvgMusteri.DataSource = db.Customers.ToList();


            #endregion
        }
    }
}
