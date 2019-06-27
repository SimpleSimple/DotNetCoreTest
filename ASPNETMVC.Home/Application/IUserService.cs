using MvcCore.Web.Core;
using System.Collections.Generic;

namespace MvcCore.Web.Application
{
    public interface IUserService   //: BaseService<User>
    {
        void Get();

        List<User> GetList();

        bool Insert();

        bool Update();

        bool Delete();

        bool DeleteList();
    }
}