using System;

namespace WorkflowEngine
{
    class VideoUploader : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Uploading video to the server...");
        }
    }
}
