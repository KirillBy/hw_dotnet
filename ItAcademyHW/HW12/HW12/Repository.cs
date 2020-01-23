using System;
using System.Collections.Generic;
using System.Text;

namespace HW12
{
    class Repository : IRepository
    {
        private const int _arraySize = 15; 
        private Motorcycle[] _storage = new Motorcycle[_arraySize];

        public void Create(Motorcycle entity)
        {
            bool freePlace = false;
            for (int i = 0; i < _storage.Length; i++)
            {
                if (_storage[i] == null )
                {
                    _storage[i] = entity;
                    freePlace = true;
                    break;
                }
                    
            }
            if(!freePlace)
            Console.WriteLine("No empty place in array. Delete some motoes");
        }

        public void Delete(Motorcycle entity)
        {
            for(int i = 0; i < _storage.Length; i++)
            {
                if (_storage[i] != null && _storage[i].Equals(entity))
                    _storage[i] = null;
            }
        }

        public Motorcycle ReadById(uint Id)
        {
            for (int i = 0; i < _storage.Length; i++)
            {
                if (_storage[i].Id == Id)
                    return _storage[i];
            }
            return null;
        }

        public void Update(Motorcycle entity, uint newOdometr)
        {
            for (int i = 0; i < _storage.Length; i++)
            {
                
                if (_storage[i] != null && _storage[i].Equals(entity))
                    _storage[i].Odometr = newOdometr;
            }
        }
    }
}
