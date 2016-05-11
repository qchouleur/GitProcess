using System.Collections.Generic;

namespace GitProcess.Entities
{
    /// <summary>
    /// The task configuration.
    /// </summary>
    public class TaskConfiguration
    {
        /// <summary>
        /// Gets or sets the task name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the script name executing the task.
        /// </summary>
        public string ScriptName { get; set; }

        /// <summary>
        /// Gets or sets the parameter count required by the task.
        /// </summary>
        public int ParameterCount { get; set; }

        /// <summary>
        /// Gets or sets the parameters defined for the task.
        /// </summary>
        public IEnumerable<string> Parameters { get; set; }
    }
}
