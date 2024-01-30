using System;
using System.Windows.Forms;

namespace Editor
{
    partial class Editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Font = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.fontColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.lowercaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uppercaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.backgroundColourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbNewDoc = new System.Windows.Forms.ToolStripButton();
            this.tbOpen = new System.Windows.Forms.ToolStripButton();
            this.tbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tbFont = new System.Windows.Forms.ToolStripButton();
            this.tbFontColour = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tbBold = new System.Windows.Forms.ToolStripButton();
            this.tbItalic = new System.Windows.Forms.ToolStripButton();
            this.tbUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.tbUpperCase = new System.Windows.Forms.ToolStripButton();
            this.tbLowerCase = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.ComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.fontDialog2 = new System.Windows.Forms.FontDialog();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.emote1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.emote2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
            this.emote3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
            this.emote4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
            this.emote5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
            this.emote6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
            this.emote7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
            this.emote8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
            this.emote9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator22 = new System.Windows.Forms.ToolStripSeparator();
            this.emote10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator23 = new System.Windows.Forms.ToolStripSeparator();
            this.emote11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator24 = new System.Windows.Forms.ToolStripSeparator();
            this.emote12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator25 = new System.Windows.Forms.ToolStripSeparator();
            this.emote13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator26 = new System.Windows.Forms.ToolStripSeparator();
            this.emote14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator27 = new System.Windows.Forms.ToolStripSeparator();
            this.emote15 = new System.Windows.Forms.ToolStripButton();
            this.EditorRTB = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Edit,
            this.Font,
            this.Insert,
            this.AboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.ToolStripSeparator5,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(37, 20);
            this.File.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // ToolStripSeparator5
            // 
            this.ToolStripSeparator5.Name = "ToolStripSeparator5";
            this.ToolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // Edit
            // 
            this.Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator2,
            this.selectAllToolStripMenuItem,
            this.toolStripSeparator3,
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(39, 20);
            this.Edit.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(119, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(119, 6);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // Font
            // 
            this.Font.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFontToolStripMenuItem,
            this.toolStripSeparator4,
            this.fontColourToolStripMenuItem,
            this.toolStripSeparator7,
            this.boldToolStripMenuItem,
            this.italicToolStripMenuItem,
            this.underlineToolStripMenuItem,
            this.normalToolStripMenuItem,
            this.toolStripSeparator11,
            this.lowercaseToolStripMenuItem,
            this.uppercaseToolStripMenuItem,
            this.toolStripSeparator6,
            this.backgroundColourToolStripMenuItem});
            this.Font.Name = "Font";
            this.Font.Size = new System.Drawing.Size(43, 20);
            this.Font.Text = "Font";
            // 
            // selectFontToolStripMenuItem
            // 
            this.selectFontToolStripMenuItem.Name = "selectFontToolStripMenuItem";
            this.selectFontToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.selectFontToolStripMenuItem.Text = "Select Font";
            this.selectFontToolStripMenuItem.Click += new System.EventHandler(this.SelectFontToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(174, 6);
            // 
            // fontColourToolStripMenuItem
            // 
            this.fontColourToolStripMenuItem.Name = "fontColourToolStripMenuItem";
            this.fontColourToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.fontColourToolStripMenuItem.Text = "Font Colour";
            this.fontColourToolStripMenuItem.Click += new System.EventHandler(this.FontColourToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(174, 6);
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.boldToolStripMenuItem.Text = "Bold";
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.BoldToolStripMenuItem_Click);
            // 
            // italicToolStripMenuItem
            // 
            this.italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            this.italicToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.italicToolStripMenuItem.Text = "Italic";
            this.italicToolStripMenuItem.Click += new System.EventHandler(this.ItalicToolStripMenuItem_Click);
            // 
            // underlineToolStripMenuItem
            // 
            this.underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            this.underlineToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.underlineToolStripMenuItem.Text = "Underline";
            this.underlineToolStripMenuItem.Click += new System.EventHandler(this.UnderlineToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem
            // 
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.normalToolStripMenuItem.Text = "Normal";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.NormalToolStripMenuItem_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(174, 6);
            // 
            // lowercaseToolStripMenuItem
            // 
            this.lowercaseToolStripMenuItem.Name = "lowercaseToolStripMenuItem";
            this.lowercaseToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.lowercaseToolStripMenuItem.Text = "Lowercase";
            this.lowercaseToolStripMenuItem.Click += new System.EventHandler(this.LowercaseToolStripMenuItem_Click);
            // 
            // uppercaseToolStripMenuItem
            // 
            this.uppercaseToolStripMenuItem.Name = "uppercaseToolStripMenuItem";
            this.uppercaseToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.uppercaseToolStripMenuItem.Text = "Uppercase";
            this.uppercaseToolStripMenuItem.Click += new System.EventHandler(this.UppercaseToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(174, 6);
            // 
            // backgroundColourToolStripMenuItem
            // 
            this.backgroundColourToolStripMenuItem.Name = "backgroundColourToolStripMenuItem";
            this.backgroundColourToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.backgroundColourToolStripMenuItem.Text = "Background Colour";
            this.backgroundColourToolStripMenuItem.Click += new System.EventHandler(this.BackgroundColourToolStripMenuItem_Click);
            // 
            // Insert
            // 
            this.Insert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem});
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(48, 20);
            this.Insert.Text = "Insert";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.ImageToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moreInfoToolStripMenuItem});
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.AboutToolStripMenuItem.Text = "About";
            // 
            // moreInfoToolStripMenuItem
            // 
            this.moreInfoToolStripMenuItem.Name = "moreInfoToolStripMenuItem";
            this.moreInfoToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.moreInfoToolStripMenuItem.Text = "More Info";
            this.moreInfoToolStripMenuItem.Click += new System.EventHandler(this.MoreInfoToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbNewDoc,
            this.tbOpen,
            this.tbSave,
            this.toolStripSeparator8,
            this.tbFont,
            this.tbFontColour,
            this.toolStripSeparator9,
            this.tbBold,
            this.tbItalic,
            this.tbUnderline,
            this.toolStripSeparator12,
            this.tbUpperCase,
            this.tbLowerCase,
            this.toolStripSeparator13,
            this.ComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbNewDoc
            // 
            this.tbNewDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbNewDoc.Image = global::Editor.Properties.Resources.document;
            this.tbNewDoc.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbNewDoc.Name = "tbNewDoc";
            this.tbNewDoc.Size = new System.Drawing.Size(23, 22);
            this.tbNewDoc.Text = "New Document";
            this.tbNewDoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tbNewDoc.Click += new System.EventHandler(this.TbNewDoc_Click);
            // 
            // tbOpen
            // 
            this.tbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbOpen.Image = global::Editor.Properties.Resources.folder;
            this.tbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbOpen.Name = "tbOpen";
            this.tbOpen.Size = new System.Drawing.Size(23, 22);
            this.tbOpen.Text = "Open";
            this.tbOpen.Click += new System.EventHandler(this.TbOpen_Click);
            // 
            // tbSave
            // 
            this.tbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbSave.Image = global::Editor.Properties.Resources.save;
            this.tbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbSave.Name = "tbSave";
            this.tbSave.Size = new System.Drawing.Size(23, 22);
            this.tbSave.Text = "Save";
            this.tbSave.Click += new System.EventHandler(this.TbSave_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // tbFont
            // 
            this.tbFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbFont.Image = global::Editor.Properties.Resources.font;
            this.tbFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbFont.Name = "tbFont";
            this.tbFont.Size = new System.Drawing.Size(23, 22);
            this.tbFont.Text = "Font Type";
            this.tbFont.Click += new System.EventHandler(this.TbFont_Click);
            // 
            // tbFontColour
            // 
            this.tbFontColour.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbFontColour.Image = global::Editor.Properties.Resources.Fatcow_Farm_Fresh_Color_wheel;
            this.tbFontColour.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbFontColour.Name = "tbFontColour";
            this.tbFontColour.Size = new System.Drawing.Size(23, 22);
            this.tbFontColour.Text = "Font Colour";
            this.tbFontColour.Click += new System.EventHandler(this.TbFontColour_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // tbBold
            // 
            this.tbBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbBold.Image = global::Editor.Properties.Resources.Icons8_Windows_8_Editing_Bold;
            this.tbBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbBold.Name = "tbBold";
            this.tbBold.Size = new System.Drawing.Size(23, 22);
            this.tbBold.Text = "Bold";
            this.tbBold.Click += new System.EventHandler(this.TbBold_Click);
            // 
            // tbItalic
            // 
            this.tbItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbItalic.Image = global::Editor.Properties.Resources.Icons8_Windows_8_Editing_Italic;
            this.tbItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbItalic.Name = "tbItalic";
            this.tbItalic.Size = new System.Drawing.Size(23, 22);
            this.tbItalic.Text = "Italic";
            this.tbItalic.Click += new System.EventHandler(this.TbItalic_Click);
            // 
            // tbUnderline
            // 
            this.tbUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbUnderline.Image = global::Editor.Properties.Resources.font_style_underline;
            this.tbUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbUnderline.Name = "tbUnderline";
            this.tbUnderline.Size = new System.Drawing.Size(23, 22);
            this.tbUnderline.Text = "toolStripButton11";
            this.tbUnderline.ToolTipText = "Underline";
            this.tbUnderline.Click += new System.EventHandler(this.TbUnderline_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 25);
            // 
            // tbUpperCase
            // 
            this.tbUpperCase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbUpperCase.Image = global::Editor.Properties.Resources.uppercase;
            this.tbUpperCase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbUpperCase.Name = "tbUpperCase";
            this.tbUpperCase.Size = new System.Drawing.Size(23, 22);
            this.tbUpperCase.Text = "Uppercase";
            this.tbUpperCase.ToolTipText = "Font Uppercase";
            this.tbUpperCase.Click += new System.EventHandler(this.TbUpperCase_Click);
            // 
            // tbLowerCase
            // 
            this.tbLowerCase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbLowerCase.Image = global::Editor.Properties.Resources.lowercase;
            this.tbLowerCase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbLowerCase.Name = "tbLowerCase";
            this.tbLowerCase.Size = new System.Drawing.Size(23, 22);
            this.tbLowerCase.Text = "Lowercase";
            this.tbLowerCase.Click += new System.EventHandler(this.TbLowerCase_Click);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(6, 25);
            // 
            // ComboBox1
            // 
            this.ComboBox1.Items.AddRange(new object[] {
            "bizarre",
            "achieve",
            "apparently",
            "appreciate",
            "believe",
            "calendar",
            "canceled",
            "committee",
            "conscious",
            "convenience",
            "curiosity",
            "definitely",
            "disappointed",
            "embarrassing",
            "gist",
            "immediately",
            "irresistible",
            "maintenance",
            "necessary",
            "noticeable",
            "possession",
            "separate",
            "tomorrow",
            "unfortunately"});
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(121, 25);
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "happy.png");
            this.imageList1.Images.SetKeyName(1, "sad.png");
            this.imageList1.Images.SetKeyName(2, "crying.png");
            this.imageList1.Images.SetKeyName(3, "angry.png");
            this.imageList1.Images.SetKeyName(4, "bored.png");
            this.imageList1.Images.SetKeyName(5, "confused.png");
            this.imageList1.Images.SetKeyName(6, "embarrassed.png");
            this.imageList1.Images.SetKeyName(7, "ill.png");
            this.imageList1.Images.SetKeyName(8, "in-love.png");
            this.imageList1.Images.SetKeyName(9, "nerd.png");
            this.imageList1.Images.SetKeyName(10, "quiet.png");
            this.imageList1.Images.SetKeyName(11, "secret.png");
            this.imageList1.Images.SetKeyName(12, "surprised.png");
            this.imageList1.Images.SetKeyName(13, "wink.png");
            this.imageList1.Images.SetKeyName(14, "tongue-out-1.png");
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emote1,
            this.toolStripSeparator14,
            this.emote2,
            this.toolStripSeparator15,
            this.emote3,
            this.toolStripSeparator16,
            this.emote4,
            this.toolStripSeparator17,
            this.emote5,
            this.toolStripSeparator18,
            this.emote6,
            this.toolStripSeparator19,
            this.emote7,
            this.toolStripSeparator20,
            this.emote8,
            this.toolStripSeparator21,
            this.emote9,
            this.toolStripSeparator22,
            this.emote10,
            this.toolStripSeparator23,
            this.emote11,
            this.toolStripSeparator24,
            this.emote12,
            this.toolStripSeparator25,
            this.emote13,
            this.toolStripSeparator26,
            this.emote14,
            this.toolStripSeparator27,
            this.emote15});
            this.toolStrip2.Location = new System.Drawing.Point(0, 49);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(800, 25);
            this.toolStrip2.TabIndex = 7;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // emote1
            // 
            this.emote1.BackColor = System.Drawing.SystemColors.Control;
            this.emote1.CheckOnClick = true;
            this.emote1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.emote1.Image = global::Editor.Properties.Resources.happy;
            this.emote1.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.emote1.Name = "emote1";
            this.emote1.Size = new System.Drawing.Size(23, 22);
            this.emote1.Text = "Happy";
            this.emote1.Click += new System.EventHandler(this.Emote1_Click);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(6, 25);
            // 
            // emote2
            // 
            this.emote2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.emote2.Image = global::Editor.Properties.Resources.sad;
            this.emote2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emote2.Name = "emote2";
            this.emote2.Size = new System.Drawing.Size(23, 22);
            this.emote2.Text = "Sad";
            this.emote2.Click += new System.EventHandler(this.Emote2_Click);
            // 
            // toolStripSeparator15
            // 
            this.toolStripSeparator15.Name = "toolStripSeparator15";
            this.toolStripSeparator15.Size = new System.Drawing.Size(6, 25);
            // 
            // emote3
            // 
            this.emote3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.emote3.Image = global::Editor.Properties.Resources.crying;
            this.emote3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emote3.Name = "emote3";
            this.emote3.Size = new System.Drawing.Size(23, 22);
            this.emote3.Text = "Crying";
            this.emote3.Click += new System.EventHandler(this.Emote3_Click);
            // 
            // toolStripSeparator16
            // 
            this.toolStripSeparator16.Name = "toolStripSeparator16";
            this.toolStripSeparator16.Size = new System.Drawing.Size(6, 25);
            // 
            // emote4
            // 
            this.emote4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.emote4.Image = global::Editor.Properties.Resources.angry;
            this.emote4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emote4.Name = "emote4";
            this.emote4.Size = new System.Drawing.Size(23, 22);
            this.emote4.Text = "Angry";
            this.emote4.Click += new System.EventHandler(this.Emote4_Click);
            // 
            // toolStripSeparator17
            // 
            this.toolStripSeparator17.Name = "toolStripSeparator17";
            this.toolStripSeparator17.Size = new System.Drawing.Size(6, 25);
            // 
            // emote5
            // 
            this.emote5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.emote5.Image = global::Editor.Properties.Resources.bored;
            this.emote5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emote5.Name = "emote5";
            this.emote5.Size = new System.Drawing.Size(23, 22);
            this.emote5.Text = "Bored";
            this.emote5.Click += new System.EventHandler(this.Emote5_Click);
            // 
            // toolStripSeparator18
            // 
            this.toolStripSeparator18.Name = "toolStripSeparator18";
            this.toolStripSeparator18.Size = new System.Drawing.Size(6, 25);
            // 
            // emote6
            // 
            this.emote6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.emote6.Image = global::Editor.Properties.Resources.confused;
            this.emote6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emote6.Name = "emote6";
            this.emote6.Size = new System.Drawing.Size(23, 22);
            this.emote6.Text = "Confused";
            this.emote6.Click += new System.EventHandler(this.Emote6_Click);
            // 
            // toolStripSeparator19
            // 
            this.toolStripSeparator19.Name = "toolStripSeparator19";
            this.toolStripSeparator19.Size = new System.Drawing.Size(6, 25);
            // 
            // emote7
            // 
            this.emote7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.emote7.Image = global::Editor.Properties.Resources.embarrassed;
            this.emote7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emote7.Name = "emote7";
            this.emote7.Size = new System.Drawing.Size(23, 22);
            this.emote7.Text = "Embarrassed";
            this.emote7.Click += new System.EventHandler(this.Emote7_Click);
            // 
            // toolStripSeparator20
            // 
            this.toolStripSeparator20.Name = "toolStripSeparator20";
            this.toolStripSeparator20.Size = new System.Drawing.Size(6, 25);
            // 
            // emote8
            // 
            this.emote8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.emote8.Image = global::Editor.Properties.Resources.ill;
            this.emote8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emote8.Name = "emote8";
            this.emote8.Size = new System.Drawing.Size(23, 22);
            this.emote8.Text = "Ill";
            this.emote8.Click += new System.EventHandler(this.Emote8_Click);
            // 
            // toolStripSeparator21
            // 
            this.toolStripSeparator21.Name = "toolStripSeparator21";
            this.toolStripSeparator21.Size = new System.Drawing.Size(6, 25);
            // 
            // emote9
            // 
            this.emote9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.emote9.Image = global::Editor.Properties.Resources.in_love;
            this.emote9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emote9.Name = "emote9";
            this.emote9.Size = new System.Drawing.Size(23, 22);
            this.emote9.Text = "In-love";
            this.emote9.Click += new System.EventHandler(this.Emote9_Click);
            // 
            // toolStripSeparator22
            // 
            this.toolStripSeparator22.Name = "toolStripSeparator22";
            this.toolStripSeparator22.Size = new System.Drawing.Size(6, 25);
            // 
            // emote10
            // 
            this.emote10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.emote10.Image = global::Editor.Properties.Resources.nerd;
            this.emote10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emote10.Name = "emote10";
            this.emote10.Size = new System.Drawing.Size(23, 22);
            this.emote10.Text = "Nerd";
            this.emote10.Click += new System.EventHandler(this.Emote10_Click);
            // 
            // toolStripSeparator23
            // 
            this.toolStripSeparator23.Name = "toolStripSeparator23";
            this.toolStripSeparator23.Size = new System.Drawing.Size(6, 25);
            // 
            // emote11
            // 
            this.emote11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.emote11.Image = global::Editor.Properties.Resources.quiet;
            this.emote11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emote11.Name = "emote11";
            this.emote11.Size = new System.Drawing.Size(23, 22);
            this.emote11.Text = "Quiet";
            this.emote11.Click += new System.EventHandler(this.Emote11_Click);
            // 
            // toolStripSeparator24
            // 
            this.toolStripSeparator24.Name = "toolStripSeparator24";
            this.toolStripSeparator24.Size = new System.Drawing.Size(6, 25);
            // 
            // emote12
            // 
            this.emote12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.emote12.Image = global::Editor.Properties.Resources.secret;
            this.emote12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emote12.Name = "emote12";
            this.emote12.Size = new System.Drawing.Size(23, 22);
            this.emote12.Text = "Secret";
            this.emote12.Click += new System.EventHandler(this.Emote12_Click);
            // 
            // toolStripSeparator25
            // 
            this.toolStripSeparator25.Name = "toolStripSeparator25";
            this.toolStripSeparator25.Size = new System.Drawing.Size(6, 25);
            // 
            // emote13
            // 
            this.emote13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.emote13.Image = global::Editor.Properties.Resources.surprised;
            this.emote13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emote13.Name = "emote13";
            this.emote13.Size = new System.Drawing.Size(23, 22);
            this.emote13.Text = "Surprised";
            this.emote13.Click += new System.EventHandler(this.Emote13_Click);
            // 
            // toolStripSeparator26
            // 
            this.toolStripSeparator26.Name = "toolStripSeparator26";
            this.toolStripSeparator26.Size = new System.Drawing.Size(6, 25);
            // 
            // emote14
            // 
            this.emote14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.emote14.Image = global::Editor.Properties.Resources.wink;
            this.emote14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emote14.Name = "emote14";
            this.emote14.Size = new System.Drawing.Size(23, 22);
            this.emote14.Text = "Wink";
            this.emote14.Click += new System.EventHandler(this.Emote14_Click);
            // 
            // toolStripSeparator27
            // 
            this.toolStripSeparator27.Name = "toolStripSeparator27";
            this.toolStripSeparator27.Size = new System.Drawing.Size(6, 25);
            // 
            // emote15
            // 
            this.emote15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.emote15.Image = global::Editor.Properties.Resources.tongue_out_1;
            this.emote15.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emote15.Name = "emote15";
            this.emote15.Size = new System.Drawing.Size(23, 22);
            this.emote15.Text = "Tongue-out";
            this.emote15.Click += new System.EventHandler(this.Emote15_Click);
            // 
            // EditorRTB
            // 
            this.EditorRTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditorRTB.Location = new System.Drawing.Point(0, 74);
            this.EditorRTB.Name = "EditorRTB";
            this.EditorRTB.Size = new System.Drawing.Size(800, 376);
            this.EditorRTB.TabIndex = 8;
            this.EditorRTB.Text = "";
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EditorRTB);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Editor";
            this.Text = "Text Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFontToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem fontColourToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem boldToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem italicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem underlineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem backgroundColourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Insert;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbNewDoc;
        private System.Windows.Forms.ToolStripButton tbOpen;
        private System.Windows.Forms.ToolStripButton tbSave;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton tbFont;
        private System.Windows.Forms.ToolStripButton tbFontColour;
        internal System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton tbBold;
        private System.Windows.Forms.ToolStripButton tbItalic;
        private System.Windows.Forms.ToolStripButton tbUnderline;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        internal new ToolStripMenuItem Font;
        private ToolStripMenuItem AboutToolStripMenuItem;
        private ToolStripButton tbUpperCase;
        internal ToolStripSeparator toolStripSeparator11;
        private ToolStripMenuItem lowercaseToolStripMenuItem;
        private ToolStripMenuItem uppercaseToolStripMenuItem;
        internal ToolStripSeparator toolStripSeparator12;
        private ToolStripButton tbLowerCase;
        private ToolStripComboBox ComboBox1;
        internal ToolStripSeparator toolStripSeparator13;
        private FontDialog fontDialog2;
        private ImageList imageList1;
        private ToolStrip toolStrip2;
        private ToolStripButton emote1;
        private ToolStripButton emote2;
        private ToolStripButton emote3;
        private ToolStripButton emote4;
        private ToolStripButton emote5;
        private ToolStripButton emote6;
        private ToolStripButton emote7;
        private ToolStripButton emote8;
        private ToolStripButton emote9;
        private ToolStripButton emote10;
        private ToolStripButton emote11;
        private ToolStripButton emote12;
        private ToolStripButton emote13;
        private ToolStripButton emote14;
        private ToolStripButton emote15;
        private RichTextBox EditorRTB;
        internal ToolStripSeparator toolStripSeparator14;
        internal ToolStripSeparator toolStripSeparator15;
        internal ToolStripSeparator toolStripSeparator16;
        internal ToolStripSeparator toolStripSeparator17;
        internal ToolStripSeparator toolStripSeparator18;
        internal ToolStripSeparator toolStripSeparator19;
        internal ToolStripSeparator toolStripSeparator20;
        internal ToolStripSeparator toolStripSeparator21;
        internal ToolStripSeparator toolStripSeparator22;
        internal ToolStripSeparator toolStripSeparator23;
        internal ToolStripSeparator toolStripSeparator24;
        internal ToolStripSeparator toolStripSeparator25;
        internal ToolStripSeparator toolStripSeparator26;
        internal ToolStripSeparator toolStripSeparator27;
        private ToolStripMenuItem moreInfoToolStripMenuItem;

        public ToolStripMenuItem Font1 { get => Font; set => Font = value; }
        public ToolStripMenuItem Font2 { get => Font; set => Font = value; }
        public ToolStripMenuItem Font3 { get => Font; set => Font = value; }
    }
}

