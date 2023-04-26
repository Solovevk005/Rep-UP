namespace УП_ИСРПО
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодвозвратаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодпродажиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодбилетаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кодпассажираDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датавозвратаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.возвратБилетовBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.solovevkDataSet2 = new УП_ИСРПО.SolovevkDataSet2();
            this.возврат_билетовTableAdapter = new УП_ИСРПО.SolovevkDataSet2TableAdapters.Возврат_билетовTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.возвратБилетовBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодвозвратаDataGridViewTextBoxColumn,
            this.кодпродажиDataGridViewTextBoxColumn,
            this.кодбилетаDataGridViewTextBoxColumn,
            this.кодпассажираDataGridViewTextBoxColumn,
            this.датавозвратаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.возвратБилетовBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(27, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(682, 167);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодвозвратаDataGridViewTextBoxColumn
            // 
            this.кодвозвратаDataGridViewTextBoxColumn.DataPropertyName = "Код_возврата";
            this.кодвозвратаDataGridViewTextBoxColumn.HeaderText = "Код_возврата";
            this.кодвозвратаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.кодвозвратаDataGridViewTextBoxColumn.Name = "кодвозвратаDataGridViewTextBoxColumn";
            this.кодвозвратаDataGridViewTextBoxColumn.Width = 125;
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
            // датавозвратаDataGridViewTextBoxColumn
            // 
            this.датавозвратаDataGridViewTextBoxColumn.DataPropertyName = "Дата_возврата";
            this.датавозвратаDataGridViewTextBoxColumn.HeaderText = "Дата_возврата";
            this.датавозвратаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датавозвратаDataGridViewTextBoxColumn.Name = "датавозвратаDataGridViewTextBoxColumn";
            this.датавозвратаDataGridViewTextBoxColumn.Width = 125;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form5";
            this.Text = "Возврат билета";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.возвратБилетовBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solovevkDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private SolovevkDataSet2 solovevkDataSet2;
        private System.Windows.Forms.BindingSource возвратБилетовBindingSource;
        private SolovevkDataSet2TableAdapters.Возврат_билетовTableAdapter возврат_билетовTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодвозвратаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпродажиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодбилетаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпассажираDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датавозвратаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}