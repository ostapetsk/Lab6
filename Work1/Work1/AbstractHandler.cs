using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Work1
{
    class AbstractHandler
    {
        public string Input1;
        public string Input2;
        public string Name;
        public string FileDirect = "";
        public AbstractHandler()
        {
            WhatNumber();
            WhatDoing();
            if (Input2 == "1")
            {
                WhatName();
                File.Create(FileDirect).Dispose();
                Console.WriteLine("Файл создан");
            }
            else if (Input2 == "2")
            {
                File.Delete(FileDirect);
                Console.WriteLine("Файл удален");
            }
            else if (Input2 == "3")
            {
                string LaterText = Convert.ToString(File.ReadAllText(FileDirect));
                Console.WriteLine("Текст внутри: " + LaterText);
                Console.WriteLine("Введите текст, который вы хотите добавить в файл: ");
                string NewText = Console.ReadLine();
                File.AppendAllText(FileDirect, NewText);
            }
        }
        public void WhatNumber()
        {
            Console.WriteLine("С каким типом документа вы хотите работать?");
            Console.WriteLine("1 - .txt");
            Console.WriteLine("2 - .pdf");
            Console.WriteLine("3 - .docx");
            Console.WriteLine("4 - .xlsx");
            Input1 = Console.ReadLine();
            if (Input1 == "1")
            {
                FileDirect = @"C:\Users\user\Desktop\" + Name + ".txt";
            }
            else if (Input1 == "2")
            {
                FileDirect = @"C:\Users\user\Desktop\" + Name + ".pdf";
            }
            else if (Input1 == "3")
            {
                FileDirect = @"C:\Users\user\Desktop\" + Name + ".docx";
            }
            else if (Input1 == "4")
            {
                FileDirect = @"C:\Users\user\Desktop\" + Name + ".xlsx";
            }
        }
        public void WhatName()
        {
            Console.WriteLine("Введите имя файла:");
            Name = Console.ReadLine();
        }
        public void WhatDoing()
        {
            Console.WriteLine("Что делать с заданым типом файлом?");
            Console.WriteLine("1 - создать на рабочем столе");
            Console.WriteLine("2 - удалить за указанной директорией");
            Console.WriteLine("3 - открыть с возможностью редактирования");
            Input2 = Console.ReadLine();
        }
    }
}
