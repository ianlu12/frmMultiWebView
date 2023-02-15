using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmMultiWebView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            init();
        }
        async void init() {
            webView21.CreationProperties =
            new Microsoft.Web.WebView2.WinForms.CoreWebView2CreationProperties();
            webView21.CreationProperties.UserDataFolder = System.IO.Path.Combine(
                Application.StartupPath, $"webView1");
            await webView21.EnsureCoreWebView2Async();
            webView21.CoreWebView2.Navigate("https://swordgale.online/");
            webView22.CreationProperties =
            new Microsoft.Web.WebView2.WinForms.CoreWebView2CreationProperties();
            webView22.CreationProperties.UserDataFolder = System.IO.Path.Combine(
                Application.StartupPath, $"webView2");
            await webView22.EnsureCoreWebView2Async();
            webView22.CoreWebView2.Navigate("https://swordgale.online/");

            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            var viewHeight = this.Height - 125;
            this.webView21.Height = viewHeight;
            this.webView22.Height = viewHeight;
            var viewWidth = (this.Width - 25 * 2 - 5 * (2 - 1)) / 2;
            this.webView21.Width = viewWidth;
            webView22.Left = this.webView21.Left + this.webView21.Width + 5;
            this.webView22.Width = viewWidth;
        }
    }
}
