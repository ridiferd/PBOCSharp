namespace WinFormsPBO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.heroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.heroLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HeroIdValue = new System.Windows.Forms.Label();
            this.HeroNameValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HeroTypeValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HeroSkillsValue = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.heroBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(393, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // heroBindingSource
            // 
            this.heroBindingSource.DataSource = typeof(WinFormsPBO.Hero);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(474, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 1;
            // 
            // heroLabel
            // 
            this.heroLabel.AutoSize = true;
            this.heroLabel.Location = new System.Drawing.Point(449, 95);
            this.heroLabel.Name = "heroLabel";
            this.heroLabel.Size = new System.Drawing.Size(46, 15);
            this.heroLabel.TabIndex = 2;
            this.heroLabel.Text = "Hero Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(449, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hero Detail";
            // 
            // HeroIdValue
            // 
            this.HeroIdValue.AutoSize = true;
            this.HeroIdValue.Location = new System.Drawing.Point(523, 95);
            this.HeroIdValue.Name = "HeroIdValue";
            this.HeroIdValue.Size = new System.Drawing.Size(71, 15);
            this.HeroIdValue.TabIndex = 4;
            this.HeroIdValue.Text = "HeroIdValue";
            // 
            // HeroNameValue
            // 
            this.HeroNameValue.AutoSize = true;
            this.HeroNameValue.Location = new System.Drawing.Point(523, 131);
            this.HeroNameValue.Name = "HeroNameValue";
            this.HeroNameValue.Size = new System.Drawing.Size(93, 15);
            this.HeroNameValue.TabIndex = 6;
            this.HeroNameValue.Text = "HeroNameValue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(449, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Hero Name";
            // 
            // HeroTypeValue
            // 
            this.HeroTypeValue.AutoSize = true;
            this.HeroTypeValue.Location = new System.Drawing.Point(523, 169);
            this.HeroTypeValue.Name = "HeroTypeValue";
            this.HeroTypeValue.Size = new System.Drawing.Size(85, 15);
            this.HeroTypeValue.TabIndex = 8;
            this.HeroTypeValue.Text = "HeroTypeValue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Hero Type";
            // 
            // HeroSkillsValue
            // 
            this.HeroSkillsValue.AutoSize = true;
            this.HeroSkillsValue.Location = new System.Drawing.Point(523, 203);
            this.HeroSkillsValue.Name = "HeroSkillsValue";
            this.HeroSkillsValue.Size = new System.Drawing.Size(87, 15);
            this.HeroSkillsValue.TabIndex = 10;
            this.HeroSkillsValue.Text = "HeroSkillsValue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(449, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Hero Skills";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HeroSkillsValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.HeroTypeValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.HeroNameValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HeroIdValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.heroLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "WinForm - PBO C Scharp";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heroBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private BindingSource heroBindingSource;
        private Label label1;
        private Label heroLabel;
        private Label label3;
        private Label HeroIdValue;
        private Label HeroNameValue;
        private Label label4;
        private Label HeroTypeValue;
        private Label label5;
        private Label HeroSkillsValue;
        private Label label6;
    }
}