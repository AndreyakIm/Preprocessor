namespace PreprocessorLib
{
    partial class SetMaterials
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.usedMaterials = new System.Windows.Forms.DataGridView();
            this.deleteRow = new System.Windows.Forms.DataGridViewButtonColumn();
            this.matID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matElastic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matPois = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sgat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matThick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matAreas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.pickAllAreas = new System.Windows.Forms.Label();
            this.areaMaterials = new System.Windows.Forms.TextBox();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.areasRadioBut = new System.Windows.Forms.RadioButton();
            this.FERadioBut = new System.Windows.Forms.RadioButton();
            this.FEMaterials = new System.Windows.Forms.TextBox();
            this.pickAllFE = new System.Windows.Forms.Label();
            this.tension2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorInvalidValue = new System.Windows.Forms.Label();
            this.materialName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.thickness = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tension = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.poissonsRatio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.elasticModulus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usedMaterials)).BeginInit();
            this.SuspendLayout();
            // 
            // usedMaterials
            // 
            this.usedMaterials.AllowUserToAddRows = false;
            this.usedMaterials.AllowUserToResizeRows = false;
            this.usedMaterials.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usedMaterials.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usedMaterials.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.usedMaterials.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usedMaterials.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deleteRow,
            this.matID,
            this.matName,
            this.matElastic,
            this.matPois,
            this.matTen,
            this.Sgat,
            this.matThick,
            this.matAreas});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usedMaterials.DefaultCellStyle = dataGridViewCellStyle2;
            this.usedMaterials.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.usedMaterials.Location = new System.Drawing.Point(16, 35);
            this.usedMaterials.Name = "usedMaterials";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usedMaterials.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.usedMaterials.RowHeadersVisible = false;
            this.usedMaterials.Size = new System.Drawing.Size(1007, 131);
            this.usedMaterials.TabIndex = 0;
            this.usedMaterials.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usedMaterials_CellContentClick);
            // 
            // deleteRow
            // 
            this.deleteRow.HeaderText = "Удалить материал";
            this.deleteRow.Name = "deleteRow";
            this.deleteRow.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.deleteRow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.deleteRow.Width = 60;
            // 
            // matID
            // 
            this.matID.HeaderText = "ID";
            this.matID.Name = "matID";
            this.matID.ReadOnly = true;
            this.matID.Width = 40;
            // 
            // matName
            // 
            this.matName.HeaderText = "Имя материала";
            this.matName.Name = "matName";
            this.matName.ReadOnly = true;
            this.matName.Width = 140;
            // 
            // matElastic
            // 
            this.matElastic.HeaderText = "Модуль упругости, Н/см^2";
            this.matElastic.Name = "matElastic";
            this.matElastic.ReadOnly = true;
            this.matElastic.Width = 140;
            // 
            // matPois
            // 
            this.matPois.HeaderText = "Коэффициент Пуассона";
            this.matPois.Name = "matPois";
            this.matPois.ReadOnly = true;
            this.matPois.Width = 140;
            // 
            // matTen
            // 
            this.matTen.HeaderText = "Допускаемое напряжение растяжения, Н/см^2";
            this.matTen.Name = "matTen";
            this.matTen.ReadOnly = true;
            this.matTen.Width = 140;
            // 
            // Sgat
            // 
            this.Sgat.HeaderText = "Допускаемое напряжение сжатия, Н/см^2";
            this.Sgat.Name = "Sgat";
            this.Sgat.ReadOnly = true;
            this.Sgat.Width = 140;
            // 
            // matThick
            // 
            this.matThick.HeaderText = "Толщина, см";
            this.matThick.Name = "matThick";
            this.matThick.ReadOnly = true;
            this.matThick.Width = 104;
            // 
            // matAreas
            // 
            this.matAreas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.matAreas.HeaderText = "Зоны";
            this.matAreas.Name = "matAreas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Используемые материалы:";
            // 
            // pickAllAreas
            // 
            this.pickAllAreas.AutoSize = true;
            this.pickAllAreas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pickAllAreas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pickAllAreas.ForeColor = System.Drawing.Color.Blue;
            this.pickAllAreas.Location = new System.Drawing.Point(290, 256);
            this.pickAllAreas.Name = "pickAllAreas";
            this.pickAllAreas.Size = new System.Drawing.Size(101, 13);
            this.pickAllAreas.TabIndex = 69;
            this.pickAllAreas.Text = "Выбрать все зоны";
            this.pickAllAreas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pickAllAreas_MouseClick);
            // 
            // areaMaterials
            // 
            this.areaMaterials.Location = new System.Drawing.Point(12, 253);
            this.areaMaterials.Name = "areaMaterials";
            this.areaMaterials.Size = new System.Drawing.Size(271, 20);
            this.areaMaterials.TabIndex = 68;
            // 
            // materialComboBox
            // 
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(154, 175);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(164, 21);
            this.materialComboBox.TabIndex = 71;
            this.materialComboBox.SelectedIndexChanged += new System.EventHandler(this.materialComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "Используемый материал:";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(171, 367);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 72;
            this.cancelButton.Text = "Закрыть";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(12, 367);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 74;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // areasRadioBut
            // 
            this.areasRadioBut.AutoSize = true;
            this.areasRadioBut.Checked = true;
            this.areasRadioBut.Location = new System.Drawing.Point(12, 230);
            this.areasRadioBut.Name = "areasRadioBut";
            this.areasRadioBut.Size = new System.Drawing.Size(275, 17);
            this.areasRadioBut.TabIndex = 75;
            this.areasRadioBut.TabStop = true;
            this.areasRadioBut.Text = "Номера зон с этим материалом (через запятую):";
            this.areasRadioBut.UseVisualStyleBackColor = true;
            this.areasRadioBut.CheckedChanged += new System.EventHandler(this.areaRadioBut_CheckedChanged);
            // 
            // FERadioBut
            // 
            this.FERadioBut.AutoSize = true;
            this.FERadioBut.Location = new System.Drawing.Point(12, 279);
            this.FERadioBut.Name = "FERadioBut";
            this.FERadioBut.Size = new System.Drawing.Size(271, 17);
            this.FERadioBut.TabIndex = 76;
            this.FERadioBut.Text = "Номера КЭ с этим материалом (через запятую):";
            this.FERadioBut.UseVisualStyleBackColor = true;
            this.FERadioBut.CheckedChanged += new System.EventHandler(this.FERadioBut_CheckedChanged);
            // 
            // FEMaterials
            // 
            this.FEMaterials.Enabled = false;
            this.FEMaterials.Location = new System.Drawing.Point(12, 302);
            this.FEMaterials.Name = "FEMaterials";
            this.FEMaterials.Size = new System.Drawing.Size(271, 20);
            this.FEMaterials.TabIndex = 77;
            // 
            // pickAllFE
            // 
            this.pickAllFE.AutoSize = true;
            this.pickAllFE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pickAllFE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pickAllFE.ForeColor = System.Drawing.Color.Blue;
            this.pickAllFE.Location = new System.Drawing.Point(290, 305);
            this.pickAllFE.Name = "pickAllFE";
            this.pickAllFE.Size = new System.Drawing.Size(89, 13);
            this.pickAllFE.TabIndex = 78;
            this.pickAllFE.Text = "Выбрать все КЭ";
            this.pickAllFE.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pickAllFE_MouseClick);
            // 
            // tension2
            // 
            this.tension2.Location = new System.Drawing.Point(779, 303);
            this.tension2.Name = "tension2";
            this.tension2.Size = new System.Drawing.Size(133, 20);
            this.tension2.TabIndex = 96;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(519, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 13);
            this.label6.TabIndex = 95;
            this.label6.Text = "Допускаемое напряжение сжатия, Н/см^2";
            // 
            // errorInvalidValue
            // 
            this.errorInvalidValue.AutoSize = true;
            this.errorInvalidValue.ForeColor = System.Drawing.Color.Red;
            this.errorInvalidValue.Location = new System.Drawing.Point(776, 357);
            this.errorInvalidValue.Name = "errorInvalidValue";
            this.errorInvalidValue.Size = new System.Drawing.Size(110, 13);
            this.errorInvalidValue.TabIndex = 93;
            this.errorInvalidValue.Text = "Неверное значение!";
            this.errorInvalidValue.Visible = false;
            // 
            // materialName
            // 
            this.materialName.Location = new System.Drawing.Point(779, 196);
            this.materialName.Name = "materialName";
            this.materialName.Size = new System.Drawing.Size(133, 20);
            this.materialName.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 89;
            this.label4.Text = "Имя материала:";
            // 
            // thickness
            // 
            this.thickness.Location = new System.Drawing.Point(779, 329);
            this.thickness.Name = "thickness";
            this.thickness.Size = new System.Drawing.Size(133, 20);
            this.thickness.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(521, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 87;
            this.label5.Text = "Толщина, см:";
            // 
            // tension
            // 
            this.tension.Location = new System.Drawing.Point(779, 277);
            this.tension.Name = "tension";
            this.tension.Size = new System.Drawing.Size(133, 20);
            this.tension.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "Допускаемое напряжение растяжения, Н/см^2:";
            // 
            // poissonsRatio
            // 
            this.poissonsRatio.Location = new System.Drawing.Point(779, 251);
            this.poissonsRatio.Name = "poissonsRatio";
            this.poissonsRatio.Size = new System.Drawing.Size(133, 20);
            this.poissonsRatio.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(519, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 13);
            this.label8.TabIndex = 83;
            this.label8.Text = "Коэффициент Пуассона:";
            // 
            // elasticModulus
            // 
            this.elasticModulus.Location = new System.Drawing.Point(779, 225);
            this.elasticModulus.Name = "elasticModulus";
            this.elasticModulus.Size = new System.Drawing.Size(133, 20);
            this.elasticModulus.TabIndex = 82;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(519, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 13);
            this.label9.TabIndex = 81;
            this.label9.Text = "Модуль упругости, Н/см^2:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(645, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 97;
            this.label2.Text = "Редактирование материала";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(126, 13);
            this.label10.TabIndex = 98;
            this.label10.Text = "Назначение материала";
            // 
            // SetMaterials
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CancelButton = this.cancelButton;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1035, 402);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tension2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.errorInvalidValue);
            this.Controls.Add(this.materialName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.thickness);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tension);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.poissonsRatio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.elasticModulus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pickAllFE);
            this.Controls.Add(this.FEMaterials);
            this.Controls.Add(this.FERadioBut);
            this.Controls.Add(this.areasRadioBut);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.materialComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pickAllAreas);
            this.Controls.Add(this.areaMaterials);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usedMaterials);
            this.MaximizeBox = false;
            this.Name = "SetMaterials";
            this.Text = "Материалы";
            ((System.ComponentModel.ISupportInitialize)(this.usedMaterials)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView usedMaterials;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pickAllAreas;
        private System.Windows.Forms.TextBox areaMaterials;
        private System.Windows.Forms.ComboBox materialComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.RadioButton areasRadioBut;
        private System.Windows.Forms.RadioButton FERadioBut;
        private System.Windows.Forms.TextBox FEMaterials;
        private System.Windows.Forms.Label pickAllFE;
        private System.Windows.Forms.TextBox tension2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label errorInvalidValue;
        private System.Windows.Forms.TextBox materialName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox thickness;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tension;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox poissonsRatio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox elasticModulus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewButtonColumn deleteRow;
        private System.Windows.Forms.DataGridViewTextBoxColumn matID;
        private System.Windows.Forms.DataGridViewTextBoxColumn matName;
        private System.Windows.Forms.DataGridViewTextBoxColumn matElastic;
        private System.Windows.Forms.DataGridViewTextBoxColumn matPois;
        private System.Windows.Forms.DataGridViewTextBoxColumn matTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sgat;
        private System.Windows.Forms.DataGridViewTextBoxColumn matThick;
        private System.Windows.Forms.DataGridViewTextBoxColumn matAreas;
    }
}