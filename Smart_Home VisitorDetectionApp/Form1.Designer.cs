namespace Smart_Home_VisitorDetectionApp
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
            this.Picbox = new System.Windows.Forms.PictureBox();
            this.Capturebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // Picbox
            // 
            this.Picbox.Location = new System.Drawing.Point(0, 0);
            this.Picbox.Name = "Picbox";
            this.Picbox.Size = new System.Drawing.Size(875, 651);
            this.Picbox.TabIndex = 0;
            this.Picbox.TabStop = false;
            // 
            // Capturebtn
            // 
            this.Capturebtn.Location = new System.Drawing.Point(893, 31);
            this.Capturebtn.Name = "Capturebtn";
            this.Capturebtn.Size = new System.Drawing.Size(117, 32);
            this.Capturebtn.TabIndex = 1;
            this.Capturebtn.Text = "Capture";
            this.Capturebtn.UseVisualStyleBackColor = true;
            this.Capturebtn.Click += new System.EventHandler(this.Capturebtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 650);
            this.Controls.Add(this.Capturebtn);
            this.Controls.Add(this.Picbox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Picbox;
        private System.Windows.Forms.Button Capturebtn;
    }
}

