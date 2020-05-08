using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;




namespace ISAD157_MySQL_Data_Form
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }


        //This code section shows connection details for the ConnectionString which will be used to intiate connection to the MySQL Database.

        string connectionString = "SERVER=" + DBConnect.SERVER + ";" +
                    "DATABASE=" + DBConnect.DATABASE_NAME + ";" + "UID=" +
                    DBConnect.USER_NAME + ";" + "PASSWORD=" +
                    DBConnect.PASSWORD + ";" + "SslMode=" +
                    DBConnect.SslMode + ";";








        //Code for User's Table Button which enables Data to be pulled out of that table and to be displayed from the MySQL Database.



        private void btnUser_Click(object sender, EventArgs e)
        {

            using (MySqlConnection connection =
                new MySqlConnection(connectionString))

            {

                //Source table being stated from which the Data will be pulled from to be displayed
                string DataQuery = "SELECT * FROM isad157_showarth.user;"; 

                //Opening connection
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(DataQuery, connection);
                MySqlDataAdapter sqlDA =new MySqlDataAdapter(cmd);

                //Data output being declared
                DataTable userDataTable = new DataTable();
                sqlDA.Fill(userDataTable);

                //Where the Data will be outputted within the Form
                dataGridView1.DataSource = userDataTable;





            }




        }





        //Code for Messages Table Button which enables Data to be pulled out of that table and to be displayed from the MySQL Database. 


        private void btnMessages_Click(object sender, EventArgs e)
        {

            using (MySqlConnection connection =
               new MySqlConnection(connectionString))


            {

                //Source table being stated from which the Data will be pulled from to be displayed
                string DataQuery = "SELECT * FROM isad157_showarth.messages;";

                //Opening connection
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(DataQuery, connection);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);

                //Data output being declared
                DataTable userDataTable = new DataTable();
                sqlDA.Fill(userDataTable);

                //Where the Data will be outputted within the Form
                dataGridView1.DataSource = userDataTable;





            }

        }




        //Code for Workplaces Table Button which enables Data to be pulled out of that table and to be displayed from the MySQL Database. 



        private void btnWorkplace_Click(object sender, EventArgs e)
        {

            using (MySqlConnection connection =
              new MySqlConnection(connectionString))


            {

                //Source table being stated from which the Data will be pulled from to be displayed
                string DataQuery = "SELECT * FROM isad157_showarth.workplace;";

                //Opening connection
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(DataQuery, connection);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);

                //Data output being declared
                DataTable userDataTable = new DataTable();
                sqlDA.Fill(userDataTable);

                //Where the Data will be outputted within the Form
                dataGridView1.DataSource = userDataTable;





            }

        }



        //Code for Universities Table Button which enables Data to be pulled out of that table and to be displayed from the MySQL Database. 



        private void btnUniversities_Click(object sender, EventArgs e)
        {

            using (MySqlConnection connection =
              new MySqlConnection(connectionString))


            {

                //Source table being stated from which the Data will be pulled from to be displayed
                string DataQuery = "SELECT * FROM isad157_showarth.universities;";

                //Opening connection
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(DataQuery, connection);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);

                //Data output being declared
                DataTable userDataTable = new DataTable();
                sqlDA.Fill(userDataTable);

                //Where the Data will be outputted within the Form
                dataGridView1.DataSource = userDataTable;





            }


        }



        //Code for Friends Table Button which enables Data to be pulled out of that table and to be displayed from the MySQL Database. 


        private void btnFriends_Click(object sender, EventArgs e)
        {

            using (MySqlConnection connection =
             new MySqlConnection(connectionString))


            {

                //Source table being stated from which the Data will be pulled from to be displayed
                string DataQuery = "SELECT * FROM isad157_showarth.friends;";

                //Opening connection
                connection.Open();

                MySqlCommand cmd = new MySqlCommand(DataQuery, connection);
                MySqlDataAdapter sqlDA = new MySqlDataAdapter(cmd);

                //Data output being declared
                DataTable userDataTable = new DataTable();
                sqlDA.Fill(userDataTable);

                //Where the Data will be outputted within the Form
                dataGridView1.DataSource = userDataTable;





            }



        }


        //Instructions for "Close Form" button when clicked, application will close.

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
