﻿namespace it_School
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.update_button = new System.Windows.Forms.Button();
            this.insert_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1405, 24);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 61);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 50;
            this.dataGridView2.Size = new System.Drawing.Size(1078, 557);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1099, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 24);
            this.comboBox1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1099, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 22);
            this.textBox1.TabIndex = 3;
            // 
            // update_button
            // 
            this.update_button.Location = new System.Drawing.Point(1100, 138);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(142, 43);
            this.update_button.TabIndex = 4;
            this.update_button.Text = "UPDATE";
            this.update_button.UseVisualStyleBackColor = true;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // insert_button
            // 
            this.insert_button.Location = new System.Drawing.Point(1100, 216);
            this.insert_button.Name = "insert_button";
            this.insert_button.Size = new System.Drawing.Size(142, 43);
            this.insert_button.TabIndex = 5;
            this.insert_button.Text = "INSERT";
            this.insert_button.UseVisualStyleBackColor = true;
            this.insert_button.Click += new System.EventHandler(this.insert_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(1100, 298);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(142, 43);
            this.delete_button.TabIndex = 6;
            this.delete_button.Text = "REMOVE";
            this.delete_button.UseVisualStyleBackColor = true;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(1275, 61);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(142, 52);
            this.search_button.TabIndex = 7;
            this.search_button.Text = "SEARCH";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 631);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.insert_button);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Button insert_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button search_button;
    }
}