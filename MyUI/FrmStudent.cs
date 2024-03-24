using IBLL;
using MyBLL;
using MyEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyUI
{
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            BindComboBox();
            BindDataGridView();
        }

        ProfessionInfoBLL professionBll = new ProfessionInfoBLL();
        IStudentInfoBLL studentBll = new StudentInfoBLL();
        private void BindComboBox()
        {
            List<ProfessionInfoEntity> professionList = new List<ProfessionInfoEntity>();
            professionList = professionBll.List();
            professionList.Insert(0, new ProfessionInfoEntity { ProfessionID = 0, ProfessionName = "---请选择---" });
            comboBoxProfession.DataSource = professionList;
            comboBoxProfession.DisplayMember = "ProfessionName";
            comboBoxProfession.ValueMember = "ProfessionID";
        }

        private void BindDataGridView()
        {

            StudentInfoEntity student = new StudentInfoEntity();
            student.ProfessionID = int.Parse(comboBoxProfession.SelectedValue.ToString());
            student.StuName = textBoxName.Text;
            dataGridViewStu.AutoGenerateColumns = false;
            dataGridViewStu.DataSource = studentBll.SearchList(student);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BindDataGridView();
        }

        private void dataGridViewStu_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            if (e.RowIndex < 0) return;
            if (dataGridViewStu.Rows[e.RowIndex].Selected == false)
            {
                dataGridViewStu.ClearSelection();
                dataGridViewStu.Rows[e.RowIndex].Selected = true;
            }
            if (dataGridViewStu.SelectedRows.Count == 1)
            {
                dataGridViewStu.CurrentCell = dataGridViewStu.Rows[e.RowIndex].Cells[e.ColumnIndex];
            }
            contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定删除吗？", "删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel) return;
            string selectedStuID = dataGridViewStu.SelectedCells[0].Value.ToString();
            if (studentBll.Delete(selectedStuID) == 1)
            {
                MessageBox.Show("删除成功！");
                BindDataGridView();
            }
            else
            {
                MessageBox.Show("删除失败!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
