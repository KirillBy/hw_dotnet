using System;
using System.Collections.Generic;
using System.Text;

namespace HW12
{
    public interface IRepository
    {
        void Create(Motorcycle entity);
        void Delete(Motorcycle entity);
        Motorcycle ReadById(uint Id);
        void Update (Motorcycle entity, uint newOdometr);

    }
}
