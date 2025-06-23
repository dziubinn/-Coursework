namespace Сoursework
{
    partial class UserForm
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
            btnOpenFavorites = new Label();
            btnSearch = new Button();
            btnFilter = new Button();
            PanelSearch = new Panel();
            welcomeLabel = new Label();
            btnHome = new Button();
            SearchFilterslbl = new Label();
            TitleNamelbl = new Label();
            cmbFilterValue = new ComboBox();
            cmbFilterBy = new ComboBox();
            txtSearch = new TextBox();
            flowPanelMovies = new FlowLayoutPanel();
            lblHeader = new Label();
            PanelSearch.SuspendLayout();
            SuspendLayout();
            // 
            // btnOpenFavorites
            // 
            btnOpenFavorites.Font = new Font("Belwe Bd BT", 17F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenFavorites.ForeColor = Color.Firebrick;
            btnOpenFavorites.Location = new Point(46, 55);
            btnOpenFavorites.Name = "btnOpenFavorites";
            btnOpenFavorites.Size = new Size(38, 36);
            btnOpenFavorites.TabIndex = 3;
            btnOpenFavorites.Text = "♥";
            btnOpenFavorites.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Belwe Bd BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(218, 131);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 23);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search🔍";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnFilter
            // 
            btnFilter.FlatStyle = FlatStyle.Popup;
            btnFilter.Font = new Font("Belwe Bd BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnFilter.Location = new Point(218, 328);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(100, 23);
            btnFilter.TabIndex = 7;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // PanelSearch
            // 
            PanelSearch.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            PanelSearch.BorderStyle = BorderStyle.FixedSingle;
            PanelSearch.Controls.Add(welcomeLabel);
            PanelSearch.Controls.Add(btnHome);
            PanelSearch.Controls.Add(btnOpenFavorites);
            PanelSearch.Controls.Add(SearchFilterslbl);
            PanelSearch.Controls.Add(TitleNamelbl);
            PanelSearch.Controls.Add(cmbFilterValue);
            PanelSearch.Controls.Add(cmbFilterBy);
            PanelSearch.Controls.Add(txtSearch);
            PanelSearch.Controls.Add(btnSearch);
            PanelSearch.Controls.Add(btnFilter);
            PanelSearch.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            PanelSearch.Location = new Point(8, 12);
            PanelSearch.Name = "PanelSearch";
            PanelSearch.Size = new Size(330, 539);
            PanelSearch.TabIndex = 5;
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Belwe Bd BT", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            welcomeLabel.Location = new Point(8, 9);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(43, 26);
            welcomeLabel.TabIndex = 10;
            welcomeLabel.Text = "Hi!";
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.Transparent;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 17F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.Location = new Point(5, 54);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(46, 37);
            btnHome.TabIndex = 9;
            btnHome.Text = "🏠";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // SearchFilterslbl
            // 
            SearchFilterslbl.AutoSize = true;
            SearchFilterslbl.Font = new Font("Belwe Bd BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            SearchFilterslbl.Location = new Point(18, 169);
            SearchFilterslbl.Name = "SearchFilterslbl";
            SearchFilterslbl.Size = new Size(134, 23);
            SearchFilterslbl.TabIndex = 8;
            SearchFilterslbl.Text = "Search filters";
            // 
            // TitleNamelbl
            // 
            TitleNamelbl.AutoSize = true;
            TitleNamelbl.Font = new Font("Belwe Bd BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TitleNamelbl.Location = new Point(18, 105);
            TitleNamelbl.Name = "TitleNamelbl";
            TitleNamelbl.Size = new Size(109, 23);
            TitleNamelbl.TabIndex = 7;
            TitleNamelbl.Text = "Title name";
            // 
            // cmbFilterValue
            // 
            cmbFilterValue.DropDownHeight = 230;
            cmbFilterValue.Font = new Font("Belwe Bd BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbFilterValue.FormattingEnabled = true;
            cmbFilterValue.IntegralHeight = false;
            cmbFilterValue.Location = new Point(18, 328);
            cmbFilterValue.Name = "cmbFilterValue";
            cmbFilterValue.Size = new Size(194, 23);
            cmbFilterValue.TabIndex = 6;
            // 
            // cmbFilterBy
            // 
            cmbFilterBy.Font = new Font("Belwe Bd BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbFilterBy.FormattingEnabled = true;
            cmbFilterBy.Items.AddRange(new object[] { "Genre", "Year", "Director", "Country", "Main actor", "Duration", "Studio" });
            cmbFilterBy.Location = new Point(18, 193);
            cmbFilterBy.Name = "cmbFilterBy";
            cmbFilterBy.Size = new Size(194, 23);
            cmbFilterBy.TabIndex = 5;
            cmbFilterBy.SelectedIndexChanged += cmbFilterBy_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Belwe Bd BT", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(18, 131);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(194, 22);
            txtSearch.TabIndex = 3;
            // 
            // flowPanelMovies
            // 
            flowPanelMovies.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowPanelMovies.AutoScroll = true;
            flowPanelMovies.Location = new Point(344, 97);
            flowPanelMovies.Name = "flowPanelMovies";
            flowPanelMovies.Size = new Size(630, 454);
            flowPanelMovies.TabIndex = 6;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Belwe Bd BT", 23.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeader.Location = new Point(344, 13);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(171, 37);
            lblHeader.TabIndex = 7;
            lblHeader.Text = "All Movies";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(974, 563);
            Controls.Add(lblHeader);
            Controls.Add(flowPanelMovies);
            Controls.Add(PanelSearch);
            MinimumSize = new Size(690, 602);
            Name = "UserForm";
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            PanelSearch.ResumeLayout(false);
            PanelSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnFilter;
        private Panel PanelSearch;
        private ComboBox cmbFilterBy;
        private TextBox txtSearch;
        private ComboBox cmbFilterValue;
        private FlowLayoutPanel flowPanelMovies;
        private Label SearchFilterslbl;
        private Label TitleNamelbl;
        private Label lblHeader;
        private Label btnOpenFavorites;
        private Button btnHome;
        private Label welcomeLabel;
        private Panel panel1;
    }
}