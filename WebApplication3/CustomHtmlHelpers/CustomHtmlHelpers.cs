using System.Web;
using System.Web.Mvc;

namespace WebApplication3.CustomHtmlHelpers
{
    public static class CustomHtmlHelpers
    {
        //public static IHtmlString Image(this HtmlHelper helper, string src, string alt)

        // BELOW FUNCTION REturns a basic string
        //public static string Image(this HtmlHelper helper, string src, string alt)
        //{
        //    TagBuilder tb = new TagBuilder("img");
        //    tb.Attributes.Add("src", VirtualPathUtility.ToAbsolute(src));
        //    tb.Attributes.Add("alt", alt);
        //    //return new MvcHtmlString(tb.ToString(TagRenderMode.SelfClosing));
        //    return tb.ToString(TagRenderMode.SelfClosing);

        //}

        public static IHtmlString Image(this HtmlHelper helper, string src, string alt)
        {
            TagBuilder tb = new TagBuilder("img");
            tb.Attributes.Add("src", VirtualPathUtility.ToAbsolute(src));
            tb.Attributes.Add("alt", alt);
            return new MvcHtmlString(tb.ToString(TagRenderMode.SelfClosing));

        }
    }
}