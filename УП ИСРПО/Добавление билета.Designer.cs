﻿namespace УП_ИСРПО
{
    partial class Form5
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
            this.возвратБилетовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.solovevkDataSet2 = new УП_ИСРПО.SolovevkDataSet2();
            this.возврат_билетовTableAdapter = new УП_ИСРПО.SolovevkDataSet2TableAdapters.Возврат_билетовTableAdapter();
            this.btnClose_V = new System.Windows.Forms.Button();
            this.возвратБилетовBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.solovevkDataSet10 = new УП_ИСРПО.SolovevkDataSet10();
            this.возврат_билетовTableAdapter1 = new УП_ИСРПО.SolovevkDataSet10TableAdapters.Возврат_билетовTableAdapter();
            this.txtbilet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdateP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnDobav = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.возвратБилетовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.возвратБилетовBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet10)).BeginInit();
            this.SuspendLayout();
            // 
            // возвратБилетовBindingSource
            // 
            this.возвратБилетовBindingSource.DataMember = "Возврат билетов";
            this.возвратБилетовBindingSource.DataSource = this.solovevkDataSet2;
            // 
            // solovevkDataSet2
            // 
            this.solovevkDataSet2.DataSetName = "SolovevkDataSet2";
            this.solovevkDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // возврат_билетовTableAdapter
            // 
            this.возврат_билетовTableAdapter.ClearBeforeFill = true;
            // 
            // btnClose_V
            // 
            this.btnClose_V.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnClose_V.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose_V.Location = new System.Drawing.Point(69, 358);
            this.btnClose_V.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose_V.Name = "btnClose_V";
            this.btnClose_V.Size = new System.Drawing.Size(140, 44);
            this.btnClose_V.TabIndex = 1;
            this.btnClose_V.Text = "Назад";
            this.btnClose_V.UseVisualStyleBackColor = true;
            this.btnClose_V.Click += new System.EventHandler(this.btnClose_V_Click);
            // 
            // возвратБилетовBindingSource1
            // 
            this.возвратБилетовBindingSource1.DataMember = "Возврат билетов";
            this.возвратБилетовBindingSource1.DataSource = this.solovevkDataSet10;
            // 
            // solovevkDataSet10
            // 
            this.solovevkDataSet10.DataSetName = "SolovevkDataSet10";
            this.solovevkDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // возврат_билетовTableAdapter1
            // 
            this.возврат_билетовTableAdapter1.ClearBeforeFill = true;
            // 
            // txtbilet
            // 
            this.txtbilet.Location = new System.Drawing.Point(221, 70);
            this.txtbilet.Name = "txtbilet";
            this.txtbilet.Size = new System.Drawing.Size(210, 24);
            this.txtbilet.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Билет:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пассажир:";
            // 
            // txtPas
            // 
            this.txtPas.Location = new System.Drawing.Point(221, 117);
            this.txtPas.Name = "txtPas";
            this.txtPas.Size = new System.Drawing.Size(210, 24);
            this.txtPas.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата продажи:";
            // 
            // txtdateP
            // 
            this.txtdateP.Location = new System.Drawing.Point(221, 207);
            this.txtdateP.Name = "txtdateP";
            this.txtdateP.Size = new System.Drawing.Size(210, 24);
            this.txtdateP.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Цена билета:";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(221, 258);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(210, 24);
            this.txtCena.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Способ оплаты:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Карта",
            "Наличные"});
            this.comboBox1.Location = new System.Drawing.Point(221, 308);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 26);
            this.comboBox1.TabIndex = 12;
            // 
            // btnDobav
            // 
            this.btnDobav.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDobav.Location = new System.Drawing.Point(253, 358);
            this.btnDobav.Margin = new System.Windows.Forms.Padding(4);
            this.btnDobav.Name = "btnDobav";
            this.btnDobav.Size = new System.Drawing.Size(140, 44);
            this.btnDobav.TabIndex = 13;
            this.btnDobav.Text = "Добавить";
            this.btnDobav.UseVisualStyleBackColor = true;
            this.btnDobav.Click += new System.EventHandler(this.btnDobav_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(167, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Продажа билета:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 18);
            this.label7.TabIndex = 16;
            this.label7.Text = "Фамилия пассажира:";
            // 
            // txtFio
            // 
            this.txtFio.Location = new System.Drawing.Point(221, 162);
            this.txtFio.Name = "txtFio";
            this.txtFio.Size = new System.Drawing.Size(210, 24);
            this.txtFio.TabIndex = 15;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(478, 431);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnDobav);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtdateP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbilet);
            this.Controls.Add(this.btnClose_V);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form5";
            this.Text = "Купить билет";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.возвратБилетовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.возвратБилетовBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private SolovevkDataSet2 solovevkDataSet2;
        private System.Windows.Forms.BindingSource возвратБилетовBindingSource;
        private SolovevkDataSet2TableAdapters.Возврат_билетовTableAdapter возврат_билетовTableAdapter;
        private System.Windows.Forms.Button btnClose_V;
        private SolovevkDataSet10 solovevkDataSet10;
        private System.Windows.Forms.BindingSource возвратБилетовBindingSource1;
        private SolovevkDataSet10TableAdapters.Возврат_билетовTableAdapter возврат_билетовTableAdapter1;
        private System.Windows.Forms.TextBox txtbilet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdateP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnDobav;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFio;
    }
}