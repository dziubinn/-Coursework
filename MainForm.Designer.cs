namespace Сoursework
{
    partial class MainForm
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
            flowPanelControls = new FlowLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnOpenFavorites = new Button();
            btnSearch = new Button();
            btnFilter = new Button();
            PanelSearch = new Panel();
            SearchFilterslbl = new Label();
            TitleNamelbl = new Label();
            cmbFilterValue = new ComboBox();
            cmbFilterBy = new ComboBox();
            txtSearch = new TextBox();
            flowPanelMovies = new FlowLayoutPanel();
            lblHeader = new Label();
            flowPanelControls.SuspendLayout();
            PanelSearch.SuspendLayout();
            SuspendLayout();
            // 
            // flowPanelControls
            // 
            flowPanelControls.BackColor = Color.AntiqueWhite;
            flowPanelControls.BorderStyle = BorderStyle.FixedSingle;
            flowPanelControls.Controls.Add(btnAdd);
            flowPanelControls.Controls.Add(btnEdit);
            flowPanelControls.Controls.Add(btnDelete);
            flowPanelControls.Controls.Add(btnOpenFavorites);
            flowPanelControls.Location = new Point(8, 9);
            flowPanelControls.Name = "flowPanelControls";
            flowPanelControls.Padding = new Padding(5, 2, 5, 2);
            flowPanelControls.Size = new Size(330, 36);
            flowPanelControls.TabIndex = 0;
            flowPanelControls.WrapContents = false;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Location = new Point(8, 5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(85, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Location = new Point(99, 5);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(85, 23);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Location = new Point(190, 5);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnOpenFavorites
            // 
            btnOpenFavorites.Anchor = AnchorStyles.Top;
            btnOpenFavorites.BackColor = Color.AntiqueWhite;
            btnOpenFavorites.FlatAppearance.BorderSize = 0;
            btnOpenFavorites.FlatAppearance.MouseDownBackColor = Color.AntiqueWhite;
            btnOpenFavorites.FlatAppearance.MouseOverBackColor = Color.AntiqueWhite;
            btnOpenFavorites.FlatStyle = FlatStyle.Flat;
            btnOpenFavorites.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnOpenFavorites.ForeColor = Color.Firebrick;
            btnOpenFavorites.Location = new Point(281, 5);
            btnOpenFavorites.Name = "btnOpenFavorites";
            btnOpenFavorites.Size = new Size(34, 23);
            btnOpenFavorites.TabIndex = 3;
            btnOpenFavorites.Text = "♥";
            btnOpenFavorites.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Location = new Point(215, 49);
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
            btnFilter.Location = new Point(215, 284);
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
            PanelSearch.Controls.Add(SearchFilterslbl);
            PanelSearch.Controls.Add(TitleNamelbl);
            PanelSearch.Controls.Add(cmbFilterValue);
            PanelSearch.Controls.Add(cmbFilterBy);
            PanelSearch.Controls.Add(txtSearch);
            PanelSearch.Controls.Add(btnSearch);
            PanelSearch.Controls.Add(btnFilter);
            PanelSearch.Location = new Point(8, 51);
            PanelSearch.Name = "PanelSearch";
            PanelSearch.Size = new Size(330, 500);
            PanelSearch.TabIndex = 5;
            // 
            // SearchFilterslbl
            // 
            SearchFilterslbl.AutoSize = true;
            SearchFilterslbl.Font = new Font("Bauhaus 93", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            SearchFilterslbl.Location = new Point(15, 108);
            SearchFilterslbl.Name = "SearchFilterslbl";
            SearchFilterslbl.Size = new Size(121, 21);
            SearchFilterslbl.TabIndex = 8;
            SearchFilterslbl.Text = "Search filters";
            // 
            // TitleNamelbl
            // 
            TitleNamelbl.AutoSize = true;
            TitleNamelbl.Font = new Font("Bauhaus 93", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TitleNamelbl.Location = new Point(15, 26);
            TitleNamelbl.Name = "TitleNamelbl";
            TitleNamelbl.Size = new Size(101, 21);
            TitleNamelbl.TabIndex = 7;
            TitleNamelbl.Text = "Title name";
            // 
            // cmbFilterValue
            // 
            cmbFilterValue.DropDownHeight = 230;
            cmbFilterValue.FormattingEnabled = true;
            cmbFilterValue.IntegralHeight = false;
            cmbFilterValue.Location = new Point(15, 284);
            cmbFilterValue.Name = "cmbFilterValue";
            cmbFilterValue.Size = new Size(194, 23);
            cmbFilterValue.TabIndex = 6;
            cmbFilterValue.SelectedIndexChanged += cmbFilterValue_SelectedIndexChanged;
            // 
            // cmbFilterBy
            // 
            cmbFilterBy.FormattingEnabled = true;
            cmbFilterBy.Items.AddRange(new object[] { "Genre", "Year", "Director", "Country", "Main actor", "Duration", "Studio" });
            cmbFilterBy.Location = new Point(15, 132);
            cmbFilterBy.Name = "cmbFilterBy";
            cmbFilterBy.Size = new Size(194, 23);
            cmbFilterBy.TabIndex = 5;
            cmbFilterBy.SelectedIndexChanged += cmbFilterBy_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(15, 50);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(194, 23);
            txtSearch.TabIndex = 3;
            // 
            // flowPanelMovies
            // 
            flowPanelMovies.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowPanelMovies.AutoScroll = true;
            flowPanelMovies.Location = new Point(344, 99);
            flowPanelMovies.Name = "flowPanelMovies";
            flowPanelMovies.Size = new Size(609, 452);
            flowPanelMovies.TabIndex = 6;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Bauhaus 93", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeader.Location = new Point(344, 11);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(149, 34);
            lblHeader.TabIndex = 7;
            lblHeader.Text = "All Movies";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 563);
            Controls.Add(lblHeader);
            Controls.Add(flowPanelMovies);
            Controls.Add(PanelSearch);
            Controls.Add(flowPanelControls);
            MinimumSize = new Size(690, 602);
            Name = "MainForm";
            Text = "MainForm";
            FormClosing += MainForm_FormClosing;
            flowPanelControls.ResumeLayout(false);
            PanelSearch.ResumeLayout(false);
            PanelSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion

        private FlowLayoutPanel flowPanelControls;
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
        private Button btnOpenFavorites;
    }
}