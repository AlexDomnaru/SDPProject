using System;
using System.Collections.Generic;
using System.Text;
using Data.Domain.Entities;

namespace Business.Interfaces
{
    public interface IAboutYouRepository<T> : IRepository<T> where T: IEntity
    {
    }
}
