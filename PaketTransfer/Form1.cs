using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paket02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbHesap.SelectedIndex = 0;
            btnHesap.Click += btnTiklamalar;
            btnMesaj.Click += btnTiklamalar;
            btnNesne.Click += btnTiklamalar;
            btnResim.Click += btnTiklamalar;
        }

        void btnTiklamalar(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Name)
            {
                case "btnMesaj":
                    break;
                case "btnResim":
                    break;
                case "btnNesne":
                    break;
                case "btnHesap":
                    switch (cmbHesap.SelectedIndex)
                    {
                        case 0: //Topla
                            break;
                        case 1: //Çıkart
                            break;
                        case 2: //Çarp
                            break;
                        case 3: //Böl
                            break;
                    }
                    break;
            }

            TerminalIslem(null);
        }


        void TerminalIslem(byte[] veri)
        {

        }
    }
}
