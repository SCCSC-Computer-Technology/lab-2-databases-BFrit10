/*Brian Fritsche
 * CPT 206 A01H
 * Lab 2*/



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FritscheB206Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cityBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cityBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.cityDBDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cityDBDataSet.City' table. You can move, or remove it, as needed.
            this.cityTableAdapter.Fill(this.cityDBDataSet.City);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAscend_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.PopAsc(this.cityDBDataSet.City);
        }

        private void btnDescend_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.PopDesc(this.cityDBDataSet.City);
        }

        private void btnCityName_Click(object sender, EventArgs e)
        {
            this.cityTableAdapter.CityAscend(this.cityDBDataSet.City);
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Total Population is: {cityTableAdapter.PopSum()}"
                + $"\nAverage Population is: {cityTableAdapter.PopAvg()}"
                + $"\nHighest Population is: {cityTableAdapter.PopHighest()}"
                + $"\nLowest Population is: {cityTableAdapter.PopLowest()}");
        }


    }
}
