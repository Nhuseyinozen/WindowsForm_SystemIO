namespace WindowsForm_SystemIO
{
    partial class Form1
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
            this.lstCustormer = new System.Windows.Forms.ListBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.GroupBox();
            this.comboCompany = new System.Windows.Forms.ComboBox();
            this.comboCountry = new System.Windows.Forms.ComboBox();
            this.comboEmail = new System.Windows.Forms.ComboBox();
            this.comboIName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboSurname = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.About.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstCustormer
            // 
            this.lstCustormer.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstCustormer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstCustormer.FormattingEnabled = true;
            this.lstCustormer.ItemHeight = 20;
            this.lstCustormer.Location = new System.Drawing.Point(30, 21);
            this.lstCustormer.Name = "lstCustormer";
            this.lstCustormer.Size = new System.Drawing.Size(286, 324);
            this.lstCustormer.TabIndex = 0;
            this.lstCustormer.DoubleClick += new System.EventHandler(this.lstCustormer_DoubleClick);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShow.Location = new System.Drawing.Point(30, 363);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(645, 40);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "SHOW";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Location = new System.Drawing.Point(30, 422);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(645, 40);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // About
            // 
            this.About.Controls.Add(this.comboSurname);
            this.About.Controls.Add(this.label7);
            this.About.Controls.Add(this.comboCompany);
            this.About.Controls.Add(this.comboCountry);
            this.About.Controls.Add(this.comboEmail);
            this.About.Controls.Add(this.comboIName);
            this.About.Controls.Add(this.label4);
            this.About.Controls.Add(this.label3);
            this.About.Controls.Add(this.label6);
            this.About.Controls.Add(this.label5);
            this.About.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.About.Location = new System.Drawing.Point(322, 20);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(359, 325);
            this.About.TabIndex = 3;
            this.About.TabStop = false;
            this.About.Text = "About";
            // 
            // comboCompany
            // 
            this.comboCompany.FormattingEnabled = true;
            this.comboCompany.Location = new System.Drawing.Point(105, 270);
            this.comboCompany.Name = "comboCompany";
            this.comboCompany.Size = new System.Drawing.Size(248, 33);
            this.comboCompany.TabIndex = 7;
            // 
            // comboCountry
            // 
            this.comboCountry.FormattingEnabled = true;
            this.comboCountry.Location = new System.Drawing.Point(105, 208);
            this.comboCountry.Name = "comboCountry";
            this.comboCountry.Size = new System.Drawing.Size(248, 33);
            this.comboCountry.TabIndex = 6;
            // 
            // comboEmail
            // 
            this.comboEmail.FormattingEnabled = true;
            this.comboEmail.Location = new System.Drawing.Point(105, 154);
            this.comboEmail.Name = "comboEmail";
            this.comboEmail.Size = new System.Drawing.Size(248, 33);
            this.comboEmail.TabIndex = 5;
            // 
            // comboIName
            // 
            this.comboIName.FormattingEnabled = true;
            this.comboIName.Location = new System.Drawing.Point(105, 51);
            this.comboIName.Name = "comboIName";
            this.comboIName.Size = new System.Drawing.Size(248, 33);
            this.comboIName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Company";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Country";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name";
            // 
            // comboSurname
            // 
            this.comboSurname.FormattingEnabled = true;
            this.comboSurname.Location = new System.Drawing.Point(105, 98);
            this.comboSurname.Name = "comboSurname";
            this.comboSurname.Size = new System.Drawing.Size(248, 33);
            this.comboSurname.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Surname";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 474);
            this.Controls.Add(this.About);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lstCustormer);
            this.Name = "Form1";
            this.Text = "SystemIO";
            this.About.ResumeLayout(false);
            this.About.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustormer;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox About;
        private System.Windows.Forms.ComboBox comboCompany;
        private System.Windows.Forms.ComboBox comboCountry;
        private System.Windows.Forms.ComboBox comboEmail;
        private System.Windows.Forms.ComboBox comboIName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboSurname;
        private System.Windows.Forms.Label label7;
    }
}

