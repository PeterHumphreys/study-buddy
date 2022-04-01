﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Study_Buddy.BusinessLogic;

namespace Study_Buddy.Presentation
{
    public partial class AddGradeForm : Form, IView
    {
        private AddGradeFormController controller;
        public AddGradeForm()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Size = new System.Drawing.Size(1366, 768);
            this.mainPanel.MaximumSize = new System.Drawing.Size(1080, 720);
            this.mainPanel.Size = new System.Drawing.Size(1080, 720);
            this.nav1.SetCurrentForm(this);
        }
        
        public void SetController(FormController controller)
        {
            this.controller = (AddGradeFormController)controller;
        }

        private void butAddAssig_Click(object sender, EventArgs e)
        {
            Boolean valid = true;
            double points = 0;
            if (txtNameAssign.Text.Equals(""))
            {
                MessageBox.Show("Invalid Name");
                valid = false;
            }
            try
            {
                points = Double.Parse(txtPointsAssign.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Score");
                valid = false;
            }
            if (valid)
            {
                controller.AddGrade(txtNameAssign.Text, points);
                MessageBox.Show("Successfully added grade");
            }
        }

        private void AddGradeForm_Load(object sender, EventArgs e)
        {
            Course course = controller.course;
            foreach(Assignment assignment in course.assignments)
            {
                txtNameAssign.Items.Add(assignment.name);
            }
        }
    }
}