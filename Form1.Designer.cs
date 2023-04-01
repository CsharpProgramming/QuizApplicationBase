
namespace QuizApplication
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.QuestionContainer = new System.Windows.Forms.Panel();
            this.ButtonStart = new Siticone.Desktop.UI.WinForms.SiticoneGradientButton();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.LabelTittle = new System.Windows.Forms.Label();
            this.QuestionContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuestionContainer
            // 
            this.QuestionContainer.Controls.Add(this.ButtonStart);
            this.QuestionContainer.Controls.Add(this.LabelDescription);
            this.QuestionContainer.Controls.Add(this.LabelTittle);
            this.QuestionContainer.Location = new System.Drawing.Point(13, 12);
            this.QuestionContainer.Name = "QuestionContainer";
            this.QuestionContainer.Size = new System.Drawing.Size(872, 484);
            this.QuestionContainer.TabIndex = 1;
            // 
            // ButtonStart
            // 
            this.ButtonStart.Animated = true;
            this.ButtonStart.AutoRoundedCorners = true;
            this.ButtonStart.BorderRadius = 33;
            this.ButtonStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonStart.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonStart.FillColor = System.Drawing.Color.RosyBrown;
            this.ButtonStart.FillColor2 = System.Drawing.Color.LightCoral;
            this.ButtonStart.Font = new System.Drawing.Font("Tw Cen MT", 14.25F, System.Drawing.FontStyle.Bold);
            this.ButtonStart.ForeColor = System.Drawing.Color.White;
            this.ButtonStart.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.ButtonStart.Location = new System.Drawing.Point(311, 317);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(250, 69);
            this.ButtonStart.TabIndex = 6;
            this.ButtonStart.Text = "Start Quiz";
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // LabelDescription
            // 
            this.LabelDescription.AutoSize = true;
            this.LabelDescription.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDescription.ForeColor = System.Drawing.Color.RosyBrown;
            this.LabelDescription.Location = new System.Drawing.Point(343, 140);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(189, 19);
            this.LabelDescription.TabIndex = 5;
            this.LabelDescription.Text = "C# coding quiz description";
            // 
            // LabelTittle
            // 
            this.LabelTittle.AutoSize = true;
            this.LabelTittle.Font = new System.Drawing.Font("Tw Cen MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTittle.ForeColor = System.Drawing.Color.RosyBrown;
            this.LabelTittle.Location = new System.Drawing.Point(364, 98);
            this.LabelTittle.Name = "LabelTittle";
            this.LabelTittle.Size = new System.Drawing.Size(147, 24);
            this.LabelTittle.TabIndex = 4;
            this.LabelTittle.Text = "C# coding Quiz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(897, 507);
            this.Controls.Add(this.QuestionContainer);
            this.MaximumSize = new System.Drawing.Size(913, 546);
            this.MinimumSize = new System.Drawing.Size(913, 546);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# coding quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.QuestionContainer.ResumeLayout(false);
            this.QuestionContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel QuestionContainer;
        private Siticone.Desktop.UI.WinForms.SiticoneGradientButton ButtonStart;
        private System.Windows.Forms.Label LabelDescription;
        private System.Windows.Forms.Label LabelTittle;
    }
}

