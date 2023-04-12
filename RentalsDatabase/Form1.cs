 namespace RentalsDatabase

{
    using System;
    using System.Data;
    using System.Data.SqlClient;
    using System.Diagnostics.Metrics;
    using System.Runtime.InteropServices;
    using System.Windows.Forms.VisualStyles;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float charge;
        String carType = " ";
        char xtra = 'N';
        DataTable tb = new DataTable();
        SqlDataAdapter adapter = new SqlDataAdapter();
        
        //Initialize MSSQL Connection
        SqlConnection conn = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog = Rentals;Integrated Security = True;Connect Timeout = 30;Encrypt = False;TrustServerCertificate = False;ApplicationIntent = ReadWrite;MultiSubnetFailover = False");
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }

        //Function to display the database inside a DataGridView with DataTable
        private void displayBtn_Click(object sender, EventArgs e)
        {
            
            SqlCommand Fillcmd = new SqlCommand();
            
            Fillcmd.Connection = conn;
            Fillcmd.CommandText = "SELECT * FROM dbo.Rentals;";
            tb.Clear();
            
            adapter.SelectCommand = Fillcmd;
            try
            {
                conn.Open();
                adapter.Fill(tb);
                dataGridView1.DataSource = tb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }

        //Function to place a rental inside the database
        private void placeBtn_Click(object sender, EventArgs e)
        {
            SqlCommand Fillcmd = new SqlCommand();
            Fillcmd.Connection = conn;
            Fillcmd.CommandType = CommandType.Text;

            //Check which of the cartypes the user has chosen and access properties
            foreach (ValueRadioBtn r in groupBox1.Controls)
            {
                if (r.Checked == true)
                {
                    charge = r.Value();
                    carType = r.CarType();
                    
                }
            }
            
            String plateNum = licensebox.Text;
            DateTime rDate = rentDate.Value;
            DateTime ruDate = returnDate.Value;
            
            double cost = Math.Ceiling((ruDate - rDate).TotalDays * charge);
            if (checkBox1.Checked == true)
            {
                cost = cost + 25;
                xtra = 'Y';
            }
            Fillcmd.CommandText = "INSERT INTO Rentals VALUES(@plateNum, @carType, @rDate, @ruDate, @cost, @xtra)";

            Fillcmd.Parameters.Add("@plateNum", SqlDbType.VarChar);
            Fillcmd.Parameters.Add("@carType", SqlDbType.VarChar);
            Fillcmd.Parameters.Add("@rDate", SqlDbType.Date);
            Fillcmd.Parameters.Add("@ruDate", SqlDbType.Date);
            Fillcmd.Parameters.Add("@cost", SqlDbType.Int);
            Fillcmd.Parameters.Add("@xtra", SqlDbType.Char);
            

            Fillcmd.Parameters[0].Value = plateNum;
            Fillcmd.Parameters[1].Value = carType;
            Fillcmd.Parameters[2].Value = rDate;
            Fillcmd.Parameters[3].Value = ruDate;
            Fillcmd.Parameters[4].Value = cost;
            Fillcmd.Parameters[5].Value = xtra;

            try
            {
                conn.Open();
                Fillcmd.ExecuteNonQuery();
                
                MessageBox.Show("Success");
            } 
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            checkBox1.Checked = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Function to update a rental inside the database
        private void updatebtn_Click(object sender, EventArgs e)
        {
            SqlCommand updcmd = new SqlCommand();
            updcmd.Connection = conn;

            updcmd.CommandText = "UPDATE dbo.Rentals SET PlateNum = @gridPlateNum, CarType = @carType, RentDate = @rDate, ReturnDate = @ruDate, Cost = @cost, xDriver = @xtra WHERE Id = @Id;";

            updcmd.Parameters.Add("@gridPlateNum", SqlDbType.VarChar, 50,"PlateNum");
            updcmd.Parameters.Add("@carType", SqlDbType.VarChar, 11, "CarType");
            updcmd.Parameters.Add("@rDate", SqlDbType.Date, 30, "RentDate");
            updcmd.Parameters.Add("@ruDate", SqlDbType.Date, 30, "ReturnDate");
            updcmd.Parameters.Add("@cost", SqlDbType.Int, 8, "Cost");
            updcmd.Parameters.Add("@xtra", SqlDbType.Char, 1, "xDriver");
            updcmd.Parameters.Add("@Id", SqlDbType.Int, 10, "Id");

            adapter.UpdateCommand = updcmd;

            try
            {
                conn.Open();
                int r = adapter.Update(tb);
                MessageBox.Show("Updated " + r.ToString() + " row(s)");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            conn.Close();
        }
    }
}