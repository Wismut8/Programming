namespace Programming.Controls
{
    partial class ClassesControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            FilmGroupBox = new GroupBox();
            FindMaxRatingButton = new Button();
            RatingTextBox = new TextBox();
            label5 = new Label();
            GenreTextBox = new TextBox();
            GenreLabel = new Label();
            IssueTextBox = new TextBox();
            IssueLabel = new Label();
            DurationTextBox = new TextBox();
            DurationLabel = new Label();
            NameTextBox = new TextBox();
            NameLabel = new Label();
            FilmsListBox = new ListBox();
            RectanglesGroupBox = new GroupBox();
            IdTextBox = new TextBox();
            label3 = new Label();
            yTextBox = new TextBox();
            label2 = new Label();
            xTextBox = new TextBox();
            label1 = new Label();
            CoordinatesLabel = new Label();
            FindButton = new Button();
            WidthTextBox = new TextBox();
            WidthLabel = new Label();
            LenghtTextBox = new TextBox();
            LengthLabel = new Label();
            RectanglesListBox = new ListBox();
            FilmGroupBox.SuspendLayout();
            RectanglesGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // FilmGroupBox
            // 
            FilmGroupBox.Controls.Add(FindMaxRatingButton);
            FilmGroupBox.Controls.Add(RatingTextBox);
            FilmGroupBox.Controls.Add(label5);
            FilmGroupBox.Controls.Add(GenreTextBox);
            FilmGroupBox.Controls.Add(GenreLabel);
            FilmGroupBox.Controls.Add(IssueTextBox);
            FilmGroupBox.Controls.Add(IssueLabel);
            FilmGroupBox.Controls.Add(DurationTextBox);
            FilmGroupBox.Controls.Add(DurationLabel);
            FilmGroupBox.Controls.Add(NameTextBox);
            FilmGroupBox.Controls.Add(NameLabel);
            FilmGroupBox.Controls.Add(FilmsListBox);
            FilmGroupBox.Location = new Point(455, 3);
            FilmGroupBox.Name = "FilmGroupBox";
            FilmGroupBox.Size = new Size(456, 306);
            FilmGroupBox.TabIndex = 3;
            FilmGroupBox.TabStop = false;
            FilmGroupBox.Text = "Films";
            // 
            // FindMaxRatingButton
            // 
            FindMaxRatingButton.Location = new Point(6, 262);
            FindMaxRatingButton.Name = "FindMaxRatingButton";
            FindMaxRatingButton.Size = new Size(173, 29);
            FindMaxRatingButton.TabIndex = 11;
            FindMaxRatingButton.Text = "Find";
            FindMaxRatingButton.UseVisualStyleBackColor = true;
            FindMaxRatingButton.Click += FindMaxRatingButton_Click;
            // 
            // RatingTextBox
            // 
            RatingTextBox.Location = new Point(185, 263);
            RatingTextBox.Name = "RatingTextBox";
            RatingTextBox.Size = new Size(131, 27);
            RatingTextBox.TabIndex = 10;
            RatingTextBox.TextChanged += RatingTextBox_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(182, 238);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 9;
            label5.Text = "Rating:";
            // 
            // GenreTextBox
            // 
            GenreTextBox.Location = new Point(185, 208);
            GenreTextBox.Name = "GenreTextBox";
            GenreTextBox.Size = new Size(131, 27);
            GenreTextBox.TabIndex = 8;
            GenreTextBox.TextChanged += GenreTextBox_TextChanged;
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(182, 185);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(51, 20);
            GenreLabel.TabIndex = 7;
            GenreLabel.Text = "Genre:";
            // 
            // IssueTextBox
            // 
            IssueTextBox.Location = new Point(185, 155);
            IssueTextBox.Name = "IssueTextBox";
            IssueTextBox.Size = new Size(131, 27);
            IssueTextBox.TabIndex = 6;
            IssueTextBox.TextChanged += IssueTextBox_TextChanged;
            // 
            // IssueLabel
            // 
            IssueLabel.AutoSize = true;
            IssueLabel.Location = new Point(182, 132);
            IssueLabel.Name = "IssueLabel";
            IssueLabel.Size = new Size(94, 20);
            IssueLabel.TabIndex = 5;
            IssueLabel.Text = "Year of issue:";
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(185, 102);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(131, 27);
            DurationTextBox.TabIndex = 4;
            DurationTextBox.TextChanged += DurationTextBox_TextChanged;
            // 
            // DurationLabel
            // 
            DurationLabel.AutoSize = true;
            DurationLabel.Location = new Point(182, 79);
            DurationLabel.Name = "DurationLabel";
            DurationLabel.Size = new Size(142, 20);
            DurationLabel.TabIndex = 3;
            DurationLabel.Text = "Duration in minutes:";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(185, 49);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(131, 27);
            NameTextBox.TabIndex = 2;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(182, 26);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(52, 20);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "Name:";
            // 
            // FilmsListBox
            // 
            FilmsListBox.FormattingEnabled = true;
            FilmsListBox.ItemHeight = 20;
            FilmsListBox.Items.AddRange(new object[] { "Film 1", "Film 2", "Film 3", "Film 4", "Film 5" });
            FilmsListBox.Location = new Point(6, 26);
            FilmsListBox.Name = "FilmsListBox";
            FilmsListBox.Size = new Size(173, 224);
            FilmsListBox.TabIndex = 0;
            FilmsListBox.SelectedIndexChanged += FilmsListBox_SelectedIndexChanged;
            // 
            // RectanglesGroupBox
            // 
            RectanglesGroupBox.Controls.Add(IdTextBox);
            RectanglesGroupBox.Controls.Add(label3);
            RectanglesGroupBox.Controls.Add(yTextBox);
            RectanglesGroupBox.Controls.Add(label2);
            RectanglesGroupBox.Controls.Add(xTextBox);
            RectanglesGroupBox.Controls.Add(label1);
            RectanglesGroupBox.Controls.Add(CoordinatesLabel);
            RectanglesGroupBox.Controls.Add(FindButton);
            RectanglesGroupBox.Controls.Add(WidthTextBox);
            RectanglesGroupBox.Controls.Add(WidthLabel);
            RectanglesGroupBox.Controls.Add(LenghtTextBox);
            RectanglesGroupBox.Controls.Add(LengthLabel);
            RectanglesGroupBox.Controls.Add(RectanglesListBox);
            RectanglesGroupBox.Location = new Point(5, 3);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(444, 306);
            RectanglesGroupBox.TabIndex = 2;
            RectanglesGroupBox.TabStop = false;
            RectanglesGroupBox.Text = "Rectangles";
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Location = new Point(228, 143);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(27, 27);
            IdTextBox.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(195, 146);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 2;
            label3.Text = "ID:";
            // 
            // yTextBox
            // 
            yTextBox.Enabled = false;
            yTextBox.Location = new Point(288, 208);
            yTextBox.Name = "yTextBox";
            yTextBox.Size = new Size(38, 27);
            yTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 211);
            label2.Name = "label2";
            label2.Size = new Size(20, 20);
            label2.TabIndex = 2;
            label2.Text = "Y:";
            // 
            // xTextBox
            // 
            xTextBox.Enabled = false;
            xTextBox.Location = new Point(216, 208);
            xTextBox.Name = "xTextBox";
            xTextBox.Size = new Size(40, 27);
            xTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 211);
            label1.Name = "label1";
            label1.Size = new Size(21, 20);
            label1.TabIndex = 2;
            label1.Text = "X:";
            // 
            // CoordinatesLabel
            // 
            CoordinatesLabel.AutoSize = true;
            CoordinatesLabel.Location = new Point(194, 185);
            CoordinatesLabel.Name = "CoordinatesLabel";
            CoordinatesLabel.Size = new Size(55, 20);
            CoordinatesLabel.TabIndex = 2;
            CoordinatesLabel.Text = "Center:";
            // 
            // FindButton
            // 
            FindButton.Location = new Point(195, 259);
            FindButton.Name = "FindButton";
            FindButton.Size = new Size(131, 31);
            FindButton.TabIndex = 1;
            FindButton.Text = "Find";
            FindButton.UseVisualStyleBackColor = true;
            FindButton.Click += FindButton_Click;
            // 
            // WidthTextBox
            // 
            WidthTextBox.Location = new Point(195, 102);
            WidthTextBox.Name = "WidthTextBox";
            WidthTextBox.Size = new Size(131, 27);
            WidthTextBox.TabIndex = 1;
            WidthTextBox.TextChanged += WidthTextBox_TextChanged;
            // 
            // WidthLabel
            // 
            WidthLabel.AutoSize = true;
            WidthLabel.Location = new Point(192, 79);
            WidthLabel.Name = "WidthLabel";
            WidthLabel.Size = new Size(52, 20);
            WidthLabel.TabIndex = 1;
            WidthLabel.Text = "Width:";
            // 
            // LenghtTextBox
            // 
            LenghtTextBox.Location = new Point(195, 49);
            LenghtTextBox.Name = "LenghtTextBox";
            LenghtTextBox.Size = new Size(131, 27);
            LenghtTextBox.TabIndex = 1;
            LenghtTextBox.TextChanged += LenghtTextBox_TextChanged;
            // 
            // LengthLabel
            // 
            LengthLabel.AutoSize = true;
            LengthLabel.Location = new Point(192, 26);
            LengthLabel.Name = "LengthLabel";
            LengthLabel.Size = new Size(57, 20);
            LengthLabel.TabIndex = 1;
            LengthLabel.Text = "Lenght:";
            // 
            // RectanglesListBox
            // 
            RectanglesListBox.FormattingEnabled = true;
            RectanglesListBox.ItemHeight = 20;
            RectanglesListBox.Items.AddRange(new object[] { "Rectangle 1", "Rectangle 2", "Rectangle 3", "Rectangle 4", "Rectangle 5" });
            RectanglesListBox.Location = new Point(6, 26);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(173, 264);
            RectanglesListBox.TabIndex = 1;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged;
            // 
            // ClassesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(FilmGroupBox);
            Controls.Add(RectanglesGroupBox);
            Name = "ClassesControl";
            Size = new Size(916, 470);
            Load += ClassesControl_Load;
            FilmGroupBox.ResumeLayout(false);
            FilmGroupBox.PerformLayout();
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox FilmGroupBox;
        private Button FindMaxRatingButton;
        private TextBox RatingTextBox;
        private Label label5;
        private TextBox GenreTextBox;
        private Label GenreLabel;
        private TextBox IssueTextBox;
        private Label IssueLabel;
        private TextBox DurationTextBox;
        private Label DurationLabel;
        private TextBox NameTextBox;
        private Label NameLabel;
        private ListBox FilmsListBox;
        private GroupBox RectanglesGroupBox;
        private TextBox IdTextBox;
        private Label label3;
        private TextBox yTextBox;
        private Label label2;
        private TextBox xTextBox;
        private Label label1;
        private Label CoordinatesLabel;
        private Button FindButton;
        private TextBox WidthTextBox;
        private Label WidthLabel;
        private TextBox LenghtTextBox;
        private Label LengthLabel;
        private ListBox RectanglesListBox;
    }
}
