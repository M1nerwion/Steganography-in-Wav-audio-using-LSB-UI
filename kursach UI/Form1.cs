using System.Windows.Forms;
using EnDecodeMessage;

namespace kursach_UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



            //textBoxStegoInput.Hide();
            //labelStegoInput.Hide();
            //buttonStegoInput.Hide();

            //labelMessage.Hide();
            //textBoxMessage.Hide();

            textBoxReadFromFile.Hide();
            labelReadMessageFromFile.Hide();
            buttonReadFromFile.Hide();


            //Выключить доп элементы
            radioButtonEncode.Checked = true;

            //textBoxStegoInput.Enabled = false;
            //labelStegoInput.Enabled = false;
            //buttonStegoInput.Enabled = false;

            //labelMessage.Enabled = false;
            //textBoxMessage.Enabled = false;

            textBoxReadFromFile.Enabled = false;
            labelReadMessageFromFile.Enabled = false;
            buttonReadFromFile.Enabled = false;

        }

        private void buttonStart_Click(object sender, EventArgs e)//Когда нажали кнопку старт
        {
            string Text = textBoxInputFile.Text;//Текст поля входного файла (путь входного файла)
            if (Text != string.Empty)//Если поле пусто,то вывести ошибку
            {
                if (radioButtonDecode.Checked)//если выбран режим Decode
                {
                    string message = string.Empty;//Обнуляем строку сообщения

                    //проверка на существование такого файла
                    FileInfo file = new FileInfo(Text);
                    if (file.Exists || Text == "")
                    {
                        message = EnDecodeMessage.EnDecodeMessage.Decode(textBoxInputFile.Text);//Декодируем сообщение из входного файла с шифрованной информацией
                        DecodedMessage NewDecodedMessageForm = new DecodedMessage(message);//Создаем форму режима decode
                        NewDecodedMessageForm.Show();//показываем форму режима decode
                    }
                    else MessageBox.Show("Error 404: File not exist.\n Please check file path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//Ошибка о несуществовании файла
                }
                else//если выбран режим Encode
                {
                    string message = string.Empty;
                    if (radioButtonReadFromTextBox.Checked)//если выбран режим чтения из textBox
                    {
                        message = textBoxMessage.Text;//Текст поля Сообщения
                    }
                    else
                    {
                        message = EnDecodeMessage.EnDecodeMessage.ReadFromFile(textBoxReadFromFile.Text);//Текст из файла
                    }

                    string file_stego = textBoxStegoInput.Text;//Текст поля выходного файла (путь выходного файла с зашифрованной инфомрацией)
                    FileInfo file = new FileInfo(Text);
                    //проверка на существование такого файла
                    if (file.Exists || Text == "")
                    {
                        EnDecodeMessage.EnDecodeMessage.Encode(Text, message, file_stego);//Кодируем сообщение в входной файл
                        Result newResultForm = new Result(file_stego);//Создаем форму режима Encode
                        newResultForm.Show();//показываем форму режима Encode
                    }
                    else MessageBox.Show("Error 404: File not exist.\n Please check file path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);// Ошибка о несуществовании файла
                }
            }
            else MessageBox.Show("Error 404: File not exist.\n Please check file path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);// Ошибка о несуществовании файла

        }

        private void buttonChooseInputFile_Click(object sender, EventArgs e)//Входной файл
        {
            if (openFileDialogInput.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл и записываем в текстовое поле входного файла
            textBoxInputFile.Text = openFileDialogInput.FileName;
        }

        private void buttonStegoInput_Click(object sender, EventArgs e)//Выходной файл
        {
            if (openFileDialogInput.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл и записываем в текстовое поле выходного файла
            textBoxStegoInput.Text = openFileDialogInput.FileName;
        }

        private void radioButtonEncode_CheckedChanged(object sender, EventArgs e)//Когда нажали Encode
        {
            //Включить доп элементы
            textBoxStegoInput.Enabled = true;
            labelStegoInput.Enabled = true;
            buttonStegoInput.Enabled = true;

            labelMessage.Enabled = true;
            textBoxMessage.Enabled = true;

            groupBoxEncode.Enabled = true;

            labelInformationLatinLanguage.Enabled = true;

            //Показать доп элементы
            textBoxStegoInput.Show();
            labelStegoInput.Show();
            buttonStegoInput.Show();

            labelMessage.Show();
            textBoxMessage.Show();

            groupBoxEncode.Show();

            labelInformationLatinLanguage.Show();

            //Обновить labelnputFile
            labelnputFile.Location = new Point(61, 38);
            labelnputFile.Text = "Полный путь входного файла:";
        }

        private void radioButtonDecode_CheckedChanged(object sender, EventArgs e)//Когда нажали Decode
        {
            //Скрыть доп элементы
            textBoxStegoInput.Hide();
            labelStegoInput.Hide();
            buttonStegoInput.Hide();

            labelMessage.Hide();
            textBoxMessage.Hide();

            textBoxReadFromFile.Hide();
            labelReadMessageFromFile.Hide();
            buttonReadFromFile.Hide();

            groupBoxEncode.Hide();

            labelInformationLatinLanguage.Hide();

            //Выключить доп элементы
            textBoxStegoInput.Enabled = false;
            labelStegoInput.Enabled = false;
            buttonStegoInput.Enabled = false;

            labelMessage.Enabled = false;
            textBoxMessage.Enabled = false;

            textBoxReadFromFile.Enabled = false;
            labelReadMessageFromFile.Enabled = false;
            buttonReadFromFile.Enabled = false;

            groupBoxEncode.Enabled = false;

            labelInformationLatinLanguage.Enabled = false;

            //Обновить labelnputFile
            labelnputFile.Location = new Point(20, 38);
            labelnputFile.Text = "Полный путь дешифруемого файла:";
        }

        private void labelMessage_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonReadFromTextBox_CheckedChanged(object sender, EventArgs e)
        {
            //Скрываем Поля для ввода пути файла с сообщнием
            textBoxReadFromFile.Hide();
            labelReadMessageFromFile.Hide();
            buttonReadFromFile.Hide();

            textBoxReadFromFile.Enabled = false;
            labelReadMessageFromFile.Enabled = false;
            buttonReadFromFile.Enabled = false;

            //Показываем и активируем ввод сообщение через textbox
            labelMessage.Show();
            textBoxMessage.Show();

            labelMessage.Enabled = true;
            textBoxMessage.Enabled = true;
        }

        private void radioButtonReadMessageFromFile_CheckedChanged(object sender, EventArgs e)
        {
            //Показываем и активируем Поля для ввода пути файла с сообщнием
            textBoxReadFromFile.Show();
            labelReadMessageFromFile.Show();
            buttonReadFromFile.Show();

            textBoxReadFromFile.Enabled = true;
            labelReadMessageFromFile.Enabled = true;
            buttonReadFromFile.Enabled = true;

            //Убираем ввод сообщение через textbox
            labelMessage.Hide();
            textBoxMessage.Hide();

            labelMessage.Enabled = false;
            textBoxMessage.Enabled = false;
        }

        private void buttonReadFromFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogMessage.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл и записываем в текстовое поле выходного файла
            textBoxReadFromFile.Text = openFileDialogMessage.FileName;
        }
    }
}
