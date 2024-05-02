using Markdig;
using MarkdigExtensions.RtfRenderer;

namespace MvcDemo
{
    public class MarkdownServices
    {
        protected MarkdownServices() { }

        public static string MarkdownToRtf(string markdown)
        {
            var pipeline = new MarkdownPipelineBuilder().Build();
            var writer = new StringWriter();
            var renderer = new RtfRenderer(writer);

            renderer.StartDocument();
            Markdown.Convert(markdown, renderer, pipeline);
            renderer.CloseDocument();

            return writer.ToString();
        }
    }
}
