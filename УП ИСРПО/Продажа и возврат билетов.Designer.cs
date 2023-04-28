namespace УП_ИСРПО
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
            this.продажаБилетовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.solovevkDataSet1 = new УП_ИСРПО.SolovevkDataSet1();
            this.продажа_билетовTableAdapter = new УП_ИСРПО.SolovevkDataSet1TableAdapters.Продажа_билетовTableAdapter();
            this.btnClose_P = new System.Windows.Forms.Button();
            this.продажаБилетовBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.solovevkDataSet9 = new УП_ИСРПО.SolovevkDataSet9();
            this.продажа_билетовTableAdapter1 = new УП_ИСРПО.SolovevkDataSet9TableAdapters.Продажа_билетовTableAdapter();
            this.возвратБилетовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.solovevkDataSet11 = new УП_ИСРПО.SolovevkDataSet11();
            this.возврат_билетовTableAdapter = new УП_ИСРПО.SolovevkDataSet11TableAdapters.Возврат_билетовTableAdapter();
            this.btnKupit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодпродажиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодбилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодпассажираDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датапродажиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценабилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.способоплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.продажабилетовBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.solovevkDataSet12 = new УП_ИСРПО.SolovevkDataSet12();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодвозвратаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодпродажиDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодбилетаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценабилетаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодпассажираDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датавозвратаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.возвратбилетовBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.solovevkDataSet13 = new УП_ИСРПО.SolovevkDataSet13();
            this.продажа_билетовTableAdapter2 = new УП_ИСРПО.SolovevkDataSet12TableAdapters.Продажа_билетовTableAdapter();
            this.возврат_билетовTableAdapter1 = new УП_ИСРПО.SolovevkDataSet13TableAdapters.Возврат_билетовTableAdapter();
            this.btnUpdate_1 = new System.Windows.Forms.Button();
            this.btnVozvr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.продажаБилетовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажаБилетовBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.возвратБилетовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажабилетовBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.возвратбилетовBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet13)).BeginInit();
            this.SuspendLayout();
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
            // btnClose_P
            // 
            this.btnClose_P.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose_P.Location = new System.Drawing.Point(13, 377);
            this.btnClose_P.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose_P.Name = "btnClose_P";
            this.btnClose_P.Size = new System.Drawing.Size(149, 44);
            this.btnClose_P.TabIndex = 1;
            this.btnClose_P.Text = "Назад";
            this.btnClose_P.UseVisualStyleBackColor = true;
            this.btnClose_P.Click += new System.EventHandler(this.btnClose_P_Click);
            // 
            // продажаБилетовBindingSource1
            // 
            this.продажаБилетовBindingSource1.DataMember = "Продажа билетов";
            this.продажаБилетовBindingSource1.DataSource = this.solovevkDataSet9;
            // 
            // solovevkDataSet9
            // 
            this.solovevkDataSet9.DataSetName = "SolovevkDataSet9";
            this.solovevkDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // продажа_билетовTableAdapter1
            // 
            this.продажа_билетовTableAdapter1.ClearBeforeFill = true;
            // 
            // возвратБилетовBindingSource
            // 
            this.возвратБилетовBindingSource.DataMember = "Возврат билетов";
            this.возвратБилетовBindingSource.DataSource = this.solovevkDataSet11;
            // 
            // solovevkDataSet11
            // 
            this.solovevkDataSet11.DataSetName = "SolovevkDataSet11";
            this.solovevkDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // возврат_билетовTableAdapter
            // 
            this.возврат_билетовTableAdapter.ClearBeforeFill = true;
            // 
            // btnKupit
            // 
            this.btnKupit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnKupit.Location = new System.Drawing.Point(13, 272);
            this.btnKupit.Margin = new System.Windows.Forms.Padding(4);
            this.btnKupit.Name = "btnKupit";
            this.btnKupit.Size = new System.Drawing.Size(149, 44);
            this.btnKupit.TabIndex = 4;
            this.btnKupit.Text = "Купить билет";
            this.btnKupit.UseVisualStyleBackColor = true;
            this.btnKupit.Click += new System.EventHandler(this.btnKupit_Click);
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
            this.ценабилетаDataGridViewTextBoxColumn,
            this.способоплатыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.продажабилетовBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(463, 228);
            this.dataGridView1.TabIndex = 5;
            // 
            // кодпродажиDataGridViewTextBoxColumn
            // 
            this.кодпродажиDataGridViewTextBoxColumn.DataPropertyName = "Код_продажи";
            this.кодпродажиDataGridViewTextBoxColumn.HeaderText = "Код_продажи";
            this.кодпродажиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодпродажиDataGridViewTextBoxColumn.Name = "кодпродажиDataGridViewTextBoxColumn";
            this.кодпродажиDataGridViewTextBoxColumn.ReadOnly = true;
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
            // ценабилетаDataGridViewTextBoxColumn
            // 
            this.ценабилетаDataGridViewTextBoxColumn.DataPropertyName = "Цена_билета";
            this.ценабилетаDataGridViewTextBoxColumn.HeaderText = "Цена_билета";
            this.ценабилетаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценабилетаDataGridViewTextBoxColumn.Name = "ценабилетаDataGridViewTextBoxColumn";
            this.ценабилетаDataGridViewTextBoxColumn.Width = 125;
            // 
            // способоплатыDataGridViewTextBoxColumn
            // 
            this.способоплатыDataGridViewTextBoxColumn.DataPropertyName = "Способ_оплаты";
            this.способоплатыDataGridViewTextBoxColumn.HeaderText = "Способ_оплаты";
            this.способоплатыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.способоплатыDataGridViewTextBoxColumn.Name = "способоплатыDataGridViewTextBoxColumn";
            this.способоплатыDataGridViewTextBoxColumn.Width = 125;
            // 
            // продажабилетовBindingSource2
            // 
            this.продажабилетовBindingSource2.DataMember = "Продажа_билетов";
            this.продажабилетовBindingSource2.DataSource = this.solovevkDataSet12;
            // 
            // solovevkDataSet12
            // 
            this.solovevkDataSet12.DataSetName = "SolovevkDataSet12";
            this.solovevkDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодвозвратаDataGridViewTextBoxColumn,
            this.кодпродажиDataGridViewTextBoxColumn1,
            this.кодбилетаDataGridViewTextBoxColumn1,
            this.ценабилетаDataGridViewTextBoxColumn1,
            this.кодпассажираDataGridViewTextBoxColumn1,
            this.датавозвратаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.возвратбилетовBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(492, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(463, 228);
            this.dataGridView2.TabIndex = 6;
            // 
            // кодвозвратаDataGridViewTextBoxColumn
            // 
            this.кодвозвратаDataGridViewTextBoxColumn.DataPropertyName = "Код_возврата";
            this.кодвозвратаDataGridViewTextBoxColumn.HeaderText = "Код_возврата";
            this.кодвозвратаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодвозвратаDataGridViewTextBoxColumn.Name = "кодвозвратаDataGridViewTextBoxColumn";
            this.кодвозвратаDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодпродажиDataGridViewTextBoxColumn1
            // 
            this.кодпродажиDataGridViewTextBoxColumn1.DataPropertyName = "Код_продажи";
            this.кодпродажиDataGridViewTextBoxColumn1.HeaderText = "Код_продажи";
            this.кодпродажиDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.кодпродажиDataGridViewTextBoxColumn1.Name = "кодпродажиDataGridViewTextBoxColumn1";
            this.кодпродажиDataGridViewTextBoxColumn1.Width = 125;
            // 
            // кодбилетаDataGridViewTextBoxColumn1
            // 
            this.кодбилетаDataGridViewTextBoxColumn1.DataPropertyName = "Код_билета";
            this.кодбилетаDataGridViewTextBoxColumn1.HeaderText = "Код_билета";
            this.кодбилетаDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.кодбилетаDataGridViewTextBoxColumn1.Name = "кодбилетаDataGridViewTextBoxColumn1";
            this.кодбилетаDataGridViewTextBoxColumn1.Width = 125;
            // 
            // ценабилетаDataGridViewTextBoxColumn1
            // 
            this.ценабилетаDataGridViewTextBoxColumn1.DataPropertyName = "Цена_билета";
            this.ценабилетаDataGridViewTextBoxColumn1.HeaderText = "Цена_билета";
            this.ценабилетаDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ценабилетаDataGridViewTextBoxColumn1.Name = "ценабилетаDataGridViewTextBoxColumn1";
            this.ценабилетаDataGridViewTextBoxColumn1.Width = 125;
            // 
            // кодпассажираDataGridViewTextBoxColumn1
            // 
            this.кодпассажираDataGridViewTextBoxColumn1.DataPropertyName = "Код_пассажира";
            this.кодпассажираDataGridViewTextBoxColumn1.HeaderText = "Код_пассажира";
            this.кодпассажираDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.кодпассажираDataGridViewTextBoxColumn1.Name = "кодпассажираDataGridViewTextBoxColumn1";
            this.кодпассажираDataGridViewTextBoxColumn1.Width = 125;
            // 
            // датавозвратаDataGridViewTextBoxColumn
            // 
            this.датавозвратаDataGridViewTextBoxColumn.DataPropertyName = "Дата_возврата";
            this.датавозвратаDataGridViewTextBoxColumn.HeaderText = "Дата_возврата";
            this.датавозвратаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датавозвратаDataGridViewTextBoxColumn.Name = "датавозвратаDataGridViewTextBoxColumn";
            this.датавозвратаDataGridViewTextBoxColumn.Width = 125;
            // 
            // возвратбилетовBindingSource1
            // 
            this.возвратбилетовBindingSource1.DataMember = "Возврат_билетов";
            this.возвратбилетовBindingSource1.DataSource = this.solovevkDataSet13;
            // 
            // solovevkDataSet13
            // 
            this.solovevkDataSet13.DataSetName = "SolovevkDataSet13";
            this.solovevkDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // продажа_билетовTableAdapter2
            // 
            this.продажа_билетовTableAdapter2.ClearBeforeFill = true;
            // 
            // возврат_билетовTableAdapter1
            // 
            this.возврат_билетовTableAdapter1.ClearBeforeFill = true;
            // 
            // btnUpdate_1
            // 
            this.btnUpdate_1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUpdate_1.Location = new System.Drawing.Point(327, 272);
            this.btnUpdate_1.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate_1.Name = "btnUpdate_1";
            this.btnUpdate_1.Size = new System.Drawing.Size(149, 44);
            this.btnUpdate_1.TabIndex = 7;
            this.btnUpdate_1.Text = "Сохранить";
            this.btnUpdate_1.UseVisualStyleBackColor = true;
            this.btnUpdate_1.Click += new System.EventHandler(this.btnUpdate_1_Click);
            // 
            // btnVozvr
            // 
            this.btnVozvr.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVozvr.Location = new System.Drawing.Point(170, 272);
            this.btnVozvr.Margin = new System.Windows.Forms.Padding(4);
            this.btnVozvr.Name = "btnVozvr";
            this.btnVozvr.Size = new System.Drawing.Size(149, 44);
            this.btnVozvr.TabIndex = 8;
            this.btnVozvr.Text = "Возвратить билет";
            this.btnVozvr.UseVisualStyleBackColor = true;
            this.btnVozvr.Click += new System.EventHandler(this.btnVozvr_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(965, 461);
            this.Controls.Add(this.btnVozvr);
            this.Controls.Add(this.btnUpdate_1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKupit);
            this.Controls.Add(this.btnClose_P);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.Text = "Проданные билеты";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.продажаБилетовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажаБилетовBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.возвратБилетовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажабилетовBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.возвратбилетовBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet13)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private SolovevkDataSet1 solovevkDataSet1;
        private System.Windows.Forms.BindingSource продажаБилетовBindingSource;
        private SolovevkDataSet1TableAdapters.Продажа_билетовTableAdapter продажа_билетовTableAdapter;
        private System.Windows.Forms.Button btnClose_P;
        private SolovevkDataSet9 solovevkDataSet9;
        private System.Windows.Forms.BindingSource продажаБилетовBindingSource1;
        private SolovevkDataSet9TableAdapters.Продажа_билетовTableAdapter продажа_билетовTableAdapter1;
        private SolovevkDataSet11 solovevkDataSet11;
        private System.Windows.Forms.BindingSource возвратБилетовBindingSource;
        private SolovevkDataSet11TableAdapters.Возврат_билетовTableAdapter возврат_билетовTableAdapter;
        private System.Windows.Forms.Button btnKupit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private SolovevkDataSet12 solovevkDataSet12;
        private System.Windows.Forms.BindingSource продажабилетовBindingSource2;
        private SolovevkDataSet12TableAdapters.Продажа_билетовTableAdapter продажа_билетовTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпродажиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодбилетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпассажираDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датапродажиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценабилетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn способоплатыDataGridViewTextBoxColumn;
        private SolovevkDataSet13 solovevkDataSet13;
        private System.Windows.Forms.BindingSource возвратбилетовBindingSource1;
        private SolovevkDataSet13TableAdapters.Возврат_билетовTableAdapter возврат_билетовTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодвозвратаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпродажиDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодбилетаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценабилетаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпассажираDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датавозвратаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnUpdate_1;
        private System.Windows.Forms.Button btnVozvr;
    }
}