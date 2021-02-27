using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T, Y>
    {
       public T[] forKeys;
       public Y[] forVal;
        
        public MyDictionary()
        {
            forKeys = new T[0];
            forVal = new Y[0];
        }

        public void Add(T key, Y val)
        {
            T[] tempKey = forKeys;
            Y[] tempVal = forVal;
            forKeys = new T[forKeys.Length + 1];
            forVal = new Y[forVal.Length + 1];
            for (int i = 0; i < tempKey.Length; i++)
            {
                tempKey[i] = forKeys[i];
            }
            for (int i = 0; i < tempVal.Length; i++)
            {
                tempVal[i] = forVal[i];
            }
            forKeys[forKeys.Length - 1] = key;
            forVal[forVal.Length - 1] = val;
        
        }
        public int Count()
        {
            return forKeys.Length;
        }
    }
   
}
