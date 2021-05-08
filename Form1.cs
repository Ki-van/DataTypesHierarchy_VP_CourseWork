﻿using System;
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
            BuildTreeView();
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

            foreach(DataType dataType in DataTypes.dataTypes)
            {
                Type typeType = dataType.GetType();
                if(typeType == typeof(DependentScalar))
                {
                    AddTreeNode(dataType, depsNode);
                } else if(typeType == typeof(AggregateType))
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
            if(typeType == typeof(Number))
            {
                Number element = (Number)dataType;

                TreeNode newNode = new(element.Name);
                newNode.Nodes.Add(new TreeNode(element.Value.ToString()));
                newNode.Tag = dataType;
                rootNode.Nodes.Add(newNode);
            } else if(typeType == typeof(Character))
            {
                Character element = (Character)dataType;

                TreeNode newNode = new(element.Name);
                newNode.Nodes.Add(new TreeNode(element.Value.ToString()));
                newNode.Tag = dataType;
                rootNode.Nodes.Add(newNode);
            } else if(typeType == typeof(Boolean))
            {
                Boolean element = (Boolean)dataType;

                TreeNode newNode = new(element.Name);
                newNode.Nodes.Add(new TreeNode(element.Value.ToString()));
                newNode.Tag = dataType;
                rootNode.Nodes.Add(newNode);
            } else if(typeType == typeof(AggregateType))
            {
                AggregateType element = (AggregateType)dataType;

                TreeNode newNode = new(element.Name);
                newNode.Tag = dataType;
                
                foreach(DataType component in element.Components)
                {
                    AddTreeNode(component, newNode);
                }
                rootNode.Nodes.Add(newNode);
            } else if(typeType == typeof(DependentScalar))
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
    }
}
