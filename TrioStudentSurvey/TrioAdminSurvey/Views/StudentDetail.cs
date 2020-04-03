using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrioStudentSurvey.Models;

namespace TrioAdminSurvey.Views
{
    public partial class StudentDetail : Form
    {
        Form sender;
        Survey Survey;
        public StudentDetail()
        {
            InitializeComponent();
        }

        public StudentDetail(Survey survey, Form f)
        {
            InitializeComponent();
            Survey = survey;
            sender = f;
            label1.Text = survey.FirstName + " " + survey.LastName;


            
        }

        private void StudentDetail_FormClosing(object s, FormClosingEventArgs e)
        {
            
            MessageBox.Show("Form Closing");
            sender.Show();
        }

        private void StudentDetail_Load(object sender, EventArgs e)
        {

        }
    }
}
