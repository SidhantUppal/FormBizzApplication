using System.Threading.Tasks;
using Syntaq.Falcon.Views;
using Xamarin.Forms;

namespace Syntaq.Falcon.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
