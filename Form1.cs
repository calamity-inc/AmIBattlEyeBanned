using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;
using System.Net.Http;

namespace AmIBattlEyeBanned
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string computeBeId(long rid)
        {
            using (var md5 = MD5.Create())
            {
                byte[] digest = md5.ComputeHash(Encoding.ASCII.GetBytes("BE" + Convert.ToBase64String(Encoding.UTF8.GetBytes(rid.ToString()))));
                string hexDigest = "";
                for (int i = 0; i != digest.Length; ++i)
                {
                    hexDigest += digest[i].ToString("x2").ToLower();
                }
                return hexDigest;
            }
        }

        private string checkBanReason(long rid)
        {
            using (var client = new UdpClient())
            {
                // "Connect" to paradise1.battleye.com
                IPEndPoint ep = new IPEndPoint(IPAddress.Parse("51.89.97.102"), 61455);
                client.Connect(ep);

                // Send
                var outgoingData = new byte[4];
                var rng = new Random();
                for (int i = 0; i != outgoingData.Length; ++i)
                {
                    outgoingData[i] = (byte)rng.Next(0, 256);
                }
                outgoingData = outgoingData.Concat(Encoding.UTF8.GetBytes(computeBeId(rid))).ToArray();
                client.Send(outgoingData, outgoingData.Length);

                // Send
                byte[] receivedData = client.Receive(ref ep);
                return Encoding.ASCII.GetString(receivedData.Skip(4).ToArray());
            }
        }

        private void bancheck_btn_Click(object sender, EventArgs e)
        {
            long rid;
            if (long.TryParse(bancheck_input.Text, out rid))
            {
                var ban_reason = checkBanReason(rid);
                if (ban_reason == "")
                {
                    bancheck_status.Text = "RID " + rid + " is not banned.";
                }
                else
                {
                    bancheck_status.Text = ban_reason;
                }
            }
            else
            {
                bancheck_input.Text = "Invalid input.";
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://amibattleyebanned.com/resolve-rid-steps.png");
        }

        private async void name2rid_btn_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string content = await client.GetStringAsync("https://sc-cache.com/n/" + name2rid_input.Text);
                    if (content.Substring(0, 6) == "{\"id\":")
                    {
                        bancheck_input.Text = content.Substring(6, content.IndexOf(',') - 6);
                        name2rid_status.Text = "Filled in RID!";
                        linkLabel1.Visible = false;
                        return;
                    }
                }
                catch (Exception)
                {
                }
                name2rid_status.Text = "Not in cache.";
                linkLabel1.Visible = true;
            }
        }
    }
}
