// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.Management.Resources.Models;

namespace Microsoft.Azure.Management.Resources.Models
{
    /// <summary>
    /// Deployment properties.
    /// </summary>
    public partial class DeploymentProperties : BasicDeployment
    {
        private string _correlationId;
        
        /// <summary>
        /// Optional. Gets or sets the correlation ID of the deployment.
        /// </summary>
        public string CorrelationId
        {
            get { return this._correlationId; }
            set { this._correlationId = value; }
        }
        
        private string _outputs;
        
        /// <summary>
        /// Optional. Gets or sets key/value pairs that represent
        /// deploymentoutput.
        /// </summary>
        public string Outputs
        {
            get { return this._outputs; }
            set { this._outputs = value; }
        }
        
        private IList<Provider> _providers;
        
        /// <summary>
        /// Optional. The list of resource providers needed for the deployment
        /// </summary>
        public IList<Provider> Providers
        {
            get { return this._providers; }
            set { this._providers = value; }
        }
        
        private string _provisioningState;
        
        /// <summary>
        /// Optional. Gets or sets the state of the provisioning.
        /// </summary>
        public string ProvisioningState
        {
            get { return this._provisioningState; }
            set { this._provisioningState = value; }
        }
        
        private DateTime _timestamp;
        
        /// <summary>
        /// Optional. Gets or sets the timestamp of the template deployment.
        /// </summary>
        public DateTime Timestamp
        {
            get { return this._timestamp; }
            set { this._timestamp = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DeploymentProperties class.
        /// </summary>
        public DeploymentProperties()
        {
            this.Providers = new List<Provider>();
        }
    }
}
