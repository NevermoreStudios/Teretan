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
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelLegsLenght = new System.Windows.Forms.Label();
            this.labelArmsLenght = new System.Windows.Forms.Label();
            this.labelWaistWidth = new System.Windows.Forms.Label();
            this.labelShoulderWidth = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelBithdate = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnRemoveOrder = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.labelSubscriptionLenght = new System.Windows.Forms.Label();
            this.labelSubscriptionLeft = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelSubscriptionDate = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnExtend = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnRemoveUser = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnPreferences = new System.Windows.Forms.Button();
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
            this.Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Users.Location = new System.Drawing.Point(13, 13);
            this.Users.MultiSelect = false;
            this.Users.Name = "Users";
            this.Users.ReadOnly = true;
            this.Users.RowHeadersVisible = false;
            this.Users.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Users.Size = new System.Drawing.Size(600, 523);
            this.Users.TabIndex = 0;
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
            this.Filter.Location = new System.Drawing.Point(12, 571);
            this.Filter.MultiSelect = false;
            this.Filter.Name = "Filter";
            this.Filter.RowHeadersVisible = false;
            this.Filter.Size = new System.Drawing.Size(601, 94);
            this.Filter.TabIndex = 1;
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFilter.Location = new System.Drawing.Point(13, 542);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearFilter.Location = new System.Drawing.Point(94, 542);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(75, 23);
            this.btnClearFilter.TabIndex = 3;
            this.btnClearFilter.Text = "Clear Filter";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.btnExtend);
            this.groupBox.Controls.Add(this.label13);
            this.groupBox.Controls.Add(this.textBox1);
            this.groupBox.Controls.Add(this.labelEmail);
            this.groupBox.Controls.Add(this.label12);
            this.groupBox.Controls.Add(this.labelSubscriptionDate);
            this.groupBox.Controls.Add(this.btnRemoveOrder);
            this.groupBox.Controls.Add(this.label15);
            this.groupBox.Controls.Add(this.btnAddOrder);
            this.groupBox.Controls.Add(this.label14);
            this.groupBox.Controls.Add(this.listBox1);
            this.groupBox.Controls.Add(this.labelSubscriptionLeft);
            this.groupBox.Controls.Add(this.label10);
            this.groupBox.Controls.Add(this.labelSubscriptionLenght);
            this.groupBox.Controls.Add(this.labelLegsLenght);
            this.groupBox.Controls.Add(this.label11);
            this.groupBox.Controls.Add(this.labelArmsLenght);
            this.groupBox.Controls.Add(this.labelWaistWidth);
            this.groupBox.Controls.Add(this.labelShoulderWidth);
            this.groupBox.Controls.Add(this.labelHeight);
            this.groupBox.Controls.Add(this.labelAge);
            this.groupBox.Controls.Add(this.labelBithdate);
            this.groupBox.Controls.Add(this.labelSurname);
            this.groupBox.Controls.Add(this.labelName);
            this.groupBox.Controls.Add(this.label9);
            this.groupBox.Controls.Add(this.label8);
            this.groupBox.Controls.Add(this.label7);
            this.groupBox.Controls.Add(this.label6);
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Location = new System.Drawing.Point(619, 13);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(478, 573);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(240, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Arms Lenght";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Waist Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Shoulder Width";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Height";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birthdate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(240, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Legs Lenght";
            // 
            // labelLegsLenght
            // 
            this.labelLegsLenght.AutoSize = true;
            this.labelLegsLenght.Location = new System.Drawing.Point(339, 152);
            this.labelLegsLenght.Name = "labelLegsLenght";
            this.labelLegsLenght.Size = new System.Drawing.Size(66, 13);
            this.labelLegsLenght.TabIndex = 17;
            this.labelLegsLenght.Text = "Legs Lenght";
            // 
            // labelArmsLenght
            // 
            this.labelArmsLenght.AutoSize = true;
            this.labelArmsLenght.Location = new System.Drawing.Point(339, 116);
            this.labelArmsLenght.Name = "labelArmsLenght";
            this.labelArmsLenght.Size = new System.Drawing.Size(66, 13);
            this.labelArmsLenght.TabIndex = 16;
            this.labelArmsLenght.Text = "Arms Lenght";
            // 
            // labelWaistWidth
            // 
            this.labelWaistWidth.AutoSize = true;
            this.labelWaistWidth.Location = new System.Drawing.Point(339, 48);
            this.labelWaistWidth.Name = "labelWaistWidth";
            this.labelWaistWidth.Size = new System.Drawing.Size(65, 13);
            this.labelWaistWidth.TabIndex = 15;
            this.labelWaistWidth.Text = "Waist Width";
            // 
            // labelShoulderWidth
            // 
            this.labelShoulderWidth.AutoSize = true;
            this.labelShoulderWidth.Location = new System.Drawing.Point(339, 83);
            this.labelShoulderWidth.Name = "labelShoulderWidth";
            this.labelShoulderWidth.Size = new System.Drawing.Size(80, 13);
            this.labelShoulderWidth.TabIndex = 14;
            this.labelShoulderWidth.Text = "Shoulder Width";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Location = new System.Drawing.Point(339, 16);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(38, 13);
            this.labelHeight.TabIndex = 13;
            this.labelHeight.Text = "Height";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(105, 114);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(29, 13);
            this.labelAge.TabIndex = 12;
            this.labelAge.Text = "Age:";
            // 
            // labelBithdate
            // 
            this.labelBithdate.AutoSize = true;
            this.labelBithdate.Location = new System.Drawing.Point(105, 79);
            this.labelBithdate.Name = "labelBithdate";
            this.labelBithdate.Size = new System.Drawing.Size(52, 13);
            this.labelBithdate.TabIndex = 11;
            this.labelBithdate.Text = "Birthdate:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(105, 46);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(52, 13);
            this.labelSurname.TabIndex = 10;
            this.labelSurname.Text = "Surname:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(105, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Orders";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 168);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(220, 95);
            this.listBox1.TabIndex = 19;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(6, 269);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(75, 23);
            this.btnAddOrder.TabIndex = 20;
            this.btnAddOrder.Text = "Add";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            // 
            // btnRemoveOrder
            // 
            this.btnRemoveOrder.Location = new System.Drawing.Point(96, 269);
            this.btnRemoveOrder.Name = "btnRemoveOrder";
            this.btnRemoveOrder.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveOrder.TabIndex = 21;
            this.btnRemoveOrder.Text = "Remove";
            this.btnRemoveOrder.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 319);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Subscipion Date";
            // 
            // labelSubscriptionLenght
            // 
            this.labelSubscriptionLenght.AutoSize = true;
            this.labelSubscriptionLenght.Location = new System.Drawing.Point(267, 319);
            this.labelSubscriptionLenght.Name = "labelSubscriptionLenght";
            this.labelSubscriptionLenght.Size = new System.Drawing.Size(48, 13);
            this.labelSubscriptionLenght.TabIndex = 6;
            this.labelSubscriptionLenght.Text = "OBJECT";
            // 
            // labelSubscriptionLeft
            // 
            this.labelSubscriptionLeft.AutoSize = true;
            this.labelSubscriptionLeft.Location = new System.Drawing.Point(417, 319);
            this.labelSubscriptionLeft.Name = "labelSubscriptionLeft";
            this.labelSubscriptionLeft.Size = new System.Drawing.Size(48, 13);
            this.labelSubscriptionLeft.TabIndex = 7;
            this.labelSubscriptionLeft.Text = "OBJECT";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(331, 319);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Subsription Left";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(162, 319);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "SubscriptionLenght ";
            // 
            // labelSubscriptionDate
            // 
            this.labelSubscriptionDate.AutoSize = true;
            this.labelSubscriptionDate.Location = new System.Drawing.Point(97, 319);
            this.labelSubscriptionDate.Name = "labelSubscriptionDate";
            this.labelSubscriptionDate.Size = new System.Drawing.Size(48, 13);
            this.labelSubscriptionDate.TabIndex = 10;
            this.labelSubscriptionDate.Text = "OBJECT";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 401);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Email";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(60, 401);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(79, 13);
            this.labelEmail.TabIndex = 23;
            this.labelEmail.Text = "how convinient";
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(6, 462);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(459, 96);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // btnExtend
            // 
            this.btnExtend.Location = new System.Drawing.Point(6, 344);
            this.btnExtend.Name = "btnExtend";
            this.btnExtend.Size = new System.Drawing.Size(459, 36);
            this.btnExtend.TabIndex = 26;
            this.btnExtend.Text = "Extend Subscription";
            this.btnExtend.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(619, 592);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnEditUser
            // 
            this.btnEditUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditUser.Location = new System.Drawing.Point(701, 592);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(75, 23);
            this.btnEditUser.TabIndex = 6;
            this.btnEditUser.Text = "Edit";
            this.btnEditUser.UseVisualStyleBackColor = true;
            // 
            // btnRemoveUser
            // 
            this.btnRemoveUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveUser.Location = new System.Drawing.Point(782, 592);
            this.btnRemoveUser.Name = "btnRemoveUser";
            this.btnRemoveUser.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveUser.TabIndex = 7;
            this.btnRemoveUser.Text = "Remove";
            this.btnRemoveUser.UseVisualStyleBackColor = true;
            // 
            // btnProducts
            // 
            this.btnProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProducts.Location = new System.Drawing.Point(904, 647);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(75, 23);
            this.btnProducts.TabIndex = 8;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = true;
            // 
            // btnPreferences
            // 
            this.btnPreferences.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreferences.Location = new System.Drawing.Point(985, 647);
            this.btnPreferences.Name = "btnPreferences";
            this.btnPreferences.Size = new System.Drawing.Size(75, 23);
            this.btnPreferences.TabIndex = 9;
            this.btnPreferences.Text = "Preferences";
            this.btnPreferences.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 682);
            this.Controls.Add(this.btnPreferences);
            this.Controls.Add(this.btnProducts);
            this.Controls.Add(this.btnRemoveUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelSubscriptionDate;
        private System.Windows.Forms.Button btnRemoveOrder;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelSubscriptionLeft;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelSubscriptionLenght;
        private System.Windows.Forms.Label labelLegsLenght;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelArmsLenght;
        private System.Windows.Forms.Label labelWaistWidth;
        private System.Windows.Forms.Label labelShoulderWidth;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelBithdate;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnExtend;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnRemoveUser;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnPreferences;
    }
}