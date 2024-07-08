namespace POD_App.Models
{
    public class AuthenticateResultModel
    {
        public string AccessToken { get; set; }
        public int ExpireInSeconds { get; set; }
        public string RefreshToken { get; set; }
        public int RefreshTokenExpireInSeconds { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string UserTypeId { get; set; }
        public string UserType { get; set; }
    }
}
