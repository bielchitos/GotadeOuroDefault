using Serenity.Services;

namespace GotadeOuroDefault.Administration
{
    public class UserRoleListRequest : ServiceRequest
    {
        public int? UserID { get; set; }
    }
}