/*
 * FILE         : Team.cs
 * PROJECT      : Assignment 1 - Group 3
 * PROGRAMMER   : Jackson Ruby
 * DATE         : Nov. 5, 2019
 * DESCRIPTION  :
 *      Class for a team. Holds all information about a team.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WorldSeriesChampions
{
    public class Team
    {
        public string Name { get; set; }

        public BindingList<GameInfo> YearsWon { get; set; }

        public Team()
        {
            Name = "";
            YearsWon = new BindingList<GameInfo>();
        }

        public Team(string teamName)
        {
            Name = teamName;
            YearsWon = new BindingList<GameInfo>();
        }

        public void AddYearWon(GameInfo newYearWon)
        {
            YearsWon.Add(newYearWon);
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
