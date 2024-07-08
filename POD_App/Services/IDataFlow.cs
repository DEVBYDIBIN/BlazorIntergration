using POD_App.Models;

namespace POD_App.Services
{
    public interface IDataFlow
    {
        
        public Task<LoginResponsM> LoginAuth(LoginModel loginCredentials);
       
        public Task<List<UniversityL>> GetUversity();
        public Task<Htest> GetHolidays();
        public Task<USAPL> GetUSAP();
        public Task<CryptoL> GetCryptoL();
        public Task<SpaceEML> GetSpaceEvents();
        public Task<List<HongKongM>> GetHongKongD();

    }
}
