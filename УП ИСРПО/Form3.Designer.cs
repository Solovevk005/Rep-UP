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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
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
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
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
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(28, 426);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 40);
            this.button2.TabIndex = 2;
            this.button2.Text = "Продажа";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Location = new System.Drawing.Point(200, 426);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 40);
            this.button3.TabIndex = 3;
            this.button3.Text = "Возврат билетов";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridView1.Location = new System.Drawing.Point(28, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(742, 308);
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
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox1.Location = new System.Drawing.Point(142, 346);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 28);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(28, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.Location = new System.Drawing.Point(28, 380);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 28);
            this.button4.TabIndex = 8;
            this.button4.Text = "Фильтр";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox2.Location = new System.Drawing.Point(142, 380);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(251, 28);
            this.textBox2.TabIndex = 7;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button5.Location = new System.Drawing.Point(422, 346);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(130, 28);
            this.button5.TabIndex = 9;
            this.button5.Text = "Удалить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnDobovlenie
            // 
            this.btnDobovlenie.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDobovlenie.Location = new System.Drawing.Point(1350, 346);
            this.btnDobovlenie.Name = "btnDobovlenie";
            this.btnDobovlenie.Size = new System.Drawing.Size(173, 28);
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
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dataGridView2.Location = new System.Drawing.Point(803, 22);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(720, 308);
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
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button6.Location = new System.Drawing.Point(1197, 346);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 28);
            this.button6.TabIndex = 16;
            this.button6.Text = "Удалить";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button7.Location = new System.Drawing.Point(803, 380);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 28);
            this.button7.TabIndex = 15;
            this.button7.Text = "Фильтр";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox3.Location = new System.Drawing.Point(923, 380);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(262, 28);
            this.textBox3.TabIndex = 14;
            // 
            // button8
            // 
            this.button8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button8.Location = new System.Drawing.Point(803, 346);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 28);
            this.button8.TabIndex = 13;
            this.button8.Text = "Поиск";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox4.Location = new System.Drawing.Point(923, 346);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(262, 28);
            this.textBox4.TabIndex = 12;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button9
            // 
            this.button9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button9.Location = new System.Drawing.Point(422, 383);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(130, 28);
            this.button9.TabIndex = 17;
            this.button9.Text = "Сохранить";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button10.Location = new System.Drawing.Point(1197, 380);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(147, 28);
            this.button10.TabIndex = 18;
            this.button10.Text = "Сохранить";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button11.Location = new System.Drawing.Point(558, 346);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(212, 28);
            this.button11.TabIndex = 19;
            this.button11.Text = "Добавление расписание";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.Location = new System.Drawing.Point(28, 472);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(166, 40);
            this.btnClose.TabIndex = 20;
            this.btnClose.Text = "Назад";
            this.btnClose.UseMnemonic = false;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 700);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnDobovlenie);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
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
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button btnDobovlenie;
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button9;
        public System.Windows.Forms.Button button10;
        public System.Windows.Forms.Button button11;
    }
}