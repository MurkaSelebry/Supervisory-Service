namespace SupervisoryServiceLibrary
{
    partial class SolutionFilterForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerMax = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerMin = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(96, 134);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 28;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(15, 134);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 27;
            this.buttonOk.Text = "ОК";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // comboBoxMaterial
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(15, 105);
            this.comboBoxStatus.Name = "comboBoxMaterial";
            this.comboBoxStatus.Size = new System.Drawing.Size(156, 23);
            this.comboBoxStatus.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 24;
            this.label7.Text = "Статус:";
            // 
            // dateTimePickerMax
            // 
            this.dateTimePickerMax.Location = new System.Drawing.Point(37, 61);
            this.dateTimePickerMax.Name = "dateTimePickerMax";
            this.dateTimePickerMax.Size = new System.Drawing.Size(132, 23);
            this.dateTimePickerMax.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "до";
            // 
            // dateTimePickerMin
            // 
            this.dateTimePickerMin.Location = new System.Drawing.Point(37, 32);
            this.dateTimePickerMin.Name = "dateTimePickerMin";
            this.dateTimePickerMin.Size = new System.Drawing.Size(132, 23);
            this.dateTimePickerMin.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 15);
            this.label5.TabIndex = 20;
            this.label5.Text = "от";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Дата принятия решения:";
            // 
            // SolutionFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 171);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerMax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "SolutionFilterForm";
            this.Text = "SolutionFilterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonCancel;
        private Button buttonOk;
        private ComboBox comboBoxStatus;
        private Label label7;
        private DateTimePicker dateTimePickerMax;
        private Label label6;
        private DateTimePicker dateTimePickerMin;
        private Label label5;
        private Label label4;
    }
}