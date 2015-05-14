using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PioDock
{
    public class InteractingAtomList
    {
        public List<string> InteractingAtomsListR { get; set; }
        public List<string> InteractingAtomsListL { get; set; }
    }

    static class ComplexInterfaceGenerator
    {
        static double EuclideanDistance(AACoordinate point1, AACoordinate point2)
        {
            var xp = Math.Pow(point1.X - point2.X, 2);
            var yp = Math.Pow(point1.Y - point2.Y, 2);
            var zp = Math.Pow(point1.Z - point2.Z, 2);
            var dis = Math.Sqrt(xp + yp + zp);
            return dis;
        }

         public static InteractingAtomList GenerateInterfaceResidues(List<AACoordinate> receptorAtomsList, List<AACoordinate> ligandAtomsList)
        {

            var interactingAtomResults = new InteractingAtomList();
            var receptorIntercationList = new List<string>();
            var ligandIntercationList = new List<string>();

            foreach (var receptorAtom in receptorAtomsList)
            {

                if (receptorAtom.atomName != "H")
                {
                    foreach (var ligandAtom in ligandAtomsList)
                    {

                        var dis = EuclideanDistance(receptorAtom, ligandAtom);

                        if (dis < Constant.betweenChainDistanceThershold)
                        {
                            receptorIntercationList.Add(receptorAtom.ResiNumber.ToString());
                            ligandIntercationList.Add(ligandAtom.ResiNumber.ToString());
                        }
                    }
                }
            }
            interactingAtomResults.InteractingAtomsListR = receptorIntercationList.Distinct().ToList();
            interactingAtomResults.InteractingAtomsListL = ligandIntercationList.OrderBy(a => a).ToList().Distinct().ToList();

            return interactingAtomResults;
        }


        public static String CreateInteractionSeqforDockedModels(List<string> Atoms)
        {
           
        }

        public static string CreateSquence()
        {
        }
    }
}
