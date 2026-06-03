using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class AddQuestionForm : Form
    {
        
        public AddQuestionForm()
        {
            InitializeComponent();
        }

        private void closeAddQuestionButton_Click(object sender, EventArgs e)
        {
            var parsed = InputValidator.TryParseToNumber(addAnswerTextBox.Text, out int userAnswer, out string errorMessage);
            if (!parsed)
            {
                MessageBox.Show(errorMessage);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
