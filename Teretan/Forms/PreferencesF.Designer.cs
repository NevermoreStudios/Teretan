namespace Teretan
{
    partial class PreferencesF
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Button saveButton;
            this.yellowVal = new System.Windows.Forms.NumericUpDown();
            this.redVal = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yellowVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redVal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(27, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(113, 13);
            label1.TabIndex = 0;
            label1.Tag = "i18n-text";
            label1.Text = "form-preference-yellow";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(27, 37);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(99, 13);
            label2.TabIndex = 1;
            label2.Tag = "i18n-text";
            label2.Text = "form-preference-red";
            // 
            // yellowVal
            // 
            this.yellowVal.Location = new System.Drawing.Point(164, 9);
            this.yellowVal.Name = "yellowVal";
            this.yellowVal.Size = new System.Drawing.Size(45, 20);
            this.yellowVal.TabIndex = 2;
            // 
            // redVal
            // 
            this.redVal.Location = new System.Drawing.Point(164, 35);
            this.redVal.Name = "redVal";
            this.redVal.Size = new System.Drawing.Size(45, 20);
            this.redVal.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(215, 11);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(29, 13);
            label3.TabIndex = 4;
            label3.Tag = "i18n-text";
            label3.Text = "days";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(215, 37);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(29, 13);
            label4.TabIndex = 5;
            label4.Tag = "i18n-text";
            label4.Text = "days";
            // 
            // saveButton
            // 
            saveButton.Location = new System.Drawing.Point(197, 65);
            saveButton.Name = "saveButton";
            saveButton.Size = new System.Drawing.Size(75, 23);
            saveButton.TabIndex = 6;
            saveButton.Tag = "i18n-text";
            saveButton.Text = "ok";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += new System.EventHandler(this.Save);
            // 
            // PreferencesF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 100);
            this.Controls.Add(saveButton);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.redVal);
            this.Controls.Add(this.yellowVal);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PreferencesF";
            this.Text = "form-preferences";
            this.Load += new System.EventHandler(this.PreferencesF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yellowVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redVal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown yellowVal;
        private System.Windows.Forms.NumericUpDown redVal;
    }
}