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
using System.Threading;

namespace easyDe4dot
{
    public partial class Form1 : Form
    {
        string CurDir = Path.GetDirectoryName(typeof(Form1).Assembly.Location);
        string de4dot;
        string de4dot64;
        private Thread thread;
        private Process process;

        public Form1(string [] args)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            if (args != null && args.Length > 0 && File.Exists(args[0]))
                SetInputFile(args[0]);
            
            de4dot = CurDir + "\\de4dot.exe";
            de4dot64 = CurDir + "\\de4dot-x64.exe";

            bool x86found = File.Exists(de4dot);
            bool x64found =  File.Exists(de4dot64);

            if (!x86found && !x64found)
            {
                MessageBox.Show("De4dot not found, exiting...");
                Environment.Exit(0);
            }

            if (!x64found || !x86found)
            {
                chk64.Enabled = false;
                if (!x86found)
                    chk64.Checked = true;
            }
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                SetInputFile(openFileDialog1.FileName);
        }
        private void SetInputFile(string inputFile)
        {
            txtFile.Text = inputFile;
            txtFile.SelectAll();
        }

        private void txtFile_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Move : DragDropEffects.None;
        }

        private void txtFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (files != null && files.Length > 0)
                SetInputFile(files[0]);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (thread != null)
                thread.Abort();
            if (process != null && !process.HasExited)
                process.Kill();
            thread = new Thread(new ThreadStart(StartDe4dot));
            thread.Start();
        }
        private void StartDe4dot(){
            process = new Process();
            ProcessStartInfo sinfo = new ProcessStartInfo();

            List<string> args = new List<string>();

            if (txtFile.Text == "")
            {
                MessageBox.Show("Please select a file");
                return;
            }
            args.Add(string.Format("\"{0}\"", txtFile.Text));

            if (chkPrsrvTok.Checked) args.Add(chkPrsrvTok.Text);
            if (chkKeepTypes.Checked) args.Add(chkKeepTypes.Text);
            if (chkDntRnm.Checked) args.Add(chkDntRnm.Text);
            if (chkForceObf.Checked)
            {
                args.Add(chkForceObf.Text);
                if (cmbObf.SelectedIndex == -1)
                {
                    MessageBox.Show("Invalid obfuscator index");
                    return;
                }
                args.Add(((string)cmbObf.SelectedItem).Split(' ')[0]);
            }
            if (chkStrtype.Checked)
            {
                args.Add(chkStrtype.Text);
                if (cmbStrype.SelectedIndex == -1)
                {
                    MessageBox.Show("Invalid strtype index");
                    return;
                }
                args.Add((string)cmbStrype.SelectedItem);

                string[] toks = txtStrtok.Text.Split(' ');
                if (toks.Length == 0)
                {
                    MessageBox.Show("Strtok can't be empty");
                    return;
                }
                foreach (string tok in toks)
                {
                    args.Add(lblStrtok.Text);
                    args.Add(tok);
                }
            }
            sinfo.Arguments = string.Join(" ", args);
            sinfo.FileName = chk64.Checked ? de4dot64 : de4dot;
            sinfo.RedirectStandardOutput = true;
            sinfo.UseShellExecute = false;
            sinfo.CreateNoWindow = true;
            process.StartInfo = sinfo;

            txtLog.Text = "Command line : " + sinfo.Arguments + Environment.NewLine;
            txtLog.AppendText("Starting de4dot" + Environment.NewLine);

            if (process.Start())
            {
                txtLog.AppendText("Process started" + Environment.NewLine);
                txtLog.AppendText("----------------" + Environment.NewLine);
                
                while (!process.HasExited)
                {
                    string line = process.StandardOutput.ReadLine();
                    if (line!=null && line != "")
                        txtLog.AppendText(line +Environment.NewLine);
                }
                txtLog.AppendText("----------------" + Environment.NewLine);
                txtLog.AppendText("Process terminated");

            }
            else
                txtLog.AppendText("!Failed to start process" + Environment.NewLine);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLog.Text = "";
        }
    }
}
