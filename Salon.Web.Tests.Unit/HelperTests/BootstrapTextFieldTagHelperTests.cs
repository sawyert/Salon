using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using NSubstitute;
using NUnit.Framework;
using Salon.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace Salon.Web.Tests.Unit.HelperTests
{
    [TestFixture]
    public class BootstrapTextFieldTagHelperTests
    {
        BootstrapTextFieldTagHelper bootstrapTextFieldTagHelper;
        HtmlEncoder newHtmlEncoder;

        [SetUp]
        public void Setup()
        {
            var htmlGenerator = Substitute.For<IHtmlGenerator>();
            
            newHtmlEncoder = HtmlEncoder.Create(new TextEncoderSettings(new UnicodeRange(0, 65536)));

            bootstrapTextFieldTagHelper = new BootstrapTextFieldTagHelper(htmlGenerator, newHtmlEncoder)
            {
                ViewContext = new ViewContext()
            };
        }

        private TagHelperContext GetTagHelperContext()
        {
            return new TagHelperContext(
                new TagHelperAttributeList(),
                new Dictionary<object, object>(),
                Guid.NewGuid().ToString("N"));
        }

        private TagHelperOutput GetTagHelperOutput(TagHelperAttributeList tagHelperAttributList = null)
        {
            if(tagHelperAttributList == null)
            {
                tagHelperAttributList = new TagHelperAttributeList();
            }

            return new TagHelperOutput(
                "div",
                tagHelperAttributList,
                (useCachedResult, htmlEncoder) =>
                {
                    var tagHelperContent = new DefaultTagHelperContent();
                    tagHelperContent.SetContent(string.Empty);
                    return Task.FromResult<TagHelperContent>(tagHelperContent);
                }
                );
        }

        private string GetStringFromOutput(TagHelperOutput tagHelperOutput)
        {
            using (var writer = new StringWriter())
            {
                tagHelperOutput.WriteTo(writer, newHtmlEncoder);
                return writer.ToString();
            }
        }

        private ModelExpression GetModelExpression<T>(T container, string propertyName)
        {
            var metadataProvider = new TestModelMetadataProvider();
            var containerType = typeof(T);

            var containerMetadata = metadataProvider.GetMetadataForType(containerType);
            var containerExplorer = metadataProvider.GetModelExplorerForType(containerType, container);

            var propertyMetadata = metadataProvider.GetMetadataForProperty(containerType, propertyName);
            var modelExplorer = containerExplorer.GetExplorerForExpression(propertyMetadata, container);

            return new ModelExpression(propertyName, modelExplorer);
        }

        [Test]
        public async Task GetTagContent_CreatesLabelInputValidationHtml()
        {
            // Arrange
            var testModel = new TestModel();
            var expected = "<div class=\"form-group\"><label class=\"col-md-2 control-label\"></label><div class=\"col-md-10\"><input class=\"form-control\" type=\"text\"></input><span class=\"text-danger\"></span></div></div>";
            bootstrapTextFieldTagHelper.For = GetModelExpression(testModel, nameof(TestModel.Name));
            var tagHelperOutput = GetTagHelperOutput();
            // Act
            await bootstrapTextFieldTagHelper.ProcessAsync(GetTagHelperContext(), tagHelperOutput);

            // Assert
            var outputString = GetStringFromOutput(tagHelperOutput);
            Assert.IsTrue(!string.IsNullOrWhiteSpace(outputString));
            Assert.AreEqual(expected, outputString);
        }

        [Test]
        public async Task GetTagContent_KeepsExistingClass()
        {
            // Arrange
            var testModel = new TestModel();
            var expected = "<div class=\"form-group alphabet soup\"><label class=\"col-md-2 control-label\"></label><div class=\"col-md-10\"><input class=\"form-control\" type=\"text\"></input><span class=\"text-danger\"></span></div></div>";
            bootstrapTextFieldTagHelper.For = GetModelExpression(testModel, nameof(TestModel.Name));
            var tagHelperOutput = GetTagHelperOutput(new TagHelperAttributeList { new TagHelperAttribute("class", "alphabet soup") });

            // Act
            await bootstrapTextFieldTagHelper.ProcessAsync(GetTagHelperContext(), tagHelperOutput);

            // Assert
            var outputString = GetStringFromOutput(tagHelperOutput);
            Assert.IsTrue(!string.IsNullOrWhiteSpace(outputString));
            Assert.AreEqual(expected, outputString);
        }
    }

    public class TestModel
    {
        public string Name { get; set; }
    }
}
