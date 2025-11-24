
using System.Collections.Generic;
using Pr13.Models;

namespace Pr13.Interfaces
{
    public interface IUsers
    {
        void All(out List<Users> Users);
    }
}
