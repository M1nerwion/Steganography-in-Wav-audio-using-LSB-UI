namespace kursach_UI
{
    partial class Result
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
            labelStegoFile = new Label();
            textBox1 = new TextBox();
            buttonCloseResult = new Button();
            SuspendLayout();
            // 
            // labelStegoFile
            // 
            labelStegoFile.AutoSize = true;
            labelStegoFile.Location = new Point(53, 62);
            labelStegoFile.Name = "labelStegoFile";
            labelStegoFile.Size = new Size(226, 15);
            labelStegoFile.TabIndex = 0;
            labelStegoFile.Text = "Файл, с зашифрованным сообщением:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(295, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(409, 23);
            textBox1.TabIndex = 1;
            // 
            // buttonCloseResult
            // 
            buttonCloseResult.BackColor = Color.FromArgb(255, 128, 128);
            buttonCloseResult.Location = new Point(617, 147);
            buttonCloseResult.Name = "buttonCloseResult";
            buttonCloseResult.Size = new Size(87, 22);
            buttonCloseResult.TabIndex = 3;
            buttonCloseResult.Text = "Закрыть";
            buttonCloseResult.UseVisualStyleBackColor = false;
            buttonCloseResult.Click += buttonCloseResult_Click;
            // 
            // Result
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 195);
            Controls.Add(buttonCloseResult);
            Controls.Add(textBox1);
            Controls.Add(labelStegoFile);
            Name = "Result";
            Text = "Result";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelStegoFile;
        private TextBox textBox1;
        private Button buttonCloseResult;
    }
}