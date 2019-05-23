namespace ArabaYarısı
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
            this.components = new System.ComponentModel.Container();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.blueCar = new System.Windows.Forms.PictureBox();
            this.greenCar = new System.Windows.Forms.PictureBox();
            this.yellowCar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(498, 171);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(55, 20);
            this.lblSonuc.TabIndex = 15;
            this.lblSonuc.Text = "Sonuç";
            // 
            // btnEnd
            // 
            this.btnEnd.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEnd.Location = new System.Drawing.Point(478, 79);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(105, 50);
            this.btnEnd.TabIndex = 13;
            this.btnEnd.Text = "Oyunu Sonlandır";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(478, 14);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(105, 39);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Oyunu Başlat";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Red;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(428, 10);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // blueCar
            // 
            this.blueCar.BackColor = System.Drawing.Color.Gray;
            this.blueCar.Image = global::ArabaYarısı.Properties.Resources.turquois_racing_car_top_view_105016;
            this.blueCar.Location = new System.Drawing.Point(319, 350);
            this.blueCar.Name = "blueCar";
            this.blueCar.Size = new System.Drawing.Size(60, 88);
            this.blueCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.blueCar.TabIndex = 11;
            this.blueCar.TabStop = false;
            // 
            // greenCar
            // 
            this.greenCar.BackColor = System.Drawing.Color.Gray;
            this.greenCar.Image = global::ArabaYarısı.Properties.Resources.image;
            this.greenCar.Location = new System.Drawing.Point(202, 350);
            this.greenCar.Name = "greenCar";
            this.greenCar.Size = new System.Drawing.Size(60, 88);
            this.greenCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.greenCar.TabIndex = 10;
            this.greenCar.TabStop = false;
            // 
            // yellowCar
            // 
            this.yellowCar.BackColor = System.Drawing.Color.Gray;
            this.yellowCar.Image = global::ArabaYarısı.Properties.Resources.yellow_racing_car_top_view_105025;
            this.yellowCar.Location = new System.Drawing.Point(81, 350);
            this.yellowCar.Name = "yellowCar";
            this.yellowCar.Size = new System.Drawing.Size(60, 88);
            this.yellowCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yellowCar.TabIndex = 9;
            this.yellowCar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ArabaYarısı.Properties.Resources.yol_714x536;
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.blueCar);
            this.Controls.Add(this.greenCar);
            this.Controls.Add(this.yellowCar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Araba Yarışı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox blueCar;
        private System.Windows.Forms.PictureBox greenCar;
        private System.Windows.Forms.PictureBox yellowCar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

