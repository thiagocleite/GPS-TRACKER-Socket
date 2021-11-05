using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GPS1Visual
{
    public partial class Alarme : Form
    {
        public Alarme(string frase)
        {
            InitializeComponent();
            labelFrase.Text = frase;
        }

        // FLAGS DE SOM
        [System.Flags]
        public enum PlaySoundFlags : int
        {
            SND_SYNC = 0x0000,
            SND_ASYNC = 0x0001,
            SND_NODEFAULT = 0x0002,
            SND_LOOP = 0x0008,
            SND_NOSTOP = 0x0010,
            SND_NOWAIT = 0x00002000,
            SND_FILENAME = 0x00020000,
            SND_RESOURCE = 0x00040004
        }


        // IMPORTAÇÃO DO COMPONENTE DE SOM
        [DllImport("winmm.dll", EntryPoint = "PlaySound", SetLastError = true, CharSet = CharSet.Unicode, ThrowOnUnmappableChar = true)]
        public static extern bool PlaySound(string szSound, System.IntPtr hMod, PlaySoundFlags flags);

        private void Alarme_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PlaySound(@"alarm_3.wav", new System.IntPtr(), PlaySoundFlags.SND_ASYNC);
        }

        private void buttonStopAll_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (labelFrase.Visible)
            {
                labelFrase.Visible = false;
            }
            else
            {
                labelFrase.Visible = true;
            }
        }
    }
}
