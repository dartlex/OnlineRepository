using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void ShowQuestionsButton_Click(object sender, EventArgs e)
        {
            var questionsForm = new QuestionsForm();
            questionsForm.ShowDialog();
        }

        private void showResultsButton_Click(object sender, EventArgs e)
        {
            var resultsForm = new ResultForm();
            resultsForm.ShowDialog();
        }

    }
}
