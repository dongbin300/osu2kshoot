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

namespace osu2kshoot
{
    public partial class Form1 : Form
    {
        enum ConvertOptions { OnlyButton, OnlyFX, OnlyKnob, ButtonAndFX, ButtonAndKnob, FXAndKnob, All }
        double currentTiming;
        int[] knobLength = new int[2];

        RhythmGameObjects rgo = new RhythmGameObjects();
        Osu osu = new Osu();
        KShoot kshoot = new KShoot();

        public Form1()
        {
            InitializeComponent();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (openOsuFileDialog.ShowDialog() == DialogResult.OK)
            {
                osuDirectoryTextBox.Text = openOsuFileDialog.FileName;
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (fourRadioButton.Checked)
                    Convert(osuDirectoryTextBox.Text, 4, ConvertOptions.OnlyButton);
                if (sevenRadioButton.Checked)
                    Convert(osuDirectoryTextBox.Text, 7, ConvertOptions.ButtonAndFX);
                if (sevenRadioButton2.Checked)
                    Convert(osuDirectoryTextBox.Text, 7, ConvertOptions.All);
                /*string str = string.Empty;
                foreach (int n in rgo.Notes)
                {
                    str += n + " ";
                }
                MessageBox.Show(str);*/
                MessageBox.Show("변환 완료.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Convert(string filePath, int keyCount, ConvertOptions co)
        {
            #region OsuToRhythmGameObjects
            FileStream fs = new FileStream(filePath, FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            string line = string.Empty;
            bool timingPoints = false;
            bool hitObjects = false;
            bool first = true;
            osu.LongNoteEndTiming = new int[keyCount];

            for (int i = 0; sr.Peek() >= 0; i++)
            {
                line = sr.ReadLine();

                if (hitObjects)
                {
                    string[] obj = line.Split(',');
                    if (first) // 첫 노트는 타이밍을 오프셋으로 설정
                    {
                        currentTiming = osu.Offset;
                        first = false;
                    }

                    int button = keyCount == 4 ? (int.Parse(obj[0]) / 32 - 2) / 4 : (int.Parse(obj[0]) / 36 - 1) / 2;
                    int buttonValue = (int)Math.Pow(2, button);

                    if (obj[5].Split(':').Length - 1 == 5) // : 개수가 5개면 롱노트
                    {
                        // 롱노트 시작
                        osu.LongNoteEndTiming[button] = int.Parse(obj[5].Split(':')[0]);
                    }

                    if (IsTiming(int.Parse(obj[2]))) // 이전노트와 같은 타이밍
                    {
                        if (rgo.Notes.Count == 0) // 첫 노트
                            rgo.Notes.Add(buttonValue + LongNoteValue(keyCount));
                        else
                            rgo.Notes[rgo.Notes.Count - 1] += buttonValue + LongNoteValue(keyCount);
                    }
                    else // 이전노트와 다른 타이밍
                    {
                        while (!IsTiming(int.Parse(obj[2]))) // 타이밍을 찾는 중
                        {
                            if (currentTiming > int.Parse(obj[2]))
                                break;
                            rgo.Notes.Add(LongNoteValue(keyCount));
                            currentTiming += osu.OneTickTiming;
                            LongNoteEndCheck(keyCount);
                        }
                        rgo.Notes[rgo.Notes.Count - 1] += buttonValue + LongNoteValue(keyCount);
                    }
                }
                else
                {
                    if (timingPoints)
                    {
                        string[] obj = line.Split(',');
                        osu.Offset = int.Parse(obj[0]);
                        osu.OneBeatTiming = double.Parse(obj[1]);
                        osu.OneTickTiming = osu.OneBeatTiming / 4.0;
                        osu.BPM = (int)(1000.0 / osu.OneBeatTiming * 60.0);
                        timingPoints = false;
                    }
                    else if (line.Contains("osu file format"))
                    {
                        osu.Version = int.Parse(line.Replace("osu file format v", ""));
                    }
                    else if (line.Contains("AudioFilename: "))
                    {
                        osu.AudioFileName = line.Replace("AudioFilename: ", "");
                    }
                    else if (line.Contains("Title:"))
                    {
                        osu.Title = line.Replace("Title:", "");
                    }
                    else if (line.Contains("Artist:"))
                    {
                        osu.Artist = line.Replace("Artist:", "");
                    }
                    else if (line.Contains("Creator:"))
                    {
                        osu.Creator = line.Replace("Creator:", "");
                    }
                    else if (line.Contains("[TimingPoints]"))
                    {
                        timingPoints = true;
                    }
                    else if (line.Contains("[HitObjects]"))
                    {
                        hitObjects = true;
                    }
                }
            }
            sr.Close();
            fs.Close();
            #endregion

            #region RhythmGameObjectsToKShoot
            kshoot.Title = osu.Title;
            kshoot.Artist = osu.Artist;
            kshoot.Effect = osu.Creator;
            kshoot.Jacket = jacketDirectoryTextBox.Text;
            kshoot.Illustrator = illustratorTextBox.Text;
            kshoot.Difficulty = difficultyComboBox.SelectedIndex;
            kshoot.Level = int.Parse(levelTextBox.Text);
            kshoot.T = osu.BPM;
            kshoot.M = musicDirectoryTextBox.Text;
            kshoot.MVol = 80;
            kshoot.O = osu.Offset;
            kshoot.Bg = backgroundComboBox.SelectedIndex;
            kshoot.Layer = layerComboBox.SelectedIndex;
            kshoot.Po = 0;
            kshoot.Plength = 15000;
            kshoot.PFilterGain = 0;
            kshoot.ChokkakuAutoVol = 0;
            kshoot.ChokkakuVol = 0;
            kshoot.Icon = iconDirectoryTextBox.Text;
            kshoot.Ver = "160";
            kshoot.Beat = "4/4";
            FileStream fs2 = new FileStream($"[converted]{kshoot.Title}.ksh", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs2, Encoding.UTF8);
            sw.WriteLine($"title={kshoot.Title}");
            sw.WriteLine($"artist={kshoot.Artist}");
            sw.WriteLine($"effect={kshoot.Effect}");
            sw.WriteLine($"jacket={kshoot.Jacket}");
            sw.WriteLine($"illustrator={kshoot.Illustrator}");
            sw.WriteLine($"difficulty={kshoot.DifficultiesKS[kshoot.Difficulty]}");
            sw.WriteLine($"level={kshoot.Level}");
            sw.WriteLine($"t={kshoot.T}");
            sw.WriteLine($"m={kshoot.M}");
            sw.WriteLine($"mvol={kshoot.MVol}");
            sw.WriteLine($"o={kshoot.O}");
            sw.WriteLine($"bg={kshoot.BackGrounds[kshoot.Bg]}");
            sw.WriteLine($"layer={kshoot.Layers[kshoot.Layer]}");
            sw.WriteLine($"po={kshoot.Po}");
            sw.WriteLine($"plength={kshoot.Plength}");
            sw.WriteLine($"pfiltergain={kshoot.PFilterGain}");
            sw.WriteLine($"chokkakuautovol={kshoot.ChokkakuAutoVol}");
            sw.WriteLine($"chokkakuvol={kshoot.ChokkakuVol}");
            sw.WriteLine($"icon={kshoot.Icon}");
            sw.WriteLine($"ver={kshoot.Ver}");
            sw.WriteLine("--");
            sw.WriteLine($"beat={kshoot.Beat}");
            sw.WriteLine($"t={kshoot.T}");
            for (int i = 0; i < rgo.Notes.Count; i++)
            {
                if (i % 16 == 0)
                    sw.WriteLine("--");
                sw.WriteLine(NoteParse(keyCount, rgo.Notes[i], co));
            }
            sw.Flush();
            sw.Close();
            fs2.Close();
            #endregion
        }

        bool IsTiming(int timing)
        {
            if (Math.Abs(currentTiming - timing) <= 2)
                return true;
            else
                return false;
        }

        int LongNoteValue(int keyCount)
        {
            int sum = 0;
            for (int i = 0; i < keyCount; i++)
            {
                if (osu.LongNoteEndTiming[i] > 0)
                    sum += (int)Math.Pow(2, i + keyCount);
            }
            return sum;
        }

        void LongNoteEndCheck(int keyCount)
        {
            for (int i = 0; i < keyCount; i++)
            {
                if (IsTiming(osu.LongNoteEndTiming[i]))
                {
                    osu.LongNoteEndTiming[i] = 0;
                }
            }
        }

        string NoteParse(int keyCount, int noteNum, ConvertOptions co)
        {
            Random random = new Random();
            bool[] button = new bool[keyCount * 2];
            bool[] knobSustain = new bool[2];
            int temp = noteNum;
            string str = string.Empty;
            for (int i = 0; i < keyCount * 2; i++)
            {
                if (temp >= (int)Math.Pow(2, keyCount * 2 - i))
                {
                    temp -= (int)Math.Pow(2, keyCount * 2 - i);
                    button[keyCount * 2 - 1 - i] = true;
                }
            }
            if (keyCount == 4)
            {
                switch (co)
                {
                    case ConvertOptions.OnlyButton:
                        for (int i = 0; i < keyCount; i++)
                        {
                            if (button[i])
                                str += "1";
                            else if (button[i + keyCount])
                                str += "2";
                            else
                                str += "0";
                        }
                        return str + "|00|--";
                }
            }
            else if (keyCount == 7)
            {
                switch (co)
                {
                    case ConvertOptions.ButtonAndFX:
                        if (button[1]) str += "1";
                        else if (button[8]) str += "2";
                        else str += "0";
                        if (button[2]) str += "1";
                        else if (button[9]) str += "2";
                        else str += "0";
                        if (button[4]) str += "1";
                        else if (button[11]) str += "2";
                        else str += "0";
                        if (button[5]) str += "1";
                        else if (button[12]) str += "2";
                        else str += "0";
                        str += "|";
                        if (button[0]) str += "2";
                        else if (button[7]) str += "1";
                        else str += "0";
                        if (button[6]) str += "2";
                        else if (button[13]) str += "1";
                        else str += "0";
                        return str += "|--";
                    case ConvertOptions.All:
                        if (button[1]) str += "1";
                        else if (button[8]) str += "2";
                        else str += "0";
                        if (button[2]) str += "1";
                        else if (button[9]) str += "2";
                        else str += "0";
                        if (button[4]) str += "1";
                        else if (button[11]) str += "2";
                        else str += "0";
                        if (button[5]) str += "1";
                        else if (button[12]) str += "2";
                        else str += "0";
                        str += "|";
                        if (button[0]) str += "2";
                        else if (button[7]) str += "1";
                        else str += "0";
                        if (button[6]) str += "2";
                        else if (button[13]) str += "1";
                        else str += "0";
                        str += "|";

                        knobLength[0]--;
                        knobLength[1]--;
                        // 노브 버튼이 나오고 노브 중 하나라도 유지가 안되고 있으면
                        if (button[3] && (knobLength[0] < 0 || knobLength[1] < 0))
                        {
                            if (knobLength[0] >= 0 && knobLength[1] < 0)
                            {
                                str += knobLength[0] == 0 ? "oo" : ":o";
                                knobLength[1] = random.Next(14) + 2;
                            }
                            else if (knobLength[0] < 0 && knobLength[1] >= 0)
                            {
                                str += knobLength[1] == 0 ? "00" : "0:";
                                knobLength[0] = random.Next(14) + 2;
                            }
                            else
                            {
                                int num = random.Next(2);
                                str += num == 0 ? "0-" : "-o";
                                knobLength[num] = random.Next(14) + 2;
                            }
                        }
                        // TODO: 노브 롱노트
                        // 노브 버튼이 안나오면
                        else
                        {
                            str += knobLength[0] > 0 ? ":" : knobLength[0] == 0 ? "o" : "-";
                            str += knobLength[1] > 0 ? ":" : knobLength[1] == 0 ? "0" : "-";
                        }
                        return str;
                }
            }

            return "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string str in kshoot.Difficulties)
                difficultyComboBox.Items.Add(str);
            foreach (string str in kshoot.BackGrounds)
                backgroundComboBox.Items.Add(str);
            foreach (string str in kshoot.Layers)
                layerComboBox.Items.Add(str);

            difficultyComboBox.SelectedIndex = 3;
            backgroundComboBox.SelectedIndex = 0;
            layerComboBox.SelectedIndex = 0;
        }

        private void JacketDirectorySearchButton_Click(object sender, EventArgs e)
        {
            if (openJacketFileDialog.ShowDialog() == DialogResult.OK)
            {
                jacketDirectoryTextBox.Text = openJacketFileDialog.FileName;
            }
        }

        private void MusicDirectorySearchButton_Click(object sender, EventArgs e)
        {
            if (openMusicFileDialog.ShowDialog() == DialogResult.OK)
            {
                musicDirectoryTextBox.Text = openMusicFileDialog.FileName;
            }
        }

        private void IconDirectorySearchButton_Click(object sender, EventArgs e)
        {
            if (openIconFileDialog.ShowDialog() == DialogResult.OK)
            {
                iconDirectoryTextBox.Text = openIconFileDialog.FileName;
            }
        }
    }

    public class Osu
    {
        public int Version;
        public string AudioFileName;
        public string Title;
        public string Artist;
        public string Creator;
        public int Offset;
        public double OneBeatTiming;
        public double OneTickTiming;
        public int BPM;
        public int[] LongNoteEndTiming;

        public Osu()
        {
        }
    }

    public class RhythmGameObjects
    {
        public int KeyCount; // 4,5,6,7
        public int BPM; // 130,140,150
        public int BeatCount; // 16, 24, 32
        public List<int> Notes = new List<int>(); // 0:빈 공간, 1~:노트 나오는 번호

        public RhythmGameObjects()
        {

        }
    }

    public class KShoot
    {
        public string[] Difficulties = { "NOV", "ADV", "EXH", "MXM" };
        public string[] DifficultiesKS = { "light", "challenge", "extended", "infinite" };
        public string[] BackGrounds = { "sunset", "desert" };
        public string[] Layers = { "arrow", "smoke" };

        public string Title;
        public string Artist;
        public string Effect;
        public string Jacket;
        public string Illustrator;
        public int Difficulty;
        public int Level;
        public int T;
        public string M;
        public int MVol;
        public int O;
        public int Bg;
        public int Layer;
        public int Po;
        public int Plength;
        public int PFilterGain;
        public int ChokkakuAutoVol;
        public int ChokkakuVol;
        public string Icon;
        public string Ver;
        public string Beat;

        public KShoot()
        {

        }
    }
}
