using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PioDock
{
    class DockedModelsChainInfo
    {
        public string DockedModelName { get; set; }
        public List<AACoordinate> ReceptorAtomsList { get; set; }
        public List<AACoordinate> LigandAtomsList { get; set; }
        public List<string> ReceptorInteractingAtomsList { get; set; }
        public List<string> LigandInteractingAtomsList { get; set; }
    }
}
