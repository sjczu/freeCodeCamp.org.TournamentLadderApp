using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Requirements
/// 1. Tracks games played and their outcome (who won + points scored/lost)
/// 2. Multiple competitors play in the tournament (n-competitors, if odd number add 1 wildcard)
/// 3. Creates a tournament plan (who plays in what order)
/// 4. Schedules games
/// 5. A single loss eliminates a player
/// 6. The last player standing is the winner
/// </summary>

namespace freeCodeCamp.org
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
