using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace media_calculator
{

    public partial class form_home : Form
    {

        private bool mousedown;
        private Point lastLocation;
        // Retrieve values on form load
        int movies_save = Properties.Settings.Default.movies;
        int shows_save = Properties.Settings.Default.shows;
        int stage_dramas_save = Properties.Settings.Default.stage_dramas;

        public form_home()
        {
            InitializeComponent();
        }

        private void form_home_Load(object sender, EventArgs e)
        {
            tb_m_cu.Focus();

            // Use these values as needed, e.g., displaying them in TextBoxes
            tb_m_cu.Text = movies_save.ToString();
            tb_s_cu.Text = shows_save.ToString();
            tb_sd_cu.Text = stage_dramas_save.ToString();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            tb_m_add.Clear();
            tb_m_new.Clear();
            tb_s_add.Clear();
            tb_s_new.Clear();
            tb_sd_add.Clear();
            tb_sd_new.Clear();

            movies_save = Properties.Settings.Default.movies;
            shows_save = Properties.Settings.Default.shows;
            stage_dramas_save = Properties.Settings.Default.stage_dramas;

            tb_m_cu.Text = movies_save.ToString();
            tb_s_cu.Text = shows_save.ToString();
            tb_sd_cu.Text = stage_dramas_save.ToString();

            tb_m_add.Text = "0";
            tb_s_add.Text = "0";
            tb_sd_add.Text = "0";

            tb_m_cu.Focus();
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            try
            {
                int m = Convert.ToInt32(tb_m_cu.Text) + Convert.ToInt32(tb_m_add.Text);
                int s = Convert.ToInt32(tb_s_cu.Text) + Convert.ToInt32(tb_s_add.Text);
                int sd = Convert.ToInt32(tb_sd_cu.Text) + Convert.ToInt32(tb_sd_add.Text);

                tb_m_new.Text = m.ToString();
                tb_s_new.Text = s.ToString();
                tb_sd_new.Text = sd.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void form_home_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void form_home_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
            lastLocation = e.Location;
        }

        private void form_home_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
            lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int movies_save = int.Parse(tb_m_new.Text);
            int shows_save = int.Parse(tb_s_new.Text);
            int stage_dramas_save = int.Parse(tb_sd_new.Text);

            Properties.Settings.Default.movies = movies_save;
            Properties.Settings.Default.shows = shows_save;
            Properties.Settings.Default.stage_dramas = stage_dramas_save;

            Properties.Settings.Default.Save();

        }

        private void btn_clear_mem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.movies = int.Parse("-1");
            Properties.Settings.Default.shows = int.Parse("-1");
            Properties.Settings.Default.stage_dramas = int.Parse("-1");

            Properties.Settings.Default.Save();
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.movies = int.Parse("0");
            Properties.Settings.Default.shows = int.Parse("0");
            Properties.Settings.Default.stage_dramas = int.Parse("0");

            Properties.Settings.Default.Save();
        }

        private void tb_m_add_Click(object sender, EventArgs e)
        {
            tb_m_add.Clear();
        }

        private void tb_s_add_Click(object sender, EventArgs e)
        {
            tb_s_add.Clear();
        }

        private void tb_sd_add_Click(object sender, EventArgs e)
        {
            tb_sd_add.Clear();
        }

    }
}
