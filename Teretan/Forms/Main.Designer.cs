namespace Teretan
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Users = new System.Windows.Forms.DataGridView();
            this.Filter = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.cbActive = new System.Windows.Forms.CheckBox();
            this.tbNeck = new System.Windows.Forms.TextBox();
            this.tbWeight = new System.Windows.Forms.TextBox();
            this.tbCalvR = new System.Windows.Forms.TextBox();
            this.tbTighR = new System.Windows.Forms.TextBox();
            this.tbBicepsR = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.tbHips = new System.Windows.Forms.TextBox();
            this.tbWaist = new System.Windows.Forms.TextBox();
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbChest = new System.Windows.Forms.TextBox();
            this.tbFat = new System.Windows.Forms.TextBox();
            this.tbCalvL = new System.Windows.Forms.TextBox();
            this.tbTighL = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tbBicepsL = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelSubscriptionLenght = new System.Windows.Forms.Label();
            this.btnExtend = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.labelSubscriptionDate = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.labelSubscriptionLeft = new System.Windows.Forms.Label();
            this.btnRemoveOrder = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.lbOrders = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnPreferences = new System.Windows.Forms.Button();
            this.btnNotif = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Filter)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Users
            // 
            this.Users.AllowUserToAddRows = false;
            this.Users.AllowUserToDeleteRows = false;
            this.Users.AllowUserToResizeColumns = false;
            this.Users.AllowUserToResizeRows = false;
            this.Users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Users.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Users.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Users.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Users.Location = new System.Drawing.Point(12, 12);
            this.Users.MultiSelect = false;
            this.Users.Name = "Users";
            this.Users.ReadOnly = true;
            this.Users.RowHeadersVisible = false;
            this.Users.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Users.Size = new System.Drawing.Size(600, 522);
            this.Users.TabIndex = 0;
            this.Users.Tag = "bt";
            this.Users.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Users_CellClick);
            this.Users.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.Users_SortCompare);
            // 
            // Filter
            // 
            this.Filter.AllowUserToResizeColumns = false;
            this.Filter.AllowUserToResizeRows = false;
            this.Filter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Filter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Filter.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Filter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Filter.Location = new System.Drawing.Point(12, 570);
            this.Filter.MultiSelect = false;
            this.Filter.Name = "Filter";
            this.Filter.RowHeadersVisible = false;
            this.Filter.Size = new System.Drawing.Size(601, 94);
            this.Filter.TabIndex = 1;
            this.Filter.Tag = "bt";
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFilter.Location = new System.Drawing.Point(13, 541);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Tag = "bt";
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearFilter.Location = new System.Drawing.Point(94, 541);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(75, 23);
            this.btnClearFilter.TabIndex = 3;
            this.btnClearFilter.Tag = "bt";
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.label28);
            this.groupBox.Controls.Add(this.label27);
            this.groupBox.Controls.Add(this.label26);
            this.groupBox.Controls.Add(this.cbActive);
            this.groupBox.Controls.Add(this.tbNeck);
            this.groupBox.Controls.Add(this.tbWeight);
            this.groupBox.Controls.Add(this.tbCalvR);
            this.groupBox.Controls.Add(this.tbTighR);
            this.groupBox.Controls.Add(this.tbBicepsR);
            this.groupBox.Controls.Add(this.tbEmail);
            this.groupBox.Controls.Add(this.tbHeight);
            this.groupBox.Controls.Add(this.tbHips);
            this.groupBox.Controls.Add(this.tbWaist);
            this.groupBox.Controls.Add(this.tbTel);
            this.groupBox.Controls.Add(this.tbChest);
            this.groupBox.Controls.Add(this.tbFat);
            this.groupBox.Controls.Add(this.tbCalvL);
            this.groupBox.Controls.Add(this.tbTighL);
            this.groupBox.Controls.Add(this.label25);
            this.groupBox.Controls.Add(this.tbBicepsL);
            this.groupBox.Controls.Add(this.label23);
            this.groupBox.Controls.Add(this.label18);
            this.groupBox.Controls.Add(this.label19);
            this.groupBox.Controls.Add(this.label20);
            this.groupBox.Controls.Add(this.label22);
            this.groupBox.Controls.Add(this.label12);
            this.groupBox.Controls.Add(this.label24);
            this.groupBox.Controls.Add(this.label16);
            this.groupBox.Controls.Add(this.label21);
            this.groupBox.Controls.Add(this.label17);
            this.groupBox.Controls.Add(this.label9);
            this.groupBox.Controls.Add(this.label8);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.tbAge);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.dtpDate);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.tbSurname);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.tbName);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.tbID);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.label15);
            this.groupBox.Controls.Add(this.labelSubscriptionLenght);
            this.groupBox.Controls.Add(this.btnExtend);
            this.groupBox.Controls.Add(this.label11);
            this.groupBox.Controls.Add(this.labelSubscriptionDate);
            this.groupBox.Controls.Add(this.label13);
            this.groupBox.Controls.Add(this.tbNotes);
            this.groupBox.Controls.Add(this.label14);
            this.groupBox.Controls.Add(this.labelSubscriptionLeft);
            this.groupBox.Controls.Add(this.btnRemoveOrder);
            this.groupBox.Controls.Add(this.btnAddOrder);
            this.groupBox.Controls.Add(this.lbOrders);
            this.groupBox.Controls.Add(this.label10);
            this.groupBox.Location = new System.Drawing.Point(619, 13);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(478, 573);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(175, 84);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(80, 13);
            this.label28.TabIndex = 60;
            this.label28.Text = "Circumferences";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(370, 112);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(32, 13);
            this.label27.TabIndex = 59;
            this.label27.Text = "Right";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(46, 112);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(25, 13);
            this.label26.TabIndex = 58;
            this.label26.Text = "Left";
            // 
            // cbActive
            // 
            this.cbActive.AutoSize = true;
            this.cbActive.Location = new System.Drawing.Point(401, 261);
            this.cbActive.Name = "cbActive";
            this.cbActive.Size = new System.Drawing.Size(56, 17);
            this.cbActive.TabIndex = 20;
            this.cbActive.Tag = "Tog";
            this.cbActive.Text = "Active";
            this.cbActive.UseVisualStyleBackColor = true;
            // 
            // tbNeck
            // 
            this.tbNeck.Location = new System.Drawing.Point(272, 109);
            this.tbNeck.Name = "tbNeck";
            this.tbNeck.Size = new System.Drawing.Size(43, 20);
            this.tbNeck.TabIndex = 5;
            this.tbNeck.Tag = "Tog";
            // 
            // tbWeight
            // 
            this.tbWeight.Location = new System.Drawing.Point(431, 229);
            this.tbWeight.Name = "tbWeight";
            this.tbWeight.Size = new System.Drawing.Size(43, 20);
            this.tbWeight.TabIndex = 17;
            this.tbWeight.Tag = "Tog";
            // 
            // tbCalvR
            // 
            this.tbCalvR.Location = new System.Drawing.Point(431, 199);
            this.tbCalvR.Name = "tbCalvR";
            this.tbCalvR.Size = new System.Drawing.Size(43, 20);
            this.tbCalvR.TabIndex = 14;
            this.tbCalvR.Tag = "Tog";
            // 
            // tbTighR
            // 
            this.tbTighR.Location = new System.Drawing.Point(431, 169);
            this.tbTighR.Name = "tbTighR";
            this.tbTighR.Size = new System.Drawing.Size(43, 20);
            this.tbTighR.TabIndex = 11;
            this.tbTighR.Tag = "Tog";
            // 
            // tbBicepsR
            // 
            this.tbBicepsR.Location = new System.Drawing.Point(431, 137);
            this.tbBicepsR.Name = "tbBicepsR";
            this.tbBicepsR.Size = new System.Drawing.Size(43, 20);
            this.tbBicepsR.TabIndex = 8;
            this.tbBicepsR.Tag = "Tog";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(240, 259);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(150, 20);
            this.tbEmail.TabIndex = 19;
            this.tbEmail.Tag = "Tog";
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(272, 229);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(43, 20);
            this.tbHeight.TabIndex = 16;
            this.tbHeight.Tag = "Tog";
            // 
            // tbHips
            // 
            this.tbHips.Location = new System.Drawing.Point(272, 199);
            this.tbHips.Name = "tbHips";
            this.tbHips.Size = new System.Drawing.Size(43, 20);
            this.tbHips.TabIndex = 13;
            this.tbHips.Tag = "Tog";
            // 
            // tbWaist
            // 
            this.tbWaist.Location = new System.Drawing.Point(272, 169);
            this.tbWaist.Name = "tbWaist";
            this.tbWaist.Size = new System.Drawing.Size(43, 20);
            this.tbWaist.TabIndex = 10;
            this.tbWaist.Tag = "Tog";
            // 
            // tbTel
            // 
            this.tbTel.Location = new System.Drawing.Point(33, 259);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(150, 20);
            this.tbTel.TabIndex = 18;
            this.tbTel.Tag = "Tog";
            // 
            // tbChest
            // 
            this.tbChest.Location = new System.Drawing.Point(272, 139);
            this.tbChest.Name = "tbChest";
            this.tbChest.Size = new System.Drawing.Size(43, 20);
            this.tbChest.TabIndex = 7;
            this.tbChest.Tag = "Tog";
            // 
            // tbFat
            // 
            this.tbFat.Location = new System.Drawing.Point(112, 229);
            this.tbFat.Name = "tbFat";
            this.tbFat.Size = new System.Drawing.Size(43, 20);
            this.tbFat.TabIndex = 15;
            this.tbFat.Tag = "Tog";
            // 
            // tbCalvL
            // 
            this.tbCalvL.Location = new System.Drawing.Point(112, 199);
            this.tbCalvL.Name = "tbCalvL";
            this.tbCalvL.Size = new System.Drawing.Size(43, 20);
            this.tbCalvL.TabIndex = 12;
            this.tbCalvL.Tag = "Tog";
            // 
            // tbTighL
            // 
            this.tbTighL.Location = new System.Drawing.Point(112, 169);
            this.tbTighL.Name = "tbTighL";
            this.tbTighL.Size = new System.Drawing.Size(43, 20);
            this.tbTighL.TabIndex = 9;
            this.tbTighL.Tag = "Tog";
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(5, 262);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(22, 13);
            this.label25.TabIndex = 46;
            this.label25.Text = "Tel";
            this.label25.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbBicepsL
            // 
            this.tbBicepsL.Location = new System.Drawing.Point(112, 137);
            this.tbBicepsL.Name = "tbBicepsL";
            this.tbBicepsL.Size = new System.Drawing.Size(43, 20);
            this.tbBicepsL.TabIndex = 6;
            this.tbBicepsL.Tag = "Tog";
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(46, 232);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 13);
            this.label23.TabIndex = 46;
            this.label23.Text = "Body Fat %";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(2, 202);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(104, 13);
            this.label18.TabIndex = 46;
            this.label18.Text = "Calv";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(2, 172);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 13);
            this.label19.TabIndex = 45;
            this.label19.Text = "Tigh";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(2, 140);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(104, 13);
            this.label20.TabIndex = 44;
            this.label20.Text = "Biceps";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(384, 232);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 13);
            this.label22.TabIndex = 43;
            this.label22.Text = "Weight";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(321, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Calv";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(196, 262);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 13);
            this.label24.TabIndex = 40;
            this.label24.Text = "E-mail";
            this.label24.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(321, 172);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 13);
            this.label16.TabIndex = 42;
            this.label16.Text = "Tigh";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(228, 232);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 13);
            this.label21.TabIndex = 40;
            this.label21.Text = "Height";
            this.label21.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(321, 140);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 13);
            this.label17.TabIndex = 41;
            this.label17.Text = "Biceps";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(162, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 13);
            this.label9.TabIndex = 40;
            this.label9.Text = "Hip";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(162, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Waist";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(162, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Chest";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(162, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Neck";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbAge
            // 
            this.tbAge.Enabled = false;
            this.tbAge.Location = new System.Drawing.Point(319, 47);
            this.tbAge.Name = "tbAge";
            this.tbAge.Size = new System.Drawing.Size(50, 20);
            this.tbAge.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(287, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Age";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(72, 44);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 3;
            this.dtpDate.Tag = "Tog";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Birth Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(307, 16);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(100, 20);
            this.tbSurname.TabIndex = 2;
            this.tbSurname.Tag = "Tog";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(252, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Surname";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(131, 16);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 1;
            this.tbName.Tag = "Tog";
            this.tbName.Text = "asdf";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(90, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(36, 16);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(39, 20);
            this.tbID.TabIndex = 0;
            this.tbID.Tag = "Tog";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(232, 307);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "SubscriptionLenght ";
            // 
            // labelSubscriptionLenght
            // 
            this.labelSubscriptionLenght.AutoSize = true;
            this.labelSubscriptionLenght.Location = new System.Drawing.Point(337, 307);
            this.labelSubscriptionLenght.Name = "labelSubscriptionLenght";
            this.labelSubscriptionLenght.Size = new System.Drawing.Size(48, 13);
            this.labelSubscriptionLenght.TabIndex = 6;
            this.labelSubscriptionLenght.Text = "OBJECT";
            // 
            // btnExtend
            // 
            this.btnExtend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtend.Location = new System.Drawing.Point(235, 383);
            this.btnExtend.Name = "btnExtend";
            this.btnExtend.Size = new System.Drawing.Size(237, 48);
            this.btnExtend.TabIndex = 24;
            this.btnExtend.Tag = "bt";
            this.btnExtend.Text = "Extend Subscription";
            this.btnExtend.UseVisualStyleBackColor = true;
            this.btnExtend.Click += new System.EventHandler(this.btnExtend_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(235, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Subscipion Date";
            // 
            // labelSubscriptionDate
            // 
            this.labelSubscriptionDate.AutoSize = true;
            this.labelSubscriptionDate.Location = new System.Drawing.Point(326, 333);
            this.labelSubscriptionDate.Name = "labelSubscriptionDate";
            this.labelSubscriptionDate.Size = new System.Drawing.Size(48, 13);
            this.labelSubscriptionDate.TabIndex = 10;
            this.labelSubscriptionDate.Text = "OBJECT";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 437);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Notes";
            // 
            // tbNotes
            // 
            this.tbNotes.AcceptsReturn = true;
            this.tbNotes.AcceptsTab = true;
            this.tbNotes.BackColor = System.Drawing.SystemColors.Window;
            this.tbNotes.Location = new System.Drawing.Point(6, 462);
            this.tbNotes.Multiline = true;
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbNotes.Size = new System.Drawing.Size(459, 96);
            this.tbNotes.TabIndex = 25;
            this.tbNotes.Tag = "Tog";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(235, 358);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Subsription Left";
            // 
            // labelSubscriptionLeft
            // 
            this.labelSubscriptionLeft.AutoSize = true;
            this.labelSubscriptionLeft.Location = new System.Drawing.Point(321, 358);
            this.labelSubscriptionLeft.Name = "labelSubscriptionLeft";
            this.labelSubscriptionLeft.Size = new System.Drawing.Size(48, 13);
            this.labelSubscriptionLeft.TabIndex = 7;
            this.labelSubscriptionLeft.Text = "OBJECT";
            // 
            // btnRemoveOrder
            // 
            this.btnRemoveOrder.Location = new System.Drawing.Point(99, 408);
            this.btnRemoveOrder.Name = "btnRemoveOrder";
            this.btnRemoveOrder.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveOrder.TabIndex = 23;
            this.btnRemoveOrder.Tag = "bt";
            this.btnRemoveOrder.Text = "Remove";
            this.btnRemoveOrder.UseVisualStyleBackColor = true;
            this.btnRemoveOrder.Click += new System.EventHandler(this.btnRemoveOrder_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(9, 408);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrder.TabIndex = 22;
            this.btnAddOrder.Tag = "bt";
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // lbOrders
            // 
            this.lbOrders.FormattingEnabled = true;
            this.lbOrders.Location = new System.Drawing.Point(9, 307);
            this.lbOrders.Name = "lbOrders";
            this.lbOrders.Size = new System.Drawing.Size(220, 95);
            this.lbOrders.TabIndex = 21;
            this.lbOrders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbOrders_MouseDoubleClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Orders";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddUser.Location = new System.Drawing.Point(619, 592);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.Tag = "bt";
            this.btnAddUser.Text = "Add";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.bntAddUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditUser.Location = new System.Drawing.Point(701, 592);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(75, 23);
            this.btnEditUser.TabIndex = 6;
            this.btnEditUser.Tag = "bt";
            this.btnEditUser.Text = "Edit";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveUser.Location = new System.Drawing.Point(782, 592);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveUser.TabIndex = 7;
            this.btnRemoveUser.Tag = "bt";
            this.btnRemoveUser.Text = "Remove";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            this.btnRemoveUser.Click += new System.EventHandler(this.btnRemoveUser_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProducts.Location = new System.Drawing.Point(939, 647);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(75, 23);
            this.btnProducts.TabIndex = 10;
            this.btnProducts.Tag = "bt";
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnPreferences
            // 
            this.btnPreferences.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreferences.Location = new System.Drawing.Point(1020, 647);
            this.btnPreferences.Name = "btnPreferences";
            this.btnPreferences.Size = new System.Drawing.Size(75, 23);
            this.btnPreferences.TabIndex = 11;
            this.btnPreferences.Tag = "bt";
            this.btnPreferences.Text = "Preferences";
            this.btnPreferences.UseVisualStyleBackColor = true;
            this.btnPreferences.Click += new System.EventHandler(this.btnPreferences_Click);
            // 
            // btnNotif
            // 
            this.btnNotif.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNotif.Location = new System.Drawing.Point(620, 622);
            this.btnNotif.Name = "btnNotif";
            this.btnNotif.Size = new System.Drawing.Size(237, 48);
            this.btnNotif.TabIndex = 8;
            this.btnNotif.Tag = "bt";
            this.btnNotif.Text = "Notiications";
            this.btnNotif.UseVisualStyleBackColor = true;
            this.btnNotif.Click += new System.EventHandler(this.btnNotif_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(939, 618);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(156, 23);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Tag = "bt";
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 681);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnNotif);
            this.Controls.Add(this.btnPreferences);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.btnClearFilter);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.Users);
            this.MinimumSize = new System.Drawing.Size(1130, 720);
            this.Name = "Main";
            this.Tag = "";
            this.Text = "Teretan";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Filter)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Users;
        private System.Windows.Forms.DataGridView Filter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Label labelSubscriptionDate;
        private System.Windows.Forms.Button btnRemoveOrder;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox lbOrders;
        private System.Windows.Forms.Label labelSubscriptionLeft;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelSubscriptionLenght;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnExtend;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnPreferences;
        private System.Windows.Forms.Button btnNotif;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox tbAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNeck;
        private System.Windows.Forms.TextBox tbCalvR;
        private System.Windows.Forms.TextBox tbTighR;
        private System.Windows.Forms.TextBox tbBicepsR;
        private System.Windows.Forms.TextBox tbHips;
        private System.Windows.Forms.TextBox tbWaist;
        private System.Windows.Forms.TextBox tbChest;
        private System.Windows.Forms.TextBox tbCalvL;
        private System.Windows.Forms.TextBox tbTighL;
        private System.Windows.Forms.TextBox tbBicepsL;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbWeight;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.TextBox tbFat;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.CheckBox cbActive;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
    }
}