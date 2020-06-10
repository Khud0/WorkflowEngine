using System;

namespace WorkflowEngine
{
    class VideoProcessor : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Processing your video...");
        }
    }
}
