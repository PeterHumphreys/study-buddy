﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Study_Buddy.DataAccess;

namespace Study_Buddy.Presentation
{
    public partial class HomePageForm : Form
    {
        public HomePageForm()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.Size = new System.Drawing.Size(1366, 768);
            this.mainPanel.MaximumSize = new System.Drawing.Size(1080, 720);
            this.mainPanel.Size = new System.Drawing.Size(1080, 720);
        }

        // Add Assignment Button
        private void button2_Click(object sender, EventArgs e)
        {
            FormController.openForm(new AddAssignmentForm());
        }

        // Add Course Button
        private void button3_Click(object sender, EventArgs e)
        {
            FormController.openForm(new addCourseForm());
        }

        // Visualize My Data Button
        private void button4_Click(object sender, EventArgs e)
        {
            FormController.openForm(new CourseInfoForm());
        }

        private void nav1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bloop");
            Point cursor = PointToClient(new Point(Cursor.Position.X, Cursor.Position.Y));
            Control control = (Control)sender;   // Sender gives you which control is clicked.
            Control child = control.GetChildAtPoint(cursor);
            MessageBox.Show(child.Name.ToString());
        }
    }
}
