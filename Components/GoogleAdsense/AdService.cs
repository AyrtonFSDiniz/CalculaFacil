using Microsoft.JSInterop;
using System.Threading.Tasks;

public class AdService
{
    private readonly IJSRuntime _jsRuntime;

    public AdService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async Task LoadAdsAsync()
    {
        // Chama uma função JavaScript para inicializar os anúncios
        await _jsRuntime.InvokeVoidAsync("initializeAds");
    }
}
