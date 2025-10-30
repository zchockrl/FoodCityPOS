using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private int numberOfItemsInCurrentOrder = 0;
        public MainPOSForm(string username, string position)
        {
            InitializeComponent();
            name = username;
            Uposition = position;
            nameOfUser.Text = name;

            timeDisplay.Tick += displayTime_Tick;
            timeDisplay.Enabled = true;

            displayTime_Tick(null, null);
            this.Resize += MainPOSForm_Resize;

            
        }

        private void MainPOSForm_Resize(object sender, EventArgs e)
        {
            valuCardPresentStrip.Width = (int)(this.ClientSize.Width * 0.85);
            valuCardHolderInfo.Width = (int)(this.ClientSize.Width * 0.85);
            buttonContainer.Width = (int)(this.ClientSize.Width * 0.15);
        }

        private void buttonContainer_Resize(object sender, EventArgs e)
        {
            signOff.Width = (int)(buttonContainer.Width * .6);
            bakeryDeliMenu.Width = (int)(buttonContainer.Width * .4);

        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bottomPanel = new Panel();
            readyLabel = new Label();
            currentDate = new Label();
            currentTime = new Label();
            connectionStatus = new Label();
            nameOfUser = new Label();
            timeDisplay = new System.Windows.Forms.Timer(components);
            valuCardPresentStrip = new Panel();
            topPanelContainer = new Label();
            valuCardHolderInfo = new Panel();
            signOff = new System.Windows.Forms.Button();
            buttonContainer = new Panel();
            bakeryDeliMenu = new System.Windows.Forms.Button();
            bottomPanel.SuspendLayout();
            valuCardPresentStrip.SuspendLayout();
            buttonContainer.SuspendLayout();
            SuspendLayout();
            // 
            // bottomPanel
            // 
            bottomPanel.BackColor = Color.Gray;
            bottomPanel.Controls.Add(readyLabel);
            bottomPanel.Controls.Add(currentDate);
            bottomPanel.Controls.Add(currentTime);
            bottomPanel.Controls.Add(connectionStatus);
            bottomPanel.Controls.Add(nameOfUser);
            bottomPanel.Dock = DockStyle.Bottom;
            bottomPanel.Location = new Point(0, 594);
            bottomPanel.Name = "bottomPanel";
            bottomPanel.Size = new Size(1496, 20);
            bottomPanel.TabIndex = 0;
            // 
            // readyLabel
            // 
            readyLabel.Anchor = AnchorStyles.Left;
            readyLabel.AutoSize = true;
            readyLabel.Location = new Point(4, 2);
            readyLabel.Name = "readyLabel";
            readyLabel.Size = new Size(39, 15);
            readyLabel.TabIndex = 5;
            readyLabel.Text = "Ready";
            // 
            // currentDate
            // 
            currentDate.Anchor = AnchorStyles.Right;
            currentDate.Location = new Point(1187, 2);
            currentDate.Name = "currentDate";
            currentDate.Size = new Size(70, 15);
            currentDate.TabIndex = 4;
            currentDate.Text = DateTime.Now.ToString("MM/dd/yyyy");
            // 
            // currentTime
            // 
            currentTime.Anchor = AnchorStyles.Right;
            currentTime.Location = new Point(1277, 2);
            currentTime.Name = "currentTime";
            currentTime.Size = new Size(99, 15);
            currentTime.TabIndex = 3;
            currentTime.Text = "placeholder";
            currentTime.TextAlign = ContentAlignment.MiddleRight;
            // 
            // connectionStatus
            // 
            connectionStatus.Anchor = AnchorStyles.Right;
            connectionStatus.BackColor = Color.Green;
            connectionStatus.Location = new Point(1428, 0);
            connectionStatus.Name = "connectionStatus";
            connectionStatus.Size = new Size(68, 20);
            connectionStatus.TabIndex = 1;
            // 
            // nameOfUser
            // 
            nameOfUser.Anchor = AnchorStyles.Left;
            nameOfUser.AutoSize = true;
            nameOfUser.Location = new Point(195, 2);
            nameOfUser.Name = "nameOfUser";
            nameOfUser.Size = new Size(99, 15);
            nameOfUser.TabIndex = 0;
            nameOfUser.Text = "namePlaceholder";
            // 
            // timeDisplay
            // 
            timeDisplay.Interval = 1000;
            // 
            // valuCardPresentStrip
            // 
            valuCardPresentStrip.BackColor = Color.MediumTurquoise;
            valuCardPresentStrip.Controls.Add(topPanelContainer);
            valuCardPresentStrip.Location = new Point(0, 0);
            valuCardPresentStrip.Name = "valuCardPresentStrip";
            valuCardPresentStrip.Size = new Size(1191, 60);
            valuCardPresentStrip.TabIndex = 0;
            // 
            // topPanelContainer
            // 
            topPanelContainer.Dock = DockStyle.Top;
            topPanelContainer.Location = new Point(0, 0);
            topPanelContainer.Name = "topPanelContainer";
            topPanelContainer.Size = new Size(1191, 94);
            topPanelContainer.TabIndex = 2;
            // 
            // valuCardHolderInfo
            // 
            valuCardHolderInfo.BackColor = Color.PapayaWhip;
            valuCardHolderInfo.Location = new Point(0, 60);
            valuCardHolderInfo.Name = "valuCardHolderInfo";
            valuCardHolderInfo.Size = new Size(1191, 34);
            valuCardHolderInfo.TabIndex = 1;
            // 
            // signOff
            // 
            signOff.BackColor = Color.Red;
            signOff.FlatStyle = FlatStyle.Flat;
            signOff.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            signOff.ForeColor = Color.White;
            signOff.Location = new Point(0, 0);
            signOff.Margin = new Padding(0);
            signOff.Name = "signOff";
            signOff.Size = new Size(185, 142);
            signOff.TabIndex = 0;
            signOff.Text = "SIGN\r\nOFF";
            signOff.TextAlign = ContentAlignment.TopLeft;
            signOff.UseVisualStyleBackColor = false;
            signOff.Click += signOff_Click;
            signOff.Margin = Padding.Empty;
            signOff.FlatAppearance.BorderSize = 0;
            signOff.Padding = Padding.Empty;
            signOff.TabStop = false;
            // 
            // buttonContainer
            // 
            buttonContainer.Controls.Add(bakeryDeliMenu);
            buttonContainer.Controls.Add(signOff);
            buttonContainer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonContainer.Location = new Point(1191, 0);
            buttonContainer.Name = "buttonContainer";
            buttonContainer.Size = new Size(305, 525);
            buttonContainer.TabIndex = 2;
            buttonContainer.Dock = DockStyle.Right;
            // 
            // bakeryDeliMenu
            // 
            bakeryDeliMenu.BackColor = Color.Green;
            bakeryDeliMenu.FlatStyle = FlatStyle.Flat;
            bakeryDeliMenu.ForeColor = Color.White;
            bakeryDeliMenu.Location = new Point(184, 0);
            bakeryDeliMenu.Margin = new Padding(0);
            bakeryDeliMenu.Name = "bakeryDeliMenu";
            bakeryDeliMenu.Size = new Size(121, 142);
            bakeryDeliMenu.TabIndex = 1;
            bakeryDeliMenu.Text = "BAKERY\r\nDELI\r\nMENU";
            bakeryDeliMenu.TextAlign = ContentAlignment.TopLeft;
            bakeryDeliMenu.UseVisualStyleBackColor = false;
            bakeryDeliMenu.FlatAppearance.BorderSize = 0;
            bakeryDeliMenu.Margin = Padding.Empty;
            bakeryDeliMenu.Padding = Padding.Empty;
            bakeryDeliMenu.TabStop = false;

            // 
            // MainPOSForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1496, 614);
            Controls.Add(buttonContainer);
            Controls.Add(valuCardHolderInfo);
            Controls.Add(valuCardPresentStrip);
            Controls.Add(bottomPanel);
            Name = "MainPOSForm";
            Text = "MainPOSForm";
            Load += MainPOSForm_Load;
            bottomPanel.ResumeLayout(false);
            bottomPanel.PerformLayout();
            valuCardPresentStrip.ResumeLayout(false);
            buttonContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void displayTime_Tick(object sender, EventArgs e)
        {
            // Update the label with the current time
            currentTime.Text = DateTime.Now.ToString("hh:mm:ss tt");

            if (POSSession.valuCardApplied)
            {
                valuCardPresentStrip.BackColor = Color.Red;
            }
            else
            {
                valuCardPresentStrip.BackColor = Color.MediumTurquoise;
            }
        }

        #endregion

        private Panel bottomPanel;
        private Label nameOfUser;
        private Label connectionStatus;
        private System.Windows.Forms.Timer timeDisplay;
        private Label currentTime;
        private Label currentDate;
        private Label readyLabel;
        private Panel valuCardPresentStrip;
        private Panel valuCardHolderInfo;
        private Label topPanelContainer;
        private System.Windows.Forms.Button signOff;
        private Panel buttonContainer;
        private System.Windows.Forms.Button bakeryDeliMenu;
    }
}