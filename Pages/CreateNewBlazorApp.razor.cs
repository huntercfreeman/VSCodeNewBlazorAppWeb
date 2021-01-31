using BlazorExtensionWeb.Code;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExtensionWeb.Pages
{
    public partial class CreateNewBlazorApp : ComponentBase
    {
        [Inject]
        private IFileGenerator FileGenerator { get; set; }
        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        private EditContext _newBlazorAppContext;
        private NewBlazorApp _newBlazorApp;

        protected override void OnInitialized()
        {
            _newBlazorApp = new NewBlazorApp();

            _newBlazorAppContext = new EditContext(_newBlazorApp);

            base.OnInitialized();
        }

        private async Task OnValidSubmit()
        {
            await JSRuntime.InvokeVoidAsync("postToParent");
        }
    }
}
