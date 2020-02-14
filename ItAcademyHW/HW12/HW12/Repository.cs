using System;
using System.Collections.Generic;
using System.Text;

namespace HW12
{
    class Repository : IRepository
    {

        private static List<Motorcycle> _storage  = new List<Motorcycle>();
        public void Create(Motorcycle entity)
        {

            Logger.Log.Info($"New moto {entity.Name} has been added to list. ID: {entity.Id}, " +
                $"Model: {entity.Model}, Year: {entity.Year}, Odometr: {entity.Odometr}");
            _storage.Add(entity);
        }

        public void Delete(Motorcycle entity)
        {
            Logger.Log.Info($"New moto {entity.Name} has been deleted from list. ID: {entity.Id}, " +
             $"Model: {entity.Model}, Year: {entity.Year}, Odometr: {entity.Odometr}");
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
                {
                    Logger.Log.Info($"Moto {entity.Name} has been update odometr from {entity.Odometr} to {newOdometr}: {entity.Id}, " +
                         $"Model: {entity.Model}, Year: {entity.Year}");
                      item.Odometr = newOdometr;
                }
                    
            }
        }
    }
}
