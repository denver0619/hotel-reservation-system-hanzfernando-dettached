﻿namespace HotelReservationSystem.Rooms
{
    partial class RoomsPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.artanPanel1 = new HotelReservationSystem.Assets.ArtanPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.artanPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(30, 50, 30, 50);
            this.panel1.Size = new System.Drawing.Size(900, 900);
            this.panel1.TabIndex = 0;
            // 
            // artanPanel1
            // 
            this.artanPanel1.BackColor = System.Drawing.Color.White;
            this.artanPanel1.BorderRadius = 30;
            this.artanPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.artanPanel1.ForeColor = System.Drawing.Color.Black;
            this.artanPanel1.GradientAngle = 90F;
            this.artanPanel1.GradientBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(154)))), ((int)(((byte)(237)))));
            this.artanPanel1.GradientTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(154)))), ((int)(((byte)(237)))));
            this.artanPanel1.Location = new System.Drawing.Point(30, 50);
            this.artanPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.artanPanel1.Name = "artanPanel1";
            this.artanPanel1.Size = new System.Drawing.Size(840, 800);
            this.artanPanel1.TabIndex = 0;
            // 
            // RoomsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(3)))), ((int)(((byte)(24)))));
            this.Controls.Add(this.panel1);
            this.Name = "RoomsPanel";
            this.Size = new System.Drawing.Size(900, 900);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Assets.ArtanPanel artanPanel1;
    }
}
