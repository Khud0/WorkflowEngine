using System;

namespace WorkflowEngine
{
    class VideoPoster : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Posting the video on your channel...");
        }
    }
}
