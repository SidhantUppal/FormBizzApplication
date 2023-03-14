using System.Collections.Generic;
using MvvmHelpers;
using Syntaq.Falcon.Models.NavigationMenu;

namespace Syntaq.Falcon.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}