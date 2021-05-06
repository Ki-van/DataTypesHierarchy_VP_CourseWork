using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataTypesHierarchy_VP_CourseWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddDataType_Click(object sender, EventArgs e)
        {
            FormDataTypeChooser formDataTypeChooser = new FormDataTypeChooser
            {
                Owner = this,
                StartPosition = FormStartPosition.CenterParent
            };
            formDataTypeChooser.ShowDialog();
            if(formDataTypeChooser.DialogResult == DialogResult.OK)
            {
                BuildTreeView();
                hierarchyTreeView.Refresh();
            }
        }

        private void BuildTreeView()
        {
            hierarchyTreeView.Nodes.Clear();

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            hierarchyTreeView.ExpandAll();
        }
    }
}
