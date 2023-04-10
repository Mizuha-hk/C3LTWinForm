namespace C3LTWinForm
{
    partial class Form1
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
            MainTab = new TabControl();
            tabPage1 = new TabPage();
            deleteButton = new Button();
            PhoneItemList = new ListView();
            label1 = new Label();
            SearchText = new TextBox();
            SearchButton = new Button();
            tabPage2 = new TabPage();
            CausionText = new Label();
            ApplicationButton = new Button();
            PhoneBox = new TextBox();
            label3 = new Label();
            NameBox = new TextBox();
            label2 = new Label();
            MainTab.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // MainTab
            // 
            MainTab.Controls.Add(tabPage1);
            MainTab.Controls.Add(tabPage2);
            MainTab.Location = new Point(0, 0);
            MainTab.Name = "MainTab";
            MainTab.SelectedIndex = 0;
            MainTab.Size = new Size(483, 353);
            MainTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(deleteButton);
            tabPage1.Controls.Add(PhoneItemList);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(SearchText);
            tabPage1.Controls.Add(SearchButton);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(475, 320);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "検索";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.WhiteSmoke;
            deleteButton.ForeColor = Color.Red;
            deleteButton.Location = new Point(362, 288);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(94, 29);
            deleteButton.TabIndex = 5;
            deleteButton.Text = "削除";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // PhoneItemList
            // 
            PhoneItemList.GridLines = true;
            PhoneItemList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            PhoneItemList.Location = new Point(8, 59);
            PhoneItemList.Name = "PhoneItemList";
            PhoneItemList.Size = new Size(448, 223);
            PhoneItemList.TabIndex = 4;
            PhoneItemList.UseCompatibleStateImageBehavior = false;
            PhoneItemList.View = View.Details;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(8, 3);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 3;
            label1.Text = "名前検索";
            // 
            // SearchText
            // 
            SearchText.Location = new Point(8, 26);
            SearchText.Name = "SearchText";
            SearchText.Size = new Size(348, 27);
            SearchText.TabIndex = 1;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(362, 24);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(94, 29);
            SearchButton.TabIndex = 0;
            SearchButton.Text = "検索";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(CausionText);
            tabPage2.Controls.Add(ApplicationButton);
            tabPage2.Controls.Add(PhoneBox);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(NameBox);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(475, 320);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "登録";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // CausionText
            // 
            CausionText.AutoSize = true;
            CausionText.ForeColor = Color.Red;
            CausionText.Location = new Point(8, 114);
            CausionText.Name = "CausionText";
            CausionText.Size = new Size(0, 20);
            CausionText.TabIndex = 5;
            // 
            // ApplicationButton
            // 
            ApplicationButton.Location = new Point(220, 84);
            ApplicationButton.Name = "ApplicationButton";
            ApplicationButton.Size = new Size(94, 29);
            ApplicationButton.TabIndex = 4;
            ApplicationButton.Text = "登録";
            ApplicationButton.UseVisualStyleBackColor = true;
            ApplicationButton.Click += ApplicationButton_Click;
            // 
            // PhoneBox
            // 
            PhoneBox.Location = new Point(8, 84);
            PhoneBox.Name = "PhoneBox";
            PhoneBox.Size = new Size(206, 27);
            PhoneBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 61);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "電話番号";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(8, 31);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(206, 27);
            NameBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 8);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 0;
            label2.Text = "名前";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 350);
            Controls.Add(MainTab);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            MainTab.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl MainTab;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label1;
        private TextBox SearchText;
        private Button SearchButton;
        private Button ApplicationButton;
        private TextBox PhoneBox;
        private Label label3;
        private TextBox NameBox;
        private Label label2;
        private Label CausionText;
        private ListView PhoneItemList;
        private Button deleteButton;
    }
}