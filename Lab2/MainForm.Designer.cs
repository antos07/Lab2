namespace Lab2
{
    partial class MainFrom
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.removeFiltersButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.enteranceDateCheckBox = new System.Windows.Forms.CheckBox();
            this.groupCheckBox = new System.Windows.Forms.CheckBox();
            this.fieldOfStudyCheckBox = new System.Windows.Forms.CheckBox();
            this.facultyCheckBox = new System.Windows.Forms.CheckBox();
            this.studentNameCheckBox = new System.Windows.Forms.CheckBox();
            this.linqRadioButton = new System.Windows.Forms.RadioButton();
            this.domApiRadioButton = new System.Windows.Forms.RadioButton();
            this.saxApiRadioButton = new System.Windows.Forms.RadioButton();
            this.searchMethodLabel = new System.Windows.Forms.Label();
            this.selectedColumnsLabel = new System.Windows.Forms.Label();
            this.searchQueryLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchQueryTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openXmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToHtmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldOfStudyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enteringDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 49);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.removeFiltersButton);
            this.mainSplitContainer.Panel1.Controls.Add(this.filterButton);
            this.mainSplitContainer.Panel1.Controls.Add(this.enteranceDateCheckBox);
            this.mainSplitContainer.Panel1.Controls.Add(this.groupCheckBox);
            this.mainSplitContainer.Panel1.Controls.Add(this.fieldOfStudyCheckBox);
            this.mainSplitContainer.Panel1.Controls.Add(this.facultyCheckBox);
            this.mainSplitContainer.Panel1.Controls.Add(this.studentNameCheckBox);
            this.mainSplitContainer.Panel1.Controls.Add(this.linqRadioButton);
            this.mainSplitContainer.Panel1.Controls.Add(this.domApiRadioButton);
            this.mainSplitContainer.Panel1.Controls.Add(this.saxApiRadioButton);
            this.mainSplitContainer.Panel1.Controls.Add(this.searchMethodLabel);
            this.mainSplitContainer.Panel1.Controls.Add(this.selectedColumnsLabel);
            this.mainSplitContainer.Panel1.Controls.Add(this.searchQueryLabel);
            this.mainSplitContainer.Panel1.Controls.Add(this.searchLabel);
            this.mainSplitContainer.Panel1.Controls.Add(this.searchQueryTextBox);
            this.mainSplitContainer.Panel1MinSize = 750;
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.dataGridView);
            this.mainSplitContainer.Panel2MinSize = 1000;
            this.mainSplitContainer.Size = new System.Drawing.Size(2050, 1033);
            this.mainSplitContainer.SplitterDistance = 750;
            this.mainSplitContainer.TabIndex = 0;
            // 
            // removeFiltersButton
            // 
            this.removeFiltersButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.removeFiltersButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.removeFiltersButton.Location = new System.Drawing.Point(18, 902);
            this.removeFiltersButton.Name = "removeFiltersButton";
            this.removeFiltersButton.Size = new System.Drawing.Size(717, 73);
            this.removeFiltersButton.TabIndex = 9;
            this.removeFiltersButton.Text = "Прибрати фільтри";
            this.removeFiltersButton.UseVisualStyleBackColor = true;
            this.removeFiltersButton.Click += new System.EventHandler(this.removeFiltersButton_Click);
            // 
            // filterButton
            // 
            this.filterButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.filterButton.Location = new System.Drawing.Point(18, 813);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(717, 73);
            this.filterButton.TabIndex = 9;
            this.filterButton.Text = "Відфільтрувати";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // enteranceDateCheckBox
            // 
            this.enteranceDateCheckBox.AutoSize = true;
            this.enteranceDateCheckBox.Checked = true;
            this.enteranceDateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enteranceDateCheckBox.Location = new System.Drawing.Point(18, 476);
            this.enteranceDateCheckBox.Name = "enteranceDateCheckBox";
            this.enteranceDateCheckBox.Size = new System.Drawing.Size(216, 45);
            this.enteranceDateCheckBox.TabIndex = 5;
            this.enteranceDateCheckBox.Text = "Дата вступу";
            this.enteranceDateCheckBox.UseVisualStyleBackColor = true;
            this.enteranceDateCheckBox.CheckedChanged += new System.EventHandler(this.enteranceDateCheckBox_CheckedChanged);
            // 
            // groupCheckBox
            // 
            this.groupCheckBox.AutoSize = true;
            this.groupCheckBox.Checked = true;
            this.groupCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.groupCheckBox.Location = new System.Drawing.Point(18, 425);
            this.groupCheckBox.Name = "groupCheckBox";
            this.groupCheckBox.Size = new System.Drawing.Size(135, 45);
            this.groupCheckBox.TabIndex = 4;
            this.groupCheckBox.Text = "Група";
            this.groupCheckBox.UseVisualStyleBackColor = true;
            this.groupCheckBox.CheckedChanged += new System.EventHandler(this.groupCheckBox_CheckedChanged);
            // 
            // fieldOfStudyCheckBox
            // 
            this.fieldOfStudyCheckBox.AutoSize = true;
            this.fieldOfStudyCheckBox.Checked = true;
            this.fieldOfStudyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fieldOfStudyCheckBox.Location = new System.Drawing.Point(18, 374);
            this.fieldOfStudyCheckBox.Name = "fieldOfStudyCheckBox";
            this.fieldOfStudyCheckBox.Size = new System.Drawing.Size(244, 45);
            this.fieldOfStudyCheckBox.TabIndex = 3;
            this.fieldOfStudyCheckBox.Text = "Спеціальність";
            this.fieldOfStudyCheckBox.UseVisualStyleBackColor = true;
            this.fieldOfStudyCheckBox.CheckedChanged += new System.EventHandler(this.fieldOfStudyCheckBox_CheckedChanged);
            // 
            // facultyCheckBox
            // 
            this.facultyCheckBox.AutoSize = true;
            this.facultyCheckBox.Checked = true;
            this.facultyCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.facultyCheckBox.Location = new System.Drawing.Point(18, 323);
            this.facultyCheckBox.Name = "facultyCheckBox";
            this.facultyCheckBox.Size = new System.Drawing.Size(367, 45);
            this.facultyCheckBox.TabIndex = 2;
            this.facultyCheckBox.Text = "Структурний підрозділ";
            this.facultyCheckBox.UseVisualStyleBackColor = true;
            this.facultyCheckBox.CheckedChanged += new System.EventHandler(this.facultyCheckBox_CheckedChanged);
            // 
            // studentNameCheckBox
            // 
            this.studentNameCheckBox.AutoSize = true;
            this.studentNameCheckBox.Checked = true;
            this.studentNameCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.studentNameCheckBox.Location = new System.Drawing.Point(18, 272);
            this.studentNameCheckBox.Name = "studentNameCheckBox";
            this.studentNameCheckBox.Size = new System.Drawing.Size(102, 45);
            this.studentNameCheckBox.TabIndex = 1;
            this.studentNameCheckBox.Text = "ПІБ";
            this.studentNameCheckBox.UseVisualStyleBackColor = true;
            this.studentNameCheckBox.CheckedChanged += new System.EventHandler(this.studentNameCheckBox_CheckedChanged);
            // 
            // linqRadioButton
            // 
            this.linqRadioButton.AutoSize = true;
            this.linqRadioButton.Location = new System.Drawing.Point(18, 716);
            this.linqRadioButton.Name = "linqRadioButton";
            this.linqRadioButton.Size = new System.Drawing.Size(225, 45);
            this.linqRadioButton.TabIndex = 8;
            this.linqRadioButton.TabStop = true;
            this.linqRadioButton.Text = "LINQ to XML";
            this.linqRadioButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.linqRadioButton.UseVisualStyleBackColor = true;
            this.linqRadioButton.CheckedChanged += new System.EventHandler(this.linqRadioButton_CheckedChanged);
            // 
            // domApiRadioButton
            // 
            this.domApiRadioButton.AutoSize = true;
            this.domApiRadioButton.Location = new System.Drawing.Point(18, 665);
            this.domApiRadioButton.Name = "domApiRadioButton";
            this.domApiRadioButton.Size = new System.Drawing.Size(178, 45);
            this.domApiRadioButton.TabIndex = 7;
            this.domApiRadioButton.TabStop = true;
            this.domApiRadioButton.Text = "DOM API";
            this.domApiRadioButton.UseVisualStyleBackColor = true;
            this.domApiRadioButton.CheckedChanged += new System.EventHandler(this.domApiRadioButton_CheckedChanged);
            // 
            // saxApiRadioButton
            // 
            this.saxApiRadioButton.AutoSize = true;
            this.saxApiRadioButton.Checked = true;
            this.saxApiRadioButton.Location = new System.Drawing.Point(18, 614);
            this.saxApiRadioButton.Name = "saxApiRadioButton";
            this.saxApiRadioButton.Size = new System.Drawing.Size(160, 45);
            this.saxApiRadioButton.TabIndex = 6;
            this.saxApiRadioButton.TabStop = true;
            this.saxApiRadioButton.Text = "SAX API";
            this.saxApiRadioButton.UseVisualStyleBackColor = true;
            this.saxApiRadioButton.CheckedChanged += new System.EventHandler(this.saxApiRadioButton_CheckedChanged);
            // 
            // searchMethodLabel
            // 
            this.searchMethodLabel.AutoSize = true;
            this.searchMethodLabel.Location = new System.Drawing.Point(12, 557);
            this.searchMethodLabel.Name = "searchMethodLabel";
            this.searchMethodLabel.Size = new System.Drawing.Size(219, 41);
            this.searchMethodLabel.TabIndex = 5;
            this.searchMethodLabel.Text = "Метод пошуку";
            // 
            // selectedColumnsLabel
            // 
            this.selectedColumnsLabel.AutoSize = true;
            this.selectedColumnsLabel.Location = new System.Drawing.Point(12, 214);
            this.selectedColumnsLabel.Name = "selectedColumnsLabel";
            this.selectedColumnsLabel.Size = new System.Drawing.Size(310, 41);
            this.selectedColumnsLabel.TabIndex = 3;
            this.selectedColumnsLabel.Text = "Колонки для пошуку:";
            // 
            // searchQueryLabel
            // 
            this.searchQueryLabel.AutoSize = true;
            this.searchQueryLabel.Location = new System.Drawing.Point(12, 144);
            this.searchQueryLabel.Name = "searchQueryLabel";
            this.searchQueryLabel.Size = new System.Drawing.Size(102, 41);
            this.searchQueryLabel.TabIndex = 2;
            this.searchQueryLabel.Text = "Запит:";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchLabel.Location = new System.Drawing.Point(12, 23);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(556, 81);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Пошук у документі";
            // 
            // searchQueryTextBox
            // 
            this.searchQueryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchQueryTextBox.Location = new System.Drawing.Point(120, 144);
            this.searchQueryTextBox.Name = "searchQueryTextBox";
            this.searchQueryTextBox.Size = new System.Drawing.Size(615, 47);
            this.searchQueryTextBox.TabIndex = 0;
            this.searchQueryTextBox.TextChanged += new System.EventHandler(this.searchQueryTextBox_TextChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentNameColumn,
            this.facultyColumn,
            this.fieldOfStudyColumn,
            this.groupColumn,
            this.enteringDateColumn});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 102;
            this.dataGridView.RowTemplate.Height = 49;
            this.dataGridView.Size = new System.Drawing.Size(1296, 1033);
            this.dataGridView.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(2050, 49);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openXmlToolStripMenuItem,
            this.exportToHtmlToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(112, 45);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openXmlToolStripMenuItem
            // 
            this.openXmlToolStripMenuItem.Name = "openXmlToolStripMenuItem";
            this.openXmlToolStripMenuItem.Size = new System.Drawing.Size(478, 54);
            this.openXmlToolStripMenuItem.Text = "Відкрити XML-файл";
            this.openXmlToolStripMenuItem.Click += new System.EventHandler(this.openXmlToolStripMenuItem_Click);
            // 
            // exportToHtmlToolStripMenuItem
            // 
            this.exportToHtmlToolStripMenuItem.Name = "exportToHtmlToolStripMenuItem";
            this.exportToHtmlToolStripMenuItem.Size = new System.Drawing.Size(478, 54);
            this.exportToHtmlToolStripMenuItem.Text = "Експортувати в HTML";
            this.exportToHtmlToolStripMenuItem.Click += new System.EventHandler(this.exportToHtmlToolStripMenuItem_Click);
            // 
            // studentNameColumn
            // 
            this.studentNameColumn.HeaderText = "ПІБ";
            this.studentNameColumn.MinimumWidth = 12;
            this.studentNameColumn.Name = "studentNameColumn";
            this.studentNameColumn.ReadOnly = true;
            this.studentNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // facultyColumn
            // 
            this.facultyColumn.HeaderText = "Структурний підрозділ";
            this.facultyColumn.MinimumWidth = 12;
            this.facultyColumn.Name = "facultyColumn";
            this.facultyColumn.ReadOnly = true;
            this.facultyColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fieldOfStudyColumn
            // 
            this.fieldOfStudyColumn.HeaderText = "Спеціальність";
            this.fieldOfStudyColumn.MinimumWidth = 12;
            this.fieldOfStudyColumn.Name = "fieldOfStudyColumn";
            this.fieldOfStudyColumn.ReadOnly = true;
            this.fieldOfStudyColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupColumn
            // 
            this.groupColumn.HeaderText = "Група";
            this.groupColumn.MinimumWidth = 12;
            this.groupColumn.Name = "groupColumn";
            this.groupColumn.ReadOnly = true;
            this.groupColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // enteringDateColumn
            // 
            this.enteringDateColumn.HeaderText = "Дата вступу";
            this.enteringDateColumn.MinimumWidth = 12;
            this.enteringDateColumn.Name = "enteringDateColumn";
            this.enteringDateColumn.ReadOnly = true;
            this.enteringDateColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2050, 1082);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainFrom";
            this.Text = "Список студентів";
            this.Load += new System.EventHandler(this.MainFrom_Load);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel1.PerformLayout();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SplitContainer mainSplitContainer;
        private DataGridView dataGridView;
        private TextBox searchQueryTextBox;
        private Label searchLabel;
        private Label searchQueryLabel;
        private Label selectedColumnsLabel;
        private RadioButton linqRadioButton;
        private RadioButton domApiRadioButton;
        private RadioButton saxApiRadioButton;
        private Label searchMethodLabel;
        private CheckBox enteranceDateCheckBox;
        private CheckBox groupCheckBox;
        private CheckBox fieldOfStudyCheckBox;
        private CheckBox facultyCheckBox;
        private CheckBox studentNameCheckBox;
        private Button filterButton;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openXmlToolStripMenuItem;
        private ToolStripMenuItem exportToHtmlToolStripMenuItem;
        private Button removeFiltersButton;
        private DataGridViewTextBoxColumn studentNameColumn;
        private DataGridViewTextBoxColumn facultyColumn;
        private DataGridViewTextBoxColumn fieldOfStudyColumn;
        private DataGridViewTextBoxColumn groupColumn;
        private DataGridViewTextBoxColumn enteringDateColumn;
    }
}