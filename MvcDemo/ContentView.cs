using Markdig;
using Markdig.Syntax;
using MvcDemo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MvcDemo
{
    public partial class ContentView : Form, ITextModelObserver
    {
        public ContentView(TextModel model)
        {
            InitializeComponent();

            model.RegisterView(this);
        }

        public void OnContentChanged(TextModel sender)
        {
            Task.Run(() =>
            {
                // This is a more computing intense process, hence we
                // delegate the workload to a thread to relief the update
                // notification handler
                var rtf = MarkdownServices.MarkdownToRtf(sender.Content);

                Invoke(() =>
                {
                    // Coming from a separate thread, we have to schedule the update
                    // of the UI in the UI thread.
                    Content.Rtf = rtf;
                });
            });
        }
    }
}
