namespace Generator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            MainSplit = new SplitContainer();
            MenuStrip = new MenuStrip();
            FileTSMI = new ToolStripMenuItem();
            OpenTSMI = new ToolStripMenuItem();
            SaveTSMI = new ToolStripMenuItem();
            SaveAsTSMI = new ToolStripMenuItem();
            QuitTSMI = new ToolStripMenuItem();
            HelpTSMI = new ToolStripMenuItem();
            thereIsNoHelpToolStripMenuItem = new ToolStripMenuItem();
            noOneWillHearYourCryToolStripMenuItem = new ToolStripMenuItem();
            theSufferingWillBeEternalToolStripMenuItem = new ToolStripMenuItem();
            enjoyToolStripMenuItem = new ToolStripMenuItem();
            InputTreeSplit = new SplitContainer();
            ToolTipSplit = new SplitContainer();
            ToolTipLabel = new Label();
            TreeBrowserSplit = new SplitContainer();
            Fields = new TreeView();
            Preview = new WebBrowser();
            SaveFileDialog = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)MainSplit).BeginInit();
            MainSplit.Panel1.SuspendLayout();
            MainSplit.Panel2.SuspendLayout();
            MainSplit.SuspendLayout();
            MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InputTreeSplit).BeginInit();
            InputTreeSplit.Panel1.SuspendLayout();
            InputTreeSplit.Panel2.SuspendLayout();
            InputTreeSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ToolTipSplit).BeginInit();
            ToolTipSplit.Panel2.SuspendLayout();
            ToolTipSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TreeBrowserSplit).BeginInit();
            TreeBrowserSplit.Panel1.SuspendLayout();
            TreeBrowserSplit.Panel2.SuspendLayout();
            TreeBrowserSplit.SuspendLayout();
            SuspendLayout();
            // 
            // MainSplit
            // 
            MainSplit.BackColor = SystemColors.Control;
            MainSplit.Cursor = Cursors.HSplit;
            MainSplit.Dock = DockStyle.Fill;
            MainSplit.FixedPanel = FixedPanel.Panel1;
            MainSplit.IsSplitterFixed = true;
            MainSplit.Location = new Point(0, 0);
            MainSplit.Name = "MainSplit";
            MainSplit.Orientation = Orientation.Horizontal;
            // 
            // MainSplit.Panel1
            // 
            MainSplit.Panel1.Controls.Add(MenuStrip);
            // 
            // MainSplit.Panel2
            // 
            MainSplit.Panel2.Controls.Add(InputTreeSplit);
            MainSplit.Size = new Size(1666, 758);
            MainSplit.SplitterDistance = 25;
            MainSplit.TabIndex = 1;
            // 
            // MenuStrip
            // 
            MenuStrip.Items.AddRange(new ToolStripItem[] { FileTSMI, HelpTSMI });
            MenuStrip.Location = new Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new Size(1666, 24);
            MenuStrip.TabIndex = 0;
            MenuStrip.Text = "menuStrip1";
            // 
            // FileTSMI
            // 
            FileTSMI.DropDownItems.AddRange(new ToolStripItem[] { OpenTSMI, SaveTSMI, SaveAsTSMI, QuitTSMI });
            FileTSMI.Name = "FileTSMI";
            FileTSMI.Size = new Size(37, 20);
            FileTSMI.Text = "File";
            // 
            // OpenTSMI
            // 
            OpenTSMI.Name = "OpenTSMI";
            OpenTSMI.ShortcutKeys = Keys.Control | Keys.O;
            OpenTSMI.Size = new Size(190, 22);
            OpenTSMI.Text = "Оpen";
            OpenTSMI.Click += OpenTSMI_Click;
            // 
            // SaveTSMI
            // 
            SaveTSMI.Name = "SaveTSMI";
            SaveTSMI.ShortcutKeys = Keys.Control | Keys.S;
            SaveTSMI.Size = new Size(190, 22);
            SaveTSMI.Text = "Save";
            SaveTSMI.Click += SaveTSMI_Click;
            // 
            // SaveAsTSMI
            // 
            SaveAsTSMI.Name = "SaveAsTSMI";
            SaveAsTSMI.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            SaveAsTSMI.Size = new Size(190, 22);
            SaveAsTSMI.Text = "Save as";
            SaveAsTSMI.Click += SaveAsTSMI_Click;
            // 
            // QuitTSMI
            // 
            QuitTSMI.Name = "QuitTSMI";
            QuitTSMI.ShortcutKeys = Keys.Alt | Keys.F4;
            QuitTSMI.ShowShortcutKeys = false;
            QuitTSMI.Size = new Size(190, 22);
            QuitTSMI.Text = "Quit";
            QuitTSMI.Click += QuitTSMI_Click;
            // 
            // HelpTSMI
            // 
            HelpTSMI.DropDownItems.AddRange(new ToolStripItem[] { thereIsNoHelpToolStripMenuItem, noOneWillHearYourCryToolStripMenuItem, theSufferingWillBeEternalToolStripMenuItem, enjoyToolStripMenuItem });
            HelpTSMI.Name = "HelpTSMI";
            HelpTSMI.Size = new Size(44, 20);
            HelpTSMI.Text = "Help";
            // 
            // thereIsNoHelpToolStripMenuItem
            // 
            thereIsNoHelpToolStripMenuItem.Name = "thereIsNoHelpToolStripMenuItem";
            thereIsNoHelpToolStripMenuItem.Size = new Size(219, 22);
            thereIsNoHelpToolStripMenuItem.Text = "There is no help";
            // 
            // noOneWillHearYourCryToolStripMenuItem
            // 
            noOneWillHearYourCryToolStripMenuItem.Name = "noOneWillHearYourCryToolStripMenuItem";
            noOneWillHearYourCryToolStripMenuItem.Size = new Size(219, 22);
            noOneWillHearYourCryToolStripMenuItem.Text = "No one will hear your cry";
            // 
            // theSufferingWillBeEternalToolStripMenuItem
            // 
            theSufferingWillBeEternalToolStripMenuItem.Name = "theSufferingWillBeEternalToolStripMenuItem";
            theSufferingWillBeEternalToolStripMenuItem.Size = new Size(219, 22);
            theSufferingWillBeEternalToolStripMenuItem.Text = "The suffering will be eternal";
            // 
            // enjoyToolStripMenuItem
            // 
            enjoyToolStripMenuItem.Name = "enjoyToolStripMenuItem";
            enjoyToolStripMenuItem.Size = new Size(219, 22);
            enjoyToolStripMenuItem.Text = "Enjoy)";
            // 
            // InputTreeSplit
            // 
            InputTreeSplit.BorderStyle = BorderStyle.Fixed3D;
            InputTreeSplit.Cursor = Cursors.VSplit;
            InputTreeSplit.Dock = DockStyle.Fill;
            InputTreeSplit.Location = new Point(0, 0);
            InputTreeSplit.Name = "InputTreeSplit";
            // 
            // InputTreeSplit.Panel1
            // 
            InputTreeSplit.Panel1.Controls.Add(ToolTipSplit);
            InputTreeSplit.Panel1.Cursor = Cursors.Default;
            // 
            // InputTreeSplit.Panel2
            // 
            InputTreeSplit.Panel2.Controls.Add(TreeBrowserSplit);
            InputTreeSplit.Size = new Size(1666, 729);
            InputTreeSplit.SplitterDistance = 608;
            InputTreeSplit.TabIndex = 0;
            // 
            // ToolTipSplit
            // 
            ToolTipSplit.BorderStyle = BorderStyle.Fixed3D;
            ToolTipSplit.Cursor = Cursors.HSplit;
            ToolTipSplit.Dock = DockStyle.Fill;
            ToolTipSplit.Location = new Point(0, 0);
            ToolTipSplit.Name = "ToolTipSplit";
            ToolTipSplit.Orientation = Orientation.Horizontal;
            // 
            // ToolTipSplit.Panel1
            // 
            ToolTipSplit.Panel1.Cursor = Cursors.Default;
            // 
            // ToolTipSplit.Panel2
            // 
            ToolTipSplit.Panel2.Controls.Add(ToolTipLabel);
            ToolTipSplit.Panel2.Cursor = Cursors.Default;
            ToolTipSplit.Size = new Size(608, 729);
            ToolTipSplit.SplitterDistance = 499;
            ToolTipSplit.TabIndex = 0;
            // 
            // ToolTipLabel
            // 
            ToolTipLabel.Dock = DockStyle.Fill;
            ToolTipLabel.Location = new Point(0, 0);
            ToolTipLabel.Name = "ToolTipLabel";
            ToolTipLabel.Size = new Size(604, 222);
            ToolTipLabel.TabIndex = 0;
            ToolTipLabel.Text = "ToolTip";
            ToolTipLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TreeBrowserSplit
            // 
            TreeBrowserSplit.BorderStyle = BorderStyle.Fixed3D;
            TreeBrowserSplit.Cursor = Cursors.VSplit;
            TreeBrowserSplit.Dock = DockStyle.Fill;
            TreeBrowserSplit.Location = new Point(0, 0);
            TreeBrowserSplit.Name = "TreeBrowserSplit";
            // 
            // TreeBrowserSplit.Panel1
            // 
            TreeBrowserSplit.Panel1.Controls.Add(Fields);
            TreeBrowserSplit.Panel1.Cursor = Cursors.Default;
            // 
            // TreeBrowserSplit.Panel2
            // 
            TreeBrowserSplit.Panel2.Controls.Add(Preview);
            TreeBrowserSplit.Panel2.Cursor = Cursors.Default;
            TreeBrowserSplit.Size = new Size(1054, 729);
            TreeBrowserSplit.SplitterDistance = 366;
            TreeBrowserSplit.TabIndex = 0;
            // 
            // Fields
            // 
            Fields.BackColor = SystemColors.Control;
            Fields.Dock = DockStyle.Fill;
            Fields.HideSelection = false;
            Fields.Location = new Point(0, 0);
            Fields.Name = "Fields";
            Fields.Size = new Size(362, 725);
            Fields.TabIndex = 1;
            Fields.AfterSelect += TreeView_AfterSelect;
            // 
            // Preview
            // 
            Preview.AllowWebBrowserDrop = false;
            Preview.Dock = DockStyle.Fill;
            Preview.IsWebBrowserContextMenuEnabled = false;
            Preview.Location = new Point(0, 0);
            Preview.Name = "Preview";
            Preview.Size = new Size(680, 725);
            Preview.TabIndex = 2;
            Preview.DocumentCompleted += Preview_DocumentCompleted;
            // 
            // SaveFileDialog
            // 
            SaveFileDialog.Filter = "Word document files (*.docx)|*.docx|All files (*.*)|*.*";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1666, 758);
            Controls.Add(MainSplit);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = Properties.Resources.Icon;
            MainMenuStrip = MenuStrip;
            Name = "MainForm";
            Text = "Generator";
            FormClosed += MainForm_FormClosed;
            Load += MainForm_Load;
            MainSplit.Panel1.ResumeLayout(false);
            MainSplit.Panel1.PerformLayout();
            MainSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainSplit).EndInit();
            MainSplit.ResumeLayout(false);
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            InputTreeSplit.Panel1.ResumeLayout(false);
            InputTreeSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)InputTreeSplit).EndInit();
            InputTreeSplit.ResumeLayout(false);
            ToolTipSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ToolTipSplit).EndInit();
            ToolTipSplit.ResumeLayout(false);
            TreeBrowserSplit.Panel1.ResumeLayout(false);
            TreeBrowserSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TreeBrowserSplit).EndInit();
            TreeBrowserSplit.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private SplitContainer MainSplit;
        private SplitContainer InputTreeSplit;
        private SplitContainer TreeBrowserSplit;
        private TreeView Fields;
        private WebBrowser Preview;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem FileTSMI;
        private ToolStripMenuItem OpenTSMI;
        private ToolStripMenuItem SaveTSMI;
        private ToolStripMenuItem SaveAsTSMI;
        private ToolStripMenuItem QuitTSMI;
        private ToolStripMenuItem HelpTSMI;
        private SaveFileDialog SaveFileDialog;
        private SplitContainer ToolTipSplit;
        private Label ToolTipLabel;
        private ToolStripMenuItem thereIsNoHelpToolStripMenuItem;
        private ToolStripMenuItem noOneWillHearYourCryToolStripMenuItem;
        private ToolStripMenuItem theSufferingWillBeEternalToolStripMenuItem;
        private ToolStripMenuItem enjoyToolStripMenuItem;
    }
}

