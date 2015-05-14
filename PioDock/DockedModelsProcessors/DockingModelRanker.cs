using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PioDock
{
    class DockingModelRanker
    {
        static string receptorPredictedInterface="";
        static string ligandPredictedInterface = "";
        public static InterfacePredictionAvailibility InterfaceAvailibility { get; private set; }
        public static List<string> RankModels()
        {
            var RankedList = new List<string>();
            var allDockedPDBModels = Directory.GetFiles(Form1.Input.DockedModelsFolderLocation,"*.pdb");
            if (allDockedPDBModels.Count()==0 )
                throw new ValidationException("There are no pdb files in the provided folder");
            SetPredictedInterfaces();
            foreach (var dockingModel in allDockedPDBModels)
            {

                var chainContents = File.ReadAllText(dockingModel).Split(new[] { "HEADER" }, StringSplitOptions.RemoveEmptyEntries);
                var fileparts = dockingModel.Split(new[] { "\\", ".pdb" }, StringSplitOptions.RemoveEmptyEntries);

                var dockedModel = new DockedModelsChainInfo
                {
                    ReceptorAtomsList = PDBFileReader.CreateReceptorAtomLists(chainContents[0]),
                    LigandAtomsList = PDBFileReader.CreateLigandAtomLists(chainContents[1]),
                    DockedModelName = fileparts[fileparts.Length - 1],
                };

                ValidateInterfaceWithModelsProvided(dockedModel);
                var interactionListofDockedModel= ComplexInterfaceGenerator.GenerateInterfaceResidues(dockedModel.ReceptorAtomsList, dockedModel.LigandAtomsList);
                dockedModel.ReceptorInteractingAtomsList = interactionListofDockedModel.InteractingAtomsListR;
                dockedModel.LigandInteractingAtomsList = interactionListofDockedModel.InteractingAtomsListL;
            }

            return RankedList;
        }

        static void ValidatePDBFiles (string[] chainContent, string dockedFileName)
        {
            if (chainContent.Count() < 2)
                throw new ValidationException("The provided docked PDB file "+dockedFileName+"contains less than 2 chains!" );
            if (chainContent.Count() > 2)
                throw new ValidationException("The provided docked PDB file " + dockedFileName + "contains more than 2 chains!");
        }
        /// <summary>
        /// Checks if length wise the interface provided and the number of residues do match
        /// </summary>
        /// <param name="dockedModel"></param>
        static void ValidateInterfaceWithModelsProvided(DockedModelsChainInfo dockedModel)
        {
            var receptorCalphaResidues= dockedModel.ReceptorAtomsList.Where(a => a.atomName == "CA").Select(a => a).ToList();
            var ligandCalphaResidues = dockedModel.LigandAtomsList.Where(a => a.atomName == "CA").Select(a => a).ToList();
            if (InterfaceAvailibility == InterfacePredictionAvailibility.ReceptorSideOnly || InterfaceAvailibility == InterfacePredictionAvailibility.BothSide)
            {
                if (receptorCalphaResidues.Count() != receptorPredictedInterface.Length)
                    throw new ValidationException("The provided docked PDB file for "+dockedModel.DockedModelName+" and the receptor interface prediction result do not match!");
            }

            if (InterfaceAvailibility == InterfacePredictionAvailibility.LigandSideOnly || InterfaceAvailibility == InterfacePredictionAvailibility.BothSide)
            {
                if (ligandCalphaResidues.Count() != ligandPredictedInterface.Length)
                    throw new ValidationException("The provided docked PDB file " + dockedModel.DockedModelName + " and the ligand interface prediction result do not match!");
            }
            
        }

        /// <summary>
        /// sets the [predicted interface for receptor and ligand and decides which is not availible.
        /// at this stage at least one is selected otherwise an exception is thrown earlier in teh program.
        /// </summary>
        static void SetPredictedInterfaces()
        {
            if (Form1.Input.LigandInterfacePredictionAddress == "No File Chosen")
            {
                receptorPredictedInterface = GetPredictedInteface(Form1.Input.ReceptorInterfacePredictionAddress);
                InterfaceAvailibility = InterfacePredictionAvailibility.ReceptorSideOnly;
            }

            else if (Form1.Input.ReceptorInterfacePredictionAddress == "No File Chosen")
            {
                ligandPredictedInterface = GetPredictedInteface(Form1.Input.LigandInterfacePredictionAddress);
                InterfaceAvailibility = InterfacePredictionAvailibility.LigandSideOnly;
            }
            else
            {
                receptorPredictedInterface = GetPredictedInteface(Form1.Input.ReceptorInterfacePredictionAddress);
                ligandPredictedInterface = GetPredictedInteface(Form1.Input.LigandInterfacePredictionAddress);
                InterfaceAvailibility = InterfacePredictionAvailibility.BothSide;
            }
          
               
        }
        /// <summary>
        /// This function reads the prediction gnerated by TPIP and returns the predicted Interface
        /// </summary>
        static string GetPredictedInteface(string path)
        {
            var content=File.ReadAllLines(path);
            return content[2];
        }

         public enum InterfacePredictionAvailibility
         {
            ReceptorSideOnly = 0,
            LigandSideOnly = 1,
            BothSide=2
         }

            

    }
}
