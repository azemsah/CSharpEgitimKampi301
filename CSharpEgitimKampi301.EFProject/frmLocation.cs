﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampi301.EFProject
{
    public partial class frmLocation : Form
    {
        public frmLocation()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravleDbEntities db = new EgitimKampiEfTravleDbEntities();

        private void btnList_Click(object sender, EventArgs e)
        {
            var values = db.Location.ToList();
            dataGridView1.DataSource = values;
        }

        
    }
}
