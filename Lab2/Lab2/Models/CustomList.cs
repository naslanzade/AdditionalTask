using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Models
{
    class CustomList<T>
    {
        public static int Id { get; set; }
        
        private T[] _datas;

        static int _id = 0;

        public CustomList()
        {
            _id++;
            Id = _id;
            _datas = new T[0];
        }
              

     

        public void Add(T data)
        {
            Array.Resize(ref _datas, _datas.Length + 1);

            _datas[_datas.Length - 1] = data;
        }


        public T[] GetAll()
        {

            return _datas;

        }



    }
}
