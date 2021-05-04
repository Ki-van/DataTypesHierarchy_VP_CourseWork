
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
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Аггрегатный");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Зависимый");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Независимый");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Скалярный", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Тип данных", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode9});
            this.hierarchyTreeView = new System.Windows.Forms.TreeView();
            this.btnAddDataType = new System.Windows.Forms.Button();
            this.Свойства = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // hierarchyTreeView
            // 
            this.hierarchyTreeView.Location = new System.Drawing.Point(13, 13);
            this.hierarchyTreeView.Name = "hierarchyTreeView";
            treeNode6.Name = "Aggregate";
            treeNode6.Text = "Аггрегатный";
            treeNode7.Name = "Dependent";
            treeNode7.Text = "Зависимый";
            treeNode8.Name = "Independent";
            treeNode8.Text = "Независимый";
            treeNode9.Name = "Scalar";
            treeNode9.Text = "Скалярный";
            treeNode10.Name = "RootDataType";
            treeNode10.Text = "Тип данных";
            this.hierarchyTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode10});
            this.hierarchyTreeView.Size = new System.Drawing.Size(510, 602);
            this.hierarchyTreeView.TabIndex = 0;
            // 
            // btnAddDataType
            // 
            this.btnAddDataType.Location = new System.Drawing.Point(585, 162);
            this.btnAddDataType.Name = "btnAddDataType";
            this.btnAddDataType.Size = new System.Drawing.Size(75, 23);
            this.btnAddDataType.TabIndex = 1;
            this.btnAddDataType.Text = "Добавить тип";
            this.btnAddDataType.UseVisualStyleBackColor = true;
            this.btnAddDataType.Click += new System.EventHandler(this.btnAddDataType_Click);
            // 
            // Свойства
            // 
            this.Свойства.AutoSize = true;
            this.Свойства.Location = new System.Drawing.Point(598, 41);
            this.Свойства.Name = "Свойства";
            this.Свойства.Size = new System.Drawing.Size(38, 15);
            this.Свойства.TabIndex = 2;
            this.Свойства.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 627);
            this.Controls.Add(this.Свойства);
            this.Controls.Add(this.btnAddDataType);
            this.Controls.Add(this.hierarchyTreeView);
            this.Name = "Form1";
            this.Text = "Data types hierarchy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView hierarchyTreeView;
        private System.Windows.Forms.Button btnAddDataType;
        private System.Windows.Forms.Label Свойства;
    }
}

