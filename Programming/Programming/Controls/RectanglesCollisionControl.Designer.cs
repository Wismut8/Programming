namespace Programming
{
    partial class RectanglesCollisionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectanglesCollisionControl));
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
            SuspendLayout();
            // 
            // RectanglesPanel
            // 
            RectanglesPanel.Location = new Point(375, 35);
            RectanglesPanel.Name = "RectanglesPanel";
            RectanglesPanel.Size = new Size(515, 452);
            RectanglesPanel.TabIndex = 31;
            // 
            // HeightRecTextBox
            // 
            HeightRecTextBox.Location = new Point(76, 464);
            HeightRecTextBox.Name = "HeightRecTextBox";
            HeightRecTextBox.Size = new Size(125, 27);
            HeightRecTextBox.TabIndex = 30;
            HeightRecTextBox.TextChanged += HeightRecTextBox_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 467);
            label11.Name = "label11";
            label11.Size = new Size(57, 20);
            label11.TabIndex = 29;
            label11.Text = "Height:";
            // 
            // WidthRecTextBox
            // 
            WidthRecTextBox.Location = new Point(76, 427);
            WidthRecTextBox.Name = "WidthRecTextBox";
            WidthRecTextBox.Size = new Size(125, 27);
            WidthRecTextBox.TabIndex = 28;
            WidthRecTextBox.TextChanged += WidthRecTextBox_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 430);
            label10.Name = "label10";
            label10.Size = new Size(52, 20);
            label10.TabIndex = 27;
            label10.Text = "Width:";
            // 
            // YRecTextBox
            // 
            YRecTextBox.Location = new Point(76, 394);
            YRecTextBox.Name = "YRecTextBox";
            YRecTextBox.Size = new Size(125, 27);
            YRecTextBox.TabIndex = 26;
            YRecTextBox.TextChanged += YRecTextBox_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(50, 394);
            label9.Name = "label9";
            label9.Size = new Size(20, 20);
            label9.TabIndex = 25;
            label9.Text = "Y:";
            // 
            // XRecTextBox
            // 
            XRecTextBox.Location = new Point(76, 361);
            XRecTextBox.Name = "XRecTextBox";
            XRecTextBox.Size = new Size(125, 27);
            XRecTextBox.TabIndex = 24;
            XRecTextBox.TextChanged += XRecTextBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(49, 361);
            label8.Name = "label8";
            label8.Size = new Size(21, 20);
            label8.TabIndex = 23;
            label8.Text = "X:";
            // 
            // IDRecTextBox
            // 
            IDRecTextBox.Enabled = false;
            IDRecTextBox.Location = new Point(76, 328);
            IDRecTextBox.Name = "IDRecTextBox";
            IDRecTextBox.Size = new Size(125, 27);
            IDRecTextBox.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(43, 331);
            label7.Name = "label7";
            label7.Size = new Size(27, 20);
            label7.TabIndex = 21;
            label7.Text = "ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 305);
            label6.Name = "label6";
            label6.Size = new Size(135, 20);
            label6.TabIndex = 20;
            label6.Text = "Selected rectangle:";
            // 
            // DeleteRecButton
            // 
            DeleteRecButton.BackColor = Color.White;
            DeleteRecButton.FlatAppearance.BorderSize = 0;
            DeleteRecButton.FlatStyle = FlatStyle.Flat;
            DeleteRecButton.Image = (Image)resources.GetObject("DeleteRecButton.Image");
            DeleteRecButton.Location = new Point(188, 245);
            DeleteRecButton.Name = "DeleteRecButton";
            DeleteRecButton.Size = new Size(171, 57);
            DeleteRecButton.TabIndex = 19;
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
            AddRecButton.Location = new Point(13, 245);
            AddRecButton.Name = "AddRecButton";
            AddRecButton.Size = new Size(135, 57);
            AddRecButton.TabIndex = 18;
            AddRecButton.UseVisualStyleBackColor = false;
            AddRecButton.Click += AddRecButton_Click;
            // 
            // RecListBox
            // 
            RecListBox.FormattingEnabled = true;
            RecListBox.ItemHeight = 20;
            RecListBox.Location = new Point(13, 35);
            RecListBox.Name = "RecListBox";
            RecListBox.Size = new Size(346, 204);
            RecListBox.TabIndex = 17;
            RecListBox.SelectedIndexChanged += RecListBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 12);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 16;
            label4.Text = "Rectangles:";
            // 
            // RectanglesCollisionControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(RectanglesPanel);
            Controls.Add(HeightRecTextBox);
            Controls.Add(label11);
            Controls.Add(WidthRecTextBox);
            Controls.Add(label10);
            Controls.Add(YRecTextBox);
            Controls.Add(label9);
            Controls.Add(XRecTextBox);
            Controls.Add(label8);
            Controls.Add(IDRecTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(DeleteRecButton);
            Controls.Add(AddRecButton);
            Controls.Add(RecListBox);
            Controls.Add(label4);
            Name = "RectanglesCollisionControl";
            Size = new Size(913, 539);
            Load += RectanglesCollisionControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel RectanglesPanel;
        private TextBox HeightRecTextBox;
        private Label label11;
        private TextBox WidthRecTextBox;
        private Label label10;
        private TextBox YRecTextBox;
        private Label label9;
        private TextBox XRecTextBox;
        private Label label8;
        private TextBox IDRecTextBox;
        private Label label7;
        private Label label6;
        private Button DeleteRecButton;
        private Button AddRecButton;
        private ListBox RecListBox;
        private Label label4;
    }
}
