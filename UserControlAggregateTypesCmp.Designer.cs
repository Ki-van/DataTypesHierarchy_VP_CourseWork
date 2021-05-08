
namespace DataTypesHierarchy_VP_CourseWork
{
    partial class UserControlAggregateTypesCmp
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbObject1 = new System.Windows.Forms.GroupBox();
            this.TypeSize1 = new System.Windows.Forms.Label();
            this.gbObject2 = new System.Windows.Forms.GroupBox();
            this.TypeSize2 = new System.Windows.Forms.Label();
            this.cmpResult = new System.Windows.Forms.Label();
            this.gbObject1.SuspendLayout();
            this.gbObject2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbObject1
            // 
            this.gbObject1.Controls.Add(this.TypeSize1);
            this.gbObject1.Location = new System.Drawing.Point(3, 4);
            this.gbObject1.Name = "gbObject1";
            this.gbObject1.Size = new System.Drawing.Size(150, 61);
            this.gbObject1.TabIndex = 0;
            this.gbObject1.TabStop = false;
            this.gbObject1.Text = "Name1";
            this.gbObject1.DragDrop += new System.Windows.Forms.DragEventHandler(this.gbObject1_DragDrop);
            this.gbObject1.DragEnter += new System.Windows.Forms.DragEventHandler(this.gbObject1_DragEnter);
            // 
            // TypeSize1
            // 
            this.TypeSize1.AutoSize = true;
            this.TypeSize1.Location = new System.Drawing.Point(61, 23);
            this.TypeSize1.Name = "TypeSize1";
            this.TypeSize1.Size = new System.Drawing.Size(33, 15);
            this.TypeSize1.TabIndex = 0;
            this.TypeSize1.Text = "Size1";
            // 
            // gbObject2
            // 
            this.gbObject2.Controls.Add(this.TypeSize2);
            this.gbObject2.Location = new System.Drawing.Point(177, 5);
            this.gbObject2.Name = "gbObject2";
            this.gbObject2.Size = new System.Drawing.Size(150, 61);
            this.gbObject2.TabIndex = 1;
            this.gbObject2.TabStop = false;
            this.gbObject2.Text = "Name2";
            this.gbObject2.DragDrop += new System.Windows.Forms.DragEventHandler(this.gbObject2_DragDrop);
            this.gbObject2.DragEnter += new System.Windows.Forms.DragEventHandler(this.gbObject2_DragEnter);
            // 
            // TypeSize2
            // 
            this.TypeSize2.AutoSize = true;
            this.TypeSize2.Location = new System.Drawing.Point(68, 23);
            this.TypeSize2.Name = "TypeSize2";
            this.TypeSize2.Size = new System.Drawing.Size(33, 15);
            this.TypeSize2.TabIndex = 0;
            this.TypeSize2.Text = "Size2";
            // 
            // cmpResult
            // 
            this.cmpResult.AutoSize = true;
            this.cmpResult.Location = new System.Drawing.Point(159, 27);
            this.cmpResult.Name = "cmpResult";
            this.cmpResult.Size = new System.Drawing.Size(12, 15);
            this.cmpResult.TabIndex = 2;
            this.cmpResult.Text = "?";
            // 
            // UserControlAggregateTypesCmp
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.cmpResult);
            this.Controls.Add(this.gbObject2);
            this.Controls.Add(this.gbObject1);
            this.Name = "UserControlAggregateTypesCmp";
            this.Size = new System.Drawing.Size(334, 70);
            this.Load += new System.EventHandler(this.UserControlAggregateTypesCmp_Load);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.UserControlAggregateTypesCmp_DragEnter);
            this.gbObject1.ResumeLayout(false);
            this.gbObject1.PerformLayout();
            this.gbObject2.ResumeLayout(false);
            this.gbObject2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbObject1;
        private System.Windows.Forms.Label TypeSize1;
        private System.Windows.Forms.GroupBox gbObject2;
        private System.Windows.Forms.Label TypeSize2;
        private System.Windows.Forms.Label cmpResult;
    }
}
