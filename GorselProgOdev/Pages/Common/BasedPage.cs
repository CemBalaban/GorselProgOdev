using GorselProgOdev.Helpers;
using GorselProgOdev.ViewModels.Common;

namespace GorselProgOdev.Pages.Common;

public abstract class BasedPage<TViewModel> : ContentPage where TViewModel : BaseView
{
    protected BasedPage(TViewModel viewModel) => base.BindingContext = viewModel;

    protected new TViewModel BindingContext => (TViewModel)base.BindingContext;

    public abstract void Build();

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

#if DEBUG
        HotReloadServices.UpdateApplicationEvent += ReloadUI;
#endif
    }
    protected override void OnNavigatingFrom(NavigatingFromEventArgs args)
    {
        base.OnNavigatingFrom(args);

#if DEBUG
        HotReloadServices.UpdateApplicationEvent += ReloadUI;
#endif
    }
    private void ReloadUI(Type[]? obj)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            Build();
        });
    }

}