using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace RunHijacker {
    public partial class frmMainForm : Form {
        // Ugly, I know. Something weird with line endings made me not able to figure out how to actually get regedit to accept manual .reg files I created, so I am just using a template one generated from regedit.exe.
        static string write = Encoding.UTF8.GetString(Convert.FromBase64String("V2luZG93cyBSZWdpc3RyeSBFZGl0b3IgVmVyc2lvbiA1LjAwDQoNCltIS0VZX0xPQ0FMX01BQ0hJTkVcU09GVFdBUkVcTWljcm9zb2Z0XFdpbmRvd3MgTlRcQ3VycmVudFZlcnNpb25cSW1hZ2UgRmlsZSBFeGVjdXRpb24gT3B0aW9uc1x7eyBvcmlnaW4gfX1dDQoiRGVidWdnZXIiPSJ7eyBuZXdQYXRoIH19Ig0KDQo="));

        public frmMainForm() {
            InitializeComponent();
        }

        private void submit(object sender, EventArgs e) {
            writeRegKey(txtOriginal.Text, txtNewPath.Text);
        }

        private void btnUnpatch_Click(object sender, EventArgs e) {
            writeRegKey(txtOriginal.Text, "");
        }

        private void writeRegKey(string original, string newPath) {
            File.Delete("temp.reg");
            string built = write.Replace("{{ origin }}", original).Replace("{{ newPath }}", newPath);
            System.IO.File.WriteAllText(@"temp.reg", built);
            Process pc = Process.Start("regedit.exe", Directory.GetCurrentDirectory() + "\\temp.reg");
            pc.WaitForExit();
            File.Delete("temp.reg");
        }
    }
}
