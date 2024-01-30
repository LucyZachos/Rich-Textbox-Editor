/*Author: Lucinda Frohlich
  Date: 14/06/2019 completed
  Module: Basic C# Programming
  Module Code: MLBC-195-01
  IS Project Specification - Editor (Project 2)
  Project Purpose: A text editor that will function similarly to Mircosoft word
*/


//Namespaces utilized
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using ExtendedRichTextBox;

namespace Editor

{
    public partial class Editor : Form
    {
        //Constructors: Invoked automatically at the time of the objects creation
        #region constructor

        public Editor()
        {
            InitializeComponent();
            currentFile = "";
            this.Text = "New Document";
        }

        #endregion

        //Declaration: Value storage area
        #region Declaration

        //Keeps track of the path and file name of the file loaded into the extended RTB control
        private string currentFile; 

        #endregion

        //Main Menu Methods. I have used regions to optimize search efficiciency when debugging
        #region Menu Methods

        //New file settings
        #region New File Method

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Settings create a new document
            try
            {
                //Checks if the document has been modified
                if (EditorRTB.Modified == true)
                {
                    //message displayed in a seperate box
                    System.Windows.Forms.DialogResult answer;
                    answer = MessageBox.Show("Save current document before creating new document? All current text will be lost if not saved.", "Unsaved Document", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == System.Windows.Forms.DialogResult.No)
                    {
                        currentFile = "";
                        this.Text = "New Document";
                        EditorRTB.Modified = false;
                        EditorRTB.Clear();
                        return;
                    }
                    else
                    {
                        SaveToolStripMenuItem_Click(this, new EventArgs());
                        EditorRTB.Modified = false;
                        EditorRTB.Clear();
                        currentFile = "";
                        this.Text = "New Document";
                        return;
                    }
                }
                else
                {
                    currentFile = "";
                    this.Text = "New Document";
                    EditorRTB.Modified = false;
                    EditorRTB.Clear();
                    return;
                }
            }
            catch (Exception ex)
            {
                //message displayed in a seperate box when an exception occurs
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        #endregion

        //Open an existing document
        #region Open Method

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //checks if the document has been edited/ modified
                if (EditorRTB.Modified == true)
                {
                    //message displayed in a seperate box
                    System.Windows.Forms.DialogResult answer;
                    answer = MessageBox.Show("Save current file before opening another document? All current text will be lost if not saved", "Unsaved Document", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == System.Windows.Forms.DialogResult.No)
                    {
                        EditorRTB.Modified = false;
                        OpenFile();
                    }
                    else
                    {
                        SaveToolStripMenuItem_Click(this, new EventArgs());
                        OpenFile();
                    }
                }
                else
                {
                    OpenFile();
                }
            }
            catch (Exception ex)
            {
                //message displayed in a seperate box when an exception is caught
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void OpenFile()
        {
            //open an existing document settings
            try
            {
                //Open file dialog box
                openFileDialog1.Title = "Open File";
                openFileDialog1.DefaultExt = "rtf";
                //file type filters
                openFileDialog1.Filter = "Rich Text Files|*.rtf|Text Files|*.txt|HTML Files|*.htm|All Files|*.*";
                openFileDialog1.FilterIndex = 1;
                openFileDialog1.FileName = string.Empty;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    if (openFileDialog1.FileName == "")
                    {
                        return;
                    }

                    string stringExt;
                    stringExt = System.IO.Path.GetExtension(openFileDialog1.FileName);
                    stringExt = stringExt.ToUpper();

                    if (stringExt == ".RTF")
                    {
                        EditorRTB.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        //To open the document as plain text
                        System.IO.StreamReader txtReader;
                        txtReader = new System.IO.StreamReader(openFileDialog1.FileName);
                        EditorRTB.Text = txtReader.ReadToEnd();
                        txtReader.Close();
                        txtReader = null;
                        EditorRTB.SelectionStart = 0;
                        EditorRTB.SelectionLength = 0;
                    }

                    currentFile = openFileDialog1.FileName;
                    EditorRTB.Modified = false;
                    this.Text = currentFile.ToString();
                }
                else
                {
                    //message displayed in a seperate box
                    MessageBox.Show("Open File request cancelled.", "Cancelled");
                }
            }
            catch (Exception ex)
            {
                //message displayed in a seperate box when an exception is caught
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        #endregion

        //Save a document
        #region Save Method

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Settings to save a document
            try
            {
                if (currentFile == string.Empty)
                {
                    SaveAsToolStripMenuItem_Click(this, e);
                    return;
                }

                try
                {
                    string stringExt;
                    stringExt = System.IO.Path.GetExtension(currentFile);
                    stringExt = stringExt.ToUpper();
                    if (stringExt == ".RTF")
                    {
                        EditorRTB.SaveFile(currentFile);
                    }
                    else
                    {
                        //To save the document as plain text
                        System.IO.StreamWriter txtWriter;
                        txtWriter = new System.IO.StreamWriter(currentFile);
                        txtWriter.Write(EditorRTB.Text);
                        txtWriter.Close();
                        txtWriter = null;
                        EditorRTB.SelectionStart = 0;
                        EditorRTB.SelectionLength = 0;
                    }

                    this.Text = currentFile.ToString();
                    EditorRTB.Modified = false;
                }
                catch (Exception ex)
                {
                    //message displayed in a seperate box when an exception is caught
                    MessageBox.Show(ex.Message.ToString(), "File Save Error. The document could not be saved.");
                }
            }
            catch (Exception ex)
            {
                //message displayed in a seperate box when an exception is caught
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        #endregion

        //Save a copy of an open document
        #region Save As Method

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Settings to save a copy of an existing document
            try
            {
                saveFileDialog1.Title = "Save File";
                saveFileDialog1.DefaultExt = "rtf";
                saveFileDialog1.Filter = "Rich Text Files|*.rtf|Text Files|*.txt|HTML Files|*.htm|All Files|*.*";
                saveFileDialog1.FilterIndex = 1;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {

                    //if file name is empty
                    if (saveFileDialog1.FileName == "")
                    {
                        return;
                    }

                    string stringExt;
                    stringExt = System.IO.Path.GetExtension(saveFileDialog1.FileName);
                    stringExt = stringExt.ToUpper();

                    if (stringExt == ".RTF")
                    {
                        EditorRTB.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.RichText);
                    }
                    else
                    {
                        //Save a plain text document
                        System.IO.StreamWriter txtWriter;
                        txtWriter = new System.IO.StreamWriter(saveFileDialog1.FileName);
                        txtWriter.Write(EditorRTB.Text);
                        txtWriter.Close();
                        txtWriter = null;
                        EditorRTB.SelectionStart = 0;
                        EditorRTB.SelectionLength = 0;
                    }

                    currentFile = saveFileDialog1.FileName;
                    EditorRTB.Modified = false;
                    this.Text = currentFile.ToString();
                    MessageBox.Show(currentFile.ToString() + " saved.", "File Save");
                }
                else
                {
                    //message displayed in a seperate box when an exception is caught
                    MessageBox.Show("Save File request cancelled.", "Cancelled");
                }
            }
            catch (Exception ex)
            {
                //message displayed in a seperate box when an exception is caught
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        #endregion

        //Settings to exit/close the document
        #region Exit Method

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Settings to close/exit a document
            try
            {
                //Checks if the document has been edited
                if (EditorRTB.Modified == true)
                {
                    //message displayed in a seperate box
                    System.Windows.Forms.DialogResult answer;
                    answer = MessageBox.Show("Save this document before closing?", "Unsaved Document", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == System.Windows.Forms.DialogResult.Yes)
                    {
                        return;
                    }
                    else
                    {
                        EditorRTB.Modified = false;
                        Application.Exit();
                    }
                }
                else
                {
                    EditorRTB.Modified = false;
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                //message displayed in a seperate box when an exception is caught
                MessageBox.Show(ex.Message.ToString(), "Error");
            }

        }

        #endregion

        //Undo method settings
        #region Undo Method

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Settings to undo an action
            try
            {
                if (EditorRTB.CanUndo)
                {
                    EditorRTB.Undo();
                }
            }
            catch (Exception ex)
            {
                //message displayed in a seperate box when an exception is caught
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        #endregion

        //Redo method settings
        #region Redo Method

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //settings to redo an action that was previoously undone
            try
            {
                if (EditorRTB.CanRedo)
                {
                    EditorRTB.Redo();
                }
            }
            catch (Exception ex)
            {
                //message displayed in a seperate box when an exception is caught
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        #endregion

        //Select all method settings
        #region SelectAll Method
        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Settings to select all text and images within the RTB
            try
            {
                EditorRTB.SelectAll();
            }
            catch (Exception)
            {
                //message displayed in a seperate box when an exception is caught
                MessageBox.Show("Unable to select all document content.", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        //Copy method settings
        #region Copy Method
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //settings to copy text and images within the RTB
            try
            {
                EditorRTB.Copy();
            }
            catch (Exception)
            {
                //message displayed in a seperate box when an exception is caught
                MessageBox.Show("Unable to copy document content.", "Copy", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        //Cut method settings
        #region Cut Method

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //settings to cut text and images from within the RTB
            try
            {
                EditorRTB.Cut();
            }
            catch
            {
                //message displayed in a seperate box when an exception is caught
                MessageBox.Show("Unable to cut document content.", "Cut", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        //Paste method settings
        #region Paste Method

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //settings to paste text and images within the RTB
            try
            {
                EditorRTB.Paste();
            }
            catch
            {
                //message displayed in a seperate box when an exception is caught
                MessageBox.Show("Unable to copy clipboard content to document.", "Paste", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        //System font selection settings
        #region Select Font Method
        private void SelectFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Settings to select a font within the RTB
            try
            {
                //If no font is selected - Change all font within the RTB
                if (!(EditorRTB.SelectionFont == null))
                {
                    fontDialog1.Font = EditorRTB.SelectionFont;
                }
                else
                {
                    fontDialog1.Font = null;
                }
                //if text has been selected, change only selected text
                fontDialog1.ShowApply = true;
           
                if (fontDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    EditorRTB.SelectionFont = fontDialog1.Font;
                }
            }
            catch (Exception ex)
            {
                //message displayed in a seperate box when an exception is caught
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        #endregion

        //Font colour method settings
        #region Font Colour Method

        private void FontColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                colorDialog1.Color = EditorRTB.ForeColor;

                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    //Checking for any text in the RTB
                    if (EditorRTB.SelectionLength > 0)
                    {
                        EditorRTB.SelectionColor = colorDialog1.Color;
                    }
                    else
                    {
                        EditorRTB.ForeColor = colorDialog1.Color;
                    }
                }
            }
            catch (Exception ex)
            {
                //message displayed in a seperate box when an exception is caught
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        #endregion

        //To set selected text to Bold
        #region Bold Font Method

        private void BoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Check if there is any text in the doccument
                if (EditorRTB.Text == "")
                {
                    //Returns a message
                    MessageBox.Show("The document is empty and could not be formatted.");
                }
                // changes selected text to bold
                else if (!(EditorRTB.SelectionFont == null))
                {
                    System.Drawing.Font currentFont = EditorRTB.SelectionFont;
                    System.Drawing.FontStyle newFontStyle;

                    newFontStyle = EditorRTB.SelectionFont.Style ^ FontStyle.Bold;

                    EditorRTB.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);

                }
            }
            catch (Exception ex)
            {
                //message displayed in a seperate box when an exception is caught
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        #endregion

        //To set selected text to italic
        #region Italic Font Method
        private void ItalicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //chekcs if there is any text in the RTB to be changed
                if (EditorRTB.Text == "")
                {
                    //returns a message if there is not text to edit
                    MessageBox.Show("The document is empty and could not be formatted.");
                }
                else if (!(EditorRTB.SelectionFont == null))
                {
                    //sets selected text to italic
                    System.Drawing.Font currentFont = EditorRTB.SelectionFont;
                    System.Drawing.FontStyle newFontStyle;

                    newFontStyle = EditorRTB.SelectionFont.Style ^ FontStyle.Italic;

                    EditorRTB.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                }
            }
            catch (Exception ex)
            {
                //message displayed in a seperate box when an exception is caught
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        #endregion

        //To underline selected text
        #region Underline Font Method

        private void UnderlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //checks if the RTB contains any text
                if (EditorRTB.Text == "")
                {
                    //message displayed in a seperate box
                    MessageBox.Show("The document is empty and could not be formatted.");
                }
                else if (!(EditorRTB.SelectionFont == null))
                {
                    //Selected text is underlined
                    System.Drawing.Font currentFont = EditorRTB.SelectionFont;
                    System.Drawing.FontStyle newFontStyle;

                    newFontStyle = EditorRTB.SelectionFont.Style ^ FontStyle.Underline;

                    EditorRTB.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                }
            }
            catch (Exception ex)
            {
                //message displayed in a seperate box when an exception is caught
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        #endregion

        //Settings to revert text back to standard
        #region Normal Font Method

        private void NormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //checks if the RTB contains any text
                if (EditorRTB.Text == "")
                {
                    //message displayed in a seperate box
                    MessageBox.Show("The document is empty and could not be formatted.");
                }
                else if (!(EditorRTB.SelectionFont == null))
                {
                    System.Drawing.Font currentFont = EditorRTB.SelectionFont;
                    System.Drawing.FontStyle newFontStyle;
                    newFontStyle = FontStyle.Regular;
                    EditorRTB.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);
                }
            }
            catch (Exception ex)
            {
                //message displayed in a seperate box when an exception is caught
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        #endregion

        //Settings to change text to uppercase
        #region Uppercase Method

        private void UppercaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //checks if the RTB contains any text
                if (EditorRTB.Text == "")
                {
                    //message displayed in a seperate box
                    MessageBox.Show("The document is empty and could not be formatted.");
                }
                else if (EditorRTB.SelectionLength > 0)
                {
                    //checks for text in the RTB
                    EditorRTB.SelectedText = EditorRTB.SelectedText.ToUpper();
                }
                else
                {
                    EditorRTB.Text = EditorRTB.Text.ToUpper();
                }
            }
            catch (Exception ex)
            {
                //message displayed in a seperate box when an exception is caught
                MessageBox.Show(ex.Message.ToString(), "Error");
            }

        }

        #endregion

        //Settings to change text to lowercase
        #region Lowercase Method
        private void LowercaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Checks if the RTB is empty
                if (EditorRTB.Text == "")
                {
                    //message displayed in a seperate box
                    MessageBox.Show("The document is empty and could not be formatted.");
                }
                //Checks if the RTB contains any text
                else if (EditorRTB.SelectionLength > 0)
                {
                    //sets seleted text to lowercase
                    EditorRTB.SelectedText = EditorRTB.SelectedText.ToLower();
                }
                else
                {
                    //if nothing is selected, all text is set to lowercase
                    EditorRTB.Text = EditorRTB.Text.ToLower();
                }
            }
            catch (Exception ex)
            {
                //message displayed in a seperate box when an exception is caught
                MessageBox.Show(ex.Message.ToString(), "Error");
            }

        }

        #endregion

        //Settings to to RTB background colour
        #region Background Colour Method

        private void BackgroundColourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                colorDialog1.Color = EditorRTB.BackColor;

                //message displayed in a seperate box
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    //sets background colour
                     EditorRTB.BackColor = colorDialog1.Color;
                }
            }   
            catch (Exception ex)
            {
                //message displayed in a seperate box when an exception is caught
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        #endregion

        //Settings to insert an image into the Editor
        #region Insert Image Method

        private void ImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open file dialog
            openFileDialog1.Title = "Insert Image File";
            openFileDialog1.DefaultExt = "rtf";
            openFileDialog1.Filter = "Bitmap Files|*.bmp|JPEG Files|*.jpg|GIF Files|*.gif";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName == "")
            {
                return;
            }

            try
            {
                string stringImagePath = openFileDialog1.FileName;
                Image img;
                img = Image.FromFile(stringImagePath);
                Clipboard.SetDataObject(img);
                DataFormats.Format df;
                df = DataFormats.GetFormat(DataFormats.Bitmap);
                if (this.EditorRTB.CanPaste(df))
                {
                    this.EditorRTB.Paste(df);
                }
            }
            catch
            {
                //message displayed in a seperate box when an exception is caught
                MessageBox.Show("Unable to insert image format selected.", "Paste", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        //About application and author
        #region About

        private void MoreInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //message displayed in a seperate box when an exception is caught
            MessageBox.Show("This program was created by Lucinda Frohlich as a simple Rich Text Editor. Created: 19/06/2019");
        }

        #endregion

        #endregion

        //Toolbar Methods
        #region Toolbar Methods

        //refrers back to Menu - New Document settings.
        private void TbNewDoc_Click(object sender, EventArgs e)
        {
            NewToolStripMenuItem_Click(this, e);
        }

        //refers back too Menu - Open settings
        private void TbOpen_Click(object sender, EventArgs e)
        {
            OpenToolStripMenuItem_Click(this, e);
        }

        //refers back to Menu - Save settings
        private void TbSave_Click(object sender, EventArgs e)
        {
            SaveToolStripMenuItem_Click(this, e);
        }

        //refers back to Menu - Font settings
        private void TbFont_Click(object sender, EventArgs e)
        {
            SelectFontToolStripMenuItem_Click(this, e);
        }

        //refers back to Menu - Font COlour settings
        private void TbFontColour_Click(object sender, EventArgs e)
        {
            FontColourToolStripMenuItem_Click(this, new EventArgs());
        }

        //refers back to Menu - Bold settings
        private void TbBold_Click(object sender, EventArgs e)
        {
            BoldToolStripMenuItem_Click(this, e);
        }

        //refers back to Menu - Italic settings
        private void TbItalic_Click(object sender, EventArgs e)
        {
            ItalicToolStripMenuItem_Click(this, e);
        }

        //refers back to Menu - Underline settings
        private void TbUnderline_Click(object sender, EventArgs e)
        {
            UnderlineToolStripMenuItem_Click(this, e);
        }

        //refers back to Menu - Uppercase settings
        private void TbUpperCase_Click(object sender, EventArgs e)
        {
            UppercaseToolStripMenuItem_Click(this, e);
        }

        //refers back to Menu - Lowercase settings
        private void TbLowerCase_Click(object sender, EventArgs e)
        {
            LowercaseToolStripMenuItem_Click(this, e);
        }

        //Settings for comboBox. Drop down box containing words that can be appended at RT
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditorRTB.SelectedText = ComboBox1.SelectedItem.ToString();
        }
        #endregion

        //Settings for Windows main close button
        #region Exit Button

        //Settings to close document from main form. 
        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //checks if the document has been edited
                if (EditorRTB.Modified == true)
                {
                    //Message box to save before closing
                    System.Windows.Forms.DialogResult answer;
                    answer = MessageBox.Show("Save current document before exiting?", "Unsaved Document", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (answer == System.Windows.Forms.DialogResult.No)
                    {
                        EditorRTB.Modified = false;
                        EditorRTB.Clear();
                        return;
                    }
                    else
                    {
                        SaveToolStripMenuItem_Click(this, new EventArgs());
                    }
                }
                else
                {
                    //RTB is cleared and  closed
                    EditorRTB.Clear();
                }
                currentFile = "";
                this.Text = "New Document";
            }
            catch (Exception ex)
            {
                //message displayed in a seperate box when an exception is caught
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        #endregion

        //Settings for emoticon buttons. Images are selected from a imagelist in design
        #region Emoticons

        private void Emote1_Click(object sender, EventArgs e)
        {
            Bitmap emote0 = new
            Bitmap(this.imageList1.Images[0]);
            Clipboard.SetImage(emote0);
            EditorRTB.Paste();
            Clipboard.Clear();
        }

        private void Emote2_Click(object sender, EventArgs e)
        {
            Bitmap emote1 = new
            Bitmap(this.imageList1.Images[1]);
            Clipboard.SetImage(emote1);
            EditorRTB.Paste();
            Clipboard.Clear();
        }

        private void Emote3_Click(object sender, EventArgs e)
        {
            Bitmap emote2 = new
            Bitmap(this.imageList1.Images[2]);
            Clipboard.SetImage(emote2);
            EditorRTB.Paste();
            Clipboard.Clear();
        }

        private void Emote4_Click(object sender, EventArgs e)
        {
            Bitmap emote3 = new
            Bitmap(this.imageList1.Images[3]);
            Clipboard.SetImage(emote3);
            EditorRTB.Paste();
            Clipboard.Clear();
        }

        private void Emote5_Click(object sender, EventArgs e)
        {
            Bitmap emote4 = new
            Bitmap(this.imageList1.Images[4]);
            Clipboard.SetImage(emote4);
            EditorRTB.Paste();
            Clipboard.Clear();
        }

        private void Emote6_Click(object sender, EventArgs e)
        {
            Bitmap emote5 = new
            Bitmap(this.imageList1.Images[5]);
            Clipboard.SetImage(emote5);
            EditorRTB.Paste();
            Clipboard.Clear();
        }

        private void Emote7_Click(object sender, EventArgs e)
        {
            Bitmap emote6 = new
            Bitmap(this.imageList1.Images[6]);
            Clipboard.SetImage(emote6);
            EditorRTB.Paste();
            Clipboard.Clear();
        }

        private void Emote8_Click(object sender, EventArgs e)
        {
            Bitmap emote7 = new
            Bitmap(this.imageList1.Images[7]);
            Clipboard.SetImage(emote7);
            EditorRTB.Paste();
            Clipboard.Clear();
        }

        private void Emote9_Click(object sender, EventArgs e)
        {
            Bitmap emote8 = new
            Bitmap(this.imageList1.Images[8]);
            Clipboard.SetImage(emote8);
            EditorRTB.Paste();
            Clipboard.Clear();
        }

        private void Emote10_Click(object sender, EventArgs e)
        {
            Bitmap emote9 = new
            Bitmap(this.imageList1.Images[9]);
            Clipboard.SetImage(emote9);
            EditorRTB.Paste();
            Clipboard.Clear();
        }

        private void Emote11_Click(object sender, EventArgs e)
        {
            Bitmap emote10 = new
            Bitmap(this.imageList1.Images[10]);
            Clipboard.SetImage(emote10);
            EditorRTB.Paste();
            Clipboard.Clear();
        }

        private void Emote12_Click(object sender, EventArgs e)
        {
            Bitmap emote11 = new
            Bitmap(this.imageList1.Images[11]);
            Clipboard.SetImage(emote11);
            EditorRTB.Paste();
            Clipboard.Clear();
        }

        private void Emote13_Click(object sender, EventArgs e)
        {
            Bitmap emote12 = new
            Bitmap(this.imageList1.Images[12]);
            Clipboard.SetImage(emote12);
            EditorRTB.Paste();
            Clipboard.Clear();
        }

        private void Emote14_Click(object sender, EventArgs e)
        {
            Bitmap emote13 = new
            Bitmap(this.imageList1.Images[13]);
            Clipboard.SetImage(emote13);
            EditorRTB.Paste();
            Clipboard.Clear();
        }

        private void Emote15_Click(object sender, EventArgs e)
        {
            Bitmap emote14 = new
            Bitmap(this.imageList1.Images[14]);
            Clipboard.SetImage(emote14);
            EditorRTB.Paste();
            Clipboard.Clear();
        }


        #endregion
    }
}