namespace Doctor.Web.Application.DataServiceClients
{
    using Doctor.Web.Application.Commands;
    using Doctor.Web.Application.Dtos;
    using Microsoft.VisualBasic;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;
    public class PrescriptionsServiceClient : IPrescriptionsServiceClient
    {
        public IHttpClientFactory clientFactory;

        public PrescriptionsServiceClient(IHttpClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public async Task<IEnumerable<PrescriptionDto>> GetPrescriptionsByDoctorId(int doctorId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
            Environment.GetEnvironmentVariable("Prescriptionaddr") + "/prescriptions-by-doctor-id?doctorId=" + doctorId);
            var body = JsonSerializer.Serialize(doctorId);
            request.Content = new StringContent(body, Encoding.UTF8, "application/json");
            var client = clientFactory.CreateClient();
            var response = await client.SendAsync(request);
            using var responseStream = await response.Content.ReadAsStreamAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };


            return await JsonSerializer.DeserializeAsync<IEnumerable<PrescriptionDto>>(responseStream, options);
        }

        public void PostPrescription(AddPrescriptionCommand command)
        {
            var body = JsonSerializer.Serialize(command);
            var request = new HttpRequestMessage(HttpMethod.Post,
            Environment.GetEnvironmentVariable("Prescriptionaddr") + "/prescription-add");
            request.Content = new StringContent(body, Encoding.UTF8, "application/json");
            var client = clientFactory.CreateClient();
            var response = client.SendAsync(request);
        }


    }
}
