namespace ObjectOrientedPractics
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
            ItemsTabPage = new TabControl();
            tabPage2 = new TabPage();
            itemsTab1 = new View.Tabs.ItemsTab();
            CustomersTabPage = new TabPage();
            customersTab1 = new View.Tabs.CustomersTab.CustomersTab();
            ItemsTabPage.SuspendLayout();
            tabPage2.SuspendLayout();
            CustomersTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsTabPage
            // 
            ItemsTabPage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsTabPage.Controls.Add(tabPage2);
            ItemsTabPage.Controls.Add(CustomersTabPage);
            ItemsTabPage.Location = new Point(0, 0);
            ItemsTabPage.Name = "ItemsTabPage";
            ItemsTabPage.SelectedIndex = 0;
            ItemsTabPage.Size = new Size(816, 533);
            ItemsTabPage.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(itemsTab1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(808, 500);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Items";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(802, 491);
            itemsTab1.TabIndex = 0;
            // 
            // CustomersTabPage
            // 
            CustomersTabPage.Controls.Add(customersTab1);
            CustomersTabPage.Location = new Point(4, 29);
            CustomersTabPage.Name = "CustomersTabPage";
            CustomersTabPage.Padding = new Padding(3);
            CustomersTabPage.Size = new Size(808, 500);
            CustomersTabPage.TabIndex = 2;
            CustomersTabPage.Text = "Customers";
            CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            customersTab1.Dock = DockStyle.Fill;
            customersTab1.Location = new Point(3, 3);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(802, 494);
            customersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 535);
            Controls.Add(ItemsTabPage);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "Object Oriented Practics";
            ItemsTabPage.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            CustomersTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl ItemsTabPage;
        private TabPage tabPage2;
        private View.Tabs.ItemsTab itemsTab1;
        private TabPage CustomersTabPage;
        private View.Tabs.CustomersTab.CustomersTab customersTab1;
    }
}