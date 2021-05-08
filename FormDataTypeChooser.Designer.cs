
namespace DataTypesHierarchy_VP_CourseWork
{
    partial class FormDataTypeChooser
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
            this.groupBoxClassType = new System.Windows.Forms.GroupBox();
            this.rbtnInDependent = new System.Windows.Forms.RadioButton();
            this.rbtnDependent = new System.Windows.Forms.RadioButton();
            this.rbtnAggregate = new System.Windows.Forms.RadioButton();
            this.btnCreateType = new System.Windows.Forms.Button();
            this.btnCloneType = new System.Windows.Forms.Button();
            this.groupBoxClassType.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxClassType
            // 
            this.groupBoxClassType.Controls.Add(this.rbtnInDependent);
            this.groupBoxClassType.Controls.Add(this.rbtnDependent);
            this.groupBoxClassType.Controls.Add(this.rbtnAggregate);
            this.groupBoxClassType.Location = new System.Drawing.Point(13, 13);
            this.groupBoxClassType.Name = "groupBoxClassType";
            this.groupBoxClassType.Size = new System.Drawing.Size(200, 100);
            this.groupBoxClassType.TabIndex = 0;
            this.groupBoxClassType.TabStop = false;
            this.groupBoxClassType.Text = "Выберите класс типа";
            // 
            // rbtnInDependent
            // 
            this.rbtnInDependent.AutoSize = true;
            this.rbtnInDependent.Location = new System.Drawing.Point(7, 75);
            this.rbtnInDependent.Name = "rbtnInDependent";
            this.rbtnInDependent.Size = new System.Drawing.Size(102, 19);
            this.rbtnInDependent.TabIndex = 2;
            this.rbtnInDependent.TabStop = true;
            this.rbtnInDependent.Text = "Независимый";
            this.rbtnInDependent.UseVisualStyleBackColor = true;
            // 
            // rbtnDependent
            // 
            this.rbtnDependent.AutoSize = true;
            this.rbtnDependent.Location = new System.Drawing.Point(7, 49);
            this.rbtnDependent.Name = "rbtnDependent";
            this.rbtnDependent.Size = new System.Drawing.Size(89, 19);
            this.rbtnDependent.TabIndex = 1;
            this.rbtnDependent.TabStop = true;
            this.rbtnDependent.Text = "Зависимый";
            this.rbtnDependent.UseVisualStyleBackColor = true;
            // 
            // rbtnAggregate
            // 
            this.rbtnAggregate.AutoSize = true;
            this.rbtnAggregate.Location = new System.Drawing.Point(7, 23);
            this.rbtnAggregate.Name = "rbtnAggregate";
            this.rbtnAggregate.Size = new System.Drawing.Size(90, 19);
            this.rbtnAggregate.TabIndex = 0;
            this.rbtnAggregate.TabStop = true;
            this.rbtnAggregate.Text = "Агрегатный";
            this.rbtnAggregate.UseVisualStyleBackColor = true;
            // 
            // btnCreateType
            // 
            this.btnCreateType.Location = new System.Drawing.Point(219, 90);
            this.btnCreateType.Name = "btnCreateType";
            this.btnCreateType.Size = new System.Drawing.Size(94, 23);
            this.btnCreateType.TabIndex = 1;
            this.btnCreateType.Text = "Создать";
            this.btnCreateType.UseVisualStyleBackColor = true;
            this.btnCreateType.Click += new System.EventHandler(this.btnCreateType_Click);
            // 
            // btnCloneType
            // 
            this.btnCloneType.Location = new System.Drawing.Point(220, 61);
            this.btnCloneType.Name = "btnCloneType";
            this.btnCloneType.Size = new System.Drawing.Size(93, 23);
            this.btnCloneType.TabIndex = 2;
            this.btnCloneType.Text = "Клонировать";
            this.btnCloneType.UseVisualStyleBackColor = true;
            this.btnCloneType.Click += new System.EventHandler(this.btnCloneType_Click);
            // 
            // FormDataTypeChooser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 129);
            this.Controls.Add(this.btnCloneType);
            this.Controls.Add(this.btnCreateType);
            this.Controls.Add(this.groupBoxClassType);
            this.Name = "FormDataTypeChooser";
            this.Text = "Создать новый тип";
            this.groupBoxClassType.ResumeLayout(false);
            this.groupBoxClassType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxClassType;
        private System.Windows.Forms.RadioButton rbtnInDependent;
        private System.Windows.Forms.RadioButton rbtnDependent;
        private System.Windows.Forms.RadioButton rbtnAggregate;
        private System.Windows.Forms.Button btnCreateType;
        private System.Windows.Forms.Button btnCloneType;
    }
}