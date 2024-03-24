namespace MyUI
{
    partial class FrmStudent
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            textBoxName = new TextBox();
            comboBoxProfession = new ComboBox();
            btnSearch = new Button();
            btnAdd = new Button();
            btnEdit = new Button();
            dataGridViewStu = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            contextMenuStrip1 = new ContextMenuStrip(components);
            删除ToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStu).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F);
            label1.Location = new Point(15, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 27);
            label1.TabIndex = 0;
            label1.Text = "专业：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F);
            label2.Location = new Point(328, 29);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 27);
            label2.TabIndex = 1;
            label2.Text = "姓名：";
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Microsoft YaHei UI", 12F);
            textBoxName.Location = new Point(411, 26);
            textBoxName.Margin = new Padding(4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(214, 33);
            textBoxName.TabIndex = 2;
            // 
            // comboBoxProfession
            // 
            comboBoxProfession.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProfession.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            comboBoxProfession.FormattingEnabled = true;
            comboBoxProfession.Location = new Point(90, 26);
            comboBoxProfession.Margin = new Padding(4);
            comboBoxProfession.Name = "comboBoxProfession";
            comboBoxProfession.Size = new Size(199, 28);
            comboBoxProfession.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Microsoft YaHei UI", 11.25F);
            btnSearch.Location = new Point(656, 26);
            btnSearch.Margin = new Padding(4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(104, 46);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "搜索";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft YaHei UI", 11.25F);
            btnAdd.Location = new Point(768, 26);
            btnAdd.Margin = new Padding(4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(104, 46);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "新增";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Microsoft YaHei UI", 11.25F);
            btnEdit.Location = new Point(879, 26);
            btnEdit.Margin = new Padding(4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(104, 46);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "编辑";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // dataGridViewStu
            // 
            dataGridViewStu.AllowUserToAddRows = false;
            dataGridViewStu.AllowUserToDeleteRows = false;
            dataGridViewStu.AllowUserToResizeColumns = false;
            dataGridViewStu.AllowUserToResizeRows = false;
            dataGridViewStu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStu.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewStu.Location = new Point(15, 79);
            dataGridViewStu.Margin = new Padding(4);
            dataGridViewStu.Name = "dataGridViewStu";
            dataGridViewStu.ReadOnly = true;
            dataGridViewStu.RowHeadersVisible = false;
            dataGridViewStu.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewStu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewStu.Size = new Size(968, 414);
            dataGridViewStu.TabIndex = 7;
            dataGridViewStu.CellMouseDown += dataGridViewStu_CellMouseDown;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "StuID";
            Column1.HeaderText = "学生学号";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 81;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "StuName";
            Column2.HeaderText = "姓名";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "StuAge";
            Column3.HeaderText = "年龄";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "StuSex";
            Column4.HeaderText = "性别";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.DataPropertyName = "StuHobby";
            Column5.HeaderText = "爱好";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column6.DataPropertyName = "ProfessionName";
            Column6.HeaderText = "专业";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { 删除ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(109, 28);
            // 
            // 删除ToolStripMenuItem
            // 
            删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            删除ToolStripMenuItem.Size = new Size(108, 24);
            删除ToolStripMenuItem.Text = "删除";
            删除ToolStripMenuItem.Click += 删除ToolStripMenuItem_Click;
            // 
            // FrmStudent
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 529);
            Controls.Add(dataGridViewStu);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(comboBoxProfession);
            Controls.Add(textBoxName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4);
            Name = "FrmStudent";
            Text = "学生信息";
            Load += FrmStudent_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewStu).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxName;
        private ComboBox comboBoxProfession;
        private Button btnSearch;
        private Button btnAdd;
        private Button btnEdit;
        private DataGridView dataGridViewStu;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 删除ToolStripMenuItem;
    }
}