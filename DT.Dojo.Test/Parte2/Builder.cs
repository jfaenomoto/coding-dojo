using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.Dojo.Test.Parte2
{
    public interface Builder<T>
    {
        T build();
    }
}
