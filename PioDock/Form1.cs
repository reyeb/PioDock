using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PioDock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "PioDock";
        }

        private void btnClearEntries_Click(object sender, EventArgs e)
        {
            txtDockedModelsFolderLocation.Text = "No File Chosen";
            txtLigandInterfaceAddress.Text = "No File Chosen";
            txtReceptorInterfaceAddress.Text = "No File Chosen"; 
           
        }

        private void btnDockedModelsChooseFile_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }
        public void ChooseFolder()
        {
            if (dockedModelsfolderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtDockedModelsFolderLocation.Text = dockedModelsfolderBrowserDialog1.SelectedPath;
            }
        }

        private void btnReceptorInterfaceChooseFile_Click(object sender, EventArgs e)
        {
           
            if (openPredictionFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                txtReceptorInterfaceAddress.Text = openPredictionFileDialog1.FileName;
            }
        }

        private void btnLigandInterfaceChooseFile_Click(object sender, EventArgs e)
        {
            if (openPredictionFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtLigandInterfaceAddress.Text = openPredictionFileDialog1.FileName;
            }

        }


        public static DataInput Input { get; set; }
        private void btnRankModels_Click(object sender, EventArgs e)
        {
            
            try
            {
              ValidateInputFields();
              
               Input = new DataInput
                {
                    DockedModelsFolderLocation = txtDockedModelsFolderLocation.Text,
                    LigandInterfacePredictionAddress = txtLigandInterfaceAddress.Text,
                    ReceptorInterfacePredictionAddress = txtReceptorInterfaceAddress.Text,
                   
                };
               Input.ValidateDataAvailibilty();
               var t = new DockingModelAnalyser();
               // AppendTextToRichTextBox(txtResult, Color.Blue, "Process Start");
               t.GetModelsRanking();
            }
            catch (ValidationException ex)
            {
                AppendTextToRichTextBox(txtResult, Color.Red, "ERROR!!!\n");
                AppendTextToRichTextBox(txtResult, Color.Empty, ex.Message + "\n");
                btnRankModels.Visible = false;
            }
            catch (Exception ex)
            {
                AppendTextToRichTextBox(txtResult, Color.Red, "An application error occurred. Please contact us with the following information and your input data.\n");
                AppendTextToRichTextBox(txtResult, Color.Empty, ex.StackTrace+"\n");
                btnRankModels.Visible = false;
            }
         
        }

        bool ValidateInputFields()
        {
            if (txtReceptorInterfaceAddress.Text == "No File Chosen" && txtLigandInterfaceAddress.Text == "No File Chosen")
            {
                MessageBox.Show("Choose an interface prediction file for Receptor/Ligand. It is necessary to have a file for at least one.");
                return false;
            }
            if (txtDockedModelsFolderLocation.Text == "No File Chosen")
            {
                MessageBox.Show("Choose a folder for docked pdb files of Receptor-Ligand.");
                return false;
            }

          
            return true;
        }

        void AppendTextToRichTextBox(RichTextBox box, Color color, string text)
        {
            int start = box.TextLength;
            box.AppendText(text);
            int end = box.TextLength;

            // Textbox may transform chars, so (end-start) != text.Length
            box.Select(start, end - start);
            {
                box.SelectionColor = color;
            }
            box.SelectionLength = 0; 
        }

        private void btnExample_Click(object sender, EventArgs e)
        {
            txtDockedModelsFolderLocation.Text = @".\DockedModels";
            txtLigandInterfaceAddress.Text = @".\ligandPrediction.txt";
               txtReceptorInterfaceAddress.Text = @"No File Chosen";
               btnRankModels_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var helpForm = new Form2();
            helpForm.Show();
        }

       
    }
}
