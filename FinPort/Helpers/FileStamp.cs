﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinPort.Helpers
{
    public class FileStamp
    {
        public static string MakeUnique(string fileName)
        {
            var extension = Path.GetExtension(fileName);
            fileName = Path.GetFileNameWithoutExtension(fileName);
            fileName = SlugMaker.MakeSlug(fileName);
            fileName = $"{fileName}{DateTime.Now.Ticks}{extension}";
            return fileName;
        }
    }
}