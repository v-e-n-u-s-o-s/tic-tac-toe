namespace tic_tac_toe_CLIENT.Models
{
    public class Board
    {
        public static string[,] board_data { get; set; }
        public static void refresh_board(bool online = false)
        {
            string[] comparator_cross = { "X", "X", "X" };
            string[] comparator_circle = { "O", "O", "O" };
            string[] comparator_x = new string[3];
            string[] comparator_y = new string[3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    comparator_x[j] = board_data[i, j];
                    comparator_y[j] = board_data[j, i];
                    Button button = Application.OpenForms["Main"].Controls.Find("board_" + i + "_" + j, true).FirstOrDefault() as Button;
                    button.Text = board_data[i, j];
                }
                if (Enumerable.SequenceEqual(comparator_cross, comparator_x))
                {
                    Main.win(true, online);
                }
                else if (Enumerable.SequenceEqual(comparator_circle, comparator_x))
                {
                    Main.win(false, online);
                }
                else if (Enumerable.SequenceEqual(comparator_cross, comparator_y))
                {
                    Main.win(true, online);
                }
                else if (Enumerable.SequenceEqual(comparator_circle, comparator_y))
                {
                    Main.win(false, online);
                }

                comparator_x = new string[3];
                comparator_y = new string[3];
            }
            for (int i = 0; i < 3; i++)
            {
                comparator_x[i] = board_data[i, i];
                comparator_y[i] = board_data[2 - i, i];
            }
            if (Enumerable.SequenceEqual(comparator_cross, comparator_x))
            {
                Main.win(true, online);
            }
            else if (Enumerable.SequenceEqual(comparator_circle, comparator_x))
            {
                Main.win(false, online);
            }
            else if (Enumerable.SequenceEqual(comparator_cross, comparator_y))
            {
                Main.win(true, online);
            }
            else if (Enumerable.SequenceEqual(comparator_circle, comparator_y))
            {
                Main.win(false, online);
            }
        }

        public static void update_data(object source, System.Timers.ElapsedEventArgs e)
        {
            string response = ApiConnection.GetData(Main.session_id).Result;
            if (response is null)
            {
                return;
            }

            string[] list = response.Split(';');
            if (Main.side == Convert.ToBoolean(list[list.Length - 1]))
            {
                return;
            }

            int k = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board_data[i, j] = list[k];
                    k++;
                }
            }
            Main main = new Main();
            main.refresh_controls();
            refresh_board();
        }
    }
}
