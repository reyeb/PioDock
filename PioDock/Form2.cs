﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PioDock
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Text = "Help";
            txtHelp.Text = text;
            this.txtHelp.AutoSize = true;
        }


        string text = @"
For a set of docked models generated for a receptor-ligand, PioDock scores and ranks them. To do so each docked model interface is compared against the interfaces predicted by TPIP for receptor/ligand.

The inputs to the PioDock software are:

1) Interface Information Section:

TPIP Prediction File for Receptor: This file is generated by TPIP software for receptor protein.
TPIP Prediction File for Ligand: This file is generated by TPIP software for ligand protein.
Note: at least one of these files are required to perform the ranking.

2) Docked Models Information Section:

Folder containing all docked pdb files of Receptor-Ligand: This folder contains all the docked models for the recptor-ligand pair which you aim to rank.

The pdb files should be in the following format:
-----------------------------------------------------------------------------------------
HEADER receptor.pdb
ATOM      1  N   ASP B   1      11.985  13.171  12.967  1.00  0.00      RB0  N
ATOM      2  H   ASP B   1      12.300  12.685  12.152  0.00  0.00      RB0  H
ATOM      3  CA  ASP B   1      11.956  12.358  14.123  1.00  0.00      RB0  C
...
END
HEADER ligand.pdb
ATOM      1  N   LYS B   1       1.175  52.651  14.891  1.00  0.00      LB0  N                          
ATOM      2  H   LYS B   1       0.942  52.114  15.705  0.00  0.00      LB0  H                          
ATOM      3  CA  LYS B   1       2.557  53.075  14.666  1.00  0.00      LB0  C    
...
END

-----------------------------------------------------------------------------------------

To see an example click “Run Example”.
To rank your own models specify the inputs and click “Rank Models”.

";
        
    }
}
