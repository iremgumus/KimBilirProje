
namespace KİM_BİLİR
{
    partial class UcretliGirisKayıt
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Adıtxt = new System.Windows.Forms.TextBox();
            this.Soyadıtxt = new System.Windows.Forms.TextBox();
            this.Sıfretxt = new System.Windows.Forms.TextBox();
            this.Grisbtn = new System.Windows.Forms.Button();
            this.KayıtOlbtn = new System.Windows.Forms.Button();
            this.xbtn = new System.Windows.Forms.Button();
            this.Geribtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(90, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "GİRİŞ EKRANI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(137, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(110, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Soyadı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(131, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Şifre:";
            // 
            // Adıtxt
            // 
            this.Adıtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Adıtxt.Location = new System.Drawing.Point(211, 140);
            this.Adıtxt.Multiline = true;
            this.Adıtxt.Name = "Adıtxt";
            this.Adıtxt.Size = new System.Drawing.Size(142, 25);
            this.Adıtxt.TabIndex = 0;
            this.Adıtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Adıtxt_KeyPress);
            // 
            // Soyadıtxt
            // 
            this.Soyadıtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Soyadıtxt.Location = new System.Drawing.Point(211, 178);
            this.Soyadıtxt.Multiline = true;
            this.Soyadıtxt.Name = "Soyadıtxt";
            this.Soyadıtxt.Size = new System.Drawing.Size(142, 25);
            this.Soyadıtxt.TabIndex = 1;
            this.Soyadıtxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Adıtxt_KeyPress);
            // 
            // Sıfretxt
            // 
            this.Sıfretxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Sıfretxt.Location = new System.Drawing.Point(211, 216);
            this.Sıfretxt.Multiline = true;
            this.Sıfretxt.Name = "Sıfretxt";
            this.Sıfretxt.PasswordChar = '*';
            this.Sıfretxt.Size = new System.Drawing.Size(142, 25);
            this.Sıfretxt.TabIndex = 2;
            this.Sıfretxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sıfretxt_KeyPress);
            // 
            // Grisbtn
            // 
            this.Grisbtn.BackColor = System.Drawing.Color.Transparent;
            this.Grisbtn.BackgroundImage = global::KİM_BİLİR.Properties.Resources.ArkaPlan;
            this.Grisbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Grisbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Grisbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Grisbtn.Location = new System.Drawing.Point(261, 256);
            this.Grisbtn.Name = "Grisbtn";
            this.Grisbtn.Size = new System.Drawing.Size(92, 33);
            this.Grisbtn.TabIndex = 3;
            this.Grisbtn.Text = "GİRİŞ";
            this.Grisbtn.UseVisualStyleBackColor = false;
            this.Grisbtn.Click += new System.EventHandler(this.Grisbtn_Click);
            // 
            // KayıtOlbtn
            // 
            this.KayıtOlbtn.BackColor = System.Drawing.Color.Transparent;
            this.KayıtOlbtn.BackgroundImage = global::KİM_BİLİR.Properties.Resources.ArkaPlan;
            this.KayıtOlbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KayıtOlbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KayıtOlbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.KayıtOlbtn.Location = new System.Drawing.Point(238, 295);
            this.KayıtOlbtn.Name = "KayıtOlbtn";
            this.KayıtOlbtn.Size = new System.Drawing.Size(115, 33);
            this.KayıtOlbtn.TabIndex = 4;
            this.KayıtOlbtn.Text = "KAYIT OL";
            this.KayıtOlbtn.UseVisualStyleBackColor = false;
            this.KayıtOlbtn.Click += new System.EventHandler(this.KayıtOlbtn_Click);
            // 
            // xbtn
            // 
            this.xbtn.BackgroundImage = global::KİM_BİLİR.Properties.Resources.ArkaPlan;
            this.xbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.xbtn.Location = new System.Drawing.Point(405, 1);
            this.xbtn.Name = "xbtn";
            this.xbtn.Size = new System.Drawing.Size(47, 28);
            this.xbtn.TabIndex = 5;
            this.xbtn.Text = "X";
            this.xbtn.UseVisualStyleBackColor = true;
            this.xbtn.Click += new System.EventHandler(this.xbtn_Click);
            // 
            // Geribtn
            // 
            this.Geribtn.BackgroundImage = global::KİM_BİLİR.Properties.Resources.ArkaPlan;
            this.Geribtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Geribtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Geribtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Geribtn.Location = new System.Drawing.Point(352, 1);
            this.Geribtn.Name = "Geribtn";
            this.Geribtn.Size = new System.Drawing.Size(47, 28);
            this.Geribtn.TabIndex = 6;
            this.Geribtn.Text = ">";
            this.Geribtn.UseVisualStyleBackColor = true;
            this.Geribtn.Click += new System.EventHandler(this.Geribtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBox1.Location = new System.Drawing.Point(371, 216);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 21);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "Göster";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // UcretliGirisKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KİM_BİLİR.Properties.Resources.ArkaPlan1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(453, 399);
            this.ControlBox = false;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Geribtn);
            this.Controls.Add(this.xbtn);
            this.Controls.Add(this.KayıtOlbtn);
            this.Controls.Add(this.Grisbtn);
            this.Controls.Add(this.Sıfretxt);
            this.Controls.Add(this.Soyadıtxt);
            this.Controls.Add(this.Adıtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UcretliGirisKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ EKRANI";
            this.Load += new System.EventHandler(this.UcretliGirisKayıt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Adıtxt;
        private System.Windows.Forms.TextBox Soyadıtxt;
        private System.Windows.Forms.TextBox Sıfretxt;
        private System.Windows.Forms.Button Grisbtn;
        private System.Windows.Forms.Button KayıtOlbtn;
        private System.Windows.Forms.Button xbtn;
        private System.Windows.Forms.Button Geribtn;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}