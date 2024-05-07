namespace MvcDemo.Model
{
    public interface ITextModelObserver
    {
        void OnContentChanged(TextModel sender);
    }
}
