using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSingleton
{
    public class SingletonClass
    {
        private static SingletonClass _instance;
        private String _value;

        private SingletonClass()
        {
            SetValueToRandomValue();
        }

        public static SingletonClass GetInstance()
        {
            if (_instance == null)
            {
                System.Threading.Mutex mutex = new System.Threading.Mutex();
                mutex.WaitOne();

                if (_instance == null)
                {
                    _instance = new SingletonClass();
                }

                mutex.ReleaseMutex();
            }

            return _instance;
        }

        public string GetValue()
        {
            return _value;        
        }

        private void SetValueToRandomValue()
        {
            System.Random randomizer = new System.Random(); 
            System.Threading.Mutex mutex = new System.Threading.Mutex();
            mutex.WaitOne();
            _value = randomizer.Next(1,1000000).ToString();
            mutex.ReleaseMutex();
        }
    }
}
