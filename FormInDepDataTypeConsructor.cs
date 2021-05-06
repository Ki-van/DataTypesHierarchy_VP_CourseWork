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
    public partial class FormInDepDataTypeConsructor : Form
    {
        public FormInDepDataTypeConsructor()
        {
            InitializeComponent();
        }

        private void grbRealTypeParams_Enter(object sender, EventArgs e)
        {

        }

        private void btnCreateScalar_Click(object sender, EventArgs e)
        {
            if (tbTypeName.Text == "" || (tbTypeValue.Text == "" && !rbtnScalarBoolean.Checked))
            {
                MessageBox.Show("Заполните пустые поля", "Неточность", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (rbtnScalarNumber.Checked)
            {
                try
                {
                    uint size;
                    if (rbtnRealNumber.Checked)
                    {

                        if (rbtnRealSize4.Checked)
                            size = 4;
                        else
                            size = 8;

                        Number number = new Number(true, size, tbTypeName.Text, Decimal.Parse(tbTypeValue.Text));
                        DataTypes.dataTypes.Add(number);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else if (rbtnWholeNumber.Checked)
                    {
                        if (rbtWholeSize1.Checked)
                            size = 1;
                        else if (rbtWholeSize2.Checked)
                            size = 2;
                        else if (rbtWholeSize4.Checked)
                            size = 4;
                        else 
                            size = 8;

                        Number number = new Number(cbWholeSigned.Checked, false, size, tbTypeName.Text, Decimal.Parse(tbTypeValue.Text));
                        DataTypes.dataTypes.Add(number);
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Недопустимое значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Слишком большое значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else if (rbtnScalarCharacter.Checked)
            {
                try
                {
                    Character character = new Character(tbTypeName.Text, Char.Parse(tbTypeValue.Text));
                    DataTypes.dataTypes.Add(character);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Недопустимое значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else if (rbtnScalarBoolean.Checked)
            {
                try
                {
                    Boolean boolean = new Boolean(tbTypeName.Text, (cbBooleanValue.SelectedItem.ToString() == "true")?true:false);
                    DataTypes.dataTypes.Add(boolean);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Недопустимое значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void FormInDepDataTypeConsructor_Load(object sender, EventArgs e)
        {
            grbNumberWholeParams.Visible = false;
            rbtnRealSize4.Checked = true;
            cbBooleanValue.SelectedIndex = 0;
        }

        private void rbtnRealNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnRealNumber.Checked)
                grbRealTypeParams.Visible = true;
            else
                grbRealTypeParams.Visible = false;
        }

        private void rbtnWholeNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnWholeNumber.Checked)
                grbNumberWholeParams.Show();
            else
                grbNumberWholeParams.Hide();
        }

        private void rbtnScalarNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnScalarNumber.Checked)
            {
                grbNumberClass.Visible = true;
                rbtnRealNumber.Checked = true;
                grbRealTypeParams.Visible = true;
                grbNumberWholeParams.Visible = false;
            } else
            {
                grbNumberClass.Visible = false;
                grbNumberWholeParams.Visible = false;
                grbRealTypeParams.Visible = false;
            }
        }

        private void rbtnScalarBoolean_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnScalarBoolean.Checked)
            {
                cbBooleanValue.Visible = true;
                tbTypeValue.Visible = false;
            }
            else
            {
                cbBooleanValue.Visible = false;
                tbTypeValue.Visible = true;
            }
        }
    }
}
