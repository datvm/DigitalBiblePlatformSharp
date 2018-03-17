#define WRITELOGFILE

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DigitalBiblePlatformSharp.Test
{

    internal static class TestUtils
    {

        public const string LogFileLocation = @"D:\Temp\TestLog";

        static TestUtils()
        {
            Directory.CreateDirectory(LogFileLocation);
        }

        public static void WriteLogFile<T>(string methodName, T obj)
        {
#if WRITELOGFILE
            var path = Path.Combine(LogFileLocation, methodName + ".json");
            var content = (typeof(T) == typeof(string)) ? (obj as string) : JsonConvert.SerializeObject(obj);

            File.WriteAllText(path, content);
#endif
        }

        public static void IsNotNullOrEmpty<T>(IEnumerable<T> enumerable)
        {
            Assert.IsNotNull(enumerable);
            Assert.AreNotEqual(0, enumerable.Count());
        }

    }

}
