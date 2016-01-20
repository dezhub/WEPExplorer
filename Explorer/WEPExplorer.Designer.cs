namespace Explore
{
    partial class WEPExplorer
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
            System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
            PresentationControls.CheckBoxProperties checkBoxProperties1 = new PresentationControls.CheckBoxProperties();
            PresentationControls.CheckBoxProperties checkBoxProperties2 = new PresentationControls.CheckBoxProperties();
            PresentationControls.CheckBoxProperties checkBoxProperties3 = new PresentationControls.CheckBoxProperties();
            PresentationControls.CheckBoxProperties checkBoxProperties4 = new PresentationControls.CheckBoxProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WEPExplorer));
            this.gbProviderFilters = new System.Windows.Forms.GroupBox();
            this.cbchkTasks = new PresentationControls.CheckBoxComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnProvFilterApply = new System.Windows.Forms.Button();
            this.txtProviderFilterText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbchkOpcodes = new PresentationControls.CheckBoxComboBox();
            this.cbchkLevels = new PresentationControls.CheckBoxComboBox();
            this.cbchkChannels = new PresentationControls.CheckBoxComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbProviderKeywords = new System.Windows.Forms.GroupBox();
            this.lvProviderKeywords = new System.Windows.Forms.ListView();
            this.lvcKeywordsValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcKeywordsName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcKeywordsMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtProviderNameFilter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lvProviders = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbProviderMetadata = new System.Windows.Forms.GroupBox();
            this.lvProviderMetadata = new System.Windows.Forms.ListView();
            this.lvcProvMetadataId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcProvMetadataLevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcProvMetadataOpcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcProvMetadataTask = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcProvMetadataKeyword = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcProvMetadataChannel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcProvMetadataMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvcProvMetadataFields = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctxmenuProvMetadata = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxmenuitemProvMetaInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmenuProviders = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainFileClearCache = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMainHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxmenuProvKeywords = new System.Windows.Forms.ContextMenuStrip(this.components);
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.gbProviderFilters.SuspendLayout();
            this.gbProviderKeywords.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbProviderMetadata.SuspendLayout();
            this.ctxmenuProvMetadata.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(132, 6);
            // 
            // gbProviderFilters
            // 
            this.gbProviderFilters.Controls.Add(this.cbchkTasks);
            this.gbProviderFilters.Controls.Add(this.label6);
            this.gbProviderFilters.Controls.Add(this.btnProvFilterApply);
            this.gbProviderFilters.Controls.Add(this.txtProviderFilterText);
            this.gbProviderFilters.Controls.Add(this.label5);
            this.gbProviderFilters.Controls.Add(this.cbchkOpcodes);
            this.gbProviderFilters.Controls.Add(this.cbchkLevels);
            this.gbProviderFilters.Controls.Add(this.cbchkChannels);
            this.gbProviderFilters.Controls.Add(this.label3);
            this.gbProviderFilters.Controls.Add(this.label2);
            this.gbProviderFilters.Controls.Add(this.label1);
            this.gbProviderFilters.Location = new System.Drawing.Point(7, 209);
            this.gbProviderFilters.Name = "gbProviderFilters";
            this.gbProviderFilters.Size = new System.Drawing.Size(460, 189);
            this.gbProviderFilters.TabIndex = 7;
            this.gbProviderFilters.TabStop = false;
            this.gbProviderFilters.Text = "Provider filters";
            // 
            // cbchkTasks
            // 
            this.cbchkTasks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            checkBoxProperties1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbchkTasks.CheckBoxProperties = checkBoxProperties1;
            this.cbchkTasks.DisplayMemberSingleItem = "";
            this.cbchkTasks.FormattingEnabled = true;
            this.cbchkTasks.Location = new System.Drawing.Point(83, 106);
            this.cbchkTasks.Name = "cbchkTasks";
            this.cbchkTasks.Size = new System.Drawing.Size(371, 21);
            this.cbchkTasks.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tasks:";
            // 
            // btnProvFilterApply
            // 
            this.btnProvFilterApply.Location = new System.Drawing.Point(83, 160);
            this.btnProvFilterApply.Name = "btnProvFilterApply";
            this.btnProvFilterApply.Size = new System.Drawing.Size(129, 23);
            this.btnProvFilterApply.TabIndex = 17;
            this.btnProvFilterApply.Text = "&Apply";
            this.btnProvFilterApply.UseVisualStyleBackColor = true;
            this.btnProvFilterApply.Click += new System.EventHandler(this.btnProvFilterApply_Click);
            // 
            // txtProviderFilterText
            // 
            this.txtProviderFilterText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProviderFilterText.Location = new System.Drawing.Point(83, 134);
            this.txtProviderFilterText.Name = "txtProviderFilterText";
            this.txtProviderFilterText.Size = new System.Drawing.Size(371, 20);
            this.txtProviderFilterText.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Message has:";
            // 
            // cbchkOpcodes
            // 
            this.cbchkOpcodes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            checkBoxProperties2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbchkOpcodes.CheckBoxProperties = checkBoxProperties2;
            this.cbchkOpcodes.DisplayMemberSingleItem = "";
            this.cbchkOpcodes.FormattingEnabled = true;
            this.cbchkOpcodes.Location = new System.Drawing.Point(83, 79);
            this.cbchkOpcodes.Name = "cbchkOpcodes";
            this.cbchkOpcodes.Size = new System.Drawing.Size(371, 21);
            this.cbchkOpcodes.TabIndex = 14;
            // 
            // cbchkLevels
            // 
            this.cbchkLevels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            checkBoxProperties3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbchkLevels.CheckBoxProperties = checkBoxProperties3;
            this.cbchkLevels.DisplayMemberSingleItem = "";
            this.cbchkLevels.FormattingEnabled = true;
            this.cbchkLevels.Location = new System.Drawing.Point(83, 52);
            this.cbchkLevels.Name = "cbchkLevels";
            this.cbchkLevels.Size = new System.Drawing.Size(371, 21);
            this.cbchkLevels.TabIndex = 13;
            // 
            // cbchkChannels
            // 
            this.cbchkChannels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            checkBoxProperties4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cbchkChannels.CheckBoxProperties = checkBoxProperties4;
            this.cbchkChannels.DisplayMemberSingleItem = "";
            this.cbchkChannels.FormattingEnabled = true;
            this.cbchkChannels.Location = new System.Drawing.Point(83, 23);
            this.cbchkChannels.Name = "cbchkChannels";
            this.cbchkChannels.Size = new System.Drawing.Size(371, 21);
            this.cbchkChannels.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Opcodes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Levels:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Channels:";
            // 
            // gbProviderKeywords
            // 
            this.gbProviderKeywords.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProviderKeywords.Controls.Add(this.lvProviderKeywords);
            this.gbProviderKeywords.Location = new System.Drawing.Point(470, 209);
            this.gbProviderKeywords.Name = "gbProviderKeywords";
            this.gbProviderKeywords.Size = new System.Drawing.Size(390, 189);
            this.gbProviderKeywords.TabIndex = 8;
            this.gbProviderKeywords.TabStop = false;
            this.gbProviderKeywords.Text = "Keywords";
            // 
            // lvProviderKeywords
            // 
            this.lvProviderKeywords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvcKeywordsValue,
            this.lvcKeywordsName,
            this.lvcKeywordsMessage});
            this.lvProviderKeywords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProviderKeywords.FullRowSelect = true;
            this.lvProviderKeywords.Location = new System.Drawing.Point(3, 16);
            this.lvProviderKeywords.MultiSelect = false;
            this.lvProviderKeywords.Name = "lvProviderKeywords";
            this.lvProviderKeywords.Size = new System.Drawing.Size(384, 170);
            this.lvProviderKeywords.TabIndex = 7;
            this.lvProviderKeywords.UseCompatibleStateImageBehavior = false;
            this.lvProviderKeywords.View = System.Windows.Forms.View.Details;
            // 
            // lvcKeywordsValue
            // 
            this.lvcKeywordsValue.Text = "Value";
            // 
            // lvcKeywordsName
            // 
            this.lvcKeywordsName.Text = "Name";
            this.lvcKeywordsName.Width = 134;
            // 
            // lvcKeywordsMessage
            // 
            this.lvcKeywordsMessage.Text = "Message";
            this.lvcKeywordsMessage.Width = 148;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtProviderNameFilter);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lvProviders);
            this.groupBox3.Location = new System.Drawing.Point(7, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(859, 191);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Providers";
            // 
            // txtProviderNameFilter
            // 
            this.txtProviderNameFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProviderNameFilter.Location = new System.Drawing.Point(87, 19);
            this.txtProviderNameFilter.Name = "txtProviderNameFilter";
            this.txtProviderNameFilter.Size = new System.Drawing.Size(766, 20);
            this.txtProviderNameFilter.TabIndex = 10;
            this.txtProviderNameFilter.TextChanged += new System.EventHandler(this.txtProviderNameFilter_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Provider name:";
            // 
            // lvProviders
            // 
            this.lvProviders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvProviders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvProviders.FullRowSelect = true;
            this.lvProviders.Location = new System.Drawing.Point(3, 45);
            this.lvProviders.MultiSelect = false;
            this.lvProviders.Name = "lvProviders";
            this.lvProviders.Size = new System.Drawing.Size(850, 140);
            this.lvProviders.TabIndex = 8;
            this.lvProviders.UseCompatibleStateImageBehavior = false;
            this.lvProviders.View = System.Windows.Forms.View.Details;
            this.lvProviders.DoubleClick += new System.EventHandler(this.lvProviders_DoubleClick);
            this.lvProviders.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lvProviders_KeyPress);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "GUID";
            this.columnHeader1.Width = 279;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 381;
            // 
            // gbProviderMetadata
            // 
            this.gbProviderMetadata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbProviderMetadata.Controls.Add(this.lvProviderMetadata);
            this.gbProviderMetadata.Location = new System.Drawing.Point(7, 404);
            this.gbProviderMetadata.Name = "gbProviderMetadata";
            this.gbProviderMetadata.Size = new System.Drawing.Size(853, 324);
            this.gbProviderMetadata.TabIndex = 10;
            this.gbProviderMetadata.TabStop = false;
            this.gbProviderMetadata.Text = "Provider metadata";
            // 
            // lvProviderMetadata
            // 
            this.lvProviderMetadata.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvcProvMetadataId,
            this.lvcProvMetadataLevel,
            this.lvcProvMetadataOpcode,
            this.lvcProvMetadataTask,
            this.lvcProvMetadataKeyword,
            this.lvcProvMetadataChannel,
            this.lvcProvMetadataMessage,
            this.lvcProvMetadataFields});
            this.lvProviderMetadata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProviderMetadata.FullRowSelect = true;
            this.lvProviderMetadata.Location = new System.Drawing.Point(3, 16);
            this.lvProviderMetadata.Name = "lvProviderMetadata";
            this.lvProviderMetadata.Size = new System.Drawing.Size(847, 305);
            this.lvProviderMetadata.TabIndex = 7;
            this.lvProviderMetadata.UseCompatibleStateImageBehavior = false;
            this.lvProviderMetadata.View = System.Windows.Forms.View.Details;
            // 
            // lvcProvMetadataId
            // 
            this.lvcProvMetadataId.Text = "Id";
            // 
            // lvcProvMetadataLevel
            // 
            this.lvcProvMetadataLevel.Text = "Level";
            this.lvcProvMetadataLevel.Width = 106;
            // 
            // lvcProvMetadataOpcode
            // 
            this.lvcProvMetadataOpcode.Text = "Opcode";
            this.lvcProvMetadataOpcode.Width = 115;
            // 
            // lvcProvMetadataTask
            // 
            this.lvcProvMetadataTask.Text = "Task";
            this.lvcProvMetadataTask.Width = 164;
            // 
            // lvcProvMetadataKeyword
            // 
            this.lvcProvMetadataKeyword.Text = "Keyword";
            // 
            // lvcProvMetadataChannel
            // 
            this.lvcProvMetadataChannel.Text = "Channel";
            this.lvcProvMetadataChannel.Width = 205;
            // 
            // lvcProvMetadataMessage
            // 
            this.lvcProvMetadataMessage.Text = "Message";
            this.lvcProvMetadataMessage.Width = 300;
            // 
            // lvcProvMetadataFields
            // 
            this.lvcProvMetadataFields.Text = "Fields";
            // 
            // ctxmenuProvMetadata
            // 
            this.ctxmenuProvMetadata.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxmenuitemProvMetaInfo});
            this.ctxmenuProvMetadata.Name = "ctxmenuProvMetadata";
            this.ctxmenuProvMetadata.Size = new System.Drawing.Size(175, 26);
            // 
            // ctxmenuitemProvMetaInfo
            // 
            this.ctxmenuitemProvMetaInfo.Name = "ctxmenuitemProvMetaInfo";
            this.ctxmenuitemProvMetaInfo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.ctxmenuitemProvMetaInfo.Size = new System.Drawing.Size(174, 22);
            this.ctxmenuitemProvMetaInfo.Text = "Information";
            this.ctxmenuitemProvMetaInfo.Click += new System.EventHandler(this.ctxmenuitemProvMetaInfo_Click);
            // 
            // ctxmenuProviders
            // 
            this.ctxmenuProviders.Name = "ctxmenuProvMetadata";
            this.ctxmenuProviders.Size = new System.Drawing.Size(61, 4);
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(865, 24);
            this.menuMain.TabIndex = 11;
            this.menuMain.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMainFileClearCache,
            toolStripMenuItem1,
            this.menuMainFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuMainFileClearCache
            // 
            this.menuMainFileClearCache.Name = "menuMainFileClearCache";
            this.menuMainFileClearCache.Size = new System.Drawing.Size(135, 22);
            this.menuMainFileClearCache.Text = "Clear cache";
            this.menuMainFileClearCache.Click += new System.EventHandler(this.menuMainFileClearCache_Click);
            // 
            // menuMainFileExit
            // 
            this.menuMainFileExit.Name = "menuMainFileExit";
            this.menuMainFileExit.Size = new System.Drawing.Size(135, 22);
            this.menuMainFileExit.Text = "E&xit";
            this.menuMainFileExit.Click += new System.EventHandler(this.menuMainFileExit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMainHelpAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // menuMainHelpAbout
            // 
            this.menuMainHelpAbout.Name = "menuMainHelpAbout";
            this.menuMainHelpAbout.Size = new System.Drawing.Size(107, 22);
            this.menuMainHelpAbout.Text = "&About";
            this.menuMainHelpAbout.Click += new System.EventHandler(this.menuMainHelpAbout_Click);
            // 
            // ctxmenuProvKeywords
            // 
            this.ctxmenuProvKeywords.Name = "ctxmenuProvKeywords";
            this.ctxmenuProvKeywords.Size = new System.Drawing.Size(61, 4);
            // 
            // WEPExplorer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 729);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.gbProviderMetadata);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbProviderKeywords);
            this.Controls.Add(this.gbProviderFilters);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WEPExplorer";
            this.Text = "Windows Events Providers Explorer";
            this.Load += new System.EventHandler(this.WEPExplorerForm_Load);
            this.gbProviderFilters.ResumeLayout(false);
            this.gbProviderFilters.PerformLayout();
            this.gbProviderKeywords.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbProviderMetadata.ResumeLayout(false);
            this.ctxmenuProvMetadata.ResumeLayout(false);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProviderFilters;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbProviderKeywords;
        private System.Windows.Forms.ListView lvProviderKeywords;
        private PresentationControls.CheckBoxComboBox cbchkOpcodes;
        private PresentationControls.CheckBoxComboBox cbchkLevels;
        private PresentationControls.CheckBoxComboBox cbchkChannels;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lvProviders;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox txtProviderNameFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbProviderMetadata;
        private System.Windows.Forms.ListView lvProviderMetadata;
        private System.Windows.Forms.ColumnHeader lvcProvMetadataId;
        private System.Windows.Forms.ColumnHeader lvcProvMetadataLevel;
        private System.Windows.Forms.ColumnHeader lvcProvMetadataOpcode;
        private System.Windows.Forms.ColumnHeader lvcProvMetadataTask;
        private System.Windows.Forms.ColumnHeader lvcProvMetadataChannel;
        private System.Windows.Forms.ColumnHeader lvcProvMetadataMessage;
        private System.Windows.Forms.ColumnHeader lvcKeywordsValue;
        private System.Windows.Forms.ColumnHeader lvcKeywordsName;
        private System.Windows.Forms.ColumnHeader lvcKeywordsMessage;
        private System.Windows.Forms.TextBox txtProviderFilterText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader lvcProvMetadataKeyword;
        private System.Windows.Forms.Button btnProvFilterApply;
        private System.Windows.Forms.ContextMenuStrip ctxmenuProvMetadata;
        private System.Windows.Forms.ContextMenuStrip ctxmenuProviders;
        private PresentationControls.CheckBoxComboBox cbchkTasks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem ctxmenuitemProvMetaInfo;
        private System.Windows.Forms.ColumnHeader lvcProvMetadataFields;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuMainFileExit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuMainHelpAbout;
        private System.Windows.Forms.ContextMenuStrip ctxmenuProvKeywords;
        private System.Windows.Forms.ToolStripMenuItem menuMainFileClearCache;
    }
}

