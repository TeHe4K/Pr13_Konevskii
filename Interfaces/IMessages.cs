
using System.Collections.Generic;
using Pr13.Models;

namespace Pr13.Interfaces
{
    public interface IMessages
    {
        void All(out List<Messages> Messages);
        void Save(bool Update = false);
        void Delete();
    }
}
