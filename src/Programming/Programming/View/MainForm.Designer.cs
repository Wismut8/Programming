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
            enumerationsControl1 = new EnumerationsControl();
            Classes = new TabPage();
            classesControl1 = new Controls.ClassesControl();
            Rectangles = new TabPage();
            rectanglesCollisionControl1 = new RectanglesCollisionControl();
            EnumsTabControl.SuspendLayout();
            Enums.SuspendLayout();
            Classes.SuspendLayout();
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
            Enums.Controls.Add(enumerationsControl1);
            Enums.Location = new Point(4, 29);
            Enums.Name = "Enums";
            Enums.Padding = new Padding(3);
            Enums.Size = new Size(917, 581);
            Enums.TabIndex = 1;
            Enums.Text = "Enums";
            Enums.UseVisualStyleBackColor = true;
            // 
            // enumerationsControl1
            // 
            enumerationsControl1.Dock = DockStyle.Fill;
            enumerationsControl1.Location = new Point(3, 3);
            enumerationsControl1.Name = "enumerationsControl1";
            enumerationsControl1.Size = new Size(911, 575);
            enumerationsControl1.TabIndex = 0;
            // 
            // Classes
            // 
            Classes.Controls.Add(classesControl1);
            Classes.Location = new Point(4, 29);
            Classes.Name = "Classes";
            Classes.Size = new Size(917, 581);
            Classes.TabIndex = 2;
            Classes.Text = "Classes";
            Classes.UseVisualStyleBackColor = true;
            // 
            // classesControl1
            // 
            classesControl1.BackColor = SystemColors.Window;
            classesControl1.Dock = DockStyle.Fill;
            classesControl1.Location = new Point(0, 0);
            classesControl1.Name = "classesControl1";
            classesControl1.Size = new Size(917, 581);
            classesControl1.TabIndex = 0;
            // 
            // Rectangles
            // 
            Rectangles.Controls.Add(rectanglesCollisionControl1);
            Rectangles.Location = new Point(4, 29);
            Rectangles.Name = "Rectangles";
            Rectangles.Size = new Size(917, 581);
            Rectangles.TabIndex = 3;
            Rectangles.Text = "Rectangles";
            Rectangles.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            rectanglesCollisionControl1.BackColor = SystemColors.Window;
            rectanglesCollisionControl1.Dock = DockStyle.Fill;
            rectanglesCollisionControl1.Location = new Point(0, 0);
            rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            rectanglesCollisionControl1.Size = new Size(917, 581);
            rectanglesCollisionControl1.TabIndex = 0;
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
            Classes.ResumeLayout(false);
            Rectangles.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl EnumsTabControl;
        private TabPage Classes;
        private TabPage Rectangles;
        private RectanglesCollisionControl rectanglesCollisionControl1;
        private TabPage Enums;
        private EnumerationsControl enumerationsControl1;
        private Controls.ClassesControl classesControl1;
    }
}