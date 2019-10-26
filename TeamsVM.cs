using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WorldSeriesChampions
{
    public class TeamsVM : INotifyPropertyChanged
    {
        const string TEAMS_FILE = "Teams.txt";
        const string WINNERS_FILE = "WorldSeriesWinners.txt";
        const string LOSERS_FILE = "WorldSeriesLosers.txt";
        const string SCORES_FILE = "Scores.txt";
        const int FIRST_YEAR = 1903;
        const int LAST_YEAR = 2018;
        const int NO_WORLD_SERIES_YEAR_1 = 1904;
        const int NO_WORLD_SERIES_YEAR_2 = 1994;

        private BindingList<Team> allTeams;
        public BindingList<Team> AllTeams
        {
            get { return allTeams; }
            set { allTeams = value; notifyChange(); }
        }

        private int allTeamsSelectedIndex;
        public int AllTeamsSelectedIndex
        {
            get { return allTeamsSelectedIndex; }
            set { allTeamsSelectedIndex = value; populateYearsWon(); notifyChange(); }
        }

        private BindingList<GameInfo> yearsWon;
        public BindingList<GameInfo> YearsWon
        {
            get { return yearsWon; }
            set { yearsWon = value; notifyChange(); }
        }

        private int yearsWonSelectedIndex;
        public int YearsWonSelectedIndex
        {
            get { return yearsWonSelectedIndex; }
            set { yearsWonSelectedIndex = value; populateGameInfo(); notifyChange(); }
        }

        private string score;
        public string Score 
        {
            get { return score; }
            set { score = value; notifyChange(); }
        }
        private string losingTeam;
        public string LosingTeam 
        {
            get { return losingTeam; }
            set { losingTeam = value; notifyChange(); }
        }

        public TeamsVM()
        {
            AllTeams = new BindingList<Team>();
            YearsWon = new BindingList<GameInfo>();

            List<string> teams = File.ReadAllLines(TEAMS_FILE).ToList();
            List<string> winners = File.ReadAllLines(WINNERS_FILE).ToList();
            List<string> losers = File.ReadAllLines(LOSERS_FILE).ToList();
            List<string> scores = File.ReadAllLines(SCORES_FILE).ToList();

            for (int i = 0; i < teams.Count; i++)
            {
                Team newTeam = new Team(teams[i]);
                int yearValue = FIRST_YEAR;
                int iterator = 0;
                while (yearValue <= LAST_YEAR)
                {
                    if (yearValue != NO_WORLD_SERIES_YEAR_1 && yearValue != NO_WORLD_SERIES_YEAR_2)
                    {
                        GameInfo newGameInfo = new GameInfo
                        {
                            YearWon = yearValue,
                            Score = scores[iterator],
                            LosingTeam = losers[iterator]
                        };
                        if (winners[iterator] == teams[i])
                        {
                            newTeam.AddYearWon(newGameInfo);
                        }
                        iterator++;
                    }
                    yearValue++;
                }

                AllTeams.Add(newTeam);
            }

            AllTeamsSelectedIndex = 0;
        }

        private void populateYearsWon()
        {
            YearsWon = allTeams[allTeamsSelectedIndex].YearsWon;
            YearsWonSelectedIndex = 0;
        }

        private void populateGameInfo()
        {
            if (yearsWonSelectedIndex >= 0)
            {
                Score = yearsWon[yearsWonSelectedIndex].Score;
                LosingTeam = yearsWon[yearsWonSelectedIndex].LosingTeam;
            }
        }

        #region notifyChange
        //property changed event handler
        public event PropertyChangedEventHandler PropertyChanged;
        private void notifyChange([CallerMemberName]string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
        #endregion notifyChange
    }
}
