﻿namespace УП_ИСРПО
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодпродажиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодбилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодпассажираDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датапродажиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.способоплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продажаБилетовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.solovevkDataSet1 = new УП_ИСРПО.SolovevkDataSet1();
            this.продажа_билетовTableAdapter = new УП_ИСРПО.SolovevkDataSet1TableAdapters.Продажа_билетовTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажаБилетовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодпродажиDataGridViewTextBoxColumn,
            this.кодбилетаDataGridViewTextBoxColumn,
            this.кодпассажираDataGridViewTextBoxColumn,
            this.датапродажиDataGridViewTextBoxColumn,
            this.способоплатыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.продажаБилетовBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(46, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(677, 181);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодпродажиDataGridViewTextBoxColumn
            // 
            this.кодпродажиDataGridViewTextBoxColumn.DataPropertyName = "Код_продажи";
            this.кодпродажиDataGridViewTextBoxColumn.HeaderText = "Код_продажи";
            this.кодпродажиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодпродажиDataGridViewTextBoxColumn.Name = "кодпродажиDataGridViewTextBoxColumn";
            this.кодпродажиDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодбилетаDataGridViewTextBoxColumn
            // 
            this.кодбилетаDataGridViewTextBoxColumn.DataPropertyName = "Код_билета";
            this.кодбилетаDataGridViewTextBoxColumn.HeaderText = "Код_билета";
            this.кодбилетаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодбилетаDataGridViewTextBoxColumn.Name = "кодбилетаDataGridViewTextBoxColumn";
            this.кодбилетаDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодпассажираDataGridViewTextBoxColumn
            // 
            this.кодпассажираDataGridViewTextBoxColumn.DataPropertyName = "Код_пассажира";
            this.кодпассажираDataGridViewTextBoxColumn.HeaderText = "Код_пассажира";
            this.кодпассажираDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодпассажираDataGridViewTextBoxColumn.Name = "кодпассажираDataGridViewTextBoxColumn";
            this.кодпассажираDataGridViewTextBoxColumn.Width = 125;
            // 
            // датапродажиDataGridViewTextBoxColumn
            // 
            this.датапродажиDataGridViewTextBoxColumn.DataPropertyName = "Дата_продажи";
            this.датапродажиDataGridViewTextBoxColumn.HeaderText = "Дата_продажи";
            this.датапродажиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датапродажиDataGridViewTextBoxColumn.Name = "датапродажиDataGridViewTextBoxColumn";
            this.датапродажиDataGridViewTextBoxColumn.Width = 125;
            // 
            // способоплатыDataGridViewTextBoxColumn
            // 
            this.способоплатыDataGridViewTextBoxColumn.DataPropertyName = "Способ_оплаты";
            this.способоплатыDataGridViewTextBoxColumn.HeaderText = "Способ_оплаты";
            this.способоплатыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.способоплатыDataGridViewTextBoxColumn.Name = "способоплатыDataGridViewTextBoxColumn";
            this.способоплатыDataGridViewTextBoxColumn.Width = 125;
            // 
            // продажаБилетовBindingSource
            // 
            this.продажаБилетовBindingSource.DataMember = "Продажа билетов";
            this.продажаБилетовBindingSource.DataSource = this.solovevkDataSet1;
            // 
            // solovevkDataSet1
            // 
            this.solovevkDataSet1.DataSetName = "SolovevkDataSet1";
            this.solovevkDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // продажа_билетовTableAdapter
            // 
            this.продажа_билетовTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(46, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Проданные билеты";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажаБилетовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SolovevkDataSet1 solovevkDataSet1;
        private System.Windows.Forms.BindingSource продажаБилетовBindingSource;
        private SolovevkDataSet1TableAdapters.Продажа_билетовTableAdapter продажа_билетовTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпродажиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодбилетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпассажираDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датапродажиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn способоплатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}