namespace Laboration_3
{
    partial class formWindow
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveAs = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.OpenFileTextBox = new System.Windows.Forms.RichTextBox();
            this.labWithSpace = new System.Windows.Forms.Label();
            this.labWithoutSpace = new System.Windows.Forms.Label();
            this.labAmountWords = new System.Windows.Forms.Label();
            this.labAmountRows = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop = true;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Controls.Add(this.btnCreate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnOpenFile, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSaveAs, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.OpenFileTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labWithSpace, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labWithoutSpace, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labAmountWords, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.labAmountRows, 4, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(673, 320);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDrop);
            this.tableLayoutPanel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            // 
            // btnCreate
            // 
            this.btnCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreate.Location = new System.Drawing.Point(8, 8);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(126, 25);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Ny";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOpenFile.Location = new System.Drawing.Point(140, 8);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(126, 25);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "Öppna";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(404, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(126, 25);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Spara";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnSaveAs
            // 
            this.btnSaveAs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveAs.Location = new System.Drawing.Point(272, 8);
            this.btnSaveAs.Name = "btnSaveAs";
            this.btnSaveAs.Size = new System.Drawing.Size(126, 25);
            this.btnSaveAs.TabIndex = 2;
            this.btnSaveAs.Text = "Spara Som";
            this.btnSaveAs.UseVisualStyleBackColor = true;
            this.btnSaveAs.Click += new System.EventHandler(this.BtnSaveAs_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClose.Location = new System.Drawing.Point(536, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(126, 25);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Avsluta";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // OpenFileTextBox
            // 
            this.OpenFileTextBox.AllowDrop = true;
            this.tableLayoutPanel1.SetColumnSpan(this.OpenFileTextBox, 5);
            this.OpenFileTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenFileTextBox.Location = new System.Drawing.Point(8, 39);
            this.OpenFileTextBox.Name = "OpenFileTextBox";
            this.OpenFileTextBox.Size = new System.Drawing.Size(654, 211);
            this.OpenFileTextBox.TabIndex = 5;
            this.OpenFileTextBox.Text = "";
            this.OpenFileTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDrop);
            this.OpenFileTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnter);
            this.OpenFileTextBox.TextChanged += new System.EventHandler(this.OpenFileTextBox_TextChanged);
            // 
            // labWithSpace
            // 
            this.labWithSpace.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labWithSpace, 3);
            this.labWithSpace.Location = new System.Drawing.Point(8, 253);
            this.labWithSpace.Name = "labWithSpace";
            this.labWithSpace.Size = new System.Drawing.Size(0, 13);
            this.labWithSpace.TabIndex = 6;
            // 
            // labWithoutSpace
            // 
            this.labWithoutSpace.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labWithoutSpace, 3);
            this.labWithoutSpace.Location = new System.Drawing.Point(8, 284);
            this.labWithoutSpace.Name = "labWithoutSpace";
            this.labWithoutSpace.Size = new System.Drawing.Size(0, 13);
            this.labWithoutSpace.TabIndex = 7;
            // 
            // labAmountWords
            // 
            this.labAmountWords.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labAmountWords, 2);
            this.labAmountWords.Location = new System.Drawing.Point(404, 253);
            this.labAmountWords.Name = "labAmountWords";
            this.labAmountWords.Size = new System.Drawing.Size(0, 13);
            this.labAmountWords.TabIndex = 8;
            // 
            // labAmountRows
            // 
            this.labAmountRows.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labAmountRows, 2);
            this.labAmountRows.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labAmountRows.Location = new System.Drawing.Point(404, 284);
            this.labAmountRows.Name = "labAmountRows";
            this.labAmountRows.Size = new System.Drawing.Size(0, 13);
            this.labAmountRows.TabIndex = 9;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // formWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 320);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(400, 322);
            this.Name = "formWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWindow_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveAs;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.RichTextBox OpenFileTextBox;
        private System.Windows.Forms.Label labWithSpace;
        private System.Windows.Forms.Label labWithoutSpace;
        private System.Windows.Forms.Label labAmountWords;
        private System.Windows.Forms.Label labAmountRows;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

