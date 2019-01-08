using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Qapp_rev1_0_1.Global;
using static Qapp_rev1_0_1.Developer;

namespace Qapp_rev1_0_1 {
    public partial class Startup : Form {
        private bool mouseDown;
        private Point lastLocation;
        private bool openProgramCheck;
        private bool openUploadCheck;
        private bool openOpenCheck;

        public Startup() {
            InitializeComponent();
            buttNewCreate.MouseEnter += buttNewCreate_MouseEnter;
            buttNewCreate.MouseLeave += buttNewCreate_MouseLeave;
        }

        private void Startup_Load(object sender, EventArgs e) {
            //openCheck on Startup = False
            //New Program, Upload and Open will be collapsed
            openProgramCheck = false;
            openUploadCheck = false;
            openOpenCheck = false;

            // Top-Right Exit (X) Button
            // hide border
            buttExit.TabStop = false;
            buttExit.FlatStyle = FlatStyle.Flat;
            buttExit.FlatAppearance.BorderSize = 0;

            // Top-Right Minimize (-) Button
            // hide border
            buttMinimize.TabStop = false;
            buttMinimize.FlatStyle = FlatStyle.Flat;
            buttMinimize.FlatAppearance.BorderSize = 0;

            //setup colors
            ToolStripProfessionalRenderer dark = new ToolStripProfessionalRenderer(new MyColorTable(Color.FromArgb(64, 64, 64)));
            ToolStripProfessionalRenderer dimgray = new ToolStripProfessionalRenderer(new MyColorTable(Color.DimGray));

            //setup toolstrip default hover color
            ToolStripManager.Renderer = dark;

        }
        private void buttExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Startup_MouseDown(object sender, MouseEventArgs e) {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Startup_MouseMove(object sender, MouseEventArgs e) {
            if (mouseDown) {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X,
                (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Startup_MouseUp(object sender, MouseEventArgs e) {
            mouseDown = false;
        }

        private void buttMinimize_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private void labelNewProgram_Click(object sender, EventArgs e) {
            openProgramCheck = true;
            panelNewProgram.Visible = true;
            panelUploadProgram.Visible = false;
            panelOpenProgram.Visible = false;
            labelNewProgram.ForeColor = Color.WhiteSmoke;
            labelUpload.Location = new Point(48, 234);
            labelUpload.ForeColor = Color.Silver;
            labelOpen.Location = new Point(48, 274);
            labelOpen.ForeColor = Color.Silver;
        }
        private void labelUploadProgram_Click(object sender, EventArgs e) {
            openUploadCheck = true;
            panelNewProgram.Visible = false;
            panelUploadProgram.Visible = true;
            panelOpenProgram.Visible = false;
            labelNewProgram.ForeColor = Color.Silver;
            labelUpload.Location = new Point(48, 159);
            labelUpload.ForeColor = Color.WhiteSmoke;
            labelOpen.Location = new Point(48, 245);
            labelOpen.ForeColor = Color.Silver;
        }
        private void labelOpenProgram_Click(object sender, EventArgs e) {
            openOpenCheck = true;
            panelNewProgram.Visible = false;
            panelUploadProgram.Visible = false;
            panelOpenProgram.Visible = true;
            labelNewProgram.ForeColor = Color.Silver;
            labelUpload.Location = new Point(48, 159);
            labelUpload.ForeColor = Color.Silver;
            labelOpen.Location = new Point(48, 205);
            labelOpen.ForeColor = Color.WhiteSmoke;
        }
        private void dropTelsec_SelectedValueChanged(object sender, EventArgs e) {
            
        }

        private void buttNewCreate_MouseEnter(object sender, EventArgs e) {
                buttNewCreate.BackColor = Color.Gray;
                buttUpload.BackColor = Color.Gray;
                buttOpen.BackColor = Color.Gray;
        }
        private void buttNewCreate_MouseLeave(object sender, EventArgs e) {
            buttNewCreate.BackColor = Color.FromArgb(64, 64, 64);
            buttUpload.BackColor = Color.FromArgb(64, 64, 64);
            buttOpen.BackColor = Color.FromArgb(64, 64, 64);

        }
    }
}
