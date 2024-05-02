using MvcDemo.Model;

namespace MvcDemo
{
    public partial class EditorViewController : Form, ITextModelObserver
    {
        private readonly TextModel _model;

        public EditorViewController(Model.TextModel model)
        {
            InitializeComponent();

            _model = model;
            _model.RegisterView(this);
        }

        public void OnContentChanged(TextModel sender)
        {
            Content.Text = sender.Content;
        }

        private void Content_TextChanged(object sender, EventArgs e)
        {
            _model.SetContent(Content.Text);
        }
    }
}
