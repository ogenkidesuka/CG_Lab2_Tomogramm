using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TomogrammVisualizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LOADED.Text = "ОЖИДАНИЕ ЗАГРУЗКИ";
            trackBar2.Value = -1000;
            trackBar3.Value = 1500;
            VAL_LAY.Text = trackBar1.Value.ToString();
            VAL_MIN.Text = trackBar2.Value.ToString();
            VAL_WIDTH.Text = trackBar3.Value.ToString();
        }

        Bin bin = new Bin();
        View view = new View();
        bool loaded = false;
        bool needReload = false;
        int currentLayer = 0;
        int FrameCount;
        DateTime NextFPSUpdate = DateTime.Now.AddSeconds(1);

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string str = dialog.FileName;
                bin.readBIN(str);
                view.SetupView(glControl1.Width, glControl1.Height);
                glControl1.Invalidate();
                loaded = true;
                needReload = true;
                LOADED.Text = "ЗАГРУЗКА ЗАВЕРШЕНА";
                trackBar1.Maximum = Bin.Z - 2;
            }
        }

        void DisplayFPS()
        {
            if (DateTime.Now >= NextFPSUpdate)
            {
                FPS.Text = String.Format("{0} FPS", FrameCount);
                NextFPSUpdate = DateTime.Now.AddSeconds(1);
                FrameCount = 0;
            }
            FrameCount++;
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            while (glControl1.IsIdle)
            {
                DisplayFPS();
                glControl1.Invalidate();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VSYNC_CheckedChanged(object sender, EventArgs e)
        {
            if (VSYNC.Checked == true)
            {
                glControl1.VSync = true;
            }
            if (VSYNC.Checked == false)
            {
                glControl1.VSync = false;
            }
            needReload = true;
            glControl1.Refresh();
            glControl1.Invalidate();
        }

        private void BY_TEXTURE_CheckedChanged(object sender, EventArgs e) {  }

        private void BY_QUADS_CheckedChanged(object sender, EventArgs e) {  }

        private void BY_TEXTURE_Click(object sender, EventArgs e)
        {
            if (BY_TEXTURE.Checked)
            {
                BY_QUADS.Checked = false;
                BY_TEXTURE.Checked = true;
                BY_QUADSTRIP.Checked = false;
            }
            needReload = true;
        }

        private void BY_QUADS_Click(object sender, EventArgs e)
        {
            if (BY_QUADS.Checked)
            {
                BY_QUADS.Checked = true;
                BY_TEXTURE.Checked = false;
                BY_QUADSTRIP.Checked = false;
            }
            needReload = true;
        }

        private void BY_QUADSTRIP_Click(object sender, EventArgs e)
        {
            if (BY_QUADSTRIP.Checked)
            {
                BY_QUADS.Checked = false;
                BY_TEXTURE.Checked = false;
                BY_QUADSTRIP.Checked = true;
            }
            needReload = true;
        }

        private void glControl1_Paint(object sender, PaintEventArgs e)
        {
            if(BY_TEXTURE.Checked)
            {
                Paint_Texture(sender, e);
            }
            else if (BY_QUADS.Checked)
            {
                //trackBar1.Maximum = Bin.Y - 1;
                Paint_Quads(sender, e);
            } else if(BY_QUADSTRIP.Checked)
            {
                Paint_QuadStrip(sender, e);
            }
        }

        private void Paint_Texture(object sender, PaintEventArgs e)
        {
            if (loaded)
            {
                if (needReload)
                {
                    view.generateTextureImage(currentLayer);
                    view.Load2DTexture();
                    needReload = false;
                }
                view.DrawTexture();
                glControl1.SwapBuffers();
            }
        }

        private void Paint_Quads(object sender, PaintEventArgs e)
        {
            if (loaded)
            {
                view.DrawQuads(currentLayer);
                glControl1.SwapBuffers();
            }
        }

        private void Paint_QuadStrip(object sender, PaintEventArgs e)
        {
            if (loaded)
            {
                view.DrawQuadStrip(currentLayer);
                glControl1.SwapBuffers();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            currentLayer = trackBar1.Value;
            needReload = true;
            VAL_LAY.Text = currentLayer.ToString();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(loaded)
            {
                needReload = true;
                view.SetupView(glControl1.Width, glControl1.Height);
                glControl1.Refresh();
                glControl1.Invalidate();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Application.Idle += Application_Idle;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            needReload = true;
            int GetMin = trackBar2.Value;
            view.SetMin(ref GetMin);
            VAL_MIN.Text = GetMin.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            needReload = true;
            int GetWidth = trackBar3.Value;
            view.SetWidth(ref GetWidth);
            VAL_WIDTH.Text = GetWidth.ToString();
        }

        private void VAL_MIN_TextChanged(object sender, EventArgs e)
        {
        }

        private void VAL_WIDTH_TextChanged(object sender, EventArgs e)
        {
        }

        private void VAL_LAY_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FPS_TextChanged(object sender, EventArgs e)
        {

        }

        private void glControl1_Load(object sender, EventArgs e)
        {

        }
    }
}
