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
                new Stylesheet("~/assets/css/fontawesome-all.min.css"),
                new Stylesheet("~/assets/css/noscript.css"),
                new Stylesheet("~/assets/css/main.css"),
                new Script("~/assets/js/jquery.min.js"),
                new Script("~/assets/js/jquery.scrollex.min.js"),
                new Script("~/assets/js/jquery.scrolly.min.js"),
                new Script("~/assets/js/browser.min.js"),
                new Script("~/assets/js/breakpoints.min.js"),
                new Script("~/assets/js/util.js"),
                new Script("~/assets/js/main.js"),
                new Script("~/assets/js/interop.js", "", "", ResourceLocation.Body, ResourceLoadBehavior.Always, null, null, null, RenderModes.Interactive)
            }
        };
    }
}
