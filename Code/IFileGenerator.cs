using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExtensionWeb.Code
{
    public interface IFileGenerator
    {
        public bool Generate(NewBlazorApp newBlazorApp);
    }
}