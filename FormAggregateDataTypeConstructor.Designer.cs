
namespace DataTypesHierarchy_VP_CourseWork
{
    partial class FormAggregateDataTypeConstructor
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
            this.listBoxAvailableComponents = new System.Windows.Forms.ListBox();
            this.listBoxIncludedComponents = new System.Windows.Forms.ListBox();
            this.btnAddComponent = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCreateType = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveComponent = new System.Windows.Forms.Button();
            this.tbTypeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxAvailableComponents
            // 
            this.listBoxAvailableComponents.FormattingEnabled = true;
            this.listBoxAvailableComponents.ItemHeight = 15;
            this.listBoxAvailableComponents.Location = new System.Drawing.Point(12, 27);
            this.listBoxAvailableComponents.Name = "listBoxAvailableComponents";
            this.listBoxAvailableComponents.Size = new System.Drawing.Size(214, 364);
            this.listBoxAvailableComponents.TabIndex = 0;
            // 
            // listBoxIncludedComponents
            // 
            this.listBoxIncludedComponents.FormattingEnabled = true;
            this.listBoxIncludedComponents.ItemHeight = 15;
            this.listBoxIncludedComponents.Location = new System.Drawing.Point(271, 27);
            this.listBoxIncludedComponents.Name = "listBoxIncludedComponents";
            this.listBoxIncludedComponents.Size = new System.Drawing.Size(214, 364);
            this.listBoxIncludedComponents.TabIndex = 1;
            // 
            // btnAddComponent
            // 
            this.btnAddComponent.Location = new System.Drawing.Point(232, 163);
            this.btnAddComponent.Name = "btnAddComponent";
            this.btnAddComponent.Size = new System.Drawing.Size(33, 23);
            this.btnAddComponent.TabIndex = 2;
            this.btnAddComponent.Text = ">";
            this.btnAddComponent.UseVisualStyleBackColor = true;
            this.btnAddComponent.Click += new System.EventHandler(this.btnAddComponent_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(329, 476);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreateType
            // 
            this.btnCreateType.Location = new System.Drawing.Point(410, 476);
            this.btnCreateType.Name = "btnCreateType";
            this.btnCreateType.Size = new System.Drawing.Size(75, 23);
            this.btnCreateType.TabIndex = 4;
            this.btnCreateType.Text = "Создать";
            this.btnCreateType.UseVisualStyleBackColor = true;
            this.btnCreateType.Click += new System.EventHandler(this.btnCreateType_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите компоненты типа";
            // 
            // btnRemoveComponent
            // 
            this.btnRemoveComponent.Location = new System.Drawing.Point(232, 192);
            this.btnRemoveComponent.Name = "btnRemoveComponent";
            this.btnRemoveComponent.Size = new System.Drawing.Size(33, 23);
            this.btnRemoveComponent.TabIndex = 6;
            this.btnRemoveComponent.Text = "<";
            this.btnRemoveComponent.UseVisualStyleBackColor = true;
            this.btnRemoveComponent.Click += new System.EventHandler(this.btnRemoveComponent_Click);
            // 
            // tbTypeName
            // 
            this.tbTypeName.Location = new System.Drawing.Point(12, 433);
            this.tbTypeName.Name = "tbTypeName";
            this.tbTypeName.PlaceholderText = "TypeName";
            this.tbTypeName.Size = new System.Drawing.Size(214, 23);
            this.tbTypeName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Введите имя типа";
            // 
            // FormAggregateDataTypeConstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbTypeName);
            this.Controls.Add(this.btnRemoveComponent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateType);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddComponent);
            this.Controls.Add(this.listBoxIncludedComponents);
            this.Controls.Add(this.listBoxAvailableComponents);
            this.Name = "FormAggregateDataTypeConstructor";
            this.Text = "Создание агрегатного типа";
            this.Load += new System.EventHandler(this.FormAggregateDataTypeConstructor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAvailableComponents;
        private System.Windows.Forms.ListBox listBoxIncludedComponents;
        private System.Windows.Forms.Button btnAddComponent;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCreateType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveComponent;
        private System.Windows.Forms.TextBox tbTypeName;
        private System.Windows.Forms.Label label2;
    }
}