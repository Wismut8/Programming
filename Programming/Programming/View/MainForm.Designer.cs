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
            EnumsTabControl.SuspendLayout();
            Enums.SuspendLayout();
            SeasonGroupBox.SuspendLayout();
            ParsingGroupBox.SuspendLayout();
            EnumerationsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // EnumsTabControl
            // 
            EnumsTabControl.Controls.Add(Enums);
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
            IntTextBox.TextChanged += IntTextBox_TextChanged;
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
    }
}