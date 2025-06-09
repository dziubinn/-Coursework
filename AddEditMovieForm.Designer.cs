namespace Сoursework
{
    partial class AddEditMovieForm
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtTitle;
        private TextBox txtDirector;
        private TextBox txtGenre;
        private TextBox txtCountry;
        private TextBox txtStudio;
        private TextBox txtActors;
        private TextBox txtDescription;

        private NumericUpDown numYear;
        private NumericUpDown numDuration;
        private NumericUpDown numRating;

        private CheckBox chkWatched;
        private CheckBox chkFavorite;

        private Button btnOK;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtTitle = new TextBox();
            txtDirector = new TextBox();
            txtGenre = new TextBox();
            txtCountry = new TextBox();
            txtStudio = new TextBox();
            txtActors = new TextBox();
            txtDescription = new TextBox();
            numYear = new NumericUpDown();
            numDuration = new NumericUpDown();
            numRating = new NumericUpDown();
            chkWatched = new CheckBox();
            chkFavorite = new CheckBox();
            btnOK = new Button();
            btnCancel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRating).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(173, 8);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(190, 23);
            txtTitle.TabIndex = 0;
            // 
            // txtDirector
            // 
            txtDirector.Location = new Point(173, 245);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(190, 23);
            txtDirector.TabIndex = 5;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(173, 98);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(190, 23);
            txtGenre.TabIndex = 2;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(173, 196);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(190, 23);
            txtCountry.TabIndex = 4;
            // 
            // txtStudio
            // 
            txtStudio.Location = new Point(173, 54);
            txtStudio.Name = "txtStudio";
            txtStudio.Size = new Size(190, 23);
            txtStudio.TabIndex = 1;
            // 
            // txtActors
            // 
            txtActors.Location = new Point(173, 291);
            txtActors.Name = "txtActors";
            txtActors.Size = new Size(190, 23);
            txtActors.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Location = new Point(173, 445);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(644, 70);
            txtDescription.TabIndex = 9;
            // 
            // numYear
            // 
            numYear.Location = new Point(173, 142);
            numYear.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(190, 23);
            numYear.TabIndex = 3;
            numYear.Value = new decimal(new int[] { 1980, 0, 0, 0 });
            // 
            // numDuration
            // 
            numDuration.Location = new Point(173, 344);
            numDuration.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numDuration.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            numDuration.Name = "numDuration";
            numDuration.Size = new Size(190, 23);
            numDuration.TabIndex = 7;
            numDuration.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // numRating
            // 
            numRating.Location = new Point(173, 396);
            numRating.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numRating.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRating.Name = "numRating";
            numRating.Size = new Size(190, 23);
            numRating.TabIndex = 8;
            numRating.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // chkWatched
            // 
            chkWatched.Location = new Point(173, 529);
            chkWatched.Name = "chkWatched";
            chkWatched.Size = new Size(19, 24);
            chkWatched.TabIndex = 10;
            // 
            // chkFavorite
            // 
            chkFavorite.Location = new Point(173, 573);
            chkFavorite.Name = "chkFavorite";
            chkFavorite.Size = new Size(19, 24);
            chkFavorite.TabIndex = 11;
            // 
            // btnOK
            // 
            btnOK.Anchor = AnchorStyles.Top;
            btnOK.BackColor = Color.YellowGreen;
            btnOK.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnOK.Location = new Point(32, 626);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(121, 34);
            btnOK.TabIndex = 12;
            btnOK.Text = "Save";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top;
            btnCancel.BackColor = Color.Salmon;
            btnCancel.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(182, 626);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(109, 34);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 15);
            label1.Name = "label1";
            label1.Size = new Size(42, 16);
            label1.TabIndex = 14;
            label1.Text = "Title:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 61);
            label2.Name = "label2";
            label2.Size = new Size(53, 16);
            label2.TabIndex = 15;
            label2.Text = "Studio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 105);
            label3.Name = "label3";
            label3.Size = new Size(51, 16);
            label3.TabIndex = 16;
            label3.Text = "Genre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(32, 149);
            label4.Name = "label4";
            label4.Size = new Size(43, 16);
            label4.TabIndex = 17;
            label4.Text = "Year:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(32, 203);
            label5.Name = "label5";
            label5.Size = new Size(66, 16);
            label5.TabIndex = 18;
            label5.Text = "Country:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(32, 252);
            label6.Name = "label6";
            label6.Size = new Size(67, 16);
            label6.TabIndex = 19;
            label6.Text = "Director:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(32, 298);
            label7.Name = "label7";
            label7.Size = new Size(90, 16);
            label7.TabIndex = 20;
            label7.Text = "Main actors:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(32, 351);
            label8.Name = "label8";
            label8.Size = new Size(111, 16);
            label8.TabIndex = 21;
            label8.Text = "Duration (min):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(32, 403);
            label9.Name = "label9";
            label9.Size = new Size(103, 16);
            label9.TabIndex = 22;
            label9.Text = "Rating (1-10):";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(32, 448);
            label10.Name = "label10";
            label10.Size = new Size(84, 16);
            label10.TabIndex = 23;
            label10.Text = "Discription:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(32, 537);
            label11.Name = "label11";
            label11.Size = new Size(72, 16);
            label11.TabIndex = 24;
            label11.Text = "Watched:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Bauhaus 93", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(32, 581);
            label12.Name = "label12";
            label12.Size = new Size(65, 16);
            label12.TabIndex = 25;
            label12.Text = "Favorite:";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top;
            label13.AutoSize = true;
            label13.Font = new Font("Bauhaus 93", 20.2F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(428, 54);
            label13.Name = "label13";
            label13.Size = new Size(322, 30);
            label13.TabIndex = 26;
            label13.Text = "Add or edit your movie!🎥";
            // 
            // AddEditMovieForm
            // 
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(889, 688);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTitle);
            Controls.Add(txtStudio);
            Controls.Add(txtGenre);
            Controls.Add(numYear);
            Controls.Add(txtCountry);
            Controls.Add(txtDirector);
            Controls.Add(txtActors);
            Controls.Add(numDuration);
            Controls.Add(numRating);
            Controls.Add(txtDescription);
            Controls.Add(chkWatched);
            Controls.Add(chkFavorite);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(905, 727);
            Name = "AddEditMovieForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add/Edit Movie";
            ((System.ComponentModel.ISupportInitialize)numYear).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRating).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}
