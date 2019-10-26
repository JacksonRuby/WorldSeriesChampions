using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldSeriesChampions
{
    public class GameInfo
    {
        public int YearWon { get; set; }
        public string Score { get; set; }
        public string LosingTeam { get; set; }

        public GameInfo()
        {
            YearWon = 0;
            Score = "";
            LosingTeam = "";
        }

        public override string ToString()
        {
            return YearWon.ToString();
        }
    }
}
