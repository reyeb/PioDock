using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PioDock
{
   static class ScoreCalculator
    {

        public static double CalculateDockedModelScore(DockedInterfaceSequence dockedInterfaceSequences, PredictedInterfaceInformation predictedInterfaceInfo)
        {
            double rScore = 0;
            double lScore = 0;
            if (predictedInterfaceInfo.InterfaceAvailibility != InterfacePredictionAvailibility.LigandSideOnly)
                rScore = CalculateInterfaceSimScore(predictedInterfaceInfo.PredictedReceptorInterface, dockedInterfaceSequences.DockedReceptorInterface);
            if (predictedInterfaceInfo.InterfaceAvailibility != InterfacePredictionAvailibility.ReceptorSideOnly)
                lScore = CalculateInterfaceSimScore(predictedInterfaceInfo.PredictedLigandnterface, dockedInterfaceSequences.DockedLigandnterface);
            var finalScore = (lScore + rScore) / 2;

            return finalScore;
           
        }
        static double CalculateInterfaceSimScore(string predictedSeq, string dockedSeq)
        {

            int j = 0;
            double TP = 0;
            var totalGroundTruthInt = predictedSeq.Where(a => a == 'I').Select(a => a).Count();
            var totalQuaryInt = dockedSeq.Where(a => a == 'I').Select(a => a).Count();
            foreach (var resi in predictedSeq)
            {
                if (resi == 'I')
                {
                    if (dockedSeq[j] == 'I')
                    {
                        TP++;
                    }
                }

                j++;
            }

            var Bottom = Math.Sqrt(totalGroundTruthInt * totalQuaryInt);
            var score = TP / Bottom;
            return score;
        }
    }
}
