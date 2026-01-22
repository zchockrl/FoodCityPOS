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
        public bool awaitingWeight = false;
        public double itemPricePerLB = 0;
        public string weightedItemID = "";
        public string weightedItemName = "";
        public double weightedItemPrice;
        public bool weightedItemIsAlcoholic;

        public BindingList<OrderLine> orderLines = new BindingList<OrderLine>();
        private void MainPOSForm_Load(object sender, EventArgs e)
        {
            
            itemDisplay.AutoGenerateColumns = false;
            itemDisplay.DataSource = orderLines;
            itemDisplay.Columns.Clear();

            itemDisplay.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Id",
                Width = 90
            });

            itemDisplay.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                Width = 250
            });

            itemDisplay.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UnitPrice",
                Width = 90
            });

            itemDisplay.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalPrice",
                Width = 90
            });

            itemDisplay.ReadOnly = true;
            itemDisplay.AllowUserToAddRows = false;
            itemDisplay.AllowUserToDeleteRows = false;
            itemDisplay.RowHeadersVisible = false;
            itemDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            UpdateGridVisibility();
        }

        private void signOff_Click(object sender, EventArgs e)
        {
            if (POSSession.inOrder)
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
                                    valuCardTransaction.BackColor = Color.Red;
                                    regularTransaction.BackColor = Color.Gray;

                                    int fullPoints = int.Parse(reader["points"].ToString());
                                    int visits = fullPoints / 150;
                                    int remainingPoints = fullPoints % 150;
                                    fuelBuckBalanceText.Text = $"{visits} " + $"{remainingPoints}/150";
                                    fuelBuckBalanceText.Visible = true;
                                    fuelBuckPreface.Visible = true;
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
            awaitingWeight = false;
            typeDisplay.Text = "";
            multiplierText.Text = "";
            enableRightPanelButtons();
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
            {
                typeDisplay.Text = "";
                return;
            }

            if (int.TryParse(typeDisplay.Text, out int invalid))
            {
                if (invalid <= 0)
                {
                    typeDisplay.Text = "";
                    return;
                }
            }

            multiplierText.Text = $"Quantity: {multiplier}";
            typeDisplay.Text = "";
            POSSession.multiplier = multiplier;

        }

        private void enterItem_Click(object sender, EventArgs e)
        {
            if (int.TryParse(typeDisplay.Text, out int converted))
            {
                string itemId = converted.ToString();

                string connection = "server=localhost;user id=root;password=Bbs+Cp101422!_;database=fcupos;";
                using (MySqlConnection conn = new MySqlConnection(connection))
                {
                    try
                    {
                        conn.Open();
                        string query = "SELECT * FROM products WHERE Id = " + itemId;
                        using (MySqlCommand command = new MySqlCommand(query, conn))
                        {

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    bool perLB = reader.GetBoolean("PerLB");
                                    bool isAlcoholic = reader.GetBoolean("IsAlcoholic");
                                    if (!perLB)
                                    {
                                        for (int i = 0; i < POSSession.multiplier; i++)
                                        {
                                            
                                            Item newItem = new Item(itemId, reader["Name"].ToString(), perLB, Double.Parse(reader["Price"].ToString()), isAlcoholic);
                                            POSSession.addItemToOrder(newItem, Double.Parse(reader["Price"].ToString()));
                                            AddItemToGrid(newItem);
                                        }
                                        POSSession.multiplier = 1;
                                    }

                                    else
                                    {
                                        itemPricePerLB = Double.Parse(reader["Price"].ToString());
                                        awaitingWeight = true;
                                        multiplierText.Font = new Font("Segoe UI", 12F);
                                        weightedItemID = reader["Id"].ToString();
                                        weightedItemName = reader["Name"].ToString();
                                        weightedItemPrice = Double.Parse(reader["Price"].ToString());
                                        weightedItemIsAlcoholic = reader.GetBoolean("IsAlcoholic");
                                        multiplierText.Text = $"Enter Item Weight in pounds with 2 decimals, followed by OK\n{reader["Name"].ToString().ToUpper()}";
                                        disableRightPanelButtons();
                                        typeDisplay.Text = "";
                                    }
                                    typeDisplay.Text = "";
                                    POSSession.multiplier = 1;
                                }
                                else
                                {
                                    Console.WriteLine("Failure.");
                                    typeDisplay.Text = "";
                                    POSSession.multiplier = 1;
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Database error: {ex.Message}");
                        typeDisplay.Text = "";
                        POSSession.multiplier = 1;
                    }
                }
            }

        }

        private void enableRightPanelButtons()
        {
            var buttons = rightButtonLayout.Controls.OfType<Button>();

            foreach (var button in buttons)
            {
                button.Enabled = true;
            }
        }

        private void disableRightPanelButtons()
        {
            var buttons = rightButtonLayout.Controls.OfType<Button>();

            foreach (var button in buttons)
            {
                button.Enabled = false;
            }
        }

        private void posOK_Click(object sender, EventArgs e)
        {
            if (awaitingWeight)
            {
                if (typeDisplay.Text.Length > 4 || !double.TryParse(typeDisplay.Text, out double weight) || weight <= 0)
                {
                    enableRightPanelButtons();
                    typeDisplay.Text = "";
                    multiplierText.Text = "";
                    multiplierText.Font = new Font("Segoe UI", 18F);
                    awaitingWeight = false;
                    return;
                }

                weight /= 100;

                weightedItemPrice = Math.Round(itemPricePerLB * weight, 2);

                Item newItem = new Item(weightedItemID, weightedItemName, true, weightedItemPrice, weightedItemIsAlcoholic);

                POSSession.addItemToOrder(newItem, weightedItemPrice);
                AddItemToGrid(newItem);
                enableRightPanelButtons();
                typeDisplay.Text = "";
                multiplierText.Text = "";
                multiplierText.Font = new Font("Segoe UI", 18F);
                awaitingWeight = false;
                return;
            }
        }

        private void AddItemToGrid(Item item)
        {
            string unitPrice = item.price.ToString();
            string totalPrice = "100";

            orderLines.Add(new OrderLine
            {
                Id = item.id,
                Name = item.name,
                unitPrice = item.price.ToString(),
                totalPrice = "100"
            });

            itemDisplay.FirstDisplayedScrollingRowIndex = itemDisplay.RowCount - 1;

            UpdateGridVisibility();
        }

        private void UpdateGridVisibility()
        {
            itemDisplay.Visible = orderLines.Count > 0;
        }
    }
}
