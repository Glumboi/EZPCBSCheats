using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Memory;
using System.Threading;
using MaterialSkin;
using MaterialSkin.Controls;

namespace EZPCBSCheats
{
    public partial class Form1 : MaterialForm
    {
        static Mem m = new Mem();
        int PID = m.GetProcIdFromName("PCBS.exe");

        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange800, Primary.Orange800, Accent.Orange700, TextShade.WHITE);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hookprocess();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Add_Money_BN_Click(object sender, EventArgs e)
        {
            setmoney(true);
        }

        private void setmoney(bool error)
        {
            string text = Money_Textbox.Text;
            try
            {
                m.WriteMemory("mono.dll+0x0026A208,20,A0,F30,0,20,C0", "int", text);

            }
            catch (Exception)
            {
                if(error)
                {
                    MessageBox.Show("Something went very wrong! \nMake sure you entered a number or updated the app!\nAlso please make sure that PCBS is opened and the app is hooked to it.", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Freeze_Tick(object sender, EventArgs e)
        {
            setmoney(false);
        }

        private void hookprocess()
        {
            if (PID > 0)
            {
                m.OpenProcess(PID);
                materialLabel1.Text = "PCBS.exe is found and the cheat is attached...";
                //Thread th = new Thread();
                //th.Start();
            }
            else
            {
                MessageBox.Show("PCBS.exe is not launched please start PCBS and restart the app.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                materialLabel1.Text = "PCBS.exe is not started...";
            }
        }

        private void freezemoney_Cb_CheckedChanged(object sender, EventArgs e)
        {
            if(freezemoney_Cb.Checked)
            {
                Freeze.Start();
            }
            else
            {
                Freeze.Stop();
            }
        }
    }
}
