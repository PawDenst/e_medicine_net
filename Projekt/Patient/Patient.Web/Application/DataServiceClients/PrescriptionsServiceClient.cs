using Patient.Web.Application.Commands;
using Patient.Web.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Patient.Web.Application;

namespace Patient.Web.Application.DataServiceClients
{
    public class PrescriptionsServiceClient : IPrescriptionsServiceClient
    {
        public IHttpClientFactory clientFactory;

        public PrescriptionsServiceClient(IHttpClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public async Task<IEnumerable<PrescriptionDto>> GetPrescriptionsByPatientId(int patientId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
           Environment.GetEnvironmentVariable("Prescriptionaddr") + "/prescriptions-by-doctor-id?doctorId=" + patientId);
            var body = JsonSerializer.Serialize(patientId);
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
    }
}
