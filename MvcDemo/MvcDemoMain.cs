using MvcDemo.Model;

namespace MvcDemo
{
    public partial class MvcDemoMain : Form
    {
        private readonly TextModel _model;

        public MvcDemoMain(TextModel model)
        {
            InitializeComponent();

            _model = model;

            CenterToScreen();
        }

        private void OnSetLorem_Click(object sender, EventArgs e)
        {
            _model.SetContent("Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.");
        }

        private void OnClear_Click(object sender, EventArgs e)
        {
            _model.Clear();
        }

        private void OnSetMarkdown_Click(object sender, EventArgs e)
        {
            _model.SetContent(@"# Hello world!

How are *you* today?

I am feeling **good**!");
        }

        private void OnShowWindows_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                ShowForm(form);
            }
        }

        private static void ShowForm(Form form)
        {
            form.WindowState = FormWindowState.Normal;
            form.BringToFront();
        }
    }
}
