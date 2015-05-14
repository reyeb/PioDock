using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PioDock
{
   

    class DockingModelAnalyser
    {
        static List<DockedModelScore> DockeModelScoreList = new List<DockedModelScore>();
        //private readonly IYourForm form;
        //public DockingModelAnalyser(IYourForm form)
        //{
        //    this.form = form;
        //}
        // void hiii()
        //{
        //    string firstName = form.FirstName;
        //    form.FirstName = "some name";
            
        
        //}
        public void GetModelsRanking()
        {
            var allDockedPDBModels = Directory.GetFiles(Form1.Input.DockedModelsFolderLocation,"*.pdb");
            if (allDockedPDBModels.Count()==0 )
                throw new ValidationException("There are no pdb files in the provided folder");
            var predictedInterfaceInfo=InterfaceSeqCreator.SetPredictedInterfaces();

            foreach (var dockingModel in allDockedPDBModels)
            {

                var chainContents = File.ReadAllText(dockingModel).Split(new[] { "HEADER" }, StringSplitOptions.RemoveEmptyEntries);
                var fileparts = dockingModel.Split(new[] { "\\", ".pdb" }, StringSplitOptions.RemoveEmptyEntries);
                var modelName= fileparts[fileparts.Length - 1];

                var dockedModelInfo=GetDockedModelInfo(chainContents,  modelName,  predictedInterfaceInfo);
                var dockedModelInterfaces = InterfaceSeqCreator.CreateDockedInterfaceSequence(dockedModelInfo);
                var dcokedModelscore= ScoreCalculator.CalculateDockedModelScore(dockedModelInterfaces,predictedInterfaceInfo);

                FillDockedModelScoreList(dockedModelInfo.DockedModelName, dcokedModelscore);
            }

            GetDockModelRanking();
        }

        static DockedModelsChainInfo GetDockedModelInfo(string[] chainContents, string modelName, PredictedInterfaceInformation predictedInterfaceInfo)
        {
           Validator.ValidatePDBFiles(chainContents,modelName);
            var dockedModelInfo = new DockedModelsChainInfo
            {
                ReceptorAtomsList = PDBFileReader.CreateReceptorAtomLists(chainContents[0]),
                LigandAtomsList = PDBFileReader.CreateLigandAtomLists(chainContents[1]),
                DockedModelName = modelName,
            };

            Validator.ValidateInterfaceWithModelsProvided(dockedModelInfo, predictedInterfaceInfo);
            var interactionListofDockedModel = ComplexInterfaceGenerator.GenerateInterfaceResidues(dockedModelInfo.ReceptorAtomsList, dockedModelInfo.LigandAtomsList);
            dockedModelInfo.ReceptorInteractingAtomsList = interactionListofDockedModel.InteractingAtomsListR;
            dockedModelInfo.LigandInteractingAtomsList = interactionListofDockedModel.InteractingAtomsListL;

            return dockedModelInfo;
        }


        static void FillDockedModelScoreList(string modelName, double dcokedModelscore)
        {
            var scoredDockedModel = new DockedModelScore
            {
                ModelName = modelName,
                RankedScore = dcokedModelscore
            };
            DockeModelScoreList.Add(scoredDockedModel);
        }

        static void GetDockModelRanking()
        {
            DockeModelScoreList=DockeModelScoreList.OrderByDescending(a => a.RankedScore).ToList();
            FileHelper.WriteList(DockeModelScoreList);
        }
    }
}
