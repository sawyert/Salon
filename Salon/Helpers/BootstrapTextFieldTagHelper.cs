using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Salon.Helpers
{
    [HtmlTargetElement("div", Attributes = TextFieldAttributeName)]
    public class BootstrapTextFieldTagHelper : TagHelper
    {
        private const string TextFieldAttributeName = "bs-textfield-for";

        /// <summary>
        /// An expression to be evaluated against the current model.
        /// </summary>
        [HtmlAttributeName(TextFieldAttributeName)]
        public ModelExpression For { get; set; }

        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        private readonly IHtmlGenerator _htmlGenerator;
        private readonly HtmlEncoder _htmlEncoder;

        public BootstrapTextFieldTagHelper(IHtmlGenerator htmlGenerator, HtmlEncoder htmlEncoder)
        {
            _htmlGenerator = htmlGenerator;
            _htmlEncoder = htmlEncoder;
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            // Get input tag
            var inputTag = new InputTagHelper(_htmlGenerator)
            {
                For = this.For,
                ViewContext = this.ViewContext
            };
            // Get label tag
            var labelTag = new LabelTagHelper(_htmlGenerator)
            {
                For = this.For,
                ViewContext = this.ViewContext
            };
            // Get validation tag
            var validationTag = new ValidationMessageTagHelper(_htmlGenerator)
            {
                For = this.For,
                ViewContext = this.ViewContext
            };

            output.Content.AppendHtml(await labelTag.GetGeneratedContent(_htmlEncoder, "label", TagMode.StartTagAndEndTag, new TagHelperAttributeList { new TagHelperAttribute("class", "col-md-2 control-label") }));
            // Field and validation within the same div
            output.Content.AppendHtml("<div class=\"col-md-10\">");
            output.Content.AppendHtml(await inputTag.GetGeneratedContent(_htmlEncoder, "input", TagMode.StartTagAndEndTag, new TagHelperAttributeList { new TagHelperAttribute("class", "form-control") }));
            output.Content.AppendHtml(await validationTag.GetGeneratedContent(_htmlEncoder, "span", TagMode.StartTagAndEndTag, new TagHelperAttributeList { new TagHelperAttribute("class", "text-danger") }));
            output.Content.AppendHtml("</div>");

            string classValue = "form-group";
            if (output.Attributes.ContainsName("class"))
            {
                classValue += " " + output.Attributes["class"].Value;
            }
            output.Attributes.SetAttribute("class", classValue);
        }
    }
}
