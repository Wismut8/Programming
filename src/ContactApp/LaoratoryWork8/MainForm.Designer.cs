namespace LaoratoryWork8
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            FlightIfoGroupBox = new GroupBox();
            DeleteButton = new Button();
            AddFlightButton = new Button();
            FlightTypeComboBox = new ComboBox();
            FlightTypeLabel = new Label();
            FlightTimeTextBox = new TextBox();
            FlightTimePicker = new DateTimePicker();
            FlightTimeLabel = new Label();
            DepartureTimeLabel = new Label();
            DestinationTextBox = new TextBox();
            DestinationLabel = new Label();
            DeparturePointTextBox = new TextBox();
            DeparturePointLabel = new Label();
            FlightsListBox = new ListBox();
            FlightIfoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // FlightIfoGroupBox
            // 
            FlightIfoGroupBox.BackColor = SystemColors.Window;
            FlightIfoGroupBox.Controls.Add(DeleteButton);
            FlightIfoGroupBox.Controls.Add(AddFlightButton);
            FlightIfoGroupBox.Controls.Add(FlightTypeComboBox);
            FlightIfoGroupBox.Controls.Add(FlightTypeLabel);
            FlightIfoGroupBox.Controls.Add(FlightTimeTextBox);
            FlightIfoGroupBox.Controls.Add(FlightTimePicker);
            FlightIfoGroupBox.Controls.Add(FlightTimeLabel);
            FlightIfoGroupBox.Controls.Add(DepartureTimeLabel);
            FlightIfoGroupBox.Controls.Add(DestinationTextBox);
            FlightIfoGroupBox.Controls.Add(DestinationLabel);
            FlightIfoGroupBox.Controls.Add(DeparturePointTextBox);
            FlightIfoGroupBox.Controls.Add(DeparturePointLabel);
            FlightIfoGroupBox.ForeColor = SystemColors.ActiveCaptionText;
            FlightIfoGroupBox.Location = new Point(355, 13);
            FlightIfoGroupBox.Name = "FlightIfoGroupBox";
            FlightIfoGroupBox.Size = new Size(404, 281);
            FlightIfoGroupBox.TabIndex = 5;
            FlightIfoGroupBox.TabStop = false;
            FlightIfoGroupBox.Text = "Flight information:";
            // 
            // DeleteButton
            // 
            DeleteButton.BackgroundImage = (Image)resources.GetObject("DeleteButton.BackgroundImage");
            DeleteButton.FlatAppearance.BorderSize = 0;
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.Location = new Point(64, 224);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(44, 42);
            DeleteButton.TabIndex = 12;
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // AddFlightButton
            // 
            AddFlightButton.BackgroundImage = (Image)resources.GetObject("AddFlightButton.BackgroundImage");
            AddFlightButton.FlatAppearance.BorderSize = 0;
            AddFlightButton.FlatStyle = FlatStyle.Flat;
            AddFlightButton.Location = new Point(17, 223);
            AddFlightButton.Margin = new Padding(0);
            AddFlightButton.Name = "AddFlightButton";
            AddFlightButton.Size = new Size(44, 43);
            AddFlightButton.TabIndex = 11;
            AddFlightButton.UseVisualStyleBackColor = true;
            AddFlightButton.Click += AddFlightButton_Click;
            // 
            // FlightTypeComboBox
            // 
            FlightTypeComboBox.FormattingEnabled = true;
            FlightTypeComboBox.Items.AddRange(new object[] { "domestic", "international" });
            FlightTypeComboBox.Location = new Point(141, 185);
            FlightTypeComboBox.Name = "FlightTypeComboBox";
            FlightTypeComboBox.Size = new Size(250, 28);
            FlightTypeComboBox.TabIndex = 10;
            // 
            // FlightTypeLabel
            // 
            FlightTypeLabel.AutoSize = true;
            FlightTypeLabel.Location = new Point(35, 185);
            FlightTypeLabel.Name = "FlightTypeLabel";
            FlightTypeLabel.Size = new Size(100, 20);
            FlightTypeLabel.TabIndex = 9;
            FlightTypeLabel.Text = "Type of flight:";
            // 
            // FlightTimeTextBox
            // 
            FlightTimeTextBox.Location = new Point(141, 149);
            FlightTimeTextBox.Name = "FlightTimeTextBox";
            FlightTimeTextBox.Size = new Size(250, 27);
            FlightTimeTextBox.TabIndex = 8;
            FlightTimeTextBox.TextChanged += FlightTimeTextBox_TextChanged;
            // 
            // FlightTimePicker
            // 
            FlightTimePicker.Location = new Point(141, 111);
            FlightTimePicker.Name = "FlightTimePicker";
            FlightTimePicker.Size = new Size(250, 27);
            FlightTimePicker.TabIndex = 7;
            // 
            // FlightTimeLabel
            // 
            FlightTimeLabel.AutoSize = true;
            FlightTimeLabel.Location = new Point(52, 149);
            FlightTimeLabel.Name = "FlightTimeLabel";
            FlightTimeLabel.Size = new Size(83, 20);
            FlightTimeLabel.TabIndex = 6;
            FlightTimeLabel.Text = "Flight time:";
            // 
            // DepartureTimeLabel
            // 
            DepartureTimeLabel.AutoSize = true;
            DepartureTimeLabel.Location = new Point(22, 111);
            DepartureTimeLabel.Name = "DepartureTimeLabel";
            DepartureTimeLabel.Size = new Size(113, 20);
            DepartureTimeLabel.TabIndex = 4;
            DepartureTimeLabel.Text = "Departure time:";
            // 
            // DestinationTextBox
            // 
            DestinationTextBox.Location = new Point(141, 74);
            DestinationTextBox.Name = "DestinationTextBox";
            DestinationTextBox.Size = new Size(250, 27);
            DestinationTextBox.TabIndex = 3;
            DestinationTextBox.TextChanged += DestinationTextBox_TextChanged;
            // 
            // DestinationLabel
            // 
            DestinationLabel.AutoSize = true;
            DestinationLabel.Location = new Point(47, 74);
            DestinationLabel.Name = "DestinationLabel";
            DestinationLabel.Size = new Size(88, 20);
            DestinationLabel.TabIndex = 2;
            DestinationLabel.Text = "Destination:";
            // 
            // DeparturePointTextBox
            // 
            DeparturePointTextBox.Location = new Point(141, 37);
            DeparturePointTextBox.Name = "DeparturePointTextBox";
            DeparturePointTextBox.Size = new Size(250, 27);
            DeparturePointTextBox.TabIndex = 1;
            DeparturePointTextBox.TextChanged += DeparturePointTextBox_TextChanged;
            // 
            // DeparturePointLabel
            // 
            DeparturePointLabel.AutoSize = true;
            DeparturePointLabel.Location = new Point(17, 37);
            DeparturePointLabel.Name = "DeparturePointLabel";
            DeparturePointLabel.Size = new Size(118, 20);
            DeparturePointLabel.TabIndex = 0;
            DeparturePointLabel.Text = "Departure point:";
            // 
            // FlightsListBox
            // 
            FlightsListBox.FormattingEnabled = true;
            FlightsListBox.ItemHeight = 20;
            FlightsListBox.Location = new Point(10, 13);
            FlightsListBox.Name = "FlightsListBox";
            FlightsListBox.Size = new Size(339, 424);
            FlightsListBox.TabIndex = 4;
            FlightsListBox.SelectedIndexChanged += FlightsListBox_SelectedIndexChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(769, 450);
            Controls.Add(FlightIfoGroupBox);
            Controls.Add(FlightsListBox);
            Name = "MainForm";
            Text = "Flights Control";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            FlightIfoGroupBox.ResumeLayout(false);
            FlightIfoGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox FlightIfoGroupBox;
        private Button DeleteButton;
        private Button AddFlightButton;
        private ComboBox FlightTypeComboBox;
        private Label FlightTypeLabel;
        private TextBox FlightTimeTextBox;
        private DateTimePicker FlightTimePicker;
        private Label FlightTimeLabel;
        private Label DepartureTimeLabel;
        private TextBox DestinationTextBox;
        private Label DestinationLabel;
        private TextBox DeparturePointTextBox;
        private Label DeparturePointLabel;
        private ListBox FlightsListBox;
    }
}