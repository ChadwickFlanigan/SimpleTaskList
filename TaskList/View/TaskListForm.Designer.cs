namespace TaskList
{
    partial class TaskListForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            viewListButton = new Button();
            createListButton = new Button();
            deleteButton = new Button();
            listDataGridView = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listDataGridView).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 272F));
            tableLayoutPanel1.Controls.Add(viewListButton, 2, 0);
            tableLayoutPanel1.Controls.Add(createListButton, 2, 1);
            tableLayoutPanel1.Controls.Add(deleteButton, 2, 2);
            tableLayoutPanel1.Controls.Add(listDataGridView, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 169F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // viewListButton
            // 
            viewListButton.Anchor = AnchorStyles.None;
            viewListButton.Location = new Point(626, 58);
            viewListButton.Name = "viewListButton";
            viewListButton.Size = new Size(75, 23);
            viewListButton.TabIndex = 0;
            viewListButton.Text = "View";
            viewListButton.UseVisualStyleBackColor = true;
            // 
            // createListButton
            // 
            createListButton.Anchor = AnchorStyles.None;
            createListButton.Location = new Point(626, 198);
            createListButton.Name = "createListButton";
            createListButton.Size = new Size(75, 23);
            createListButton.TabIndex = 1;
            createListButton.Text = "Create";
            createListButton.UseVisualStyleBackColor = true;
            createListButton.Click += createListButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.None;
            deleteButton.Location = new Point(626, 353);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // listDataGridView
            // 
            listDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(listDataGridView, 2);
            listDataGridView.Dock = DockStyle.Fill;
            listDataGridView.Location = new Point(3, 3);
            listDataGridView.Name = "listDataGridView";
            tableLayoutPanel1.SetRowSpan(listDataGridView, 3);
            listDataGridView.RowTemplate.Height = 25;
            listDataGridView.Size = new Size(522, 444);
            listDataGridView.TabIndex = 3;
            // 
            // TaskListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "TaskListForm";
            Text = "Simple Task List";
            Load += TaskListForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)listDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button viewListButton;
        private Button createListButton;
        private Button deleteButton;
        private DataGridView listDataGridView;
    }
}