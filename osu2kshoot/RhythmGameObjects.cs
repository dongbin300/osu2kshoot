using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osu2kshoot
{
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

    public class Osu
    {
        public int Version;
        public string AudioFileName;
        public string Title;
        public string Artist;
        public string Creator;
        public string BeatMapVersion;
        public int Offset;
        public double OneBeatTiming;
        public double OneTickTiming;
        public int BPM;
        public int[] LongNoteEndTiming;
        public int FirstNoteTiming;
        public int LastNoteTiming;
        public int NoteCount;

        public Osu()
        {
        }
    }

    public class KShoot
    {
        public string[] Difficulties = { "NOV", "ADV", "EXH", "MXM" };
        public string[] DifficultiesKS = { "light", "challenge", "extended", "infinite" };
        public string[] BackGrounds = { "desert", "sunset" };
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
        public string FilterType;
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
