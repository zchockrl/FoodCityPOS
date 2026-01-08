using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FoodCityPOS
{
    public partial class MainPOSForm : Form
    {
        private void MainPOSForm_Load(object sender, EventArgs e)
        {

        }

        private void signOff_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void bakeryDeliMenu_Click(object sender, EventArgs e)
        {
        }

        private void voidMenu_Click(object sender, EventArgs e)
        {

        }

        private void buttonContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customerLookup_Click(object sender, EventArgs e)
        {
            POSSession.valuCardApplied = true;
            if (POSSession.valuCardApplied)
            {

                string connection = "server=localhost;user id=root;password=Bbs+Cp101422!_;database=fcupos;";
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT * FROM customers WHERE valucardNumber = 4001";
                        using (MySqlCommand command = new MySqlCommand(query, conn))
                        {

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string firstname = reader["first_name"].ToString();
                                    string lastname = reader["last_name"].ToString();
                                    POSSession.customerFirstName = firstname;
                                    POSSession.customerLastName = lastname;
                                    customerDisplayPreface.Visible = true;
                                    customerNameDisplay.Text = $"{lastname}, {firstname}";
                                    customerNameDisplay.Visible = true;
                                }
                                else
                                {
                                    Console.WriteLine("Failure.");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Database error: {ex.Message}");
                    }
                }
            }
        }
    }
}
