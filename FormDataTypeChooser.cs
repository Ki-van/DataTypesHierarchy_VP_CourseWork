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
    public partial class FormDataTypeChooser : Form
    {
        public FormDataTypeChooser()
        {
            InitializeComponent();
        }

        private void btnCreateType_Click(object sender, EventArgs e)
        {
            
            if (rbtnInDependent.Checked)
            {
                FormInDepDataTypeConsructor formInDepDataTypeConsructor = new()
                {
                    Owner = this,
                    StartPosition = FormStartPosition.CenterParent
                };
                formInDepDataTypeConsructor.ShowDialog();

            }
            else if (rbtnDependent.Checked)
            {

            }
            else if (rbtnAggregate.Checked)
            {

            }
        }
    }
}