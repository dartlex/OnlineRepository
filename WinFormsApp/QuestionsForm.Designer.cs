namespace WinFormsApp
{
    partial class QuestionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            questionsDataGridView = new DataGridView();
            questionsColumn = new DataGridViewTextBoxColumn();
            addQuestionButton = new Button();
            removeQuestionButton = new Button();
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // questionsDataGridView
            // 
            questionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            questionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { questionsColumn });
            questionsDataGridView.Location = new Point(12, 12);
            questionsDataGridView.Name = "questionsDataGridView";
            questionsDataGridView.ReadOnly = true;
            questionsDataGridView.RowHeadersWidth = 62;
            questionsDataGridView.Size = new Size(776, 410);
            questionsDataGridView.TabIndex = 0;
            // 
            // questionsColumn
            // 
            questionsColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            questionsColumn.HeaderText = "Вопросы";
            questionsColumn.MinimumWidth = 8;
            questionsColumn.Name = "questionsColumn";
            questionsColumn.ReadOnly = true;
            // 
            // addQuestionButton
            // 
            addQuestionButton.Location = new Point(12, 428);
            addQuestionButton.Name = "addQuestionButton";
            addQuestionButton.Size = new Size(112, 34);
            addQuestionButton.TabIndex = 1;
            addQuestionButton.Text = "Добавить";
            addQuestionButton.UseVisualStyleBackColor = true;
            addQuestionButton.Click += addQuestionButton_Click;
            // 
            // removeQuestionButton
            // 
            removeQuestionButton.Location = new Point(138, 428);
            removeQuestionButton.Name = "removeQuestionButton";
            removeQuestionButton.Size = new Size(112, 34);
            removeQuestionButton.TabIndex = 2;
            removeQuestionButton.Text = "Удалить";
            removeQuestionButton.UseVisualStyleBackColor = true;
            removeQuestionButton.Click += removeQuestionButton_Click;
            // 
            // QuestionsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 474);
            Controls.Add(removeQuestionButton);
            Controls.Add(addQuestionButton);
            Controls.Add(questionsDataGridView);
            Name = "QuestionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QuestionsForm";
            Load += QuestionsForm_Load;
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView questionsDataGridView;
        private Button addQuestionButton;
        private Button removeQuestionButton;
        private DataGridViewTextBoxColumn questionsColumn;
    }
}