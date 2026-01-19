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
            if (inOrder)
            {
                return;
            }

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

        private void pos0_Click(object sender, EventArgs e)
        {
            typeDisplay.Text += pos0.Text;
        }

        private void pos00_Click(object sender, EventArgs e)
        {
            typeDisplay.Text += pos00.Text;
        }

        private void pos1_Click(object sender, EventArgs e)
        {
            typeDisplay.Text += pos1.Text;
        }

        private void pos2_Click(object sender, EventArgs e)
        {
            typeDisplay.Text += pos2.Text;
        }

        private void pos3_Click(object sender, EventArgs e)
        {
            typeDisplay.Text += pos3.Text;
        }

        private void pos4_Click(object sender, EventArgs e)
        {
            typeDisplay.Text += pos4.Text;
        }

        private void pos5_Click(object sender, EventArgs e)
        {
            typeDisplay.Text += pos5.Text;
        }

        private void pos6_Click(object sender, EventArgs e)
        {
            typeDisplay.Text += pos6.Text;
        }

        private void pos7_Click(object sender, EventArgs e)
        {
            typeDisplay.Text += pos7.Text;
        }

        private void pos8_Click(object sender, EventArgs e)
        {
            typeDisplay.Text += pos8.Text;
        }

        private void pos9_Click(object sender, EventArgs e)
        {
            typeDisplay.Text += pos9.Text;
        }

        private void posClear_Click(object sender, EventArgs e)
        {
            typeDisplay.Text = "";
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (typeDisplay.Text.Length == 0)
            {
                return;
            }

            typeDisplay.Text = typeDisplay.Text.Substring(0, typeDisplay.Text.Length - 1);
        }

        private void posAtSign_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(typeDisplay.Text, out int multiplier))
                return;

            multiplierText.Text = $"Quantity: {multiplier}";
            typeDisplay.Text = "";


        }
    }
}
