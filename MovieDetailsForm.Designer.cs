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
            panelDetails = new Panel();
            SuspendLayout();
            // 
            // panelDetails
            // 
            panelDetails.Anchor = AnchorStyles.Top;
            panelDetails.BackColor = Color.SeaShell;
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
            ResumeLayout(false);
        }

        #endregion
        private Panel panelDetails;
    }

}