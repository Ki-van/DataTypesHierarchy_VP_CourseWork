using System;
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
    public partial class FormCloneType : Form
    {
        public FormCloneType()
        {
            InitializeComponent();
        }

        private void FormCloneType_Load(object sender, EventArgs e)
        {
            lbTypes.DataSource = DataTypes.dataTypes;
            lbTypes.DisplayMember = "Name";
        }

        private void btnCloneType_Click(object sender, EventArgs e)
        {
            DataType dataType = (DataType)lbTypes.SelectedItem;
            if (dataType != null)
            {
                try
                {
                    
                    DataTypes.dataTypes.Add((DataType)dataType.Clone());
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Выберите тип");
        }
    }
}
