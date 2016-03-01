using System;

namespace Microsoft.VisualStudio.Services.Agent.Common
{
    public class TaskCommands : AgentService, ICommandExtension
    {
        public Type ExtensionType 
        {
            get
            {
                return typeof(ICommandExtension);
            }    
        }
        
        public String CommandArea
        {
            get
            {
                return "task";
            }
        }
    }
}