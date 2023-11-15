using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSUP
{
    public class RequestRSUP
    {
        public string GetLoginToken()
        {
            string LoginToken = "";
            string endPoint = "https://apip2.myrsup.co.id:8089/RSUPInd.Api/Auth/Login";
            HttpClient client = new HttpClient();
            var requestBody = new
            {
                userName = "nintex",
                password = "nt@12345",
                computerName = "<string>"
            };

            var jsonBody = JsonConvert.SerializeObject(requestBody);
            var httpContent = new StringContent(jsonBody, Encoding.UTF8, "application/json");
            var response = client.PostAsync(endPoint, httpContent).Result;
            var responseJson = response.Content.ReadAsStringAsync().Result;
            var responseObject = JsonConvert.DeserializeObject<dynamic>(responseJson);
            LoginToken = responseObject.Results.Token;

            return LoginToken;  
        }
    }
}
