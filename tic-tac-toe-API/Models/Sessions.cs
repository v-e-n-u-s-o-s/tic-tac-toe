namespace tic_tac_toe_API.Models
{
    public class Sessions
    {
        private readonly DbTools db_tools;
        private readonly string database = "sessions";
        public Sessions()
        {
            db_tools = new DbTools("localhost", "tic-tac-toe", "api", "^r~b]PP#D*R5c7/s");
            DeleteOldSessions();
        }
        private void DeleteOldSessions()
        {
            string condition = "timestamp < (NOW() - INTERVAL 5 MINUTE)";
            db_tools.Delete(database, condition);
        }
        public void CreateSession(long player_1)
        {
            string[] columns = new string[] { "COUNT(player_1)" };
            string[] values = new string[] { "", $"(S) ; ; ; ; ; ; ; ; ;{(new Random().NextDouble() >= 0.5 ? "true" : "false")}" };
            string conditions = $"player_1 = {player_1}";
            List<string>[] result = db_tools.Select(database, columns, conditions);
            int session = Convert.ToInt32(result[0][0]);
            if (session is 0)
            {
                columns = new string[] { "player_1", "data" };
                values[0] = "(I)" + player_1;
                db_tools.Insert(database, columns, values);
            }
            else
            {
                columns = new string[] { "player_2", "data" };
                values[0] = "(I)0";
                conditions = $"player_1 = {player_1}";
                db_tools.Update(database, columns, values, conditions);
            }
        }
        public void JoinSession(long player_1, long player_2)
        {
            string[] columns = new string[] { "player_2" };
            string[] values = new string[] { $"(I){player_2}" };
            string conditions = $"player_1 = {player_1} AND player_2 = 0";
            db_tools.Update(database, columns, values, conditions);
        }
        public string GetData(long player_x)
        {
            string[] columns = new string[] { "data" };
            string conditions = $"player_1 = {player_x} OR player_2 = {player_x}";
            List<string>[] result = db_tools.Select(database, columns, conditions);
            try { return result[0][0]; }
            catch { return ""; }
        }
        public void SetData(long player_1, string data)
        {
            string[] columns = new string[] { "data" };
            string[] values = new string[] { $"(S){data}" };
            string conditions = $"player_1 = {player_1}";
            db_tools.Update(database, columns, values, conditions);
        }
    }
}
