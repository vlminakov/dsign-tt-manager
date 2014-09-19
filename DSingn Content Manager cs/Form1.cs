using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

using Newtonsoft.Json;
using Newtonsoft.Json.Bson;

using System.Diagnostics;

using DSUI;

namespace DSingn_Content_Manager_cs
{
    public partial class Form1 : Form
    {
        private string tt_name_to_save;

        PlayersGroup[] pg;

        private LoginForm lf;

        private TreeNode sNode;

        private string tempLabelValue;

        private long totalDuration = 0;

        public void LoginUser(string login, string pass)
        {
            string loginResult = DSHttp.Instance.queryServer(Constants.HTTP_METHOD_POST, Constants.HTTP_LOGIN_PATH, new []{
                new KeyValuePair<string, string>("Content-Type", "application/x-www-form-urlencoded")
            }, 
            new[] {
                new KeyValuePair<string, string>("ClientType","3"),
                new KeyValuePair<string, string>("email",login),
                new KeyValuePair<string, string>("password",pass),
                new KeyValuePair<string, string>("rememberMe","0")
            }, null);

            LoginResponse resp = JsonConvert.DeserializeObject<LoginResponse>(loginResult);
            Debug.WriteLine(resp.status);
            Debug.WriteLine(resp.uuid);

            if (resp.status == 1)
            {
                Options.Instance.Uuid = resp.uuid;
                this.lf.Close();
            }
            else
            {
                this.lf.showAlert("Не верные данные");
            }
        }

        private string getPlayerGroups(string uuid)
        {
            string res = DSHttp.Instance.queryServer(Constants.HTTP_METHOD_GET, Constants.HTTP_GROUPS_PATH, null,
            null, null);

            Debug.WriteLine(res);
            return res;
        }

        List<TTAbstraction> ttList;
        public void getTtList()
        {
            ttList = new List<TTAbstraction>();
            ttList = JsonConvert.DeserializeObject<List<TTAbstraction>>(DSHttp.Instance.queryServer(Constants.HTTP_METHOD_GET, "ttlist", null, null, null));
            if (listTT.Items.Count > 0)
            {
                listTT.Items.Clear();
            }
            foreach (TTAbstraction tta in ttList)
            {
                listTT.Items.Add(tta.name);
            }
        }

        private void initgroups()
        {
            this.treeViewPlayerGroups.Nodes.Clear();
            string respGroups = getPlayerGroups(Options.Instance.Uuid);
            pg = JsonConvert.DeserializeObject<PlayersGroup[]>(respGroups);

            ImageList ml = new ImageList();

            ml.Images.Add(images.gs);
            ml.Images.Add(images.ys);
            ml.Images.Add(images.rs);
            ml.Images.Add(images.empty);
            treeViewPlayerGroups.ImageList = ml;

            foreach (PlayersGroup pgr in pg)
            {
                DSTreeNode groupNode = new DSTreeNode(pgr.name, pgr.description);
                groupNode.ImageIndex = 3;
                groupNode.plGroup = pgr;
                groupNode.SelectedImageIndex = 3;
                if (pgr.players.Count > 0)
                {
                    foreach (Player player in pgr.players)
                    {
                        DSTreeNode playerNode = new DSTreeNode(player.name, player.description);
                        playerNode.plGroup = null;
                        playerNode.ImageIndex = player.state;
                        playerNode.SelectedImageIndex = player.state;
                        playerNode.playerId = Convert.ToInt32(player.id);
                        playerNode.player = player;
                        groupNode.Nodes.Add(playerNode);
                    }
                }
                treeViewPlayerGroups.Nodes.Add(groupNode);
            }

        }

        public Form1()
        {
            InitializeComponent();
            lf = new LoginForm();
            lf.ShowDialog(this);

            this.setActiveMenuItem(Constants.MENU_BUTTON_PLAYERS);

            
            this.getTtList();

            
        }

        private void menuButtonPlayers_Click(object sender, EventArgs e)
        {
            this.setActiveMenuItem(Constants.MENU_BUTTON_PLAYERS);
        }

        private void menuButtonTimetable_Click(object sender, EventArgs e)
        {
            this.setActiveMenuItem(Constants.MENU_BUTTON_TIMETABLE);
        }

        private void menuButtonStat_Click(object sender, EventArgs e)
        {
            this.setActiveMenuItem(Constants.MENU_BUTTON_STAT);
        }

        private void setActiveMenuItem(int index)
        {
            try
            {
                foreach (Button btn in panel1.Controls)
                {
                    btn.BackColor = SystemColors.ControlDarkDark;
                }
                switch (index)
                {
                    case Constants.MENU_BUTTON_PLAYERS:
                        menuButtonPlayers.BackColor = Color.FromArgb(0, 200, 150);
                        break;
                    case Constants.MENU_BUTTON_TIMETABLE:
                        menuButtonTimetable.BackColor = Color.FromArgb(0, 200, 150);
                        break;
                    case Constants.MENU_BUTTON_STAT:
                        menuButtonStat.BackColor = Color.FromArgb(0, 200, 150);
                        break;
                    default:
                        break;
                }
            }
            catch (Exception)
            {
            }
            
            this.showActivePanel(index);
        }

        private void showActivePanel(int index)
        {
            
            foreach (Panel p in panelContentContainer.Controls)
            {
                p.Visible = false;
            }
            switch (index)
            {
                case Constants.MENU_BUTTON_PLAYERS:
                    panelPlayersContent.Visible = true;
                    initgroups();
                    break;
                case Constants.MENU_BUTTON_TIMETABLE:
                    panelTimetable.Visible = true;
                    this.initTimeTable();
                    panelTT.Visible = true;
                    foreach (Control c in panelTT.Controls)
                    {
                        c.Visible = true;
                    }
                    break;
                case Constants.MENU_BUTTON_STAT:
                    panelStat.Visible = true;
                    this.getUserFiles();
                    break;
                default:
                    break;
            }
            
        }

        private void getUserFiles()
        {
            if (userFilesListView.Items.Count > 0)
                userFilesListView.Items.Clear();
            string response = DSHttp.Instance.queryServer(Constants.HTTP_METHOD_GET, "filelist", null, null, null);
            List<string> fileNames = JsonConvert.DeserializeObject<List<string>>(response);
            foreach (string filename in fileNames)
            {
                this.userFilesListView.Items.Add(new ListViewItem(filename));
            }
        }

        private PlayersGroup __tempPg = null;
        private void treeViewPlayerGroups_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (((DSTreeNode)e.Item).Parent != null)
                {
                    foreach (PlayersGroup _pg in pg)
                    {
                        if (((DSTreeNode)((DSTreeNode)e.Item).Parent).name.Equals(_pg.name))
                        {
                            __tempPg = _pg;
                        }
                    }
                }
                DoDragDrop(e.Item, DragDropEffects.Move);
            }
        }

        private void treeViewPlayerGroups_DragDrop(object sender, DragEventArgs e)
        {
            PlayersGroup _pg = null;
            Player _p = null;
            Point targetPoint = treeViewPlayerGroups.PointToClient(new Point(e.X, e.Y));
            DSTreeNode targetNode = (DSTreeNode)treeViewPlayerGroups.GetNodeAt(targetPoint);
            DSTreeNode draggedNode = (DSTreeNode)e.Data.GetData(typeof(DSTreeNode));
            foreach (PlayersGroup __pg in pg)
            {
                foreach (Player __p in __pg.players)
                {
                    if (draggedNode.name.Equals(__p.name))
                    {
                        _p = __p;
                    }
                }
            }
            foreach (PlayersGroup _pgr in pg)
            {
                if (_pgr.name.Equals(targetNode.name))
                {
                    _pg = _pgr;
                }
            }
            if (targetNode == null)
            {
                if (e.Effect == DragDropEffects.Move && draggedNode.Parent != null)
                {
                    draggedNode.Remove();
                    treeViewPlayerGroups.Nodes.Add(draggedNode);
                }
                return;
            }
            if (!draggedNode.Equals(targetNode) && !ContainsNode(draggedNode, targetNode))
            {
                if (e.Effect == DragDropEffects.Move && targetNode.Parent == null)
                {
                    draggedNode.Remove();
                    targetNode.Nodes.Add(draggedNode);
                    __tempPg.players.Remove(_p);
                    _pg.players.Add(_p);
                }
                targetNode.Expand();
            }
        }

        private void treeViewPlayerGroups_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void treeViewPlayerGroups_DragOver(object sender, DragEventArgs e)
        {
            Point targetPoint = treeViewPlayerGroups.PointToClient(new Point(e.X, e.Y));
            treeViewPlayerGroups.SelectedNode = treeViewPlayerGroups.GetNodeAt(targetPoint);
        }

        private bool ContainsNode(DSTreeNode node1, DSTreeNode node2)
        {
            if (node2.Parent == null) return false;
            if (node2.Parent.Equals(node1)) return true;
            return ContainsNode(node1, (DSTreeNode)node2.Parent);
        }

        private void pGroupsMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button.Equals(MouseButtons.Right))
            {
                this.sNode = e.Node;
                treeViewPlayerGroups.SelectedNode = e.Node;
                pGroupsContextMenu.Show(treeViewPlayerGroups, new Point(e.X, e.Y));
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.sNode.Text + " test1 submenu called!!!\n");
            treeViewPlayerGroups.Nodes.Remove(this.sNode);
            this.sNode = null;
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.sNode.BeginEdit();
        }

        private void pGroups_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label != null)
            {
                if (e.Label.Length > 0){
                    if (e.Label.IndexOfAny(new char[] { '@', '<', '>', '/', '\\' }) == -1)
                    {
                        e.Node.EndEdit(false);
                    }
                    else
                    {
                        e.CancelEdit = true;
                        MessageBox.Show("Символы: @, <, >, /, \\ запрещены!");
                        e.Node.Text = this.tempLabelValue;
                        e.Node.BeginEdit();
                    }
                }
                else
                {
                    e.CancelEdit = true;
                    MessageBox.Show("Название не может быть пустой строкой!");
                    e.Node.Text = this.tempLabelValue;
                    e.Node.BeginEdit();
                }
            }
        }

        private void pGroups_BeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            this.tempLabelValue = e.Node.Text;
        }

        private void переместитьВГруппуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<TreeNode> rootNodes = new List<TreeNode>();
            foreach (TreeNode n in treeViewPlayerGroups.Nodes)
            {
                if (n.Parent == null)
                    rootNodes.Add(n);
            }
            string str = "";
            foreach (TreeNode tn in rootNodes)
                str += tn.Text + "\n";
            Debug.WriteLine(str);
            MoveToDialog md = new MoveToDialog();
            md.Nodes = rootNodes;
            md.ShowDialog(this);
        }

        public void MovePlayerToGroup(string nodeName)
        {
            TreeNode targetNode = null;
            foreach (TreeNode n in treeViewPlayerGroups.Nodes)
            {
                if (n.Text.Equals(nodeName))
                    targetNode = n;
            }
            this.sNode.Remove();
            targetNode.Nodes.Add(this.sNode);
            this.sNode = null;
        }

        private void расписаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSTreeNode snode = (DSTreeNode)this.treeViewPlayerGroups.SelectedNode;
            Player player = snode.player;
            int ttId = player.ttId;
            this.setActiveMenuItem(Constants.MENU_BUTTON_TIMETABLE);
            TTAbstraction tta = new TTAbstraction();
            foreach (TTAbstraction ttta in ttList){
                if (ttta.id == ttId)
                {
                    tta = ttta;
                    break;
                }
            }
            this.currentTtId = tta.id;
            string ttContent = tta.content;
            TimetableContent ttContentObj = JsonConvert.DeserializeObject<TimetableContent>(ttContent);
            parseTTable(ttContentObj);
            DateTime date = DateTime.Now;
            string dayT = date.ToString("dd.MM.yyyy");
            foreach (TabPage tp in tabControl1.TabPages)
            {
                if (tp.Text.Equals(dayT))
                {
                    tabControl1.SelectTab(tp);
                    break;
                }
            }
        }

        private bool ttLoaded = false;

        private void initTimeTable()
        {
            if (ttLoaded)
                return;
            string caption = Text;
            Text += " - загрузка...";
            downloadConfig();
            List<FileDescription> files = JsonConvert.DeserializeObject<List<FileDescription>>(File.ReadAllText("config.json"));

            List<string> pFiles = new List<string>();
            foreach (FileDescription fd in files)
            {
                if (fd.preview != null)
                {
                    pFiles.Add("previews/"+fd.preview.name);
                }
                else 
                {
                    if (fd.type.Equals("image")){
                        pFiles.Add("image/"+fd.name);
                    }
                }
            }
            downloadFiles(pFiles);

            int videoIndex = 0;
            int audioIndex = 0;
            int imageIndex = 0;
            foreach (FileDescription fd in files)
            {
                PreviewItem pi = new PreviewItem();
                if (fd.type.Equals("audio"))
                {
                    pi.Type = Constants.PREVIEW_ITEM_TYPE_AUDIO;
                }
                else if (fd.type.Equals("image"))
                {
                    pi.Type = Constants.PREVIEW_ITEM_TYPE_IMAGE;
                }
                else if (fd.type.Equals("video"))
                {
                    pi.Type = Constants.PREVIEW_ITEM_TYPE_VIDEO;
                }
                pi.setText(fd.name);
                pi.Duration = fd.duration;
                
                if (fd.type.Equals("audio"))
                {
                    pi.setImage(Image.FromFile("images\\audio.png"));
                    pi.SetBounds(pi.Width * audioIndex + 3 * audioIndex, 3, pi.Width, pi.Height);
                    panel_a.Controls.Add(pi);
                    audioIndex++;
                }
                else if (fd.type.Equals("image"))
                {
                    pi.Duration = "0";
                    pi.setImage(Image.FromFile("images\\" + fd.name));
                    pi.SetBounds(pi.Width * imageIndex + 3 * imageIndex, 3, pi.Width, pi.Height);
                    panel_i.Controls.Add(pi);
                    imageIndex++;
                }
                else if (fd.type.Equals("video"))
                {
                    pi.setImage(Image.FromFile("images\\" + fd.preview.name));
                    pi.SetBounds(pi.Width * videoIndex + 3 * videoIndex, 3, pi.Width, pi.Height);
                    panel_v.Controls.Add(pi);
                    videoIndex++;
                }
            }
            ttLoaded = true;
            Text = caption;
            DateTime ddd = DateTime.Now;
            
            for (int i = 0; i < 14; i++)
            {
                TabPage tp = new TabPage(ddd.ToString("dd.MM.yyyy"));
                TimeLineControl tc = new TimeLineControl();
                tc.delegateForm1 = this;
                tc.Dock = DockStyle.Fill;
                tp.Controls.Add(tc);
                tabControl1.TabPages.Add(tp);
                ddd = ddd.AddDays(1);
            }
        }

        private void downloadConfig()
        {
            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(Constants.FTP_HOME + "config.json");
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            // This example assumes the FTP site uses anonymous logon.
            request.Credentials = new NetworkCredential(Options.Instance.Email, Options.Instance.Password);

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);
            string str = reader.ReadToEnd();
            File.WriteAllText("config.json", str);
            reader.Close();
            response.Close();
        }

        private void downloadFiles(List<string> files)
        {
            foreach (string file in files)
            {
                // Get the object used to communicate with the server.
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(Constants.FTP_HOME + file);
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                request.UseBinary = true;

                // This example assumes the FTP site uses anonymous logon.
                request.Credentials = new NetworkCredential(Options.Instance.Email, Options.Instance.Password);

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                FileStream fs = new FileStream("images\\" + file.Substring(file.LastIndexOf('/') + 1), FileMode.Create);
                Stream respSream = response.GetResponseStream();

                byte[] buffer = new byte[102400];

                int read = 0;

                do
                {

                    read = respSream.Read(buffer, 0, buffer.Length);

                    fs.Write(buffer, 0, read);

                    fs.Flush();

                } while (!(read == 0));

                fs.Flush();

                fs.Close();

                response.Close();

                respSream.Close();
                response.Close();
            }
        }

        private void savegroups_button_Click(object sender, EventArgs e)
        {
            string jsstr = JsonConvert.SerializeObject(pg);
            Debug.WriteLine(jsstr);
            string str = DSHttp.Instance.queryServer(Constants.HTTP_METHOD_POST, "savegroups", new[]{
                new KeyValuePair<string, string>("Content-Type", "application/x-www-form-urlencoded")
            },
            new[] {
                new KeyValuePair<string, string>("data",jsstr)
            }, null);
        }

        private Player findPlayerByName(string name)
        {
            foreach (PlayersGroup _pg in pg)
            {
                foreach (Player _p in _pg.players)
                {
                    if (_p.name.Equals(name))
                    {
                        return _p;
                    }
                }
            }

            return null;
        }

        public void setTTName(string name)
        {
            this.tt_name_to_save = name;
        }

        public void saveTT()
        {
            List<Day> days = new List<Day>();
            foreach (TabPage tp in tabControl1.TabPages)
            {
                Control[] ctrl = new Control[tp.Controls.Count];
                tp.Controls.CopyTo(ctrl, 0);
                TimeLineControl tlc = (TimeLineControl)ctrl[0];
                Day d = tlc.getDay();
                d.Date = tp.Text;
                days.Add(d);
            }
            TimetableContent ttc = new TimetableContent();
            ttc.Timetable = new Timetable();
            ttc.Timetable.Days = days;
            string jsonstring = JsonConvert.SerializeObject(ttc);
            TTAbstraction tta = new TTAbstraction();
            tta.name = "new tt!";
            tta.content = jsonstring;
            TTSetNameWnd dlg = new TTSetNameWnd();
            dlg.ShowDialog(this);
            tta.name = this.tt_name_to_save;
            string ttJson = JsonConvert.SerializeObject(tta);
            DSHttp.Instance.queryServer(Constants.HTTP_METHOD_POST, "savett", new[]{
                new KeyValuePair<string, string>("Content-Type", "application/json")
            }, null, ttJson);
            this.getTtList();
        }

        public void asignPlayer()
        {
            List<DSTreeNode> nodes = new List<DSTreeNode>();
            foreach (DSTreeNode tn in this.treeViewPlayerGroups.Nodes)
            {
                DSTreeNode tmpNode = tn.Clone();
                if (tn.Nodes.Count > 0)
                {
                    foreach (DSTreeNode ttn in tn.Nodes)
                    {
                        tmpNode.Nodes.Add(ttn.Clone());
                    }
                }
                nodes.Add(tmpNode);
            }
            PlayersListWnd plListWnd = new PlayersListWnd(nodes);
            plListWnd.ShowDialog(this);

            DSHttp.Instance.queryServer(Constants.HTTP_METHOD_POST,
                "update-player-tt",
                new[] {
                    new KeyValuePair<string, string>("Content-Type", "application/x-www-form-urlencoded")
                },
                new []{
                    new KeyValuePair<string, string>("pid", this.pid.ToString()),
                    new KeyValuePair<string, string>("tid", this.currentTtId.ToString())
                },
                null);

        }

        private List<PreviewItem> copiedContent;
        public void copyCurrent(TimeLineControl tc)
        {
            if (copiedContent == null)
                copiedContent = new List<PreviewItem>();
            if (copiedContent.Count > 0)
                copiedContent.Clear();
            foreach (PreviewItem pi in tc.Items)
            {
                if (pi.Selected)
                {
                    copiedContent.Add((PreviewItem)pi.Clone());
                }
            }
            if (copiedContent.Count == 0)
                MessageBox.Show("Вы ни чего не выделили");
        }

        public void copyAll(TimeLineControl tc)
        {
            if (copiedContent == null)
                copiedContent = new List<PreviewItem>();
            if (copiedContent.Count > 0)
                copiedContent.Clear();
            foreach (PreviewItem pi in tc.Items)
            {
                copiedContent.Add((PreviewItem)pi.Clone());
            }
        }

        public void pasteContent(TimeLineControl tc)
        {
            if (copiedContent != null && copiedContent.Count > 0){
                foreach (PreviewItem pi in copiedContent)
                {
                    tc.addItem((PreviewItem)pi.Clone());
                }
            }
        }

        private int currentTtId = 0;

        private void ttNameSelected(object sender, EventArgs e)
        {
            string timeTableName = listTT.SelectedItem.ToString();
            TTAbstraction tta = null;
            foreach (TTAbstraction _tta in ttList)
            {
                if (_tta.name.Equals(timeTableName))
                {
                    tta = _tta;
                    break;
                }
            }
            this.currentTtId = tta.id;
            string ttContent = tta.content;
            TimetableContent ttContentObj = JsonConvert.DeserializeObject<TimetableContent>(ttContent);
            parseTTable(ttContentObj);
        }

        private void parseTTable(TimetableContent tt)
        {
            int tabsCount = tabControl1.TabPages.Count;
            for (int i = 0; i < tabsCount; i++)
            {
                Day day = tt.Timetable.Days[i];
                tabControl1.SelectTab(i);
                tabControl1.SelectedTab.Text = day.Date;
                Control[] ctrl = new Control[tabControl1.SelectedTab.Controls.Count];
                tabControl1.SelectedTab.Controls.CopyTo(ctrl, 0);
                TimeLineControl tlc = (TimeLineControl)ctrl[0];
                tlc.setDay(day);
            }

            tabControl1.SelectTab(0);
        }

        private void newTtButton_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            foreach (TabPage tp in this.tabControl1.TabPages)
            {
                Control[] ctrls = new Control[tp.Controls.Count];
                tp.Controls.CopyTo(ctrls, 0);
                TimeLineControl tlc = (TimeLineControl)ctrls[0];
                tlc.Clear();
                tp.Text = date.ToString("dd.MM.yyyy");
                date = date.AddDays(1);
                this.listTT.ResetText();
            }
            tabControl1.SelectTab(0);
        }

        private int pid;
        public void set_ass_player(int pid)
        {
            this.pid = pid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // GENERATE REPORT
            List<List<FileReportObject>> report = new List<List<FileReportObject>>();
            string[] filenames;
            List<string> files = new List<string>();
            foreach (ListViewItem item in userFilesListView.SelectedItems)
            {
                Debug.WriteLine(item.Text);
                files.Add(item.Text);
                //List<FileReportObject> fileReport = JsonConvert.DeserializeObject<List<FileReportObject>>(DSHttp.Instance.queryServer(Constants.HTTP_METHOD_GET,
                //    "getstat", null, new []{new KeyValuePair<string, string>("filename", item.Text)},null));
                report.Add(JsonConvert.DeserializeObject<List<FileReportObject>>(DSHttp.Instance.queryServer(Constants.HTTP_METHOD_GET,
                    "getstat", null, new[] { new KeyValuePair<string, string>("filename", item.Text) }, null)));
            }
            filenames = new string[report.Count];
            files.CopyTo(filenames);
            ExcelLayer eLayer = new ExcelLayer();
            eLayer.createReport(report, filenames);
        }
    }
}
