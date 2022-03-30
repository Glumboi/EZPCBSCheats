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
using System.Runtime.InteropServices;

namespace EZPCBSCheats
{
    public partial class Form1 : MaterialForm
    {
        static Mem m = new Mem();
        int PID = m.GetProcIdFromName("PCBS.exe");

        //Extern methods used to manage hotkeys
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        //Hotkeys
        private const int ACTION_HOTKEY_ID = 1;
        private const int ACTION_HOTKEY_ID2 = 2;
        private const int ACTION_HOTKEY_ID3 = 3;
        private const int ACTION_HOTKEY_ID4 = 4;
        private const int ACTION_HOTKEY_ID5 = 5;
        private const int ACTION_HOTKEY_ID6 = 6;
        private const int ACTION_HOTKEY_ID7 = 7;
        private const int ACTION_HOTKEY_ID8 = 8;
        private const int ACTION_HOTKEY_ID9 = 9;
        private const int ACTION_HOTKEY_ID10 = 10;

        Form form = new Hotkeys();

        public Form1()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange800, Primary.Orange800, Primary.Orange800, Accent.Orange700, TextShade.WHITE);
        }

        private void loadhotkeys()
        {
            RegisterHotKey(this.Handle, ACTION_HOTKEY_ID, 2, (int)Keys.M);
            RegisterHotKey(this.Handle, ACTION_HOTKEY_ID2, 2, (int)Keys.A);
            RegisterHotKey(this.Handle, ACTION_HOTKEY_ID3, 2, (int)Keys.X);
            RegisterHotKey(this.Handle, ACTION_HOTKEY_ID4, 3, (int)Keys.X);
            RegisterHotKey(this.Handle, ACTION_HOTKEY_ID5, 6, (int)Keys.X);
            RegisterHotKey(this.Handle, ACTION_HOTKEY_ID6, 2, (int)Keys.OemMinus);
            RegisterHotKey(this.Handle, ACTION_HOTKEY_ID7, 3, (int)Keys.A);
            RegisterHotKey(this.Handle, ACTION_HOTKEY_ID8, 3, (int)Keys.OemMinus);
            RegisterHotKey(this.Handle, ACTION_HOTKEY_ID9, 2, (int)Keys.Oemplus);
            RegisterHotKey(this.Handle, ACTION_HOTKEY_ID10, 3, (int)Keys.Oemplus);
        }

        //This method handles all the hotkey actions
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == ACTION_HOTKEY_ID)
            {
                string moneyamount = Money_Textbox.Text;
                setmoney(true);
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == ACTION_HOTKEY_ID2)
            {
                addmoney("1000");
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == ACTION_HOTKEY_ID3)
            {
                addxp("5000");
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == ACTION_HOTKEY_ID4)
            {
                addxp("50000");
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == ACTION_HOTKEY_ID5)
            {
                string xptoadd = Xp_Textbox.Text;
                addxp(xptoadd);
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == ACTION_HOTKEY_ID6)
            {
                subtractxp("5000");
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == ACTION_HOTKEY_ID7)
            {
                addmoney("10000");
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == ACTION_HOTKEY_ID8)
            {
                subtractxp("50000");
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == ACTION_HOTKEY_ID9)
            {
                subtractmoney("1000");
            }
            else if (m.Msg == 0x0312 && m.WParam.ToInt32() == ACTION_HOTKEY_ID10)
            {
                subtractmoney("10000");
            }
            base.WndProc(ref m);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            hookprocess();
            loadhotkeys();
            
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
                m.WriteMemory("UnityPlayer.dll+0x01539738,28,3F0,A0,F30,0,20,C0", "int", text);

            }
            catch (Exception)
            {
                if(error)
                {
                    MessageBox.Show("Something went very wrong! \nMake sure you entered a number or updated the app!\nAlso please make sure that PCBS is opened and the app is hooked to it.", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addxp(string xp)
        {     
            try
            {
                int xp_str = Int32.Parse(xp);
                int currentxp = m.ReadInt("UnityPlayer.dll+0x0153A760,0,200,A0,F30,0,20,BC");
                int xptoadd = currentxp + xp_str;
                m.WriteMemory("UnityPlayer.dll+0x0153A760,0,200,A0,F30,0,20,BC", "int", $"{xptoadd}");
            }
            catch
            {
                MessageBox.Show("Something went very wrong! \nMake sure you entered a number or updated the app!\nAlso please make sure that PCBS is opened and the app is hooked to it.", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void subtractxp(string xp)
        {
            
            try
            {
                int xp_str = Int32.Parse(xp);
                int currentxp = m.ReadInt("UnityPlayer.dll+0x0153A760,0,200,A0,F30,0,20,BC");
                int xptoadd = currentxp - xp_str;
                m.WriteMemory("UnityPlayer.dll+0x0153A760,0,200,A0,F30,0,20,BC", "int", $"{xptoadd}");
            }
            catch
            {
                MessageBox.Show("Something went very wrong! \nMake sure you entered a number or updated the app!\nAlso please make sure that PCBS is opened and the app is hooked to it.", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void freezeXp()
        {
            try
            {
                int currentxp = m.ReadInt("UnityPlayer.dll+0x0153A760,0,200,A0,F30,0,20,BC");
                m.FreezeValue("UnityPlayer.dll+0x0153A760,0,200,A0,F30,0,20,BC", "int", $"{currentxp}");
            }
            catch
            {
                MessageBox.Show("Something went very wrong! \nMake sure you entered a number or updated the app!\nAlso please make sure that PCBS is opened and the app is hooked to it.", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void unfreezexp()
        {
            try
            {
                m.UnfreezeValue("UnityPlayer.dll+0x0153A760,0,200,A0,F30,0,20,BC");
            }
            catch
            {
                MessageBox.Show("Something went very wrong! \nMake sure you entered a number or updated the app!\nAlso please make sure that PCBS is opened and the app is hooked to it.", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getcurrentxp()
        {
        }

        private void Freeze_money_Tick(object sender, EventArgs e)
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
                freezeMoney();
                //Freeze_money.Start();
            }
            else
            {
                UnfreezeMoney();
                //Freeze_money.Stop();
            }
        }

        private void freezeMoney()
        {
            try
            {
                int currentxp = m.ReadInt("UnityPlayer.dll+0x01539738,28,3F0,A0,F30,0,20,C0");
                m.FreezeValue("UnityPlayer.dll+0x01539738,28,3F0,A0,F30,0,20,C0", "int", $"{currentxp}");
            }
            catch
            {
                MessageBox.Show("Something went very wrong! \nMake sure you entered a number or updated the app!\nAlso please make sure that PCBS is opened and the app is hooked to it.", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UnfreezeMoney()
        {
            try
            {
                m.UnfreezeValue("UnityPlayer.dll+0x01539738,28,3F0,A0,F30,0,20,C0");
            }
            catch
            {
                MessageBox.Show("Something went very wrong! \nMake sure you entered a number or updated the app!\nAlso please make sure that PCBS is opened and the app is hooked to it.", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_50000_Xp_BN_Click(object sender, EventArgs e)
        {
            addxp("50000");
        }

        private void Add_5000_Xp_BN_Click(object sender, EventArgs e)
        {
            addxp("5000");
        }

        private void Add_Xp_BN_Click(object sender, EventArgs e)
        {
            string xptoadd = Xp_Textbox.Text;
            addxp(xptoadd);
        }

        private void freezexp_Cb_CheckedChanged(object sender, EventArgs e)
        {
            if (freezexp_Cb.Checked)
            {
                 freezeXp();   
            }
            else
            {   
                 unfreezexp();   
            }
        }

        private void Subtract_50000_Xp_BN_Click(object sender, EventArgs e)
        {
            subtractxp("50000");
        }

        private void Subtract_5000_Xp_BN_Click(object sender, EventArgs e)
        {
            subtractxp("5000");
        }

        //used later
        private void Update_Tick(object sender, EventArgs e)
        {
        }

        private void addmoney(string moneytoadd)
        {
            //Old pointer kept for testing
            //"mono.dll+0x0026A208,20,A0,F30,0,20,C0", "int", text
            try
            {
                int money_str = Int32.Parse(moneytoadd);
                int currentmoney = m.ReadInt("UnityPlayer.dll+0x01539738,28,3F0,A0,F30,0,20,C0");
                int moneytoadd_final = currentmoney + money_str;
                m.WriteMemory("UnityPlayer.dll+0x01539738,28,3F0,A0,F30,0,20,C0", "int", $"{moneytoadd_final}");
            }
            catch
            {
                MessageBox.Show("Something went very wrong! \nMake sure you entered a number or updated the app!\nAlso please make sure that PCBS is opened and the app is hooked to it.", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void subtractmoney(string moneytoadd)
        {
            
            //Old pointer kept for testing
            //"mono.dll+0x0026A208,20,A0,F30,0,20,C0", "int", text
            try
            {
                int money_str = Int32.Parse(moneytoadd);
                int currentmoney = m.ReadInt("mono.dll+0x0026A208,20,A0,F30,0,20,C0");
                int moneytoadd_final = currentmoney - money_str;
                m.WriteMemory("UnityPlayer.dll+0x01539738,28,3F0,A0,F30,0,20,C0", "int", $"{moneytoadd_final}");
            }
            catch
            {
                MessageBox.Show("Something went very wrong! \nMake sure you entered a number or updated the app!\nAlso please make sure that PCBS is opened and the app is hooked to it.", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Add_10000_Money_BN_Click(object sender, EventArgs e)
        {
            addmoney("10000");
        }

        private void Subtract_1000_Money_BN_Click(object sender, EventArgs e)
        {
            subtractmoney("1000");
        }

        private void Subtract_10000_Money_BN_Click(object sender, EventArgs e)
        {
            subtractmoney("10000");
        }

        private void Add_1000_Money_BN_Click(object sender, EventArgs e)
        {
            addmoney("1000");
        }

        private void Show_Hotkeys_BN_Click(object sender, EventArgs e)
        {
            form.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
