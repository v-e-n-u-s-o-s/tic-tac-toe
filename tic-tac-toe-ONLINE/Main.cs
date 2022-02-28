using System.Data;

using tic_tac_toe_ONLINE.Models;

namespace tic_tac_toe_ONLINE
{
    public partial class Main : Form
    {
        // --------------------------------[ PROPETRIES ]-------------------------------- //

        //private static System.Timers.Timer aTimer;

        // ----------------------------------[ METHODS ]---------------------------------- //
        public Main()
        {
            InitializeComponent();
            //BoardTools.boardData = new string[3, 3];
            //aTimer = new System.Timers.Timer
            //{
            //    Interval = 250
            //};
            //aTimer.Elapsed += BoardTools.SyncData;
        }
    }
}
