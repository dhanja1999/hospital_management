namespace hospital_management
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
            this.leftpanel = new System.Windows.Forms.Panel();
            this.upperpanel = new System.Windows.Forms.Panel();
            this.cornerlabel = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.BackColor = System.Drawing.Color.RosyBrown;
            this.leftpanel.Controls.Add(this.cornerlabel);
            this.leftpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftpanel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.leftpanel.Location = new System.Drawing.Point(0, 0);
            this.leftpanel.Name = "leftpanel";
            this.leftpanel.Size = new System.Drawing.Size(200, 511);
            this.leftpanel.TabIndex = 0;
            // 
            // upperpanel
            // 
            this.upperpanel.BackColor = System.Drawing.Color.RosyBrown;
            this.upperpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.upperpanel.Location = new System.Drawing.Point(200, 0);
            this.upperpanel.Name = "upperpanel";
            this.upperpanel.Size = new System.Drawing.Size(775, 100);
            this.upperpanel.TabIndex = 1;
            // 
            // cornerlabel
            // 
            this.cornerlabel.BackColor = System.Drawing.Color.Lavender;
            this.cornerlabel.Font = new System.Drawing.Font("Poor Richard", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cornerlabel.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cornerlabel.Location = new System.Drawing.Point(0, 0);
            this.cornerlabel.Name = "cornerlabel";
            this.cornerlabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cornerlabel.Size = new System.Drawing.Size(200, 100);
            this.cornerlabel.TabIndex = 3;
            this.cornerlabel.Text = "hospital";
            this.cornerlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 511);
            this.Controls.Add(this.upperpanel);
            this.Controls.Add(this.leftpanel);
            this.Name = "Form1";
            this.Text = "HOSPITAL MANAGEMENT SYSTEM";
            this.leftpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftpanel;
        private System.Windows.Forms.Panel upperpanel;
        private System.Windows.Forms.Label cornerlabel;
    }
}

