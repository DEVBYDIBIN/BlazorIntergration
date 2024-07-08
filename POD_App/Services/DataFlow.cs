using Newtonsoft.Json;
using POD_App.Models;
using RestSharp;

using System;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using Microsoft.AspNetCore.DataProtection.KeyManagement;

namespace POD_App.Services
{
    public class DataFlow:IDataFlow
    {
        public readonly IConfiguration Configuration;

        public DataFlow(IConfiguration configuration)
        {
            Configuration = configuration;
        }

 
        //LoginAUTH
        public async Task<LoginResponsM> LoginAuth(LoginModel loginCredentials)
        {
            LoginResponsM loginResponsM = new LoginResponsM();
           if (loginCredentials.Password == "1@123" & loginCredentials.Username =="pass@123")        
            {
                loginResponsM.Status = true;
                loginResponsM.StatusCode = 200;
                loginResponsM.JWTToken ="kjhkjhdsakdjhaskdhakjdhaksdjhaskdjhadskjha";
               
            }
            else {
                loginResponsM.Status = false;
            }
           return loginResponsM;   
        }
  
        public async Task<List<UniversityL>> GetUversity()
        {
            List<UniversityL> LT_Uver = new List<UniversityL>();
            try
            {
                var url = "http://universities.hipolabs.com/search?country=United+States";


                var client = new HttpClient();
        
                var response = await client.GetAsync(url);
                string apiResponse = await response.Content.ReadAsStringAsync();
                LT_Uver = JsonConvert.DeserializeObject<List<UniversityL>>(apiResponse); // Assign the deserialized response to Lt_master
                if (response.IsSuccessStatusCode == true)
                {
                    return LT_Uver;
                }          
            }
            catch (Exception ex)
            {

            }      
            return LT_Uver;
        }
        public async Task<Htest> GetHolidays()
        {
            Htest LT_Uver = new Htest();
            try
            {
                var url = "https://www.gov.uk/bank-holidays.json";


                var client = new HttpClient();

                var response = await client.GetAsync(url);
                string apiResponse = await response.Content.ReadAsStringAsync();
                LT_Uver = JsonConvert.DeserializeObject<Htest>(apiResponse); // Assign the deserialized response to Lt_master
                if (response.IsSuccessStatusCode == true)
                {
                    return LT_Uver;
                }
            }
            catch (Exception ex)
            {

            }
            return LT_Uver;
        }
        public async Task<USAPL> GetUSAP()
        {
            USAPL LT_Uver = new USAPL();
            try
            {
                var url = "https://datausa.io/api/data?drilldowns=Nation&measures=Population";


                var client = new HttpClient();

                var response = await client.GetAsync(url);
                string apiResponse = await response.Content.ReadAsStringAsync();
                LT_Uver = JsonConvert.DeserializeObject<USAPL>(apiResponse); // Assign the deserialized response to Lt_master
                if (response.IsSuccessStatusCode == true)
                {
                    return LT_Uver;           
                }
            }
            catch (Exception ex)
            {

            }
            return LT_Uver;
        }
        public async Task<CryptoL> GetCryptoL()
        {
            CryptoL LT_Uver = new CryptoL();
            try
            {
                var url = "https://api.coincap.io/v2/assets";


                var client = new HttpClient();

                var response = await client.GetAsync(url);
                string apiResponse = await response.Content.ReadAsStringAsync();
                LT_Uver = JsonConvert.DeserializeObject<CryptoL>(apiResponse); // Assign the deserialized response to Lt_master
                if (response.IsSuccessStatusCode == true)
                {
                    return LT_Uver;
                }
            }
            catch (Exception ex)
            {

            }
            return LT_Uver;
        }
        public async Task<SpaceEML> GetSpaceEvents()
        {
            SpaceEML LT_Uver = new SpaceEML();
            try
            {
                var url = "https://ll.thespacedevs.com/2.2.0/agencies/?limit=100";


                var client = new HttpClient();

                var response = await client.GetAsync(url);
                string apiResponse = await response.Content.ReadAsStringAsync();
                LT_Uver = JsonConvert.DeserializeObject<SpaceEML>(apiResponse); // Assign the deserialized response to Lt_master
                if (response.IsSuccessStatusCode == true)
                {
                    return LT_Uver;
                }
            }
            catch (Exception ex)
            {

            }
            return LT_Uver;
        }
        public async Task<List<HongKongM>> GetHongKongD()
        {
            List<HongKongM> LT_Uver = new List<HongKongM>();
            try
            {
                var url = "https://geodata.gov.hk/gs/api/v1.0.0/locationSearch?q=museums";


                var client = new HttpClient();

                var response = await client.GetAsync(url);
                string apiResponse = await response.Content.ReadAsStringAsync();
                LT_Uver = JsonConvert.DeserializeObject<List<HongKongM>>(apiResponse); // Assign the deserialized response to Lt_master
                if (response.IsSuccessStatusCode == true)
                {
                    return LT_Uver;
                }
            }
            catch (Exception ex)
            {

            }
            return LT_Uver;

        }



    }

}
