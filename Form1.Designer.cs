
namespace DataTypesHierarchy_VP_CourseWork
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Аггрегатный");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Зависимый");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Независимый");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Скалярный", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Тип данных", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4});
            this.hierarchyTreeView = new System.Windows.Forms.TreeView();
            this.btnAddDataType = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tbTypeDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditType = new System.Windows.Forms.Button();
            this.btnDeleteType = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelToolTip = new System.Windows.Forms.Label();
            this.menuConvertLenght = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // hierarchyTreeView
            // 
            this.hierarchyTreeView.AllowDrop = true;
            this.hierarchyTreeView.BackColor = System.Drawing.SystemColors.Control;
            this.hierarchyTreeView.Location = new System.Drawing.Point(12, 45);
            this.hierarchyTreeView.Name = "hierarchyTreeView";
            treeNode1.Name = "Aggregate";
            treeNode1.Text = "Аггрегатный";
            treeNode2.Name = "Dependent";
            treeNode2.Text = "Зависимый";
            treeNode3.Name = "Independent";
            treeNode3.Text = "Независимый";
            treeNode4.Name = "Scalar";
            treeNode4.Text = "Скалярный";
            treeNode5.Name = "RootDataType";
            treeNode5.Text = "Тип данных";
            this.hierarchyTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.hierarchyTreeView.Size = new System.Drawing.Size(429, 570);
            this.hierarchyTreeView.TabIndex = 0;
            this.hierarchyTreeView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.hierarchyTreeView_ItemDrag);
            this.hierarchyTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.hierarchyTreeView_AfterSelect);
            // 
            // btnAddDataType
            // 
            this.btnAddDataType.Location = new System.Drawing.Point(460, 592);
            this.btnAddDataType.Name = "btnAddDataType";
            this.btnAddDataType.Size = new System.Drawing.Size(129, 23);
            this.btnAddDataType.TabIndex = 1;
            this.btnAddDataType.Text = "Добавить тип";
            this.btnAddDataType.UseVisualStyleBackColor = true;
            this.btnAddDataType.Click += new System.EventHandler(this.btnAddDataType_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFile,
            this.menuConvertLenght});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(872, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripMenuItemFile
            // 
            this.toolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemOpen,
            this.toolStripMenuItemSave});
            this.toolStripMenuItemFile.Name = "toolStripMenuItemFile";
            this.toolStripMenuItemFile.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItemFile.Text = "Файл";
            // 
            // toolStripMenuItemOpen
            // 
            this.toolStripMenuItemOpen.Name = "toolStripMenuItemOpen";
            this.toolStripMenuItemOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.toolStripMenuItemOpen.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItemOpen.Text = "Открыть";
            // 
            // toolStripMenuItemSave
            // 
            this.toolStripMenuItemSave.Name = "toolStripMenuItemSave";
            this.toolStripMenuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItemSave.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItemSave.Text = "Сохранить";
            // 
            // tbTypeDescription
            // 
            this.tbTypeDescription.BackColor = System.Drawing.SystemColors.Control;
            this.tbTypeDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTypeDescription.Location = new System.Drawing.Point(460, 45);
            this.tbTypeDescription.Multiline = true;
            this.tbTypeDescription.Name = "tbTypeDescription";
            this.tbTypeDescription.ReadOnly = true;
            this.tbTypeDescription.Size = new System.Drawing.Size(399, 446);
            this.tbTypeDescription.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Описание типа";
            // 
            // btnEditType
            // 
            this.btnEditType.Location = new System.Drawing.Point(595, 592);
            this.btnEditType.Name = "btnEditType";
            this.btnEditType.Size = new System.Drawing.Size(129, 23);
            this.btnEditType.TabIndex = 6;
            this.btnEditType.Text = "Редактировать тип";
            this.btnEditType.UseVisualStyleBackColor = true;
            this.btnEditType.Click += new System.EventHandler(this.btnEditType_Click);
            // 
            // btnDeleteType
            // 
            this.btnDeleteType.Location = new System.Drawing.Point(730, 592);
            this.btnDeleteType.Name = "btnDeleteType";
            this.btnDeleteType.Size = new System.Drawing.Size(129, 23);
            this.btnDeleteType.TabIndex = 7;
            this.btnDeleteType.Text = "Удалить тип";
            this.btnDeleteType.UseVisualStyleBackColor = true;
            this.btnDeleteType.Click += new System.EventHandler(this.btnDeleteType_Click);
            // 
            // labelToolTip
            // 
            this.labelToolTip.AutoSize = true;
            this.labelToolTip.Location = new System.Drawing.Point(810, 528);
            this.labelToolTip.Name = "labelToolTip";
            this.labelToolTip.Size = new System.Drawing.Size(12, 15);
            this.labelToolTip.TabIndex = 8;
            this.labelToolTip.Text = "?";
            // 
            // menuConvertLenght
            // 
            this.menuConvertLenght.Name = "menuConvertLenght";
            this.menuConvertLenght.Size = new System.Drawing.Size(64, 20);
            this.menuConvertLenght.Text = "Задание";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 627);
            this.Controls.Add(this.labelToolTip);
            this.Controls.Add(this.btnDeleteType);
            this.Controls.Add(this.btnEditType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTypeDescription);
            this.Controls.Add(this.btnAddDataType);
            this.Controls.Add(this.hierarchyTreeView);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "Data types hierarchy";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView hierarchyTreeView;
        private System.Windows.Forms.Button btnAddDataType;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemOpen;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSave;
        private System.Windows.Forms.TextBox tbTypeDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditType;
        private System.Windows.Forms.Button btnDeleteType;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelToolTip;
        private System.Windows.Forms.ToolStripMenuItem menuConvertLenght;
    }
}

