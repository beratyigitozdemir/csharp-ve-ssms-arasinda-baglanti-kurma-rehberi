namespace sqlserverconnection
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvKisiler = new DataGridView();
            BtnKaydet = new Button();
            label2 = new Label();
            label1 = new Label();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvKisiler).BeginInit();
            SuspendLayout();
            // 
            // dgvKisiler
            // 
            dgvKisiler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKisiler.Location = new Point(92, 187);
            dgvKisiler.Name = "dgvKisiler";
            dgvKisiler.Size = new Size(457, 150);
            dgvKisiler.TabIndex = 11;
            // 
            // BtnKaydet
            // 
            BtnKaydet.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            BtnKaydet.Location = new Point(334, 75);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(139, 32);
            BtnKaydet.TabIndex = 10;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = true;
            BtnKaydet.Click += BtnKaydet_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(37, 107);
            label2.Name = "label2";
            label2.Size = new Size(50, 19);
            label2.TabIndex = 9;
            label2.Text = "Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(37, 56);
            label1.Name = "label1";
            label1.Size = new Size(28, 19);
            label1.TabIndex = 8;
            label1.Text = "Ad";
            // 
            // txtSoyad
            // 
            txtSoyad.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtSoyad.Location = new Point(92, 104);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(176, 26);
            txtSoyad.TabIndex = 7;
            // 
            // txtAd
            // 
            txtAd.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtAd.Location = new Point(92, 56);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(176, 26);
            txtAd.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvKisiler);
            Controls.Add(BtnKaydet);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Name = "Form1";
            Text = "Kayıt";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKisiler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvKisiler;
        private Button BtnKaydet;
        private Label label2;
        private Label label1;
        private TextBox txtSoyad;
        private TextBox txtAd;
    }
}
