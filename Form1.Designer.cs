namespace tudien11
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
            this.btnSEARCH = new System.Windows.Forms.Button();
            this.btnDELETE = new System.Windows.Forms.Button();
            this.txtSearchTerm = new System.Windows.Forms.TextBox();
            this.txtMeanings = new System.Windows.Forms.TextBox();
            this.btnEDIT = new System.Windows.Forms.Button();
            this.btnEXIT = new System.Windows.Forms.Button();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtExamples = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnADD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSEARCH
            // 
            this.btnSEARCH.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSEARCH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSEARCH.Location = new System.Drawing.Point(514, 11);
            this.btnSEARCH.Margin = new System.Windows.Forms.Padding(2);
            this.btnSEARCH.Name = "btnSEARCH";
            this.btnSEARCH.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSEARCH.Size = new System.Drawing.Size(89, 31);
            this.btnSEARCH.TabIndex = 1;
            this.btnSEARCH.Text = "TRA CỨU";
            this.btnSEARCH.UseVisualStyleBackColor = true;
            this.btnSEARCH.Click += new System.EventHandler(this.btnSEARCH_Click);
            // 
            // btnDELETE
            // 
            this.btnDELETE.Location = new System.Drawing.Point(514, 129);
            this.btnDELETE.Margin = new System.Windows.Forms.Padding(2);
            this.btnDELETE.Name = "btnDELETE";
            this.btnDELETE.Size = new System.Drawing.Size(89, 31);
            this.btnDELETE.TabIndex = 7;
            this.btnDELETE.Text = "XÓA TỪ";
            this.btnDELETE.UseVisualStyleBackColor = true;
            this.btnDELETE.Click += new System.EventHandler(this.btnDELETE_Click);
            // 
            // txtSearchTerm
            // 
            this.txtSearchTerm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSearchTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchTerm.Location = new System.Drawing.Point(303, 11);
            this.txtSearchTerm.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchTerm.Multiline = true;
            this.txtSearchTerm.Name = "txtSearchTerm";
            this.txtSearchTerm.Size = new System.Drawing.Size(170, 31);
            this.txtSearchTerm.TabIndex = 0;
            this.txtSearchTerm.TextChanged += new System.EventHandler(this.txtSearchTerm_TextChanged);
            // 
            // txtMeanings
            // 
            this.txtMeanings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeanings.Location = new System.Drawing.Point(76, 172);
            this.txtMeanings.Margin = new System.Windows.Forms.Padding(2);
            this.txtMeanings.Multiline = true;
            this.txtMeanings.Name = "txtMeanings";
            this.txtMeanings.Size = new System.Drawing.Size(294, 61);
            this.txtMeanings.TabIndex = 4;
            // 
            // btnEDIT
            // 
            this.btnEDIT.Location = new System.Drawing.Point(514, 202);
            this.btnEDIT.Margin = new System.Windows.Forms.Padding(2);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.Size = new System.Drawing.Size(89, 31);
            this.btnEDIT.TabIndex = 8;
            this.btnEDIT.Text = "CHỈNH TỪ";
            this.btnEDIT.UseVisualStyleBackColor = true;
            this.btnEDIT.Click += new System.EventHandler(this.btnEDIT_Click);
            // 
            // btnEXIT
            // 
            this.btnEXIT.Location = new System.Drawing.Point(514, 279);
            this.btnEXIT.Margin = new System.Windows.Forms.Padding(2);
            this.btnEXIT.Name = "btnEXIT";
            this.btnEXIT.Size = new System.Drawing.Size(89, 31);
            this.btnEXIT.TabIndex = 9;
            this.btnEXIT.Text = "THOÁT";
            this.btnEXIT.UseVisualStyleBackColor = true;
            this.btnEXIT.Click += new System.EventHandler(this.btnEXIT_Click);
            // 
            // txtTerm
            // 
            this.txtTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTerm.Location = new System.Drawing.Point(76, 69);
            this.txtTerm.Margin = new System.Windows.Forms.Padding(2);
            this.txtTerm.Multiline = true;
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(294, 31);
            this.txtTerm.TabIndex = 2;
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(76, 121);
            this.txtType.Margin = new System.Windows.Forms.Padding(2);
            this.txtType.Multiline = true;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(294, 35);
            this.txtType.TabIndex = 3;
            // 
            // txtExamples
            // 
            this.txtExamples.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExamples.Location = new System.Drawing.Point(76, 256);
            this.txtExamples.Margin = new System.Windows.Forms.Padding(2);
            this.txtExamples.Multiline = true;
            this.txtExamples.Name = "txtExamples";
            this.txtExamples.Size = new System.Drawing.Size(294, 70);
            this.txtExamples.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Từ cần tìm kiếm :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Từ  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 135);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Loại từ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 202);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nghĩa  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 293);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ví dụ :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::tudien11.Properties.Resources.sach;
            this.pictureBox1.Location = new System.Drawing.Point(36, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(514, 65);
            this.btnADD.Margin = new System.Windows.Forms.Padding(2);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(89, 31);
            this.btnADD.TabIndex = 16;
            this.btnADD.Text = "THÊM TỪ";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 351);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExamples);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.btnEXIT);
            this.Controls.Add(this.btnEDIT);
            this.Controls.Add(this.txtMeanings);
            this.Controls.Add(this.txtSearchTerm);
            this.Controls.Add(this.btnDELETE);
            this.Controls.Add(this.btnSEARCH);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSEARCH;
        private System.Windows.Forms.Button btnDELETE;
        private System.Windows.Forms.TextBox txtSearchTerm;
        private System.Windows.Forms.TextBox txtMeanings;
        private System.Windows.Forms.Button btnEDIT;
        private System.Windows.Forms.Button btnEXIT;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtExamples;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnADD;
    }
}

