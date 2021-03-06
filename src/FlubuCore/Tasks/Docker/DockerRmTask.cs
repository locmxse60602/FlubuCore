//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Attributes;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
    public partial class DockerRmTask : ExternalProcessTaskBase<int, DockerRmTask>
    {
        private string[] _container;


        public DockerRmTask(params string[] container)
        {
            ExecutablePath = "docker";
            WithArguments("rm");
            _container = container;
        }

        protected override string Description { get; set; }

        /// <summary>
        /// Force the removal of a running container (uses SIGKILL)
        /// </summary>
        [ArgKey("--force")]
        public DockerRmTask Force()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Remove the specified link
        /// </summary>
        [ArgKey("--link")]
        public DockerRmTask Link()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Remove the volumes associated with the container
        /// </summary>
        [ArgKey("--volumes")]
        public DockerRmTask Volumes()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        protected override int DoExecute(ITaskContextInternal context)
        {
            WithArguments(_container);

            return base.DoExecute(context);
        }
    }
}