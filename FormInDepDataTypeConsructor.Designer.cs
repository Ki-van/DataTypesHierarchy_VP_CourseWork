
namespace DataTypesHierarchy_VP_CourseWork
{
    partial class FormInDepDataTypeConsructor
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnScalarBoolean = new System.Windows.Forms.RadioButton();
            this.rbtnScalarCharacter = new System.Windows.Forms.RadioButton();
            this.rbtnScalarNumber = new System.Windows.Forms.RadioButton();
            this.btnCreateScalar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grbNumberClass = new System.Windows.Forms.GroupBox();
            this.rbtnWholeNumber = new System.Windows.Forms.RadioButton();
            this.rbtnRealNumber = new System.Windows.Forms.RadioButton();
            this.grbRealTypeParams = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnRealSize8 = new System.Windows.Forms.RadioButton();
            this.rbtnRealSize4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTypeName = new System.Windows.Forms.TextBox();
            this.Значение = new System.Windows.Forms.Label();
            this.tbTypeValue = new System.Windows.Forms.TextBox();
            this.grbNumberWholeParams = new System.Windows.Forms.GroupBox();
            this.cbWholeSigned = new System.Windows.Forms.CheckBox();
            this.grbWholeSize = new System.Windows.Forms.GroupBox();
            this.rbtWholeSize8 = new System.Windows.Forms.RadioButton();
            this.rbtWholeSize4 = new System.Windows.Forms.RadioButton();
            this.rbtWholeSize2 = new System.Windows.Forms.RadioButton();
            this.rbtWholeSize1 = new System.Windows.Forms.RadioButton();
            this.cbBooleanValue = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.grbNumberClass.SuspendLayout();
            this.grbRealTypeParams.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grbNumberWholeParams.SuspendLayout();
            this.grbWholeSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnScalarBoolean);
            this.groupBox1.Controls.Add(this.rbtnScalarCharacter);
            this.groupBox1.Controls.Add(this.rbtnScalarNumber);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите класс скалярного типа";
            // 
            // rbtnScalarBoolean
            // 
            this.rbtnScalarBoolean.AutoSize = true;
            this.rbtnScalarBoolean.Location = new System.Drawing.Point(7, 75);
            this.rbtnScalarBoolean.Name = "rbtnScalarBoolean";
            this.rbtnScalarBoolean.Size = new System.Drawing.Size(144, 19);
            this.rbtnScalarBoolean.TabIndex = 2;
            this.rbtnScalarBoolean.Text = "Логическое значение";
            this.rbtnScalarBoolean.UseVisualStyleBackColor = true;
            this.rbtnScalarBoolean.CheckedChanged += new System.EventHandler(this.rbtnScalarBoolean_CheckedChanged);
            // 
            // rbtnScalarCharacter
            // 
            this.rbtnScalarCharacter.AutoSize = true;
            this.rbtnScalarCharacter.Location = new System.Drawing.Point(7, 49);
            this.rbtnScalarCharacter.Name = "rbtnScalarCharacter";
            this.rbtnScalarCharacter.Size = new System.Drawing.Size(69, 19);
            this.rbtnScalarCharacter.TabIndex = 1;
            this.rbtnScalarCharacter.Text = "Символ";
            this.rbtnScalarCharacter.UseVisualStyleBackColor = true;
            // 
            // rbtnScalarNumber
            // 
            this.rbtnScalarNumber.AutoSize = true;
            this.rbtnScalarNumber.Checked = true;
            this.rbtnScalarNumber.Location = new System.Drawing.Point(7, 23);
            this.rbtnScalarNumber.Name = "rbtnScalarNumber";
            this.rbtnScalarNumber.Size = new System.Drawing.Size(60, 19);
            this.rbtnScalarNumber.TabIndex = 0;
            this.rbtnScalarNumber.TabStop = true;
            this.rbtnScalarNumber.Text = "Число";
            this.rbtnScalarNumber.UseVisualStyleBackColor = true;
            this.rbtnScalarNumber.CheckedChanged += new System.EventHandler(this.rbtnScalarNumber_CheckedChanged);
            // 
            // btnCreateScalar
            // 
            this.btnCreateScalar.Location = new System.Drawing.Point(364, 415);
            this.btnCreateScalar.Name = "btnCreateScalar";
            this.btnCreateScalar.Size = new System.Drawing.Size(75, 23);
            this.btnCreateScalar.TabIndex = 1;
            this.btnCreateScalar.Text = "Создать";
            this.btnCreateScalar.UseVisualStyleBackColor = true;
            this.btnCreateScalar.Click += new System.EventHandler(this.btnCreateScalar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(283, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grbNumberClass
            // 
            this.grbNumberClass.Controls.Add(this.rbtnWholeNumber);
            this.grbNumberClass.Controls.Add(this.rbtnRealNumber);
            this.grbNumberClass.Location = new System.Drawing.Point(239, 13);
            this.grbNumberClass.Name = "grbNumberClass";
            this.grbNumberClass.Size = new System.Drawing.Size(200, 100);
            this.grbNumberClass.TabIndex = 3;
            this.grbNumberClass.TabStop = false;
            this.grbNumberClass.Text = "Выберите класс тип Число";
            // 
            // rbtnWholeNumber
            // 
            this.rbtnWholeNumber.AutoSize = true;
            this.rbtnWholeNumber.Location = new System.Drawing.Point(7, 49);
            this.rbtnWholeNumber.Name = "rbtnWholeNumber";
            this.rbtnWholeNumber.Size = new System.Drawing.Size(60, 19);
            this.rbtnWholeNumber.TabIndex = 1;
            this.rbtnWholeNumber.Text = "Целое";
            this.rbtnWholeNumber.UseVisualStyleBackColor = true;
            this.rbtnWholeNumber.CheckedChanged += new System.EventHandler(this.rbtnWholeNumber_CheckedChanged);
            // 
            // rbtnRealNumber
            // 
            this.rbtnRealNumber.AutoSize = true;
            this.rbtnRealNumber.Checked = true;
            this.rbtnRealNumber.Location = new System.Drawing.Point(7, 23);
            this.rbtnRealNumber.Name = "rbtnRealNumber";
            this.rbtnRealNumber.Size = new System.Drawing.Size(105, 19);
            this.rbtnRealNumber.TabIndex = 0;
            this.rbtnRealNumber.TabStop = true;
            this.rbtnRealNumber.Text = "Вещественное";
            this.rbtnRealNumber.UseVisualStyleBackColor = true;
            this.rbtnRealNumber.CheckedChanged += new System.EventHandler(this.rbtnRealNumber_CheckedChanged);
            // 
            // grbRealTypeParams
            // 
            this.grbRealTypeParams.Controls.Add(this.groupBox2);
            this.grbRealTypeParams.Location = new System.Drawing.Point(13, 120);
            this.grbRealTypeParams.Name = "grbRealTypeParams";
            this.grbRealTypeParams.Size = new System.Drawing.Size(426, 114);
            this.grbRealTypeParams.TabIndex = 4;
            this.grbRealTypeParams.TabStop = false;
            this.grbRealTypeParams.Text = "Параметры вещественного числа";
            this.grbRealTypeParams.Enter += new System.EventHandler(this.grbRealTypeParams_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnRealSize8);
            this.groupBox2.Controls.Add(this.rbtnRealSize4);
            this.groupBox2.Location = new System.Drawing.Point(7, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 80);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Занимаемый размер";
            // 
            // rbtnRealSize8
            // 
            this.rbtnRealSize8.AutoSize = true;
            this.rbtnRealSize8.Location = new System.Drawing.Point(7, 49);
            this.rbtnRealSize8.Name = "rbtnRealSize8";
            this.rbtnRealSize8.Size = new System.Drawing.Size(59, 19);
            this.rbtnRealSize8.TabIndex = 1;
            this.rbtnRealSize8.TabStop = true;
            this.rbtnRealSize8.Text = "8 байт";
            this.rbtnRealSize8.UseVisualStyleBackColor = true;
            // 
            // rbtnRealSize4
            // 
            this.rbtnRealSize4.AutoSize = true;
            this.rbtnRealSize4.Location = new System.Drawing.Point(7, 23);
            this.rbtnRealSize4.Name = "rbtnRealSize4";
            this.rbtnRealSize4.Size = new System.Drawing.Size(65, 19);
            this.rbtnRealSize4.TabIndex = 0;
            this.rbtnRealSize4.TabStop = true;
            this.rbtnRealSize4.Text = "4 байта";
            this.rbtnRealSize4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя типа";
            // 
            // tbTypeName
            // 
            this.tbTypeName.Location = new System.Drawing.Point(12, 322);
            this.tbTypeName.Name = "tbTypeName";
            this.tbTypeName.PlaceholderText = "TypeName";
            this.tbTypeName.Size = new System.Drawing.Size(200, 23);
            this.tbTypeName.TabIndex = 2;
            // 
            // Значение
            // 
            this.Значение.AutoSize = true;
            this.Значение.Location = new System.Drawing.Point(11, 348);
            this.Значение.Name = "Значение";
            this.Значение.Size = new System.Drawing.Size(60, 15);
            this.Значение.TabIndex = 3;
            this.Значение.Text = "Значение";
            // 
            // tbTypeValue
            // 
            this.tbTypeValue.Location = new System.Drawing.Point(12, 366);
            this.tbTypeValue.Name = "tbTypeValue";
            this.tbTypeValue.PlaceholderText = "value";
            this.tbTypeValue.Size = new System.Drawing.Size(201, 23);
            this.tbTypeValue.TabIndex = 4;
            // 
            // grbNumberWholeParams
            // 
            this.grbNumberWholeParams.Controls.Add(this.cbWholeSigned);
            this.grbNumberWholeParams.Controls.Add(this.grbWholeSize);
            this.grbNumberWholeParams.Location = new System.Drawing.Point(12, 119);
            this.grbNumberWholeParams.Name = "grbNumberWholeParams";
            this.grbNumberWholeParams.Size = new System.Drawing.Size(427, 168);
            this.grbNumberWholeParams.TabIndex = 5;
            this.grbNumberWholeParams.TabStop = false;
            this.grbNumberWholeParams.Text = "Параметры целого числа";
            // 
            // cbWholeSigned
            // 
            this.cbWholeSigned.AutoSize = true;
            this.cbWholeSigned.Location = new System.Drawing.Point(227, 34);
            this.cbWholeSigned.Name = "cbWholeSigned";
            this.cbWholeSigned.Size = new System.Drawing.Size(78, 19);
            this.cbWholeSigned.TabIndex = 1;
            this.cbWholeSigned.Text = "Знаковое";
            this.cbWholeSigned.UseVisualStyleBackColor = true;
            // 
            // grbWholeSize
            // 
            this.grbWholeSize.Controls.Add(this.rbtWholeSize8);
            this.grbWholeSize.Controls.Add(this.rbtWholeSize4);
            this.grbWholeSize.Controls.Add(this.rbtWholeSize2);
            this.grbWholeSize.Controls.Add(this.rbtWholeSize1);
            this.grbWholeSize.Location = new System.Drawing.Point(15, 23);
            this.grbWholeSize.Name = "grbWholeSize";
            this.grbWholeSize.Size = new System.Drawing.Size(200, 131);
            this.grbWholeSize.TabIndex = 0;
            this.grbWholeSize.TabStop = false;
            this.grbWholeSize.Text = "Размер типа";
            // 
            // rbtWholeSize8
            // 
            this.rbtWholeSize8.AutoSize = true;
            this.rbtWholeSize8.Location = new System.Drawing.Point(7, 102);
            this.rbtWholeSize8.Name = "rbtWholeSize8";
            this.rbtWholeSize8.Size = new System.Drawing.Size(59, 19);
            this.rbtWholeSize8.TabIndex = 3;
            this.rbtWholeSize8.Text = "8 байт";
            this.rbtWholeSize8.UseVisualStyleBackColor = true;
            // 
            // rbtWholeSize4
            // 
            this.rbtWholeSize4.AutoSize = true;
            this.rbtWholeSize4.Location = new System.Drawing.Point(7, 76);
            this.rbtWholeSize4.Name = "rbtWholeSize4";
            this.rbtWholeSize4.Size = new System.Drawing.Size(65, 19);
            this.rbtWholeSize4.TabIndex = 2;
            this.rbtWholeSize4.Text = "4 байта";
            this.rbtWholeSize4.UseVisualStyleBackColor = true;
            // 
            // rbtWholeSize2
            // 
            this.rbtWholeSize2.AutoSize = true;
            this.rbtWholeSize2.Location = new System.Drawing.Point(7, 50);
            this.rbtWholeSize2.Name = "rbtWholeSize2";
            this.rbtWholeSize2.Size = new System.Drawing.Size(65, 19);
            this.rbtWholeSize2.TabIndex = 1;
            this.rbtWholeSize2.Text = "2 байта";
            this.rbtWholeSize2.UseVisualStyleBackColor = true;
            // 
            // rbtWholeSize1
            // 
            this.rbtWholeSize1.AutoSize = true;
            this.rbtWholeSize1.Checked = true;
            this.rbtWholeSize1.Location = new System.Drawing.Point(7, 23);
            this.rbtWholeSize1.Name = "rbtWholeSize1";
            this.rbtWholeSize1.Size = new System.Drawing.Size(59, 19);
            this.rbtWholeSize1.TabIndex = 0;
            this.rbtWholeSize1.TabStop = true;
            this.rbtWholeSize1.Text = "1 байт";
            this.rbtWholeSize1.UseVisualStyleBackColor = true;
            // 
            // cbBooleanValue
            // 
            this.cbBooleanValue.FormattingEnabled = true;
            this.cbBooleanValue.Items.AddRange(new object[] {
            "true",
            "false"});
            this.cbBooleanValue.Location = new System.Drawing.Point(13, 366);
            this.cbBooleanValue.Name = "cbBooleanValue";
            this.cbBooleanValue.Size = new System.Drawing.Size(200, 23);
            this.cbBooleanValue.TabIndex = 6;
            this.cbBooleanValue.Visible = false;
            // 
            // FormInDepDataTypeConsructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 450);
            this.Controls.Add(this.cbBooleanValue);
            this.Controls.Add(this.grbNumberWholeParams);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTypeName);
            this.Controls.Add(this.Значение);
            this.Controls.Add(this.tbTypeValue);
            this.Controls.Add(this.grbNumberClass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreateScalar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbRealTypeParams);
            this.Name = "FormInDepDataTypeConsructor";
            this.Text = "Создать новый независимый тип";
            this.Load += new System.EventHandler(this.FormInDepDataTypeConsructor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbNumberClass.ResumeLayout(false);
            this.grbNumberClass.PerformLayout();
            this.grbRealTypeParams.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbNumberWholeParams.ResumeLayout(false);
            this.grbNumberWholeParams.PerformLayout();
            this.grbWholeSize.ResumeLayout(false);
            this.grbWholeSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnScalarBoolean;
        private System.Windows.Forms.RadioButton rbtnScalarCharacter;
        private System.Windows.Forms.RadioButton rbtnScalarNumber;
        private System.Windows.Forms.Button btnCreateScalar;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grbNumberClass;
        private System.Windows.Forms.RadioButton rbtnWholeNumber;
        private System.Windows.Forms.RadioButton rbtnRealNumber;
        private System.Windows.Forms.GroupBox grbRealTypeParams;
        private System.Windows.Forms.TextBox tbTypeValue;
        private System.Windows.Forms.Label Значение;
        private System.Windows.Forms.TextBox tbTypeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnRealSize8;
        private System.Windows.Forms.RadioButton rbtnRealSize4;
        private System.Windows.Forms.GroupBox grbNumberWholeParams;
        private System.Windows.Forms.CheckBox cbWholeSigned;
        private System.Windows.Forms.GroupBox grbWholeSize;
        private System.Windows.Forms.RadioButton rbtWholeSize8;
        private System.Windows.Forms.RadioButton rbtWholeSize4;
        private System.Windows.Forms.RadioButton rbtWholeSize2;
        private System.Windows.Forms.RadioButton rbtWholeSize1;
        private System.Windows.Forms.ComboBox cbBooleanValue;
    }
}