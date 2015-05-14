namespace PioDock
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblReceptorInterface = new System.Windows.Forms.Label();
            this.lblLigandInterface = new System.Windows.Forms.Label();
            this.btnReceptorInterfaceChooseFile = new System.Windows.Forms.Button();
            this.dockedModelsfolderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtReceptorInterfaceAddress = new System.Windows.Forms.TextBox();
            this.txtLigandInterfaceAddress = new System.Windows.Forms.TextBox();
            this.btnLigandInterfaceChooseFile = new System.Windows.Forms.Button();
            this.lblDockedModels = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDockedModelsFolderLocation = new System.Windows.Forms.TextBox();
            this.btnDockedModelsChooseFile = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRankModels = new System.Windows.Forms.Button();
            this.btnClearEntries = new System.Windows.Forms.Button();
            this.openPredictionFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.btnExample = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblReceptorInterface
            // 
            this.lblReceptorInterface.AutoSize = true;
            this.lblReceptorInterface.Location = new System.Drawing.Point(12, 31);
            this.lblReceptorInterface.Name = "lblReceptorInterface";
            this.lblReceptorInterface.Size = new System.Drawing.Size(165, 13);
            this.lblReceptorInterface.TabIndex = 0;
            this.lblReceptorInterface.Text = "TPIP Prediction File for Receptor:";
            // 
            // lblLigandInterface
            // 
            this.lblLigandInterface.AutoSize = true;
            this.lblLigandInterface.Location = new System.Drawing.Point(12, 60);
            this.lblLigandInterface.Name = "lblLigandInterface";
            this.lblLigandInterface.Size = new System.Drawing.Size(153, 13);
            this.lblLigandInterface.TabIndex = 1;
            this.lblLigandInterface.Text = "TPIP Prediction File for Ligand:";
            // 
            // btnReceptorInterfaceChooseFile
            // 
            this.btnReceptorInterfaceChooseFile.Location = new System.Drawing.Point(504, 31);
            this.btnReceptorInterfaceChooseFile.Name = "btnReceptorInterfaceChooseFile";
            this.btnReceptorInterfaceChooseFile.Size = new System.Drawing.Size(91, 20);
            this.btnReceptorInterfaceChooseFile.TabIndex = 2;
            this.btnReceptorInterfaceChooseFile.Text = "Choose File";
            this.btnReceptorInterfaceChooseFile.UseVisualStyleBackColor = true;
            this.btnReceptorInterfaceChooseFile.Click += new System.EventHandler(this.btnReceptorInterfaceChooseFile_Click);
            // 
            // txtReceptorInterfaceAddress
            // 
            this.txtReceptorInterfaceAddress.Location = new System.Drawing.Point(183, 31);
            this.txtReceptorInterfaceAddress.Name = "txtReceptorInterfaceAddress";
            this.txtReceptorInterfaceAddress.Size = new System.Drawing.Size(298, 20);
            this.txtReceptorInterfaceAddress.TabIndex = 3;
            this.txtReceptorInterfaceAddress.Text = "No File Chosen";
            // 
            // txtLigandInterfaceAddress
            // 
            this.txtLigandInterfaceAddress.Location = new System.Drawing.Point(183, 59);
            this.txtLigandInterfaceAddress.Name = "txtLigandInterfaceAddress";
            this.txtLigandInterfaceAddress.Size = new System.Drawing.Size(297, 20);
            this.txtLigandInterfaceAddress.TabIndex = 4;
            this.txtLigandInterfaceAddress.Text = "No File Chosen";
            // 
            // btnLigandInterfaceChooseFile
            // 
            this.btnLigandInterfaceChooseFile.Location = new System.Drawing.Point(504, 59);
            this.btnLigandInterfaceChooseFile.Name = "btnLigandInterfaceChooseFile";
            this.btnLigandInterfaceChooseFile.Size = new System.Drawing.Size(91, 20);
            this.btnLigandInterfaceChooseFile.TabIndex = 5;
            this.btnLigandInterfaceChooseFile.Text = "Choose File";
            this.btnLigandInterfaceChooseFile.UseVisualStyleBackColor = true;
            this.btnLigandInterfaceChooseFile.Click += new System.EventHandler(this.btnLigandInterfaceChooseFile_Click);
            // 
            // lblDockedModels
            // 
            this.lblDockedModels.AutoSize = true;
            this.lblDockedModels.Location = new System.Drawing.Point(12, 25);
            this.lblDockedModels.Name = "lblDockedModels";
            this.lblDockedModels.Size = new System.Drawing.Size(327, 13);
            this.lblDockedModels.TabIndex = 6;
            this.lblDockedModels.Text = "Select the folder containing all docked pdb files of Receptor-Ligand:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLigandInterfaceChooseFile);
            this.groupBox1.Controls.Add(this.txtLigandInterfaceAddress);
            this.groupBox1.Controls.Add(this.txtReceptorInterfaceAddress);
            this.groupBox1.Controls.Add(this.btnReceptorInterfaceChooseFile);
            this.groupBox1.Controls.Add(this.lblLigandInterface);
            this.groupBox1.Controls.Add(this.lblReceptorInterface);
            this.groupBox1.Location = new System.Drawing.Point(9, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(630, 107);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Interface Information";
            // 
            // txtDockedModelsFolderLocation
            // 
            this.txtDockedModelsFolderLocation.Location = new System.Drawing.Point(15, 54);
            this.txtDockedModelsFolderLocation.Name = "txtDockedModelsFolderLocation";
            this.txtDockedModelsFolderLocation.Size = new System.Drawing.Size(306, 20);
            this.txtDockedModelsFolderLocation.TabIndex = 8;
            this.txtDockedModelsFolderLocation.Text = "D:\\Reyhaneh\\Works\\BioInformatics-Kingston\\Research\\Investments\\Apps\\PioDock\\clusp" +
                "ro.1AY7";
            // 
            // btnDockedModelsChooseFile
            // 
            this.btnDockedModelsChooseFile.Location = new System.Drawing.Point(355, 53);
            this.btnDockedModelsChooseFile.Name = "btnDockedModelsChooseFile";
            this.btnDockedModelsChooseFile.Size = new System.Drawing.Size(91, 20);
            this.btnDockedModelsChooseFile.TabIndex = 9;
            this.btnDockedModelsChooseFile.Text = "Choose File";
            this.btnDockedModelsChooseFile.UseVisualStyleBackColor = true;
            this.btnDockedModelsChooseFile.Click += new System.EventHandler(this.btnDockedModelsChooseFile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDockedModelsChooseFile);
            this.groupBox2.Controls.Add(this.txtDockedModelsFolderLocation);
            this.groupBox2.Controls.Add(this.lblDockedModels);
            this.groupBox2.Location = new System.Drawing.Point(9, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(629, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Docked Models Information";
            // 
            // btnRankModels
            // 
            this.btnRankModels.Location = new System.Drawing.Point(55, 256);
            this.btnRankModels.Name = "btnRankModels";
            this.btnRankModels.Size = new System.Drawing.Size(108, 23);
            this.btnRankModels.TabIndex = 11;
            this.btnRankModels.Text = "Rank Models";
            this.btnRankModels.UseVisualStyleBackColor = true;
            this.btnRankModels.Click += new System.EventHandler(this.btnRankModels_Click);
            // 
            // btnClearEntries
            // 
            this.btnClearEntries.Location = new System.Drawing.Point(192, 256);
            this.btnClearEntries.Name = "btnClearEntries";
            this.btnClearEntries.Size = new System.Drawing.Size(88, 23);
            this.btnClearEntries.TabIndex = 12;
            this.btnClearEntries.Text = "Clear Entries";
            this.btnClearEntries.UseVisualStyleBackColor = true;
            this.btnClearEntries.Click += new System.EventHandler(this.btnClearEntries_Click);
            // 
            // openPredictionFileDialog1
            // 
            this.openPredictionFileDialog1.FileName = "openFileDialog1";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(24, 314);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(100, 13);
            this.lblResult.TabIndex = 14;
            this.lblResult.Text = "Process Information";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(24, 344);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(614, 125);
            this.txtResult.TabIndex = 15;
            this.txtResult.Text = "";
            // 
            // btnExample
            // 
            this.btnExample.Location = new System.Drawing.Point(513, 256);
            this.btnExample.Name = "btnExample";
            this.btnExample.Size = new System.Drawing.Size(113, 23);
            this.btnExample.TabIndex = 17;
            this.btnExample.Text = "Run Example";
            this.btnExample.UseVisualStyleBackColor = true;
            this.btnExample.Click += new System.EventHandler(this.btnExample_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(139, 520);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Help";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 520);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Click Help for more info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 542);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExample);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnClearEntries);
            this.Controls.Add(this.btnRankModels);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "t";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReceptorInterface;
        private System.Windows.Forms.Label lblLigandInterface;
        private System.Windows.Forms.Button btnReceptorInterfaceChooseFile;
        private System.Windows.Forms.FolderBrowserDialog dockedModelsfolderBrowserDialog1;
        private System.Windows.Forms.TextBox txtReceptorInterfaceAddress;
        private System.Windows.Forms.TextBox txtLigandInterfaceAddress;
        private System.Windows.Forms.Button btnLigandInterfaceChooseFile;
        private System.Windows.Forms.Label lblDockedModels;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDockedModelsFolderLocation;
        private System.Windows.Forms.Button btnDockedModelsChooseFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRankModels;
        private System.Windows.Forms.Button btnClearEntries;
        private System.Windows.Forms.OpenFileDialog openPredictionFileDialog1;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.Button btnExample;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

