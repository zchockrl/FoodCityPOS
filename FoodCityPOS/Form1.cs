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
        private void loginZero_Click(object sender, EventArgs e)
        {
        }

        private void loginOne_Click(object sender, EventArgs e)
        {
        }

        private void loginTwo_Click(object sender, EventArgs e)
        {
        }

        private void loginThree_Click(object sender, EventArgs e)
        {
        }

        private void loginFour_Click(object sender, EventArgs e)
        {
        }

        private void loginFive_Click(object sender, EventArgs e)
        {
        }

        private void loginSix_Click(object sender, EventArgs e)
        {
        }

        private void loginSeven_Click(object sender, EventArgs e)
        {
        }

        private void loginEight_Click(object sender, EventArgs e)
        {
        }

        private void loginNine_Click(object sender, EventArgs e)
        {
        }

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

        private void KeyboardButton_Click(object sender, EventArgs e)
        {
            if (activeTextBox == null) return;

            Button btn = sender as Button;
            if (btn != null)
            {
                activeTextBox.Text += btn.Text;
            }
        }

        private async void loginSend_Click(object sender, EventArgs e)
        {
            string username = loginBoxOne.Text;
            string password = loginBoxTwo.Text;
            string connection = "server=localhost;user id=root;password=;database=fcupos;";
            using (MySqlConnection conn = new MySqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM employees WHERE username = @username AND password = @password";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                panel1.Hide();
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

        private void loginP_Click(object sender, EventArgs e)
        {
        }

        private void loginO_Click(object sender, EventArgs e)
        {
        }

        private void loginI_Click(object sender, EventArgs e)
        {
        }

        private void loginU_Click(object sender, EventArgs e)
        {
        }

        private void loginY_Click(object sender, EventArgs e)
        {
        }

        private void loginT_Click(object sender, EventArgs e)
        {
        }

        private void loginR_Click(object sender, EventArgs e)
        {
        }

        private void loginE_Click(object sender, EventArgs e)
        {
        }

        private void loginW_Click(object sender, EventArgs e)
        {
        }

        private void loginQ_Click(object sender, EventArgs e)
        {
        }

        private void loginL_Click(object sender, EventArgs e)
        {
        }

        private void loginK_Click(object sender, EventArgs e)
        { 
        }

        private void loginJ_Click(object sender, EventArgs e)
        {
        }

        private void loginH_Click(object sender, EventArgs e)
        {
        }

        private void loginG_Click(object sender, EventArgs e)
        {
        }

        private void loginF_Click(object sender, EventArgs e)
        {
        }

        private void loginD_Click(object sender, EventArgs e)
        {
        }

        private void loginS_Click(object sender, EventArgs e)
        {
        }

        private void loginA_Click(object sender, EventArgs e)
        {
        }

        private void loginM_Click(object sender, EventArgs e)
        {
        }

        private void loginN_Click(object sender, EventArgs e)
        {
        }

        private void loginB_Click(object sender, EventArgs e)
        {
        }

        private void loginV_Click(object sender, EventArgs e)
        {
        }

        private void loginC_Click(object sender, EventArgs e)
        {
        }

        private void loginX_Click(object sender, EventArgs e)
        {
        }

        private void loginZ_Click(object sender, EventArgs e)
        {
        }
    }
}
