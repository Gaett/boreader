using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace boreader
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public Thread thread;
        public String filename;
        public ArrayList texts;
        public int counter = 0;
        public Boolean started = false;
        public Boolean padded = false;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.textBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Location = new System.Drawing.Point(18, 63);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(1399, 270);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Hello !";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.trackBar1);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(18, 6);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1358, 48);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Write earlier  ( 0 to 9sec ) def 3";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(233, 3);
            this.trackBar1.Maximum = 9;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(239, 69);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Value = 3;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(479, 5);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 35);
            this.button5.TabIndex = 10;
            this.button5.Text = "Chose file";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.open_File);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.start_reader);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(719, 5);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 35);
            this.button4.TabIndex = 9;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.exit_button);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(838, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "ALT + F1 : toggle button visibility";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(1079, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "ALT + F2 : toggle ToolBar visibility";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1430, 347);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Build Order Reader";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.toggle_shortkeys);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public int charToInt(char c)
        {
            return (int)(c - '0');
        }

        public void readstuff()
        {
            int time = 0;
            int diff = 0;
            DateTime t1 = DateTime.Now;
            DateTime t2 = DateTime.Now;
            int cursorValue = 3;
            MethodInvoker inv2 = delegate
            {
                cursorValue = this.trackBar1.Value;
            };
            this.Invoke(inv2);

            foreach (String line in this.texts)
            {
                var match = Regex.Match(line, "\\d+:\\d+");
                time = Milli_From_String(match.Groups[0].Value);
/*                String[] words = line.Split(' ');
                time = (
                    charToInt(words[2][0])*60
                    + charToInt(words[2][2])*10
                    + charToInt(words[2][3])
                    ) *1000;*/
                
                //Console.WriteLine("Time " + time + " Diff " + diff);
                if (time < (cursorValue * 1000)+1000)
                {
                    diff = 0;


                } 
                else
                {
                    if (!padded)
                    {
                        diff = Math.Abs(time - cursorValue * 1000);
                        this.padded = true;
                    }
                    else
                    {
                        diff = Math.Abs(time - diff);
                    }
                    Thread.Sleep(diff);
                    t2 = DateTime.Now;
                    TimeSpan ts = t2.Subtract(t1);
                    //Console.WriteLine(ts);
                    diff = time;
                }
                MethodInvoker inv = delegate
                {
                    this.textBox1.AppendText(line);
                    //Console.WriteLine(line);
                };
                this.Invoke(inv);
            }
        }

        private void start_reader(object sender, System.EventArgs e)
        {
            if (!started)
            {
                this.thread = new Thread(() => {
                    this.readstuff();
                });
                this.thread.Start();
                textBox1.Text = "START build order \r\n";
                this.button1.Text = "Stop";
                this.started = true;
            }
            else
            {
                try
                {
                    this.thread.Abort();
                }
                catch (Exception)
                {
                    
                }
                textBox1.Text = "STOP build order \r\n";
                this.button1.Text = "Start";
                this.started = false;
            }
            
        }

        private void exit_button(object sender, System.EventArgs e)
        {
            try
            {
                this.thread.Abort();
            } catch (Exception)
            {
                this.Close();
            }
            this.Close();
        }

        private void open_File(object sender, System.EventArgs e)
        {
            this.button1.Text = "Start";
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "C# Corner Open File Dialog";
            fdlg.InitialDirectory = System.IO.Directory.GetCurrentDirectory();
            fdlg.Filter = "txt files (*.txt)|*.txt";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                this.filename = fdlg.FileName;
                this.texts = new ArrayList();
                String line = "";
                System.IO.StreamReader st = new System.IO.StreamReader(this.filename);
                while ((line = st.ReadLine()) != null)
                {
                    this.texts.Add(line + "\r\n");
                    counter++;
                }
                st.Close();
            } else
            {

            }

        }

        public int Milli_From_String(String abc)
        {
            int calc = 0;
            if (abc.Length == 4)
            {
                calc = (
                    charToInt(abc[0]) * 60
                    + charToInt(abc[2]) * 10
                    + charToInt(abc[3])
                    ) * 1000;
            }
            else
            {
                calc = (
                    ( (charToInt(abc[0])) * 10 + charToInt(abc[1])) * 60
                    + charToInt(abc[3]) * 10
                    + charToInt(abc[4])
                    ) * 1000;
            }
            return calc;
        }

        private void Form1_ResizeEnd(Object sender, EventArgs e)
        {
            this.textBox1.Left = (this.Width / 2) - (this.textBox1.Width / 2);
            this.textBox1.Width = (this.Width / 2);
            this.flowLayoutPanel1.Left = (this.Width / 2) - (this.flowLayoutPanel1.Width / 2);
        }

        private void toggle_shortkeys(Object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F1)
            {
                if (button1.Enabled)
                {
                    button1.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    trackBar1.Enabled = false;
                    trackBar1.Visible = false;
                    label3.Visible = false;
                }
                else
                {
                    button1.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    trackBar1.Enabled = true;
                    trackBar1.Visible = true;
                    label3.Visible = true;
                }

            }
            if (e.Alt && e.KeyCode == Keys.F2)
            {
                if (this.FormBorderStyle == FormBorderStyle.None)
                {
                    this.FormBorderStyle = FormBorderStyle.Sizable;
                }
                else
                {
                    this.FormBorderStyle = FormBorderStyle.None;
                }
            }
        }

        #endregion
        public System.Windows.Forms.TextBox textBox1;
        public FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button5;
        private Button button4;
        private TrackBar trackBar1;
        private Label label1;
        private Label label2;
        private Label label3;

        public object Response { get; private set; }
    }

    
}

