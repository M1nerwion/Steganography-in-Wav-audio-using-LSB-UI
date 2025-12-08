namespace kursach_UI
{
    partial class DecodedMessage
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
            labelDecodedMessage = new Label();
            textBoxDecodedMessage = new TextBox();
            buttonCloseDecodeMessage = new Button();
            SuspendLayout();
            // 
            // labelDecodedMessage
            // 
            labelDecodedMessage.AutoSize = true;
            labelDecodedMessage.Location = new Point(162, 28);
            labelDecodedMessage.Name = "labelDecodedMessage";
            labelDecodedMessage.Size = new Size(215, 15);
            labelDecodedMessage.TabIndex = 0;
            labelDecodedMessage.Text = "Текст расшифрованного сообщения:";
            // 
            // textBoxDecodedMessage
            // 
            textBoxDecodedMessage.Location = new Point(30, 72);
            textBoxDecodedMessage.Multiline = true;
            textBoxDecodedMessage.Name = "textBoxDecodedMessage";
            textBoxDecodedMessage.Size = new Size(477, 323);
            textBoxDecodedMessage.TabIndex = 1;
            // 
            // buttonCloseDecodeMessage
            // 
            buttonCloseDecodeMessage.BackColor = Color.LightCoral;
            buttonCloseDecodeMessage.Location = new Point(405, 411);
            buttonCloseDecodeMessage.Name = "buttonCloseDecodeMessage";
            buttonCloseDecodeMessage.Size = new Size(93, 25);
            buttonCloseDecodeMessage.TabIndex = 2;
            buttonCloseDecodeMessage.Text = "Закрыть";
            buttonCloseDecodeMessage.UseVisualStyleBackColor = false;
            buttonCloseDecodeMessage.Click += buttonCloseDecodeMessage_Click;
            // 
            // DecodedMessage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 449);
            Controls.Add(buttonCloseDecodeMessage);
            Controls.Add(textBoxDecodedMessage);
            Controls.Add(labelDecodedMessage);
            Name = "DecodedMessage";
            Text = "DecodedMessage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDecodedMessage;
        private TextBox textBoxDecodedMessage;
        private Button buttonCloseDecodeMessage;
    }
}