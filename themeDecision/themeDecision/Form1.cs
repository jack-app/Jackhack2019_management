using System;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace themeDecision
{
    public partial class Form1 : Form
    {

        private string[] theme = { "!", "現実を拡張せよ！", "放置して見ていると楽しいもの\n（多少操作してもOK）",
                                    "ボール", "面倒くさいが楽になる", "行列を楽しめるプロダクト   \n（ゲーム禁止）",
                                    "5" };
        private bool onlyone = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Clicked(object sender, EventArgs e)
        {
            if (!onlyone)
            {
                byte[] bs = new byte[4];
                RNGCryptoServiceProvider rand = new RNGCryptoServiceProvider();
                rand.GetBytes(bs);
                rand.Dispose();
                System.Diagnostics.Trace.WriteLine(BitConverter.ToUInt32(bs, 0));
                textBox1.Text = theme[BitConverter.ToUInt32(bs, 0) % 7];
                onlyone = true;
            }
        }
    }
}
