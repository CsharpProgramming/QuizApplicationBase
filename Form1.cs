using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApplication
{
    public partial class Form1 : Form
    {
        public static Form1 instance;

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            LabelTittle.Visible = false;
            LabelDescription.Visible = false;
            ButtonStart.Visible = false;

            QuestionTemplate QT = new QuestionTemplate();
            QT.Dock = DockStyle.Fill;
            QuestionContainer.Controls.Clear();
            QuestionContainer.Controls.Add(QT);
        }
    }
}
