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
            this.btnClose_P = new System.Windows.Forms.Button();
            this.solovevkDataSet13 = new УП_ИСРПО.SolovevkDataSet13();
            this.btnUpdate_1 = new System.Windows.Forms.Button();
            this.btnVozvr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.фамилияпассажираDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценабилетаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датавозвратаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.возвратбилетовBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.solovevkDataSet15 = new УП_ИСРПО.SolovevkDataSet15();
            this.возврат_билетовTableAdapter2 = new УП_ИСРПО.SolovevkDataSet15TableAdapters.Возврат_билетовTableAdapter();
            this.btnKup = new System.Windows.Forms.Button();
            this.продажабилетовBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.solovevkDataSet21 = new УП_ИСРПО.SolovevkDataSet21();
            this.продажа_билетовTableAdapter7 = new УП_ИСРПО.SolovevkDataSet21TableAdapters.Продажа_билетовTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.solovevkDataSet22 = new УП_ИСРПО.SolovevkDataSet22();
            this.продажабилетовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.продажа_билетовTableAdapter = new УП_ИСРПО.SolovevkDataSet22TableAdapters.Продажа_билетовTableAdapter();
            this.маршрутDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датапродажиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценабилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвобилетовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.способоплатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статуспокупкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.возвратбилетовBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажабилетовBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажабилетовBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose_P
            // 
            this.btnClose_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnClose_P.Location = new System.Drawing.Point(13, 256);
            this.btnClose_P.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClose_P.Name = "btnClose_P";
            this.btnClose_P.Size = new System.Drawing.Size(146, 29);
            this.btnClose_P.TabIndex = 1;
            this.btnClose_P.Text = "Назад";
            this.btnClose_P.UseVisualStyleBackColor = true;
            this.btnClose_P.Click += new System.EventHandler(this.btnClose_P_Click);
            // 
            // solovevkDataSet13
            // 
            this.solovevkDataSet13.DataSetName = "SolovevkDataSet13";
            this.solovevkDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnUpdate_1
            // 
            this.btnUpdate_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnUpdate_1.Location = new System.Drawing.Point(327, 256);
            this.btnUpdate_1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnUpdate_1.Name = "btnUpdate_1";
            this.btnUpdate_1.Size = new System.Drawing.Size(146, 29);
            this.btnUpdate_1.TabIndex = 7;
            this.btnUpdate_1.Text = "Сохранить";
            this.btnUpdate_1.UseVisualStyleBackColor = true;
            this.btnUpdate_1.Click += new System.EventHandler(this.btnUpdate_1_Click);
            // 
            // btnVozvr
            // 
            this.btnVozvr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnVozvr.Location = new System.Drawing.Point(481, 256);
            this.btnVozvr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVozvr.Name = "btnVozvr";
            this.btnVozvr.Size = new System.Drawing.Size(146, 29);
            this.btnVozvr.TabIndex = 8;
            this.btnVozvr.Text = "Возвратить билет";
            this.btnVozvr.UseVisualStyleBackColor = true;
            this.btnVozvr.Click += new System.EventHandler(this.btnVozvr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Билеты_на продажу";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(509, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Билеты на возврат:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.фамилияпассажираDataGridViewTextBoxColumn1,
            this.ценабилетаDataGridViewTextBoxColumn1,
            this.датавозвратаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.возвратбилетовBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(512, 53);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(376, 151);
            this.dataGridView2.TabIndex = 12;
            // 
            // фамилияпассажираDataGridViewTextBoxColumn1
            // 
            this.фамилияпассажираDataGridViewTextBoxColumn1.DataPropertyName = "Фамилия_пассажира";
            this.фамилияпассажираDataGridViewTextBoxColumn1.HeaderText = "Фамилия_пассажира";
            this.фамилияпассажираDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.фамилияпассажираDataGridViewTextBoxColumn1.Name = "фамилияпассажираDataGridViewTextBoxColumn1";
            this.фамилияпассажираDataGridViewTextBoxColumn1.Width = 125;
            // 
            // ценабилетаDataGridViewTextBoxColumn1
            // 
            this.ценабилетаDataGridViewTextBoxColumn1.DataPropertyName = "Цена_билета";
            this.ценабилетаDataGridViewTextBoxColumn1.HeaderText = "Цена_билета";
            this.ценабилетаDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.ценабилетаDataGridViewTextBoxColumn1.Name = "ценабилетаDataGridViewTextBoxColumn1";
            this.ценабилетаDataGridViewTextBoxColumn1.Width = 125;
            // 
            // датавозвратаDataGridViewTextBoxColumn
            // 
            this.датавозвратаDataGridViewTextBoxColumn.DataPropertyName = "Дата_возврата";
            this.датавозвратаDataGridViewTextBoxColumn.HeaderText = "Дата_возврата";
            this.датавозвратаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датавозвратаDataGridViewTextBoxColumn.Name = "датавозвратаDataGridViewTextBoxColumn";
            this.датавозвратаDataGridViewTextBoxColumn.Width = 125;
            // 
            // возвратбилетовBindingSource2
            // 
            this.возвратбилетовBindingSource2.DataMember = "Возврат_билетов";
            this.возвратбилетовBindingSource2.DataSource = this.solovevkDataSet15;
            // 
            // solovevkDataSet15
            // 
            this.solovevkDataSet15.DataSetName = "SolovevkDataSet15";
            this.solovevkDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // возврат_билетовTableAdapter2
            // 
            this.возврат_билетовTableAdapter2.ClearBeforeFill = true;
            // 
            // btnKup
            // 
            this.btnKup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnKup.Location = new System.Drawing.Point(170, 256);
            this.btnKup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnKup.Name = "btnKup";
            this.btnKup.Size = new System.Drawing.Size(146, 29);
            this.btnKup.TabIndex = 14;
            this.btnKup.Text = "Купить";
            this.btnKup.UseVisualStyleBackColor = true;
            this.btnKup.Click += new System.EventHandler(this.btnKup_Click);
            // 
            // продажабилетовBindingSource7
            // 
            this.продажабилетовBindingSource7.DataMember = "Продажа_билетов";
            this.продажабилетовBindingSource7.DataSource = this.solovevkDataSet21;
            // 
            // solovevkDataSet21
            // 
            this.solovevkDataSet21.DataSetName = "SolovevkDataSet21";
            this.solovevkDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // продажа_билетовTableAdapter7
            // 
            this.продажа_билетовTableAdapter7.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(170, 210);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(438, 26);
            this.textBox1.TabIndex = 16;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(15, 208);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.маршрутDataGridViewTextBoxColumn,
            this.датапродажиDataGridViewTextBoxColumn,
            this.ценабилетаDataGridViewTextBoxColumn,
            this.колвобилетовDataGridViewTextBoxColumn,
            this.способоплатыDataGridViewTextBoxColumn,
            this.статуспокупкиDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.продажабилетовBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(15, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(491, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // solovevkDataSet22
            // 
            this.solovevkDataSet22.DataSetName = "SolovevkDataSet22";
            this.solovevkDataSet22.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // продажабилетовBindingSource
            // 
            this.продажабилетовBindingSource.DataMember = "Продажа_билетов";
            this.продажабилетовBindingSource.DataSource = this.solovevkDataSet22;
            // 
            // продажа_билетовTableAdapter
            // 
            this.продажа_билетовTableAdapter.ClearBeforeFill = true;
            // 
            // маршрутDataGridViewTextBoxColumn
            // 
            this.маршрутDataGridViewTextBoxColumn.DataPropertyName = "Маршрут";
            this.маршрутDataGridViewTextBoxColumn.HeaderText = "Маршрут";
            this.маршрутDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.маршрутDataGridViewTextBoxColumn.Name = "маршрутDataGridViewTextBoxColumn";
            this.маршрутDataGridViewTextBoxColumn.Width = 125;
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
            // колвобилетовDataGridViewTextBoxColumn
            // 
            this.колвобилетовDataGridViewTextBoxColumn.DataPropertyName = "Колво_билетов";
            this.колвобилетовDataGridViewTextBoxColumn.HeaderText = "Колво_билетов";
            this.колвобилетовDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.колвобилетовDataGridViewTextBoxColumn.Name = "колвобилетовDataGridViewTextBoxColumn";
            this.колвобилетовDataGridViewTextBoxColumn.Width = 125;
            // 
            // способоплатыDataGridViewTextBoxColumn
            // 
            this.способоплатыDataGridViewTextBoxColumn.DataPropertyName = "Способ_оплаты";
            this.способоплатыDataGridViewTextBoxColumn.HeaderText = "Способ_оплаты";
            this.способоплатыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.способоплатыDataGridViewTextBoxColumn.Name = "способоплатыDataGridViewTextBoxColumn";
            this.способоплатыDataGridViewTextBoxColumn.Width = 125;
            // 
            // статуспокупкиDataGridViewTextBoxColumn
            // 
            this.статуспокупкиDataGridViewTextBoxColumn.DataPropertyName = "Статус_покупки";
            this.статуспокупкиDataGridViewTextBoxColumn.HeaderText = "Статус_покупки";
            this.статуспокупкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.статуспокупкиDataGridViewTextBoxColumn.Name = "статуспокупкиDataGridViewTextBoxColumn";
            this.статуспокупкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(902, 323);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnKup);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVozvr);
            this.Controls.Add(this.btnUpdate_1);
            this.Controls.Add(this.btnClose_P);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form4";
            this.Text = "Проданные билеты";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.возвратбилетовBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажабилетовBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.продажабилетовBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose_P;
        private SolovevkDataSet13 solovevkDataSet13;
        private System.Windows.Forms.Button btnUpdate_1;
        private System.Windows.Forms.Button btnVozvr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private SolovevkDataSet15 solovevkDataSet15;
        private System.Windows.Forms.BindingSource возвратбилетовBindingSource2;
        private SolovevkDataSet15TableAdapters.Возврат_билетовTableAdapter возврат_билетовTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияпассажираDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценабилетаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датавозвратаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnKup;
        private SolovevkDataSet21 solovevkDataSet21;
        private System.Windows.Forms.BindingSource продажабилетовBindingSource7;
        private SolovevkDataSet21TableAdapters.Продажа_билетовTableAdapter продажа_билетовTableAdapter7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SolovevkDataSet22 solovevkDataSet22;
        private System.Windows.Forms.BindingSource продажабилетовBindingSource;
        private SolovevkDataSet22TableAdapters.Продажа_билетовTableAdapter продажа_билетовTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn маршрутDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датапродажиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценабилетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвобилетовDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn способоплатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статуспокупкиDataGridViewTextBoxColumn;
    }
}