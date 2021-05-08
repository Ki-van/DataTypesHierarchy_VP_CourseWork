
namespace DataTypesHierarchy_VP_CourseWork
{
    partial class FormCloneType
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
            this.lbTypes = new System.Windows.Forms.ListBox();
            this.btnCloneType = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTypes
            // 
            this.lbTypes.FormattingEnabled = true;
            this.lbTypes.ItemHeight = 15;
            this.lbTypes.Location = new System.Drawing.Point(12, 12);
            this.lbTypes.Name = "lbTypes";
            this.lbTypes.Size = new System.Drawing.Size(328, 364);
            this.lbTypes.TabIndex = 0;
            // 
            // btnCloneType
            // 
            this.btnCloneType.Location = new System.Drawing.Point(250, 382);
            this.btnCloneType.Name = "btnCloneType";
            this.btnCloneType.Size = new System.Drawing.Size(91, 23);
            this.btnCloneType.TabIndex = 1;
            this.btnCloneType.Text = "Клонировать";
            this.btnCloneType.UseVisualStyleBackColor = true;
            this.btnCloneType.Click += new System.EventHandler(this.btnCloneType_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(169, 382);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FormCloneType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 414);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCloneType);
            this.Controls.Add(this.lbTypes);
            this.Name = "FormCloneType";
            this.Text = "Клонировать тип";
            this.Load += new System.EventHandler(this.FormCloneType_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbTypes;
        private System.Windows.Forms.Button btnCloneType;
        private System.Windows.Forms.Button btnCancel;
    }
}