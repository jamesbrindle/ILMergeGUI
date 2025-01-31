﻿namespace ILMergeGui
{
    /// <summary>
    /// The mainform.
    /// </summary>
    partial class Mainform
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
            this.components = new System.ComponentModel.Container();
            this.ToolTips = new System.Windows.Forms.ToolTip(this.components);
            this.ChkSignKeyFile = new System.Windows.Forms.CheckBox();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.ChkGenerateLog = new System.Windows.Forms.CheckBox();
            this.ChkDelayedSign = new System.Windows.Forms.CheckBox();
            this.btnLogFile = new System.Windows.Forms.Button();
            this.ChkUnionDuplicates = new System.Windows.Forms.CheckBox();
            this.TxtLogFile = new System.Windows.Forms.TextBox();
            this.btnKeyFile = new System.Windows.Forms.Button();
            this.ChkCopyAttributes = new System.Windows.Forms.CheckBox();
            this.TxtKeyFile = new System.Windows.Forms.TextBox();
            this.TxtOutputAssembly = new System.Windows.Forms.TextBox();
            this.btnOutputPath = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.CboDebug = new System.Windows.Forms.ComboBox();
            this.CboTargetFramework = new System.Windows.Forms.ComboBox();
            this.ListAssembly = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChkInternalize = new System.Windows.Forms.CheckBox();
            this.ChkMergeXml = new System.Windows.Forms.CheckBox();
            this.ChkGenCmdLine = new System.Windows.Forms.CheckBox();
            this.WorkerILMerge = new System.ComponentModel.BackgroundWorker();
            this.openFile1 = new System.Windows.Forms.OpenFileDialog();
            this.LblPrimaryAssembly = new System.Windows.Forms.Label();
            this.LblPrimaryAssemblyInfo = new System.Windows.Forms.Label();
            this.BoxOutput = new System.Windows.Forms.GroupBox();
            this.LblOutputPath = new System.Windows.Forms.Label();
            this.LblDebug = new System.Windows.Forms.Label();
            this.LblTargetFramework = new System.Windows.Forms.Label();
            this.BoxOptions = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.menuRecentFile = new System.Windows.Forms.ToolStripMenuItem();
            this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxOutput.SuspendLayout();
            this.BoxOptions.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ToolTips
            // 
            this.ToolTips.AutomaticDelay = 800;
            this.ToolTips.IsBalloon = true;
            // 
            // ChkSignKeyFile
            // 
            this.ChkSignKeyFile.AutoSize = true;
            this.ChkSignKeyFile.Location = new System.Drawing.Point(8, 60);
            this.ChkSignKeyFile.Margin = new System.Windows.Forms.Padding(4);
            this.ChkSignKeyFile.Name = "ChkSignKeyFile";
            this.ChkSignKeyFile.Size = new System.Drawing.Size(126, 20);
            this.ChkSignKeyFile.TabIndex = 5;
            this.ChkSignKeyFile.Text = "Sign with key file";
            this.ToolTips.SetToolTip(this.ChkSignKeyFile, "Sign the output assembly with a key file.");
            this.ChkSignKeyFile.UseVisualStyleBackColor = true;
            this.ChkSignKeyFile.CheckedChanged += new System.EventHandler(this.ChkSignKeyFile_CheckedChanged);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFile.Image = global::ILMergeGui.Properties.Resources.IconAdd;
            this.btnAddFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddFile.Location = new System.Drawing.Point(671, 249);
            this.btnAddFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(149, 28);
            this.btnAddFile.TabIndex = 33;
            this.btnAddFile.Text = "Add assemblies";
            this.btnAddFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolTips.SetToolTip(this.btnAddFile, "Click to select and add assemblies to the list.");
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // ChkGenerateLog
            // 
            this.ChkGenerateLog.AutoSize = true;
            this.ChkGenerateLog.Location = new System.Drawing.Point(8, 122);
            this.ChkGenerateLog.Margin = new System.Windows.Forms.Padding(4);
            this.ChkGenerateLog.Name = "ChkGenerateLog";
            this.ChkGenerateLog.Size = new System.Drawing.Size(127, 20);
            this.ChkGenerateLog.TabIndex = 13;
            this.ChkGenerateLog.Text = "Generate log file";
            this.ToolTips.SetToolTip(this.ChkGenerateLog, "Write results to a log file.");
            this.ChkGenerateLog.UseVisualStyleBackColor = true;
            this.ChkGenerateLog.CheckedChanged += new System.EventHandler(this.ChkGenerateLog_CheckedChanged);
            // 
            // ChkDelayedSign
            // 
            this.ChkDelayedSign.AutoSize = true;
            this.ChkDelayedSign.Enabled = false;
            this.ChkDelayedSign.Location = new System.Drawing.Point(168, 60);
            this.ChkDelayedSign.Margin = new System.Windows.Forms.Padding(4);
            this.ChkDelayedSign.Name = "ChkDelayedSign";
            this.ChkDelayedSign.Size = new System.Drawing.Size(109, 20);
            this.ChkDelayedSign.TabIndex = 7;
            this.ChkDelayedSign.Text = "Delayed sign";
            this.ToolTips.SetToolTip(this.ChkDelayedSign, "Use delayed sign.");
            this.ChkDelayedSign.UseVisualStyleBackColor = true;
            // 
            // btnLogFile
            // 
            this.btnLogFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogFile.Enabled = false;
            this.btnLogFile.Image = global::ILMergeGui.Properties.Resources.IconFolder;
            this.btnLogFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnLogFile.Location = new System.Drawing.Point(787, 143);
            this.btnLogFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogFile.Name = "btnLogFile";
            this.btnLogFile.Size = new System.Drawing.Size(33, 28);
            this.btnLogFile.TabIndex = 17;
            this.ToolTips.SetToolTip(this.btnLogFile, "Click to select a log path");
            this.btnLogFile.UseVisualStyleBackColor = true;
            this.btnLogFile.Click += new System.EventHandler(this.btnLogFile_Click);
            // 
            // ChkUnionDuplicates
            // 
            this.ChkUnionDuplicates.AutoSize = true;
            this.ChkUnionDuplicates.Location = new System.Drawing.Point(168, 26);
            this.ChkUnionDuplicates.Margin = new System.Windows.Forms.Padding(4);
            this.ChkUnionDuplicates.Name = "ChkUnionDuplicates";
            this.ChkUnionDuplicates.Size = new System.Drawing.Size(129, 20);
            this.ChkUnionDuplicates.TabIndex = 3;
            this.ChkUnionDuplicates.Text = "Union duplicates";
            this.ToolTips.SetToolTip(this.ChkUnionDuplicates, "Union duplicate classes and references.");
            this.ChkUnionDuplicates.UseVisualStyleBackColor = true;
            // 
            // TxtLogFile
            // 
            this.TxtLogFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtLogFile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TxtLogFile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.TxtLogFile.Enabled = false;
            this.TxtLogFile.Location = new System.Drawing.Point(8, 145);
            this.TxtLogFile.Margin = new System.Windows.Forms.Padding(4);
            this.TxtLogFile.MaxLength = 255;
            this.TxtLogFile.Name = "TxtLogFile";
            this.TxtLogFile.Size = new System.Drawing.Size(769, 22);
            this.TxtLogFile.TabIndex = 15;
            this.ToolTips.SetToolTip(this.TxtLogFile, "Path to the log file.");
            // 
            // btnKeyFile
            // 
            this.btnKeyFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKeyFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKeyFile.Enabled = false;
            this.btnKeyFile.Image = global::ILMergeGui.Properties.Resources.IconFolder;
            this.btnKeyFile.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnKeyFile.Location = new System.Drawing.Point(787, 81);
            this.btnKeyFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnKeyFile.Name = "btnKeyFile";
            this.btnKeyFile.Size = new System.Drawing.Size(33, 28);
            this.btnKeyFile.TabIndex = 11;
            this.ToolTips.SetToolTip(this.btnKeyFile, "Click to select a key file");
            this.btnKeyFile.UseVisualStyleBackColor = true;
            this.btnKeyFile.Click += new System.EventHandler(this.btnKeyFile_Click);
            // 
            // ChkCopyAttributes
            // 
            this.ChkCopyAttributes.AutoSize = true;
            this.ChkCopyAttributes.Checked = true;
            this.ChkCopyAttributes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkCopyAttributes.Location = new System.Drawing.Point(8, 26);
            this.ChkCopyAttributes.Margin = new System.Windows.Forms.Padding(4);
            this.ChkCopyAttributes.Name = "ChkCopyAttributes";
            this.ChkCopyAttributes.Size = new System.Drawing.Size(118, 20);
            this.ChkCopyAttributes.TabIndex = 1;
            this.ChkCopyAttributes.Text = "Copy attributes";
            this.ToolTips.SetToolTip(this.ChkCopyAttributes, "Copy assembly attributes.");
            this.ChkCopyAttributes.UseVisualStyleBackColor = true;
            // 
            // TxtKeyFile
            // 
            this.TxtKeyFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtKeyFile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TxtKeyFile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.TxtKeyFile.Enabled = false;
            this.TxtKeyFile.Location = new System.Drawing.Point(8, 84);
            this.TxtKeyFile.Margin = new System.Windows.Forms.Padding(4);
            this.TxtKeyFile.MaxLength = 255;
            this.TxtKeyFile.Name = "TxtKeyFile";
            this.TxtKeyFile.Size = new System.Drawing.Size(769, 22);
            this.TxtKeyFile.TabIndex = 9;
            this.ToolTips.SetToolTip(this.TxtKeyFile, "Path to the key file");
            // 
            // TxtOutputAssembly
            // 
            this.TxtOutputAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtOutputAssembly.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.TxtOutputAssembly.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.TxtOutputAssembly.Location = new System.Drawing.Point(8, 46);
            this.TxtOutputAssembly.Margin = new System.Windows.Forms.Padding(4);
            this.TxtOutputAssembly.MaxLength = 255;
            this.TxtOutputAssembly.Name = "TxtOutputAssembly";
            this.TxtOutputAssembly.Size = new System.Drawing.Size(769, 22);
            this.TxtOutputAssembly.TabIndex = 2;
            this.ToolTips.SetToolTip(this.TxtOutputAssembly, "Path to the output generated assembly.");
            // 
            // btnOutputPath
            // 
            this.btnOutputPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOutputPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOutputPath.Image = global::ILMergeGui.Properties.Resources.IconFolder;
            this.btnOutputPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnOutputPath.Location = new System.Drawing.Point(787, 43);
            this.btnOutputPath.Margin = new System.Windows.Forms.Padding(4);
            this.btnOutputPath.Name = "btnOutputPath";
            this.btnOutputPath.Size = new System.Drawing.Size(33, 28);
            this.btnOutputPath.TabIndex = 4;
            this.ToolTips.SetToolTip(this.btnOutputPath, "Click to select the path to the output assembly");
            this.btnOutputPath.UseVisualStyleBackColor = true;
            this.btnOutputPath.Click += new System.EventHandler(this.btnOutputPath_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMerge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMerge.Enabled = false;
            this.btnMerge.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMerge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMerge.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnMerge.Location = new System.Drawing.Point(679, 89);
            this.btnMerge.Margin = new System.Windows.Forms.Padding(4);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(141, 28);
            this.btnMerge.TabIndex = 10;
            this.btnMerge.Text = "Merge!";
            this.btnMerge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ToolTips.SetToolTip(this.btnMerge, "Click to start merging.");
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // CboDebug
            // 
            this.CboDebug.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboDebug.FormattingEnabled = true;
            this.CboDebug.Items.AddRange(new object[] {
            "True",
            "False"});
            this.CboDebug.Location = new System.Drawing.Point(72, 89);
            this.CboDebug.Margin = new System.Windows.Forms.Padding(4);
            this.CboDebug.Name = "CboDebug";
            this.CboDebug.Size = new System.Drawing.Size(84, 24);
            this.CboDebug.TabIndex = 6;
            this.ToolTips.SetToolTip(this.CboDebug, "Set the debug parameter.");
            // 
            // CboTargetFramework
            // 
            this.CboTargetFramework.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CboTargetFramework.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboTargetFramework.FormattingEnabled = true;
            this.CboTargetFramework.Items.AddRange(new object[] {
            ".NET 2.0",
            ".NET 3.0",
            ".NET 3.5",
            ".NET 4.0"});
            this.CboTargetFramework.Location = new System.Drawing.Point(256, 89);
            this.CboTargetFramework.Margin = new System.Windows.Forms.Padding(4);
            this.CboTargetFramework.Name = "CboTargetFramework";
            this.CboTargetFramework.Size = new System.Drawing.Size(383, 24);
            this.CboTargetFramework.TabIndex = 8;
            this.ToolTips.SetToolTip(this.CboTargetFramework, "Set the target framework.");
            // 
            // ListAssembly
            // 
            this.ListAssembly.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListAssembly.AllowDrop = true;
            this.ListAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListAssembly.CheckBoxes = true;
            this.ListAssembly.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ListAssembly.FullRowSelect = true;
            this.ListAssembly.GridLines = true;
            this.ListAssembly.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListAssembly.HideSelection = false;
            this.ListAssembly.Location = new System.Drawing.Point(4, 20);
            this.ListAssembly.Margin = new System.Windows.Forms.Padding(4);
            this.ListAssembly.Name = "ListAssembly";
            this.ListAssembly.Size = new System.Drawing.Size(819, 221);
            this.ListAssembly.TabIndex = 34;
            this.ToolTips.SetToolTip(this.ListAssembly, "Assemblies to be merged.");
            this.ListAssembly.UseCompatibleStateImageBehavior = false;
            this.ListAssembly.View = System.Windows.Forms.View.Details;
            this.ListAssembly.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ListAssembly_ItemCheck);
            this.ListAssembly.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.ListAssembly_ItemChecked);
            this.ListAssembly.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListAssembly_DragDrop);
            this.ListAssembly.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListAssembly_DragEnter);
            this.ListAssembly.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListAssembly_KeyDown);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Assembly";
            // 
            // ChkInternalize
            // 
            this.ChkInternalize.AutoSize = true;
            this.ChkInternalize.Location = new System.Drawing.Point(337, 26);
            this.ChkInternalize.Margin = new System.Windows.Forms.Padding(4);
            this.ChkInternalize.Name = "ChkInternalize";
            this.ChkInternalize.Size = new System.Drawing.Size(89, 20);
            this.ChkInternalize.TabIndex = 18;
            this.ChkInternalize.Text = "Internalize";
            this.ToolTips.SetToolTip(this.ChkInternalize, "Change all public identifiers into internal ones.");
            this.ChkInternalize.UseVisualStyleBackColor = true;
            // 
            // ChkMergeXml
            // 
            this.ChkMergeXml.AutoSize = true;
            this.ChkMergeXml.Location = new System.Drawing.Point(337, 60);
            this.ChkMergeXml.Margin = new System.Windows.Forms.Padding(4);
            this.ChkMergeXml.Name = "ChkMergeXml";
            this.ChkMergeXml.Size = new System.Drawing.Size(182, 20);
            this.ChkMergeXml.TabIndex = 19;
            this.ChkMergeXml.Text = "Merge xml documentation";
            this.ToolTips.SetToolTip(this.ChkMergeXml, "Merge xml documentation into a single file.");
            this.ChkMergeXml.UseVisualStyleBackColor = true;
            // 
            // ChkGenCmdLine
            // 
            this.ChkGenCmdLine.AutoSize = true;
            this.ChkGenCmdLine.Location = new System.Drawing.Point(168, 122);
            this.ChkGenCmdLine.Margin = new System.Windows.Forms.Padding(4);
            this.ChkGenCmdLine.Name = "ChkGenCmdLine";
            this.ChkGenCmdLine.Size = new System.Drawing.Size(158, 20);
            this.ChkGenCmdLine.TabIndex = 22;
            this.ChkGenCmdLine.Text = "Generate cmd line file";
            this.ToolTips.SetToolTip(this.ChkGenCmdLine, "Write results to a log file.");
            this.ChkGenCmdLine.UseVisualStyleBackColor = true;
            // 
            // WorkerILMerge
            // 
            this.WorkerILMerge.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WorkerILMerge_DoWork);
            this.WorkerILMerge.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.WorkerILMerge_RunWorkerCompleted);
            // 
            // LblPrimaryAssembly
            // 
            this.LblPrimaryAssembly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblPrimaryAssembly.AutoSize = true;
            this.LblPrimaryAssembly.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblPrimaryAssembly.Location = new System.Drawing.Point(144, 255);
            this.LblPrimaryAssembly.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrimaryAssembly.Name = "LblPrimaryAssembly";
            this.LblPrimaryAssembly.Size = new System.Drawing.Size(16, 16);
            this.LblPrimaryAssembly.TabIndex = 30;
            this.LblPrimaryAssembly.Text = "···";
            this.LblPrimaryAssembly.TextChanged += new System.EventHandler(this.LblPrimaryAssembly_TextChanged);
            // 
            // LblPrimaryAssemblyInfo
            // 
            this.LblPrimaryAssemblyInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblPrimaryAssemblyInfo.AutoSize = true;
            this.LblPrimaryAssemblyInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblPrimaryAssemblyInfo.Location = new System.Drawing.Point(8, 255);
            this.LblPrimaryAssemblyInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPrimaryAssemblyInfo.Name = "LblPrimaryAssemblyInfo";
            this.LblPrimaryAssemblyInfo.Size = new System.Drawing.Size(118, 16);
            this.LblPrimaryAssemblyInfo.TabIndex = 31;
            this.LblPrimaryAssemblyInfo.Text = "Primary assembly:";
            // 
            // BoxOutput
            // 
            this.BoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxOutput.Controls.Add(this.LblOutputPath);
            this.BoxOutput.Controls.Add(this.TxtOutputAssembly);
            this.BoxOutput.Controls.Add(this.btnOutputPath);
            this.BoxOutput.Controls.Add(this.btnMerge);
            this.BoxOutput.Controls.Add(this.CboDebug);
            this.BoxOutput.Controls.Add(this.LblDebug);
            this.BoxOutput.Controls.Add(this.LblTargetFramework);
            this.BoxOutput.Controls.Add(this.CboTargetFramework);
            this.BoxOutput.Location = new System.Drawing.Point(16, 519);
            this.BoxOutput.Margin = new System.Windows.Forms.Padding(4);
            this.BoxOutput.Name = "BoxOutput";
            this.BoxOutput.Padding = new System.Windows.Forms.Padding(4);
            this.BoxOutput.Size = new System.Drawing.Size(828, 124);
            this.BoxOutput.TabIndex = 35;
            this.BoxOutput.TabStop = false;
            this.BoxOutput.Text = "Output";
            // 
            // LblOutputPath
            // 
            this.LblOutputPath.AutoSize = true;
            this.LblOutputPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblOutputPath.Location = new System.Drawing.Point(4, 26);
            this.LblOutputPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblOutputPath.Name = "LblOutputPath";
            this.LblOutputPath.Size = new System.Drawing.Size(110, 16);
            this.LblOutputPath.TabIndex = 0;
            this.LblOutputPath.Text = "Output assembly:";
            // 
            // LblDebug
            // 
            this.LblDebug.AutoSize = true;
            this.LblDebug.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblDebug.Location = new System.Drawing.Point(4, 92);
            this.LblDebug.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblDebug.Name = "LblDebug";
            this.LblDebug.Size = new System.Drawing.Size(51, 16);
            this.LblDebug.TabIndex = 0;
            this.LblDebug.Text = "Debug:";
            // 
            // LblTargetFramework
            // 
            this.LblTargetFramework.AutoSize = true;
            this.LblTargetFramework.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LblTargetFramework.Location = new System.Drawing.Point(165, 92);
            this.LblTargetFramework.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTargetFramework.Name = "LblTargetFramework";
            this.LblTargetFramework.Size = new System.Drawing.Size(77, 16);
            this.LblTargetFramework.TabIndex = 0;
            this.LblTargetFramework.Text = "Framework:";
            // 
            // BoxOptions
            // 
            this.BoxOptions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoxOptions.Controls.Add(this.ChkGenCmdLine);
            this.BoxOptions.Controls.Add(this.radioButton2);
            this.BoxOptions.Controls.Add(this.radioButton1);
            this.BoxOptions.Controls.Add(this.ChkMergeXml);
            this.BoxOptions.Controls.Add(this.ChkInternalize);
            this.BoxOptions.Controls.Add(this.ChkSignKeyFile);
            this.BoxOptions.Controls.Add(this.ChkGenerateLog);
            this.BoxOptions.Controls.Add(this.ChkDelayedSign);
            this.BoxOptions.Controls.Add(this.btnLogFile);
            this.BoxOptions.Controls.Add(this.TxtKeyFile);
            this.BoxOptions.Controls.Add(this.ChkUnionDuplicates);
            this.BoxOptions.Controls.Add(this.TxtLogFile);
            this.BoxOptions.Controls.Add(this.btnKeyFile);
            this.BoxOptions.Controls.Add(this.ChkCopyAttributes);
            this.BoxOptions.Location = new System.Drawing.Point(16, 325);
            this.BoxOptions.Margin = new System.Windows.Forms.Padding(4);
            this.BoxOptions.Name = "BoxOptions";
            this.BoxOptions.Padding = new System.Windows.Forms.Padding(4);
            this.BoxOptions.Size = new System.Drawing.Size(828, 187);
            this.BoxOptions.TabIndex = 34;
            this.BoxOptions.TabStop = false;
            this.BoxOptions.Text = "Options";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(584, 55);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 20);
            this.radioButton2.TabIndex = 21;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ILRepack";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(584, 23);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 20);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ILMerge";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 28);
            this.menuStrip1.TabIndex = 38;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem3
            // 
            this.fileToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileNew,
            this.toolStripSeparator6,
            this.mnuFileOpen,
            this.mnuFileSave,
            this.toolStripSeparator7,
            this.mnuFileExit,
            this.toolStripSeparator8,
            this.menuRecentFile});
            this.fileToolStripMenuItem3.Name = "fileToolStripMenuItem3";
            this.fileToolStripMenuItem3.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem3.Text = "File";
            // 
            // mnuFileNew
            // 
            this.mnuFileNew.Name = "mnuFileNew";
            this.mnuFileNew.Size = new System.Drawing.Size(224, 26);
            this.mnuFileNew.Text = "New";
            this.mnuFileNew.Click += new System.EventHandler(this.mnuFileNew_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuFileOpen
            // 
            this.mnuFileOpen.Name = "mnuFileOpen";
            this.mnuFileOpen.Size = new System.Drawing.Size(224, 26);
            this.mnuFileOpen.Text = "Open";
            this.mnuFileOpen.Click += new System.EventHandler(this.mnuFileOpen_Click);
            // 
            // mnuFileSave
            // 
            this.mnuFileSave.Name = "mnuFileSave";
            this.mnuFileSave.Size = new System.Drawing.Size(224, 26);
            this.mnuFileSave.Text = "Save";
            this.mnuFileSave.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(221, 6);
            // 
            // mnuFileExit
            // 
            this.mnuFileExit.Name = "mnuFileExit";
            this.mnuFileExit.Size = new System.Drawing.Size(224, 26);
            this.mnuFileExit.Text = "Exit";
            this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(221, 6);
            // 
            // menuRecentFile
            // 
            this.menuRecentFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xToolStripMenuItem});
            this.menuRecentFile.Name = "menuRecentFile";
            this.menuRecentFile.Size = new System.Drawing.Size(224, 26);
            this.menuRecentFile.Text = "MRU";
            // 
            // xToolStripMenuItem
            // 
            this.xToolStripMenuItem.Name = "xToolStripMenuItem";
            this.xToolStripMenuItem.Size = new System.Drawing.Size(99, 26);
            this.xToolStripMenuItem.Text = "x";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem1.Text = "New";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem1.Text = "Open";
            // 
            // saveToolStripMenuItem1
            // 
            this.saveToolStripMenuItem1.Name = "saveToolStripMenuItem1";
            this.saveToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem1.Text = "Save";
            this.saveToolStripMenuItem1.Click += new System.EventHandler(this.mnuFileSave_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // fileToolStripMenuItem2
            // 
            this.fileToolStripMenuItem2.Name = "fileToolStripMenuItem2";
            this.fileToolStripMenuItem2.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem2.Text = "File";
            // 
            // newToolStripMenuItem2
            // 
            this.newToolStripMenuItem2.Name = "newToolStripMenuItem2";
            this.newToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem2.Text = "New";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // openToolStripMenuItem2
            // 
            this.openToolStripMenuItem2.Name = "openToolStripMenuItem2";
            this.openToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem2.Text = "Open";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ListAssembly);
            this.groupBox1.Controls.Add(this.btnAddFile);
            this.groupBox1.Controls.Add(this.LblPrimaryAssemblyInfo);
            this.groupBox1.Controls.Add(this.LblPrimaryAssembly);
            this.groupBox1.Location = new System.Drawing.Point(16, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(828, 284);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assemblies to merge:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 658);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "label1";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.ilproj";
            this.openFileDialog1.FileName = "*.ilproj";
            this.openFileDialog1.Filter = "IlMerge Project|*.ilproj|All Files|*.*";
            this.openFileDialog1.Title = "Select an IlMergeGui Project";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.ilproj";
            this.saveFileDialog1.FileName = "*.ilproj";
            this.saveFileDialog1.Filter = "IlMerge Project|*.ilproj|All Files|*.*";
            this.saveFileDialog1.Title = "Save as IlMergeGui Project";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 681);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 41;
            this.label2.Text = "label2";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(860, 708);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BoxOutput);
            this.Controls.Add(this.BoxOptions);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(581, 629);
            this.Name = "Mainform";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "ILMerge-GUI";
            this.Load += new System.EventHandler(this.Mainform_Load);
            this.Shown += new System.EventHandler(this.Mainform_Shown);
            this.BoxOutput.ResumeLayout(false);
            this.BoxOutput.PerformLayout();
            this.BoxOptions.ResumeLayout(false);
            this.BoxOptions.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolTip ToolTips;
        internal System.Windows.Forms.CheckBox ChkSignKeyFile;
        internal System.Windows.Forms.Button btnAddFile;
        internal System.Windows.Forms.CheckBox ChkGenerateLog;
        internal System.Windows.Forms.CheckBox ChkDelayedSign;
        internal System.Windows.Forms.Button btnLogFile;
        internal System.Windows.Forms.CheckBox ChkUnionDuplicates;
        internal System.Windows.Forms.TextBox TxtLogFile;
        internal System.Windows.Forms.Button btnKeyFile;
        internal System.Windows.Forms.CheckBox ChkCopyAttributes;
        internal System.Windows.Forms.TextBox TxtKeyFile;
        internal System.Windows.Forms.TextBox TxtOutputAssembly;
        internal System.Windows.Forms.Button btnOutputPath;
        internal System.Windows.Forms.Button btnMerge;
        internal System.Windows.Forms.ComboBox CboDebug;
        internal System.Windows.Forms.ComboBox CboTargetFramework;
        internal System.ComponentModel.BackgroundWorker WorkerILMerge;
        internal System.Windows.Forms.OpenFileDialog openFile1;
        internal System.Windows.Forms.Label LblPrimaryAssembly;
        internal System.Windows.Forms.Label LblPrimaryAssemblyInfo;
        internal System.Windows.Forms.GroupBox BoxOutput;
        internal System.Windows.Forms.Label LblOutputPath;
        internal System.Windows.Forms.Label LblDebug;
        internal System.Windows.Forms.Label LblTargetFramework;
        internal System.Windows.Forms.GroupBox BoxOptions;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuFileNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem mnuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuFileSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem mnuFileExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView ListAssembly;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        internal System.Windows.Forms.CheckBox ChkInternalize;
        internal System.Windows.Forms.CheckBox ChkMergeXml;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem menuRecentFile;
        private System.Windows.Forms.ToolStripMenuItem xToolStripMenuItem;
        internal System.Windows.Forms.CheckBox ChkGenCmdLine;

    }
}

