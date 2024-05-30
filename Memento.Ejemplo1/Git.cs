using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Ejemplo1
{
    public class Git
    {
        private List<Commit> _savedStates = new List<Commit>();
        public void Commit(Repository repo)
        {
            _savedStates.Add(repo.SaveState());
        }
        public void Revert(Repository repo) 
        {
            if (_savedStates.Any())
            {
                var lastState = _savedStates[_savedStates.Count - 2];
                repo.RestoreState(lastState);
                _savedStates.Remove(lastState);
            }
        }
    }
}
