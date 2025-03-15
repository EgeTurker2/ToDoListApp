using System;
using System.Drawing;

namespace ToDoListApp
{
    partial class frmToDoList
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
            this.txtTask = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstTasks = new System.Windows.Forms.ListBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnMarkComplete = new System.Windows.Forms.Button();
            this.lblTotalTasks = new System.Windows.Forms.Label();
            this.chkDarkMode = new System.Windows.Forms.CheckBox();
            this.RedRadioButton = new System.Windows.Forms.RadioButton();
            this.BlueRadioButton = new System.Windows.Forms.RadioButton();
            this.GreenRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveEdit = new System.Windows.Forms.Button();
            this.btnCustomTheme = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // txtTask
            // 
            this.txtTask.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTask.ForeColor = System.Drawing.Color.Black;
            this.txtTask.Location = new System.Drawing.Point(27, 46);
            this.txtTask.Margin = new System.Windows.Forms.Padding(4);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(245, 34);
            this.txtTask.TabIndex = 1;
            this.txtTask.TextChanged += new System.EventHandler(this.txtTask_TextChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTitle.ForeColor = System.Drawing.Color.Navy;
            this.lblTitle.Location = new System.Drawing.Point(167, 5);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(130, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ToDoList";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.Location = new System.Drawing.Point(480, 62);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(147, 37);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Task";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstTasks
            // 
            this.lstTasks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstTasks.ForeColor = System.Drawing.Color.Black;
            this.lstTasks.FormattingEnabled = true;
            this.lstTasks.ItemHeight = 28;
            this.lstTasks.Location = new System.Drawing.Point(27, 111);
            this.lstTasks.Margin = new System.Windows.Forms.Padding(4);
            this.lstTasks.Name = "lstTasks";
            this.lstTasks.Size = new System.Drawing.Size(599, 228);
            this.lstTasks.TabIndex = 3;
            this.lstTasks.SelectedIndexChanged += new System.EventHandler(this.lstTasks_SelectedIndexChanged);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEdit.ForeColor = System.Drawing.Color.LightBlue;
            this.btnEdit.Location = new System.Drawing.Point(27, 369);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(105, 37);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit Task";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.LightCoral;
            this.btnDelete.Location = new System.Drawing.Point(258, 371);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(187, 37);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Task";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnMarkComplete
            // 
            this.btnMarkComplete.BackColor = System.Drawing.Color.White;
            this.btnMarkComplete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMarkComplete.ForeColor = System.Drawing.Color.Orange;
            this.btnMarkComplete.Location = new System.Drawing.Point(453, 369);
            this.btnMarkComplete.Margin = new System.Windows.Forms.Padding(4);
            this.btnMarkComplete.Name = "btnMarkComplete";
            this.btnMarkComplete.Size = new System.Drawing.Size(187, 37);
            this.btnMarkComplete.TabIndex = 6;
            this.btnMarkComplete.Text = "Mark Completed";
            this.btnMarkComplete.UseVisualStyleBackColor = false;
            this.btnMarkComplete.Click += new System.EventHandler(this.btnMarkComplete_Click);
            // 
            // lblTotalTasks
            // 
            this.lblTotalTasks.AutoSize = true;
            this.lblTotalTasks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalTasks.Location = new System.Drawing.Point(27, 418);
            this.lblTotalTasks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalTasks.Name = "lblTotalTasks";
            this.lblTotalTasks.Size = new System.Drawing.Size(144, 28);
            this.lblTotalTasks.TabIndex = 7;
            this.lblTotalTasks.Text = "Total Tasks : 0";
            this.lblTotalTasks.Click += new System.EventHandler(this.lblTotalTasks_Click);
            // 
            // chkDarkMode
            // 
            this.chkDarkMode.AutoSize = true;
            this.chkDarkMode.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDarkMode.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkDarkMode.Location = new System.Drawing.Point(527, 5);
            this.chkDarkMode.Name = "chkDarkMode";
            this.chkDarkMode.Size = new System.Drawing.Size(98, 21);
            this.chkDarkMode.TabIndex = 8;
            this.chkDarkMode.Text = "Dark Mode";
            this.chkDarkMode.UseVisualStyleBackColor = true;
            this.chkDarkMode.CheckedChanged += new System.EventHandler(this.chkDarkMode_CheckedChanged);
            // 
            // RedRadioButton
            // 
            this.RedRadioButton.Location = new System.Drawing.Point(279, 70);
            this.RedRadioButton.Name = "RedRadioButton";
            this.RedRadioButton.Size = new System.Drawing.Size(58, 24);
            this.RedRadioButton.TabIndex = 9;
            this.RedRadioButton.TabStop = true;
            this.RedRadioButton.Text = "High";
            this.RedRadioButton.UseVisualStyleBackColor = true;
            // 
            // BlueRadioButton
            // 
            this.BlueRadioButton.Location = new System.Drawing.Point(343, 70);
            this.BlueRadioButton.Name = "BlueRadioButton";
            this.BlueRadioButton.Size = new System.Drawing.Size(76, 24);
            this.BlueRadioButton.TabIndex = 10;
            this.BlueRadioButton.TabStop = true;
            this.BlueRadioButton.Text = "Medium";
            this.BlueRadioButton.UseVisualStyleBackColor = true;
            // 
            // GreenRadioButton
            // 
            this.GreenRadioButton.Location = new System.Drawing.Point(425, 70);
            this.GreenRadioButton.Name = "GreenRadioButton";
            this.GreenRadioButton.Size = new System.Drawing.Size(52, 24);
            this.GreenRadioButton.TabIndex = 11;
            this.GreenRadioButton.TabStop = true;
            this.GreenRadioButton.Text = "Low";
            this.GreenRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(353, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Urgency";
            // 
            // btnSaveEdit
            // 
            this.btnSaveEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnSaveEdit.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSaveEdit.Location = new System.Drawing.Point(139, 369);
            this.btnSaveEdit.Name = "btnSaveEdit";
            this.btnSaveEdit.Size = new System.Drawing.Size(112, 39);
            this.btnSaveEdit.TabIndex = 13;
            this.btnSaveEdit.Text = "Save Edit";
            this.btnSaveEdit.UseVisualStyleBackColor = true;
            this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
            // 
            // btnCustomTheme
            // 
            this.btnCustomTheme.Location = new System.Drawing.Point(480, 32);
            this.btnCustomTheme.Name = "btnCustomTheme";
            this.btnCustomTheme.Size = new System.Drawing.Size(145, 23);
            this.btnCustomTheme.TabIndex = 14;
            this.btnCustomTheme.Text = "Custom Theme";
            this.btnCustomTheme.UseVisualStyleBackColor = true;
            this.btnCustomTheme.Click += new System.EventHandler(this.btnCustomTheme_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 85);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 22);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // frmToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(645, 506);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnCustomTheme);
            this.Controls.Add(this.btnSaveEdit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GreenRadioButton);
            this.Controls.Add(this.BlueRadioButton);
            this.Controls.Add(this.RedRadioButton);
            this.Controls.Add(this.chkDarkMode);
            this.Controls.Add(this.lblTotalTasks);
            this.Controls.Add(this.btnMarkComplete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lstTasks);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.lblTitle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmToDoList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "To-Do List Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstTasks;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnMarkComplete;
        private System.Windows.Forms.Label lblTotalTasks;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.CheckBox chkDarkMode;
        private System.Windows.Forms.RadioButton RedRadioButton;
        private System.Windows.Forms.RadioButton BlueRadioButton;
        private System.Windows.Forms.RadioButton GreenRadioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveEdit;
        private System.Windows.Forms.Button btnCustomTheme;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;

        public Color BackColor { get; private set; }
    }
}
