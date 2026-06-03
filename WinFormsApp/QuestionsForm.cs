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
    public partial class QuestionsForm : Form
    {
        public QuestionsForm()
        {
            InitializeComponent();
        }

        private void QuestionsForm_Load(object sender, EventArgs e)
        {
            questionsDataGridView.AllowUserToAddRows = false;

            var questions = QuestionsStorage.GetAll();
            foreach (var question in questions)
            {
                questionsDataGridView.Rows.Add(question.Text);
            }
        }

        private void addQuestionButton_Click(object sender, EventArgs e)
        {
            var addQuestionForm = new AddQuestionForm();
            if (addQuestionForm.ShowDialog() == DialogResult.OK)
            {
                var question = new Question(addQuestionForm.addQuestionTextBox.Text, Convert.ToInt32(addQuestionForm.addAnswerTextBox.Text));
                QuestionsStorage.Add(question);
                questionsDataGridView.Rows.Clear();
                var questions = QuestionsStorage.GetAll();
                foreach (var q in questions)
                {
                    questionsDataGridView.Rows.Add(q.Text);
                }
            }

        }

        private void removeQuestionButton_Click(object sender, EventArgs e)
        {
            if (questionsDataGridView.CurrentRow != null)
            {
                string questionText = questionsDataGridView.CurrentRow.Cells[0].Value?.ToString();

                if (!string.IsNullOrEmpty(questionText))
                {
                    DialogResult confirm = MessageBox.Show(
                        "Вы уверены, что хотите удалить этот вопрос?",
                        "Подтверждение удаления",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );
                    if (confirm == DialogResult.No)
                    {
                        return;
                    }
                    var allQuestions = QuestionsStorage.GetAll();
                    Question question = null;
                    foreach (var q in allQuestions)
                    {
                        if (q.Text == questionText)
                        {
                            question = q;
                            break;
                        }
                    }
                    QuestionsStorage.Remove(question);

                    // Обновление таблицы
                    questionsDataGridView.Rows.Clear();
                    var questions = QuestionsStorage.GetAll();
                    foreach (var q in questions)
                    {
                        questionsDataGridView.Rows.Add(q.Text);
                    }
                }
            }
        }
    }
}
