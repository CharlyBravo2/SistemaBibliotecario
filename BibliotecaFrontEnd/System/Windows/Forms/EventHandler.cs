
namespace System.Windows.Forms
{
    internal class EventHandler
    {
        private Action<object, EventArgs> btnGuardar_Click;

        public EventHandler(Action<object, EventArgs> btnGuardar_Click)
        {
            this.btnGuardar_Click = btnGuardar_Click;
        }
    }
}