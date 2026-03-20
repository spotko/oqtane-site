using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Oqtane.Theme.Massively.Client
{
    public class Interop
    {
        private readonly IJSRuntime _jsRuntime;

        public Interop(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task Load()
        {
            await _jsRuntime.InvokeVoidAsync("Oqtane.Theme.Massively.load");
        }
    }
}
