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
            btnLoad = new Button();
            btnSave = new Button();
            btnSearch = new Button();
            btnFilter = new Button();
            dataGridViewMovies = new DataGridView();
            PanelSearch = new Panel();
            cmbFilterValue = new ComboBox();
            cmbFilterBy = new ComboBox();
            txtSearch = new TextBox();
            flowPanelControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).BeginInit();
            PanelSearch.SuspendLayout();
            SuspendLayout();
            // 
            // flowPanelControls
            // 
            flowPanelControls.Anchor = AnchorStyles.Top;
            flowPanelControls.BackColor = Color.PaleGoldenrod;
            flowPanelControls.BorderStyle = BorderStyle.FixedSingle;
            flowPanelControls.Controls.Add(btnAdd);
            flowPanelControls.Controls.Add(btnEdit);
            flowPanelControls.Controls.Add(btnDelete);
            flowPanelControls.Controls.Add(btnLoad);
            flowPanelControls.Controls.Add(btnSave);
            flowPanelControls.Location = new Point(347, 1);
            flowPanelControls.Margin = new Padding(3, 4, 3, 4);
            flowPanelControls.Name = "flowPanelControls";
            flowPanelControls.Size = new Size(602, 45);
            flowPanelControls.TabIndex = 0;
            flowPanelControls.WrapContents = false;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Location = new Point(3, 4);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 31);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Location = new Point(123, 4);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(114, 31);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Location = new Point(243, 4);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(114, 31);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLoad.FlatStyle = FlatStyle.Popup;
            btnLoad.Location = new Point(363, 4);
            btnLoad.Margin = new Padding(3, 4, 3, 4);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(114, 31);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Location = new Point(483, 4);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(114, 31);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Location = new Point(265, 17);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(114, 31);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search🔍";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnFilter
            // 
            btnFilter.FlatStyle = FlatStyle.Popup;
            btnFilter.Location = new Point(441, 75);
            btnFilter.Margin = new Padding(3, 4, 3, 4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(114, 31);
            btnFilter.TabIndex = 4;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMovies
            // 
            dataGridViewMovies.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewMovies.BackgroundColor = Color.WhiteSmoke;
            dataGridViewMovies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMovies.Location = new Point(1, 327);
            dataGridViewMovies.Margin = new Padding(3, 4, 3, 4);
            dataGridViewMovies.Name = "dataGridViewMovies";
            dataGridViewMovies.RowHeadersWidth = 51;
            dataGridViewMovies.Size = new Size(1286, 376);
            dataGridViewMovies.TabIndex = 1;
            // 
            // PanelSearch
            // 
            PanelSearch.Anchor = AnchorStyles.Top;
            PanelSearch.BorderStyle = BorderStyle.FixedSingle;
            PanelSearch.Controls.Add(cmbFilterValue);
            PanelSearch.Controls.Add(cmbFilterBy);
            PanelSearch.Controls.Add(txtSearch);
            PanelSearch.Controls.Add(btnSearch);
            PanelSearch.Controls.Add(btnFilter);
            PanelSearch.Location = new Point(357, 63);
            PanelSearch.Margin = new Padding(3, 4, 3, 4);
            PanelSearch.Name = "PanelSearch";
            PanelSearch.Size = new Size(576, 200);
            PanelSearch.TabIndex = 5;
            // 
            // cmbFilterValue
            // 
            cmbFilterValue.FormattingEnabled = true;
            cmbFilterValue.Location = new Point(265, 75);
            cmbFilterValue.Margin = new Padding(3, 4, 3, 4);
            cmbFilterValue.Name = "cmbFilterValue";
            cmbFilterValue.Size = new Size(138, 28);
            cmbFilterValue.TabIndex = 6;
            // 
            // cmbFilterBy
            // 
            cmbFilterBy.FormattingEnabled = true;
            cmbFilterBy.Items.AddRange(new object[] { "Genre", "Year", "Director", "Country", "Main actor", "Duration", "Studio" });
            cmbFilterBy.Location = new Point(17, 75);
            cmbFilterBy.Margin = new Padding(3, 4, 3, 4);
            cmbFilterBy.Name = "cmbFilterBy";
            cmbFilterBy.Size = new Size(221, 28);
            cmbFilterBy.TabIndex = 5;
            cmbFilterBy.SelectedIndexChanged += cmbFilterBy_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(17, 17);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(221, 27);
            txtSearch.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1288, 704);
            Controls.Add(PanelSearch);
            Controls.Add(dataGridViewMovies);
            Controls.Add(flowPanelControls);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(631, 47);
            Name = "MainForm";
            Text = "MainForm";
            flowPanelControls.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMovies).EndInit();
            PanelSearch.ResumeLayout(false);
            PanelSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowPanelControls;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnFilter;
        private Button btnLoad;
        private Button btnSave;
        private DataGridView dataGridViewMovies;
        private Panel PanelSearch;
        private ComboBox cmbFilterBy;
        private TextBox txtSearch;
        private ComboBox cmbFilterValue;
    }
}