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

namespace StageCreate
{
    public partial class Main : Form
    {
        Dictionary<string, Dictionary<string, int>> loadlists = new Dictionary<string, Dictionary<string, int>>();
        //  List<string> temp = new List<string>();
        public static Dictionary<int, Image> imagesPath = new Dictionary<int, Image>();

        private void LoadInit()
        {
            //ファイルのロード
            string[] loadlist = File.ReadAllLines(@"./data/LoadList.data");
            foreach (string line in loadlist)
            {
                int index2 = line.IndexOf("List") + 4;
                string[] filepaths = File.ReadAllLines(@line);
                string keyString = line.Substring(index2 + 1, line.Length - index2 - 5);
                loadlists.Add(keyString, null);
                loadlists[keyString] = new Dictionary<string, int>();

                foreach (string line140 in filepaths)
                {
                    int index = line140.IndexOf(" ");
                    loadlists[keyString].Add(line140.Substring(index + 1), int.Parse(line140.Substring(0, index)));
                }
            }
            string[] pathLine = File.ReadAllLines(@"./data/ImagePath.data");
            foreach (string line in pathLine)
            {
                if (line == "")
                    continue;
                string[] def = line.Split(new char[] { });

                string path = @"./data/image/" + def[1] + ".png";

                Bitmap image = new Bitmap(path);
                imagesPath.Add(int.Parse(def[0]), (Image)image);
            }
            tBOutPath.Text = "Stage";
            lbIndex.Text = string.Empty;
        }

        private void LoadString(Dictionary<string, int> add, string[] list)
        {
            foreach (string line in list)
            {
                int index = line.IndexOf(" ");
                add.Add(line.Substring(index + 1), int.Parse(line.Substring(0, index)));
            }
        }


        public Main()
        {
            InitializeComponent();
        }

        private void StageLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.InitialDirectory = Application.ExecutablePath;
            openFile.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            DialogResult result = openFile.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //          Path path = new Path(openFile.FileName);
                tBInPath.Text = openFile.FileName;
            }

            else if (result == System.Windows.Forms.DialogResult.Cancel)
            {
                tBInPath.Text = "キャンセル";
                return;
            }
            else
            {
                tBInPath.Text = "ファイルオープン失敗";
                return;
            }
            string[] loadlist = File.ReadAllLines(tBInPath.Text);
            listBoxResult.Items.Clear();
            foreach (string line in loadlist)
            {
                listBoxResult.Items.Add(line);
            }
            LbIndexResetAndSet();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string path = @"./" + tBOutPath.Text + ".txt";
            if (File.Exists(path))
            {
                tBOutPath.Text += "_";
                path = "./" + tBOutPath.Text + "_" + ".txt";
            }
            var file = new System.IO.StreamWriter(path);
            foreach (string text in listBoxResult.Items)
            {
                file.Write(text);
                file.Write("\n");
            }

            file.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cBItem.DropDownStyle = ComboBoxStyle.DropDownList;
            cBModual.DropDownStyle = ComboBoxStyle.DropDownList;
            cBMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cBMode.Visible = false;

            cBItem.Items.Clear();

            LoadInit();

            foreach (var key in loadlists.Keys)
            {
                cBItem.Items.Add(key);
            }

        }

        private string InsertData()
        {
            //名前 PosX PosY imgNum + サイズ + モード
            string temp = string.Empty;
            if (cBItem.Text != "")
            {
                if (tBPosX.Text == "") { tBPosX.Text = 0.ToString(); }
                if (tBPosY.Text == "") { tBPosY.Text = 0.ToString(); }
                if (tBSize.Text == "") { tBSize.Text = 0.ToString(); }
                if (tBMode.Text == "") { tBMode.Text = 0.ToString(); }
                temp += cBItem.Text + " " + tBPosX.Text + " " + tBPosY.Text;

                //if (lbModual.Visible)
                //{
                temp += " " + loadlists[cBItem.Text][cBModual.Text];
                //}
                if (lbSize.Visible)
                {
                    temp += " " + tBSize.Text;
                }
                if (tBMode.Visible)
                {
                    temp += " " + tBMode.Text;
                }
                else if (cBMode.Visible)
                {
                    temp += " " + cBMode.Text;
                }
            }
            return temp;
        }

        private void ResultData()
        {

            //次のステージが空いていたら２５５
            if (tBNextStage.Text == "") { tBNextStage.Text = 255.ToString(); }

            int resultCnt = 0;
            int index = 0;

            for (int i = 0; i < listBoxResult.Items.Count; ++i)
            {
                listBoxResult.SelectedIndex = i;
                string line = listBoxResult.Text;
                if (line.Substring(0, 6) == "Result")
                {
                    listBoxResult.Items.RemoveAt(i);
                }
            }
            foreach (string line in listBoxResult.Items)
            {
                if (line.Substring(0, 8) == "Fragment")
                {
                    ++resultCnt;
                }
                if (line.Substring(0, 9) == "BreakStar")
                {
                    resultCnt += 8;
                }
                ++index;
            }
            string temp = string.Empty;
            temp = "Result " + resultCnt + " " + tBNextStage.Text;
            listBoxResult.Items.Add(temp);
            cBItem.Focus();
        }

        private void LbIndexResetAndSet()
        {
            lbIndex.Text = string.Empty;
            for (int i = 0; i < listBoxResult.Items.Count; ++i)
            {
                lbIndex.Text += i.ToString() + "\n";
            }
        }

        private void ResultButton_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Add(InsertData());
            ResultData();
            LbIndexResetAndSet();
        }

        private void cBItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cBItem.SelectedIndex)
            {
                default:
                    tBSize.Visible = true;
                    lbSize.Visible = true;
                    tBMode.Visible = false;
                    lbMode.Visible = false;
                    cBModual.Visible = true;
                    lbModual.Visible = true;
                    cBMode.Visible = false;
                    break;
            }
            switch (cBItem.SelectedIndex)
            {
                case 0:
                    tBSize.Visible = false;
                    lbSize.Visible = false;
                    lbModual.Text = "Color";
                    break;
                case 1:
                    tBSize.Visible = false;
                    lbSize.Visible = false;
                    lbModual.Text = "Color";
                    break;
                case 2:
                    lbModual.Text = "Mode";
                    break;
                case 3:
                    lbModual.Text = "Mode";
                    break;
                case 4:
                    tBSize.Visible = false;
                    lbSize.Visible = false;
                    lbModual.Text = "Mode";
                    cBMode.Visible = true;
                    cBMode.Items.Clear();

					cBMode.Items.Add("停止");
                    cBMode.Items.Add("U方向");
                    cBMode.Items.Add("D方向");
					cBMode.Items.Add("R方向");
					cBMode.Items.Add("L方向");
					cBMode.Items.Add("R回転");
					cBMode.Items.Add("L回転");
                    cBMode.SelectedIndex = 0;
                    lbMode.Text = "動き";
                    break;
                case 5:
                    tBSize.Visible = false;
                    lbSize.Visible = false;
                    lbModual.Text = string.Empty;
                    break;
                case 6:
                    lbModual.Visible = false;
                    cBModual.Visible = false;
                    lbMode.Visible = true;
                    lbMode.Text = "速度";
                    tBMode.Visible = true;
                    break;
            }
            cBModual.Items.Clear();
            foreach (string line in loadlists[cBItem.Text].Keys)
            {
                cBModual.Items.Add(line);
            }
            cBModual.SelectedIndex = 0;
        }

        private void bTlistClear_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear();
            lbIndex.Text = string.Empty;
        }

        private void listBoxResult_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listBoxResult.SelectedItem != null)
            {
                string[] selectedLine = listBoxResult.Text.Split(new char[] { });
                if (selectedLine[0] != "Result")
                {
                    cBItem.SelectedItem = selectedLine[0];
                    tBPosX.Text = selectedLine[1];
                    tBPosY.Text = selectedLine[2];
                    var temp = loadlists[selectedLine[0]].First(x => x.Value == int.Parse(selectedLine[3]));
                    cBModual.SelectedItem = temp.Key;

                    if (selectedLine[0] == "Planet" || selectedLine[0] == "BlackHole")
                    {
                        tBSize.Text = selectedLine[4];
                    }
                    else if (selectedLine[0] == "Meteo")
                    {
                        tBSize.Text = selectedLine[4];
                        tBMode.Text = selectedLine[5];
                    }
                }
            }
        }

        private void btDraw_Click(object sender, EventArgs e)
        {
            DrawWindow formDraw = new DrawWindow();
            formDraw.Location = new Point(0, 0);
            formDraw.Size = new Size(960, 540);
            DrawWindow.lines.Clear();
            foreach (string line in listBoxResult.Items)
            {
                DrawWindow.lines.Add(line);
            }
            formDraw.Show();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (listBoxResult.SelectedIndex != -1)
            {
                listBoxResult.Items.RemoveAt(listBoxResult.SelectedIndex);
            }
            LbIndexResetAndSet();
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            var index = listBoxResult.SelectedIndex;
            listBoxResult.Items.RemoveAt(index);
            listBoxResult.Items.Insert(index, InsertData());
            LbIndexResetAndSet();
        }
    }
}