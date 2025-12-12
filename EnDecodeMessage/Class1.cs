using NAudio.Wave;
using System.IO;

namespace EnDecodeMessage
{
    public class EnDecodeMessage
    {
        static private string ToBinaryBits(string message)//Функция перевоода нашего сообщения в двоичный вид
        {
            string bits = "";//строка битов
            foreach (char i in message) { bits += Convert.ToString(i, 2).PadLeft(8, '0'); }//Преобразуем каждый символ в 8-битный двоичный код 
            return bits;
        }

        static private byte[] Encode_message(string bits, byte[] buffer) //Функция Изменяем данные: Кодируем байты, изменяя биты
        {
            byte[] buffer_changed = buffer;
            for (int i = 0; i < bits.Length; i++)
            {
                buffer_changed[i] = (byte)((buffer[i] & 254) | (Convert.ToInt32(bits[i])));
            }
            return buffer_changed;
        }

        static private double ConvBinToDec(byte[] extracted_bits, long i)//Функция Преобразование двоичный код битов в десятичные байты 
        {
            double dec = 0;
            dec = 0;
            for (int j = 7; j >= 0; j--)
            {
                dec += (extracted_bits[i + j]) * Math.Pow(2, 7 - j);
            }
            return dec;
        }

        //Функция кодирования зашифрованного сообщения в WAV-файл
        static public void Encode(string Name_of_wav_file, string message, string Name_stego_wav_audio)
        {
            // Load the WAV file
            //WaveFileReader waveReader = new WaveFileReader(Name_of_wav_file);
            BinaryReader waveReader = new BinaryReader(File.Open(Name_of_wav_file, FileMode.Open));//Поток чтения из WAV-файла
            //WavFile wavFile = new WavFile(Name_of_wav_file);


            FileInfo fileInfo = new FileInfo(Name_of_wav_file);//Инфомрация о файле (нужно чтобы знать его длину)

            //Записываем метаданные
            int meta = 44;//Размер метаданных wav-файла в байтах
            long len = fileInfo.Length;//Размер wav-файла
            byte[] buffer = new byte[len - meta];//массив байтов аудиоданных
            byte[] start_44_buf = new byte[meta];//массив метаданных wav-файла
            byte[] buffer_changed = buffer; //массив измененных байтов аудиоданных с зашифрованным сообщением 
            int bytesRead44 = waveReader.Read(start_44_buf, 0, start_44_buf.Length);//Читаем метаданные
            int bytesRead = waveReader.Read(buffer, meta, buffer.Length - meta);//Читаем аудиоданные
            string bits = "";//строка битов

            message += "[end]";//Добавляем в конец сообщения разделитель, по которому будем искать конец сообщения

            bits = ToBinaryBits(message);//Преобразуем каждый символ в 8-битный двоичный код 

            //Проверка на то, уместится ли сообщение в файл
            if (bits.Length > buffer.Length) { new Exception("Сообщение слишком длинное для этого аудиофайла."); }

            buffer_changed = Encode_message(bits, buffer);//Изменяем данные: Кодируем байты, изменяя биты 

            //Записываем файл с измененными битами
            using (BinaryWriter writer = new BinaryWriter(File.Create(Name_stego_wav_audio)))
            {
                writer.Write(start_44_buf);//Записываем метаданные
                writer.Write(buffer_changed);//записываем в файл массив
                Console.WriteLine("File has been written");//Сообщение об успехе
            }

            //Тестовая запись в файл
            //using (BinaryReader reader = new BinaryReader(File.Open(Name_stego_wav_audio, FileMode.Open)))
            //{
            //    // пока не достигнут конец файла
            //    // считываем каждое значение из файла
            //    byte[] buffer1 = reader.ReadBytes(buffer.Length + meta);
            //    Console.WriteLine("cojoiajsijdoijasd");
            //}


            //waveReader.Close();

            //using (BinaryReader reader = new BinaryReader(File.Open(Name_of_wav_file, FileMode.Open)))
            //{
            //    // пока не достигнут конец файла
            //    // считываем каждое значение из файла
            //    byte[] buffer2 = reader.ReadBytes(buffer.Length + meta);
            //    Console.WriteLine("cojoiajsijdoijasd");
            //    using (BinaryWriter writer = new BinaryWriter(File.Create(Name_stego_wav_audio)))
            //    {
            //        writer.Write(buffer2);//записываем в файл массив
            //        Console.WriteLine("File has been written");
            //    }
            //}
            waveReader.Close();
        }

        //Функция декодирования зашифрованного сообщения из WAV-файла
        static public string Decode(string Name_stego_wav_audio)
        {
            //WaveFileReader waveReader = new WaveFileReader(Name_of_wav_file);
            WaveFileReader waveReader = new WaveFileReader(Name_stego_wav_audio);//Поток чтения

            //Так как используем waveReader, то метаданные он уже считал
            byte[] buffer = new byte[waveReader.Length];//массив байтов wav-файла
            int bytesRead = waveReader.Read(buffer, 0, buffer.Length);//читаем wav-файла

            //Извлекаем LSB из каждого байта
            byte[] extracted_bits = new byte[waveReader.Length];//Массив полученных битов
            for (int i = 0; i < buffer.Length; i++)
            {
                extracted_bits[i] = (byte)(buffer[i] & 1);//извлечение бита
            }
            Console.WriteLine("");


            //Преобразуем биты в символы
            string message = string.Empty;//Расшифрованное сообщение
            double dec = 0;
            for (long i = 0; i + 8 < extracted_bits.Length; i += 8)
            {
                dec = ConvBinToDec(extracted_bits, i);//Преобразуем двоичный код битов в десятичные байты
                message += (char)dec;//Добавляем расшифрованный символ 

                if (message.EndsWith("[end]"))//Проверка на разделитель в конце
                {
                    waveReader.Close();// Закрываем поток
                    return message.Substring(0, message.Length - 5);//Возвращаем сообщение без разделителя, который стоял в конце
                }
            }
            waveReader.Close(); // Закрываем поток
            return "Error 0: no message";//Ошибка, если сообщение не найдется (Разделитель)
        }

        static public string ReadFromFile(string NameFileMessage)
        {
            string message = string.Empty;
            using (StreamReader reader = new StreamReader(NameFileMessage))
            {
                message =  reader.ReadToEnd();
            }
            return message;
        }
    }
}
