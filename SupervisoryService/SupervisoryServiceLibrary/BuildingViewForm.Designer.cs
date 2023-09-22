namespace SupervisoryServiceLibrary
{
    partial class BuildingViewForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelCadastral = new System.Windows.Forms.Label();
            this.labelSquare = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelMaterial = new System.Windows.Forms.Label();
            this.labelFloors = new System.Windows.Forms.Label();
            this.labelResponsible = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(14, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 267);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
         //   this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(256, 20);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(54, 20);
            this.labelAdress.TabIndex = 1;
            this.labelAdress.Text = "Адрес:";
            // 
            // labelCadastral
            // 
            this.labelCadastral.AutoSize = true;
            this.labelCadastral.Location = new System.Drawing.Point(256, 47);
            this.labelCadastral.Name = "labelCadastral";
            this.labelCadastral.Size = new System.Drawing.Size(154, 20);
            this.labelCadastral.TabIndex = 2;
            this.labelCadastral.Text = "Кадастровый номер:";
            // 
            // labelSquare
            // 
            this.labelSquare.AutoSize = true;
            this.labelSquare.Location = new System.Drawing.Point(256, 73);
            this.labelSquare.Name = "labelSquare";
            this.labelSquare.Size = new System.Drawing.Size(102, 20);
            this.labelSquare.TabIndex = 3;
            this.labelSquare.Text = "Площадь, м2:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(256, 100);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(122, 20);
            this.labelDate.TabIndex = 4;
            this.labelDate.Text = "Дата постройки:";
            // 
            // labelMaterial
            // 
            this.labelMaterial.AutoSize = true;
            this.labelMaterial.Location = new System.Drawing.Point(256, 127);
            this.labelMaterial.Name = "labelMaterial";
            this.labelMaterial.Size = new System.Drawing.Size(81, 20);
            this.labelMaterial.TabIndex = 5;
            this.labelMaterial.Text = "Материал:";
            // 
            // labelFloors
            // 
            this.labelFloors.AutoSize = true;
            this.labelFloors.Location = new System.Drawing.Point(256, 153);
            this.labelFloors.Name = "labelFloors";
            this.labelFloors.Size = new System.Drawing.Size(63, 20);
            this.labelFloors.TabIndex = 6;
            this.labelFloors.Text = "Этажей:";
            // 
            // labelResponsible
            // 
            this.labelResponsible.AutoSize = true;
            this.labelResponsible.Location = new System.Drawing.Point(256, 180);
            this.labelResponsible.Name = "labelResponsible";
            this.labelResponsible.Size = new System.Drawing.Size(118, 20);
            this.labelResponsible.TabIndex = 7;
            this.labelResponsible.Text = "Ответственный:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(636, 189);
            this.button1.TabIndex = 8;
            this.button1.Text = "ОТКРЫТЬ НА КАРТЕ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BuildingViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelResponsible);
            this.Controls.Add(this.labelFloors);
            this.Controls.Add(this.labelMaterial);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelSquare);
            this.Controls.Add(this.labelCadastral);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BuildingViewForm";
            this.Text = "BuildingViewForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelAdress;
        private Label labelCadastral;
        private Label labelSquare;
        private Label labelDate;
        private Label labelMaterial;
        private Label labelFloors;
        private Label labelResponsible;
        private Button button1;
    }
}