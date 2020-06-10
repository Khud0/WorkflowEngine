using System.Collections.Generic;

namespace WorkflowEngine
{
    class Workflow
    {
        private readonly string name;
        private readonly ILogger logger;
        
        private List<IActivity> activities = new List<IActivity>();
        
        public Workflow(string workflowName, ILogger logger)
        {
            this.name = workflowName;
            this.logger = logger;           
        }

        /// <summary>
        /// Runs all the registered acitivities one by one.
        /// </summary>
        public void Run()
        {
            logger.Log(LogType.Info, $"Workflow {this.ToString()} has been started.");

            int activityCount = activities.Count;

            // Don't run an empty Workflow
            if (activityCount == 0) 
            {
                logger.Log(LogType.Error, $"Workflow {this.ToString()} doesn't have any activities!");
                logger.Log(LogType.Warning, $"Workflow {this.ToString()} has been aborted.");
                return;
            }

            // Execute all activities in the order they were added
            for (int i=0; i<activityCount; i++)
            {
                activities[i].Execute();
            }

            logger.Log(LogType.Info, $"Workflow {this.ToString()} has finished executing all of its activities.");
        }

        /// <summary>
        /// Registers an activity in the workflow.
        /// Activities will be executed in the order they were added.
        /// </summary>
        public void AddActivity(IActivity activity)
        {
            activities.Add(activity);
        }

        public override string ToString()
        {
            return $"\"{this.name}\"";
        }
    }
}
