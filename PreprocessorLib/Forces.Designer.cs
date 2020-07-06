namespace PreprocessorLib
{
    partial class Forces
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.function = new System.Windows.Forms.TextBox();
            this.sortByX = new System.Windows.Forms.RadioButton();
            this.sortByY = new System.Windows.Forms.RadioButton();
            this.ascSort = new System.Windows.Forms.RadioButton();
            this.descSort = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbxExcludeNodes = new System.Windows.Forms.CheckBox();
            this.txtExcludedNodes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.save1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(216, 518);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Закрыть";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(11, 342);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(113, 23);
            this.okButton.TabIndex = 11;
            this.okButton.Text = "Добавить нагрузку";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Номера линий:";
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number.Location = new System.Drawing.Point(91, 12);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(237, 26);
            this.number.TabIndex = 14;
            this.number.TextChanged += new System.EventHandler(this.number_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Функция F(X) = ";
            // 
            // function
            // 
            this.function.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.function.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.function.Location = new System.Drawing.Point(91, 122);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(237, 26);
            this.function.TabIndex = 16;
            this.function.TextChanged += new System.EventHandler(this.function_TextChanged);
            // 
            // sortByX
            // 
            this.sortByX.AutoSize = true;
            this.sortByX.Checked = true;
            this.sortByX.Location = new System.Drawing.Point(3, 4);
            this.sortByX.Name = "sortByX";
            this.sortByX.Size = new System.Drawing.Size(47, 17);
            this.sortByX.TabIndex = 85;
            this.sortByX.TabStop = true;
            this.sortByX.Text = "по X";
            this.sortByX.UseVisualStyleBackColor = true;
            // 
            // sortByY
            // 
            this.sortByY.AutoSize = true;
            this.sortByY.Location = new System.Drawing.Point(72, 4);
            this.sortByY.Name = "sortByY";
            this.sortByY.Size = new System.Drawing.Size(47, 17);
            this.sortByY.TabIndex = 86;
            this.sortByY.Text = "по Y";
            this.sortByY.UseVisualStyleBackColor = true;
            // 
            // ascSort
            // 
            this.ascSort.AutoSize = true;
            this.ascSort.Checked = true;
            this.ascSort.Location = new System.Drawing.Point(3, 3);
            this.ascSort.Name = "ascSort";
            this.ascSort.Size = new System.Drawing.Size(31, 17);
            this.ascSort.TabIndex = 87;
            this.ascSort.TabStop = true;
            this.ascSort.Text = ">";
            this.ascSort.UseVisualStyleBackColor = true;
            // 
            // descSort
            // 
            this.descSort.AutoSize = true;
            this.descSort.Location = new System.Drawing.Point(74, 3);
            this.descSort.Name = "descSort";
            this.descSort.Size = new System.Drawing.Size(31, 17);
            this.descSort.TabIndex = 88;
            this.descSort.Text = "<";
            this.descSort.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.sortByY);
            this.panel1.Controls.Add(this.sortByX);
            this.panel1.Location = new System.Drawing.Point(128, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(130, 24);
            this.panel1.TabIndex = 89;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.ascSort);
            this.panel2.Controls.Add(this.descSort);
            this.panel2.Location = new System.Drawing.Point(128, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(130, 24);
            this.panel2.TabIndex = 90;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 99;
            this.label6.Text = "Сортировка:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 100;
            this.label7.Text = "Тип сортировки:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 101;
            this.label4.Text = "Направление нагрузки:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 23);
            this.button1.TabIndex = 104;
            this.button1.Text = "Удалить все нагрузки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxExcludeNodes
            // 
            this.cbxExcludeNodes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxExcludeNodes.AutoSize = true;
            this.cbxExcludeNodes.Location = new System.Drawing.Point(11, 182);
            this.cbxExcludeNodes.Name = "cbxExcludeNodes";
            this.cbxExcludeNodes.Size = new System.Drawing.Size(113, 17);
            this.cbxExcludeNodes.TabIndex = 105;
            this.cbxExcludeNodes.Text = "Исключить узлы:";
            this.cbxExcludeNodes.UseVisualStyleBackColor = true;
            this.cbxExcludeNodes.CheckedChanged += new System.EventHandler(this.cbxExcludeNodes_CheckedChanged);
            // 
            // txtExcludedNodes
            // 
            this.txtExcludedNodes.Enabled = false;
            this.txtExcludedNodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtExcludedNodes.Location = new System.Drawing.Point(123, 176);
            this.txtExcludedNodes.Name = "txtExcludedNodes";
            this.txtExcludedNodes.Size = new System.Drawing.Size(205, 26);
            this.txtExcludedNodes.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(123, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 109;
            this.label3.Text = "25*cos(0.05*x-1.7)^3.3  (точка)";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Location = new System.Drawing.Point(141, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(157, 24);
            this.panel3.TabIndex = 110;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(64, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(28, 17);
            this.radioButton2.TabIndex = 110;
            this.radioButton2.Text = "-";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(31, 17);
            this.radioButton1.TabIndex = 109;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "+";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(67, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 111;
            this.label5.Text = "Пример:";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(69, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 111;
            this.label8.Text = "Пример:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(125, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 13);
            this.label9.TabIndex = 112;
            this.label9.Text = "1,12,18,48 (без пробелов, через запятую)";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 13);
            this.label10.TabIndex = 113;
            this.label10.Text = "Точность поиска нагруженных узлов:";
            // 
            // tb
            // 
            this.tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb.Location = new System.Drawing.Point(211, 287);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(117, 26);
            this.tb.TabIndex = 114;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(168, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 115;
            this.label11.Text = "Пример:";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(224, 316);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 116;
            this.label12.Text = "0.005 (точка)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 452);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 117;
            this.button2.Text = "Удалить нагрузку";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(130, 396);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 119;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 402);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 13);
            this.label13.TabIndex = 118;
            this.label13.Text = "Введите номер линии:";
            // 
            // save1
            // 
            this.save1.Location = new System.Drawing.Point(61, 518);
            this.save1.Name = "save1";
            this.save1.Size = new System.Drawing.Size(75, 23);
            this.save1.TabIndex = 120;
            this.save1.Text = "Сохранить";
            this.save1.UseVisualStyleBackColor = true;
            this.save1.Click += new System.EventHandler(this.save1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(10, 371);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 2);
            this.pictureBox1.TabIndex = 121;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(11, 495);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(350, 2);
            this.pictureBox2.TabIndex = 122;
            this.pictureBox2.TabStop = false;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(7, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(381, 13);
            this.label14.TabIndex = 123;
            this.label14.Text = "Номера линий, должны быть заданны одной геометрической функцией!!!";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(8, 425);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(154, 13);
            this.label15.TabIndex = 124;
            this.label15.Text = "Указывайте по одной линии!";
            // 
            // Forces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(385, 578);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.save1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtExcludedNodes);
            this.Controls.Add(this.cbxExcludeNodes);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.function);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.MaximizeBox = false;
            this.Name = "Forces";
            this.Text = "Нагрузки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Forces_FormClosed);
            this.Load += new System.EventHandler(this.Forces_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox function;
        public System.Windows.Forms.TextBox number;
        private System.Windows.Forms.RadioButton sortByX;
        private System.Windows.Forms.RadioButton sortByY;
        private System.Windows.Forms.RadioButton ascSort;
        private System.Windows.Forms.RadioButton descSort;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cbxExcludeNodes;
        private System.Windows.Forms.TextBox txtExcludedNodes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button save1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}