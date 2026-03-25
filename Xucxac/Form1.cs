using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xucxac
{
    public partial class Form1 : Form
    {

        string pathImg;
        int nChoose, nWin, nCount,nLose ;
        Random ranđ = new Random();
        
       

        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

       

        private void lbCount_Click(object sender, EventArgs e)
        {

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void Init()
        {
            pathImg = Application.StartupPath + @"\Hinhxucxac\";
            nChoose = 1;
            nCount = nWin = nLose = 0;
            picChoose.Image = Image.FromFile(pathImg + "1.png");
            picResult.Image = null;
            lbCount.Text = lbWin.Text = lbLose.Text = "";
            listResult.Items.Clear();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            nChoose = int.Parse(bt.Text);
            picChoose.Image = Image.FromFile(pathImg+nChoose.ToString() + ".png");

        }

        private void Play()
        {
            int n = ranđ.Next(1, 7);
            picResult.Image = Image.FromFile(pathImg + n.ToString() + ".png");
            nCount++;

            string kq = "Thua";
            if (n == nChoose)//Dung
            {
                nWin++;
                kq = "Thắng";
            }
            else
            {
                nLose++;
                kq = "Thua";
            }

            // Cap nhat thong ke 
            lbCount.Text = string.Format("Lần đoán thứ: {0}", nCount);
            lbWin.Text = string.Format("Lần Thắng: {0} ({1:0.00}%)", nWin, (double)nWin * 100 / nCount);
            lbLose.Text = string.Format("Lần Thua: {0} ({1:0.00}%)", nLose, (double)nLose * 100 / nCount);
            listResult.Items.Add(String.Format("{0}. {1} (Đoán {2} ra {3})", nCount, kq, nChoose, n));

        }

        private void btQuayso_Click(object sender, EventArgs e)
        {
           
            Play();
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter: Play(); break;
                    case Keys.Escape: Init(); break;
            }
            return false;
        }
    }
}
