namespace FoodCityPOS
{
    partial class MainPOSForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private readonly string name;
        private readonly string Uposition;
        public MainPOSForm(string username, string position)
        {
            InitializeComponent();
            name = username;
            Uposition = position;
            nameOfUser.Text = name;
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bottomPanel = new Panel();
            nameOfUser = new Label();
            bottomPanel.SuspendLayout();
            SuspendLayout();
            // 
            // bottomPanel
            // 
            bottomPanel.Controls.Add(nameOfUser);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 594);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(1496, 20);
            bottomPanel.TabIndex = 0;
            bottomPanel.BackColor = Color.Gray;
            // 
            // nameOfUser
            // 
            nameOfUser.AutoSize = true;
            nameOfUser.Location = new Point(2, 2);
            nameOfUser.Name = "nameOfUser";
            nameOfUser.Size = new Size(37, 15);
            nameOfUser.TabIndex = 0;
            // 
            // MainPOSForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1496, 614);
            Controls.Add(bottomPanel);
            Name = "MainPOSForm";
            Text = "MainPOSForm";
            bottomPanel.ResumeLayout(false);
            bottomPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel bottomPanel;
        private Label nameOfUser;
    }
}