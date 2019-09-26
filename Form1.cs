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
        private ListBox activeListBox;

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
            teamsListBox.Items.Clear();
            foreach (var g in groups)
                g.Value.Items.Clear();

            teamsListBox.Items.AddRange(File.ReadAllLines(addTeamsOpenFileDialog.FileName, Encoding.GetEncoding(1251)));
        }

        private void GroupQuantityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dlg = new OptionsDlg())
            {
                if (DialogResult.OK == dlg.ShowDialog())
                {
                    foreach (var g in groups)
                    {
                        foreach (var item in g.Value.Items)
                            teamsListBox.Items.Add(item.ToString().Substring(item.ToString().IndexOf(". ") + 2));
                        g.Value.Items.Clear();

                    }
                    selectFontToolStripMenuItem.Enabled = true;
                    selectGroupContextMenu.Items.Clear();

                    if (dlg.groupQuantity.Value > 0)
                    {
                        groups.Clear();
                        groupsLayoutPanel.Controls.Clear();
                        groupsLayoutPanel.RowStyles.Clear();
                        int groupCount = (int)dlg.groupQuantity.Value;
                        groupsLayoutPanel.RowCount = groupCount;
                        for (int i = 0; i < groupsLayoutPanel.RowCount; i++)
                            groupsLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, (float)100 / groupCount));

                        for (int i = 0; i < groupCount; i++)
                        {
                            var gb = new GroupBox
                            {
                                Text = $"ГРУПА {groupNames[i]}",
                                Font = new Font("Sitka Small", 10, FontStyle.Bold),
                                Dock = DockStyle.Fill
                            };

                            var lb = new ListBox
                            {
                                Dock = DockStyle.Fill,
                                Font = new Font("Franklin Gothic Medium Cond", 16f)
                            };
                            lb.MouseUp += new MouseEventHandler(GroupListBox_MouseUp);
                            gb.Controls.Add(lb);

                            groupsLayoutPanel.Controls.Add(gb, i % 4, i / 4);
                            groups.Add(gb.Text, lb);

                            selectGroupContextMenu.Items.Add(gb.Text);
                        }
                    }
                }
            }
        }

        private void GroupListBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                activeListBox = sender as ListBox;
                activeListBox.SelectedIndex = activeListBox.IndexFromPoint(e.Location);
                if (activeListBox.SelectedIndex != -1 && activeListBox.Items.Count > 0 && activeListBox.SelectedIndex == activeListBox.Items.Count - 1)
                {
                    backContextMenu.Show(((Control)sender).PointToScreen(e.Location));
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
            groups[e.ClickedItem.Text].Items.Add($"{groups[e.ClickedItem.Text].Items.Count + 1}. {teamsListBox.Items[teamsListBox.SelectedIndex]}");
            teamsListBox.Items.RemoveAt(teamsListBox.SelectedIndex);
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BackContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (activeListBox != null)
            {
                var team = activeListBox.Items[activeListBox.SelectedIndex].ToString();
                teamsListBox.Items.Add(team.Substring(team.IndexOf(". ") + 2));
                activeListBox.Items.RemoveAt(activeListBox.SelectedIndex);
                activeListBox = null;
            }
        }

        private void SelectFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (groups.Any())
            {
                groupFontDialog.ShowColor = true;
                groupFontDialog.Font = groups.First().Value.Font;
                groupFontDialog.Color = groups.First().Value.ForeColor;

                if (groupFontDialog.ShowDialog() != DialogResult.Cancel)
                {
                    foreach (var l in groups)
                    {
                        l.Value.Font = groupFontDialog.Font;
                        l.Value.ForeColor = groupFontDialog.Color;
                    }
                }
            }
        }
    }
}
