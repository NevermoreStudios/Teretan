namespace Teretan
{
    partial class EditProduct
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.editButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.descBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(81, 13);
            label1.TabIndex = 0;
            label1.Tag = "i18n-text";
            label1.Text = "form-label-name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(3, 46);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 13);
            label2.TabIndex = 1;
            label2.Tag = "i18n-text";
            label2.Text = "form-label-desc";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(347, 69);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(96, 23);
            this.editButton.TabIndex = 4;
            this.editButton.Tag = "i18n-text";
            this.editButton.Text = "add";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.Edit);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(90, 13);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(353, 20);
            this.nameBox.TabIndex = 2;
            // 
            // descBox
            // 
            this.descBox.Location = new System.Drawing.Point(90, 43);
            this.descBox.Name = "descBox";
            this.descBox.Size = new System.Drawing.Size(353, 20);
            this.descBox.TabIndex = 3;
            // 
            // EditProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 107);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.descBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditProduct";
            this.Tag = "i18n-text";
            this.Text = "form-add-product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox descBox;
        private System.Windows.Forms.Button editButton;
    }
}