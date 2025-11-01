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

        private void middleContainer_Resize(object sender, EventArgs e)
        {

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
            total = new System.Windows.Forms.Button();
            enterItem = new System.Windows.Forms.Button();
            voidMenu = new System.Windows.Forms.Button();
            posMenu = new System.Windows.Forms.Button();
            produceMenu = new System.Windows.Forms.Button();
            departmentLookup = new System.Windows.Forms.Button();
            itemSearch = new System.Windows.Forms.Button();
            customerLookup = new System.Windows.Forms.Button();
            bakeryDeliMenu = new System.Windows.Forms.Button();
            backspace = new System.Windows.Forms.Button();
            middleContainer = new Panel();
            bottomPanel.SuspendLayout();
            valuCardPresentStrip.SuspendLayout();
            buttonContainer.SuspendLayout();
            middleContainer.SuspendLayout();
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
            currentDate.Text = "11/01/2025";
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
            signOff.FlatAppearance.BorderSize = 0;
            signOff.FlatStyle = FlatStyle.Flat;
            signOff.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            signOff.ForeColor = Color.White;
            signOff.Location = new Point(0, 0);
            signOff.Margin = new Padding(0);
            signOff.Name = "signOff";
            signOff.Size = new Size(207, 128);
            signOff.TabIndex = 0;
            signOff.TabStop = false;
            signOff.Text = "SIGN\r\nOFF";
            signOff.TextAlign = ContentAlignment.TopLeft;
            signOff.UseVisualStyleBackColor = false;
            signOff.Click += signOff_Click;
            // 
            // buttonContainer
            // 
            buttonContainer.Controls.Add(total);
            buttonContainer.Controls.Add(enterItem);
            buttonContainer.Controls.Add(voidMenu);
            buttonContainer.Controls.Add(posMenu);
            buttonContainer.Controls.Add(produceMenu);
            buttonContainer.Controls.Add(departmentLookup);
            buttonContainer.Controls.Add(itemSearch);
            buttonContainer.Controls.Add(customerLookup);
            buttonContainer.Controls.Add(bakeryDeliMenu);
            buttonContainer.Controls.Add(signOff);
            buttonContainer.Dock = DockStyle.Right;
            buttonContainer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonContainer.Location = new Point(1191, 0);
            buttonContainer.Name = "buttonContainer";
            buttonContainer.Size = new Size(305, 594);
            buttonContainer.TabIndex = 2;
            // 
            // total
            // 
            total.BackColor = Color.Red;
            total.FlatAppearance.BorderSize = 0;
            total.FlatStyle = FlatStyle.Flat;
            total.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            total.ForeColor = Color.White;
            total.ImageAlign = ContentAlignment.TopLeft;
            total.Location = new Point(103, 460);
            total.Margin = new Padding(0);
            total.Name = "total";
            total.Size = new Size(202, 134);
            total.TabIndex = 9;
            total.TabStop = false;
            total.Text = "TOTAL";
            total.TextAlign = ContentAlignment.TopLeft;
            total.UseVisualStyleBackColor = false;
            // 
            // enterItem
            // 
            enterItem.BackColor = Color.Blue;
            enterItem.FlatAppearance.BorderSize = 0;
            enterItem.FlatStyle = FlatStyle.Flat;
            enterItem.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            enterItem.ForeColor = Color.White;
            enterItem.ImageAlign = ContentAlignment.TopCenter;
            enterItem.Location = new Point(0, 460);
            enterItem.Margin = new Padding(0);
            enterItem.Name = "enterItem";
            enterItem.Size = new Size(103, 134);
            enterItem.TabIndex = 8;
            enterItem.Text = "ENTER\r\nITEM";
            enterItem.TextAlign = ContentAlignment.TopLeft;
            enterItem.UseVisualStyleBackColor = false;
            // 
            // voidMenu
            // 
            voidMenu.BackColor = Color.Yellow;
            voidMenu.FlatAppearance.BorderSize = 0;
            voidMenu.FlatStyle = FlatStyle.Flat;
            voidMenu.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            voidMenu.ForeColor = Color.Red;
            voidMenu.ImageAlign = ContentAlignment.TopCenter;
            voidMenu.Location = new Point(207, 333);
            voidMenu.Margin = new Padding(0);
            voidMenu.Name = "voidMenu";
            voidMenu.Size = new Size(98, 127);
            voidMenu.TabIndex = 7;
            voidMenu.Text = "VOID\r\nMENU";
            voidMenu.TextAlign = ContentAlignment.TopLeft;
            voidMenu.UseVisualStyleBackColor = false;
            // 
            // posMenu
            // 
            posMenu.BackColor = Color.DarkOrange;
            posMenu.FlatAppearance.BorderSize = 0;
            posMenu.FlatStyle = FlatStyle.Flat;
            posMenu.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            posMenu.ImageAlign = ContentAlignment.TopLeft;
            posMenu.Location = new Point(0, 333);
            posMenu.Margin = new Padding(0);
            posMenu.Name = "posMenu";
            posMenu.Size = new Size(207, 127);
            posMenu.TabIndex = 6;
            posMenu.TabStop = false;
            posMenu.Text = "POS\r\nMENU";
            posMenu.TextAlign = ContentAlignment.TopLeft;
            posMenu.UseVisualStyleBackColor = false;
            // 
            // produceMenu
            // 
            produceMenu.BackColor = Color.DarkGreen;
            produceMenu.FlatAppearance.BorderSize = 0;
            produceMenu.FlatStyle = FlatStyle.Flat;
            produceMenu.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            produceMenu.ForeColor = Color.White;
            produceMenu.ImageAlign = ContentAlignment.TopLeft;
            produceMenu.Location = new Point(0, 291);
            produceMenu.Margin = new Padding(0);
            produceMenu.Name = "produceMenu";
            produceMenu.Size = new Size(305, 42);
            produceMenu.TabIndex = 5;
            produceMenu.TabStop = false;
            produceMenu.Text = "PRODUCE MENU";
            produceMenu.TextAlign = ContentAlignment.TopLeft;
            produceMenu.UseVisualStyleBackColor = false;
            // 
            // departmentLookup
            // 
            departmentLookup.BackColor = Color.Gold;
            departmentLookup.FlatAppearance.BorderSize = 0;
            departmentLookup.FlatStyle = FlatStyle.Flat;
            departmentLookup.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            departmentLookup.ImageAlign = ContentAlignment.TopLeft;
            departmentLookup.Location = new Point(0, 249);
            departmentLookup.Margin = new Padding(0);
            departmentLookup.Name = "departmentLookup";
            departmentLookup.Size = new Size(305, 42);
            departmentLookup.TabIndex = 4;
            departmentLookup.TabStop = false;
            departmentLookup.Text = "DEPARTMENTS";
            departmentLookup.TextAlign = ContentAlignment.TopLeft;
            departmentLookup.UseVisualStyleBackColor = false;
            // 
            // itemSearch
            // 
            itemSearch.BackColor = Color.FromArgb(255, 128, 0);
            itemSearch.FlatAppearance.BorderSize = 0;
            itemSearch.FlatStyle = FlatStyle.Flat;
            itemSearch.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            itemSearch.ForeColor = Color.White;
            itemSearch.Location = new Point(207, 128);
            itemSearch.Margin = new Padding(0);
            itemSearch.Name = "itemSearch";
            itemSearch.Size = new Size(98, 121);
            itemSearch.TabIndex = 3;
            itemSearch.Text = "ITEM\r\nSEARCH";
            itemSearch.TextAlign = ContentAlignment.TopLeft;
            itemSearch.UseVisualStyleBackColor = false;
            // 
            // customerLookup
            // 
            customerLookup.BackColor = Color.Blue;
            customerLookup.FlatAppearance.BorderSize = 0;
            customerLookup.FlatStyle = FlatStyle.Flat;
            customerLookup.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            customerLookup.ForeColor = Color.White;
            customerLookup.Location = new Point(0, 128);
            customerLookup.Margin = new Padding(0);
            customerLookup.Name = "customerLookup";
            customerLookup.Size = new Size(207, 121);
            customerLookup.TabIndex = 2;
            customerLookup.TabStop = false;
            customerLookup.Text = "CUSTOMER\r\nLOOKUP";
            customerLookup.TextAlign = ContentAlignment.TopLeft;
            customerLookup.UseVisualStyleBackColor = false;
            // 
            // bakeryDeliMenu
            // 
            bakeryDeliMenu.BackColor = Color.Green;
            bakeryDeliMenu.FlatAppearance.BorderSize = 0;
            bakeryDeliMenu.FlatStyle = FlatStyle.Flat;
            bakeryDeliMenu.ForeColor = Color.White;
            bakeryDeliMenu.Location = new Point(207, 0);
            bakeryDeliMenu.Margin = new Padding(0);
            bakeryDeliMenu.Name = "bakeryDeliMenu";
            bakeryDeliMenu.Size = new Size(98, 128);
            bakeryDeliMenu.TabIndex = 1;
            bakeryDeliMenu.TabStop = false;
            bakeryDeliMenu.Text = "BAKERY\r\nDELI\r\nMENU";
            bakeryDeliMenu.TextAlign = ContentAlignment.TopLeft;
            bakeryDeliMenu.UseVisualStyleBackColor = false;
            // 
            // backspace
            // 
            backspace.BackColor = Color.DarkGray;
            backspace.FlatAppearance.BorderSize = 0;
            backspace.FlatStyle = FlatStyle.Flat;
            backspace.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            backspace.ForeColor = Color.White;
            backspace.ImageAlign = ContentAlignment.TopLeft;
            backspace.Location = new Point(824, 0);
            backspace.Margin = new Padding(0);
            backspace.Name = "backspace";
            backspace.Size = new Size(73, 63);
            backspace.TabIndex = 8;
            backspace.Text = "BKSP";
            backspace.TextAlign = ContentAlignment.TopLeft;
            backspace.UseVisualStyleBackColor = false;
            // 
            // middleContainer
            // 
            middleContainer.Controls.Add(backspace);
            middleContainer.Location = new Point(294, 333);
            middleContainer.Name = "middleContainer";
            middleContainer.Size = new Size(897, 261);
            middleContainer.TabIndex = 9;
            // 
            // MainPOSForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1496, 614);
            Controls.Add(middleContainer);
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
            middleContainer.ResumeLayout(false);
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
        private System.Windows.Forms.Button customerLookup;
        private System.Windows.Forms.Button itemSearch;
        private System.Windows.Forms.Button departmentLookup;
        private System.Windows.Forms.Button produceMenu;
        private System.Windows.Forms.Button voidMenu;
        private System.Windows.Forms.Button posMenu;
        private System.Windows.Forms.Button enterItem;
        private System.Windows.Forms.Button total;
        private System.Windows.Forms.Button backspace;
        private Panel middleContainer;
    }
}