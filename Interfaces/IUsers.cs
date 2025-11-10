using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pr13.Models;

namespace Pr13.Interfaces
{
    public interface IUsers
    {
        void All(out List<Users> Users);
    }
}
