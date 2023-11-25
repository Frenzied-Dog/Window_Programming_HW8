namespace hw8_11_24 {
    partial class Form1 {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.招式屬性威力BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.寶可夢招式BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.寶可夢 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.屬性克制屬性被克制屬性BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.寶可夢招式招式屬性威力BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new hw8_11_24.Database1DataSet();
            this.招式DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.屬性DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.威力DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.招式DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.招式_屬性_威力TableAdapter = new hw8_11_24.Database1DataSetTableAdapters.招式_屬性_威力TableAdapter();
            this.寶可夢_招式TableAdapter = new hw8_11_24.Database1DataSetTableAdapters.寶可夢_招式TableAdapter();
            this.屬性_克制屬性_被克制屬性TableAdapter = new hw8_11_24.Database1DataSetTableAdapters.屬性_克制屬性_被克制屬性TableAdapter();
            this.招式屬性威力屬性克制屬性被克制屬性BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.屬性DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.克制屬性 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.被克制屬性 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.招式屬性威力BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.寶可夢招式BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.屬性克制屬性被克制屬性BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.寶可夢招式招式屬性威力BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.招式屬性威力屬性克制屬性被克制屬性BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.寶可夢,
            this.招式DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.寶可夢招式BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(860, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.招式DataGridViewTextBoxColumn1,
            this.屬性DataGridViewTextBoxColumn,
            this.威力DataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.寶可夢招式招式屬性威力BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 193);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(860, 175);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.屬性DataGridViewTextBoxColumn1,
            this.克制屬性,
            this.被克制屬性});
            this.dataGridView3.DataSource = this.招式屬性威力屬性克制屬性被克制屬性BindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 374);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(860, 175);
            this.dataGridView3.TabIndex = 1;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // 招式屬性威力BindingSource
            // 
            this.招式屬性威力BindingSource.DataMember = "招式_屬性_威力";
            this.招式屬性威力BindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // 寶可夢招式BindingSource
            // 
            this.寶可夢招式BindingSource.DataMember = "寶可夢_招式";
            this.寶可夢招式BindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // 寶可夢
            // 
            this.寶可夢.DataPropertyName = "寶可夢";
            this.寶可夢.HeaderText = "寶可夢";
            this.寶可夢.Name = "寶可夢";
            // 
            // 屬性克制屬性被克制屬性BindingSource
            // 
            this.屬性克制屬性被克制屬性BindingSource.DataMember = "屬性_克制屬性_被克制屬性";
            this.屬性克制屬性被克制屬性BindingSource.DataSource = this.database1DataSetBindingSource;
            // 
            // 寶可夢招式招式屬性威力BindingSource
            // 
            this.寶可夢招式招式屬性威力BindingSource.DataMember = "寶可夢_招式_招式_屬性_威力";
            this.寶可夢招式招式屬性威力BindingSource.DataSource = this.寶可夢招式BindingSource;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 招式DataGridViewTextBoxColumn1
            // 
            this.招式DataGridViewTextBoxColumn1.DataPropertyName = "招式";
            this.招式DataGridViewTextBoxColumn1.HeaderText = "招式";
            this.招式DataGridViewTextBoxColumn1.Name = "招式DataGridViewTextBoxColumn1";
            // 
            // 屬性DataGridViewTextBoxColumn
            // 
            this.屬性DataGridViewTextBoxColumn.DataPropertyName = "屬性";
            this.屬性DataGridViewTextBoxColumn.HeaderText = "屬性";
            this.屬性DataGridViewTextBoxColumn.Name = "屬性DataGridViewTextBoxColumn";
            // 
            // 威力DataGridViewTextBoxColumn
            // 
            this.威力DataGridViewTextBoxColumn.DataPropertyName = "威力";
            this.威力DataGridViewTextBoxColumn.HeaderText = "威力";
            this.威力DataGridViewTextBoxColumn.Name = "威力DataGridViewTextBoxColumn";
            // 
            // 招式DataGridViewTextBoxColumn
            // 
            this.招式DataGridViewTextBoxColumn.DataPropertyName = "招式";
            this.招式DataGridViewTextBoxColumn.HeaderText = "招式";
            this.招式DataGridViewTextBoxColumn.Name = "招式DataGridViewTextBoxColumn";
            // 
            // 招式_屬性_威力TableAdapter
            // 
            this.招式_屬性_威力TableAdapter.ClearBeforeFill = true;
            // 
            // 寶可夢_招式TableAdapter
            // 
            this.寶可夢_招式TableAdapter.ClearBeforeFill = true;
            // 
            // 屬性_克制屬性_被克制屬性TableAdapter
            // 
            this.屬性_克制屬性_被克制屬性TableAdapter.ClearBeforeFill = true;
            // 
            // 招式屬性威力屬性克制屬性被克制屬性BindingSource
            // 
            this.招式屬性威力屬性克制屬性被克制屬性BindingSource.DataMember = "招式_屬性_威力_屬性_克制屬性_被克制屬性";
            this.招式屬性威力屬性克制屬性被克制屬性BindingSource.DataSource = this.寶可夢招式招式屬性威力BindingSource;
            // 
            // 屬性DataGridViewTextBoxColumn1
            // 
            this.屬性DataGridViewTextBoxColumn1.DataPropertyName = "屬性";
            this.屬性DataGridViewTextBoxColumn1.HeaderText = "屬性";
            this.屬性DataGridViewTextBoxColumn1.Name = "屬性DataGridViewTextBoxColumn1";
            // 
            // 克制屬性
            // 
            this.克制屬性.DataPropertyName = "克制屬性";
            this.克制屬性.HeaderText = "克制屬性";
            this.克制屬性.Name = "克制屬性";
            // 
            // 被克制屬性
            // 
            this.被克制屬性.DataPropertyName = "被克制屬性";
            this.被克制屬性.HeaderText = "被克制屬性";
            this.被克制屬性.Name = "被克制屬性";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.招式屬性威力BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.寶可夢招式BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.屬性克制屬性被克制屬性BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.寶可夢招式招式屬性威力BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.招式屬性威力屬性克制屬性被克制屬性BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource 招式屬性威力BindingSource;
        private Database1DataSetTableAdapters.招式_屬性_威力TableAdapter 招式_屬性_威力TableAdapter;
        private System.Windows.Forms.BindingSource 寶可夢招式BindingSource;
        private Database1DataSetTableAdapters.寶可夢_招式TableAdapter 寶可夢_招式TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 寶可夢;
        private System.Windows.Forms.DataGridViewTextBoxColumn 招式DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 招式DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 屬性DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 威力DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 屬性克制屬性被克制屬性BindingSource;
        private Database1DataSetTableAdapters.屬性_克制屬性_被克制屬性TableAdapter 屬性_克制屬性_被克制屬性TableAdapter;
        private System.Windows.Forms.BindingSource 寶可夢招式招式屬性威力BindingSource;
        private System.Windows.Forms.BindingSource 招式屬性威力屬性克制屬性被克制屬性BindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn 屬性DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 克制屬性;
        private System.Windows.Forms.DataGridViewTextBoxColumn 被克制屬性;
    }
}

