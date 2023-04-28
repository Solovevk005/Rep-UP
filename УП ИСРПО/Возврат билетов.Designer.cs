namespace УП_ИСРПО
{
    partial class Возврат_билетов
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
            this.txtProdaj = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbilet_1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCenna = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPassaj = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdatevoz = new System.Windows.Forms.TextBox();
            this.btnVozvr = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtProdaj
            // 
            this.txtProdaj.Location = new System.Drawing.Point(197, 30);
            this.txtProdaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProdaj.Name = "txtProdaj";
            this.txtProdaj.Size = new System.Drawing.Size(206, 27);
            this.txtProdaj.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Проданный билет:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "№Билета";
            // 
            // txtbilet_1
            // 
            this.txtbilet_1.Location = new System.Drawing.Point(197, 81);
            this.txtbilet_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtbilet_1.Name = "txtbilet_1";
            this.txtbilet_1.Size = new System.Drawing.Size(206, 27);
            this.txtbilet_1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Цена:";
            // 
            // txtCenna
            // 
            this.txtCenna.Location = new System.Drawing.Point(197, 131);
            this.txtCenna.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCenna.Name = "txtCenna";
            this.txtCenna.Size = new System.Drawing.Size(206, 27);
            this.txtCenna.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Пассажир:";
            // 
            // txtPassaj
            // 
            this.txtPassaj.Location = new System.Drawing.Point(197, 187);
            this.txtPassaj.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassaj.Name = "txtPassaj";
            this.txtPassaj.Size = new System.Drawing.Size(206, 27);
            this.txtPassaj.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Дата возврата:";
            // 
            // txtdatevoz
            // 
            this.txtdatevoz.Location = new System.Drawing.Point(197, 238);
            this.txtdatevoz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdatevoz.Name = "txtdatevoz";
            this.txtdatevoz.Size = new System.Drawing.Size(206, 27);
            this.txtdatevoz.TabIndex = 8;
            // 
            // btnVozvr
            // 
            this.btnVozvr.Location = new System.Drawing.Point(218, 298);
            this.btnVozvr.Name = "btnVozvr";
            this.btnVozvr.Size = new System.Drawing.Size(142, 37);
            this.btnVozvr.TabIndex = 10;
            this.btnVozvr.Text = "Возврат";
            this.btnVozvr.UseVisualStyleBackColor = true;
            this.btnVozvr.Click += new System.EventHandler(this.btnVozvr_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(52, 298);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(142, 37);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Назад";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Возврат_билетов
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(446, 373);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnVozvr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdatevoz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPassaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCenna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbilet_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProdaj);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Возврат_билетов";
            this.Text = "Возврат билетов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProdaj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbilet_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCenna;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPassaj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdatevoz;
        private System.Windows.Forms.Button btnVozvr;
        private System.Windows.Forms.Button btnClose;
    }
}