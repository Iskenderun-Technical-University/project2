namespace Projex
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
            System.Windows.Forms.Label lblkul;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btngiris = new System.Windows.Forms.Button();
            this.lblşif = new System.Windows.Forms.Label();
            this.txtkul = new System.Windows.Forms.TextBox();
            this.txtşif = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            lblkul = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblkul
            // 
            lblkul.AutoSize = true;
            lblkul.BackColor = System.Drawing.Color.Transparent;
            lblkul.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            lblkul.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            lblkul.Location = new System.Drawing.Point(56, 164);
            lblkul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblkul.Name = "lblkul";
            lblkul.Size = new System.Drawing.Size(212, 29);
            lblkul.TabIndex = 1;
            lblkul.Text = "KULLANICI ADI : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label1.Location = new System.Drawing.Point(165, 69);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(758, 29);
            label1.TabIndex = 4;
            label1.Text = "LÜTFEN ŞİRKET KULLANICI ADI VE ŞİFRE BİLGİLERİNİ GİRİN ";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btngiris
            // 
            this.btngiris.BackColor = System.Drawing.Color.Red;
            this.btngiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiris.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btngiris.Location = new System.Drawing.Point(62, 377);
            this.btngiris.Margin = new System.Windows.Forms.Padding(4);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(500, 69);
            this.btngiris.TabIndex = 3;
            this.btngiris.Text = "GİRİŞ YAP";
            this.btngiris.UseVisualStyleBackColor = false;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // lblşif
            // 
            this.lblşif.AutoSize = true;
            this.lblşif.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblşif.Location = new System.Drawing.Point(57, 214);
            this.lblşif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblşif.Name = "lblşif";
            this.lblşif.Size = new System.Drawing.Size(102, 29);
            this.lblşif.TabIndex = 1;
            this.lblşif.Text = "ŞİFRE :";
            // 
            // txtkul
            // 
            this.txtkul.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtkul.ForeColor = System.Drawing.Color.White;
            this.txtkul.Location = new System.Drawing.Point(363, 164);
            this.txtkul.Margin = new System.Windows.Forms.Padding(4);
            this.txtkul.Name = "txtkul";
            this.txtkul.Size = new System.Drawing.Size(198, 22);
            this.txtkul.TabIndex = 1;
            this.txtkul.TextChanged += new System.EventHandler(this.txtkul_TextChanged);
            // 
            // txtşif
            // 
            this.txtşif.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.txtşif.Location = new System.Drawing.Point(364, 221);
            this.txtşif.Margin = new System.Windows.Forms.Padding(4);
            this.txtşif.Name = "txtşif";
            this.txtşif.Size = new System.Drawing.Size(197, 22);
            this.txtşif.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(718, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(297, 289);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(label1);
            this.Controls.Add(this.txtşif);
            this.Controls.Add(this.txtkul);
            this.Controls.Add(this.lblşif);
            this.Controls.Add(lblkul);
            this.Controls.Add(this.btngiris);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Label lblşif;
        private System.Windows.Forms.TextBox txtkul;
        private System.Windows.Forms.TextBox txtşif;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

