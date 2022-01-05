
namespace OyunKutusuV1
{
    partial class frmAnasayfa
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
            this.btnYeniOyun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataListe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataListe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYeniOyun
            // 
            this.btnYeniOyun.BackColor = System.Drawing.Color.OrangeRed;
            this.btnYeniOyun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYeniOyun.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniOyun.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYeniOyun.Location = new System.Drawing.Point(12, 13);
            this.btnYeniOyun.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnYeniOyun.Name = "btnYeniOyun";
            this.btnYeniOyun.Size = new System.Drawing.Size(165, 47);
            this.btnYeniOyun.TabIndex = 12;
            this.btnYeniOyun.Text = "Yeni Oyun";
            this.btnYeniOyun.UseVisualStyleBackColor = false;
            this.btnYeniOyun.Click += new System.EventHandler(this.btnYeniOyun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(12, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Son 20 Oyun";
            // 
            // dataListe
            // 
            this.dataListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListe.Location = new System.Drawing.Point(19, 128);
            this.dataListe.Name = "dataListe";
            this.dataListe.RowHeadersWidth = 62;
            this.dataListe.RowTemplate.Height = 28;
            this.dataListe.Size = new System.Drawing.Size(965, 371);
            this.dataListe.TabIndex = 14;
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 518);
            this.Controls.Add(this.dataListe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYeniOyun);
            this.Name = "frmAnasayfa";
            this.Text = "frmAnasayfa";
            this.Load += new System.EventHandler(this.frmAnasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYeniOyun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataListe;
    }
}