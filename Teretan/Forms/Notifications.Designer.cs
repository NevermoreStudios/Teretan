﻿namespace Teretan
{
    partial class Notifications
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
            this.notificationList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // notificationList
            // 
            this.notificationList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.notificationList.FormattingEnabled = true;
            this.notificationList.Location = new System.Drawing.Point(13, 13);
            this.notificationList.Name = "notificationList";
            this.notificationList.Size = new System.Drawing.Size(711, 238);
            this.notificationList.TabIndex = 0;
            // 
            // Notifications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 262);
            this.Controls.Add(this.notificationList);
            this.Name = "Notifications";
            this.Text = "Obaveštenja";
            this.Load += new System.EventHandler(this.Notifications_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox notificationList;
    }
}