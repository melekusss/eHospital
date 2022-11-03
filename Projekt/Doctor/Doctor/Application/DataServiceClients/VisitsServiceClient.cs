namespace Doctor.Web.Application.DataServiceClients
{
    using Doctor.Web.Application.Dtos;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;
    public class VisitsServiceClient : IVisitsServiceClient
    {
        public IHttpClientFactory clientFactory;

        public VisitsServiceClient(IHttpClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public async Task<IEnumerable<VisitDto>> GetVisitsByDoctorId(int doctorId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
            Environment.GetEnvironmentVariable("Visitsaddr") + "/visitsByDoctorId?doctorId=" + doctorId);
            var body = JsonSerializer.Serialize(doctorId);
            request.Content = new StringContent(body, Encoding.UTF8, "application/json");
            var client = clientFactory.CreateClient();
            var response = await client.SendAsync(request);
            using var responseStream = await response.Content.ReadAsStreamAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            return await JsonSerializer.DeserializeAsync<IEnumerable<VisitDto>>(responseStream, options);
        }


    }
}
