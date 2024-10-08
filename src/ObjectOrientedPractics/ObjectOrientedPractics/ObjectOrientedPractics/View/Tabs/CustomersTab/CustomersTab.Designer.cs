namespace ObjectOrientedPractics.View.Tabs.CustomersTab
{
    partial class CustomersTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersTab));
            SeletcedCustomerGroupBox = new GroupBox();
            CustomerAdressTextBox = new TextBox();
            AdressLabel = new Label();
            CustomerNameTextBox = new TextBox();
            CustomerIDTextBox = new TextBox();
            CustomerNameLabel = new Label();
            CustomerIdLabel = new Label();
            CustomersGroupBox = new GroupBox();
            RemoveCustomerButton = new Button();
            AddCustomerButton = new Button();
            CustomersListBox = new ListBox();
            CatPictureBox = new PictureBox();
            SeletcedCustomerGroupBox.SuspendLayout();
            CustomersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CatPictureBox).BeginInit();
            SuspendLayout();
            // 
            // SeletcedCustomerGroupBox
            // 
            SeletcedCustomerGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SeletcedCustomerGroupBox.Controls.Add(CustomerAdressTextBox);
            SeletcedCustomerGroupBox.Controls.Add(AdressLabel);
            SeletcedCustomerGroupBox.Controls.Add(CustomerNameTextBox);
            SeletcedCustomerGroupBox.Controls.Add(CustomerIDTextBox);
            SeletcedCustomerGroupBox.Controls.Add(CustomerNameLabel);
            SeletcedCustomerGroupBox.Controls.Add(CustomerIdLabel);
            SeletcedCustomerGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SeletcedCustomerGroupBox.Location = new Point(344, 4);
            SeletcedCustomerGroupBox.Name = "SeletcedCustomerGroupBox";
            SeletcedCustomerGroupBox.Size = new Size(463, 244);
            SeletcedCustomerGroupBox.TabIndex = 3;
            SeletcedCustomerGroupBox.TabStop = false;
            SeletcedCustomerGroupBox.Text = "Selected Item";
            // 
            // CustomerAdressTextBox
            // 
            CustomerAdressTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomerAdressTextBox.Location = new Point(91, 92);
            CustomerAdressTextBox.Multiline = true;
            CustomerAdressTextBox.Name = "CustomerAdressTextBox";
            CustomerAdressTextBox.Size = new Size(366, 144);
            CustomerAdressTextBox.TabIndex = 5;
            CustomerAdressTextBox.TextChanged += CustomerAdressTextBox_TextChanged;
            // 
            // AdressLabel
            // 
            AdressLabel.AutoSize = true;
            AdressLabel.Location = new Point(6, 92);
            AdressLabel.Name = "AdressLabel";
            AdressLabel.Size = new Size(56, 20);
            AdressLabel.TabIndex = 4;
            AdressLabel.Text = "Adress:";
            // 
            // CustomerNameTextBox
            // 
            CustomerNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomerNameTextBox.Location = new Point(91, 59);
            CustomerNameTextBox.Name = "CustomerNameTextBox";
            CustomerNameTextBox.Size = new Size(366, 27);
            CustomerNameTextBox.TabIndex = 3;
            CustomerNameTextBox.TextChanged += CustomerNameTextBox_TextChanged;
            // 
            // CustomerIDTextBox
            // 
            CustomerIDTextBox.Enabled = false;
            CustomerIDTextBox.Location = new Point(91, 26);
            CustomerIDTextBox.Name = "CustomerIDTextBox";
            CustomerIDTextBox.Size = new Size(147, 27);
            CustomerIDTextBox.TabIndex = 2;
            // 
            // CustomerNameLabel
            // 
            CustomerNameLabel.AutoSize = true;
            CustomerNameLabel.Location = new Point(6, 62);
            CustomerNameLabel.Name = "CustomerNameLabel";
            CustomerNameLabel.Size = new Size(79, 20);
            CustomerNameLabel.TabIndex = 1;
            CustomerNameLabel.Text = "Full Name:";
            // 
            // CustomerIdLabel
            // 
            CustomerIdLabel.AutoSize = true;
            CustomerIdLabel.Location = new Point(6, 33);
            CustomerIdLabel.Name = "CustomerIdLabel";
            CustomerIdLabel.Size = new Size(27, 20);
            CustomerIdLabel.TabIndex = 0;
            CustomerIdLabel.Text = "ID:";
            // 
            // CustomersGroupBox
            // 
            CustomersGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomersGroupBox.BackColor = SystemColors.ControlLight;
            CustomersGroupBox.Controls.Add(RemoveCustomerButton);
            CustomersGroupBox.Controls.Add(AddCustomerButton);
            CustomersGroupBox.Controls.Add(CustomersListBox);
            CustomersGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CustomersGroupBox.Location = new Point(3, 4);
            CustomersGroupBox.Name = "CustomersGroupBox";
            CustomersGroupBox.Size = new Size(335, 508);
            CustomersGroupBox.TabIndex = 2;
            CustomersGroupBox.TabStop = false;
            CustomersGroupBox.Text = "Customers";
            // 
            // RemoveCustomerButton
            // 
            RemoveCustomerButton.Anchor = AnchorStyles.Left;
            RemoveCustomerButton.Location = new Point(114, 461);
            RemoveCustomerButton.Name = "RemoveCustomerButton";
            RemoveCustomerButton.Size = new Size(104, 37);
            RemoveCustomerButton.TabIndex = 2;
            RemoveCustomerButton.Text = "Remove";
            RemoveCustomerButton.UseVisualStyleBackColor = true;
            RemoveCustomerButton.Click += RemoveCustomerButton_Click;
            // 
            // AddCustomerButton
            // 
            AddCustomerButton.Anchor = AnchorStyles.Left;
            AddCustomerButton.Location = new Point(6, 461);
            AddCustomerButton.Name = "AddCustomerButton";
            AddCustomerButton.Size = new Size(102, 37);
            AddCustomerButton.TabIndex = 1;
            AddCustomerButton.Text = "Add";
            AddCustomerButton.UseVisualStyleBackColor = true;
            AddCustomerButton.Click += AddCustomerButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 20;
            CustomersListBox.Location = new Point(0, 26);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(320, 424);
            CustomersListBox.TabIndex = 0;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // CatPictureBox
            // 
            CatPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CatPictureBox.Image = (Image)resources.GetObject("CatPictureBox.Image");
            CatPictureBox.Location = new Point(344, 254);
            CatPictureBox.Name = "CatPictureBox";
            CatPictureBox.Size = new Size(463, 258);
            CatPictureBox.TabIndex = 4;
            CatPictureBox.TabStop = false;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CatPictureBox);
            Controls.Add(SeletcedCustomerGroupBox);
            Controls.Add(CustomersGroupBox);
            Name = "CustomersTab";
            Size = new Size(812, 515);
            Load += CustomersTab_Load;
            SeletcedCustomerGroupBox.ResumeLayout(false);
            SeletcedCustomerGroupBox.PerformLayout();
            CustomersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CatPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox SeletcedCustomerGroupBox;
        private TextBox CustomerAdressTextBox;
        private Label AdressLabel;
        private TextBox CustomerNameTextBox;
        private TextBox CustomerIDTextBox;
        private Label CustomerNameLabel;
        private Label CustomerIdLabel;
        private GroupBox CustomersGroupBox;
        private Button RemoveCustomerButton;
        private Button AddCustomerButton;
        private ListBox CustomersListBox;
        private PictureBox CatPictureBox;
    }
}
