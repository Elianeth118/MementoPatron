using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Ejemplo1
{
    public class Repository
    {
        public string Code {  get; set; }
        public Commit SaveState()
        {
            return new Commit (Code);
        }
        public void RestoreState(Commit memento)
        { 
            Code = memento.Code;
        }
    }
}
