namespace hospital_management
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.afterdoctorlogin1 = new hospital_management.afterdoctorlogin();
            this.doctorloggedin1 = new hospital_management.doctorloggedin();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 508);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGIN  AS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(0, 302);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 49);
            this.button3.TabIndex = 2;
            this.button3.Text = "HOSPITAL";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 49);
            this.button2.TabIndex = 1;
            this.button2.Text = "PATIENT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "DOCTOR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // afterdoctorlogin1
            // 
            this.afterdoctorlogin1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.afterdoctorlogin1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("afterdoctorlogin1.BackgroundImage")));
            this.afterdoctorlogin1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.afterdoctorlogin1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.afterdoctorlogin1.Location = new System.Drawing.Point(138, 0);
            this.afterdoctorlogin1.Name = "afterdoctorlogin1";
            this.afterdoctorlogin1.Size = new System.Drawing.Size(905, 508);
            this.afterdoctorlogin1.TabIndex = 1;
            // 
            // doctorloggedin1
            // 
            this.doctorloggedin1.BackColor = System.Drawing.Color.AliceBlue;
            this.doctorloggedin1.Location = new System.Drawing.Point(-3, 0);
            this.doctorloggedin1.Name = "doctorloggedin1";
            this.doctorloggedin1.Size = new System.Drawing.Size(1045, 508);
            this.doctorloggedin1.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1043, 508);
            this.Controls.Add(this.afterdoctorlogin1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.doctorloggedin1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public afterdoctorlogin afterdoctorlogin1;
        private System.Windows.Forms.Label label1;
        public doctorloggedin doctorloggedin1;
    }
}