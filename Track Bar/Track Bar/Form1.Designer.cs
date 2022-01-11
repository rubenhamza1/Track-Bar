namespace Track_Bar
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
            this.trckVolume = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIspis = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trckVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // trckVolume
            // 
            this.trckVolume.LargeChange = 20;
            this.trckVolume.Location = new System.Drawing.Point(41, 44);
            this.trckVolume.Maximum = 100;
            this.trckVolume.Name = "trckVolume";
            this.trckVolume.Size = new System.Drawing.Size(253, 45);
            this.trckVolume.TabIndex = 0;
            this.trckVolume.Scroll += new System.EventHandler(this.trckVolume_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Postavljena vrijednost je:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIspis
            // 
            this.txtIspis.Location = new System.Drawing.Point(183, 139);
            this.txtIspis.Name = "txtIspis";
            this.txtIspis.Size = new System.Drawing.Size(100, 20);
            this.txtIspis.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 195);
            this.Controls.Add(this.txtIspis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trckVolume);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trckVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trckVolume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIspis;
    }
}

