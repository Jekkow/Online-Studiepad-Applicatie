using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Studiepad.GUI
{
    public partial class StudyCourse : Form
    {

        Logic.StudyCourse studyCourse = new Logic.StudyCourse(null, null);
        public StudyCourse()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (RadioButtonDeny.Checked && string.IsNullOrWhiteSpace(TextBoxNote.Text))
            {
                LabelErrorMessage.Visible = true;
            }
            else
            {
                studyCourse.ExamineStudyCourse(RadioButtonAprrove.Checked, TextBoxNote.Text);
            }
        }

        private void RadioButtonAprrove_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxNote.Enabled = false;
        }

        private void RadioButtonDeny_CheckedChanged(object sender, EventArgs e)
        {
            TextBoxNote.Enabled = true;
        }

        private void TextBoxNote_TextChanged(object sender, EventArgs e)
        {
            LabelErrorMessage.Visible = false;
        }
    }
}
