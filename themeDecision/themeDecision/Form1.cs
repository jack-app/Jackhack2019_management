using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Collections.Generic;

namespace themeDecision
{
    public partial class Form1 : Form
    {

        private string[] theme = { "!", "現実を拡張せよ！", "放置して見ていると楽しいもの\n（多少操作してもOK）",
                                    "ボール", "面倒くさいが楽になる", " 行列を楽しめるプロダクト  \n（ゲーム禁止）",
                                    "     ファミレスで使える     \nアプリ・サービス" };
        private bool onlyone = false;
        private List<string> team = new List<string>{ "A", "B", "C", "D", "E", "F", "G" };
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
                textBox1.Text = theme[Math.Abs(BitConverter.ToInt32(bs, 0)) % theme.Length];
                onlyone = true;
            }
        }
        private void Clicked2(object sender, EventArgs e)
        {
            
            if (!onlyone)
            {
                string text = "";
                byte[] bs = new byte[4];
                RNGCryptoServiceProvider rand = new RNGCryptoServiceProvider();
                while(team.Count != 1)
                {
                    rand.GetBytes(bs);
                    text += team[Math.Abs(BitConverter.ToInt32(bs, 0)) % team.Count];
                    text += "→";
                    team.RemoveAt(Math.Abs(BitConverter.ToInt32(bs, 0)) % team.Count);
                }
                rand.Dispose();
                text += team[0];
                textBox1.Text = text;
                onlyone = true;
            }
        }
    }
}
