using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN212_NERONMEN
{
    public interface IBasic<T> where T : struct
    {
        T add(T a, T b);
    }
}
