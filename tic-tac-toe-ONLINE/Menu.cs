using System.Net.NetworkInformation;
using tic_tac_toe_ONLINE.Models;

namespace tic_tac_toe_ONLINE
{
    public partial class Menu : Form
    {
        public static long id = Convert.ToInt64(NetworkInterface.GetAllNetworkInterfaces().Where(nic => nic.OperationalStatus == OperationalStatus.Up).Select(nic => nic.GetPhysicalAddress().ToString()).FirstOrDefault());
        public static long sessionId = 0;
        public static bool side;
        public static bool turn;
        public bool halo;
        public Menu()
        {
            InitializeComponent();
            halo = true;
        }

        private void Button_CreateSession_Click(object sender, EventArgs e)
        {


        }

        private void Button_JoinSession_Click(object sender, EventArgs e)
        {
            side = Convert.ToBoolean(false);
            try { sessionId = Convert.ToInt64(NumericUpDown_SessionId.Value.ToString()); }
            catch { sessionId = 0; }
            if (sessionId > 0)
            {
                ApiConnector.JoinSession(sessionId, id);
                if (ApiConnector.GetData(id).Result.Length > 0)
                {
                    new Main();
                }
                else
                {
                    MessageBox.Show("Error connecting to session.");
                }
            }
            else
            {
                MessageBox.Show("Enter valid session id.");
            }
        }
    }
}