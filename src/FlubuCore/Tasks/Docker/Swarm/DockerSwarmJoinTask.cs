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

namespace FlubuCore.Tasks.Docker.Swarm
{
    public partial class DockerSwarmJoinTask : ExternalProcessTaskBase<int, DockerSwarmJoinTask>
    {
        private string _host;


        public DockerSwarmJoinTask(string host)
        {
            ExecutablePath = "docker";
            WithArguments("swarm join");
            _host = host;
        }

        protected override string Description { get; set; }

        /// <summary>
        /// Advertised address (format: <ip|interface>[:port])
        /// </summary>
        [ArgKey("--advertise-addr")]
        public DockerSwarmJoinTask AdvertiseAddr(string advertiseAddr)
        {
            WithArgumentsKeyFromAttribute(advertiseAddr.ToString());
            return this;
        }

        /// <summary>
        /// Availability of the node ("active"|"pause"|"drain")
        /// </summary>
        [ArgKey("--availability")]
        public DockerSwarmJoinTask Availability(string availability)
        {
            WithArgumentsKeyFromAttribute(availability.ToString());
            return this;
        }

        /// <summary>
        /// Address or interface to use for data path traffic (format: <ip|interface>)
        /// </summary>
        [ArgKey("--data-path-addr")]
        public DockerSwarmJoinTask DataPathAddr(string dataPathAddr)
        {
            WithArgumentsKeyFromAttribute(dataPathAddr.ToString());
            return this;
        }

        /// <summary>
        /// Listen address (format: <ip|interface>[:port])
        /// </summary>
        [ArgKey("--listen-addr")]
        public DockerSwarmJoinTask ListenAddr(string listenAddr)
        {
            WithArgumentsKeyFromAttribute(listenAddr.ToString());
            return this;
        }

        /// <summary>
        /// Token for entry into the swarm
        /// </summary>
        [ArgKey("--token")]
        public DockerSwarmJoinTask Token(string token)
        {
            WithArgumentsKeyFromAttribute(token.ToString());
            return this;
        }

        protected override int DoExecute(ITaskContextInternal context)
        {
            WithArguments(_host);

            return base.DoExecute(context);
        }
    }
}