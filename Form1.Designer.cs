namespace WarnasRecommender
{
    partial class Homeform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nUDKualitas = new System.Windows.Forms.NumericUpDown();
            this.nUDHarga = new System.Windows.Forms.NumericUpDown();
            this.nUDPelayanan = new System.Windows.Forms.NumericUpDown();
            this.nUDSuasana = new System.Windows.Forms.NumericUpDown();
            this.nUDJarak = new System.Windows.Forms.NumericUpDown();
            this.btnFinishValuing = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUDKualitas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDHarga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPelayanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSuasana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDJarak)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selamat datang di WarNasRecc, pertama-tama tolong isi seberapa penting karakteris" +
    "tik\r\ndibawah menurut anda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "(1=Tidak Penting, 5=Sangat penting sekali)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kualitas Makanan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Harga Makanan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Pelayanan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Jarak";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Suasana Restoran";
            // 
            // nUDKualitas
            // 
            this.nUDKualitas.Location = new System.Drawing.Point(217, 70);
            this.nUDKualitas.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDKualitas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDKualitas.Name = "nUDKualitas";
            this.nUDKualitas.Size = new System.Drawing.Size(40, 20);
            this.nUDKualitas.TabIndex = 1;
            this.nUDKualitas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUDHarga
            // 
            this.nUDHarga.Location = new System.Drawing.Point(217, 96);
            this.nUDHarga.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDHarga.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDHarga.Name = "nUDHarga";
            this.nUDHarga.Size = new System.Drawing.Size(40, 20);
            this.nUDHarga.TabIndex = 2;
            this.nUDHarga.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUDPelayanan
            // 
            this.nUDPelayanan.Location = new System.Drawing.Point(217, 122);
            this.nUDPelayanan.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDPelayanan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDPelayanan.Name = "nUDPelayanan";
            this.nUDPelayanan.Size = new System.Drawing.Size(40, 20);
            this.nUDPelayanan.TabIndex = 3;
            this.nUDPelayanan.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUDSuasana
            // 
            this.nUDSuasana.Location = new System.Drawing.Point(217, 148);
            this.nUDSuasana.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDSuasana.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDSuasana.Name = "nUDSuasana";
            this.nUDSuasana.Size = new System.Drawing.Size(40, 20);
            this.nUDSuasana.TabIndex = 4;
            this.nUDSuasana.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nUDJarak
            // 
            this.nUDJarak.Location = new System.Drawing.Point(217, 174);
            this.nUDJarak.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDJarak.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDJarak.Name = "nUDJarak";
            this.nUDJarak.Size = new System.Drawing.Size(40, 20);
            this.nUDJarak.TabIndex = 5;
            this.nUDJarak.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnFinishValuing
            // 
            this.btnFinishValuing.Location = new System.Drawing.Point(356, 200);
            this.btnFinishValuing.Name = "btnFinishValuing";
            this.btnFinishValuing.Size = new System.Drawing.Size(75, 23);
            this.btnFinishValuing.TabIndex = 6;
            this.btnFinishValuing.Text = "Lanjut";
            this.btnFinishValuing.UseVisualStyleBackColor = true;
            this.btnFinishValuing.Click += new System.EventHandler(this.btnFinishValuing_Click);
            // 
            // Homeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 235);
            this.Controls.Add(this.btnFinishValuing);
            this.Controls.Add(this.nUDJarak);
            this.Controls.Add(this.nUDSuasana);
            this.Controls.Add(this.nUDPelayanan);
            this.Controls.Add(this.nUDHarga);
            this.Controls.Add(this.nUDKualitas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Homeform";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Homeform_FormClosing);
            this.Load += new System.EventHandler(this.Homeform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUDKualitas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDHarga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDPelayanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDSuasana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDJarak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nUDKualitas;
        private System.Windows.Forms.NumericUpDown nUDHarga;
        private System.Windows.Forms.NumericUpDown nUDPelayanan;
        private System.Windows.Forms.NumericUpDown nUDSuasana;
        private System.Windows.Forms.NumericUpDown nUDJarak;
        private System.Windows.Forms.Button btnFinishValuing;
    }
}

