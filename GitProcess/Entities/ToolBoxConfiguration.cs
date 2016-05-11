using System.Collections.Generic;

namespace GitProcess.Entities
{
    /// <summary>
    /// The toolbox configuration.
    /// </summary>
    public class ToolBoxConfiguration
    {
        /// <summary>
        /// Gets or sets the scripts library directory path. 
        /// </summary>
        public string LibraryPath { get; set; }

        /// <summary>
        /// Gets or sets the tasks contained by the toolbox.
        /// </summary>
        public IEnumerable<TaskConfiguration> Tasks { get; set; }
    }
}
