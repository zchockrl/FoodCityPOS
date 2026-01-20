using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace FoodCityPOS
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            loginBoxTwo.PasswordChar = '*';
            loginSpace.Click += loginSpaceClick;
            loginBoxOne.Enter += TextBox_Enter;
            loginBoxTwo.Enter += TextBox_Enter;
            loginA.Click += KeyboardButton_Click;
            loginB.Click += KeyboardButton_Click;
            loginC.Click += KeyboardButton_Click;
            loginD.Click += KeyboardButton_Click;
            loginE.Click += KeyboardButton_Click;
            loginF.Click += KeyboardButton_Click;
            loginG.Click += KeyboardButton_Click;
            loginH.Click += KeyboardButton_Click;
            loginI.Click += KeyboardButton_Click;
            loginJ.Click += KeyboardButton_Click;
            loginK.Click += KeyboardButton_Click;
            loginL.Click += KeyboardButton_Click;
            loginM.Click += KeyboardButton_Click;
            loginN.Click += KeyboardButton_Click;
            loginO.Click += KeyboardButton_Click;
            loginP.Click += KeyboardButton_Click;
            loginQ.Click += KeyboardButton_Click;
            loginR.Click += KeyboardButton_Click;
            loginS.Click += KeyboardButton_Click;
            loginT.Click += KeyboardButton_Click;
            loginU.Click += KeyboardButton_Click;
            loginV.Click += KeyboardButton_Click;
            loginW.Click += KeyboardButton_Click;
            loginX.Click += KeyboardButton_Click;
            loginY.Click += KeyboardButton_Click;
            loginZ.Click += KeyboardButton_Click;

            loginZero.Click += KeyboardButton_Click;
            loginOne.Click += KeyboardButton_Click;
            loginTwo.Click += KeyboardButton_Click;
            loginThree.Click += KeyboardButton_Click;
            loginFour.Click += KeyboardButton_Click;
            loginFive.Click += KeyboardButton_Click;
            loginSix.Click += KeyboardButton_Click;
            loginSeven.Click += KeyboardButton_Click;
            loginEight.Click += KeyboardButton_Click;
            loginNine.Click += KeyboardButton_Click;
        }
        private string loginUserName = "";
        private bool loginFormCaps = true;
        private TextBox activeTextBox = null;

        // Converts each valid character to their capital form
        private void loginCapslock_Click(object sender, EventArgs e)
        {
            foreach (Button button in panel1.Controls)
            {
                if (loginFormCaps == true)
                {
                    if (button.Name != "loginCapslock" && button.Name != "loginBackspace" && button.Name != "loginEnter" && button.Name != "loginSpace")
                    {
                        button.Text = button.Text.ToLower();
                    }
                }
                else
                {
                    if (button.Name != "loginCapslock" && button.Name != "loginBackspace" && button.Name != "loginEnter" && button.Name != "loginSpace")
                    {
                        button.Text = button.Text.ToUpper();
                    }
                }
            }
            loginFormCaps = !loginFormCaps;
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            activeTextBox = sender as TextBox;
        }

        // For each character on the login screen keyboard, its value is added to the selected text box upon being clicked
        private void KeyboardButton_Click(object sender, EventArgs e)
        {
            if (activeTextBox == null) return;

            Button btn = sender as Button;
            if (btn != null)
            {
                activeTextBox.Text += btn.Text;
            }
        }

        private void loginSpaceClick (object sender, EventArgs e)
        {
            if (activeTextBox == null) return;

            activeTextBox.Text += " ";
        }

        private async void loginSend_Click(object sender, EventArgs e)
        {
            string username = loginBoxOne.Text.Trim();
            string password = loginBoxTwo.Text;
            string connection = "server=localhost;user id=root;password=Bbs+Cp101422!_;database=fcupos;";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    string query = @"
                    SELECT name, position 
                    FROM employees 
                    WHERE username = @username 
                    AND password = SHA2(@password, 256)
                    ";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string name = reader["name"].ToString();
                                string position = reader["position"].ToString();
                                POSSession.currentUser = name;
                                MainPOSForm main = new MainPOSForm(name, position);
                                main.Show();
                                this.Hide();
                            }
                            else
                            {
                                invalidLoginMessage.Visible = true;
                                await Task.Delay(3000);
                                invalidLoginMessage.Visible = false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    string tempText = invalidLoginMessage.Text;
                    invalidLoginMessage.Text = "Internal database error.";
                    invalidLoginMessage.Visible = true;
                    await Task.Delay(3000);
                    invalidLoginMessage.Visible = false;
                    invalidLoginMessage.Text = tempText;
                }
            }
        }

        private void boxOneClear_Click(object sender, EventArgs e)
        {
            loginBoxOne.Text = "";
        }

        private void boxTwoClear_Click(object sender, EventArgs e)
        {
            loginBoxTwo.Text = "";
        }
    }
}
