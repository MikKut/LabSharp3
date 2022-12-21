using Lb3_CSharp.Models;
using System;
using System.Collections.Generic;

namespace Lb2_Sharp.FactoriesDirection
{
    internal class FactoriesDirection
    {
        private static FactoriesDirection instance;
        private static object syncRoot;
        private Dictionary<string, IFactory> _factories;
        private FactoriesDirection()
        {
            _factories = new Dictionary<string, IFactory>();
        }

        public int Size { get => _factories.Count; }
        public Dictionary<string, IFactory> Factories => _factories;
        public static FactoriesDirection GetInstance()
        {
            if (instance == null)
            {
                syncRoot = new object();
                lock (syncRoot)
                {
                    instance = new FactoriesDirection();
                }
            }

            return instance;
        }
        public void SetDictionary(Dictionary<string, IFactory> factories)
        {
            if (factories == null)
            {
                throw new ArgumentNullException($"The passed {nameof(factories)} are null");
            }

            this._factories = factories;
        }
        public bool AddFactory(IFactory factory)
        {
            if (factory == null)
            {
                throw new ArgumentNullException("Factory is null");
            }

            if (_factories.ContainsKey(factory.Name))
            {
                return false;
            }

            _factories.Add(factory.Name, factory);
            return true;
        }

        public bool DeleteFactory(IFactory factory)
        {
            if (factory == null)
            {
                throw new ArgumentNullException("Factory is null");
            }

            if (!_factories.ContainsKey(factory.Name))
            {
                return false;
            }

            _factories.Remove(factory.Name);
            return true;
        }

        public Dictionary<string, IFactory> GetAllFactories()
        {
            return _factories;
        }

        public IFactory GetFactory(string name)
        {
            return _factories[name];
        }
    }
}
