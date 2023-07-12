using Serenity.Services;
using MyRequest = GotadeOuroDefault.Administration.UserListRequest;
using MyResponse = Serenity.Services.ListResponse<GotadeOuroDefault.Administration.UserRow>;
using MyRow = GotadeOuroDefault.Administration.UserRow;

namespace GotadeOuroDefault.Administration
{
    public interface IUserListHandler : IListHandler<MyRow, MyRequest, MyResponse> { }

    public class UserListHandler : ListRequestHandler<MyRow, MyRequest, MyResponse>, IUserListHandler
    {
        public UserListHandler(IRequestContext context)
             : base(context)
        {
        }
    }
}