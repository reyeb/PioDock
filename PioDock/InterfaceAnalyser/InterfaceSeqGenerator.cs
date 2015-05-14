using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PioDock
{
    public class DockedInterfaceSequence
    {
        public string DockedReceptorInterface { get; set; }
        public string DockedLigandnterface { get; set; }
    }

    public class PredictedInterfaceInformation
    {
        public string PredictedReceptorInterface { get; set; }
        public string PredictedLigandnterface { get; set; }
        public InterfacePredictionAvailibility InterfaceAvailibility { get; set; }
    }
    public enum InterfacePredictionAvailibility
    {
        ReceptorSideOnly = 0,
        LigandSideOnly = 1,
        BothSide = 2
    }

   static class InterfaceSeqCreator
    {
       public static DockedInterfaceSequence CreateDockedInterfaceSequence(DockedModelsChainInfo dockedModel)
        {
            var interactionSeq = new DockedInterfaceSequence();
            var mapperSequnceR = dockedModel.ReceptorAtomsList.Where(a => a.atomName == "CA").Select(a => a.ResiNumber).ToList();
            interactionSeq.DockedReceptorInterface = CreateIntSeq(mapperSequnceR, dockedModel.ReceptorInteractingAtomsList);

            var mapperSequnceL = dockedModel.LigandAtomsList.Where(a => a.atomName == "CA").Select(a => a.ResiNumber).ToList();
            interactionSeq.DockedLigandnterface = CreateIntSeq(mapperSequnceL, dockedModel.LigandInteractingAtomsList);
            return interactionSeq;
        }

        static string CreateIntSeq(List<int> mapperSequnce, List<int> InteractingResi)
        {
            var interactionString = "";
            foreach (var resi in mapperSequnce)
            {


                if (InteractingResi.Contains(resi))

                    interactionString += "I";

                else
                    interactionString += ".";

            }

            return interactionString;
        }
         
        /// <summary>
        /// sets the predicted interface for receptor and ligand and decides which is not availible.
        /// at this stage at least one is selected otherwise an exception is thrown earlier in teh program.
        /// </summary>
        public static PredictedInterfaceInformation SetPredictedInterfaces()
        {
            var predictedInterInfo = new PredictedInterfaceInformation();
          
            if (Form1.Input.LigandInterfacePredictionAddress == "No File Chosen")
            {
                predictedInterInfo.PredictedReceptorInterface = GetPredictedInteface(Form1.Input.ReceptorInterfacePredictionAddress);
                predictedInterInfo.InterfaceAvailibility = InterfacePredictionAvailibility.ReceptorSideOnly;
            }

            else if (Form1.Input.ReceptorInterfacePredictionAddress == "No File Chosen")
            {
                predictedInterInfo.PredictedLigandnterface = GetPredictedInteface(Form1.Input.LigandInterfacePredictionAddress);
                predictedInterInfo.InterfaceAvailibility = InterfacePredictionAvailibility.LigandSideOnly;
            }
            else
            {
                predictedInterInfo.PredictedReceptorInterface = GetPredictedInteface(Form1.Input.ReceptorInterfacePredictionAddress);
                predictedInterInfo.PredictedLigandnterface = GetPredictedInteface(Form1.Input.LigandInterfacePredictionAddress);
                predictedInterInfo.InterfaceAvailibility = InterfacePredictionAvailibility.BothSide;
            }
            return predictedInterInfo;

        }

        /// <summary>
        /// This function reads the prediction gnerated by TPIP and returns the predicted Interface
        /// </summary>
        static string GetPredictedInteface(string path)
        {
            var content = File.ReadAllLines(path);
            return content[2];
        }
    }
}
