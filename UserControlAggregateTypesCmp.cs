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
    public partial class UserControlAggregateTypesCmp : UserControl
    {
        AggregateType obj1 = null, obj2 = null;
        public UserControlAggregateTypesCmp()
        {
            InitializeComponent();
        }

        private void gbObject1_DragDrop(object sender, DragEventArgs e)
        {
            obj1 = (AggregateType) e.Data.GetData(typeof(AggregateType));
            gbObject1.Text = obj1.Name;
            TypeSize1.Text = obj1.Size.ToString() + " байт";

            cmpAggreagates();
        }
        private void cmpAggreagates()
        {
            if(obj1 != null && obj2 != null)
            {
                if (obj1.Size > obj2.Size)
                    cmpResult.Text = ">";
                if (obj1.Size < obj2.Size)
                    cmpResult.Text = "<";
                if (obj1.Size == obj2.Size)
                    cmpResult.Text = "=";
            }
        }

        private void UserControlAggregateTypesCmp_DragEnter(object sender, DragEventArgs e) { }

        private void gbObject1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(AggregateType)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void gbObject2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(AggregateType)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void gbObject2_DragDrop(object sender, DragEventArgs e)
        {
            obj2 = (AggregateType)e.Data.GetData(typeof(AggregateType));
            gbObject2.Text = obj2.Name;
            TypeSize2.Text = obj2.Size.ToString() + " байт";

            cmpAggreagates();
        }

        private void UserControlAggregateTypesCmp_Load(object sender, EventArgs e)
        {
            gbObject1.AllowDrop = true;
            gbObject2.AllowDrop = true;
        }
    }
}
