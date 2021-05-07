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
            toolStripMenuItemOpen.Click += new System.EventHandler(this.MenuItemOpen_Click);
            toolStripMenuItemSave.Click += new System.EventHandler(this.MenuItemSave_Click);
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

        private void MenuItemOpen_Click(object sender, EventArgs e)
        {

            DataTypes.dataTypes.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файлы xml (*.xml)|*.xml";
            openFileDialog.RestoreDirectory = true;


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                try
                {
                    Serialize.LoadFromXml(openFileDialog.FileName);
                }
                catch (Exception)
                {
                    _ = MessageBox.Show("Файл поврежден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MenuItemSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Файлы xml (*.xml)|*.xml";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                Serialize.SaveToXML(saveFileDialog.FileName);
        }
    }
}
