using Blazored.LocalStorage;
using POD_App.Models;

namespace POD_App.Services
{
    public class SessionServices
    {
        public ILocalStorageService LocalStorageService { get; set; }

        public SessionServices(ILocalStorageService localStorageService) 
        {
            LocalStorageService = localStorageService;
        }

        public async Task<BSessionDataM> GetSessionData()
        {
            BSessionDataM _LocalStorageService = new BSessionDataM();
             _LocalStorageService = await LocalStorageService.GetItemAsync<BSessionDataM>("_SESSION_LOGAUTH_Datas");

            return _LocalStorageService;
        } 


    }
}
