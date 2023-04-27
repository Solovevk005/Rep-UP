namespace УП_ИСРПО
{
    partial class Form3
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
            this.btnProd = new System.Windows.Forms.Button();
            this.btnVoz = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодрасписанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодпоездаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодмаршрутаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пунктотправлениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пунктприбытияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.станцияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.регионDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаотправлениеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаприбытияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расписаниеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.solovevkDataSet3 = new УП_ИСРПО.SolovevkDataSet3();
            this.расписаниеTableAdapter = new УП_ИСРПО.SolovevkDataSet3TableAdapters.РасписаниеTableAdapter();
            this.txtPoisk = new System.Windows.Forms.TextBox();
            this.btnPoisk_1 = new System.Windows.Forms.Button();
            this.btnFiltr_1 = new System.Windows.Forms.Button();
            this.txtFiltr = new System.Windows.Forms.TextBox();
            this.btnDelete_1 = new System.Windows.Forms.Button();
            this.btnDobovlenie = new System.Windows.Forms.Button();
            this.маршрутыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.solovevkDataSet5 = new УП_ИСРПО.SolovevkDataSet5();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.кодмаршрутаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодпоездаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пунктотправлениеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.пунктприбытияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаотправлениеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.станцияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.маршрутыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.solovevkDataSet6 = new УП_ИСРПО.SolovevkDataSet6();
            this.маршрутыTableAdapter = new УП_ИСРПО.SolovevkDataSet6TableAdapters.МаршрутыTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFiltr = new System.Windows.Forms.Button();
            this.txtFiltr_1 = new System.Windows.Forms.TextBox();
            this.btnPoisk = new System.Windows.Forms.Button();
            this.txtPoisk_1 = new System.Windows.Forms.TextBox();
            this.btnSave_1 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnDobovlenie_1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProd
            // 
            this.btnProd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnProd.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProd.Location = new System.Drawing.Point(13, 389);
            this.btnProd.Margin = new System.Windows.Forms.Padding(4);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(147, 33);
            this.btnProd.TabIndex = 2;
            this.btnProd.Text = "Продажа";
            this.btnProd.UseVisualStyleBackColor = true;
            this.btnProd.Click += new System.EventHandler(this.btnProd_Click);
            // 
            // btnVoz
            // 
            this.btnVoz.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVoz.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVoz.Location = new System.Drawing.Point(167, 389);
            this.btnVoz.Margin = new System.Windows.Forms.Padding(4);
            this.btnVoz.Name = "btnVoz";
            this.btnVoz.Size = new System.Drawing.Size(147, 33);
            this.btnVoz.TabIndex = 3;
            this.btnVoz.Text = "Возврат билетов";
            this.btnVoz.UseVisualStyleBackColor = true;
            this.btnVoz.Click += new System.EventHandler(this.btnVoz_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодрасписанияDataGridViewTextBoxColumn,
            this.кодпоездаDataGridViewTextBoxColumn,
            this.кодмаршрутаDataGridViewTextBoxColumn,
            this.пунктотправлениеDataGridViewTextBoxColumn,
            this.пунктприбытияDataGridViewTextBoxColumn,
            this.станцияDataGridViewTextBoxColumn,
            this.регионDataGridViewTextBoxColumn,
            this.датаотправлениеDataGridViewTextBoxColumn,
            this.датаприбытияDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.расписаниеBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 62);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(742, 208);
            this.dataGridView1.TabIndex = 4;
            // 
            // кодрасписанияDataGridViewTextBoxColumn
            // 
            this.кодрасписанияDataGridViewTextBoxColumn.DataPropertyName = "Код_расписания";
            this.кодрасписанияDataGridViewTextBoxColumn.HeaderText = "Код_расписания";
            this.кодрасписанияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодрасписанияDataGridViewTextBoxColumn.Name = "кодрасписанияDataGridViewTextBoxColumn";
            this.кодрасписанияDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодпоездаDataGridViewTextBoxColumn
            // 
            this.кодпоездаDataGridViewTextBoxColumn.DataPropertyName = "Код_поезда";
            this.кодпоездаDataGridViewTextBoxColumn.HeaderText = "Код_поезда";
            this.кодпоездаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодпоездаDataGridViewTextBoxColumn.Name = "кодпоездаDataGridViewTextBoxColumn";
            this.кодпоездаDataGridViewTextBoxColumn.Width = 125;
            // 
            // кодмаршрутаDataGridViewTextBoxColumn
            // 
            this.кодмаршрутаDataGridViewTextBoxColumn.DataPropertyName = "Код_маршрута";
            this.кодмаршрутаDataGridViewTextBoxColumn.HeaderText = "Код_маршрута";
            this.кодмаршрутаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодмаршрутаDataGridViewTextBoxColumn.Name = "кодмаршрутаDataGridViewTextBoxColumn";
            this.кодмаршрутаDataGridViewTextBoxColumn.Width = 125;
            // 
            // пунктотправлениеDataGridViewTextBoxColumn
            // 
            this.пунктотправлениеDataGridViewTextBoxColumn.DataPropertyName = "Пункт_отправление";
            this.пунктотправлениеDataGridViewTextBoxColumn.HeaderText = "Пункт_отправление";
            this.пунктотправлениеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.пунктотправлениеDataGridViewTextBoxColumn.Name = "пунктотправлениеDataGridViewTextBoxColumn";
            this.пунктотправлениеDataGridViewTextBoxColumn.Width = 125;
            // 
            // пунктприбытияDataGridViewTextBoxColumn
            // 
            this.пунктприбытияDataGridViewTextBoxColumn.DataPropertyName = "Пункт_прибытия";
            this.пунктприбытияDataGridViewTextBoxColumn.HeaderText = "Пункт_прибытия";
            this.пунктприбытияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.пунктприбытияDataGridViewTextBoxColumn.Name = "пунктприбытияDataGridViewTextBoxColumn";
            this.пунктприбытияDataGridViewTextBoxColumn.Width = 125;
            // 
            // станцияDataGridViewTextBoxColumn
            // 
            this.станцияDataGridViewTextBoxColumn.DataPropertyName = "Станция";
            this.станцияDataGridViewTextBoxColumn.HeaderText = "Станция";
            this.станцияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.станцияDataGridViewTextBoxColumn.Name = "станцияDataGridViewTextBoxColumn";
            this.станцияDataGridViewTextBoxColumn.Width = 125;
            // 
            // регионDataGridViewTextBoxColumn
            // 
            this.регионDataGridViewTextBoxColumn.DataPropertyName = "Регион";
            this.регионDataGridViewTextBoxColumn.HeaderText = "Регион";
            this.регионDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.регионDataGridViewTextBoxColumn.Name = "регионDataGridViewTextBoxColumn";
            this.регионDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаотправлениеDataGridViewTextBoxColumn
            // 
            this.датаотправлениеDataGridViewTextBoxColumn.DataPropertyName = "Дата_отправление";
            this.датаотправлениеDataGridViewTextBoxColumn.HeaderText = "Дата_отправление";
            this.датаотправлениеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаотправлениеDataGridViewTextBoxColumn.Name = "датаотправлениеDataGridViewTextBoxColumn";
            this.датаотправлениеDataGridViewTextBoxColumn.Width = 125;
            // 
            // датаприбытияDataGridViewTextBoxColumn
            // 
            this.датаприбытияDataGridViewTextBoxColumn.DataPropertyName = "Дата_прибытия";
            this.датаприбытияDataGridViewTextBoxColumn.HeaderText = "Дата_прибытия";
            this.датаприбытияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаприбытияDataGridViewTextBoxColumn.Name = "датаприбытияDataGridViewTextBoxColumn";
            this.датаприбытияDataGridViewTextBoxColumn.Width = 125;
            // 
            // расписаниеBindingSource
            // 
            this.расписаниеBindingSource.DataMember = "Расписание";
            this.расписаниеBindingSource.DataSource = this.solovevkDataSet3;
            // 
            // solovevkDataSet3
            // 
            this.solovevkDataSet3.DataSetName = "SolovevkDataSet3";
            this.solovevkDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // расписаниеTableAdapter
            // 
            this.расписаниеTableAdapter.ClearBeforeFill = true;
            // 
            // txtPoisk
            // 
            this.txtPoisk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPoisk.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPoisk.Location = new System.Drawing.Point(167, 294);
            this.txtPoisk.Margin = new System.Windows.Forms.Padding(4);
            this.txtPoisk.Multiline = true;
            this.txtPoisk.Name = "txtPoisk";
            this.txtPoisk.Size = new System.Drawing.Size(257, 32);
            this.txtPoisk.TabIndex = 5;
            this.txtPoisk.TextChanged += new System.EventHandler(this.txtPoisk_TextChanged);
            // 
            // btnPoisk_1
            // 
            this.btnPoisk_1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPoisk_1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPoisk_1.Location = new System.Drawing.Point(13, 294);
            this.btnPoisk_1.Margin = new System.Windows.Forms.Padding(4);
            this.btnPoisk_1.Name = "btnPoisk_1";
            this.btnPoisk_1.Size = new System.Drawing.Size(147, 33);
            this.btnPoisk_1.TabIndex = 6;
            this.btnPoisk_1.Text = "Поиск";
            this.btnPoisk_1.UseVisualStyleBackColor = true;
            this.btnPoisk_1.Click += new System.EventHandler(this.btnPoisk_1_Click);
            // 
            // btnFiltr_1
            // 
            this.btnFiltr_1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFiltr_1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFiltr_1.Location = new System.Drawing.Point(13, 335);
            this.btnFiltr_1.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltr_1.Name = "btnFiltr_1";
            this.btnFiltr_1.Size = new System.Drawing.Size(147, 33);
            this.btnFiltr_1.TabIndex = 8;
            this.btnFiltr_1.Text = "Фильтр";
            this.btnFiltr_1.UseVisualStyleBackColor = true;
            this.btnFiltr_1.Click += new System.EventHandler(this.btnFiltr_1_Click);
            // 
            // txtFiltr
            // 
            this.txtFiltr.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtFiltr.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFiltr.Location = new System.Drawing.Point(167, 335);
            this.txtFiltr.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltr.Multiline = true;
            this.txtFiltr.Name = "txtFiltr";
            this.txtFiltr.Size = new System.Drawing.Size(257, 32);
            this.txtFiltr.TabIndex = 7;
            this.txtFiltr.TextChanged += new System.EventHandler(this.txtFiltr_TextChanged);
            // 
            // btnDelete_1
            // 
            this.btnDelete_1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete_1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete_1.Location = new System.Drawing.Point(456, 294);
            this.btnDelete_1.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete_1.Name = "btnDelete_1";
            this.btnDelete_1.Size = new System.Drawing.Size(147, 33);
            this.btnDelete_1.TabIndex = 9;
            this.btnDelete_1.Text = "Удалить";
            this.btnDelete_1.UseVisualStyleBackColor = true;
            this.btnDelete_1.Click += new System.EventHandler(this.btnDelete_1_Click);
            // 
            // btnDobovlenie
            // 
            this.btnDobovlenie.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDobovlenie.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDobovlenie.Location = new System.Drawing.Point(1373, 294);
            this.btnDobovlenie.Margin = new System.Windows.Forms.Padding(4);
            this.btnDobovlenie.Name = "btnDobovlenie";
            this.btnDobovlenie.Size = new System.Drawing.Size(147, 33);
            this.btnDobovlenie.TabIndex = 10;
            this.btnDobovlenie.Text = "Добавление маршрута";
            this.btnDobovlenie.UseVisualStyleBackColor = true;
            this.btnDobovlenie.Click += new System.EventHandler(this.btnDobovlenie_Click);
            // 
            // маршрутыBindingSource
            // 
            this.маршрутыBindingSource.DataMember = "Маршруты";
            this.маршрутыBindingSource.DataSource = this.solovevkDataSet5;
            // 
            // solovevkDataSet5
            // 
            this.solovevkDataSet5.DataSetName = "SolovevkDataSet5";
            this.solovevkDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодмаршрутаDataGridViewTextBoxColumn1,
            this.кодпоездаDataGridViewTextBoxColumn1,
            this.пунктотправлениеDataGridViewTextBoxColumn1,
            this.пунктприбытияDataGridViewTextBoxColumn1,
            this.датаотправлениеDataGridViewTextBoxColumn1,
            this.станцияDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.маршрутыBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(778, 62);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(742, 208);
            this.dataGridView2.TabIndex = 11;
            // 
            // кодмаршрутаDataGridViewTextBoxColumn1
            // 
            this.кодмаршрутаDataGridViewTextBoxColumn1.DataPropertyName = "Код_маршрута";
            this.кодмаршрутаDataGridViewTextBoxColumn1.HeaderText = "Код_маршрута";
            this.кодмаршрутаDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.кодмаршрутаDataGridViewTextBoxColumn1.Name = "кодмаршрутаDataGridViewTextBoxColumn1";
            this.кодмаршрутаDataGridViewTextBoxColumn1.ReadOnly = true;
            this.кодмаршрутаDataGridViewTextBoxColumn1.Width = 125;
            // 
            // кодпоездаDataGridViewTextBoxColumn1
            // 
            this.кодпоездаDataGridViewTextBoxColumn1.DataPropertyName = "Код_поезда";
            this.кодпоездаDataGridViewTextBoxColumn1.HeaderText = "Код_поезда";
            this.кодпоездаDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.кодпоездаDataGridViewTextBoxColumn1.Name = "кодпоездаDataGridViewTextBoxColumn1";
            this.кодпоездаDataGridViewTextBoxColumn1.Width = 125;
            // 
            // пунктотправлениеDataGridViewTextBoxColumn1
            // 
            this.пунктотправлениеDataGridViewTextBoxColumn1.DataPropertyName = "Пункт_отправление";
            this.пунктотправлениеDataGridViewTextBoxColumn1.HeaderText = "Пункт_отправление";
            this.пунктотправлениеDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.пунктотправлениеDataGridViewTextBoxColumn1.Name = "пунктотправлениеDataGridViewTextBoxColumn1";
            this.пунктотправлениеDataGridViewTextBoxColumn1.Width = 125;
            // 
            // пунктприбытияDataGridViewTextBoxColumn1
            // 
            this.пунктприбытияDataGridViewTextBoxColumn1.DataPropertyName = "Пункт_прибытия";
            this.пунктприбытияDataGridViewTextBoxColumn1.HeaderText = "Пункт_прибытия";
            this.пунктприбытияDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.пунктприбытияDataGridViewTextBoxColumn1.Name = "пунктприбытияDataGridViewTextBoxColumn1";
            this.пунктприбытияDataGridViewTextBoxColumn1.Width = 125;
            // 
            // датаотправлениеDataGridViewTextBoxColumn1
            // 
            this.датаотправлениеDataGridViewTextBoxColumn1.DataPropertyName = "Дата_отправление";
            this.датаотправлениеDataGridViewTextBoxColumn1.HeaderText = "Дата_отправление";
            this.датаотправлениеDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.датаотправлениеDataGridViewTextBoxColumn1.Name = "датаотправлениеDataGridViewTextBoxColumn1";
            this.датаотправлениеDataGridViewTextBoxColumn1.Width = 125;
            // 
            // станцияDataGridViewTextBoxColumn1
            // 
            this.станцияDataGridViewTextBoxColumn1.DataPropertyName = "Станция";
            this.станцияDataGridViewTextBoxColumn1.HeaderText = "Станция";
            this.станцияDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.станцияDataGridViewTextBoxColumn1.Name = "станцияDataGridViewTextBoxColumn1";
            this.станцияDataGridViewTextBoxColumn1.Width = 125;
            // 
            // маршрутыBindingSource1
            // 
            this.маршрутыBindingSource1.DataMember = "Маршруты";
            this.маршрутыBindingSource1.DataSource = this.solovevkDataSet6;
            // 
            // solovevkDataSet6
            // 
            this.solovevkDataSet6.DataSetName = "SolovevkDataSet6";
            this.solovevkDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // маршрутыTableAdapter
            // 
            this.маршрутыTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(1220, 294);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(147, 33);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFiltr
            // 
            this.btnFiltr.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFiltr.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFiltr.Location = new System.Drawing.Point(778, 335);
            this.btnFiltr.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltr.Name = "btnFiltr";
            this.btnFiltr.Size = new System.Drawing.Size(147, 33);
            this.btnFiltr.TabIndex = 15;
            this.btnFiltr.Text = "Фильтр";
            this.btnFiltr.UseVisualStyleBackColor = true;
            this.btnFiltr.Click += new System.EventHandler(this.btnFiltr_Click);
            // 
            // txtFiltr_1
            // 
            this.txtFiltr_1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtFiltr_1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtFiltr_1.Location = new System.Drawing.Point(931, 335);
            this.txtFiltr_1.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiltr_1.Multiline = true;
            this.txtFiltr_1.Name = "txtFiltr_1";
            this.txtFiltr_1.Size = new System.Drawing.Size(277, 32);
            this.txtFiltr_1.TabIndex = 14;
            // 
            // btnPoisk
            // 
            this.btnPoisk.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPoisk.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPoisk.Location = new System.Drawing.Point(778, 294);
            this.btnPoisk.Margin = new System.Windows.Forms.Padding(4);
            this.btnPoisk.Name = "btnPoisk";
            this.btnPoisk.Size = new System.Drawing.Size(147, 33);
            this.btnPoisk.TabIndex = 13;
            this.btnPoisk.Text = "Поиск";
            this.btnPoisk.UseVisualStyleBackColor = true;
            this.btnPoisk.Click += new System.EventHandler(this.btnPoisk_Click);
            // 
            // txtPoisk_1
            // 
            this.txtPoisk_1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtPoisk_1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPoisk_1.Location = new System.Drawing.Point(931, 294);
            this.txtPoisk_1.Margin = new System.Windows.Forms.Padding(4);
            this.txtPoisk_1.Multiline = true;
            this.txtPoisk_1.Name = "txtPoisk_1";
            this.txtPoisk_1.Size = new System.Drawing.Size(277, 32);
            this.txtPoisk_1.TabIndex = 12;
            this.txtPoisk_1.TextChanged += new System.EventHandler(this.txtPoisk_1_TextChanged);
            // 
            // btnSave_1
            // 
            this.btnSave_1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave_1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave_1.Location = new System.Drawing.Point(456, 339);
            this.btnSave_1.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave_1.Name = "btnSave_1";
            this.btnSave_1.Size = new System.Drawing.Size(147, 33);
            this.btnSave_1.TabIndex = 17;
            this.btnSave_1.Text = "Сохранить";
            this.btnSave_1.UseVisualStyleBackColor = true;
            this.btnSave_1.Click += new System.EventHandler(this.btnSave_1_Click);
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(1220, 335);
            this.button10.Margin = new System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(147, 33);
            this.button10.TabIndex = 18;
            this.button10.Text = "Сохранить";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDobovlenie_1
            // 
            this.btnDobovlenie_1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDobovlenie_1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDobovlenie_1.Location = new System.Drawing.Point(609, 294);
            this.btnDobovlenie_1.Margin = new System.Windows.Forms.Padding(4);
            this.btnDobovlenie_1.Name = "btnDobovlenie_1";
            this.btnDobovlenie_1.Size = new System.Drawing.Size(147, 33);
            this.btnDobovlenie_1.TabIndex = 19;
            this.btnDobovlenie_1.Text = "Добавление расписание";
            this.btnDobovlenie_1.UseVisualStyleBackColor = true;
            this.btnDobovlenie_1.Click += new System.EventHandler(this.btnDobovlenie_1_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.Location = new System.Drawing.Point(13, 444);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(147, 33);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Назад";
            this.btnClose.UseMnemonic = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Информация о расписанях:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(783, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Информация о маршрутах:";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1533, 513);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDobovlenie_1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btnSave_1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFiltr);
            this.Controls.Add(this.txtFiltr_1);
            this.Controls.Add(this.btnPoisk);
            this.Controls.Add(this.txtPoisk_1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnDobovlenie);
            this.Controls.Add(this.btnDelete_1);
            this.Controls.Add(this.btnFiltr_1);
            this.Controls.Add(this.txtFiltr);
            this.Controls.Add(this.btnPoisk_1);
            this.Controls.Add(this.txtPoisk);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnVoz);
            this.Controls.Add(this.btnProd);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "Главная ";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.расписаниеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.маршрутыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Button btnVoz;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SolovevkDataSet3 solovevkDataSet3;
        private System.Windows.Forms.BindingSource расписаниеBindingSource;
        private SolovevkDataSet3TableAdapters.РасписаниеTableAdapter расписаниеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодрасписанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпоездаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодмаршрутаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пунктотправлениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn пунктприбытияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn станцияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn регионDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаотправлениеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаприбытияDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtPoisk;
        private System.Windows.Forms.Button btnPoisk_1;
        private System.Windows.Forms.Button btnFiltr_1;
        private System.Windows.Forms.TextBox txtFiltr;
        private System.Windows.Forms.BindingSource маршрутыBindingSource;
        private SolovevkDataSet5 solovevkDataSet5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private SolovevkDataSet6 solovevkDataSet6;
        private System.Windows.Forms.BindingSource маршрутыBindingSource1;
        private SolovevkDataSet6TableAdapters.МаршрутыTableAdapter маршрутыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодмаршрутаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпоездаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn пунктотправлениеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn пунктприбытияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаотправлениеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn станцияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnFiltr;
        private System.Windows.Forms.TextBox txtFiltr_1;
        private System.Windows.Forms.Button btnPoisk;
        private System.Windows.Forms.TextBox txtPoisk_1;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button btnDelete_1;
        public System.Windows.Forms.Button btnDobovlenie;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnSave_1;
        public System.Windows.Forms.Button button10;
        public System.Windows.Forms.Button btnDobovlenie_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}