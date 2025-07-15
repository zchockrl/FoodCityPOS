using MySql.Data.MySqlClient;

namespace FoodCityPOS
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }
        private string loginUserName = "";
        private bool loginFormCaps = true;
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

        private void button1_Click(object sender, EventArgs e)
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
    }
}
