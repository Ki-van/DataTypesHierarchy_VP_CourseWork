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
        UserControlAggregateTypesCmp aggCmp;
        public Form1()
        {
            InitializeComponent();
            toolStripMenuItemOpen.Click += new System.EventHandler(this.MenuItemOpen_Click);
            toolStripMenuItemSave.Click += new System.EventHandler(this.MenuItemSave_Click);
            menuConvertLenght.Click += new EventHandler(this.MenuConvertLenght_Click);

            BuildTreeView();

            aggCmp = new UserControlAggregateTypesCmp();
            aggCmp.Location = (new Point(460, 494));
            this.Controls.Add(aggCmp);
        }

        private void btnAddDataType_Click(object sender, EventArgs e)
        {
            FormDataTypeChooser formDataTypeChooser = new FormDataTypeChooser
            {
                Owner = this,
                StartPosition = FormStartPosition.CenterParent
            };
            formDataTypeChooser.ShowDialog();
            if (formDataTypeChooser.DialogResult == DialogResult.OK)
            {
                BuildTreeView();
            }
        }

        private void BuildTreeView()
        {
            hierarchyTreeView.Nodes.Clear();

            TreeNode rootNode = new TreeNode("Тип данных");
            rootNode.Tag = new DataType();
            hierarchyTreeView.Nodes.Add(rootNode);
            TreeNode aggregatesNode = new TreeNode("Агрегатный");
            TreeNode scalarsNode = new TreeNode("Скалярный");

            TreeNode depsNode = new TreeNode("Зависимый");
            TreeNode inDepsNode = new TreeNode("Независимый");

            rootNode.Nodes.AddRange(new TreeNode[] { aggregatesNode, scalarsNode });
            scalarsNode.Nodes.Add(depsNode);
            scalarsNode.Nodes.Add(inDepsNode);

            foreach (DataType dataType in DataTypes.dataTypes)
            {
                Type typeType = dataType.GetType();
                if (typeType == typeof(DependentScalar))
                {
                    AddTreeNode(dataType, depsNode);
                } else if (typeType == typeof(AggregateType))
                {
                    AddTreeNode(dataType, aggregatesNode);
                } else
                {
                    AddTreeNode(dataType, inDepsNode);
                }
            }
            hierarchyTreeView.Nodes[0].ExpandAll();
            hierarchyTreeView.Refresh();
        }

        private void AddTreeNode(DataType dataType, TreeNode rootNode)
        {
            Type typeType = dataType.GetType();
            if (typeType == typeof(Number))
            {
                Number element = (Number)dataType;

                TreeNode newNode = new(element.Name);
                newNode.Nodes.Add(new TreeNode(element.Value.ToString()));
                newNode.Tag = dataType;
                rootNode.Nodes.Add(newNode);
            } else if (typeType == typeof(Character))
            {
                Character element = (Character)dataType;

                TreeNode newNode = new(element.Name);
                newNode.Nodes.Add(new TreeNode(element.Value.ToString()));
                newNode.Tag = dataType;
                rootNode.Nodes.Add(newNode);
            } else if (typeType == typeof(Boolean))
            {
                Boolean element = (Boolean)dataType;

                TreeNode newNode = new(element.Name);
                newNode.Nodes.Add(new TreeNode(element.Value.ToString()));
                newNode.Tag = dataType;
                rootNode.Nodes.Add(newNode);
            } else if (typeType == typeof(AggregateType))
            {
                AggregateType element = (AggregateType)dataType;

                TreeNode newNode = new(element.Name);
                newNode.Tag = dataType;

                foreach (DataType component in element.Components)
                {
                    AddTreeNode(component, newNode);
                }
                rootNode.Nodes.Add(newNode);
            } else if (typeType == typeof(DependentScalar))
            {
                DependentScalar element = (DependentScalar)dataType;

                TreeNode newNode = new(element.Name);
                newNode.Tag = dataType;
                AddTreeNode(element.Value, newNode);
                rootNode.Nodes.Add(newNode);
            }

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(labelToolTip, "Элемент сравнивает два агрегатных объекта, для использования элемента перетащите на него из дерева агрегатные типы");
            hierarchyTreeView.ExpandAll();
        }

        private void MenuConvertLenght_Click(object sender, EventArgs e)
        {
            FormConverterLenght formConverterLenght = new FormConverterLenght()
            {
                Owner = this,
                StartPosition = FormStartPosition.CenterParent
            };
            formConverterLenght.ShowDialog();
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
                    BuildTreeView();
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

        private void hierarchyTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            tbTypeDescription.Text = ((DataType)(e.Node.Tag))?.GetDescription();
        }

        private void btnDeleteType_Click(object sender, EventArgs e)
        {
            DataTypes.dataTypes.Remove((DataType)hierarchyTreeView.SelectedNode.Tag);
            BuildTreeView();
        }

        private void btnEditType_Click(object sender, EventArgs e)
        {
            Type type = hierarchyTreeView.SelectedNode.Tag.GetType();
            if (type == typeof(Number) || type == typeof(Character) || type == typeof(Boolean))
            {
                FormInDepDataTypeConsructor formInDepDataTypeConsructor = new((DataType)hierarchyTreeView.SelectedNode.Tag)
                {
                    Owner = this,
                    StartPosition = FormStartPosition.CenterParent
                };
                formInDepDataTypeConsructor.ShowDialog();
                if (formInDepDataTypeConsructor.DialogResult == DialogResult.OK)
                {
                    DialogResult = DialogResult.OK;
                    DataTypes.dataTypes.Remove((DataType)hierarchyTreeView.SelectedNode.Tag);
                    BuildTreeView();
                }
            }
            if(type == typeof(DependentScalar))
            {
                FormDepDataTypeConsructor formDepDataTypeConsructor = new()
                {
                    Owner = this,
                    StartPosition = FormStartPosition.CenterParent
                };
                formDepDataTypeConsructor.ShowDialog();
                if (formDepDataTypeConsructor.DialogResult == DialogResult.OK)
                {
                    DialogResult = DialogResult.OK;
                    DataTypes.dataTypes.Remove((DataType)hierarchyTreeView.SelectedNode.Tag);
                    BuildTreeView();
                }
            }

            if(type == typeof(AggregateType))
            {
                FormAggregateDataTypeConstructor formAggregateDataTypeConstructor = new((DataType)hierarchyTreeView.SelectedNode.Tag)
                {
                    Owner = this,
                    StartPosition = FormStartPosition.CenterParent
                };
                formAggregateDataTypeConstructor.ShowDialog();
                if (formAggregateDataTypeConstructor.DialogResult == DialogResult.OK)
                {
                    DialogResult = DialogResult.OK;
                    DataTypes.dataTypes.Remove((DataType)hierarchyTreeView.SelectedNode.Tag);
                    BuildTreeView();
                }
            }
        }

        private void hierarchyTreeView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if(((TreeNode)e.Item).Tag != null)
            {
                hierarchyTreeView.DoDragDrop(((TreeNode)e.Item).Tag, DragDropEffects.Copy);
            }
        }
    }
}
