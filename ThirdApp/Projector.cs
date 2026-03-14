namespace ThirdApp
{
    // PROJECTOR — owned by Cinema(Composition)
    // If Cinema is destroyed → Projector is destroyed too
    class Projector
    {
        private bool _isRunning = false;

        public void Start()
        {
            _isRunning = true;
            Console.WriteLine("Projector started");
        }

        public void Stop()
        {
            _isRunning = false;
            Console.WriteLine("Projector stopped");
        }

        public bool IsRunning => _isRunning;

    }
}
