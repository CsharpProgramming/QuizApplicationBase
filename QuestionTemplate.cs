using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApplication
{
    public partial class QuestionTemplate : UserControl
    {
        int CorrectA = 0;
        int QuestionID2 = 1;

        int Score = 0;

        bool GaveA = false;

        public QuestionTemplate()
        {
            InitializeComponent();
        }

        private void QuestionTemplate_Load(object sender, EventArgs e)
        {
            //First Question
            Question("Writes Hello World!", "Gives a error: Hello World!", "Writes Hello world", "Plays a mp3: Hello world", 1, "Console.WriteLine(\"Hello World!\")");
        }

        private void ManageQuestions()
        {
            timer1.Stop();

            QuestionID2++;

            //Next Questions after

            if (QuestionID2 == 2) //Question 2
            {
                Question("Writes Hello World", "Gives a error!", "Writes Hello world", "Gives you free bitcoin", 2, "Console.WriteLine(Hello World!)");
            }

            else if (QuestionID2 == 3) //Question 3
            {
                Question("Writes 4", "Gives a error!", "Writes 2 + 2", "Gives you free bitcoin", 3, "Console.WriteLine(\"2 + 2\")");
            }

            else if (QuestionID2 == 4) //And so on
            {
                Question("Writes Hello world!", "Gives a error: Hello World!", "Writes Hello world", "Plays a mp3: Hello world", 3, "Console.WriteLine(\"Hello world\")");
            }

            else
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

        public void Question(string A1, string A2, string A3, string A4, int Correct, string Code)
        {
            GaveA = false;

            //Change UI text
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

            LabelResult.Text = "What does this code do?";
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
