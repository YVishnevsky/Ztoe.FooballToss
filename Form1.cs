using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Toss
{
    public partial class Form1 : Form
    {
        readonly Dictionary<string, ListBox> groups = new Dictionary<string, ListBox>();
        readonly string groupNames = "ABCDEFGHIJ";

        public Form1()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            addTeamsOpenFileDialog.ShowDialog();
        }

        private void AddTeamsOpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            teamsListBox.Items.AddRange(File.ReadAllLines(addTeamsOpenFileDialog.FileName, Encoding.GetEncoding(1251)));
        }

        private void КількістьГрупToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dlg = new OptionsDlg();
            groups.Clear();

            if (DialogResult.OK == dlg.ShowDialog())
            {
                if (dlg.groupQuantity.Value > 0)
                {
                    groupsLayoutPanel.RowStyles.Clear();
                    int groupCount = (int)dlg.groupQuantity.Value;
                    groupsLayoutPanel.RowCount = groupCount / 4 + (groupCount % 4 > 0 ? 1 : 0);
                    for (int i = 0; i < groupsLayoutPanel.RowCount; i++)
                        groupsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, (float)100 / groupsLayoutPanel.RowCount));

                    for (int i=0; i<groupCount; i++)
                    {
                        var gb = new GroupBox();
                        gb.Text = $"Група {groupNames[i]}";
                        gb.Font = new Font("Sitka Small", 10);
                        gb.Dock = DockStyle.Fill;

                        var lb = new ListBox();
                        lb.Dock = DockStyle.Fill;
                        gb.Controls.Add(lb);

                        groupsLayoutPanel.Controls.Add(gb, i % 4, i / 4);
                        groups.Add(gb.Text, lb);

                        selectGroupContextMenu.Items.Add(gb.Text);
                    }
                }
            }
        }

        private void TeamsListBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                teamsListBox.SelectedIndex = teamsListBox.IndexFromPoint(e.Location);
                if (teamsListBox.SelectedIndex != -1 && selectGroupContextMenu.Items.Count > 0)
                {
                    selectGroupContextMenu.Show(((Control)sender).PointToScreen(e.Location));
                }
            }
        }

        private void SelectGroupContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            groups[e.ClickedItem.Text].Items.Add($"{groups[e.ClickedItem.Text].Items.Count+1}. {teamsListBox.Items[teamsListBox.SelectedIndex]}");
            teamsListBox.Items.RemoveAt(teamsListBox.SelectedIndex);
        }
    }
}
