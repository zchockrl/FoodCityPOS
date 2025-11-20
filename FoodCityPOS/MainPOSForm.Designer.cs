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
            bottomPanel.Width = this.ClientSize.Width;
            buttonContainer.Width = (int)(this.ClientSize.Width * 0.15);
            buttonContainer.Height = this.ClientSize.Height - bottomPanel.Height;
            bottomContainer.Width = (int)(this.ClientSize.Width * .85);
            bottomContainer.Height = (int)(this.ClientSize.Height * .43);

            numberContainer.Size = new Size((int)(bottomContainer.Width * 0.47), bottomContainer.Height);

            orderItemDisplayContainer.Width = (int)(this.ClientSize.Width * .85);
            orderItemDisplayContainer.Height = (int)(this.ClientSize.Height * .4084);
        }



        private void middleContainer_Resize(object sender, EventArgs e)
        {

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
            customerDisplayPreface = new Label();
            textDisplay = new Label();
            customerNameDisplay = new System.Windows.Forms.TextBox();
            signOff = new System.Windows.Forms.Button();
            buttonContainer = new Panel();
            rightButtonLayout = new TableLayoutPanel();
            bottomRowLayout = new TableLayoutPanel();
            total = new System.Windows.Forms.Button();
            enterItem = new System.Windows.Forms.Button();
            bakeryDeliMenu = new System.Windows.Forms.Button();
            voidMenu = new System.Windows.Forms.Button();
            produceMenu = new System.Windows.Forms.Button();
            customerLookup = new System.Windows.Forms.Button();
            posMenu = new System.Windows.Forms.Button();
            itemSearch = new System.Windows.Forms.Button();
            departmentLookup = new System.Windows.Forms.Button();
            bottomContainer = new Panel();
            orderTotalsContainer = new TableLayoutPanel();
            subtotalString = new Label();
            numberContainer = new TableLayoutPanel();
            posAtSign = new System.Windows.Forms.Button();
            posOK = new System.Windows.Forms.Button();
            posClear = new System.Windows.Forms.Button();
            pos3 = new System.Windows.Forms.Button();
            pos2 = new System.Windows.Forms.Button();
            pos5 = new System.Windows.Forms.Button();
            pos4 = new System.Windows.Forms.Button();
            backspace = new System.Windows.Forms.Button();
            pos9 = new System.Windows.Forms.Button();
            pos8 = new System.Windows.Forms.Button();
            pos7 = new System.Windows.Forms.Button();
            pos6 = new System.Windows.Forms.Button();
            pos1 = new System.Windows.Forms.Button();
            pos0 = new System.Windows.Forms.Button();
            pos00 = new System.Windows.Forms.Button();
            orderItemDisplayContainer = new Panel();
            taxString = new Label();
            totalString = new Label();
            tenderedString = new Label();
            bottomPanel.SuspendLayout();
            valuCardPresentStrip.SuspendLayout();
            valuCardHolderInfo.SuspendLayout();
            buttonContainer.SuspendLayout();
            rightButtonLayout.SuspendLayout();
            bottomRowLayout.SuspendLayout();
            bottomContainer.SuspendLayout();
            orderTotalsContainer.SuspendLayout();
            numberContainer.SuspendLayout();
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
            valuCardPresentStrip.Size = new Size(1212, 60);
            valuCardPresentStrip.TabIndex = 0;
            // 
            // topPanelContainer
            // 
            topPanelContainer.Dock = DockStyle.Top;
            topPanelContainer.Location = new Point(0, 0);
            topPanelContainer.Name = "topPanelContainer";
            topPanelContainer.Size = new Size(1212, 94);
            topPanelContainer.TabIndex = 2;
            // 
            // valuCardHolderInfo
            // 
            valuCardHolderInfo.BackColor = Color.PapayaWhip;
            valuCardHolderInfo.Controls.Add(customerDisplayPreface);
            valuCardHolderInfo.Controls.Add(textDisplay);
            valuCardHolderInfo.Controls.Add(customerNameDisplay);
            valuCardHolderInfo.Location = new Point(0, 60);
            valuCardHolderInfo.Name = "valuCardHolderInfo";
            valuCardHolderInfo.Size = new Size(1212, 34);
            valuCardHolderInfo.TabIndex = 1;
            // 
            // customerDisplayPreface
            // 
            customerDisplayPreface.BackColor = Color.PapayaWhip;
            customerDisplayPreface.Font = new Font("Segoe UI", 12F);
            customerDisplayPreface.Location = new Point(799, 3);
            customerDisplayPreface.Margin = new Padding(0);
            customerDisplayPreface.Name = "customerDisplayPreface";
            customerDisplayPreface.Size = new Size(100, 22);
            customerDisplayPreface.TabIndex = 1;
            customerDisplayPreface.Text = "Customer:\r\n";
            customerDisplayPreface.Visible = false;
            // 
            // textDisplay
            // 
            textDisplay.BackColor = Color.PapayaWhip;
            textDisplay.Font = new Font("Segoe UI", 16F);
            textDisplay.Location = new Point(18, 0);
            textDisplay.Margin = new Padding(0);
            textDisplay.Name = "textDisplay";
            textDisplay.Size = new Size(370, 29);
            textDisplay.TabIndex = 2;
            textDisplay.Text = "4011";
            // 
            // customerNameDisplay
            // 
            customerNameDisplay.BackColor = Color.PapayaWhip;
            customerNameDisplay.BorderStyle = BorderStyle.None;
            customerNameDisplay.Dock = DockStyle.Right;
            customerNameDisplay.Font = new Font("Segoe UI", 20F);
            customerNameDisplay.Location = new Point(899, 0);
            customerNameDisplay.Margin = new Padding(0);
            customerNameDisplay.Multiline = true;
            customerNameDisplay.Name = "customerNameDisplay";
            customerNameDisplay.Size = new Size(313, 34);
            customerNameDisplay.TabIndex = 0;
            customerNameDisplay.TabStop = false;
            customerNameDisplay.TextAlign = HorizontalAlignment.Center;
            customerNameDisplay.Visible = false;
            // 
            // signOff
            // 
            signOff.BackColor = Color.Red;
            signOff.Dock = DockStyle.Fill;
            signOff.FlatAppearance.BorderSize = 0;
            signOff.FlatStyle = FlatStyle.Flat;
            signOff.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            signOff.ForeColor = Color.White;
            signOff.Location = new Point(0, 0);
            signOff.Margin = new Padding(0);
            signOff.Name = "signOff";
            signOff.Size = new Size(198, 124);
            signOff.TabIndex = 0;
            signOff.TabStop = false;
            signOff.Text = "SIGN\r\nOFF";
            signOff.TextAlign = ContentAlignment.TopLeft;
            signOff.UseVisualStyleBackColor = false;
            signOff.Click += signOff_Click;
            // 
            // buttonContainer
            // 
            buttonContainer.Controls.Add(rightButtonLayout);
            buttonContainer.Dock = DockStyle.Right;
            buttonContainer.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonContainer.Location = new Point(1212, 0);
            buttonContainer.Name = "buttonContainer";
            buttonContainer.Size = new Size(284, 594);
            buttonContainer.TabIndex = 2;
            buttonContainer.Paint += buttonContainer_Paint;
            // 
            // rightButtonLayout
            // 
            rightButtonLayout.ColumnCount = 2;
            rightButtonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            rightButtonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            rightButtonLayout.Controls.Add(bottomRowLayout, 0, 5);
            rightButtonLayout.Controls.Add(signOff, 0, 0);
            rightButtonLayout.Controls.Add(bakeryDeliMenu, 1, 0);
            rightButtonLayout.Controls.Add(voidMenu, 1, 4);
            rightButtonLayout.Controls.Add(produceMenu, 0, 3);
            rightButtonLayout.Controls.Add(customerLookup, 0, 1);
            rightButtonLayout.Controls.Add(posMenu, 0, 4);
            rightButtonLayout.Controls.Add(itemSearch, 1, 1);
            rightButtonLayout.Controls.Add(departmentLookup, 0, 2);
            rightButtonLayout.Dock = DockStyle.Fill;
            rightButtonLayout.Location = new Point(0, 0);
            rightButtonLayout.Name = "rightButtonLayout";
            rightButtonLayout.RowCount = 6;
            rightButtonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 21F));
            rightButtonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            rightButtonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            rightButtonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            rightButtonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 21F));
            rightButtonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 22F));
            rightButtonLayout.Size = new Size(284, 594);
            rightButtonLayout.TabIndex = 0;
            // 
            // bottomRowLayout
            // 
            bottomRowLayout.ColumnCount = 2;
            rightButtonLayout.SetColumnSpan(bottomRowLayout, 2);
            bottomRowLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            bottomRowLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            bottomRowLayout.Controls.Add(total, 1, 0);
            bottomRowLayout.Controls.Add(enterItem, 0, 0);
            bottomRowLayout.Dock = DockStyle.Fill;
            bottomRowLayout.Location = new Point(0, 460);
            bottomRowLayout.Margin = new Padding(0);
            bottomRowLayout.Name = "bottomRowLayout";
            bottomRowLayout.RowCount = 1;
            bottomRowLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            bottomRowLayout.Size = new Size(284, 134);
            bottomRowLayout.TabIndex = 10;
            // 
            // total
            // 
            total.BackColor = Color.Red;
            total.Dock = DockStyle.Fill;
            total.FlatAppearance.BorderSize = 0;
            total.FlatStyle = FlatStyle.Flat;
            total.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            total.ForeColor = Color.White;
            total.ImageAlign = ContentAlignment.TopLeft;
            total.Location = new Point(113, 0);
            total.Margin = new Padding(0);
            total.Name = "total";
            total.Size = new Size(171, 134);
            total.TabIndex = 10;
            total.TabStop = false;
            total.Text = "TOTAL";
            total.TextAlign = ContentAlignment.TopLeft;
            total.UseVisualStyleBackColor = false;
            // 
            // enterItem
            // 
            enterItem.BackColor = Color.Blue;
            enterItem.Dock = DockStyle.Fill;
            enterItem.FlatAppearance.BorderSize = 0;
            enterItem.FlatStyle = FlatStyle.Flat;
            enterItem.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            enterItem.ForeColor = Color.White;
            enterItem.ImageAlign = ContentAlignment.TopCenter;
            enterItem.Location = new Point(0, 0);
            enterItem.Margin = new Padding(0);
            enterItem.Name = "enterItem";
            enterItem.Size = new Size(113, 134);
            enterItem.TabIndex = 8;
            enterItem.Text = "ENTER\r\nITEM";
            enterItem.TextAlign = ContentAlignment.TopLeft;
            enterItem.UseVisualStyleBackColor = false;
            // 
            // bakeryDeliMenu
            // 
            bakeryDeliMenu.BackColor = Color.Green;
            bakeryDeliMenu.Dock = DockStyle.Fill;
            bakeryDeliMenu.FlatAppearance.BorderSize = 0;
            bakeryDeliMenu.FlatStyle = FlatStyle.Flat;
            bakeryDeliMenu.ForeColor = Color.White;
            bakeryDeliMenu.Location = new Point(198, 0);
            bakeryDeliMenu.Margin = new Padding(0);
            bakeryDeliMenu.Name = "bakeryDeliMenu";
            bakeryDeliMenu.Size = new Size(86, 124);
            bakeryDeliMenu.TabIndex = 1;
            bakeryDeliMenu.TabStop = false;
            bakeryDeliMenu.Text = "BAKERY\r\nDELI\r\nMENU";
            bakeryDeliMenu.TextAlign = ContentAlignment.TopLeft;
            bakeryDeliMenu.UseVisualStyleBackColor = false;
            // 
            // voidMenu
            // 
            voidMenu.BackColor = Color.Yellow;
            voidMenu.Dock = DockStyle.Fill;
            voidMenu.FlatAppearance.BorderSize = 0;
            voidMenu.FlatStyle = FlatStyle.Flat;
            voidMenu.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            voidMenu.ForeColor = Color.Red;
            voidMenu.ImageAlign = ContentAlignment.TopCenter;
            voidMenu.Location = new Point(198, 336);
            voidMenu.Margin = new Padding(0);
            voidMenu.Name = "voidMenu";
            voidMenu.Size = new Size(86, 124);
            voidMenu.TabIndex = 7;
            voidMenu.Text = "VOID\r\nMENU";
            voidMenu.TextAlign = ContentAlignment.TopLeft;
            voidMenu.UseVisualStyleBackColor = false;
            voidMenu.Click += voidMenu_Click;
            // 
            // produceMenu
            // 
            produceMenu.BackColor = Color.DarkGreen;
            rightButtonLayout.SetColumnSpan(produceMenu, 2);
            produceMenu.Dock = DockStyle.Fill;
            produceMenu.FlatAppearance.BorderSize = 0;
            produceMenu.FlatStyle = FlatStyle.Flat;
            produceMenu.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            produceMenu.ForeColor = Color.White;
            produceMenu.ImageAlign = ContentAlignment.TopLeft;
            produceMenu.Location = new Point(0, 289);
            produceMenu.Margin = new Padding(0);
            produceMenu.Name = "produceMenu";
            produceMenu.Size = new Size(284, 47);
            produceMenu.TabIndex = 5;
            produceMenu.TabStop = false;
            produceMenu.Text = "PRODUCE MENU";
            produceMenu.TextAlign = ContentAlignment.TopLeft;
            produceMenu.UseVisualStyleBackColor = false;
            // 
            // customerLookup
            // 
            customerLookup.BackColor = Color.Blue;
            customerLookup.Dock = DockStyle.Fill;
            customerLookup.FlatAppearance.BorderSize = 0;
            customerLookup.FlatStyle = FlatStyle.Flat;
            customerLookup.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            customerLookup.ForeColor = Color.White;
            customerLookup.Location = new Point(0, 124);
            customerLookup.Margin = new Padding(0);
            customerLookup.Name = "customerLookup";
            customerLookup.Size = new Size(198, 118);
            customerLookup.TabIndex = 2;
            customerLookup.TabStop = false;
            customerLookup.Text = "CUSTOMER\r\nLOOKUP";
            customerLookup.TextAlign = ContentAlignment.TopLeft;
            customerLookup.UseVisualStyleBackColor = false;
            customerLookup.Click += customerLookup_Click;
            // 
            // posMenu
            // 
            posMenu.BackColor = Color.DarkOrange;
            posMenu.Dock = DockStyle.Fill;
            posMenu.FlatAppearance.BorderSize = 0;
            posMenu.FlatStyle = FlatStyle.Flat;
            posMenu.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            posMenu.ImageAlign = ContentAlignment.TopLeft;
            posMenu.Location = new Point(0, 336);
            posMenu.Margin = new Padding(0);
            posMenu.Name = "posMenu";
            posMenu.Size = new Size(198, 124);
            posMenu.TabIndex = 6;
            posMenu.TabStop = false;
            posMenu.Text = "POS\r\nMENU";
            posMenu.TextAlign = ContentAlignment.TopLeft;
            posMenu.UseVisualStyleBackColor = false;
            // 
            // itemSearch
            // 
            itemSearch.BackColor = Color.FromArgb(255, 128, 0);
            itemSearch.Dock = DockStyle.Fill;
            itemSearch.FlatAppearance.BorderSize = 0;
            itemSearch.FlatStyle = FlatStyle.Flat;
            itemSearch.Font = new Font("Segoe UI", 11.2F, FontStyle.Bold);
            itemSearch.ForeColor = Color.White;
            itemSearch.Location = new Point(198, 124);
            itemSearch.Margin = new Padding(0);
            itemSearch.Name = "itemSearch";
            itemSearch.Size = new Size(86, 118);
            itemSearch.TabIndex = 3;
            itemSearch.Text = "ITEM\r\nSEARCH";
            itemSearch.TextAlign = ContentAlignment.TopLeft;
            itemSearch.UseVisualStyleBackColor = false;
            // 
            // departmentLookup
            // 
            departmentLookup.BackColor = Color.Gold;
            rightButtonLayout.SetColumnSpan(departmentLookup, 2);
            departmentLookup.Dock = DockStyle.Fill;
            departmentLookup.FlatAppearance.BorderSize = 0;
            departmentLookup.FlatStyle = FlatStyle.Flat;
            departmentLookup.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            departmentLookup.ImageAlign = ContentAlignment.TopLeft;
            departmentLookup.Location = new Point(0, 242);
            departmentLookup.Margin = new Padding(0);
            departmentLookup.Name = "departmentLookup";
            departmentLookup.Size = new Size(284, 47);
            departmentLookup.TabIndex = 4;
            departmentLookup.TabStop = false;
            departmentLookup.Text = "DEPARTMENTS";
            departmentLookup.TextAlign = ContentAlignment.TopLeft;
            departmentLookup.UseVisualStyleBackColor = false;
            // 
            // bottomContainer
            // 
            bottomContainer.Controls.Add(orderTotalsContainer);
            bottomContainer.Controls.Add(numberContainer);
            bottomContainer.Dock = DockStyle.Bottom;
            bottomContainer.Location = new Point(0, 336);
            bottomContainer.Margin = new Padding(0);
            bottomContainer.Name = "bottomContainer";
            bottomContainer.Size = new Size(1212, 258);
            bottomContainer.TabIndex = 9;
            // 
            // orderTotalsContainer
            // 
            orderTotalsContainer.BackColor = Color.Teal;
            orderTotalsContainer.ColumnCount = 1;
            orderTotalsContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            orderTotalsContainer.Controls.Add(tenderedString, 0, 3);
            orderTotalsContainer.Controls.Add(totalString, 0, 2);
            orderTotalsContainer.Controls.Add(taxString, 0, 1);
            orderTotalsContainer.Controls.Add(subtotalString, 0, 0);
            orderTotalsContainer.Dock = DockStyle.Left;
            orderTotalsContainer.Location = new Point(0, 0);
            orderTotalsContainer.Margin = new Padding(0);
            orderTotalsContainer.Name = "orderTotalsContainer";
            orderTotalsContainer.RowCount = 5;
            orderTotalsContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            orderTotalsContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            orderTotalsContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            orderTotalsContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            orderTotalsContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            orderTotalsContainer.Size = new Size(693, 258);
            orderTotalsContainer.TabIndex = 1;
            // 
            // subtotalString
            // 
            subtotalString.Anchor = AnchorStyles.Left;
            subtotalString.AutoSize = true;
            subtotalString.Font = new Font("Segoe UI", 20F);
            subtotalString.ForeColor = Color.White;
            subtotalString.Location = new Point(3, 2);
            subtotalString.Name = "subtotalString";
            subtotalString.Padding = new Padding(10, 5, 10, 5);
            subtotalString.Size = new Size(137, 47);
            subtotalString.TabIndex = 0;
            subtotalString.Text = "Subtotal";
            // 
            // numberContainer
            // 
            numberContainer.ColumnCount = 4;
            numberContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            numberContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            numberContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.8778877F));
            numberContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.2871284F));
            numberContainer.Controls.Add(posAtSign, 2, 3);
            numberContainer.Controls.Add(posOK, 3, 2);
            numberContainer.Controls.Add(posClear, 3, 1);
            numberContainer.Controls.Add(pos3, 2, 2);
            numberContainer.Controls.Add(pos2, 1, 2);
            numberContainer.Controls.Add(pos5, 1, 1);
            numberContainer.Controls.Add(pos4, 0, 1);
            numberContainer.Controls.Add(backspace, 3, 0);
            numberContainer.Controls.Add(pos9, 2, 0);
            numberContainer.Controls.Add(pos8, 1, 0);
            numberContainer.Controls.Add(pos7, 0, 0);
            numberContainer.Controls.Add(pos6, 2, 1);
            numberContainer.Controls.Add(pos1, 0, 2);
            numberContainer.Controls.Add(pos0, 0, 3);
            numberContainer.Controls.Add(pos00, 1, 3);
            numberContainer.Dock = DockStyle.Right;
            numberContainer.Location = new Point(693, 0);
            numberContainer.Margin = new Padding(0);
            numberContainer.Name = "numberContainer";
            numberContainer.RowCount = 4;
            numberContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 22.48062F));
            numberContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 27.1317825F));
            numberContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            numberContainer.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            numberContainer.Size = new Size(519, 258);
            numberContainer.TabIndex = 0;
            // 
            // posAtSign
            // 
            posAtSign.BackColor = Color.Goldenrod;
            posAtSign.Dock = DockStyle.Fill;
            posAtSign.FlatAppearance.BorderColor = Color.Gray;
            posAtSign.FlatStyle = FlatStyle.Flat;
            posAtSign.Font = new Font("Segoe UI", 16F);
            posAtSign.ForeColor = Color.Red;
            posAtSign.Location = new Point(258, 192);
            posAtSign.Margin = new Padding(0);
            posAtSign.Name = "posAtSign";
            posAtSign.Size = new Size(149, 66);
            posAtSign.TabIndex = 14;
            posAtSign.Text = "@";
            posAtSign.TextAlign = ContentAlignment.TopLeft;
            posAtSign.UseVisualStyleBackColor = false;
            // 
            // posOK
            // 
            posOK.BackColor = Color.DarkGreen;
            posOK.Dock = DockStyle.Fill;
            posOK.FlatAppearance.BorderSize = 0;
            posOK.FlatStyle = FlatStyle.Flat;
            posOK.ForeColor = Color.White;
            posOK.Location = new Point(407, 128);
            posOK.Margin = new Padding(0);
            posOK.Name = "posOK";
            numberContainer.SetRowSpan(posOK, 2);
            posOK.Size = new Size(112, 130);
            posOK.TabIndex = 13;
            posOK.Text = "OK";
            posOK.TextAlign = ContentAlignment.TopLeft;
            posOK.UseVisualStyleBackColor = false;
            // 
            // posClear
            // 
            posClear.BackColor = Color.Red;
            posClear.Dock = DockStyle.Fill;
            posClear.FlatAppearance.BorderSize = 0;
            posClear.FlatStyle = FlatStyle.Flat;
            posClear.ForeColor = Color.White;
            posClear.Location = new Point(407, 58);
            posClear.Margin = new Padding(0);
            posClear.Name = "posClear";
            posClear.Size = new Size(112, 70);
            posClear.TabIndex = 12;
            posClear.Text = "CLEAR";
            posClear.TextAlign = ContentAlignment.TopLeft;
            posClear.UseVisualStyleBackColor = false;
            // 
            // pos3
            // 
            pos3.BackColor = Color.LightGray;
            pos3.Dock = DockStyle.Fill;
            pos3.FlatAppearance.BorderColor = Color.Gray;
            pos3.FlatStyle = FlatStyle.Flat;
            pos3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            pos3.Location = new Point(258, 128);
            pos3.Margin = new Padding(0);
            pos3.Name = "pos3";
            pos3.Size = new Size(149, 64);
            pos3.TabIndex = 10;
            pos3.Text = "3";
            pos3.TextAlign = ContentAlignment.TopLeft;
            pos3.UseVisualStyleBackColor = false;
            // 
            // pos2
            // 
            pos2.BackColor = Color.LightGray;
            pos2.Dock = DockStyle.Fill;
            pos2.FlatAppearance.BorderColor = Color.Gray;
            pos2.FlatStyle = FlatStyle.Flat;
            pos2.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            pos2.Location = new Point(129, 128);
            pos2.Margin = new Padding(0);
            pos2.Name = "pos2";
            pos2.Size = new Size(129, 64);
            pos2.TabIndex = 9;
            pos2.Text = "2";
            pos2.TextAlign = ContentAlignment.TopLeft;
            pos2.UseVisualStyleBackColor = false;
            // 
            // pos5
            // 
            pos5.BackColor = Color.LightGray;
            pos5.Dock = DockStyle.Fill;
            pos5.FlatAppearance.BorderColor = Color.Gray;
            pos5.FlatStyle = FlatStyle.Flat;
            pos5.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            pos5.Location = new Point(129, 58);
            pos5.Margin = new Padding(0);
            pos5.Name = "pos5";
            pos5.Size = new Size(129, 70);
            pos5.TabIndex = 6;
            pos5.Text = "5";
            pos5.TextAlign = ContentAlignment.TopLeft;
            pos5.UseVisualStyleBackColor = false;
            // 
            // pos4
            // 
            pos4.BackColor = Color.LightGray;
            pos4.Dock = DockStyle.Fill;
            pos4.FlatAppearance.BorderColor = Color.Gray;
            pos4.FlatStyle = FlatStyle.Flat;
            pos4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            pos4.Location = new Point(0, 58);
            pos4.Margin = new Padding(0);
            pos4.Name = "pos4";
            pos4.Size = new Size(129, 70);
            pos4.TabIndex = 5;
            pos4.Text = "4";
            pos4.TextAlign = ContentAlignment.TopLeft;
            pos4.UseVisualStyleBackColor = false;
            // 
            // backspace
            // 
            backspace.BackColor = Color.DimGray;
            backspace.Dock = DockStyle.Fill;
            backspace.FlatAppearance.BorderSize = 0;
            backspace.FlatStyle = FlatStyle.Flat;
            backspace.Font = new Font("Segoe UI", 10F);
            backspace.ForeColor = Color.White;
            backspace.Location = new Point(407, 0);
            backspace.Margin = new Padding(0);
            backspace.Name = "backspace";
            backspace.Size = new Size(112, 58);
            backspace.TabIndex = 0;
            backspace.Text = "BKSP";
            backspace.TextAlign = ContentAlignment.TopLeft;
            backspace.UseVisualStyleBackColor = false;
            // 
            // pos9
            // 
            pos9.BackColor = Color.LightGray;
            pos9.Dock = DockStyle.Fill;
            pos9.FlatAppearance.BorderColor = Color.Gray;
            pos9.FlatStyle = FlatStyle.Flat;
            pos9.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            pos9.Location = new Point(258, 0);
            pos9.Margin = new Padding(0);
            pos9.Name = "pos9";
            pos9.Size = new Size(149, 58);
            pos9.TabIndex = 1;
            pos9.Text = "9";
            pos9.TextAlign = ContentAlignment.TopLeft;
            pos9.UseVisualStyleBackColor = false;
            // 
            // pos8
            // 
            pos8.BackColor = Color.LightGray;
            pos8.Dock = DockStyle.Fill;
            pos8.FlatAppearance.BorderColor = Color.Gray;
            pos8.FlatStyle = FlatStyle.Flat;
            pos8.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            pos8.Location = new Point(129, 0);
            pos8.Margin = new Padding(0);
            pos8.Name = "pos8";
            pos8.Size = new Size(129, 58);
            pos8.TabIndex = 2;
            pos8.Text = "8";
            pos8.TextAlign = ContentAlignment.TopLeft;
            pos8.UseVisualStyleBackColor = false;
            // 
            // pos7
            // 
            pos7.BackColor = Color.LightGray;
            pos7.Dock = DockStyle.Fill;
            pos7.FlatAppearance.BorderColor = Color.Gray;
            pos7.FlatStyle = FlatStyle.Flat;
            pos7.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            pos7.Location = new Point(0, 0);
            pos7.Margin = new Padding(0);
            pos7.Name = "pos7";
            pos7.Size = new Size(129, 58);
            pos7.TabIndex = 3;
            pos7.Text = "7";
            pos7.TextAlign = ContentAlignment.TopLeft;
            pos7.UseVisualStyleBackColor = false;
            // 
            // pos6
            // 
            pos6.BackColor = Color.LightGray;
            pos6.Dock = DockStyle.Fill;
            pos6.FlatAppearance.BorderColor = Color.Gray;
            pos6.FlatStyle = FlatStyle.Flat;
            pos6.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            pos6.Location = new Point(258, 58);
            pos6.Margin = new Padding(0);
            pos6.Name = "pos6";
            pos6.Size = new Size(149, 70);
            pos6.TabIndex = 4;
            pos6.Text = "6";
            pos6.TextAlign = ContentAlignment.TopLeft;
            pos6.UseVisualStyleBackColor = false;
            // 
            // pos1
            // 
            pos1.BackColor = Color.LightGray;
            pos1.Dock = DockStyle.Fill;
            pos1.FlatAppearance.BorderColor = Color.Gray;
            pos1.FlatStyle = FlatStyle.Flat;
            pos1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            pos1.Location = new Point(0, 128);
            pos1.Margin = new Padding(0);
            pos1.Name = "pos1";
            pos1.Size = new Size(129, 64);
            pos1.TabIndex = 7;
            pos1.Text = "1";
            pos1.TextAlign = ContentAlignment.TopLeft;
            pos1.UseVisualStyleBackColor = false;
            // 
            // pos0
            // 
            pos0.BackColor = Color.LightGray;
            pos0.Dock = DockStyle.Fill;
            pos0.FlatAppearance.BorderColor = Color.Gray;
            pos0.FlatStyle = FlatStyle.Flat;
            pos0.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            pos0.Location = new Point(0, 192);
            pos0.Margin = new Padding(0);
            pos0.Name = "pos0";
            pos0.Size = new Size(129, 66);
            pos0.TabIndex = 8;
            pos0.Text = "0";
            pos0.TextAlign = ContentAlignment.TopLeft;
            pos0.UseVisualStyleBackColor = false;
            // 
            // pos00
            // 
            pos00.BackColor = Color.LightGray;
            pos00.Dock = DockStyle.Fill;
            pos00.FlatAppearance.BorderColor = Color.Gray;
            pos00.FlatStyle = FlatStyle.Flat;
            pos00.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            pos00.Location = new Point(129, 192);
            pos00.Margin = new Padding(0);
            pos00.Name = "pos00";
            pos00.Size = new Size(129, 66);
            pos00.TabIndex = 11;
            pos00.Text = "00";
            pos00.TextAlign = ContentAlignment.TopLeft;
            pos00.UseVisualStyleBackColor = false;
            // 
            // orderItemDisplayContainer
            // 
            orderItemDisplayContainer.Location = new Point(-1, 93);
            orderItemDisplayContainer.Name = "orderItemDisplayContainer";
            orderItemDisplayContainer.Size = new Size(1213, 243);
            orderItemDisplayContainer.TabIndex = 11;
            // 
            // taxString
            // 
            taxString.Anchor = AnchorStyles.Left;
            taxString.AutoSize = true;
            taxString.Font = new Font("Segoe UI", 20F);
            taxString.ForeColor = Color.White;
            taxString.Location = new Point(3, 53);
            taxString.Name = "taxString";
            taxString.Padding = new Padding(10, 5, 10, 5);
            taxString.Size = new Size(74, 47);
            taxString.TabIndex = 1;
            taxString.Text = "Tax";
            // 
            // totalString
            // 
            totalString.Anchor = AnchorStyles.Left;
            totalString.AutoSize = true;
            totalString.Font = new Font("Segoe UI", 20F);
            totalString.ForeColor = Color.White;
            totalString.Location = new Point(3, 104);
            totalString.Name = "totalString";
            totalString.Padding = new Padding(10, 5, 10, 5);
            totalString.Size = new Size(149, 47);
            totalString.TabIndex = 2;
            totalString.Text = "Total Due";
            // 
            // tenderedString
            // 
            tenderedString.Anchor = AnchorStyles.Left;
            tenderedString.AutoSize = true;
            tenderedString.Font = new Font("Segoe UI", 20F);
            tenderedString.ForeColor = Color.White;
            tenderedString.Location = new Point(3, 155);
            tenderedString.Name = "tenderedString";
            tenderedString.Padding = new Padding(10, 5, 10, 5);
            tenderedString.Size = new Size(146, 47);
            tenderedString.TabIndex = 3;
            tenderedString.Text = "Tendered";
            // 
            // MainPOSForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1496, 614);
            Controls.Add(orderItemDisplayContainer);
            Controls.Add(bottomContainer);
            Controls.Add(valuCardHolderInfo);
            Controls.Add(valuCardPresentStrip);
            Controls.Add(buttonContainer);
            Controls.Add(bottomPanel);
            Font = new Font("Segoe UI", 9F);
            Name = "MainPOSForm";
            Text = "MainPOSForm";
            Load += MainPOSForm_Load;
            bottomPanel.ResumeLayout(false);
            bottomPanel.PerformLayout();
            valuCardPresentStrip.ResumeLayout(false);
            valuCardHolderInfo.ResumeLayout(false);
            valuCardHolderInfo.PerformLayout();
            buttonContainer.ResumeLayout(false);
            rightButtonLayout.ResumeLayout(false);
            bottomRowLayout.ResumeLayout(false);
            bottomContainer.ResumeLayout(false);
            orderTotalsContainer.ResumeLayout(false);
            orderTotalsContainer.PerformLayout();
            numberContainer.ResumeLayout(false);
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
        private Panel bottomContainer;
        private TableLayoutPanel rightButtonLayout;
        private TableLayoutPanel bottomRowLayout;
        private System.Windows.Forms.Button total;
        private System.Windows.Forms.TextBox customerNameDisplay;
        private TableLayoutPanel numberContainer;
        private System.Windows.Forms.Button backspace;
        private Panel orderItemDisplayContainer;
        private Label textDisplay;
        private Label customerDisplayPreface;
        private System.Windows.Forms.Button posAtSign;
        private System.Windows.Forms.Button posOK;
        private System.Windows.Forms.Button posClear;
        private System.Windows.Forms.Button pos3;
        private System.Windows.Forms.Button pos2;
        private System.Windows.Forms.Button pos5;
        private System.Windows.Forms.Button pos4;
        private System.Windows.Forms.Button pos9;
        private System.Windows.Forms.Button pos8;
        private System.Windows.Forms.Button pos7;
        private System.Windows.Forms.Button pos6;
        private System.Windows.Forms.Button pos1;
        private System.Windows.Forms.Button pos0;
        private System.Windows.Forms.Button pos00;
        private TableLayoutPanel orderTotalsContainer;
        private Label subtotalString;
        private Label tenderedString;
        private Label totalString;
        private Label taxString;
    }
}