﻿namespace УП_ИСРПО
{
    partial class Регистрация
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
            this.txtLogin_R = new System.Windows.Forms.TextBox();
            this.txtPassword_R = new System.Windows.Forms.TextBox();
            this.txtPodver = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.BtnClose_R = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(184, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "РЕГИСТРАЦИЯ ПОЛЬЗОВАТЕЛЯ";
            // 
            // txtLogin_R
            // 
            this.txtLogin_R.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLogin_R.Location = new System.Drawing.Point(247, 105);
            this.txtLogin_R.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLogin_R.Name = "txtLogin_R";
            this.txtLogin_R.Size = new System.Drawing.Size(229, 27);
            this.txtLogin_R.TabIndex = 1;
            // 
            // txtPassword_R
            // 
            this.txtPassword_R.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtPassword_R.Location = new System.Drawing.Point(247, 159);
            this.txtPassword_R.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword_R.Name = "txtPassword_R";
            this.txtPassword_R.Size = new System.Drawing.Size(229, 24);
            this.txtPassword_R.TabIndex = 2;
            // 
            // txtPodver
            // 
            this.txtPodver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtPodver.Location = new System.Drawing.Point(247, 209);
            this.txtPodver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPodver.Name = "txtPodver";
            this.txtPodver.Size = new System.Drawing.Size(229, 24);
            this.txtPodver.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(131, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Логин:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(131, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Пароль:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(131, 213);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Подвердите:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnClear.Location = new System.Drawing.Point(126, 312);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(167, 36);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnReg
            // 
            this.btnReg.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnReg.Location = new System.Drawing.Point(301, 312);
            this.btnReg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(167, 36);
            this.btnReg.TabIndex = 8;
            this.btnReg.Text = "Зарегистрировать";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // BtnClose_R
            // 
            this.BtnClose_R.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnClose_R.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.BtnClose_R.Location = new System.Drawing.Point(126, 354);
            this.BtnClose_R.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnClose_R.Name = "BtnClose_R";
            this.BtnClose_R.Size = new System.Drawing.Size(167, 33);
            this.BtnClose_R.TabIndex = 9;
            this.BtnClose_R.Text = "Назад";
            this.BtnClose_R.UseVisualStyleBackColor = true;
            this.BtnClose_R.UseWaitCursor = true;
            this.BtnClose_R.Click += new System.EventHandler(this.BtnClose_R_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(131, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Роль:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtRole
            // 
            this.txtRole.FormattingEnabled = true;
            this.txtRole.Items.AddRange(new object[] {
            "Администратор",
            "Пассажир"});
            this.txtRole.Location = new System.Drawing.Point(247, 258);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(229, 26);
            this.txtRole.TabIndex = 12;
            // 
            // Регистрация
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(643, 499);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnClose_R);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPodver);
            this.Controls.Add(this.txtPassword_R);
            this.Controls.Add(this.txtLogin_R);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Регистрация";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLogin_R;
        private System.Windows.Forms.TextBox txtPassword_R;
        private System.Windows.Forms.TextBox txtPodver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button BtnClose_R;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox txtRole;
    }
}