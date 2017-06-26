namespace Teretan
{
    partial class ExtendSub
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
            System.Windows.Forms.Button button1;
            this.extend = new System.Windows.Forms.NumericUpDown();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.extend)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(94, 13);
            label1.TabIndex = 0;
            label1.Tag = "i18n-text";
            label1.Text = "form-extend-length";
            label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(235, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(29, 13);
            label2.TabIndex = 2;
            label2.Tag = "i18n-text";
            label2.Text = "days";
            label2.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(189, 38);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 3;
            button1.Tag = "i18n-text";
            button1.Text = "extend";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // extend
            // 
            this.extend.Location = new System.Drawing.Point(109, 6);
            this.extend.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.extend.Name = "extend";
            this.extend.Size = new System.Drawing.Size(120, 20);
            this.extend.TabIndex = 1;
            // 
            // ExtendSub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 73);
            this.Controls.Add(button1);
            this.Controls.Add(label2);
            this.Controls.Add(this.extend);
            this.Controls.Add(label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExtendSub";
            this.Text = "form-extend-sub";
            ((System.ComponentModel.ISupportInitialize)(this.extend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown extend;
    }
}