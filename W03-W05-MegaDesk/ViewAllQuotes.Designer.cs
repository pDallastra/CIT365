﻿namespace MegaDesk
{
    partial class ViewAllQuotes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BackToMainMenu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewAllQuotes = new System.Windows.Forms.DataGridView();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drawers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RushDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // BackToMainMenu
            // 
            this.BackToMainMenu.BackColor = System.Drawing.Color.White;
            this.BackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BackToMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToMainMenu.Location = new System.Drawing.Point(1629, 45);
            this.BackToMainMenu.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.BackToMainMenu.Name = "BackToMainMenu";
            this.BackToMainMenu.Size = new System.Drawing.Size(357, 126);
            this.BackToMainMenu.TabIndex = 7;
            this.BackToMainMenu.Text = "Main Menu";
            this.BackToMainMenu.UseVisualStyleBackColor = false;
            this.BackToMainMenu.Click += new System.EventHandler(this.BackToMainMenu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Aqua;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(502, 94);
            this.label1.TabIndex = 8;
            this.label1.Text = "View All Quotes";
            // 
            // dataGridViewAllQuotes
            // 
            this.dataGridViewAllQuotes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAllQuotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAllQuotes.ColumnHeadersHeight = 28;
            this.dataGridViewAllQuotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerName,
            this.Price,
            this.dataGridViewTextBoxColumn1,
            this.Width,
            this.Depth,
            this.Drawers,
            this.RushDays,
            this.OrderDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAllQuotes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAllQuotes.Location = new System.Drawing.Point(85, 250);
            this.dataGridViewAllQuotes.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dataGridViewAllQuotes.Name = "dataGridViewAllQuotes";
            this.dataGridViewAllQuotes.RowHeadersWidth = 51;
            this.dataGridViewAllQuotes.Size = new System.Drawing.Size(1901, 894);
            this.dataGridViewAllQuotes.TabIndex = 14;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 125;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 75;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "SurfaceMaterial";
            this.dataGridViewTextBoxColumn1.FillWeight = 115F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Surface Material";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 115;
            // 
            // Width
            // 
            this.Width.DataPropertyName = "Width";
            this.Width.HeaderText = "Width";
            this.Width.MinimumWidth = 6;
            this.Width.Name = "Width";
            this.Width.Width = 50;
            // 
            // Depth
            // 
            this.Depth.DataPropertyName = "Depth";
            this.Depth.HeaderText = "Depth";
            this.Depth.MinimumWidth = 6;
            this.Depth.Name = "Depth";
            this.Depth.Width = 50;
            // 
            // Drawers
            // 
            this.Drawers.DataPropertyName = "Drawers";
            this.Drawers.HeaderText = "Drawers";
            this.Drawers.MinimumWidth = 6;
            this.Drawers.Name = "Drawers";
            this.Drawers.Width = 50;
            // 
            // RushDays
            // 
            this.RushDays.DataPropertyName = "RushDays";
            this.RushDays.HeaderText = "Rush Days";
            this.RushDays.MinimumWidth = 6;
            this.RushDays.Name = "RushDays";
            this.RushDays.Width = 95;
            // 
            // OrderDate
            // 
            this.OrderDate.DataPropertyName = "OrderDate";
            this.OrderDate.HeaderText = "Order Date";
            this.OrderDate.MinimumWidth = 6;
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.Width = 250;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(2064, 1233);
            this.Controls.Add(this.dataGridViewAllQuotes);
            this.Controls.Add(this.BackToMainMenu);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewAllQuotes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Quotes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllQuotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackToMainMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewAllQuotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Width;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drawers;
        private System.Windows.Forms.DataGridViewTextBoxColumn RushDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
    }
}