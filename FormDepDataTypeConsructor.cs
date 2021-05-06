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
    public partial class FormDepDataTypeConsructor : Form
    {
        public FormDepDataTypeConsructor()
        {
            InitializeComponent();
        }

        private void FormDepDataTypeConsructor_Load(object sender, EventArgs e)
        {
            listBoxTypes.DataSource = DataTypes.dataTypes;
            listBoxTypes.DisplayMember = "Name";
        }

        private void btnCreateType_Click(object sender, EventArgs e)
        {
            DataType pointedTo = (DataType) listBoxTypes.SelectedItem;
            if (pointedTo != null)
            {
                try
                {
                    DependentScalar dependentScalar = new("Указатель на " + pointedTo.Name, pointedTo.GetType(), pointedTo);
                    DataTypes.dataTypes.Add(dependentScalar);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
