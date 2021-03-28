using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8.IndexerAndItems
{
    class IndexerArray
    {
        int[] arr;
        public int length;
        int result;
        public IndexerArray(int size)
        {
            arr = new int[size];
            length = size;
        }

        public bool ErrorOperation;
        public int this[int index]
        {
            get
            {
                if (ok(index))
                {
                    ErrorOperation = false;
                    return arr[index];
                }
                else
                {
                    ErrorOperation = true;
                    return 0;
                }
            }
            set
            {
                if (ok(index))
                {
                    arr[index] = value;
                    ErrorOperation = false;
                }
                else
                {
                    ErrorOperation = true;
                }
            }
        }

        private int resultInSquare
        {
            get
            {
                return result*result;
            }
            set
            {
                result = value;
            }
        }

        public void ArrayInSquare()
        {
            for (int i = 0; i < length; i++)
            {
                resultInSquare = arr[i];
                Console.WriteLine("array " + "[" + i + "]" + " = " + resultInSquare);
            }            
        }

        //Возвратить логическое значение true, если
        //индекс находится в установленных границах
        private bool ok(int index)
        {
            if (index >= 0 && index < length) return true;
            return false;
        }
    }

}
