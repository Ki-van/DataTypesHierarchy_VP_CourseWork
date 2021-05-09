
namespace DataTypesHierarchy_VP_CourseWork
{
    partial class ConverterLength
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NumberIn = new System.Windows.Forms.TextBox();
            this.comboBox_Out = new System.Windows.Forms.ComboBox();
            this.NumberOut = new System.Windows.Forms.TextBox();
            this.comboBox_In = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NumberIn
            // 
            this.NumberIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberIn.Location = new System.Drawing.Point(0, 0);
            this.NumberIn.Name = "NumberIn";
            this.NumberIn.Size = new System.Drawing.Size(188, 23);
            this.NumberIn.TabIndex = 0;
            this.NumberIn.Text = "0";
            this.NumberIn.TextChanged += new System.EventHandler(this.NumberIn_TextChanged);
            // 
            // comboBox_Out
            // 
            this.comboBox_Out.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_Out.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Out.FormattingEnabled = true;
            this.comboBox_Out.Location = new System.Drawing.Point(194, 26);
            this.comboBox_Out.Name = "comboBox_Out";
            this.comboBox_Out.Size = new System.Drawing.Size(105, 23);
            this.comboBox_Out.TabIndex = 3;
            // 
            // NumberOut
            // 
            this.NumberOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberOut.Enabled = false;
            this.NumberOut.Location = new System.Drawing.Point(0, 26);
            this.NumberOut.Name = "NumberOut";
            this.NumberOut.Size = new System.Drawing.Size(188, 23);
            this.NumberOut.TabIndex = 4;
            this.NumberOut.Text = "0";
            // 
            // comboBox_In
            // 
            this.comboBox_In.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_In.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_In.FormattingEnabled = true;
            this.comboBox_In.Location = new System.Drawing.Point(194, 0);
            this.comboBox_In.Name = "comboBox_In";
            this.comboBox_In.Size = new System.Drawing.Size(105, 23);
            this.comboBox_In.TabIndex = 1;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBox_In);
            this.Controls.Add(this.NumberOut);
            this.Controls.Add(this.comboBox_Out);
            this.Controls.Add(this.NumberIn);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(299, 53);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberOut;
        private System.Windows.Forms.TextBox NumberIn;
        private System.Windows.Forms.ComboBox comboBox_Out;
        private System.Windows.Forms.ComboBox comboBox_In;
    }
}
