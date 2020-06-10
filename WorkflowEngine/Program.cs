using System;

namespace WorkflowEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var workflow1 = new Workflow("Empty Video Processor", new ConsoleLogger());
            workflow1.Run();

            var workflow2 = new Workflow("MeTube Video Processor", new ConsoleLogger());
            workflow2.AddActivity(new VideoUploader());
            workflow2.AddActivity(new VideoProcessor());
            workflow2.AddActivity(new VideoPoster());
            workflow2.Run();
        }
    }
}
