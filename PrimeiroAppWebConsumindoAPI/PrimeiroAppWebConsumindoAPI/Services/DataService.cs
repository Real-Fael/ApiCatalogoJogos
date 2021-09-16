using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

using PrimeiroAppWebConsumindoAPI.Models;


namespace PrimeiroAppWebConsumindoAPI.Service
{
    public class DataService
    {
        HttpClient client = new HttpClient();
        public async Task<List<Jogo>> GetJogosAsync( int pagina = 1, int quantidade = 5)
        {
            try
            {
                string url = $"https://localhost:44354/api/v1/Jogos?pagina={pagina}&quantidade={quantidade}";
                var response = await client.GetStringAsync(url);
                List<Jogo> produtos = JsonConvert.DeserializeObject<List<Jogo>>(response);
                return produtos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Jogo> GetJogo(string id)
        {
            try
            {
                string url = string.Format("https://localhost:44354/api/v1/Jogos/{0}",id);
                var response = await client.GetStringAsync(url);
                Jogo jogo = JsonConvert.DeserializeObject<Jogo>(response);
                return jogo;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task AddJogoAsync(Jogo jogo)
        {
            try
            {
                string url = "https://localhost:44354/api/v1/Jogos/{0}";
                var uri = new Uri(string.Format(url, jogo.Id));
                var data = JsonConvert.SerializeObject(jogo);
                var content = new StringContent(data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = null;
                response = await client.PostAsync(uri, content);

                if (!response.IsSuccessStatusCode)
                {
                    throw new Exception("Erro ao incluir produto");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task UpdateJogoAsync(Jogo jogo)
        {
            string url = "https://localhost:44354/api/v1/Jogos/{0}";
            var uri = new Uri(string.Format(url, jogo.Id));
            var data = JsonConvert.SerializeObject(jogo);
            var content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = null;
            response = await client.PutAsync(uri, content);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Erro ao atualizar produto");
            }
        }
        public async Task<HttpResponseMessage> DeletaJogoAsync(string id)
        {
            string url = "https://localhost:44354/api/v1/Jogos/{0}";
            var uri = new Uri(string.Format(url, id));
            return await client.DeleteAsync(uri);
        }
    }
}
