using Lb3_CSharp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb2_CSharp.FileOperations
{
    internal static class Paths
    {
        private const string ExtensionOfFiles = ".txt";
        private static string pathToFactoryData = Directory.GetCurrentDirectory() + "\\FactoryData",
            nameOfGeneralDictionary = "total" + ExtensionOfFiles;
        static Paths()
        {
            if (!Directory.Exists(pathToFactoryData))
            {
                Directory.CreateDirectory(pathToFactoryData);
            }
        }
        public static string GetPathToFIleOfTotalDirectories()
        {
            var x = pathToFactoryData + "\\" + nameOfGeneralDictionary;
            return x;
        }
        public static string GetPathToCertainFile(PathsCategory category, string factoryName)
        {
            string pathToResultDirectory = Paths.pathToFactoryData + "\\" + category.ToString();
            if (!Directory.Exists(pathToResultDirectory))
            {
                Directory.CreateDirectory(pathToResultDirectory);
            }

            string resultString =  pathToResultDirectory +"\\" + factoryName + ExtensionOfFiles;
            if (!File.Exists(resultString))
            {
                using (var x = File.Create(resultString))
                {

                }
            }

            return resultString;
        }
    }
    enum PathsCategory
    {
        Masters,
        Employees,
        Factories
    }
}
