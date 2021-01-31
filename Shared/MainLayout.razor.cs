using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExtensionWeb.Shared
{
    public partial class MainLayout : LayoutComponentBase
    {
        /// <summary>
        /// The abreviation of the app name
        /// for uniqueness in html classes
        /// </summary>
        private const string _uniqueNamespace = "bex";

        private string[] _themeKeys = new string[] 
        {
            "dark",
            "light"
        };
        private string _selectedThemeKey;
        private string _themeClassName;

        private void SetSelectedThemeKey(string value)
        {
            _selectedThemeKey = value;

            switch (_selectedThemeKey)
            {
                case "dark":
                    _themeClassName = "dark_mode";
                    return;
                case "light":
                    _themeClassName = "light_mode";
                    return;
            }

            StateHasChanged();
        }
    }
}