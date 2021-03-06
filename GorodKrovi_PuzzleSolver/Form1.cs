﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GorodKrovi_PuzzleSolver
{
    public partial class Form1 : Form
    {
        PathCoordinator coordinator = new PathCoordinator();

        public Form1()
        {
            InitializeComponent();


            cmbStartLocation.DataSource = coordinator.GetAirflowNodes(); ;
            cmbStartLocation.DisplayMember = "Name";
            cmbStartLocation.SelectedIndex = -1;

            cmbEndLocation.BindingContext = new BindingContext();
            cmbEndLocation.DataSource = coordinator.GetAirflowNodes();
            cmbEndLocation.DisplayMember = "Name";
            cmbEndLocation.SelectedIndex = -1;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (cmbStartLocation.SelectedItem != null && cmbEndLocation.SelectedItem != null)
            {
                txtOutput.Text = "";
                coordinator.InitializePuzzle((AirflowNode)cmbStartLocation.SelectedItem, (AirflowNode)cmbEndLocation.SelectedItem);

                Stopwatch timer = new Stopwatch();
                timer.Start();
                List<AirflowNode> path = coordinator.CalculatePath();
                timer.Stop();

                foreach (AirflowNode node in path)
                {
                    txtOutput.Text += node.Name;
                    if (node.currentIndex != 0)
                    {
                        txtOutput.Text += "(" + node.currentIndex.ToString() + ")";
                    }

                    txtOutput.Text += Environment.NewLine;
                }

                txtOutput.Text += Environment.NewLine;
                txtOutput.Text += "Calculated in " + timer.Elapsed.TotalMilliseconds + " milliseconds";
            }
            else
            {
                MessageBox.Show("You must select a start point and an endpoint before proceeding", "Missing Input Parameter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            coordinator = new PathCoordinator();
            cmbStartLocation.SelectedIndex = -1;
            cmbEndLocation.SelectedIndex = -1;
            txtOutput.Text = "";
        }
    }
}
