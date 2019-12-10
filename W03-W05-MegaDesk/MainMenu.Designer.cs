﻿namespace MegaDesk
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.AddNewQuoteButton = new System.Windows.Forms.Button();
            this.ViewQuotesButton = new System.Windows.Forms.Button();
            this.SearchQuotesButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddNewQuoteButton
            // 
            this.AddNewQuoteButton.BackColor = System.Drawing.Color.White;
            this.AddNewQuoteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddNewQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewQuoteButton.Location = new System.Drawing.Point(117, 234);
            this.AddNewQuoteButton.Margin = new System.Windows.Forms.Padding(5);
            this.AddNewQuoteButton.Name = "AddNewQuoteButton";
            this.AddNewQuoteButton.Size = new System.Drawing.Size(453, 110);
            this.AddNewQuoteButton.TabIndex = 1;
            this.AddNewQuoteButton.Text = "&Add New Quote";
            this.AddNewQuoteButton.UseVisualStyleBackColor = false;
            this.AddNewQuoteButton.Click += new System.EventHandler(this.AddNewQuoteButton_Click);
            // 
            // ViewQuotesButton
            // 
            this.ViewQuotesButton.BackColor = System.Drawing.Color.White;
            this.ViewQuotesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ViewQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewQuotesButton.Location = new System.Drawing.Point(117, 377);
            this.ViewQuotesButton.Margin = new System.Windows.Forms.Padding(5);
            this.ViewQuotesButton.Name = "ViewQuotesButton";
            this.ViewQuotesButton.Size = new System.Drawing.Size(453, 110);
            this.ViewQuotesButton.TabIndex = 2;
            this.ViewQuotesButton.Text = "&View Quotes";
            this.ViewQuotesButton.UseVisualStyleBackColor = false;
            this.ViewQuotesButton.Click += new System.EventHandler(this.ViewQuotesButton_Click);
            // 
            // SearchQuotesButton
            // 
            this.SearchQuotesButton.BackColor = System.Drawing.Color.White;
            this.SearchQuotesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SearchQuotesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchQuotesButton.Location = new System.Drawing.Point(117, 517);
            this.SearchQuotesButton.Margin = new System.Windows.Forms.Padding(5);
            this.SearchQuotesButton.Name = "SearchQuotesButton";
            this.SearchQuotesButton.Size = new System.Drawing.Size(453, 110);
            this.SearchQuotesButton.TabIndex = 3;
            this.SearchQuotesButton.Text = "&Search Quotes";
            this.SearchQuotesButton.UseVisualStyleBackColor = false;
            this.SearchQuotesButton.Click += new System.EventHandler(this.SearchQuotesButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.White;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.Location = new System.Drawing.Point(117, 675);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(5);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(453, 112);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(881, 94);
            this.label1.TabIndex = 5;
            this.label1.Text = "MegaDesk 2.0 Mario e Paulo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(703, 234);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(774, 553);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1600, 873);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SearchQuotesButton);
            this.Controls.Add(this.ViewQuotesButton);
            this.Controls.Add(this.AddNewQuoteButton);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mega Desk Mario e Paulo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddNewQuoteButton;
        private System.Windows.Forms.Button ViewQuotesButton;
        private System.Windows.Forms.Button SearchQuotesButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

