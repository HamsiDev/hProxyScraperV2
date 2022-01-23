using Leaf.xNet;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hProxyScraperV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            siticoneShadowForm1.SetShadowForm(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            String url = "https://api.proxyscrape.com/v2/?request=displayproxies&protocol=";
            url = url + siticoneRoundedComboBox1.SelectedItem + "&timeout=" + siticoneRoundedTextBox1.Text + "&country=" + siticoneRoundedComboBox4.SelectedItem + "&ssl=" + siticoneRoundedComboBox3.SelectedItem + "all&anonymity=" + siticoneRoundedComboBox2.SelectedItem;
            WebClient client = new WebClient();
            String list = client.DownloadString(url);
            WebClient client2 = new WebClient();
            String list2 = client.DownloadString("https://api.proxyscrape.com/?request=lastupdated&proxytype=");

            siticoneTextBox1.Text = list;
            int count = siticoneTextBox1.Lines.Count();
            siticoneLabel10.Text = count.ToString();
            siticoneLabel11.Text = list2;
        }

        private void siticoneGradientButton4_Click(object sender, EventArgs e)
        {
            siticoneTextBox1.Clear();
        }

        private void siticoneGradientButton3_Click(object sender, EventArgs e)
        {
            string currentTime = DateTime.Now.ToString("dd-MM-yyyy h-mm-ss");

            string filepath = "SavedProxy\\"+currentTime+"-Proxy.txt";
            Directory.CreateDirectory("SavedProxy");
            File.WriteAllText(filepath, siticoneTextBox1.Text);
        }

        private void siticonePanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void siticoneCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            siticoneCheckBox2.Checked = false;
            siticoneCheckBox3.Checked = false;
        }

        private void siticoneCheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            siticoneCheckBox1.Checked = false;
            siticoneCheckBox3.Checked = false;
        }

        private void siticoneCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            siticoneCheckBox1.Checked = false;
            siticoneCheckBox2.Checked = false;
        }

        private void siticoneButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneButton2.Checked == true)
            {
                siticoneLabel2.Text = "Proxy Scraper";
            }
        }

        private void siticoneButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneButton3.Checked == true)
            {
                siticoneLabel2.Text = "Proxy Checker";
            }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneButton4.Checked == true)
            {
                siticoneLabel2.Text = "About";
            }
        }

        private void siticoneButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (siticoneButton1.Checked == true)
            {
                siticoneLabel2.Text = "Main Page";
            }
        }


        private void siticoneGradientButton5_Click(object sender, EventArgs e)
        {

        }

        private void siticoneGradientButton7_Click(object sender, EventArgs e)
        {
            String proxylist = listBox1.Items.;

        }

        string strIP = "10.0.0.0";
        int intPort = 12345;

        public static bool PingHost(string strIP, int intPort)
        {
            bool blProxy = false;
            try
            {
                TcpClient client = new TcpClient(strIP, intPort);
                MessageBox.Show("Succes:'" + strIP + ":" + intPort.ToString() + "'");

                blProxy = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error pinging host:'" + strIP + ":" + intPort.ToString() + "'");
                return false;
            }
            return blProxy;
        }

        public void Proxy()
        {
            bool tt = PingHost(strIP, intPort);
            if (tt == true)
            {
                MessageBox.Show("tt True");
            }
            else
            {
                MessageBox.Show("tt False");
            }
        }
    }
}
