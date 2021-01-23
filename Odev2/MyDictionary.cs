using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<TKey, TValue>
    {
        TKey[] arrayKey;
        TValue[] arrayValue;

        TKey[] tempKey;
        TValue[] tempValue;

        public MyDictionary()
        {
            arrayKey = new TKey[0];
            arrayValue = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            tempKey = arrayKey;
            tempValue = arrayValue;

            arrayKey = new TKey[arrayKey.Length + 1];
            arrayValue = new TValue[arrayValue.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                arrayKey[i] = tempKey[i];
            }
            for (int i = 0; i < tempValue.Length; i++)
            {
                arrayValue[i] = tempValue[i];
            }

            arrayKey[arrayKey.Length - 1] = key;
            arrayValue[arrayValue.Length - 1] = value;

        }
    }
    }
}
