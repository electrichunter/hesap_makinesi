﻿namespace Hesap_makinası
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ekran_tbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.esittir_btn = new System.Windows.Forms.Button();
            this.eksi_btn = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_carp = new System.Windows.Forms.Button();
            this.btn_bol = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.işlem_lbl = new System.Windows.Forms.Label();
            this.geçmiş2_lbl = new System.Windows.Forms.Label();
            this.btn_toplam = new System.Windows.Forms.Button();
            this.kare_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ekran_tbox
            // 
            this.Ekran_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ekran_tbox.Location = new System.Drawing.Point(47, 125);
            this.Ekran_tbox.Name = "Ekran_tbox";
            this.Ekran_tbox.Size = new System.Drawing.Size(510, 45);
            this.Ekran_tbox.TabIndex = 0;
            this.Ekran_tbox.Text = "0";
            this.Ekran_tbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Ekran_tbox.TextChanged += new System.EventHandler(this.Ekran_tbox_TextChanged);
            this.Ekran_tbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ekran_tbox_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(47, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 108);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_2.Location = new System.Drawing.Point(176, 185);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(108, 108);
            this.btn_2.TabIndex = 2;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_3.Location = new System.Drawing.Point(311, 185);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(108, 108);
            this.btn_3.TabIndex = 3;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // esittir_btn
            // 
            this.esittir_btn.BackColor = System.Drawing.Color.DeepPink;
            this.esittir_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.esittir_btn.ForeColor = System.Drawing.Color.Black;
            this.esittir_btn.Location = new System.Drawing.Point(311, 597);
            this.esittir_btn.Name = "esittir_btn";
            this.esittir_btn.Size = new System.Drawing.Size(108, 108);
            this.esittir_btn.TabIndex = 5;
            this.esittir_btn.Text = "=";
            this.esittir_btn.UseVisualStyleBackColor = false;
            this.esittir_btn.Click += new System.EventHandler(this.esittir_btn_Click);
            // 
            // eksi_btn
            // 
            this.eksi_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.eksi_btn.Location = new System.Drawing.Point(449, 327);
            this.eksi_btn.Name = "eksi_btn";
            this.eksi_btn.Size = new System.Drawing.Size(108, 108);
            this.eksi_btn.TabIndex = 6;
            this.eksi_btn.Text = "-";
            this.eksi_btn.UseVisualStyleBackColor = true;
            this.eksi_btn.Click += new System.EventHandler(this.eksi_btn_Click);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_6.Location = new System.Drawing.Point(311, 327);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(108, 108);
            this.btn_6.TabIndex = 9;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_5.Location = new System.Drawing.Point(176, 327);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(108, 108);
            this.btn_5.TabIndex = 8;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_4.Location = new System.Drawing.Point(47, 327);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(108, 108);
            this.btn_4.TabIndex = 7;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_7.Location = new System.Drawing.Point(47, 464);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(108, 108);
            this.btn_7.TabIndex = 7;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_8.Location = new System.Drawing.Point(176, 464);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(108, 108);
            this.btn_8.TabIndex = 8;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_9.Location = new System.Drawing.Point(311, 464);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(108, 108);
            this.btn_9.TabIndex = 9;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_0.Location = new System.Drawing.Point(176, 597);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(108, 108);
            this.btn_0.TabIndex = 10;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_carp
            // 
            this.btn_carp.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_carp.Location = new System.Drawing.Point(449, 464);
            this.btn_carp.Name = "btn_carp";
            this.btn_carp.Size = new System.Drawing.Size(108, 108);
            this.btn_carp.TabIndex = 11;
            this.btn_carp.Text = "x";
            this.btn_carp.UseVisualStyleBackColor = true;
            this.btn_carp.Click += new System.EventHandler(this.btn_carp_Click);
            // 
            // btn_bol
            // 
            this.btn_bol.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bol.Location = new System.Drawing.Point(449, 597);
            this.btn_bol.Name = "btn_bol";
            this.btn_bol.Size = new System.Drawing.Size(108, 108);
            this.btn_bol.TabIndex = 12;
            this.btn_bol.Text = "/";
            this.btn_bol.UseVisualStyleBackColor = true;
            this.btn_bol.Click += new System.EventHandler(this.btn_bol_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(47, 597);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 108);
            this.button2.TabIndex = 13;
            this.button2.Text = "C";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // işlem_lbl
            // 
            this.işlem_lbl.AutoSize = true;
            this.işlem_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.işlem_lbl.Location = new System.Drawing.Point(52, 64);
            this.işlem_lbl.Name = "işlem_lbl";
            this.işlem_lbl.Size = new System.Drawing.Size(0, 38);
            this.işlem_lbl.TabIndex = 14;
            // 
            // geçmiş2_lbl
            // 
            this.geçmiş2_lbl.AutoSize = true;
            this.geçmiş2_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geçmiş2_lbl.Location = new System.Drawing.Point(56, 21);
            this.geçmiş2_lbl.Name = "geçmiş2_lbl";
            this.geçmiş2_lbl.Size = new System.Drawing.Size(14, 16);
            this.geçmiş2_lbl.TabIndex = 15;
            this.geçmiş2_lbl.Text = "0";
            // 
            // btn_toplam
            // 
            this.btn_toplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_toplam.Location = new System.Drawing.Point(449, 185);
            this.btn_toplam.Name = "btn_toplam";
            this.btn_toplam.Size = new System.Drawing.Size(108, 108);
            this.btn_toplam.TabIndex = 4;
            this.btn_toplam.Text = "+";
            this.btn_toplam.UseVisualStyleBackColor = true;
            this.btn_toplam.Click += new System.EventHandler(this.btn_toplam_Click);
            // 
            // kare_btn
            // 
            this.kare_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kare_btn.Location = new System.Drawing.Point(589, 597);
            this.kare_btn.Name = "kare_btn";
            this.kare_btn.Size = new System.Drawing.Size(108, 108);
            this.kare_btn.TabIndex = 16;
            this.kare_btn.Text = "√x";
            this.kare_btn.UseVisualStyleBackColor = true;
            this.kare_btn.Click += new System.EventHandler(this.kare_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(797, 740);
            this.Controls.Add(this.kare_btn);
            this.Controls.Add(this.geçmiş2_lbl);
            this.Controls.Add(this.işlem_lbl);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_bol);
            this.Controls.Add(this.btn_carp);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.eksi_btn);
            this.Controls.Add(this.esittir_btn);
            this.Controls.Add(this.btn_toplam);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ekran_tbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Ekran_tbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button esittir_btn;
        private System.Windows.Forms.Button eksi_btn;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_carp;
        private System.Windows.Forms.Button btn_bol;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label işlem_lbl;
        private System.Windows.Forms.Label geçmiş2_lbl;
        private System.Windows.Forms.Button btn_toplam;
        private System.Windows.Forms.Button kare_btn;
    }
}

