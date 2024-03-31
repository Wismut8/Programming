namespace Programming.View
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            EnumsTabControl = new TabControl();
            Enums = new TabPage();
            SeasonGroupBox = new GroupBox();
            SeasonComboBox = new ComboBox();
            SeasonButton = new Button();
            ChooseSeasonLabel = new Label();
            ParsingGroupBox = new GroupBox();
            ParseCommentLabel = new Label();
            ParseButton = new Button();
            ValParseLabel = new Label();
            ParseTextBox = new TextBox();
            EnumerationsGroupBox = new GroupBox();
            IntValLabel = new Label();
            IntTextBox = new TextBox();
            ChooseValLabel = new Label();
            ChooseEnumLabel = new Label();
            ValuesListBox = new ListBox();
            EnumsListBox = new ListBox();
            Classes = new TabPage();
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
            Rectangles = new TabPage();
            RectanglesPanel = new Panel();
            HeightRecTextBox = new TextBox();
            label11 = new Label();
            WidthRecTextBox = new TextBox();
            label10 = new Label();
            YRecTextBox = new TextBox();
            label9 = new Label();
            XRecTextBox = new TextBox();
            label8 = new Label();
            IDRecTextBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            DeleteRecButton = new Button();
            AddRecButton = new Button();
            RecListBox = new ListBox();
            label4 = new Label();
            EnumsTabControl.SuspendLayout();
            Enums.SuspendLayout();
            SeasonGroupBox.SuspendLayout();
            ParsingGroupBox.SuspendLayout();
            EnumerationsGroupBox.SuspendLayout();
            Classes.SuspendLayout();
            FilmGroupBox.SuspendLayout();
            RectanglesGroupBox.SuspendLayout();
            Rectangles.SuspendLayout();
            SuspendLayout();
            // 
            // EnumsTabControl
            // 
            EnumsTabControl.Controls.Add(Enums);
            EnumsTabControl.Controls.Add(Classes);
            EnumsTabControl.Controls.Add(Rectangles);
            EnumsTabControl.Dock = DockStyle.Fill;
            EnumsTabControl.Location = new Point(0, 0);
            EnumsTabControl.Name = "EnumsTabControl";
            EnumsTabControl.SelectedIndex = 0;
            EnumsTabControl.Size = new Size(925, 614);
            EnumsTabControl.TabIndex = 0;
            // 
            // Enums
            // 
            Enums.Controls.Add(SeasonGroupBox);
            Enums.Controls.Add(ParsingGroupBox);
            Enums.Controls.Add(EnumerationsGroupBox);
            Enums.Location = new Point(4, 29);
            Enums.Name = "Enums";
            Enums.Padding = new Padding(3);
            Enums.Size = new Size(917, 581);
            Enums.TabIndex = 1;
            Enums.Text = "Enums";
            Enums.UseVisualStyleBackColor = true;
            // 
            // SeasonGroupBox
            // 
            SeasonGroupBox.Controls.Add(SeasonComboBox);
            SeasonGroupBox.Controls.Add(SeasonButton);
            SeasonGroupBox.Controls.Add(ChooseSeasonLabel);
            SeasonGroupBox.Location = new Point(462, 357);
            SeasonGroupBox.Name = "SeasonGroupBox";
            SeasonGroupBox.Size = new Size(452, 208);
            SeasonGroupBox.TabIndex = 2;
            SeasonGroupBox.TabStop = false;
            SeasonGroupBox.Text = "Season Handle";
            // 
            // SeasonComboBox
            // 
            SeasonComboBox.FormattingEnabled = true;
            SeasonComboBox.Items.AddRange(new object[] { "Winter", "Spring", "Summer", "Autumn" });
            SeasonComboBox.Location = new Point(6, 70);
            SeasonComboBox.Name = "SeasonComboBox";
            SeasonComboBox.Size = new Size(250, 28);
            SeasonComboBox.TabIndex = 3;
            // 
            // SeasonButton
            // 
            SeasonButton.Location = new Point(262, 70);
            SeasonButton.Name = "SeasonButton";
            SeasonButton.Size = new Size(94, 29);
            SeasonButton.TabIndex = 2;
            SeasonButton.Text = "Go!";
            SeasonButton.UseVisualStyleBackColor = true;
            SeasonButton.Click += SeasonButton_Click;
            // 
            // ChooseSeasonLabel
            // 
            ChooseSeasonLabel.AutoSize = true;
            ChooseSeasonLabel.Location = new Point(6, 47);
            ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            ChooseSeasonLabel.Size = new Size(110, 20);
            ChooseSeasonLabel.TabIndex = 1;
            ChooseSeasonLabel.Text = "Choose season:";
            // 
            // ParsingGroupBox
            // 
            ParsingGroupBox.Controls.Add(ParseCommentLabel);
            ParsingGroupBox.Controls.Add(ParseButton);
            ParsingGroupBox.Controls.Add(ValParseLabel);
            ParsingGroupBox.Controls.Add(ParseTextBox);
            ParsingGroupBox.Location = new Point(3, 357);
            ParsingGroupBox.Name = "ParsingGroupBox";
            ParsingGroupBox.Size = new Size(450, 208);
            ParsingGroupBox.TabIndex = 1;
            ParsingGroupBox.TabStop = false;
            ParsingGroupBox.Text = "Weekday Parsing:";
            // 
            // ParseCommentLabel
            // 
            ParseCommentLabel.AutoSize = true;
            ParseCommentLabel.ForeColor = SystemColors.ControlDarkDark;
            ParseCommentLabel.Location = new Point(6, 101);
            ParseCommentLabel.Name = "ParseCommentLabel";
            ParseCommentLabel.Size = new Size(18, 20);
            ParseCommentLabel.TabIndex = 2;
            ParseCommentLabel.Text = "...";
            // 
            // ParseButton
            // 
            ParseButton.Location = new Point(262, 69);
            ParseButton.Name = "ParseButton";
            ParseButton.Size = new Size(94, 29);
            ParseButton.TabIndex = 2;
            ParseButton.Text = "Parse";
            ParseButton.UseVisualStyleBackColor = true;
            ParseButton.Click += ParseButton_Click;
            // 
            // ValParseLabel
            // 
            ValParseLabel.AutoSize = true;
            ValParseLabel.Location = new Point(5, 48);
            ValParseLabel.Name = "ValParseLabel";
            ValParseLabel.Size = new Size(158, 20);
            ValParseLabel.TabIndex = 2;
            ValParseLabel.Text = "Type value for parsing:";
            // 
            // ParseTextBox
            // 
            ParseTextBox.Location = new Point(6, 70);
            ParseTextBox.Name = "ParseTextBox";
            ParseTextBox.Size = new Size(250, 27);
            ParseTextBox.TabIndex = 2;
            // 
            // EnumerationsGroupBox
            // 
            EnumerationsGroupBox.Controls.Add(IntValLabel);
            EnumerationsGroupBox.Controls.Add(IntTextBox);
            EnumerationsGroupBox.Controls.Add(ChooseValLabel);
            EnumerationsGroupBox.Controls.Add(ChooseEnumLabel);
            EnumerationsGroupBox.Controls.Add(ValuesListBox);
            EnumerationsGroupBox.Controls.Add(EnumsListBox);
            EnumerationsGroupBox.Dock = DockStyle.Top;
            EnumerationsGroupBox.Location = new Point(3, 3);
            EnumerationsGroupBox.Name = "EnumerationsGroupBox";
            EnumerationsGroupBox.Size = new Size(911, 348);
            EnumerationsGroupBox.TabIndex = 0;
            EnumerationsGroupBox.TabStop = false;
            EnumerationsGroupBox.Text = "Enumerations";
            // 
            // IntValLabel
            // 
            IntValLabel.AutoSize = true;
            IntValLabel.Location = new Point(411, 38);
            IntValLabel.Name = "IntValLabel";
            IntValLabel.Size = new Size(68, 20);
            IntValLabel.TabIndex = 5;
            IntValLabel.Text = "Int value:";
            // 
            // IntTextBox
            // 
            IntTextBox.Enabled = false;
            IntTextBox.Location = new Point(411, 61);
            IntTextBox.Name = "IntTextBox";
            IntTextBox.Size = new Size(125, 27);
            IntTextBox.TabIndex = 4;
            // 
            // ChooseValLabel
            // 
            ChooseValLabel.AutoSize = true;
            ChooseValLabel.Location = new Point(199, 38);
            ChooseValLabel.Name = "ChooseValLabel";
            ChooseValLabel.Size = new Size(101, 20);
            ChooseValLabel.TabIndex = 3;
            ChooseValLabel.Text = "Choose Value:";
            // 
            // ChooseEnumLabel
            // 
            ChooseEnumLabel.AutoSize = true;
            ChooseEnumLabel.Location = new Point(6, 38);
            ChooseEnumLabel.Name = "ChooseEnumLabel";
            ChooseEnumLabel.Size = new Size(149, 20);
            ChooseEnumLabel.TabIndex = 2;
            ChooseEnumLabel.Text = "Choose Enumeration:";
            // 
            // ValuesListBox
            // 
            ValuesListBox.FormattingEnabled = true;
            ValuesListBox.ItemHeight = 20;
            ValuesListBox.Location = new Point(199, 61);
            ValuesListBox.Name = "ValuesListBox";
            ValuesListBox.Size = new Size(191, 264);
            ValuesListBox.TabIndex = 1;
            ValuesListBox.SelectedIndexChanged += ValuesListBox_SelectedIndexChanged;
            // 
            // EnumsListBox
            // 
            EnumsListBox.FormattingEnabled = true;
            EnumsListBox.ItemHeight = 20;
            EnumsListBox.Location = new Point(6, 61);
            EnumsListBox.Name = "EnumsListBox";
            EnumsListBox.Size = new Size(183, 264);
            EnumsListBox.TabIndex = 0;
            EnumsListBox.SelectedIndexChanged += EnumsListBox_SelectedIndexChanged;
            // 
            // Classes
            // 
            Classes.Controls.Add(FilmGroupBox);
            Classes.Controls.Add(RectanglesGroupBox);
            Classes.Location = new Point(4, 29);
            Classes.Name = "Classes";
            Classes.Size = new Size(917, 581);
            Classes.TabIndex = 2;
            Classes.Text = "Classes";
            Classes.UseVisualStyleBackColor = true;
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
            FilmGroupBox.Location = new Point(458, 3);
            FilmGroupBox.Name = "FilmGroupBox";
            FilmGroupBox.Size = new Size(456, 306);
            FilmGroupBox.TabIndex = 1;
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
            RectanglesGroupBox.Location = new Point(8, 3);
            RectanglesGroupBox.Name = "RectanglesGroupBox";
            RectanglesGroupBox.Size = new Size(444, 306);
            RectanglesGroupBox.TabIndex = 0;
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
            yTextBox.Location = new Point(276, 208);
            yTextBox.Name = "yTextBox";
            yTextBox.Size = new Size(27, 27);
            yTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(250, 211);
            label2.Name = "label2";
            label2.Size = new Size(20, 20);
            label2.TabIndex = 2;
            label2.Text = "Y:";
            // 
            // xTextBox
            // 
            xTextBox.Location = new Point(216, 208);
            xTextBox.Name = "xTextBox";
            xTextBox.Size = new Size(27, 27);
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
            RectanglesListBox.Location = new Point(6, 26);
            RectanglesListBox.Name = "RectanglesListBox";
            RectanglesListBox.Size = new Size(173, 264);
            RectanglesListBox.TabIndex = 1;
            RectanglesListBox.SelectedIndexChanged += RectanglesListBox_SelectedIndexChanged_1;
            // 
            // Rectangles
            // 
            Rectangles.Controls.Add(RectanglesPanel);
            Rectangles.Controls.Add(HeightRecTextBox);
            Rectangles.Controls.Add(label11);
            Rectangles.Controls.Add(WidthRecTextBox);
            Rectangles.Controls.Add(label10);
            Rectangles.Controls.Add(YRecTextBox);
            Rectangles.Controls.Add(label9);
            Rectangles.Controls.Add(XRecTextBox);
            Rectangles.Controls.Add(label8);
            Rectangles.Controls.Add(IDRecTextBox);
            Rectangles.Controls.Add(label7);
            Rectangles.Controls.Add(label6);
            Rectangles.Controls.Add(DeleteRecButton);
            Rectangles.Controls.Add(AddRecButton);
            Rectangles.Controls.Add(RecListBox);
            Rectangles.Controls.Add(label4);
            Rectangles.Location = new Point(4, 29);
            Rectangles.Name = "Rectangles";
            Rectangles.Size = new Size(917, 581);
            Rectangles.TabIndex = 3;
            Rectangles.Text = "Rectangles";
            Rectangles.UseVisualStyleBackColor = true;
            // 
            // RectanglesPanel
            // 
            RectanglesPanel.Location = new Point(382, 37);
            RectanglesPanel.Name = "RectanglesPanel";
            RectanglesPanel.Size = new Size(515, 452);
            RectanglesPanel.TabIndex = 15;
            // 
            // HeightRecTextBox
            // 
            HeightRecTextBox.Location = new Point(83, 466);
            HeightRecTextBox.Name = "HeightRecTextBox";
            HeightRecTextBox.Size = new Size(125, 27);
            HeightRecTextBox.TabIndex = 14;
            HeightRecTextBox.TextChanged += HeightRecTextBox_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(20, 469);
            label11.Name = "label11";
            label11.Size = new Size(57, 20);
            label11.TabIndex = 13;
            label11.Text = "Height:";
            // 
            // WidthRecTextBox
            // 
            WidthRecTextBox.Location = new Point(83, 429);
            WidthRecTextBox.Name = "WidthRecTextBox";
            WidthRecTextBox.Size = new Size(125, 27);
            WidthRecTextBox.TabIndex = 12;
            WidthRecTextBox.TextChanged += WidthRecTextBox_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(25, 432);
            label10.Name = "label10";
            label10.Size = new Size(52, 20);
            label10.TabIndex = 11;
            label10.Text = "Width:";
            // 
            // YRecTextBox
            // 
            YRecTextBox.Enabled = false;
            YRecTextBox.Location = new Point(83, 396);
            YRecTextBox.Name = "YRecTextBox";
            YRecTextBox.Size = new Size(125, 27);
            YRecTextBox.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(57, 396);
            label9.Name = "label9";
            label9.Size = new Size(20, 20);
            label9.TabIndex = 9;
            label9.Text = "Y:";
            // 
            // XRecTextBox
            // 
            XRecTextBox.Enabled = false;
            XRecTextBox.Location = new Point(83, 363);
            XRecTextBox.Name = "XRecTextBox";
            XRecTextBox.Size = new Size(125, 27);
            XRecTextBox.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(56, 363);
            label8.Name = "label8";
            label8.Size = new Size(21, 20);
            label8.TabIndex = 7;
            label8.Text = "X:";
            // 
            // IDRecTextBox
            // 
            IDRecTextBox.Enabled = false;
            IDRecTextBox.Location = new Point(83, 330);
            IDRecTextBox.Name = "IDRecTextBox";
            IDRecTextBox.Size = new Size(125, 27);
            IDRecTextBox.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 333);
            label7.Name = "label7";
            label7.Size = new Size(27, 20);
            label7.TabIndex = 5;
            label7.Text = "ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 307);
            label6.Name = "label6";
            label6.Size = new Size(135, 20);
            label6.TabIndex = 4;
            label6.Text = "Selected rectangle:";
            // 
            // DeleteRecButton
            // 
            DeleteRecButton.BackColor = Color.White;
            DeleteRecButton.FlatAppearance.BorderSize = 0;
            DeleteRecButton.FlatStyle = FlatStyle.Flat;
            DeleteRecButton.Image = (Image)resources.GetObject("DeleteRecButton.Image");
            DeleteRecButton.Location = new Point(195, 247);
            DeleteRecButton.Name = "DeleteRecButton";
            DeleteRecButton.Size = new Size(171, 57);
            DeleteRecButton.TabIndex = 3;
            DeleteRecButton.UseVisualStyleBackColor = false;
            DeleteRecButton.Click += DeleteRecButton_Click;
            // 
            // AddRecButton
            // 
            AddRecButton.BackColor = Color.White;
            AddRecButton.FlatAppearance.BorderSize = 0;
            AddRecButton.FlatStyle = FlatStyle.Flat;
            AddRecButton.ForeColor = SystemColors.Control;
            AddRecButton.Image = (Image)resources.GetObject("AddRecButton.Image");
            AddRecButton.Location = new Point(20, 247);
            AddRecButton.Name = "AddRecButton";
            AddRecButton.Size = new Size(135, 57);
            AddRecButton.TabIndex = 2;
            AddRecButton.UseVisualStyleBackColor = false;
            AddRecButton.Click += AddRecButton_Click;
            // 
            // RecListBox
            // 
            RecListBox.FormattingEnabled = true;
            RecListBox.ItemHeight = 20;
            RecListBox.Location = new Point(20, 37);
            RecListBox.Name = "RecListBox";
            RecListBox.Size = new Size(346, 204);
            RecListBox.TabIndex = 1;
            RecListBox.SelectedIndexChanged += RecListBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 14);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 0;
            label4.Text = "Rectangles:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 614);
            Controls.Add(EnumsTabControl);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            EnumsTabControl.ResumeLayout(false);
            Enums.ResumeLayout(false);
            SeasonGroupBox.ResumeLayout(false);
            SeasonGroupBox.PerformLayout();
            ParsingGroupBox.ResumeLayout(false);
            ParsingGroupBox.PerformLayout();
            EnumerationsGroupBox.ResumeLayout(false);
            EnumerationsGroupBox.PerformLayout();
            Classes.ResumeLayout(false);
            FilmGroupBox.ResumeLayout(false);
            FilmGroupBox.PerformLayout();
            RectanglesGroupBox.ResumeLayout(false);
            RectanglesGroupBox.PerformLayout();
            Rectangles.ResumeLayout(false);
            Rectangles.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl EnumsTabControl;
        private TabPage Enums;
        private GroupBox EnumerationsGroupBox;
        private GroupBox ParsingGroupBox;
        private Label IntValLabel;
        private TextBox IntTextBox;
        private Label ChooseValLabel;
        private Label ChooseEnumLabel;
        private ListBox ValuesListBox;
        private ListBox EnumsListBox;
        private Label ParseCommentLabel;
        private Button ParseButton;
        private Label ValParseLabel;
        private TextBox ParseTextBox;
        private GroupBox SeasonGroupBox;
        private Label ChooseSeasonLabel;
        private Button SeasonButton;
        private ComboBox SeasonComboBox;
        private TabPage Classes;
        private GroupBox RectanglesGroupBox;
        private Button FindButton;
        private TextBox WidthTextBox;
        private Label WidthLabel;
        private TextBox LenghtTextBox;
        private Label LengthLabel;
        private ListBox RectanglesListBox;
        private GroupBox FilmGroupBox;
        private ListBox FilmsListBox;
        private Label GenreLabel;
        private TextBox IssueTextBox;
        private Label IssueLabel;
        private TextBox DurationTextBox;
        private Label DurationLabel;
        private TextBox NameTextBox;
        private Label NameLabel;
        private Button FindMaxRatingButton;
        private TextBox RatingTextBox;
        private Label label5;
        private TextBox GenreTextBox;
        private Label label2;
        private TextBox xTextBox;
        private Label label1;
        private Label CoordinatesLabel;
        private TextBox yTextBox;
        private TextBox IdTextBox;
        private Label label3;
        private TabPage Rectangles;
        private Button DeleteRecButton;
        private Button AddRecButton;
        private ListBox RecListBox;
        private Label label4;
        private TextBox IDRecTextBox;
        private Label label7;
        private Label label6;
        private Panel RectanglesPanel;
        private TextBox HeightRecTextBox;
        private Label label11;
        private TextBox WidthRecTextBox;
        private Label label10;
        private TextBox YRecTextBox;
        private Label label9;
        private TextBox XRecTextBox;
        private Label label8;
    }
}