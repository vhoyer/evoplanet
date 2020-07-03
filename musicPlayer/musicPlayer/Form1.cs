using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Microsoft.Xna.Framework.Media;

namespace musicPlayer
{
    public partial class Form1 : Form
    {
        DirectoryInfo dirInfo = new DirectoryInfo(@"C:\");

        public Form1()
        {
            InitializeComponent();
            PopulateTreeView();
        }

        private void PopulateTreeView()
        {
            TreeNode rootNode;

            DirectoryInfo info = new DirectoryInfo(@"C:\Users\"+Environment.UserName+@"\");
            if (info.Exists)
            {
                rootNode = new TreeNode(info.Name);
                rootNode.Tag = info;
                GetDirectories(info.GetDirectories(), rootNode);
                trvView.Nodes.Add(rootNode);
            }
        }

        private void GetDirectories(DirectoryInfo[] subDirs, TreeNode nodeToAddTo)
        {
            TreeNode aNode;
            DirectoryInfo[] subSubDirs;
            foreach (DirectoryInfo subDir in subDirs)
            {
                aNode = new TreeNode(subDir.Name, 0, 0);
                aNode.Tag = subDir;
                aNode.ImageKey = "folder";
                try
                {
                    subSubDirs = subDir.GetDirectories();
                    if (subSubDirs.Length != 0)
                    {
                        GetDirectories(subSubDirs, aNode);
                    }
                }
                catch (Exception)
                {
                    //MessageBox.Show(ex.Message + "\n\nErro details:\n" + ex, "Erro");
                }
                finally
                {
                    nodeToAddTo.Nodes.Add(aNode);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo[] directories = dirInfo.GetDirectories();
                if (directories.Length > 0)
                {
                    foreach (DirectoryInfo directory in directories)
                    {
                        TreeNode node = trvView.Nodes[0].Nodes.Add(directory.Name);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\nErro details:\n" + ex, "Erro");
            }
        }

        void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode newSelected = e.Node;
            lstv.Items.Clear();
            DirectoryInfo nodeDirInfo = (DirectoryInfo)newSelected.Tag;
            ListViewItem.ListViewSubItem[] subItems;
            ListViewItem item = null;

            foreach (DirectoryInfo dir in nodeDirInfo.GetDirectories())
            {
                item = new ListViewItem(dir.Name, 0);
                subItems = new ListViewItem.ListViewSubItem[]
                          {new ListViewItem.ListViewSubItem(item, "Directory"),
                   new ListViewItem.ListViewSubItem(item,
                dir.LastAccessTime.ToShortDateString())};
                item.SubItems.AddRange(subItems);
                lstv.Items.Add(item);
            }
            foreach (FileInfo file in nodeDirInfo.GetFiles())
            {
                item = new ListViewItem(file.Name, 1);
                subItems = new ListViewItem.ListViewSubItem[]
                          { new ListViewItem.ListViewSubItem(item, "File"),
                   new ListViewItem.ListViewSubItem(item,
                file.LastAccessTime.ToShortDateString())};

                item.SubItems.AddRange(subItems);
                lstv.Items.Add(item);
            }

            lstv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void lstv_ItemActivate(object sender, EventArgs e)
        {
            //Song song = new Song()
            //MediaPlayer.Play()
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MegaMarte fmr = new MegaMarte();
            fmr.ShowDialog();
        }
    }
}
