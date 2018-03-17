#define WRITELOGFILE

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace DigitalBiblePlatformSharp.Test
{

    internal static class TestUtils
    {
        private const string ApiKeyEnvironmentVariableName = "DBPSharpApiKey";

        public const string LogFileLocation = @"D:\Temp\TestLog";

        static TestUtils()
        {
            Directory.CreateDirectory(LogFileLocation);
        }

        public static void WriteLogFile<T>(T obj, [System.Runtime.CompilerServices.CallerMemberName] string callingMethod = "")
        {
#if WRITELOGFILE
            var path = Path.Combine(LogFileLocation, callingMethod + ".json");
            var content = (typeof(T) == typeof(string)) ? (obj as string) : JsonConvert.SerializeObject(obj);

            File.WriteAllText(path, content);
#endif
        }

        public static void IsNotNullOrEmpty<T>(IEnumerable<T> enumerable)
        {
            Assert.IsNotNull(enumerable);
            Assert.AreNotEqual(0, enumerable.Count());
        }

        public static DigitalBiblePlatformService GetService()
        {
            var apiKey = Environment.GetEnvironmentVariable(ApiKeyEnvironmentVariableName);

            if (string.IsNullOrEmpty(apiKey))
            {
                throw new ArgumentException($"Api not found. For unit testing, please assign your API Key to environment variable named {ApiKeyEnvironmentVariableName}.");
            }

            return new DigitalBiblePlatformService(apiKey);
        }

    }

}
