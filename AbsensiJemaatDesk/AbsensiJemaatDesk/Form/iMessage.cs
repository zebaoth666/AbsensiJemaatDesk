using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbsensiJemaatDesk
{
    public class iMessage : Form
    {
        static string heading= "Integrated Store";

        public static DialogResult eBoxOk(String message){
            DialogResult drE = MessageBox.Show(null, message, heading, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
            return drE;
        }

        public static DialogResult iBoxOk(String message) {
            DialogResult drI = MessageBox.Show(null, message, heading, MessageBoxButtons.OK, MessageBoxIcon.Information);

            return drI;
        }

        public static DialogResult erBoxOk(String message) {
            DialogResult drErr = MessageBox.Show(null, message, heading, MessageBoxButtons.OK, MessageBoxIcon.Error);

            return drErr;
        }

        public static DialogResult quBoxCon(String message) {
            DialogResult drQue = MessageBox.Show(null, message, heading, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            return drQue;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iMessage));
            this.SuspendLayout();
            // 
            // iMessage
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "iMessage";
            this.Load += new System.EventHandler(this.iMessage_Load);
            this.ResumeLayout(false);

        }

        private void iMessage_Load(object sender, EventArgs e)
        {

        }
    }
}
