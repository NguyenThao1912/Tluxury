using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TLuxury.Forms
{
    public partial class MainForm : Form
    {
        private Panel curPannelDrop;
        private Form ActiveForms;
        private Button ActiveButtons;
        public MainForm()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void timerClose_Tick(object sender, EventArgs e)
        {
            //toc do thu thanh cuon
            curPannelDrop.Height -= 5;
            if (curPannelDrop.Size == curPannelDrop.MinimumSize)
            {
                timerClose.Stop();
            }
        }
        private void timerOpen_Tick(object sender, EventArgs e)
        {
            curPannelDrop.Height += 5;
            if (curPannelDrop.Size == curPannelDrop.MaximumSize)
            {
                timerOpen.Stop();
            }
        }
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void buttonCLose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonBaoCao_Click(object sender, EventArgs e)
        {
            if (timerOpen.Enabled == true)
                return;
            if (timerClose.Enabled == true)
                return;
            if (curPannelDrop != null)
                timerClose.Start();
            curPannelDrop = panelDropdownRP;
            timerOpen.Start();
        }
        private void buttonDoiTac_Click(object sender, EventArgs e)
        {
            if (timerOpen.Enabled == true)
                return;
            if (timerClose.Enabled == true)
                return;
            if (curPannelDrop != null)
                timerClose.Start();
            curPannelDrop = panelDropdown_DoiTac;
            timerOpen.Start();
        }
        private void buttonGiaoDich_Click(object sender, EventArgs e)
        {
            if (timerOpen.Enabled == true)
                return;
            if (timerClose.Enabled == true)
                return;
            if (curPannelDrop != null)
                timerClose.Start();
            curPannelDrop = panelDropdownGiaoDich;
            timerOpen.Start();
        }
        //di chuot doi mau
        private void Hover(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            a.BackColor = Color.FromArgb(98, 109, 140);
        }
        //bo chuot mau tro lai
        private new void Leave(object sender, EventArgs e)
        {
            Button a = (Button)sender;
            a.BackColor = Color.FromArgb(0, 41, 60);
        }
        //phong to thu nho cua so
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        private void OpenChildForm(Form childForm,Button sender)
        {
            if (ActiveButtons != null && ActiveButtons.Text == sender.Text)
                return;
            if (ActiveForms != null)
                ActiveForms.Dispose();
            ActiveForms = childForm;
            ActiveButtons = sender;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;    
            this.panelContent.Controls.Add(childForm);
            this.panelContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void buttonHangHoa_Click(object sender, EventArgs e)
        {
          
        }
        private void buttonDT_KhachHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CF_Customer(),(Button) sender);
        }

        private void buttonDT_NhaCungCap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CF_Supplier(), (Button)sender);
        }

        private void buttonBanHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CF_BANHANG(), (Button)sender);
        }

        private void buttonHD_Ban_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CF_HOADON(), (Button)sender);
        }

        private void buttonHD_Nhap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CF_EntryInvoice(), (Button)sender);
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CF_Employee(), (Button)sender);
        }
    }
}
