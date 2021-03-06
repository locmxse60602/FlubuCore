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
    public partial class DockerLoginTask : ExternalProcessTaskBase<int, DockerLoginTask>
    {
        private string _server;


        public DockerLoginTask(string server = null)
        {
            ExecutablePath = "docker";
            WithArguments("login");
            _server = server;
        }

        protected override string Description { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        [ArgKey("--password")]
        public DockerLoginTask Password(string password)
        {
            WithArgumentsKeyFromAttribute(password.ToString());
            return this;
        }

        /// <summary>
        /// Take the password from stdin
        /// </summary>
        [ArgKey("--password-stdin")]
        public DockerLoginTask PasswordStdin()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Username
        /// </summary>
        [ArgKey("--username")]
        public DockerLoginTask Username(string username)
        {
            WithArgumentsKeyFromAttribute(username.ToString());
            return this;
        }

        protected override int DoExecute(ITaskContextInternal context)
        {
            WithArguments(_server);

            return base.DoExecute(context);
        }
    }
}