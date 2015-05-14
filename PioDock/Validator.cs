using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PioDock
{
    class Validator
    {
        public static void ValidatePDBFiles(string[] chainContent, string dockedFileName)
        {
            if (chainContent.Count() < 2)
                throw new ValidationException("The provided docked PDB file " + dockedFileName + "contains less than 2 chains!");
            if (chainContent.Count() > 2)
                throw new ValidationException("The provided docked PDB file " + dockedFileName + "contains more than 2 chains!");
        }
        /// <summary>
        /// Checks if length wise the interface provided and the number of residues do match
        /// </summary>
        /// <param name="dockedModel"></param>
        public static void ValidateInterfaceWithModelsProvided(DockedModelsChainInfo dockedModel,PredictedInterfaceInformation predictedInterfaceInfo )
        {
            var receptorCalphaResidues = dockedModel.ReceptorAtomsList.Where(a => a.atomName == "CA").Select(a => a).ToList();
            var ligandCalphaResidues = dockedModel.LigandAtomsList.Where(a => a.atomName == "CA").Select(a => a).ToList();
            var InterfaceAvailibility = predictedInterfaceInfo.InterfaceAvailibility;
            if (InterfaceAvailibility == InterfacePredictionAvailibility.ReceptorSideOnly || InterfaceAvailibility == InterfacePredictionAvailibility.BothSide)
            {
                if (receptorCalphaResidues.Count() != predictedInterfaceInfo.PredictedReceptorInterface.Length)
                    throw new ValidationException("The provided docked PDB file for " + dockedModel.DockedModelName + " and the receptor interface prediction result do not match!");
            }

            if (InterfaceAvailibility == InterfacePredictionAvailibility.LigandSideOnly || InterfaceAvailibility == InterfacePredictionAvailibility.BothSide)
            {
                if (ligandCalphaResidues.Count() != predictedInterfaceInfo.PredictedLigandnterface.Length)
                    throw new ValidationException("The provided docked PDB file " + dockedModel.DockedModelName + " and the ligand interface prediction result do not match!");
            }

        }
    }
}
