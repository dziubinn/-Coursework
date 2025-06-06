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
            PanelSearch = new Panel();
            cmbFilterValue = new ComboBox();
            cmbFilterBy = new ComboBox();
            txtSearch = new TextBox();
            flowPanelMovies = new FlowLayoutPanel();
            flowPanelControls.SuspendLayout();
            PanelSearch.SuspendLayout();
            SuspendLayout();
            // 
            // flowPanelControls
            // 
            flowPanelControls.Anchor = AnchorStyles.Top;
            flowPanelControls.BackColor = Color.PeachPuff;
            flowPanelControls.BorderStyle = BorderStyle.FixedSingle;
            flowPanelControls.Controls.Add(btnAdd);
            flowPanelControls.Controls.Add(btnEdit);
            flowPanelControls.Controls.Add(btnDelete);
            flowPanelControls.Controls.Add(btnLoad);
            flowPanelControls.Controls.Add(btnSave);
            flowPanelControls.Location = new Point(152, 1);
            flowPanelControls.Name = "flowPanelControls";
            flowPanelControls.Size = new Size(533, 34);
            flowPanelControls.TabIndex = 0;
            flowPanelControls.WrapContents = false;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.FlatStyle = FlatStyle.Popup;
            btnEdit.Location = new Point(109, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(100, 23);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Location = new Point(215, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(100, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btnLoad.FlatStyle = FlatStyle.Popup;
            btnLoad.Location = new Point(321, 3);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(100, 23);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Location = new Point(427, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Location = new Point(232, 13);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search🔍";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnFilter
            // 
            btnFilter.FlatStyle = FlatStyle.Popup;
            btnFilter.Location = new Point(386, 56);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(100, 23);
            btnFilter.TabIndex = 4;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = true;
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
            PanelSearch.Location = new Point(160, 47);
            PanelSearch.Name = "PanelSearch";
            PanelSearch.Size = new Size(504, 150);
            PanelSearch.TabIndex = 5;
            // 
            // cmbFilterValue
            // 
            cmbFilterValue.FormattingEnabled = true;
            cmbFilterValue.Location = new Point(232, 56);
            cmbFilterValue.Name = "cmbFilterValue";
            cmbFilterValue.Size = new Size(121, 23);
            cmbFilterValue.TabIndex = 6;
            // 
            // cmbFilterBy
            // 
            cmbFilterBy.FormattingEnabled = true;
            cmbFilterBy.Items.AddRange(new object[] { "Genre", "Year", "Director", "Country", "Main actor", "Duration", "Studio" });
            cmbFilterBy.Location = new Point(15, 56);
            cmbFilterBy.Name = "cmbFilterBy";
            cmbFilterBy.Size = new Size(194, 23);
            cmbFilterBy.TabIndex = 5;
            cmbFilterBy.SelectedIndexChanged += cmbFilterBy_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(15, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(194, 23);
            txtSearch.TabIndex = 4;
            // 
            // flowPanelMovies
            // 
            flowPanelMovies.AutoScroll = true;
            flowPanelMovies.Dock = DockStyle.Bottom;
            flowPanelMovies.Location = new Point(0, 251);
            flowPanelMovies.Name = "flowPanelMovies";
            flowPanelMovies.Size = new Size(823, 354);
            flowPanelMovies.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 605);
            Controls.Add(flowPanelMovies);
            Controls.Add(PanelSearch);
            Controls.Add(flowPanelControls);
            MinimumSize = new Size(554, 602);
            Name = "MainForm";
            Text = "MainForm";
            flowPanelControls.ResumeLayout(false);
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
        private Panel PanelSearch;
        private ComboBox cmbFilterBy;
        private TextBox txtSearch;
        private ComboBox cmbFilterValue;
        private FlowLayoutPanel flowPanelMovies;
    }
}