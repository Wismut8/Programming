namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            ItemsGroupBox = new GroupBox();
            RemoveItemButton = new Button();
            AddItemButton = new Button();
            ItemsListBox = new ListBox();
            SeletcedItemGroupBox = new GroupBox();
            ItemDescriptionTextBox = new TextBox();
            ItemDescriptionLabel = new Label();
            ItemNameTextBox = new TextBox();
            ItemNameLabel = new Label();
            ItemCostTextBox = new TextBox();
            ItemIDTextBox = new TextBox();
            CostLabel = new Label();
            IdLabel = new Label();
            ItemsGroupBox.SuspendLayout();
            SeletcedItemGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsGroupBox.BackColor = SystemColors.ControlLight;
            ItemsGroupBox.Controls.Add(RemoveItemButton);
            ItemsGroupBox.Controls.Add(AddItemButton);
            ItemsGroupBox.Controls.Add(ItemsListBox);
            ItemsGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ItemsGroupBox.Location = new Point(3, 3);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Size = new Size(335, 579);
            ItemsGroupBox.TabIndex = 0;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveItemButton.Location = new Point(114, 537);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(104, 37);
            RemoveItemButton.TabIndex = 2;
            RemoveItemButton.Text = "Remove";
            RemoveItemButton.UseVisualStyleBackColor = true;
            RemoveItemButton.Click += RemoveItemButton_Click;
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddItemButton.Location = new Point(6, 537);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(102, 37);
            AddItemButton.TabIndex = 1;
            AddItemButton.Text = "Add";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 20;
            ItemsListBox.Location = new Point(6, 26);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(320, 504);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // SeletcedItemGroupBox
            // 
            SeletcedItemGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SeletcedItemGroupBox.Controls.Add(ItemDescriptionTextBox);
            SeletcedItemGroupBox.Controls.Add(ItemDescriptionLabel);
            SeletcedItemGroupBox.Controls.Add(ItemNameTextBox);
            SeletcedItemGroupBox.Controls.Add(ItemNameLabel);
            SeletcedItemGroupBox.Controls.Add(ItemCostTextBox);
            SeletcedItemGroupBox.Controls.Add(ItemIDTextBox);
            SeletcedItemGroupBox.Controls.Add(CostLabel);
            SeletcedItemGroupBox.Controls.Add(IdLabel);
            SeletcedItemGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SeletcedItemGroupBox.Location = new Point(344, 3);
            SeletcedItemGroupBox.Name = "SeletcedItemGroupBox";
            SeletcedItemGroupBox.Size = new Size(466, 579);
            SeletcedItemGroupBox.TabIndex = 1;
            SeletcedItemGroupBox.TabStop = false;
            SeletcedItemGroupBox.Text = "Selected Item";
            // 
            // ItemDescriptionTextBox
            // 
            ItemDescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemDescriptionTextBox.Location = new Point(6, 299);
            ItemDescriptionTextBox.Multiline = true;
            ItemDescriptionTextBox.Name = "ItemDescriptionTextBox";
            ItemDescriptionTextBox.Size = new Size(451, 232);
            ItemDescriptionTextBox.TabIndex = 7;
            ItemDescriptionTextBox.TextChanged += ItemDescriptionTextBox_TextChanged;
            // 
            // ItemDescriptionLabel
            // 
            ItemDescriptionLabel.AutoSize = true;
            ItemDescriptionLabel.Location = new Point(6, 276);
            ItemDescriptionLabel.Name = "ItemDescriptionLabel";
            ItemDescriptionLabel.Size = new Size(88, 20);
            ItemDescriptionLabel.TabIndex = 6;
            ItemDescriptionLabel.Text = "Description:";
            // 
            // ItemNameTextBox
            // 
            ItemNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ItemNameTextBox.Location = new Point(6, 157);
            ItemNameTextBox.Multiline = true;
            ItemNameTextBox.Name = "ItemNameTextBox";
            ItemNameTextBox.Size = new Size(451, 107);
            ItemNameTextBox.TabIndex = 5;
            ItemNameTextBox.TextChanged += ItemNameTextBox_TextChanged;
            // 
            // ItemNameLabel
            // 
            ItemNameLabel.AutoSize = true;
            ItemNameLabel.Location = new Point(6, 134);
            ItemNameLabel.Name = "ItemNameLabel";
            ItemNameLabel.Size = new Size(52, 20);
            ItemNameLabel.TabIndex = 4;
            ItemNameLabel.Text = "Name:";
            // 
            // ItemCostTextBox
            // 
            ItemCostTextBox.Location = new Point(62, 88);
            ItemCostTextBox.Name = "ItemCostTextBox";
            ItemCostTextBox.Size = new Size(147, 27);
            ItemCostTextBox.TabIndex = 3;
            ItemCostTextBox.TextChanged += ItemCostTextBox_TextChanged;
            // 
            // ItemIDTextBox
            // 
            ItemIDTextBox.Enabled = false;
            ItemIDTextBox.Location = new Point(62, 49);
            ItemIDTextBox.Name = "ItemIDTextBox";
            ItemIDTextBox.Size = new Size(147, 27);
            ItemIDTextBox.TabIndex = 2;
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(6, 88);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(41, 20);
            CostLabel.TabIndex = 1;
            CostLabel.Text = "Cost:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(6, 48);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(27, 20);
            IdLabel.TabIndex = 0;
            IdLabel.Text = "ID:";
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SeletcedItemGroupBox);
            Controls.Add(ItemsGroupBox);
            Name = "ItemsTab";
            Size = new Size(813, 585);
            Load += ItemsTab_Load;
            ItemsGroupBox.ResumeLayout(false);
            SeletcedItemGroupBox.ResumeLayout(false);
            SeletcedItemGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ItemsGroupBox;
        private Button RemoveItemButton;
        private Button AddItemButton;
        private ListBox ItemsListBox;
        private GroupBox SeletcedItemGroupBox;
        private Label CostLabel;
        private Label IdLabel;
        private TextBox ItemIDTextBox;
        private TextBox ItemDescriptionTextBox;
        private Label ItemDescriptionLabel;
        private TextBox ItemNameTextBox;
        private Label ItemNameLabel;
        private TextBox ItemCostTextBox;
    }
}
