using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        BTDeviceSelector bTDeviceSelector = new BTDeviceSelector();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bTDeviceSelector.ShowDialog();
        }

        private void button19_Click(object sender, EventArgs e)
        {
			try
			{
				BTController.shutdown_gamepad();
                Task.Factory.StartNew(delegate ()
                {
                    //GlobalVar.BTSTARTED = true;
                    BTController.start_gamepad();
                    //GlobalVar.BTSTARTED = false;
                });
            }
			catch (Exception)
			{
			}
		}

        private void button8_Click(object sender, EventArgs e)
        {
            for(int i =0;i<5;i++)
            {
                BTController.send_button(0x8, 16);
                Thread.Sleep(1);
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                BTController.send_button(0x4, 16);
                Thread.Sleep(1);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                BTController.send_button(0x2, 16);
                Thread.Sleep(1);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                BTController.send_button(0x1, 16);
                Thread.Sleep(1);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                BTController.send_button(0x40, 16);
                Thread.Sleep(1);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                BTController.send_button(0x80, 16);
                Thread.Sleep(1);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                BTController.send_button(0x100, 16);
                Thread.Sleep(1);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                BTController.send_button(0x200, 16);
                Thread.Sleep(1);
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                BTController.send_button(0x400, 16);
                Thread.Sleep(1);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                BTController.send_button(0x800, 16);
                Thread.Sleep(1);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                BTController.send_button(0x10000, 16);
                Thread.Sleep(1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                BTController.send_button(0x20000, 16);
                Thread.Sleep(1);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                BTController.send_button(0x40000, 16);
                Thread.Sleep(1);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                BTController.send_button(0x80000, 16);
                Thread.Sleep(1);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                BTController.send_button(0x400000, 16);
                Thread.Sleep(1);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                BTController.send_button(0x800000, 16);
                Thread.Sleep(1);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                BTController.send_button(0x1000, 16);
                Thread.Sleep(1);
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                BTController.send_button(0x2000, 16);
                Thread.Sleep(1);
            }
        }
    }
}
