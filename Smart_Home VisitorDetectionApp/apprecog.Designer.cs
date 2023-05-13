namespace Smart_Home_VisitorDetectionApp
{
    partial class apprecog
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
            this.Detectbtn = new System.Windows.Forms.Button();
            this.Add_Pertsonbtn = new System.Windows.Forms.Button();
            this.Train_Imagebtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Recognizebtn = new System.Windows.Forms.Button();
            this.picDetected = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).BeginInit();
            this.SuspendLayout();
            // 
            // Picbox
            // 
            this.Picbox.Location = new System.Drawing.Point(0, 0);
            this.Picbox.Name = "Picbox";
            this.Picbox.Size = new System.Drawing.Size(875, 653);
            this.Picbox.TabIndex = 0;
            this.Picbox.TabStop = false;
            // 
            // Capturebtn
            // 
            this.Capturebtn.Location = new System.Drawing.Point(881, 31);
            this.Capturebtn.Name = "Capturebtn";
            this.Capturebtn.Size = new System.Drawing.Size(129, 32);
            this.Capturebtn.TabIndex = 1;
            this.Capturebtn.Text = "1. Capture";
            this.Capturebtn.UseVisualStyleBackColor = true;
            this.Capturebtn.Click += new System.EventHandler(this.Capturebtn_Click);
            // 
            // Detectbtn
            // 
            this.Detectbtn.Location = new System.Drawing.Point(881, 69);
            this.Detectbtn.Name = "Detectbtn";
            this.Detectbtn.Size = new System.Drawing.Size(129, 32);
            this.Detectbtn.TabIndex = 2;
            this.Detectbtn.Text = "2. Detect";
            this.Detectbtn.UseVisualStyleBackColor = true;
            this.Detectbtn.Click += new System.EventHandler(this.Detectbtn_Click);
            // 
            // Add_Pertsonbtn
            // 
            this.Add_Pertsonbtn.Location = new System.Drawing.Point(881, 307);
            this.Add_Pertsonbtn.Name = "Add_Pertsonbtn";
            this.Add_Pertsonbtn.Size = new System.Drawing.Size(129, 32);
            this.Add_Pertsonbtn.TabIndex = 3;
            this.Add_Pertsonbtn.Text = "3. Add Person";
            this.Add_Pertsonbtn.UseVisualStyleBackColor = true;
            this.Add_Pertsonbtn.Click += new System.EventHandler(this.Add_Pertsonbtn_Click);
            // 
            // Train_Imagebtn
            // 
            this.Train_Imagebtn.Location = new System.Drawing.Point(881, 345);
            this.Train_Imagebtn.Name = "Train_Imagebtn";
            this.Train_Imagebtn.Size = new System.Drawing.Size(129, 32);
            this.Train_Imagebtn.TabIndex = 4;
            this.Train_Imagebtn.Text = "4. Train Images";
            this.Train_Imagebtn.UseVisualStyleBackColor = true;
            this.Train_Imagebtn.Click += new System.EventHandler(this.Train_Imagebtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(881, 281);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 20);
            this.textBox1.TabIndex = 5;
            // 
            // Recognizebtn
            // 
            this.Recognizebtn.Location = new System.Drawing.Point(881, 383);
            this.Recognizebtn.Name = "Recognizebtn";
            this.Recognizebtn.Size = new System.Drawing.Size(129, 32);
            this.Recognizebtn.TabIndex = 6;
            this.Recognizebtn.Text = "5. Recognize Persons";
            this.Recognizebtn.UseVisualStyleBackColor = true;
            this.Recognizebtn.Click += new System.EventHandler(this.Recognizebtn_Click);
            // 
            // picDetected
            // 
            this.picDetected.Location = new System.Drawing.Point(881, 107);
            this.picDetected.Name = "picDetected";
            this.picDetected.Size = new System.Drawing.Size(129, 157);
            this.picDetected.TabIndex = 7;
            this.picDetected.TabStop = false;
            // 
            // apprecog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 650);
            this.Controls.Add(this.picDetected);
            this.Controls.Add(this.Recognizebtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Train_Imagebtn);
            this.Controls.Add(this.Add_Pertsonbtn);
            this.Controls.Add(this.Detectbtn);
            this.Controls.Add(this.Capturebtn);
            this.Controls.Add(this.Picbox);
            this.Name = "apprecog";
            this.Text = "Smart Face Recognition";
            ((System.ComponentModel.ISupportInitialize)(this.Picbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetected)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picbox;
        private System.Windows.Forms.Button Capturebtn;
        private System.Windows.Forms.Button Detectbtn;
        private System.Windows.Forms.Button Add_Pertsonbtn;
        private System.Windows.Forms.Button Train_Imagebtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Recognizebtn;
        private System.Windows.Forms.PictureBox picDetected;
    }
}

