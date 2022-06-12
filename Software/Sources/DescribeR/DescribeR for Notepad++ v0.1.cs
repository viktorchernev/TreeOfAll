using System;
using System.Linq;
using System.Windows.Forms;
using Kbg.NppPluginNET;
using Kbg.NppPluginNET.PluginInfrastructure;

namespace Kbg.Demo.Namespace
{
    partial class frmGoToLine : Form
    {
        private readonly IScintillaGateway editor;
        private static Random random = new Random();


        public frmGoToLine(IScintillaGateway editor)
        {
            this.editor = editor;
            InitializeComponent();
        }


        string last = "";
        int length = 8;
        private void buttonNewId_Click(object sender, EventArgs e)
        {
            last = RandomString(length);
            string text = last;
            if (radioButtonB.Checked) text = "<" + last + ">";
            else if (radioButtonC.Checked) text = "<" + last + ">,";
            else if (radioButtonD.Checked) text = "<" + last + ">," + Environment.NewLine;
            if (checkBoxSpaceBefore.Checked) text = " " + text;

            editor.InsertTextAndMoveCursor(text);
            labelMain.Text = last;

            if(buttonLastId.Enabled == false) buttonLastId.Enabled = true;
            editor.GrabFocus();
        }
        private void buttonLastId_Click(object sender, EventArgs e)
        {
            string text = last;
            if (radioButtonB.Checked) text = "<" + last + ">";
            else if (radioButtonC.Checked) text = "<" + last + ">,";
            else if (radioButtonD.Checked) text = "<" + last + ">," + Environment.NewLine;
            if (checkBoxSpaceBefore.Checked) text = " " + text;

            editor.InsertTextAndMoveCursor(text);
            editor.GrabFocus();
        }
        private void numericUpDownIdLength_ValueChanged(object sender, EventArgs e)
        {
            length = (int)numericUpDownIdLength.Value;
            last = "";
            buttonLastId.Enabled = false;

            labelMain.Text = "";
            for (int i = 0; i < length; i++) labelMain.Text += "X";
        }
        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }



        void FrmGoToLineVisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
            {
                Win32.SendMessage(
                    PluginBase.nppData._nppHandle, 
                    (uint) NppMsg.NPPM_SETMENUITEMCHECK,
                    PluginBase._funcItems.Items[Main.idFrmGotToLine]._cmdID, 
                    0);
            }
        }
    }
}
