namespace AESconverter
{
    partial class AESconverter 
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
            tabControl = new TabControl();
            convertingPage = new TabPage();
            getIVButton = new Button();
            decodeButton = new Button();
            codeButton = new Button();
            convertedLabel = new Label();
            valueLavel = new Label();
            convertedSourceField = new TextBox();
            label1 = new Label();
            keyLabel = new Label();
            sourceField = new TextBox();
            IVField = new TextBox();
            keyField = new TextBox();
            viewFilePage = new TabPage();
            v_saveFileButton = new Button();
            openFileButton = new Button();
            v_codeField = new TextBox();
            createFilePage = new TabPage();
            c_saveFileButton = new Button();
            c_addFileButton = new Button();
            c_codeField = new TextBox();
            tabControl.SuspendLayout();
            convertingPage.SuspendLayout();
            viewFilePage.SuspendLayout();
            createFilePage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(convertingPage);
            tabControl.Controls.Add(viewFilePage);
            tabControl.Controls.Add(createFilePage);
            tabControl.Location = new Point(12, 12);
            tabControl.Margin = new Padding(3, 2, 3, 2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1238, 722);
            tabControl.TabIndex = 0;
            // 
            // convertingPage
            // 
            convertingPage.Controls.Add(getIVButton);
            convertingPage.Controls.Add(decodeButton);
            convertingPage.Controls.Add(codeButton);
            convertingPage.Controls.Add(convertedLabel);
            convertingPage.Controls.Add(valueLavel);
            convertingPage.Controls.Add(convertedSourceField);
            convertingPage.Controls.Add(label1);
            convertingPage.Controls.Add(keyLabel);
            convertingPage.Controls.Add(sourceField);
            convertingPage.Controls.Add(IVField);
            convertingPage.Controls.Add(keyField);
            convertingPage.Location = new Point(4, 34);
            convertingPage.Margin = new Padding(3, 2, 3, 2);
            convertingPage.Name = "convertingPage";
            convertingPage.Padding = new Padding(3, 2, 3, 2);
            convertingPage.Size = new Size(1230, 684);
            convertingPage.TabIndex = 0;
            convertingPage.Text = "암/복호화";
            convertingPage.UseVisualStyleBackColor = true;
            // 
            // getIVButton
            // 
            getIVButton.Location = new Point(1002, 242);
            getIVButton.Margin = new Padding(3, 4, 3, 4);
            getIVButton.Name = "getIVButton";
            getIVButton.Size = new Size(150, 50);
            getIVButton.TabIndex = 10;
            getIVButton.Text = "백터 생성";
            getIVButton.UseVisualStyleBackColor = true;
            getIVButton.Click += getIVButton_Click;
            // 
            // decodeButton
            // 
            decodeButton.Location = new Point(1002, 172);
            decodeButton.Margin = new Padding(3, 2, 3, 2);
            decodeButton.Name = "decodeButton";
            decodeButton.Size = new Size(150, 50);
            decodeButton.TabIndex = 9;
            decodeButton.Text = "복호화";
            decodeButton.UseVisualStyleBackColor = true;
            decodeButton.Click += decodeButton_Click;
            // 
            // codeButton
            // 
            codeButton.Location = new Point(1002, 102);
            codeButton.Margin = new Padding(3, 2, 3, 2);
            codeButton.Name = "codeButton";
            codeButton.Size = new Size(150, 50);
            codeButton.TabIndex = 8;
            codeButton.Text = "암호화";
            codeButton.UseVisualStyleBackColor = true;
            codeButton.Click += codeButton_Click;
            // 
            // convertedLabel
            // 
            convertedLabel.AutoSize = true;
            convertedLabel.Location = new Point(73, 492);
            convertedLabel.Name = "convertedLabel";
            convertedLabel.Size = new Size(100, 25);
            convertedLabel.TabIndex = 7;
            convertedLabel.Text = "변환 후 값:";
            // 
            // valueLavel
            // 
            valueLavel.AutoSize = true;
            valueLavel.Location = new Point(73, 362);
            valueLavel.Name = "valueLavel";
            valueLavel.Size = new Size(100, 25);
            valueLavel.TabIndex = 6;
            valueLavel.Text = "변환 전 값:";
            // 
            // convertedSourceField
            // 
            convertedSourceField.Location = new Point(73, 520);
            convertedSourceField.Margin = new Padding(3, 2, 3, 2);
            convertedSourceField.Name = "convertedSourceField";
            convertedSourceField.ReadOnly = true;
            convertedSourceField.Size = new Size(825, 31);
            convertedSourceField.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 232);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(112, 25);
            label1.TabIndex = 4;
            label1.Text = "초기화 백터:";
            // 
            // keyLabel
            // 
            keyLabel.AutoSize = true;
            keyLabel.Location = new Point(73, 102);
            keyLabel.Name = "keyLabel";
            keyLabel.Size = new Size(34, 25);
            keyLabel.TabIndex = 3;
            keyLabel.Text = "키:";
            // 
            // sourceField
            // 
            sourceField.Location = new Point(73, 390);
            sourceField.Margin = new Padding(3, 2, 3, 2);
            sourceField.Name = "sourceField";
            sourceField.Size = new Size(825, 31);
            sourceField.TabIndex = 2;
            // 
            // IVField
            // 
            IVField.Location = new Point(73, 260);
            IVField.Margin = new Padding(3, 2, 3, 2);
            IVField.Name = "IVField";
            IVField.Size = new Size(825, 31);
            IVField.TabIndex = 1;
            // 
            // keyField
            // 
            keyField.Location = new Point(73, 130);
            keyField.Margin = new Padding(3, 2, 3, 2);
            keyField.Name = "keyField";
            keyField.Size = new Size(825, 31);
            keyField.TabIndex = 0;
            // 
            // viewFilePage
            // 
            viewFilePage.AllowDrop = true;
            viewFilePage.Controls.Add(v_saveFileButton);
            viewFilePage.Controls.Add(openFileButton);
            viewFilePage.Controls.Add(v_codeField);
            viewFilePage.Location = new Point(4, 34);
            viewFilePage.Margin = new Padding(3, 2, 3, 2);
            viewFilePage.Name = "viewFilePage";
            viewFilePage.Padding = new Padding(3, 2, 3, 2);
            viewFilePage.Size = new Size(1230, 684);
            viewFilePage.TabIndex = 1;
            viewFilePage.Text = "파일 조회";
            viewFilePage.UseVisualStyleBackColor = true;
            // 
            // v_saveFileButton
            // 
            v_saveFileButton.Location = new Point(1084, 124);
            v_saveFileButton.Margin = new Padding(3, 2, 3, 2);
            v_saveFileButton.Name = "v_saveFileButton";
            v_saveFileButton.Size = new Size(112, 34);
            v_saveFileButton.TabIndex = 2;
            v_saveFileButton.Text = "파일 저장";
            v_saveFileButton.UseVisualStyleBackColor = true;
            v_saveFileButton.Click += v_saveFileButton_Click;
            // 
            // openFileButton
            // 
            openFileButton.Location = new Point(1084, 48);
            openFileButton.Margin = new Padding(3, 2, 3, 2);
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new Size(112, 34);
            openFileButton.TabIndex = 1;
            openFileButton.Text = "파일 열기";
            openFileButton.UseVisualStyleBackColor = true;
            openFileButton.Click += openFileButton_Click;
            // 
            // v_codeField
            // 
            v_codeField.Location = new Point(30, 30);
            v_codeField.Margin = new Padding(3, 2, 3, 2);
            v_codeField.Multiline = true;
            v_codeField.Name = "v_codeField";
            v_codeField.ReadOnly = true;
            v_codeField.ScrollBars = ScrollBars.Vertical;
            v_codeField.Size = new Size(1020, 623);
            v_codeField.TabIndex = 0;
            // 
            // createFilePage
            // 
            createFilePage.AllowDrop = true;
            createFilePage.Controls.Add(c_saveFileButton);
            createFilePage.Controls.Add(c_addFileButton);
            createFilePage.Controls.Add(c_codeField);
            createFilePage.Location = new Point(4, 34);
            createFilePage.Margin = new Padding(3, 2, 3, 2);
            createFilePage.Name = "createFilePage";
            createFilePage.Padding = new Padding(3, 2, 3, 2);
            createFilePage.Size = new Size(1230, 684);
            createFilePage.TabIndex = 2;
            createFilePage.Text = "파일 생성";
            createFilePage.UseVisualStyleBackColor = true;
            // 
            // c_saveFileButton
            // 
            c_saveFileButton.Location = new Point(1084, 124);
            c_saveFileButton.Margin = new Padding(3, 2, 3, 2);
            c_saveFileButton.Name = "c_saveFileButton";
            c_saveFileButton.Size = new Size(112, 34);
            c_saveFileButton.TabIndex = 3;
            c_saveFileButton.Text = "파일 저장";
            c_saveFileButton.UseVisualStyleBackColor = true;
            c_saveFileButton.Click += c_saveFileButton_Click;
            // 
            // c_addFileButton
            // 
            c_addFileButton.Location = new Point(1084, 48);
            c_addFileButton.Margin = new Padding(3, 2, 3, 2);
            c_addFileButton.Name = "c_addFileButton";
            c_addFileButton.Size = new Size(112, 34);
            c_addFileButton.TabIndex = 2;
            c_addFileButton.Text = "파일 열기";
            c_addFileButton.UseVisualStyleBackColor = true;
            c_addFileButton.Click += c_addFileButton_Click;
            // 
            // c_codeField
            // 
            c_codeField.Location = new Point(30, 30);
            c_codeField.Margin = new Padding(3, 2, 3, 2);
            c_codeField.Multiline = true;
            c_codeField.Name = "c_codeField";
            c_codeField.ReadOnly = true;
            c_codeField.ScrollBars = ScrollBars.Vertical;
            c_codeField.Size = new Size(1020, 623);
            c_codeField.TabIndex = 1;
            // 
            // AESconverter
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 746);
            Controls.Add(tabControl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AESconverter";
            Text = "AESconverter";
            tabControl.ResumeLayout(false);
            convertingPage.ResumeLayout(false);
            convertingPage.PerformLayout();
            viewFilePage.ResumeLayout(false);
            viewFilePage.PerformLayout();
            createFilePage.ResumeLayout(false);
            createFilePage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage convertingPage;
        private TabPage viewFilePage;
        private TextBox sourceField;
        private TextBox IVField;
        private TextBox keyField;
        private TabPage createFilePage;
        private TextBox convertedSourceField;
        private Label label1;
        private Label keyLabel;
        private Label convertedLabel;
        private Label valueLavel;
        private Button decodeButton;
        private Button codeButton;
        private TextBox v_codeField;
        private TextBox c_codeField;
        private Button v_saveFileButton;
        private Button openFileButton;
        private Button c_saveFileButton;
        private Button c_addFileButton;
        private Button getIVButton;
    }
}
