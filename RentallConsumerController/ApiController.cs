using RentallConsumerModel;
using RentallConsumerModel.AccessModels;
using RentallConsumerServices.ApiService;

namespace RentallConsumerController
{
    public class ApiController
    {
        LoginService loginservice;
        public ApiController()
        {
            loginservice = new LoginService();
        }

        public  GetClientSecretTokenResponse GetClientSecretToken(GetClientSecretTokenRequest getClientSecretTokenRequest)
        {
            return loginservice.GetClientSecretToken(getClientSecretTokenRequest);
        }

        public ApiToken GetAccessToken(GetAccessTokenRequest tokenRequest)
        {
            return loginservice.GetAccessToken(tokenRequest);
        }
    }
}
