using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using SamPad.Edit_Operation;
using System.Management.Automation;
using System.Runtime.InteropServices;

namespace SamPad
{
    public partial class SamPadWindow : Form
    {
        public string archiveFile;

        string textOpenFile;

        public int zoom = 8;

        public EditOperation editOperation;

        public bool ProgramMode = false;

        bool needSave = false;

        bool saved = false;

        Timer timer;

        Process myProcess;

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        public SamPadWindow(string[] args)
        {
            InitializeComponent();
            timer = new Timer();
            timer.Tick += MyTimer_Tick;
            timer.Interval = 500;
            editOperation = new EditOperation();
            editOperation.TxtAreaChangeRequired = true;
            myProcess = new Process();
            
            if (args != null && args.Length > 0)
            {
                string openfile = args[0];

                if (File.Exists(openfile))
                {
                    using (StreamReader reader = new StreamReader(openfile))
                    {
                        writeBox.Text = reader.ReadToEnd();
                    }
                    archiveFile = openfile;
                    this.Text = archiveFile;
                    needSave = false;
                    writeBox.DeselectAll();
                }
            }
        }

        private void MyTimer_Tick(object sender, EventArgs e) 
        {
            timer.Stop();
            editOperation.Add_UndoRedo(writeBox.Text);
            UpdateView();
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writeBox.Clear();
            archiveFile = null;
            this.Text = "Sam Pad";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (archiveFile == null)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "text files (*.txt)|*.txt";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    archiveFile = saveFile.FileName;

                    using (StreamWriter sw = new StreamWriter(archiveFile))
                    {
                        sw.WriteLine(writeBox.Text);
                    }
                    this.Text = archiveFile;
                }
            }
            else
            {
                File.WriteAllText(archiveFile, writeBox.Text);
                this.Text = archiveFile;
            }
            needSave = false;
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog Openfile = new OpenFileDialog();
            Openfile.Filter = "txt files (*.txt)|*.txt|*.docx|All files";
            if (Openfile.ShowDialog() == DialogResult.OK)
            {
                archiveFile = Openfile.FileName;
                using (StreamReader sr = new StreamReader(archiveFile))
                {
                    writeBox.Text = sr.ReadToEnd();
                }
                String[] parts = archiveFile.Split();
                this.Text = parts[parts.Length - 1];
            }
        }

        private void SamPadWindow_Resize(object sender, EventArgs e)
        {
            writeBox.Size = this.Size;
        }

        private void Format_Click(object sender, EventArgs e)
        {
            var font = fontDialog1.ShowDialog();
            if (font == DialogResult.OK)
            {
                writeBox.Font = fontDialog1.Font;
            }
        }

        private void Cut_Click(object sender, EventArgs e)
        {
            writeBox.Cut();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            writeBox.Copy();
        }

        private void Paste_Click(object sender, EventArgs e)
        {
            writeBox.Paste();
        }

        private void Zoom_plus_Click(object sender, EventArgs e)
        {
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writeBox.Clear();
        }

        private void About_Click(object sender, EventArgs e)
        {
        }

        private void writeBox_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (editOperation.TxtAreaChangeRequired) 
            {
                timer.Start();
            }
            else
            {
                editOperation.TxtAreaChangeRequired = false;
            }
            UpdateView();
            try
            {
                String[] text =this.Text.Split(' ');
                if (text[text.Length -1] != "*")
                {
                    this.Text = this.Text + ' ' + '*';
                }
            }
            catch 
            {
                this.Text = this.Text + ' ' + '*';
            }
            needSave = true;
        }

        private void WebSearch_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(writeBox.Text);
            }
            catch
            {
                Process.Start("www.bing.com");
            }
        }

        private void Visible_Click(object sender, EventArgs e)
        {
            try
            {
                File.SetAttributes(archiveFile, FileAttributes.Normal);
            }
            catch
            {
                errorProvider1.SetError(writeBox, "Save the file first");
            }
        }

        private void Hided_Click(object sender, EventArgs e)
        {
            try
            {
                File.SetAttributes(archiveFile, FileAttributes.Hidden);
            }
            catch
            {
                errorProvider1.SetError(writeBox, "Save the file first");
            }
        }

        private void OnlyReading_Click(object sender, EventArgs e) {
            try {
            File.SetAttributes(archiveFile, FileAttributes.ReadOnly);
            }
            catch
            {
                errorProvider1.SetError(writeBox, "Save the file first");
            }

        }

        private void Print_Click(object sender, EventArgs e)
        {
            printDialog1.ShowDialog();
        }
		//Color of the writing box
        private void Writing_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                writeBox.BackColor = colorDialog1.Color;
            }
        }
		//Color of the toolbar
        private void Aplication_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                var color = colorDialog1.Color;
                ToolLine.BackColor = color;
            }
            
        }

        private void SaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "text files (*.txt)|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                archiveFile = saveFile.FileName;

                using (StreamWriter sw = new StreamWriter(archiveFile))
                {
                    sw.WriteLine(writeBox.Text);
                }
                String[] parts = archiveFile.Split();
                this.Text = parts[parts.Length - 1];
            }

        }

        private void UpdateView()
        {
            Undo.Enabled = editOperation.CanUndo() ? true : false;
            Redo.Enabled = editOperation.CanRedo() ? true : false;
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            writeBox.Text = editOperation.RedoClicked();
            UpdateView();
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            writeBox.Text = editOperation.UndoClicked();
            UpdateView();
        }

        private void CloseB_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void StartB_Click(object sender, EventArgs e)
        {
            PowerShell ps = PowerShell.Create();

            ps.AddCommand(writeBox.Text);

            var results = ps.Invoke();

            for (int i = 0; i <= results.Count; i++)
            {
                Console.WriteLine(results);
            }
            writeBox.Clear();
        }


        private void PowerShellB_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("PowerShell.exe");
            }
            catch
            {

            }
        }

        private void Tools_ButtonClick(object sender, EventArgs e)
        {

        }

        private void SamPadWindow_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void SamPadWindow_Load(object sender, EventArgs e)
        {

        }

        private void SamPadWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void SamPadWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            int i = 0;
            Process[] process = Process.GetProcesses();
            foreach (Process processItem in process)
            {
                if (processItem.ProcessName == process[i].ProcessName)
                {
                    break;
                }
                else
                {
                    i++;
                }
            }
            if (!saved && needSave)
            {
                if (MessageBox.Show("Want to save?", "Sam Pad", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog1.FileName, writeBox.Text);
                        process[i].Close();
                        saved = true;
                    }
                    else
                    {
                        process[i].Close();
                        saved = true;
                    }

                }
                else
                {
                    process[i].Close();
                    saved = true;
                }
            }
            else
            {
                process[i].Close();
            }
        }
    }
}