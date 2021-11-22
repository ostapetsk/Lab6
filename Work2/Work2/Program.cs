using System;
using System.IO;

namespace Work2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathMkvFile = @"C:\Users\user\Desktop\Лабораторна № 6\Work2\Work2\Media\MkvFile.Mkv";
            string pathMP3File = @"C:\Users\user\Desktop\Лабораторна № 6\Work2\Work2\Media\MP3File.mp3";
            string pathWavFile = @"C:\Users\user\Desktop\Лабораторна № 6\Work2\Work2\Media\WavFile.wav";
            string nameMkv = "MkvFile";
            string nameMP3 = "MP3File";
            string nameWav = "WavFile";
            File.Create(pathMkvFile).Dispose();
            File.Create(pathMP3File).Dispose();
            File.Create(pathWavFile).Dispose();
            Console.WriteLine("Файлы в папке Медиа: ");
            string[] massiveDirectories = new string[] { nameMkv, nameMP3, nameWav };
            foreach (string item in massiveDirectories)
            {
                Console.Write(item + "   ");
            }
            Console.WriteLine("");
            Console.WriteLine("Введите название файла для дальнейшей операции с ним");
            IMedia.name = Console.ReadLine();
            if (IMedia.name == "MkvFile")
            {
                IMedia.path = pathMkvFile;
            }
            else if (IMedia.name == "MP3File")
            {
                IMedia.path = pathMP3File;
            }
            else if (IMedia.name == "WavFile")
            {
                IMedia.path = pathWavFile;
            }
            PlayerItem pi = new PlayerItem();
        }
    }
}
