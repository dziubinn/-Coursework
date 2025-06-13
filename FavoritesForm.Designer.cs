namespace Сoursework
{
    partial class FavoritesForm
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
            labelFavorite = new Label();
            flowLayoutPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // labelFavorite
            // 
            labelFavorite.AutoSize = true;
            labelFavorite.Font = new Font("Belwe Bd BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelFavorite.Location = new Point(99, 9);
            labelFavorite.Name = "labelFavorite";
            labelFavorite.Size = new Size(157, 23);
            labelFavorite.TabIndex = 0;
            labelFavorite.Text = "Favorite movies";
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Location = new Point(31, 44);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(331, 516);
            flowLayoutPanel.TabIndex = 1;
            flowLayoutPanel.WrapContents = false;
            // 
            // FavoritesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(374, 561);
            Controls.Add(flowLayoutPanel);
            Controls.Add(labelFavorite);
            MaximumSize = new Size(390, 600);
            MinimumSize = new Size(385, 600);
            Name = "FavoritesForm";
            Text = "FavoritesForm";
            KeyDown += FavoritesForm_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFavorite;
        private FlowLayoutPanel flowLayoutPanel;
    }
}