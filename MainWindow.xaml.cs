/*
 * FILE         : MainWindow.xaml.cs
 * PROJECT      : Assignment 1 - Group 3
 * PROGRAMMER   : Jackson Ruby
 * DATE         : Nov. 5, 2019
 * DESCRIPTION  :
 *      Shows outcome of all world series games.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WorldSeriesChampions
{
    public partial class MainWindow : Window
    {

        private TeamsVM teamsViewModel = new TeamsVM();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = teamsViewModel;
        }
    }
}
