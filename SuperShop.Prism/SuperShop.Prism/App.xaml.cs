using Prism;
using Prism.Ioc;
using SuperShop.Prism.ViewModels;
using SuperShop.Prism.Views;
using SuperShop.Prism.Services;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;
using Syncfusion.Licensing;

namespace SuperShop.Prism
{
    public partial class App
    {
        public App(IPlatformInitializer initializer)
            : base(initializer)
        {
        }

        protected override async void OnInitialized()
        {
            SyncfusionLicenseProvider.RegisterLicense("MzQ5NjI3NEAzMjM3MmUzMDJlMzBoNzZCYmpQWS9QeVJWa3BhS1JqMmJNTm1kaE1XS2FMSzg0ZXdaQVkzeVRFPQ==");

            InitializeComponent();

            await NavigationService.NavigateAsync($"/{nameof(SuperShopMasterDetailPage)}/NavigationPage/{nameof(ProductsPage)}");
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
            containerRegistry.Register<IApiService, ApiService>();
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<LoginPage, LoginPageViewModel>();
            containerRegistry.RegisterForNavigation<ProductsPage, ProductsPageViewModel>();
            containerRegistry.RegisterForNavigation<ProductDetailPage, ProductDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<SuperShopMasterDetailPage, SuperShopMasterDetailPageViewModel>();
            containerRegistry.RegisterForNavigation<ShowHistoryPage, ShowHistoryPageViewModel>();
            containerRegistry.RegisterForNavigation<ModifyUserPage, ModifyUserPageViewModel>();
            containerRegistry.RegisterForNavigation<ShowCartPage, ShowCartPageViewModel>();
        }
    }
}
