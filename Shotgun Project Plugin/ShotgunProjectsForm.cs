﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sg_prj {
    public partial class ShotgunProjectsForm : Form {
        public ShotgunProjectsForm() {
            InitializeComponent();
        }

        private void ShotgunProjectsForm_Load(object sender, EventArgs e) {
            ActiveControl = projectsGrid;
        }
    }
}
