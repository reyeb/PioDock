using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PioDock
{
    public class DataInput
    {
        //DataInput() { }

        public string ReceptorInterfacePredictionAddress { get;  set; }
        public string LigandInterfacePredictionAddress { get;  set; }
        public string DockedModelsFolderLocation { get;  set; }
     
       
        public void ValidateDataAvailibilty()
        {

            if (ReceptorInterfacePredictionAddress!= "No File Chosen" &&  File.Exists(ReceptorInterfacePredictionAddress) == false)
            {
                throw new ValidationException("The interface predicted file for receptor does not exist.");
            }
            if (LigandInterfacePredictionAddress != "No File Chosen" && File.Exists(LigandInterfacePredictionAddress) == false)
            {
                throw new ValidationException("TThe interface predicted file for ligand does not exist.");
            }

            if (Directory.Exists(DockedModelsFolderLocation) == false)
            {
                throw new ValidationException("The docked model folders does not exist.");
            }

          
        }
    }
}
