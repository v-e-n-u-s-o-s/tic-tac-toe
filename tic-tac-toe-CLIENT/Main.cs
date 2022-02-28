using System.Net.NetworkInformation;
using System.Text;
using tic_tac_toe_CLIENT.Models;

namespace tic_tac_toe_CLIENT
{
    public partial class Main : Form
    {
        // --------------------------------[ PROPETRIES ]-------------------------------- //

        public static long id;
        public static long session_id;
        public static bool side;
        public static bool turn;

        private static System.Timers.Timer aTimer;

        // ----------------------------------[ METHODS ]---------------------------------- //

        public Main()
        {
            InitializeComponent();
            string mac_address = NetworkInterface.GetAllNetworkInterfaces().Where(nic => nic.OperationalStatus == OperationalStatus.Up).Select(nic => nic.GetPhysicalAddress().ToString()).FirstOrDefault();
            if (mac_address is null)
            {
                id = long_random(281474976710656, 999999999999999, new Random());
            }
            else
            {
                id = Convert.ToInt64(mac_address, 16);
            }
            Board.board_data = new string[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Board.board_data[i, j] = " ";
                }
            }
            aTimer = new System.Timers.Timer
            {
                Interval = 250
            };
            aTimer.Elapsed += Board.update_data;
        }
        public static void win(bool turn, bool online)
        {
            if (!online)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Board.board_data[i, j] = " ";
                    }
                }
                Board.refresh_board();
                string result = turn ? "Cross" : "Circle";
                MessageBox.Show(result + " won!");
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Board.board_data[i, j] = " ";
                    }
                }
                Main main = new Main();
                main.update_list();
                Board.refresh_board();
                string result = turn ? "Cross" : "Circle";
                MessageBox.Show(result + " won!");
            }
        }
        private void load_board()
        {
            menu.Visible = false;
            game.Visible = true;
        }

        private long long_random(long min, long max, Random rand)
        {
            byte[] buf = new byte[8];
            rand.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);

            return Math.Abs(longRand % (max - min)) + min;
        }
        private void update_list()
        {
            StringBuilder string_builder = new StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button button = Controls.Find("board_" + i + "_" + j, true).FirstOrDefault() as Button;
                    Board.board_data[i, j] = button.Text;
                    string_builder.Append(button.Text + ";");
                }
            }
            string_builder.Append(turn);
            ApiConnection.SetData(session_id, string_builder.ToString());
        }
        private async void assign_onclick_events()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button button = Controls.Find("board_" + i + "_" + j, true).FirstOrDefault() as Button;
                    button.Click += async (sender, e) =>
                    {
                        if (Board.board_data[button.Name.ToArray()[6] - '0', button.Name.ToArray()[8] - '0'] == " " && side == turn)
                        {
                            Board.board_data[button.Name.ToArray()[6] - '0', button.Name.ToArray()[8] - '0'] = side ? "X" : "O";
                            turn = !turn;
                            StringBuilder string_builder = new StringBuilder();
                            for (int i = 0; i < 3; i++)
                            {
                                for (int j = 0; j < 3; j++)
                                {
                                    string_builder.Append(Board.board_data[i, j]);
                                    string_builder.Append(';');
                                }
                            }
                            string_builder.Append(turn.ToString());
                            ApiConnection.SetData(session_id, string_builder.ToString());
                            string data = await ApiConnection.GetData(session_id);
                            if (data is "")
                            {
                                MessageBox.Show("Error connecting to server.");
                                Close();
                            }
                            MessageBox.Show(data);
                        }
                        refresh_controls();
                        Board.refresh_board(true);
                    };
                }
            }
        }
        public async void refresh_controls()
        {
            string data = await ApiConnection.GetData(session_id);
            turn = Convert.ToBoolean(data.Split(';')[data.Split(';').Length - 1]);
            textbox_side.Text = side ? "You are cross" : "You are circle";
            textbox_turn.Text = turn ? "Cross turn" : "Circle turn";
        }

        // ----------------------------------[ EVENTS ]---------------------------------- //

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void button_start_offline_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            turn = random.NextDouble() >= 0.5; // true - cross, false - circle
            load_board();
            Board.refresh_board();
            textbox_turn.Text = turn ? "Cross turn." : "Circle turn.";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button button = Controls.Find("board_" + i + "_" + j, true).FirstOrDefault() as Button;
                    button.Click += (sender, e) =>
                        {
                            if (Board.board_data[button.Name.ToArray()[6] - '0', button.Name.ToArray()[8] - '0'] == " ")
                            {
                                Board.board_data[button.Name.ToArray()[6] - '0', button.Name.ToArray()[8] - '0'] = turn ? "X" : "O";
                                Board.refresh_board();
                                turn = !turn;
                                StringBuilder string_builder = new StringBuilder();
                                for (int i = 0; i < 3; i++)
                                {
                                    for (int j = 0; j < 3; j++)
                                    {
                                        string_builder.Append(Board.board_data[i, j]);
                                        string_builder.Append(';');
                                    }
                                }
                                string_builder.Append(turn.ToString());
                                ApiConnection.SetData(session_id, string_builder.ToString());
                                textbox_turn.Text = turn ? "Cross turn" : "Circle turn";
                            }
                            refresh_controls();
                        };
                }
            }
        }
        private void button_start_session_Click(object sender, EventArgs e)
        {
            side = true;
            session_id = id;
            ApiConnection.CreateSession(id);
            textbox_session_id.Visible = true;
            textbox_side.Visible = true;
            textbox_session_id.Text = id.ToString() + " <- session id";
            assign_onclick_events();
            refresh_controls();
            load_board();
            aTimer.Enabled = true;
        }
        private async void button_join_session_Click(object sender, EventArgs e)
        {
            side = false;
            session_id = Convert.ToInt64(numericbox_id.Value);
            ApiConnection.JoinSession(session_id, id);
            if (await ApiConnection.GetData(id) is "")
            {
                MessageBox.Show("Wrong session id.");
            }
            else if (await ApiConnection.GetData(id) is null)
            {
                MessageBox.Show("Something went wrong connecting to server.");
                Close();
            }
            else
            {
                assign_onclick_events();
                refresh_controls();
                load_board();
                aTimer.Enabled = true;
            }
        }
    }
}
