
namespace KİM_BİLİR
{
    partial class MaviGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaviGiris));
            this.xbtn = new System.Windows.Forms.Button();
            this.Geribtn = new System.Windows.Forms.Button();
            this.mavibtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kuponbtn = new System.Windows.Forms.Button();
            this.kupontxt = new System.Windows.Forms.TextBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // xbtn
            // 
            this.xbtn.BackgroundImage = global::KİM_BİLİR.Properties.Resources.ArkaPlan;
            this.xbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.xbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.xbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.xbtn.Location = new System.Drawing.Point(740, 3);
            this.xbtn.Name = "xbtn";
            this.xbtn.Size = new System.Drawing.Size(47, 28);
            this.xbtn.TabIndex = 41;
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
            this.Geribtn.Location = new System.Drawing.Point(687, 3);
            this.Geribtn.Name = "Geribtn";
            this.Geribtn.Size = new System.Drawing.Size(47, 28);
            this.Geribtn.TabIndex = 42;
            this.Geribtn.Text = ">";
            this.Geribtn.UseVisualStyleBackColor = true;
            this.Geribtn.Click += new System.EventHandler(this.Geribtn_Click);
            // 
            // mavibtn
            // 
            this.mavibtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.mavibtn.BackgroundImage = global::KİM_BİLİR.Properties.Resources.Mavi;
            this.mavibtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mavibtn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.mavibtn.FlatAppearance.BorderSize = 3;
            this.mavibtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mavibtn.Location = new System.Drawing.Point(34, 17);
            this.mavibtn.Name = "mavibtn";
            this.mavibtn.Size = new System.Drawing.Size(140, 80);
            this.mavibtn.TabIndex = 46;
            this.mavibtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.kuponbtn);
            this.panel1.Controls.Add(this.kupontxt);
            this.panel1.Controls.Add(this.mavibtn);
            this.panel1.Location = new System.Drawing.Point(-2, 395);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 112);
            this.panel1.TabIndex = 48;
            // 
            // kuponbtn
            // 
            this.kuponbtn.BackColor = System.Drawing.Color.Transparent;
            this.kuponbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kuponbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kuponbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.kuponbtn.Location = new System.Drawing.Point(222, 67);
            this.kuponbtn.Name = "kuponbtn";
            this.kuponbtn.Size = new System.Drawing.Size(394, 33);
            this.kuponbtn.TabIndex = 17;
            this.kuponbtn.Text = "YARIŞMAYA BAŞLA";
            this.kuponbtn.UseVisualStyleBackColor = false;
            this.kuponbtn.Click += new System.EventHandler(this.kuponbtn_Click);
            // 
            // kupontxt
            // 
            this.kupontxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kupontxt.Location = new System.Drawing.Point(222, 17);
            this.kupontxt.Multiline = true;
            this.kupontxt.Name = "kupontxt";
            this.kupontxt.Size = new System.Drawing.Size(394, 35);
            this.kupontxt.TabIndex = 1;
            this.kupontxt.Text = "Lütfen fişteteki müşteri numarasını giriniz...";
            this.kupontxt.Enter += new System.EventHandler(this.textBox1_Enter);
            this.kupontxt.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(-2, 299);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(804, 207);
            this.axWindowsMediaPlayer1.TabIndex = 47;
            this.axWindowsMediaPlayer1.TabStop = false;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // MaviGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::KİM_BİLİR.Properties.Resources.ArkaPlan1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.ControlBox = false;
            this.Controls.Add(this.Geribtn);
            this.Controls.Add(this.xbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MaviGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaviGiris";
            this.Load += new System.EventHandler(this.MaviGiris_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button xbtn;
        private System.Windows.Forms.Button Geribtn;
        private System.Windows.Forms.Button mavibtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button kuponbtn;
        private System.Windows.Forms.TextBox kupontxt;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}