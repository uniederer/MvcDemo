using Markdig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcDemo
{
    public class MarkdownServices
    {
        protected MarkdownServices() { }

        public static string MarkdownToRtf(string markdown)
        {
            var pipeline = new MarkdownPipelineBuilder().Build();
            var writer = new StringWriter();
            var renderer = new RtfRenderer.RtfRenderer(writer);

            renderer.StartDocument();
            Markdown.Convert(markdown, renderer, pipeline);
            renderer.CloseDocument();

            return writer.ToString();
        }
    }
}
