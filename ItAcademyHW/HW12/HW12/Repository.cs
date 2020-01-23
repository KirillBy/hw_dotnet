using System;
using System.Collections.Generic;
using System.Text;

namespace HW12
{
    class Repository : IRepository
    {
        private const int _arraySize = 15; 
       //private Motorcycle[] _storage = new Motorcycle[_arraySize];
        private static List<Motorcycle> _storage  = new List<Motorcycle>();
        public void Create(Motorcycle entity)
        {
            _storage.Add(entity);
        }

        public void Delete(Motorcycle entity)
        {
            _storage.Remove(entity);
        }

        public Motorcycle ReadById(uint Id)
        {
            foreach (var item in _storage)
            {
                if (item.Id == Id)
                    return item;
            }
            return null;
        }

        public void Update(Motorcycle entity, uint newOdometr)
        {
            foreach (var item in _storage)
            {
                if (item == entity && item.Odometr < newOdometr)
                    item.Odometr = newOdometr;
            }
        }
    }
}
