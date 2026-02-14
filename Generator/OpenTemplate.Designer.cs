namespace Generator
{
    partial class OpenTemplate
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
            MetadataPathBox = new TextBox();
            TemplatePathBox = new TextBox();
            ButtonOk = new Button();
            ButtonCancel = new Button();
            TemplateBrowseButton = new Button();
            OpenDialog = new OpenFileDialog();
            MetadataBrowseButton = new Button();
            MetadataGroupBox = new GroupBox();
            TemplateGroupBox = new GroupBox();
            CsvGroupBox = new GroupBox();
            button1 = new Button();
            CsvPathBox = new TextBox();
            MetadataGroupBox.SuspendLayout();
            TemplateGroupBox.SuspendLayout();
            CsvGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // MetadataPathBox
            // 
            MetadataPathBox.Location = new Point(6, 21);
            MetadataPathBox.Name = "MetadataPathBox";
            MetadataPathBox.Size = new Size(320, 23);
            MetadataPathBox.TabIndex = 0;
            MetadataPathBox.TextChanged += TextBox_TextChanged;
            // 
            // TemplatePathBox
            // 
            TemplatePathBox.Anchor = AnchorStyles.None;
            TemplatePathBox.Location = new Point(9, 22);
            TemplatePathBox.Name = "TemplatePathBox";
            TemplatePathBox.Size = new Size(320, 23);
            TemplatePathBox.TabIndex = 2;
            TemplatePathBox.TextChanged += TextBox_TextChanged;
            // 
            // ButtonOk
            // 
            ButtonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ButtonOk.DialogResult = DialogResult.OK;
            ButtonOk.Enabled = false;
            ButtonOk.Location = new Point(140, 203);
            ButtonOk.Name = "ButtonOk";
            ButtonOk.Size = new Size(75, 23);
            ButtonOk.TabIndex = 4;
            ButtonOk.Text = "OK";
            ButtonOk.UseVisualStyleBackColor = true;
            ButtonOk.Click += ButtonOk_Click;
            // 
            // ButtonCancel
            // 
            ButtonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonCancel.DialogResult = DialogResult.Cancel;
            ButtonCancel.Location = new Point(224, 203);
            ButtonCancel.Name = "ButtonCancel";
            ButtonCancel.Size = new Size(75, 23);
            ButtonCancel.TabIndex = 5;
            ButtonCancel.Text = "Cancel";
            ButtonCancel.UseVisualStyleBackColor = true;
            ButtonCancel.Click += ButtonCancel_Click;
            // 
            // TemplateBrowseButton
            // 
            TemplateBrowseButton.Anchor = AnchorStyles.None;
            TemplateBrowseButton.Location = new Point(332, 21);
            TemplateBrowseButton.Name = "TemplateBrowseButton";
            TemplateBrowseButton.Size = new Size(75, 23);
            TemplateBrowseButton.TabIndex = 3;
            TemplateBrowseButton.Text = "Browse";
            TemplateBrowseButton.UseVisualStyleBackColor = true;
            TemplateBrowseButton.Click += TemplateBrowseButton_Click;
            // 
            // OpenDialog
            // 
            OpenDialog.DefaultExt = "json";
            OpenDialog.FileName = "openFileDialog";
            OpenDialog.Filter = "Metadata files (*.json)|*.json|All files (*.*)|*.*";
            // 
            // MetadataBrowseButton
            // 
            MetadataBrowseButton.Location = new Point(329, 21);
            MetadataBrowseButton.Name = "MetadataBrowseButton";
            MetadataBrowseButton.Size = new Size(75, 23);
            MetadataBrowseButton.TabIndex = 1;
            MetadataBrowseButton.Text = "Browse";
            MetadataBrowseButton.UseVisualStyleBackColor = true;
            MetadataBrowseButton.Click += MetadataBrowseButton_Click;
            // 
            // MetadataGroupBox
            // 
            MetadataGroupBox.Controls.Add(MetadataPathBox);
            MetadataGroupBox.Controls.Add(MetadataBrowseButton);
            MetadataGroupBox.Location = new Point(18, 12);
            MetadataGroupBox.Name = "MetadataGroupBox";
            MetadataGroupBox.Size = new Size(413, 57);
            MetadataGroupBox.TabIndex = 6;
            MetadataGroupBox.TabStop = false;
            MetadataGroupBox.Text = "Файл с инструкциями (*.json)";
            MetadataGroupBox.Enter += MetadataGroupBox_Enter;
            // 
            // TemplateGroupBox
            // 
            TemplateGroupBox.Controls.Add(TemplatePathBox);
            TemplateGroupBox.Controls.Add(TemplateBrowseButton);
            TemplateGroupBox.Location = new Point(15, 75);
            TemplateGroupBox.Name = "TemplateGroupBox";
            TemplateGroupBox.Size = new Size(413, 63);
            TemplateGroupBox.TabIndex = 7;
            TemplateGroupBox.TabStop = false;
            TemplateGroupBox.Text = "Документ для генерации (*.dotx)";
            // 
            // CsvGroupBox
            // 
            CsvGroupBox.Controls.Add(button1);
            CsvGroupBox.Controls.Add(CsvPathBox);
            CsvGroupBox.Location = new Point(18, 144);
            CsvGroupBox.Name = "CsvGroupBox";
            CsvGroupBox.Size = new Size(410, 55);
            CsvGroupBox.TabIndex = 8;
            CsvGroupBox.TabStop = false;
            CsvGroupBox.Text = "Таблица с данными (*.csv)";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(329, 21);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CsvPathBox
            // 
            CsvPathBox.Anchor = AnchorStyles.None;
            CsvPathBox.Location = new Point(6, 22);
            CsvPathBox.Name = "CsvPathBox";
            CsvPathBox.Size = new Size(320, 23);
            CsvPathBox.TabIndex = 4;
            // 
            // OpenTemplate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 238);
            Controls.Add(CsvGroupBox);
            Controls.Add(TemplateGroupBox);
            Controls.Add(MetadataGroupBox);
            Controls.Add(ButtonCancel);
            Controls.Add(ButtonOk);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = Properties.Resources.Icon;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OpenTemplate";
            Text = "Open";
            Load += OpenTemplate_Load;
            MetadataGroupBox.ResumeLayout(false);
            MetadataGroupBox.PerformLayout();
            TemplateGroupBox.ResumeLayout(false);
            TemplateGroupBox.PerformLayout();
            CsvGroupBox.ResumeLayout(false);
            CsvGroupBox.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private TextBox MetadataPathBox;
        private TextBox TemplatePathBox;
        private Button ButtonOk;
        private Button ButtonCancel;
        private Button TemplateBrowseButton;
        private Button MetadataBrowseButton;
        private OpenFileDialog OpenDialog;
        private GroupBox MetadataGroupBox;
        private GroupBox TemplateGroupBox;
        private GroupBox CsvGroupBox;
        private Button button1;
        private TextBox CsvPathBox;
    }
}