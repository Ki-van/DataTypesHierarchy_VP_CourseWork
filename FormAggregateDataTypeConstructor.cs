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
    public partial class FormAggregateDataTypeConstructor : Form
    {
        public FormAggregateDataTypeConstructor()
        {
            InitializeComponent();
        }

        private void FormAggregateDataTypeConstructor_Load(object sender, EventArgs e)
        {
            foreach (var type in DataTypes.dataTypes)
                listBoxAvailableComponents.Items.Add(type);
            listBoxAvailableComponents.DisplayMember = "Name";

            listBoxIncludedComponents.DisplayMember = "Name";
        }

        private void btnAddComponent_Click(object sender, EventArgs e)
        {
            DataType addedItem = (DataType) listBoxAvailableComponents.SelectedItem;
            
            if(addedItem != null)
            {
                listBoxAvailableComponents.Items.RemoveAt(listBoxAvailableComponents.SelectedIndex);
                listBoxIncludedComponents.Items.Add(addedItem);
                listBoxAvailableComponents.Refresh();
                listBoxIncludedComponents.Refresh();
            }
        }

        private void btnRemoveComponent_Click(object sender, EventArgs e)
        {
            DataType removedItem = (DataType)listBoxIncludedComponents.SelectedItem;

            if (removedItem != null)
            {
                listBoxIncludedComponents.Items.RemoveAt(listBoxIncludedComponents.SelectedIndex);
                listBoxAvailableComponents.Items.Add(removedItem);
                listBoxAvailableComponents.Refresh();
                listBoxIncludedComponents.Refresh();
            }
        }

        private void btnCreateType_Click(object sender, EventArgs e)
        {
            if (listBoxIncludedComponents.Items.Count == 0)
                MessageBox.Show("Число компонентов должно быть больше одного");
            else if(tbTypeName.Text == "")
                MessageBox.Show("Введите имя типа");
            else
            {
                List<DataType> components = new();
                foreach (var item in listBoxIncludedComponents.Items)
                    components.Add((DataType)item);
                try
                {
                    AggregateType aggregateType = new(tbTypeName.Text, components);
                    DataTypes.dataTypes.Add(aggregateType);
                    DialogResult = DialogResult.OK;
                    Close();
                }catch(Exception error)
                {

                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
