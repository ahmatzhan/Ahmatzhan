
namespace LibraryVisual
{
    partial class LibraryForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AllBookComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usersComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBookButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateToBack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userBookComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.RemoveBookButton = new System.Windows.Forms.Button();
            this.UpdateBox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AllBookComboBox
            // 
            this.AllBookComboBox.FormattingEnabled = true;
            this.AllBookComboBox.Location = new System.Drawing.Point(105, 93);
            this.AllBookComboBox.Name = "AllBookComboBox";
            this.AllBookComboBox.Size = new System.Drawing.Size(121, 21);
            this.AllBookComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Книги";
            // 
            // usersComboBox
            // 
            this.usersComboBox.FormattingEnabled = true;
            this.usersComboBox.Location = new System.Drawing.Point(286, 93);
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(121, 21);
            this.usersComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Посетители";
            // 
            // AddBookButton
            // 
            this.AddBookButton.Location = new System.Drawing.Point(184, 173);
            this.AddBookButton.Name = "AddBookButton";
            this.AddBookButton.Size = new System.Drawing.Size(137, 37);
            this.AddBookButton.TabIndex = 4;
            this.AddBookButton.Text = "Взял книгу";
            this.AddBookButton.UseVisualStyleBackColor = true;
            this.AddBookButton.Click += new System.EventHandler(this.AddBookButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(148, 137);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "До какого числа вернут";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookName,
            this.UserBook,
            this.DateToBack,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(452, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 376);
            this.dataGridView1.TabIndex = 7;
            // 
            // BookName
            // 
            this.BookName.HeaderText = "Книга";
            this.BookName.Name = "BookName";
            // 
            // UserBook
            // 
            this.UserBook.HeaderText = "Посетитель";
            this.UserBook.Name = "UserBook";
            // 
            // DateToBack
            // 
            this.DateToBack.HeaderText = "Дата";
            this.DateToBack.Name = "DateToBack";
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            // 
            // userBookComboBox
            // 
            this.userBookComboBox.FormattingEnabled = true;
            this.userBookComboBox.Location = new System.Drawing.Point(195, 242);
            this.userBookComboBox.Name = "userBookComboBox";
            this.userBookComboBox.Size = new System.Drawing.Size(121, 21);
            this.userBookComboBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Книги";
            // 
            // RemoveBookButton
            // 
            this.RemoveBookButton.Location = new System.Drawing.Point(184, 278);
            this.RemoveBookButton.Name = "RemoveBookButton";
            this.RemoveBookButton.Size = new System.Drawing.Size(137, 42);
            this.RemoveBookButton.TabIndex = 11;
            this.RemoveBookButton.Text = "Возврат книги";
            this.RemoveBookButton.UseVisualStyleBackColor = true;
            this.RemoveBookButton.Click += new System.EventHandler(this.RemoveBookButton_Click);
            // 
            // UpdateBox
            // 
            this.UpdateBox.Location = new System.Drawing.Point(820, 20);
            this.UpdateBox.Name = "UpdateBox";
            this.UpdateBox.Size = new System.Drawing.Size(75, 23);
            this.UpdateBox.TabIndex = 12;
            this.UpdateBox.Text = "Обновить";
            this.UpdateBox.UseVisualStyleBackColor = true;
            this.UpdateBox.Click += new System.EventHandler(this.UpdateBox_Click);
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 462);
            this.Controls.Add(this.UpdateBox);
            this.Controls.Add(this.RemoveBookButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.userBookComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.AddBookButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.usersComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AllBookComboBox);
            this.Name = "LibraryForm";
            this.Text = "Библиотека";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox AllBookComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox usersComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddBookButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox userBookComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RemoveBookButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateToBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button UpdateBox;
    }
}

