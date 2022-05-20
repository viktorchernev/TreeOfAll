using GOLD;
using System.Diagnostics;

namespace TestGadget
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            TestGadget.LoadGrammer(@"C:\Users\vikto\Desktop\gold\#DESCRIBE.egt");
            TestGadget.ParseTextFiles(@"C:\Users\vikto\Desktop\TreeOfAll-main\Data\", "0_root");
            //TestGadget.ParseTextFile(@"C:\Users\vikto\Desktop\gold\testfile");
            //TestGadget.ParseTextFile(@"C:\Users\vikto\Desktop\TreeOfAll-main\0_root");
            TestGadget.WriteTree(MainTreeView);
        }


        // File
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                DialogResult result = ofd.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string path = ofd.FileName;
                    TestGadget.Reset();
                    TestGadget.ParseTextFiles(path);
                    TestGadget.WriteTree(MainTreeView);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TestGadget.SourcePath == null) return;

            TestGadget.Reset();
            TestGadget.ParseTextFiles(TestGadget.SourcePath);
            TestGadget.WriteTree(MainTreeView);
        }
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TestGadget.Reset();
            MainTreeView.Nodes.Clear();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Node
        private void copyFileLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode tn = MainTreeView.SelectedNode;
            string id = TestGadget.NodeDict[tn];
            string path = TestGadget.MyParser.Files[id];
            Clipboard.SetText(path);
        }
        private void displayFileLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode tn = MainTreeView.SelectedNode;
            string id = TestGadget.NodeDict[tn];
            string path = TestGadget.MyParser.Files[id];
            MessageBox.Show(tn.Text + " : " + Environment.NewLine + path);
        }
        private void editFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TreeNode tn = MainTreeView.SelectedNode;
            string id = TestGadget.NodeDict[tn];
            string path = TestGadget.MyParser.Files[id];

            Process myProcess = new Process();
            Process.Start(@"C:\Program Files\Notepad++\notepad++.exe", path);
        }
    }
}