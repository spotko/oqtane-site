using System.Collections.Generic;
using Oqtane.Models;
using Oqtane.Shared;
using Oqtane.Themes;

namespace Oqtane.Theme.Massively.Client
{
    public class ThemeInfo : ITheme
    {
        public Oqtane.Models.Theme Theme => new Oqtane.Models.Theme
        {
            Name = "Massively",
            Version = "1.0.0",
            PackageName = "Oqtane.Theme.Massively",
            Resources = new List<Resource>
            {
                new Stylesheet("_content/Oqtane.Theme.Massively.Client.Oqtane/Themes/Oqtane.Theme.Massively/assets/css/fontawesome-all.min.css"),
                new Stylesheet("_content/Oqtane.Theme.Massively.Client.Oqtane/Themes/Oqtane.Theme.Massively/assets/css/noscript.css"),
                new Stylesheet("_content/Oqtane.Theme.Massively.Client.Oqtane/Themes/Oqtane.Theme.Massively/assets/css/main.css"),
                new Script("_content/Oqtane.Theme.Massively.Client.Oqtane/Themes/Oqtane.Theme.Massively/assets/js/jquery.min.js"),
                new Script("_content/Oqtane.Theme.Massively.Client.Oqtane/Themes/Oqtane.Theme.Massively/assets/js/jquery.scrollex.min.js"),
                new Script("_content/Oqtane.Theme.Massively.Client.Oqtane/Themes/Oqtane.Theme.Massively/assets/js/jquery.scrolly.min.js"),
                new Script("_content/Oqtane.Theme.Massively.Client.Oqtane/Themes/Oqtane.Theme.Massively/assets/js/browser.min.js"),
                new Script("_content/Oqtane.Theme.Massively.Client.Oqtane/Themes/Oqtane.Theme.Massively/assets/js/breakpoints.min.js"),
                new Script("_content/Oqtane.Theme.Massively.Client.Oqtane/Themes/Oqtane.Theme.Massively/assets/js/util.js"),
                new Script("_content/Oqtane.Theme.Massively.Client.Oqtane/Themes/Oqtane.Theme.Massively/assets/js/main.js"),
                new Script("_content/Oqtane.Theme.Massively.Client.Oqtane/Themes/Oqtane.Theme.Massively/assets/js/interop.js", "", "", ResourceLocation.Body, ResourceLoadBehavior.Always, null, null, null, RenderModes.Interactive)
            }
        };
    }
}
