using MvcDemo.Model;

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
