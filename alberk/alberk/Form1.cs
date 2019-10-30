using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alberk
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        string[] sozluk;
        string isim;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sozluk = File.ReadAllLines("C:\\Users\\xx\\Desktop\\liste.txt");
            chromeGecisAlani();
            click();

            for(int i=0;i<sozluk.Length;i++)
            {
                Clipboard.Clear();
                asagiInTusu();
                click();
                Thread.Sleep(1000);
                click();
                Thread.Sleep(1000);
                click();
                Thread.Sleep(1000);
                click();
                Thread.Sleep(1000);
                firmaIsimYazAlani();
                click();
                SendKeys.Send("{BACKSPACE}");
                Thread.Sleep(1000);
                SendKeys.Send("{BACKSPACE}");
                Thread.Sleep(1000);
                SendKeys.Send("{BACKSPACE}");
                Thread.Sleep(1000);
                firmaAdiYaz(i);
                Thread.Sleep(1000);
                gonderAlani();
                click();
                consoleEkraniAlani();
                Thread.Sleep(1000);
                click();
                Thread.Sleep(1000);
                SendKeys.Send("^f");
                consoleYaziAramaAlani();
                click();
                SendKeys.Send("Bulunamadı");
                Thread.Sleep(1000);
                bulunamadiYazisiKopyalamaHazirligi();
                click();
                click();
                Thread.Sleep(1000);
                SendKeys.Send("^c");
                Thread.Sleep(1000);
                isim = Clipboard.GetText();
                if (isim.ToString()!="Bulunamadı")
                {
                    
                    var screenShot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
                    var gfxScreenShot = Graphics.FromImage(screenShot);

                    gfxScreenShot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
                    screenShot.Save("C:\\Users\\xx\\potMus\\resim"+i.ToString()+".png", ImageFormat.Png);
                    carpiAlani();
                    Thread.Sleep(1000);
                    click();
                    Thread.Sleep(500);

                }
              
                    
                    consoleYaziAramaAlani();
                    click();
                    click();
                    Thread.Sleep(1000);
                    SendKeys.Send("{BACKSPACE}");
                    Thread.Sleep(1000);
                    SendKeys.Send("{BACKSPACE}");
                    consoleYukariCikTusu();
                    click();
                    Thread.Sleep(500); click();
                Thread.Sleep(500); click();
                Thread.Sleep(500); click();
                Thread.Sleep(500); click();
                Thread.Sleep(500); click();
                    Thread.Sleep(500); click();
                    Thread.Sleep(500);
                    yukariCikTusu();
                    click();
                    Thread.Sleep(500);
                    click();
                    Thread.Sleep(500);
                    click();
                Thread.Sleep(500);
                click();
                Thread.Sleep(500);
                click();
                Thread.Sleep(500);
                click();
                Thread.Sleep(500);
                    click();
                Thread.Sleep(500);
                    click();
                    Thread.Sleep(500);
                    click();
                    Thread.Sleep(500);
                


                

            }

        }

        public void firmaAdiYaz(int numara)
        {
            SendKeys.Send(sozluk[numara]);
        }

        private void asagiInTusu()
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(1355, 720);
        }

        private void yukariCikTusu()
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(1353, 70);
        }

        private void consoleYukariCikTusu()
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(2400, 55);
        }

        public void click()
        {
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

        private void firmaIsimYazAlani()
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(620, 620);
        }

        private void gonderAlani()
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(590, 710);
        }

        private void consoleYaziAramaAlani()
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(1400, 750);
        }

        private void consoleEkraniAlani()
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(1400, 5);
        }

        private void carpiAlani()
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(1170, 85);
        }

        private void chromeGecisAlani()
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(1300, 20);
        }

        private void bulunamadiYazisiKopyalamaHazirligi()
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(1635, 714);
        }


    }
}
