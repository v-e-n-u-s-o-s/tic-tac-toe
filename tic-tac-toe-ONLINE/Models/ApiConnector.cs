using System.Net.Http.Headers;

namespace tic_tac_toe_ONLINE.Models
{
    public class ApiConnector
    {
        private static readonly HttpClient httpClient = new HttpClient();
        public static async void CreateSession(long player_1)
        {
            try
            {
                using (HttpRequestMessage? request = new HttpRequestMessage(new HttpMethod("POST"), "http://18.134.47.108:5000/api/Sessions/Create"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "*/*");

                    request.Content = new StringContent($"\"{player_1}\"");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    HttpResponseMessage? response = await httpClient.SendAsync(request);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public static async void JoinSession(long player_1, long player_2)
        {
            try
            {
                using (HttpRequestMessage? request = new HttpRequestMessage(new HttpMethod("PUT"), $"http://18.134.47.108:5000/api/Sessions/Join/{player_1}"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "*/*");

                    request.Content = new StringContent($"\"{player_2}\"");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    HttpResponseMessage? response = await httpClient.SendAsync(request);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        public static async Task<string> GetData(long player_x)
        {
            try
            {
                using (HttpRequestMessage? request = new HttpRequestMessage(new HttpMethod("GET"), $"http://18.134.47.108:5000/api/Game/Get/{player_x}"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "text/plain");

                    HttpResponseMessage? response = await httpClient.SendAsync(request);

                    return await response.Content.ReadAsStringAsync();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return ""; }
        }
        public static async void SetData(long player_1, string data)
        {
            try
            {
                using (HttpRequestMessage? request = new HttpRequestMessage(new HttpMethod("PUT"), $"http://18.134.47.108:5000/api/Game/Set/{player_1}"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "*/*");

                    request.Content = new StringContent($"\"{data}\"");
                    request.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");

                    HttpResponseMessage? response = await httpClient.SendAsync(request);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
