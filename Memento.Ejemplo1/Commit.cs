using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Ejemplo1
{
    public class Commit
    {
        public string Code { get; private set; }
        public Commit(string code)
        { 
            Code = code; 
        }
    }
}
