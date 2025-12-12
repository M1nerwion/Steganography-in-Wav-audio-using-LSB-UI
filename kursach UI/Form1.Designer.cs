namespace kursach_UI
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
            components = new System.ComponentModel.Container();
            openFileDialogInput = new OpenFileDialog();
            groupBoxMode = new GroupBox();
            radioButtonDecode = new RadioButton();
            radioButtonEncode = new RadioButton();
            buttonStart = new Button();
            textBoxInputFile = new TextBox();
            labelnputFile = new Label();
            buttonChooseInputFile = new Button();
            textBoxMessage = new TextBox();
            labelMessage = new Label();
            notifyIcon1 = new NotifyIcon(components);
            buttonStegoInput = new Button();
            labelStegoInput = new Label();
            textBoxStegoInput = new TextBox();
            buttonReadFromFile = new Button();
            labelReadMessageFromFile = new Label();
            textBoxReadFromFile = new TextBox();
            groupBoxEncode = new GroupBox();
            radioButtonReadMessageFromFile = new RadioButton();
            radioButtonReadFromTextBox = new RadioButton();
            openFileDialogMessage = new OpenFileDialog();
            labelInformationLatinLanguage = new Label();
            groupBoxMode.SuspendLayout();
            groupBoxEncode.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialogInput
            // 
            openFileDialogInput.Filter = "Wav files|*.wav";
            openFileDialogInput.Title = "Choose covering Wav-file";
            // 
            // groupBoxMode
            // 
            groupBoxMode.Controls.Add(radioButtonDecode);
            groupBoxMode.Controls.Add(radioButtonEncode);
            groupBoxMode.Location = new Point(761, 163);
            groupBoxMode.Name = "groupBoxMode";
            groupBoxMode.Size = new Size(133, 88);
            groupBoxMode.TabIndex = 0;
            groupBoxMode.TabStop = false;
            groupBoxMode.Text = "Режим работы:";
            // 
            // radioButtonDecode
            // 
            radioButtonDecode.AutoSize = true;
            radioButtonDecode.Location = new Point(33, 54);
            radioButtonDecode.Name = "radioButtonDecode";
            radioButtonDecode.Size = new Size(65, 19);
            radioButtonDecode.TabIndex = 1;
            radioButtonDecode.Text = "Decode";
            radioButtonDecode.UseVisualStyleBackColor = true;
            radioButtonDecode.CheckedChanged += radioButtonDecode_CheckedChanged;
            // 
            // radioButtonEncode
            // 
            radioButtonEncode.AutoSize = true;
            radioButtonEncode.Checked = true;
            radioButtonEncode.Location = new Point(33, 22);
            radioButtonEncode.Name = "radioButtonEncode";
            radioButtonEncode.Size = new Size(64, 19);
            radioButtonEncode.TabIndex = 0;
            radioButtonEncode.TabStop = true;
            radioButtonEncode.Text = "Encode";
            radioButtonEncode.UseVisualStyleBackColor = true;
            radioButtonEncode.CheckedChanged += radioButtonEncode_CheckedChanged;
            // 
            // buttonStart
            // 
            buttonStart.Location = new Point(776, 359);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(83, 30);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Старт";
            buttonStart.UseVisualStyleBackColor = true;
            buttonStart.Click += buttonStart_Click;
            // 
            // textBoxInputFile
            // 
            textBoxInputFile.Location = new Point(294, 38);
            textBoxInputFile.Name = "textBoxInputFile";
            textBoxInputFile.Size = new Size(438, 23);
            textBoxInputFile.TabIndex = 2;
            // 
            // labelnputFile
            // 
            labelnputFile.AutoSize = true;
            labelnputFile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelnputFile.Location = new Point(61, 38);
            labelnputFile.Name = "labelnputFile";
            labelnputFile.Size = new Size(224, 21);
            labelnputFile.TabIndex = 3;
            labelnputFile.Text = "Полный путь входного файла:";
            // 
            // buttonChooseInputFile
            // 
            buttonChooseInputFile.Location = new Point(790, 33);
            buttonChooseInputFile.Name = "buttonChooseInputFile";
            buttonChooseInputFile.Size = new Size(75, 31);
            buttonChooseInputFile.TabIndex = 4;
            buttonChooseInputFile.Text = "Выбрать";
            buttonChooseInputFile.UseVisualStyleBackColor = true;
            buttonChooseInputFile.Click += buttonChooseInputFile_Click;
            // 
            // textBoxMessage
            // 
            textBoxMessage.Location = new Point(61, 182);
            textBoxMessage.Multiline = true;
            textBoxMessage.Name = "textBoxMessage";
            textBoxMessage.Size = new Size(671, 207);
            textBoxMessage.TabIndex = 5;
            // 
            // labelMessage
            // 
            labelMessage.AutoSize = true;
            labelMessage.Location = new Point(170, 134);
            labelMessage.Name = "labelMessage";
            labelMessage.Size = new Size(429, 15);
            labelMessage.TabIndex = 6;
            labelMessage.Text = "Введите сообщение, которое будет зашифрованно в выбранный Wav-файл:";
            labelMessage.Click += labelMessage_Click;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // buttonStegoInput
            // 
            buttonStegoInput.Location = new Point(790, 79);
            buttonStegoInput.Name = "buttonStegoInput";
            buttonStegoInput.Size = new Size(75, 31);
            buttonStegoInput.TabIndex = 9;
            buttonStegoInput.Text = "Выбрать";
            buttonStegoInput.UseVisualStyleBackColor = true;
            buttonStegoInput.Click += buttonStegoInput_Click;
            // 
            // labelStegoInput
            // 
            labelStegoInput.AutoSize = true;
            labelStegoInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelStegoInput.Location = new Point(50, 82);
            labelStegoInput.Name = "labelStegoInput";
            labelStegoInput.Size = new Size(235, 21);
            labelStegoInput.TabIndex = 8;
            labelStegoInput.Text = "Полный путь выходного файла:";
            // 
            // textBoxStegoInput
            // 
            textBoxStegoInput.Location = new Point(294, 84);
            textBoxStegoInput.Name = "textBoxStegoInput";
            textBoxStegoInput.Size = new Size(438, 23);
            textBoxStegoInput.TabIndex = 7;
            // 
            // buttonReadFromFile
            // 
            buttonReadFromFile.Location = new Point(790, 126);
            buttonReadFromFile.Name = "buttonReadFromFile";
            buttonReadFromFile.Size = new Size(75, 31);
            buttonReadFromFile.TabIndex = 12;
            buttonReadFromFile.Text = "Выбрать";
            buttonReadFromFile.UseVisualStyleBackColor = true;
            buttonReadFromFile.Click += buttonReadFromFile_Click;
            // 
            // labelReadMessageFromFile
            // 
            labelReadMessageFromFile.AutoSize = true;
            labelReadMessageFromFile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelReadMessageFromFile.Location = new Point(27, 129);
            labelReadMessageFromFile.Name = "labelReadMessageFromFile";
            labelReadMessageFromFile.Size = new Size(261, 21);
            labelReadMessageFromFile.TabIndex = 11;
            labelReadMessageFromFile.Text = "Полный путь файла с сообщением:";
            // 
            // textBoxReadFromFile
            // 
            textBoxReadFromFile.Location = new Point(294, 131);
            textBoxReadFromFile.Name = "textBoxReadFromFile";
            textBoxReadFromFile.Size = new Size(438, 23);
            textBoxReadFromFile.TabIndex = 10;
            // 
            // groupBoxEncode
            // 
            groupBoxEncode.Controls.Add(radioButtonReadMessageFromFile);
            groupBoxEncode.Controls.Add(radioButtonReadFromTextBox);
            groupBoxEncode.Location = new Point(761, 257);
            groupBoxEncode.Name = "groupBoxEncode";
            groupBoxEncode.Size = new Size(145, 88);
            groupBoxEncode.TabIndex = 13;
            groupBoxEncode.TabStop = false;
            groupBoxEncode.Text = "Сообщение читать из:";
            // 
            // radioButtonReadMessageFromFile
            // 
            radioButtonReadMessageFromFile.AutoSize = true;
            radioButtonReadMessageFromFile.Location = new Point(33, 54);
            radioButtonReadMessageFromFile.Name = "radioButtonReadMessageFromFile";
            radioButtonReadMessageFromFile.Size = new Size(60, 19);
            radioButtonReadMessageFromFile.TabIndex = 1;
            radioButtonReadMessageFromFile.Text = "Файла";
            radioButtonReadMessageFromFile.UseVisualStyleBackColor = true;
            radioButtonReadMessageFromFile.CheckedChanged += radioButtonReadMessageFromFile_CheckedChanged;
            // 
            // radioButtonReadFromTextBox
            // 
            radioButtonReadFromTextBox.AutoSize = true;
            radioButtonReadFromTextBox.Checked = true;
            radioButtonReadFromTextBox.Location = new Point(33, 22);
            radioButtonReadFromTextBox.Name = "radioButtonReadFromTextBox";
            radioButtonReadFromTextBox.Size = new Size(69, 19);
            radioButtonReadFromTextBox.TabIndex = 0;
            radioButtonReadFromTextBox.TabStop = true;
            radioButtonReadFromTextBox.Text = "Из поля";
            radioButtonReadFromTextBox.UseVisualStyleBackColor = true;
            radioButtonReadFromTextBox.CheckedChanged += radioButtonReadFromTextBox_CheckedChanged;
            // 
            // openFileDialogMessage
            // 
            openFileDialogMessage.Filter = "Текстовые файлы|*.txt";
            openFileDialogMessage.Title = "Choose file with your message";
            // 
            // labelInformationLatinLanguage
            // 
            labelInformationLatinLanguage.AutoSize = true;
            labelInformationLatinLanguage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            labelInformationLatinLanguage.ForeColor = Color.DarkRed;
            labelInformationLatinLanguage.Location = new Point(254, 163);
            labelInformationLatinLanguage.Name = "labelInformationLatinLanguage";
            labelInformationLatinLanguage.Size = new Size(478, 15);
            labelInformationLatinLanguage.TabIndex = 14;
            labelInformationLatinLanguage.Text = "Warning: Поддерживается только Латиница (Only the Latin alphabet is supported)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 410);
            Controls.Add(labelInformationLatinLanguage);
            Controls.Add(groupBoxEncode);
            Controls.Add(buttonReadFromFile);
            Controls.Add(labelReadMessageFromFile);
            Controls.Add(textBoxReadFromFile);
            Controls.Add(buttonStegoInput);
            Controls.Add(labelStegoInput);
            Controls.Add(textBoxStegoInput);
            Controls.Add(labelMessage);
            Controls.Add(textBoxMessage);
            Controls.Add(buttonChooseInputFile);
            Controls.Add(labelnputFile);
            Controls.Add(textBoxInputFile);
            Controls.Add(buttonStart);
            Controls.Add(groupBoxMode);
            Name = "Form1";
            Text = "Form1";
            groupBoxMode.ResumeLayout(false);
            groupBoxMode.PerformLayout();
            groupBoxEncode.ResumeLayout(false);
            groupBoxEncode.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialogInput;
        private GroupBox groupBoxMode;
        private RadioButton radioButtonDecode;
        private RadioButton radioButtonEncode;
        private Button buttonStart;
        private TextBox textBoxInputFile;
        private Label labelnputFile;
        private Button buttonChooseInputFile;
        private TextBox textBoxMessage;
        private Label labelMessage;
        private NotifyIcon notifyIcon1;
        private Button buttonStegoInput;
        private Label labelStegoInput;
        private TextBox textBoxStegoInput;
        private Button buttonReadFromFile;
        private Label labelReadMessageFromFile;
        private TextBox textBoxReadFromFile;
        private GroupBox groupBoxEncode;
        private RadioButton radioButtonReadMessageFromFile;
        private RadioButton radioButtonReadFromTextBox;
        private OpenFileDialog openFileDialogMessage;
        private Label labelInformationLatinLanguage;
    }
}
