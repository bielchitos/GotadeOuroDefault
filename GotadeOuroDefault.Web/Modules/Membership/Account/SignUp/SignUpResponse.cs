using Serenity.Services;

namespace GotadeOuroDefault.Membership
{
    public class SignUpResponse : ServiceResponse
    {
        public string DemoActivationLink { get; set; }
    }
}