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

namespace FormsApp
{
    public partial class Form1 : Form
    {
        static string ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=orderline;Integrated Security=True";
        SqlConnection conn = new SqlConnection(ConnectionString);
        public Form1()
        {
            InitializeComponent();
        }

        private void InitialiseButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("CREATE TABLE Customer(" +
                "ID INT IDENTITY PRIMARY KEY,Name VARCHAR(20)," +
                "Address VARCHAR(40))", conn);
            SqlCommand cmd2 = new SqlCommand("CREATE TABLE Orders(" +
                "ID INT IDENTITY PRIMARY KEY,OrderDate DATE," +
                "Customer INT, FOREIGN KEY(Customer) REFERENCES " +
                "Customer(ID))", conn);
            SqlCommand cmd3 = new SqlCommand("CREATE TABLE Product(" +
                "ID INT IDENTITY PRIMARY KEY,Price INT, Description VARCHAR(50))", conn);
            SqlCommand cmd4 = new SqlCommand("CREATE TABLE OrderLine(" +
                "Product INT, OrderID INT, FOREIGN KEY(Product) REFERENCES " +
                "Product(ID),FOREIGN KEY(OrderID) REFERENCES " +
                "Orders(ID))", conn);
            using (conn)
            {
                conn.Open();
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                cmd4.ExecuteNonQuery();
            }
            MessageBox.Show("Tables Created!");
        }
    }
}
