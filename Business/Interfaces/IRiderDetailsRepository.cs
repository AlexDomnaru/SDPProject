using System;
using System.Collections.Generic;
using System.Text;
using Data.Domain.Entities;

namespace Business.Interfaces
{
    public interface IRiderDetailsRepository<T>: IRepository<T> where T: IEntity
    {
    }
}
