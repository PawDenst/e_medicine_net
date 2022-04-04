using Patient.Web.Application.Commands;
using Patient.Web.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Patient.Web.Application.DataServiceClients
{
    public class VisitsServiceClient : IVisitsServiceClient
    {
        public IHttpClientFactory clientFactory;

        public VisitsServiceClient(IHttpClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public async Task<IEnumerable<VisitDto>> GetVisitsByPatientId(int patientId)
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
           Environment.GetEnvironmentVariable("Visitsaddr") + "visitsByDoctorId?doctorId=" + patientId);
            var body = JsonSerializer.Serialize(patientId);
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

        public void PostVisit(AddVisitCommand command)
        {
            var body = JsonSerializer.Serialize(command);
            var request = new HttpRequestMessage(HttpMethod.Post,
              Constants.VisitsConnectionString + "/addVisit");
            request.Content = new StringContent(body, Encoding.UTF8, "application/json");
            var client = clientFactory.CreateClient();
            var response = client.SendAsync(request);
        }

        public async Task<IEnumerable<VisitDto>> GetAllVisits()
        {
            var request = new HttpRequestMessage(HttpMethod.Get,
         Constants.VisitsConnectionString + "/visits");
            request.Headers.Add("Accept", "application/json");
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
