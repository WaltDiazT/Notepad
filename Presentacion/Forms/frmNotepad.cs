﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Forms
{
    public partial class frmNotepad : Form
    {
        public frmNotepad(AppCore.Services.DirectoryServices directoryServices)
        {
            InitializeComponent();
        }
    }
}