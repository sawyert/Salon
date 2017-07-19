using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Salon.Helpers
{
    public static class TagHelperExtensions
    {
        public static async Task<string> GetGeneratedContent(this ITagHelper tagHelper, HtmlEncoder htmlEncoder, string tagName, TagMode tagMode,
           TagHelperAttributeList attributes = null)
        {
            if (attributes == null)
            {
                attributes = new TagHelperAttributeList();
            }

            TagHelperOutput output = new TagHelperOutput(tagName, attributes, (arg1, arg2) =>
            {
                return Task.Run<TagHelperContent>(() => new DefaultTagHelperContent());
            })
            {
                TagMode = tagMode
            };
            TagHelperContext context = new TagHelperContext(attributes, new Dictionary<object, object>(), Guid.NewGuid().ToString());

            tagHelper.Init(context);
            await tagHelper.ProcessAsync(context, output);

            using (var writer = new StringWriter())
            {
                output.WriteTo(writer, htmlEncoder);
                return writer.ToString();
            }
        }
    }
}
