using Lb2_Sharp.FactoriesDirection;
using Lb3_CSharp.Models;
using Lb3_CSharp.Models.HR;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Lb2_CSharp.FileOperations
{
    internal static class FileOperator
    {
        public static void DeserializeSavedFactories()
        {
            string st = File.ReadAllText(Paths.GetPathToFIleOfTotalDirectories());
            Dictionary<string, Factory> oldDictionary = JsonConvert.DeserializeObject<Dictionary<string, Factory>>(st);
            var newDictionary = new Dictionary<string, IFactory>();
            foreach (var factory in oldDictionary)
            {
                var factoryString = File.ReadAllText(Paths.GetPathToCertainFile(PathsCategory.Factories, factory.Key));
                var newFactory = JsonConvert.DeserializeObject<Factory>(factoryString);

                var masterSting = File.ReadAllText(Paths.GetPathToCertainFile(PathsCategory.Masters, factory.Key));
                var masters = JsonConvert.DeserializeObject<Dictionary<string, Master>>(masterSting);

                var slaveSting = File.ReadAllText(Paths.GetPathToCertainFile(PathsCategory.Employees, factory.Key));
                var slaves = JsonConvert.DeserializeObject<Dictionary<string, Slave>>(slaveSting);

                newDictionary.Add(factory.Key,
                    new Factory(newFactory.Name, newFactory.Workshops, new FactoryHR(slaves, masters, newFactory.FactoryHR.IncomePerSlave, newFactory.FactoryHR.IncomePerMaster)));
            }

            FactoriesDirection.GetInstance().SetDictionary(newDictionary);
        }

        public static void SerializeCurrentFactoryState(Dictionary<string, IFactory> factories)
        {
            var dictionarySerialized = JsonConvert.SerializeObject(factories, Formatting.Indented);
            var path = Paths.GetPathToFIleOfTotalDirectories();
            File.WriteAllText(path, dictionarySerialized);
            foreach (var factory in factories)
            {
                var factoryString = JsonConvert.SerializeObject(factory.Value, Formatting.Indented);
                var masters = JsonConvert.SerializeObject(factory.Value.FactoryHR.Masters, Formatting.Indented);
                var slaves = JsonConvert.SerializeObject(factory.Value.FactoryHR.Employees, Formatting.Indented);
                File.WriteAllText(Paths.GetPathToCertainFile(PathsCategory.Factories, factory.Key), factoryString);
                File.WriteAllText(Paths.GetPathToCertainFile(PathsCategory.Masters, factory.Key), masters);
                File.WriteAllText(Paths.GetPathToCertainFile(PathsCategory.Employees, factory.Key), slaves);
            }
        }
    }
    enum Category
    {
        Masters,
        Slaves,
        Dictionary
    }
}
