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
        private CheckBox chkFavorite;

        private Button btnSave;
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
            chkFavorite = new CheckBox();
            btnSave = new Button();
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
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)numYear).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRating).BeginInit();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Belwe Bd BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitle.Location = new Point(154, 6);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(190, 22);
            txtTitle.TabIndex = 0;
            // 
            // txtDirector
            // 
            txtDirector.Font = new Font("Belwe Bd BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDirector.Location = new Point(154, 232);
            txtDirector.Name = "txtDirector";
            txtDirector.Size = new Size(190, 22);
            txtDirector.TabIndex = 5;
            // 
            // txtGenre
            // 
            txtGenre.Font = new Font("Belwe Bd BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtGenre.Location = new Point(154, 96);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(190, 22);
            txtGenre.TabIndex = 2;
            // 
            // txtCountry
            // 
            txtCountry.Font = new Font("Belwe Bd BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCountry.Location = new Point(154, 184);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(190, 22);
            txtCountry.TabIndex = 4;
            // 
            // txtStudio
            // 
            txtStudio.Font = new Font("Belwe Bd BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStudio.Location = new Point(154, 52);
            txtStudio.Name = "txtStudio";
            txtStudio.Size = new Size(190, 22);
            txtStudio.TabIndex = 1;
            // 
            // txtActors
            // 
            txtActors.Font = new Font("Belwe Bd BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtActors.Location = new Point(154, 278);
            txtActors.Name = "txtActors";
            txtActors.Size = new Size(190, 22);
            txtActors.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.Font = new Font("Belwe Bd BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescription.Location = new Point(154, 420);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(402, 98);
            txtDescription.TabIndex = 9;
            // 
            // numYear
            // 
            numYear.Font = new Font("Belwe Bd BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numYear.Location = new Point(154, 140);
            numYear.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            numYear.Minimum = new decimal(new int[] { 1900, 0, 0, 0 });
            numYear.Name = "numYear";
            numYear.Size = new Size(58, 22);
            numYear.TabIndex = 3;
            numYear.Value = new decimal(new int[] { 1980, 0, 0, 0 });
            // 
            // numDuration
            // 
            numDuration.Font = new Font("Belwe Bd BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numDuration.Location = new Point(154, 326);
            numDuration.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numDuration.Minimum = new decimal(new int[] { 30, 0, 0, 0 });
            numDuration.Name = "numDuration";
            numDuration.Size = new Size(58, 22);
            numDuration.TabIndex = 7;
            numDuration.Value = new decimal(new int[] { 30, 0, 0, 0 });
            // 
            // numRating
            // 
            numRating.Font = new Font("Belwe Bd BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numRating.Location = new Point(154, 374);
            numRating.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numRating.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRating.Name = "numRating";
            numRating.Size = new Size(58, 22);
            numRating.TabIndex = 8;
            numRating.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // chkFavorite
            // 
            chkFavorite.Location = new Point(154, 533);
            chkFavorite.Name = "chkFavorite";
            chkFavorite.Size = new Size(19, 24);
            chkFavorite.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top;
            btnSave.BackColor = Color.YellowGreen;
            btnSave.FlatAppearance.BorderColor = Color.Black;
            btnSave.FlatAppearance.BorderSize = 2;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Belwe Bd BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.Location = new Point(13, 575);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 26);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.TopCenter;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top;
            btnCancel.BackColor = Color.Salmon;
            btnCancel.FlatAppearance.BorderColor = Color.Black;
            btnCancel.FlatAppearance.BorderSize = 2;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Belwe Bd BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(154, 574);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 26);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Belwe Bd BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(90, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 19);
            label1.TabIndex = 14;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Belwe Bd BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(75, 52);
            label2.Name = "label2";
            label2.Size = new Size(61, 19);
            label2.TabIndex = 15;
            label2.Text = "Studio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Belwe Bd BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(79, 99);
            label3.Name = "label3";
            label3.Size = new Size(57, 19);
            label3.TabIndex = 16;
            label3.Text = "Genre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Belwe Bd BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(90, 139);
            label4.Name = "label4";
            label4.Size = new Size(46, 19);
            label4.TabIndex = 17;
            label4.Text = "Year:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Belwe Bd BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(64, 184);
            label5.Name = "label5";
            label5.Size = new Size(72, 19);
            label5.TabIndex = 18;
            label5.Text = "Country:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Belwe Bd BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(63, 235);
            label6.Name = "label6";
            label6.Size = new Size(73, 19);
            label6.TabIndex = 19;
            label6.Text = "Director:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Belwe Bd BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(37, 281);
            label7.Name = "label7";
            label7.Size = new Size(99, 19);
            label7.TabIndex = 20;
            label7.Text = "Main actors:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Belwe Bd BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(13, 326);
            label8.Name = "label8";
            label8.Size = new Size(123, 19);
            label8.TabIndex = 21;
            label8.Text = "Duration (min):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Belwe Bd BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(31, 374);
            label9.Name = "label9";
            label9.Size = new Size(105, 19);
            label9.TabIndex = 22;
            label9.Text = "Rating (1-10):";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Belwe Bd BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(42, 420);
            label10.Name = "label10";
            label10.Size = new Size(94, 19);
            label10.TabIndex = 23;
            label10.Text = "Discription:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Belwe Bd BT", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(62, 533);
            label12.Name = "label12";
            label12.Size = new Size(74, 19);
            label12.TabIndex = 25;
            label12.Text = "Favorite:";
            // 
            // AddEditMovieForm
            // 
            BackColor = Color.OldLace;
            ClientSize = new Size(644, 621);
            Controls.Add(label12);
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
            Controls.Add(chkFavorite);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(660, 660);
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
        private Label label12;
    }
}
