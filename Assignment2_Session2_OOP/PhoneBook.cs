using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_Session2_OOP
{
    internal struct PhoneBook
    {
        string[] names;
        long[] numbers;
        int size;

        public int Size
        {
            get { return size; }
        }

        public PhoneBook(int _size)
        {
            size = _size;
            names = new string[size];
            numbers = new long[size];
        }
        public void AddPerson(int position, String name, long num)
        {
            if(names is not null && numbers is not null)
            {
                if(position >= 0 && position > size)
                {
                    names[position] = name;
                    numbers[position] = num;
                }
            }
        }

        public long this[string Name]
        {
            get 
            {
                if (names is not null && numbers is not null)
                {
                    for (int i = 0; i < names.Length; i++)
                    {
                        if (Name == names[i])
                            return numbers[i];
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
                        if (Name == names[i])
                             numbers[i]= value;
                    }
                }

            }
        }
    }

   
}
