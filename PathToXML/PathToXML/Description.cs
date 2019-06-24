﻿using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Linq;

namespace PathToXML
{
    /// <summary>
    /// Возвращает строку - описание для xml файла, которое выбирается по ключевым словам в пути к файлу или папке.
    /// </summary>
    class Description
    {
        public static string Show(string folderPath)
        {

            string description = "Прочее";
            string folderName = new DirectoryInfo(folderPath).Name;

            if (folderName.Contains("enum"))
            {
                description = "Классы перечислений";
            }
            if (folderName.Contains("LibTiff"))
            {
                description = "Общие классы, используемые в библиотеке";
            }
            if (folderName.Contains("zLib"))
            {
                description = "Классы потоковые";
            }
            if (folderName.Contains("Properties"))
            {
                description = "Классы свойств";
            }
            if (folderName.Contains("obj"))
            {
                description = "Классы объектов";
            }
            if (folderName.Contains("jpeg"))
            {
                description = "Классы взаимодействия с графикой";
            }
            if (folderName.Contains("Internal"))
            {
                description = "Классы для внутреннего использования";
            }
            if (folderName.Contains("Tiff2Pdf"))
            {
                description = "Классы конвертации в pdf";
            }
            if (folderName.Contains("C#"))
            {
                description = "C# версия классов";
            }
            if (folderName.Contains("WriteTagsBeforeData"))
            {
                description = "Классы тэгов";
            }
            if (folderName.Contains("write"))
            {
                description = "Классы записи файлов";
            }
            if (folderName.Contains("WriteBlackWhiteTiff"))
            {
                description = "Классы записи черно-белых Tiff";
            }
            if (folderName.Contains("using"))
            {
                description = "Классы описания using";
            }
            if (folderName.Contains("TiffWithColorMap"))
            {
                description = "Классы Tiff с цветной палитрой";
            }
            if (folderName.Contains("32Bit"))
            {
                description = "Классы 32-битной  версии";
            }
            if (folderName.Contains("24Bit"))
            {
                description = "Классы 24-битной  версии";
            }
            if (folderName.Contains("TiffTo24BitBitmap"))
            {
                description = "Классы конвертации в 24-битную версию";
            }
            if (folderName.Contains("SimpleTiffCopy"))
            {
                description = "Классы быстрого копирования";
            }
            if (folderName.Contains("RotateTiff"))
            {
                description = "Классы поворота Tiff";
            }
            if (folderName.Contains("rotate"))
            {
                description = "Классы описывающие вращение";
            }
            if (folderName.Contains("ReadWriteCustomTags"))
            {
                description = "Классы описывающие чтение/запись кастомных тэгов";
            }
            if (folderName.Contains("ReadUnknownTagValue"))
            {
                description = "Классы описывающие считывание неизвестных тэгов";
            }
            if (folderName.Contains("ReadSamples"))
            {
                description = "Классы описывающие считывание образцов";
            }
            if (folderName.Contains("ReadExifMetadata"))
            {
                description = "Классы описывающие считывание метаданных";
            }
            if (folderName.Contains("ReadBasicProperties"))
            {
                description = "Классы описывающие считывание базовых свойств";
            }
            if (folderName.Contains("ReadArbitraryScanlines"))
            {
                description = "Классы описывающие произвольные сканлинии ";
            }
            if (folderName.Contains("Process16BitSamples"))
            {
                description = "Классы описывающие обработку 16 битных образцов";
            }
            if (folderName.Contains("PrintDirectory"))
            {
                description = "Классы описывающие печать директории";
            }
            if (folderName.Contains("NumberOfPages"))
            {
                description = "Классы описывающие число страниц";
            }
            if (folderName.Contains("ImageToBitonalTiff"))
            {
                description = "Классы описывающие конвертацию изображения в монохромный Tiff";
            }
            if (folderName.Contains("EnumerateTiffTags"))
            {
                description = "Классы описывающие перечисление тэгов ";
            }
            if (folderName.Contains("DetermineCorruptPage"))
            {
                description = "Классы описывающие распознавание поврежденной страницы";
            }
            if (folderName.Contains("CreateMultipageTiff"))
            {
                description = "Классы описывающие создание мультистраничного Tiff";
            }
            if (folderName.Contains("CreateGradientTiff"))
            {
                description = "Классы описывающие создание векторного Tiff";
            }
            if (folderName.Contains("Create16BitGrayscaleTiff"))
            {
                description = "Классы описывающие создание 16 битного Tiff (оттенки серого)";
            }
            if (folderName.Contains("ConvertToSingleStripInMemory"))
            {
                description = "Классы описывающие конвертацию в однополосный тип хранения";
            }
            if (folderName.Contains("ConvertToSingleStrip"))
            {
                description = "Конвертация в однополосный тип хранения";
            }
            if (folderName.Contains("Convert16BitTo8Bit"))
            {
                description = "Конвертация 16 бит в 8 бит";
            }
            if (folderName.Contains("BitonalTiffToBitmap"))
            {
                description = "Конвертация битонального в массив битов ";
            }
            if (folderName.Contains("BitmapTo32BitColorTiff"))
            {
                description = "Конвертация массива в 32 бит цвет";
            }
            if (folderName.Contains("BitmapTo24BitColorTiff"))
            {
                description = "Конвертация массива в 24 бит цвет";
            }
            if (folderName.Contains("AddPageToTiff"))
            {
                description = "Добавить страницу в Tiff";
            }
            if (folderName.Contains("AddCustomTagsToExistingTiff"))
            {
                description = "Добавление кастомных тэгов в существующий Tiff";
            }
            if (folderName.Contains("zLib"))
            {
                description = "zLib библиотека Tiff";
            }
            if (folderName.Contains("LibJpeg"))
            {
                description = "Библиотеки Jpeg";
            }
            if (folderName.Contains("TiffCP"))
            {
                description = "Объединение файлов в многостраничный";
            }
            if (folderName.Contains("UnitTests"))
            {
                description = "Тест кейсы";
            }
            if (folderName.Contains("Samples"))
            {
                description = "Примеры";
            }
            if (folderName.Contains("UsingCustomTiffStream"))
            {
                description = "Кастомный потоки Tiff";
            }
            if (folderName.Contains("UsingSystemIOStream"))
            {
                description = "Работа с IOS потоками";
            }
            if (folderName.Contains("Tiff2Rgba"))
            {
                description = "Конвертация Tiff в RGBA";
            }
            if (folderName.Contains("Debug"))
            {
                description = "Отладка";
            }
            if (folderName.Contains("netcoreapp2.0"))
            {
                description = "Версия .Net 2.0";
            }
            if (folderName.Contains("netstandard1.3"))
            {
                description = "Версия .NET 1.3";
            }
            if (folderName.Contains("Enums"))
            {
                description = "Объекты-перечисления, используемые в библиотеке";
            }
            if (folderName.Contains("NotifyIconWpf"))
            {
                description = "Объекты Wpf, используемые в библиотеке";
            }
            if (folderName.Contains("Interop"))
            {
                description = "Объекты взаимодействия, используемые  в библиотеке";
            }
            if (folderName.Contains("CodeCompletion"))
            {
                description = "Объекты, отвечающие за автозавершение ";
            }
            if (folderName.Contains("Document"))
            {
                description = "Классы описывающие работу с документами";
            }
            if (folderName.Contains("Highlighting"))
            {
                description = "Объекты, отвечающие за выделение";
            }
            if (folderName.Contains("Folding"))
            {
                description = "Объекты, отвечающие за группировку кода";
            }
            if (folderName.Contains("Editing"))
            {
                description = "Объекты, отвечающие за редактирование";
            }
            if (folderName.Contains("Resources"))
            {
                description = "Объекты ресурсов";
            }
            if (folderName.Contains("Xshd"))
            {
                description = "Объекты, отвечающие за работу с .Xshd файлами";
            }
            if (folderName.Contains("Indentation"))
            {
                description = "Объекты, отвечающие за табуляцию";
            }
            if (folderName.Contains("Rendering"))
            {
                description = "Объекты, отвечающие за рендеринг";
            }
            if (folderName.Contains("Search"))
            {
                description = "Объекты, отвечающие за поиск";
            }
            if (folderName.Contains("Snippets"))
            {
                description = "Объекты - сниппеты";
            }
            if (folderName.Contains("Utils"))
            {
                description = "Утилиты";
            }
            if (folderName.Contains("src"))
            {
                description = "Источник";
            }
            if (folderName.Contains("CsvHelper"))
            {
                description = "Корневая директория";
            }
            if (folderName.Contains("Configuration"))
            {
                description = "Конфигурация";
            }
            if (folderName.Contains("Attributes"))
            {
                description = "Атрибуты";
            }
            if (folderName.Contains("Expressions"))
            {
                description = "Выражения";
            }
            if (folderName.Contains("TypeConversion"))
            {
                description = "Объекты конвертации типов данных";
            }
            if (folderName.Contains("DocsGenerator"))
            {
                description = "Объекты генерации документов";
            }
            if (folderName.Contains("Formatters"))
            {
                description = "Объекты отвечающие за форматирование";
            }
            if (folderName.Contains("Generators"))
            {
                description = "Объекты отвечающие за генерацию";
            }
            if (folderName.Contains("Infos"))
            {
                description = "Объекты - описания";
            }
            if (folderName.Contains("Performance"))
            {
                description = "Объекты отвечанию за производительность";
            }
            if (folderName.Contains("ITfoxtec.Saml2"))
            {
                description = "Корнево каталог";
            }
            if (folderName.Contains("Binding"))
            {
                description = "Объекты свойств binding";
            }
            if (folderName.Contains("Claim"))
            {
                description = "Объявление типов";
            }
            if (folderName.Contains("Cryptography"))
            {
                description = "Объекты описывающие работу с шифрованием данных";
            }
            if (folderName.Contains("Extension"))
            {
                description = "Расширения";
            }
            if (folderName.Contains("Schema"))
            {
                description = "Схемы данных";
            }
            if (folderName.Contains("Metadata"))
            {
                description = "Метаданные";
            }
            if (folderName.Contains("Tokens"))
            {
                description = "Объекты описывающие токены";
            }
            if (folderName.Contains("Util"))
            {
                description = "Утилиты";
            }
            if (folderName.Contains("ITfoxtec.Saml2.Mvc"))
            {
                description = "Объекты MVC";
            }
            if (folderName.Contains("Saml2BindingExtensions"))
            {
                description = "Расширения SAML to Binding";
            }
            if (folderName.Contains("Autodiscover"))
            {
                description = "Автообнаружение";
            }
            if (folderName.Contains("Availability"))
            {
                description = "Доступность сотрудников";
            }
            if (folderName.Contains("PeopleInsights"))
            {
                description = "Сотрудники в поле зрения";
            }
            if (folderName.Contains("Recurrence"))
            {
                description = "Повторное проявление";
            }
            if (folderName.Contains("Pattern"))
            {
                description = "Шаблоны";
            }
            if (folderName.Contains("Range"))
            {
                description = "Диапазоны";
            }
            if (folderName.Contains("TimeZones"))
            {
                description = "Часовые пояса";
            }
            if (folderName.Contains("Core"))
            {
                description = "Ядро";
            }
            if (folderName.Contains("Request"))
            {
                description = "Запросы";
            }
            if (folderName.Contains("Response"))
            {
                description = "Ответы";
            }
            if (folderName.Contains("Credentials"))
            {
                description = "Разрешения";
            }
            if (folderName.Contains("Dns"))
            {
                description = "DNS объекты";
            }
            if (folderName.Contains("Elc"))
            {
                description = "Объекты описывающие работу ELC";
            }
            if (folderName.Contains("Enumeration"))
            {
                description = "Объекты-перечисления";
            }
            if (folderName.Contains("Exception"))
            {
                description = "Объекты-исключения";
            }
            if (folderName.Contains("Group"))
            {
                description = "Объекты-групп";
            }
            if (folderName.Contains("Interface"))
            {
                description = "Объекты, описывающие интерфейсы";
            }
            if (folderName.Contains("Misc"))
            {
                description = "Объекты, описывающие MISC ";
            }
            if (folderName.Contains("Availability"))
            {
                description = "Доступность";
            }
            if (folderName.Contains("IdConversion"))
            {
                description = "Описание конвертации идентификатора";
            }
            if (folderName.Contains("Notification"))
            {
                description = "Описание уведомлений";
            }
            if (folderName.Contains("PropertyDefinition"))
            {
                description = "Задание свойств";
            }
            if (folderName.Contains("Filter"))
            {
                description = "Описание фильтрации";
            }
            if (folderName.Contains("Security"))
            {
                description = "Объекты, отвечающие за безопасность данных";
            }
            if (folderName.Contains("Sync"))
            {
                description = "Объекты, отвечающие за синхронизацию данных";
            }
            if (folderName.Contains("UnifiedMessaging"))
            {
                description = "Унифицированный обмен сообщениями";
            }
           
            //if (folderName.Contains(""))
            //{
            //    description = "";
            //}
            return description;
        }
    }
}
