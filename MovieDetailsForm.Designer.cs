namespace Сoursework
{
    partial class MovieDetailsForm
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
            lblTitle = new Label();
            lblYear = new Label();
            lblDuration = new Label();
            lblGenre = new Label();
            lblStudio = new Label();
            lblCountry = new Label();
            lblRating = new Label();
            lblDirectorText = new Label();
            lblActorText = new Label();
            lblDirector = new Label();
            lblMainActor = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Bauhaus 93", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(23, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(75, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(23, 52);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(38, 15);
            lblYear.TabIndex = 1;
            lblYear.Text = "label1";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(83, 52);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(38, 15);
            lblDuration.TabIndex = 2;
            lblDuration.Text = "label1";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(133, 52);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(38, 15);
            lblGenre.TabIndex = 3;
            lblGenre.Text = "label2";
            // 
            // lblStudio
            // 
            lblStudio.AutoSize = true;
            lblStudio.Location = new Point(23, 87);
            lblStudio.Name = "lblStudio";
            lblStudio.Size = new Size(38, 15);
            lblStudio.TabIndex = 4;
            lblStudio.Text = "label1";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(83, 87);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(38, 15);
            lblCountry.TabIndex = 5;
            lblCountry.Text = "label2";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Location = new Point(23, 119);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(38, 15);
            lblRating.TabIndex = 6;
            lblRating.Text = "label3";
            // 
            // lblDirectorText
            // 
            lblDirectorText.AutoSize = true;
            lblDirectorText.Location = new Point(23, 154);
            lblDirectorText.Name = "lblDirectorText";
            lblDirectorText.Size = new Size(52, 15);
            lblDirectorText.TabIndex = 7;
            lblDirectorText.Text = "Director ";
            // 
            // lblActorText
            // 
            lblActorText.AutoSize = true;
            lblActorText.Location = new Point(23, 191);
            lblActorText.Name = "lblActorText";
            lblActorText.Size = new Size(69, 15);
            lblActorText.TabIndex = 8;
            lblActorText.Text = "Main actors";
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Location = new Point(83, 154);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(38, 15);
            lblDirector.TabIndex = 9;
            lblDirector.Text = "label1";
            // 
            // lblMainActor
            // 
            lblMainActor.AutoSize = true;
            lblMainActor.Location = new Point(116, 191);
            lblMainActor.Name = "lblMainActor";
            lblMainActor.Size = new Size(38, 15);
            lblMainActor.TabIndex = 10;
            lblMainActor.Text = "label2";
            // 
            // MovieDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMainActor);
            Controls.Add(lblDirector);
            Controls.Add(lblActorText);
            Controls.Add(lblDirectorText);
            Controls.Add(lblRating);
            Controls.Add(lblCountry);
            Controls.Add(lblStudio);
            Controls.Add(lblGenre);
            Controls.Add(lblDuration);
            Controls.Add(lblYear);
            Controls.Add(lblTitle);
            Name = "MovieDetailsForm";
            Text = "MovieDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblYear;
        private Label lblDuration;
        private Label lblGenre;
        private Label lblStudio;
        private Label lblCountry;
        private Label lblRating;
        private Label lblDirectorText;
        private Label lblActorText;
        private Label lblDirector;
        private Label lblMainActor;
    }
}