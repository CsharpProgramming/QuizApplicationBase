using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApplication
{
    public partial class QuestionTemplate : UserControl
    {
        int CorrectA = 0;
        int QuestionID = 0;
        int Score = 0;
        string ColorTheme = "Pink";
        string PromptMessage = "Select the answer!";
        bool GaveA = false;

        public QuestionTemplate()
        {
            InitializeComponent();
        }

        private void QuestionTemplate_Load(object sender, EventArgs e)
        {
            ColorTheme = "Blue"; //Themes: Pink, Green, Yellow, Blue
            PromptMessage = "Select the answer";

            Theme();
            ManageQuestions();
        }

        private void ManageQuestions()
        {
            timer1.Stop();
            QuestionID++;

            Question(1, "Writes Hello World!", "Gives a error: Hello World!", "Writes Hello world", "Plays a mp3: Hello world", 1, "Console.WriteLine(\"Hello World!\")");
            Question(2, "Writes Hello World", "Gives a error!", "Writes Hello world", "Gives you free bitcoin", 2, "Console.WriteLine(Hello World!)");
            Question(3, "Writes 4", "Gives a error!", "Writes 2 + 2", "Gives you free bitcoin", 3, "Console.WriteLine(\"2 + 2\")");

            if (QuestionID == 4)
            {
                //End of the Quiz
                label1.Visible = true;
                label2.Visible = true;
                label2.Text = "Score: " + Score;
                CodeQuestion.Visible = false;
                LabelResult.Visible = false;
                Button1.Enabled = false;
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
            }
        }

        //Dont change this code to add custom questions change the upper one

        public void Question(int QuestionNumber, string A1, string A2, string A3, string A4, int Correct, string Code)
        {
            if (QuestionNumber == QuestionID)
            {
                GaveA = false;

                Button1.Text = A1;
                Button2.Text = A2;
                Button3.Text = A3;
                Button4.Text = A4;
                CodeQuestion.Text = Code;

                //Set correct button
                CorrectA = Correct;

                Button1.Enabled = true;
                Button2.Enabled = true;
                Button3.Enabled = true;
                Button4.Enabled = true;

                LabelResult.Text = PromptMessage;
            }
        }

        private void Theme()
        {
            if (ColorTheme == "Green")
            {
                Button1.FillColor = Color.OliveDrab;
                Button1.FillColor2 = Color.GreenYellow;
                Button2.FillColor = Color.OliveDrab;
                Button2.FillColor2 = Color.GreenYellow;
                Button3.FillColor = Color.OliveDrab;
                Button3.FillColor2 = Color.GreenYellow;
                Button4.FillColor = Color.OliveDrab;
                Button4.FillColor2 = Color.GreenYellow;

                label1.ForeColor = Color.OliveDrab;
                label2.ForeColor = Color.OliveDrab;
                CodeQuestion.ForeColor = Color.OliveDrab;
                LabelResult.ForeColor = Color.OliveDrab;
            }

            if (ColorTheme == "Yellow")
            {
                Button1.FillColor = Color.Yellow;
                Button1.FillColor2 = Color.Olive;
                Button2.FillColor = Color.Yellow;
                Button2.FillColor2 = Color.Olive;
                Button3.FillColor = Color.Yellow;
                Button3.FillColor2 = Color.Olive;
                Button4.FillColor = Color.Yellow;
                Button4.FillColor2 = Color.Olive;

                label1.ForeColor = Color.Yellow;
                label2.ForeColor = Color.Yellow;
                CodeQuestion.ForeColor = Color.Yellow;
                LabelResult.ForeColor = Color.Yellow;
            }

            if (ColorTheme == "Blue")
            {
                Button1.FillColor = Color.Aquamarine;
                Button1.FillColor2 = Color.Turquoise;
                Button2.FillColor = Color.Aquamarine;
                Button2.FillColor2 = Color.Turquoise;
                Button3.FillColor = Color.Aquamarine;
                Button3.FillColor2 = Color.Turquoise;
                Button4.FillColor = Color.Aquamarine;
                Button4.FillColor2 = Color.Turquoise;

                label1.ForeColor = Color.Aquamarine;
                label2.ForeColor = Color.Aquamarine;
                CodeQuestion.ForeColor = Color.Aquamarine;
                LabelResult.ForeColor = Color.Aquamarine;
            }

            else
            {
                Button1.FillColor = Color.RosyBrown;
                Button1.FillColor2 = Color.LightCoral;
                Button2.FillColor = Color.RosyBrown;
                Button2.FillColor2 = Color.LightCoral;
                Button3.FillColor = Color.RosyBrown;
                Button3.FillColor2 = Color.LightCoral;
                Button4.FillColor = Color.RosyBrown;
                Button4.FillColor2 = Color.LightCoral;

                label1.ForeColor = Color.RosyBrown;
                label2.ForeColor = Color.RosyBrown;
                CodeQuestion.ForeColor = Color.RosyBrown;
                LabelResult.ForeColor = Color.RosyBrown;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (CorrectA == 1)
            {
                LabelResult.Text = "Correct choice!";
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                timer1.Start();

                if (GaveA == false)
                {
                    Score++;
                }
            }

            else
            {
                LabelResult.Text = "Incorrect choice!";
            }

            if (GaveA == false)
            {
                GaveA = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (CorrectA == 2)
            {
                LabelResult.Text = "Correct choice!";
                Button1.Enabled = false;
                Button3.Enabled = false;
                Button4.Enabled = false;
                timer1.Start();

                if (GaveA == false)
                {
                    Score++;
                }
            }

            else
            {
                LabelResult.Text = "Incorrect choice!";
            }

            if (GaveA == false)
            {
                GaveA = true;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (CorrectA == 3)
            {
                LabelResult.Text = "Correct choice!";
                Button2.Enabled = false;
                Button1.Enabled = false;
                Button4.Enabled = false;
                timer1.Start();

                if (GaveA == false)
                {
                    Score++;
                }
            }

            else
            {
                LabelResult.Text = "Incorrect choice!";
            }

            if (GaveA == false)
            {
                GaveA = true;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (CorrectA == 4)
            {
                LabelResult.Text = "Correct choice!";
                Button2.Enabled = false;
                Button3.Enabled = false;
                Button1.Enabled = false;
                timer1.Start();

                if (GaveA == false)
                {
                    Score++;
                }
            }

            else
            {
                LabelResult.Text = "Incorrect choice!";
            }

            if (GaveA == false)
            {
                GaveA = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ManageQuestions();
        }
    }
}
