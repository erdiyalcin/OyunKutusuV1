
namespace OyunKutusuV1
{
    partial class frmSayiTahmin
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
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.btmTahmin = new System.Windows.Forms.Button();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataSonBesOyunum = new System.Windows.Forms.DataGridView();
            this.dataSonBesHerkes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataSonBesOyunum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSonBesHerkes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.BackColor = System.Drawing.Color.OrangeRed;
            this.btnYeniOyun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniOyun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYeniOyun.Location = new System.Drawing.Point(530, 29);
            this.btnYeniOyun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(165, 64);
            this.btnYeniOyun.TabIndex = 13;
            this.btnYeniOyun.Text = "Yeni Oyun";
            this.btnYeniOyun.UseVisualStyleBackColor = false;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // btmTahmin
            // 
            this.btmTahmin.BackColor = System.Drawing.Color.OrangeRed;
            this.btmTahmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btmTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btmTahmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btmTahmin.Location = new System.Drawing.Point(260, 29);
            this.btmTahmin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btmTahmin.Name = "btmTahmin";
            this.btmTahmin.Size = new System.Drawing.Size(165, 64);
            this.btmTahmin.TabIndex = 14;
            this.btmTahmin.Text = "Tahmin Et";
            this.btmTahmin.UseVisualStyleBackColor = false;
            this.btmTahmin.Click += new System.EventHandler(this.btmTahmin_Click);
            // 
            // txtSayi
            // 
            this.txtSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSayi.Location = new System.Drawing.Point(114, 29);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(126, 64);
            this.txtSayi.TabIndex = 15;
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblSure.Location = new System.Drawing.Point(27, 40);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(53, 37);
            this.lblSure.TabIndex = 16;
            this.lblSure.Text = "40";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblAciklama.Location = new System.Drawing.Point(29, 117);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(481, 29);
            this.lblAciklama.TabIndex = 17;
            this.lblAciklama.Text = "Yeni oyun oynamak için Yeni Oyun a basınız";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataSonBesOyunum
            // 
            this.dataSonBesOyunum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSonBesOyunum.Location = new System.Drawing.Point(34, 181);
            this.dataSonBesOyunum.Name = "dataSonBesOyunum";
            this.dataSonBesOyunum.RowHeadersWidth = 62;
            this.dataSonBesOyunum.RowTemplate.Height = 28;
            this.dataSonBesOyunum.Size = new System.Drawing.Size(1072, 229);
            this.dataSonBesOyunum.TabIndex = 18;
            // 
            // dataSonBesHerkes
            // 
            this.dataSonBesHerkes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSonBesHerkes.Location = new System.Drawing.Point(34, 428);
            this.dataSonBesHerkes.Name = "dataSonBesHerkes";
            this.dataSonBesHerkes.RowHeadersWidth = 62;
            this.dataSonBesHerkes.RowTemplate.Height = 28;
            this.dataSonBesHerkes.Size = new System.Drawing.Size(1072, 246);
            this.dataSonBesHerkes.TabIndex = 19;
            // 
            // frmSayiTahmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 718);
            this.Controls.Add(this.dataSonBesHerkes);
            this.Controls.Add(this.dataSonBesOyunum);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.btmTahmin);
            this.Controls.Add(this.btnYeniOyun);
            this.Name = "frmSayiTahmin";
            this.Text = "frmSayiTahmin";
            this.Load += new System.EventHandler(this.frmSayiTahmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSonBesOyunum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSonBesHerkes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYeniOyun;
        private System.Windows.Forms.Button btmTahmin;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataSonBesOyunum;
        private System.Windows.Forms.DataGridView dataSonBesHerkes;
    }
}