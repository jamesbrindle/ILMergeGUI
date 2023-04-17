namespace ILMergeGui
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    /// <summary>
    /// About Dialog.
    /// </summary>
    public partial class AboutDialog : Form
    {
        [DllImport("shcore.dll")]
        static extern int SetProcessDpiAwareness(_Process_DPI_Awareness value);
        enum _Process_DPI_Awareness
        {
            Process_DPI_Unaware = 0,
            Process_System_DPI_Aware = 1,
            Process_Per_Monitor_DPI_Aware = 2
        }

        const String picasadownloader_at_codeplex = "http://ilmergegui.codeplex.com";
        const String picasadownloader_mailto = "mailto:wim@vander-vegt.nl?SUBJECT=Suggestion for ILMergeGui";
        const String paypal_picasadownloader = "https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=84Y4JSJE47R7J";

        /// <summary>
        /// Constructor.
        /// </summary>
        public AboutDialog()
        {
            SetProcessDpiAwareness(_Process_DPI_Awareness.Process_System_DPI_Aware);
            InitializeComponent();

            textBox1.Text = String.Format(textBox1.Text, Assembly.GetExecutingAssembly().GetName().Version);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(paypal_picasadownloader);
            }
            catch (Win32Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(picasadownloader_at_codeplex);
            }
            catch (Win32Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(picasadownloader_mailto);
            }
            catch (Win32Exception e1)
            {
                MessageBox.Show(e1.Message);
            }
        }
    }
}
