namespace WindowsFormsApp1
{
    partial class Applications
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstStudent = new System.Windows.Forms.ListBox();
            this.FillStudent = new System.Windows.Forms.Button();
            this.ReadFile = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.WriteFile = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstStudent
            // 
            this.lstStudent.FormattingEnabled = true;
            this.lstStudent.Location = new System.Drawing.Point(12, 12);
            this.lstStudent.Name = "lstStudent";
            this.lstStudent.Size = new System.Drawing.Size(594, 433);
            this.lstStudent.TabIndex = 0;
            this.lstStudent.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.lstStudent_Format);
            // 
            // FillStudent
            // 
            this.FillStudent.Location = new System.Drawing.Point(612, 12);
            this.FillStudent.Name = "FillStudent";
            this.FillStudent.Size = new System.Drawing.Size(109, 42);
            this.FillStudent.TabIndex = 1;
            this.FillStudent.Text = "FillStudent";
            this.FillStudent.UseVisualStyleBackColor = true;
            this.FillStudent.Click += new System.EventHandler(this.btnFillStudent_Click);
            // 
            // ReadFile
            // 
            this.ReadFile.Location = new System.Drawing.Point(612, 156);
            this.ReadFile.Name = "ReadFile";
            this.ReadFile.Size = new System.Drawing.Size(109, 42);
            this.ReadFile.TabIndex = 3;
            this.ReadFile.Text = "ReadFile";
            this.ReadFile.UseVisualStyleBackColor = true;
            this.ReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(612, 403);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(612, 204);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(109, 42);
            this.Remove.TabIndex = 5;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(612, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "CheckAverage";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnCheckAverage_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(612, 355);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "SortByAverage";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSort_Click_1);
            // 
            // WriteFile
            // 
            this.WriteFile.Location = new System.Drawing.Point(612, 108);
            this.WriteFile.Name = "WriteFile";
            this.WriteFile.Size = new System.Drawing.Size(109, 42);
            this.WriteFile.TabIndex = 2;
            this.WriteFile.Text = "WriteFile";
            this.WriteFile.UseVisualStyleBackColor = true;
            this.WriteFile.Click += new System.EventHandler(this.btnWriteFile_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(612, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 42);
            this.button3.TabIndex = 8;
            this.button3.Text = "AddStudent";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnAddStudent_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(612, 301);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(109, 48);
            this.panel1.TabIndex = 9;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(4, 27);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(92, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "По спаданню";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(97, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "По зростанню";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Applications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 453);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ReadFile);
            this.Controls.Add(this.WriteFile);
            this.Controls.Add(this.FillStudent);
            this.Controls.Add(this.lstStudent);
            this.Name = "Applications";
            this.Text = "Application";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstStudent;
        private System.Windows.Forms.Button FillStudent;
        private System.Windows.Forms.Button ReadFile;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button WriteFile;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

