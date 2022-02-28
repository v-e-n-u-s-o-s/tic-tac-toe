namespace tic_tac_toe_ONLINE.Models
{
    public class BoardTools
    {
        public static string[,] boardData { get; set; }
        public static void SyncBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button button = Application.OpenForms["Main"].Controls.Find("board_" + i + "_" + j, true).FirstOrDefault() as Button;
                    button.Text = boardData[i, j];
                }
            }
            TextBox textBox = Application.OpenForms["Main"].Controls.Find("TextBox_Info", true).FirstOrDefault() as TextBox;
            textBox.Text = Menu.sessionId.ToString() + " <- session id,\n" + (Menu.side ? "CROSS" : "CIRCLE") + " <- your side,\n" + (Menu.turn ? "CROSS" : "CIRCLE") + " <- turn.";
        }
        public static void ok()
        {
            Menu.side = true;
        }
        public static void SyncData(object source, System.Timers.ElapsedEventArgs e)
        {
            string response = ApiConnector.GetData(Menu.sessionId).Result;
            if (response is null)
            {
                return;
            }

            string[] list = response.Split(';');
            if (Menu.side == Convert.ToBoolean(list[list.Length - 1]))
            {
                return;
            }

            int k = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    boardData[i, j] = list[k];
                    k++;
                }
            }
            SyncBoard();
        }
        public static string CheckForWin()
        {
            string result = "";
            for (int i = 0; i < 3; i++)
            {
                result = new[] { boardData[i, 0], boardData[i, 1], boardData[i, 2], "X" }.Distinct().Count() == 1 ? "X" : result;
                result = new[] { boardData[0, i], boardData[1, i], boardData[2, i], "X" }.Distinct().Count() == 1 ? "X" : result;
                result = new[] { boardData[i, 0], boardData[i, 1], boardData[i, 2], "O" }.Distinct().Count() == 1 ? "O" : result;
                result = new[] { boardData[0, i], boardData[1, i], boardData[2, i], "O" }.Distinct().Count() == 1 ? "O" : result;
            }
            result = new[] { boardData[0, 0], boardData[1, 1], boardData[2, 2], "X" }.Distinct().Count() == 1 ? "X" : result;
            result = new[] { boardData[0, 2], boardData[1, 1], boardData[2, 0], "X" }.Distinct().Count() == 1 ? "X" : result;
            result = new[] { boardData[0, 0], boardData[1, 1], boardData[2, 2], "O" }.Distinct().Count() == 1 ? "O" : result;
            result = new[] { boardData[0, 2], boardData[1, 1], boardData[2, 0], "O" }.Distinct().Count() == 1 ? "O" : result;
            return result;
        }
    }
}
