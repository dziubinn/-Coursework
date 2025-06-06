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
            lblDirector = new Label();
            lblMainActor = new Label();
            lblDescription = new Label();
            panelDetails = new Panel();
            panelDetails.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Bauhaus 93", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.Location = new Point(21, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(75, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(21, 63);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(38, 15);
            lblYear.TabIndex = 1;
            lblYear.Text = "label1";
            // 
            // lblDuration
            // 
            lblDuration.AutoSize = true;
            lblDuration.Location = new Point(89, 63);
            lblDuration.Name = "lblDuration";
            lblDuration.Size = new Size(38, 15);
            lblDuration.TabIndex = 2;
            lblDuration.Text = "label1";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Location = new Point(159, 63);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(38, 15);
            lblGenre.TabIndex = 3;
            lblGenre.Text = "label2";
            // 
            // lblStudio
            // 
            lblStudio.AutoSize = true;
            lblStudio.Location = new Point(21, 206);
            lblStudio.Name = "lblStudio";
            lblStudio.Size = new Size(38, 15);
            lblStudio.TabIndex = 4;
            lblStudio.Text = "label1";
            lblStudio.Click += lblStudio_Click;
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(21, 172);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(38, 15);
            lblCountry.TabIndex = 5;
            lblCountry.Text = "label2";
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Location = new Point(89, 96);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(38, 15);
            lblRating.TabIndex = 6;
            lblRating.Text = "label3";
            // 
            // lblDirector
            // 
            lblDirector.AutoSize = true;
            lblDirector.Location = new Point(21, 96);
            lblDirector.Name = "lblDirector";
            lblDirector.Size = new Size(38, 15);
            lblDirector.TabIndex = 9;
            lblDirector.Text = "label1";
            // 
            // lblMainActor
            // 
            lblMainActor.AutoSize = true;
            lblMainActor.Location = new Point(21, 128);
            lblMainActor.Name = "lblMainActor";
            lblMainActor.Size = new Size(38, 15);
            lblMainActor.TabIndex = 10;
            lblMainActor.Text = "label2";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.BackColor = Color.OldLace;
            lblDescription.Location = new Point(21, 245);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(38, 15);
            lblDescription.TabIndex = 11;
            lblDescription.Text = "label1";
            lblDescription.Click += label1_Click;
            // 
            // panelDetails
            // 
            panelDetails.Anchor = AnchorStyles.Top;
            panelDetails.BackColor = Color.SeaShell;
            panelDetails.Controls.Add(lblTitle);
            panelDetails.Controls.Add(lblDescription);
            panelDetails.Controls.Add(lblRating);
            panelDetails.Controls.Add(lblStudio);
            panelDetails.Controls.Add(lblCountry);
            panelDetails.Controls.Add(lblMainActor);
            panelDetails.Controls.Add(lblYear);
            panelDetails.Controls.Add(lblDirector);
            panelDetails.Controls.Add(lblDuration);
            panelDetails.Controls.Add(lblGenre);
            panelDetails.Location = new Point(12, 12);
            panelDetails.Name = "panelDetails";
            panelDetails.Size = new Size(484, 318);
            panelDetails.TabIndex = 12;
            // 
            // MovieDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(508, 344);
            Controls.Add(panelDetails);
            MaximumSize = new Size(524, 383);
            MinimumSize = new Size(524, 383);
            Name = "MovieDetailsForm";
            Text = "MovieDetailsForm";
            panelDetails.ResumeLayout(false);
            panelDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Label lblYear;
        private Label lblDuration;
        private Label lblGenre;
        private Label lblStudio;
        private Label lblCountry;
        private Label lblRating;
        private Label lblDirector;
        private Label lblMainActor;
        private Label lblDescription;
        private Panel panelDetails;
    }

}