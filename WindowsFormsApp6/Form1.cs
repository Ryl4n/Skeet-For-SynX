using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using SkeetFramework;
using sxlib.Specialized;
using sxlib;
using System.Diagnostics;
using skeet;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public SxLibWinForms Sxlib;
        public bool attached;
        public bool loaded;
        public static string Direct = Directory.GetCurrentDirectory();
        public Form1()
        {
            Functions.Lib = SxLib.InitializeWinForms(this, Direct);
            Functions.Lib.Load();
            Functions.Lib.LoadEvent += SynLoadEvent;

            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "skeet X by rylan and hayden";
            listBox1.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(listBox1, "./Script_skeet", "*.txt");
            Functions.PopulateListBox(listBox1, "./Script_skeet", "*.lua");

            

            timer1.Start();
        }
        private void skeetButton1_Click(object sender, EventArgs e)
        {
        }

        private void skeetComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void skeetToggle1_CheckedChanged(object sender)
        {
            
        }

        private void skeetBackground1_Click(object sender, EventArgs e)
        {

        }

        private void skeetGroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void skeetButton2_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "";
        }

        private void skeetButton1_Click_1(object sender, EventArgs e)
        {
            string script = this.fastColoredTextBox1.Text;
            Functions.Lib.Execute(script);
        }

        private void skeetButton4_Click(object sender, EventArgs e)
        {
            if (Functions.openfiledialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string MainText = File.ReadAllText(Functions.openfiledialog.FileName);
                    fastColoredTextBox1.Text = MainText;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void skeetButton3_Click(object sender, EventArgs e)
        {

        }

        private void skeetButton3_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(1);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//Clear Items in the LuaScriptList
            Functions.PopulateListBox(listBox1, "./Script_skeet", "*.txt");
            Functions.PopulateListBox(listBox1, "./Script_skeet", "*.lua");
        }


        private void script()
        {
           

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) => fastColoredTextBox1.Text = File.ReadAllText($"./Script_skeet/{listBox1.SelectedItem}");

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }
        private void SynAttachEvent(SxLibBase.SynAttachEvents Event, object Param)
        {
            switch (Event)
            {
                case SxLibBase.SynAttachEvents.INJECTING:
                    this.label1.Text = "Injecting";
                    return;

                case SxLibBase.SynAttachEvents.CHECKING_WHITELIST:
                    this.label1.Text = "Checking Whitelist";
                    return;

                case SxLibBase.SynAttachEvents.FAILED_TO_ATTACH:
                    this.label1.Text = "Failed To Attach";
                    return;

                case SxLibBase.SynAttachEvents.NOT_UPDATED:
                    this.label1.Text = "Not Updated";
                    return;

                case SxLibBase.SynAttachEvents.UPDATING_DLLS:
                    this.label1.Text = "Updating DLLs";
                    return;

                case SxLibBase.SynAttachEvents.ALREADY_INJECTED:
                    this.label1.Text = "Already Injected";
                    return;

                case SxLibBase.SynAttachEvents.READY:
                    this.label1.Text = "Ready!";
                    return;




            }


        }

        private void SynLoadEvent(SxLibBase.SynLoadEvents Event, object Param)
        {
            switch (Event)
            {
                case SxLibBase.SynLoadEvents.CHANGING_WL:
                    this.label1.Text = "Checking Whitelist";
                    return;

                case SxLibBase.SynLoadEvents.DOWNLOADING_DLLS:
                    this.label1.Text = "Downloading DLLS";
                    return;

                case SxLibBase.SynLoadEvents.UNAUTHORIZED_HWID:
                    this.label1.Text = "HWID Error";
                    return;

                case SxLibBase.SynLoadEvents.CHECKING_DATA:
                    this.label1.Text = "Checking Data";
                    return;



                case SxLibBase.SynLoadEvents.READY:
                    this.label1.Text = "Ready!";

                    return;

            }
        }

        private void skeetButton5_Click(object sender, EventArgs e)
        {
            //water wat = new water();
           // wat.Show();

         


            Functions.Lib.Attach();
            Functions.Lib.AttachEvent += SynAttachEvent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void skeetToggle1_CheckedChanged_1(object sender)
        {
            if (skeetToggle1.Checked == true)
            {
                this.TopMost = true;
            }
            if (skeetToggle1.Checked == false)
            {
                this.TopMost = false;
            }
        }

        private void skeetToggle2_CheckedChanged(object sender)
        {






            
            if (skeetToggle2.Checked == true)
            {
                
                string scr = skeetTextBox1.Text;
                Functions.Lib.Execute(scr);
            }
            if (skeetToggle2.Checked == false)
            {
                
            }
        }

        private void skeetTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
