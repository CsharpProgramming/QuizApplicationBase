using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApplication
{
    public partial class Form1 : Form
    {
        public static Form1 instance;

        string ColorTheme = "Pink";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ColorTheme = "Blue"; //Themes: Pink, Green, Yellow, Blue

            Theme();
        }

        private void Theme()
        {
            if (ColorTheme == "Green")
            {
                ButtonStart.FillColor = Color.OliveDrab;
                ButtonStart.FillColor2 = Color.GreenYellow;
                LabelTittle.ForeColor = Color.OliveDrab;
                LabelDescription.ForeColor = Color.OliveDrab;
            }

            else if (ColorTheme == "Yellow")
            {
                ButtonStart.FillColor = Color.Yellow;
                ButtonStart.FillColor2 = Color.Olive;
                LabelTittle.ForeColor = Color.Yellow;
                LabelDescription.ForeColor = Color.Yellow;
            }

            else if (ColorTheme == "Blue")
            {
                ButtonStart.FillColor = Color.Aquamarine;
                ButtonStart.FillColor2 = Color.Turquoise;
                LabelTittle.ForeColor = Color.Aquamarine;
                LabelDescription.ForeColor = Color.Aquamarine;
            }

            else
            {
                ButtonStart.FillColor = Color.RosyBrown;
                ButtonStart.FillColor = Color.LightCoral;
                LabelTittle.ForeColor = Color.RosyBrown;
                LabelDescription.ForeColor = Color.RosyBrown;
            }
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
