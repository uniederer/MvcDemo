using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Markdig;
using MvcDemo.Model;

namespace MvcDemo
{
    public partial class TextParameterView : Form, ITextModelObserver
    {
        public TextParameterView(TextModel _model)
        {
            InitializeComponent();

            _model.RegisterView(this);
        }

        public void OnContentChanged(TextModel sender)
        {
            Task.Run(() =>
            {
                // This is a more computing intense process, hence we
                // delegate the workload to a thread to relief the update
                // notification handler
                var content = Markdown.ToPlainText(sender.Content);
                var words = content.Split(" ")
                                   .Where(s => !string.IsNullOrWhiteSpace(s))
                                   .ToArray();

                // Coming from a separate thread, we have to schedule the update
                // of the UI in the UI thread.
                Invoke(() =>
                {
                    CharacterCount.Text = sender.Content.Length.ToString();
                    WordCount.Text = words.Length.ToString();
                });
            });
        }
    }
}
