using System;
using System.IO;
using System.Text;

namespace ImageReader
{
    class Program
    {
        static void Main(string[] args)
        {            
            const string _pathToJpeg = @"D:\Images\Bitmap.bmp";
            const string _finalPath = @"D:\Images\Final.bmp";
            
            
            
            const string _message = "Secret Message To Transfer";

            //Cripting();
            //GetDataFromImage(_pathToJpeg);
        }

        //private static void GetDataFromImage(string _pathToJpeg)
        //{
        //    FileStream _readFs;
        //    byte[] _pictureByte;
        //    byte[] _byteData;

        //    try
        //    {
        //        // Загрузка картинки
        //        using (_readFs = new FileStream(_pathToJpeg, FileMode.Open, FileAccess.Read))
        //        {
        //            _pictureByte = new byte[_readFs.Length];
        //            int byteCounter = Convert.ToInt32(_pictureByte.Length);

        //            _readFs.Read(_pictureByte, 0, byteCounter);
        //            _readFs.Close();
        //        }

        //        // Преобразуем сообщение в массив байтов
        //        Encoding ascEnc = Encoding.ASCII;
        //        _byteData = ascEnc.GetBytes(_message);

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Во время выполнения произошла ошибка: \n {ex.Message}");
        //        Console.ReadLine();
        //    }
        //}

        //private static void Cripting()
        //{
        //    // Обязательно проверяем, что число бит в картинке достататочно для записи текста
        //    if ((_pictureByte.Length - 54) < (_byteData.Length * 8))
        //    {
        //        Console.WriteLine("Шифрование невозможно, т.к. шифруемый файл превышает размер изображения!!!");
        //    }

        //    else // если всё нормально (есть место)
        //    {
        //        int k = 54; // 54 байта в bmp  занимает заголовок - далее мы лишь увеличиваем отступ
        //                    // в цилке записываем данные в картинку
        //        for (int i = 0; i < _byteData.Length; i++)
        //        {
        //            int bit = 0;
        //            for (int j = 0; j < 8; j++)
        //            {
        //                bit = (_byteData[i] & (0x01 << j)) >> j;
        //                _pictureByte[k] = Convert.ToByte(((_pictureByte[k] >> 1) << 1) | bit);
        //                k++; // нарашиваем отсутп(так как мы удаляемся от начала файла)
        //            }
        //        }

        //        File.WriteAllBytes(_finalPath, _pictureByte);
        //    }
        //}
    }
}
