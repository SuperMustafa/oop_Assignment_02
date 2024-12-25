using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_session_2_demo
{
    internal struct Contacts
    {
        string[] names;
        long[] numbers;
        int size;

        public int Size
        {
            get { return size; }
        }

        //==============parameterized constructor=============
        public Contacts(int _size)
        {
            size = _size;
            names = new string[size];
            numbers = new long[size];
        }

        public void AddContact(string Name, long number, int index)
        {
            if (names is not null && numbers is not null)
            {
                if (index >= 0 && index < size)
                {
                    names[index] = Name;
                    numbers[index] = number;
                }

            }
        }
        #region indexer
        // indexer is a special property
        // indexer always named this
        // indexer take parameter
        public long this[string name]
        {
            get
            {
                if(names is not null&&numbers is not null)
                {
                    for(int i = 0; i < names.Length; i++)
                    {
                        if (name == names[i])
                        {
                            return numbers[i];
                        }
                    }
                }
                return -1;


            }
            set
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (name == names[i])
                        {
                             numbers[i]=value;
                        }
                    }
                }
                
            }
    }
    }
    #endregion

}
