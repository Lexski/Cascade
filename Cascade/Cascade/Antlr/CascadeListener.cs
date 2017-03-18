namespace Cascade.Antlr
{
    class CascadeListener : CascadeBaseListener
    {
        // The listener issues commands to the controller.
        private IController _controller;

        public CascadeListener(IController controller)
        {
            _controller = controller;
        }
    }
}
