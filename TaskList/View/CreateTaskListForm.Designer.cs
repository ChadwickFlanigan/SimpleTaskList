namespace TaskList.View
{
    partial class CreateTaskListForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            listNameLabel = new Label();
            listNameTextBox = new TextBox();
            createButton = new Button();
            cancelButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.5439339F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.45607F));
            tableLayoutPanel1.Controls.Add(listNameLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(listNameTextBox, 1, 0);
            tableLayoutPanel1.Controls.Add(createButton, 1, 1);
            tableLayoutPanel1.Controls.Add(cancelButton, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.0566025F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.9433975F));
            tableLayoutPanel1.Size = new Size(239, 92);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // listNameLabel
            // 
            listNameLabel.Anchor = AnchorStyles.Right;
            listNameLabel.AutoSize = true;
            listNameLabel.Location = new Point(25, 15);
            listNameLabel.Name = "listNameLabel";
            listNameLabel.Size = new Size(45, 15);
            listNameLabel.TabIndex = 0;
            listNameLabel.Text = "Name: ";
            // 
            // listNameTextBox
            // 
            listNameTextBox.Anchor = AnchorStyles.Left;
            listNameTextBox.Location = new Point(76, 11);
            listNameTextBox.Name = "listNameTextBox";
            listNameTextBox.Size = new Size(160, 23);
            listNameTextBox.TabIndex = 1;
            // 
            // createButton
            // 
            createButton.Anchor = AnchorStyles.None;
            createButton.Location = new Point(118, 57);
            createButton.Name = "createButton";
            createButton.Size = new Size(75, 23);
            createButton.TabIndex = 2;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.None;
            cancelButton.Location = new Point(3, 57);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(67, 23);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // CreateTaskListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(239, 92);
            Controls.Add(tableLayoutPanel1);
            Name = "CreateTaskListForm";
            Text = "Create a List";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label listNameLabel;
        private TextBox listNameTextBox;
        private Button cancelButton;
        private Button createButton;
    }
}