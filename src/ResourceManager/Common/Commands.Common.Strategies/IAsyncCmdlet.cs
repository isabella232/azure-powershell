﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.Azure.Commands.Common.Strategies
{
    /// <summary>
    /// Asynchronous cmdlet interface.
    /// </summary>
    public interface IAsyncCmdlet
    {
        /// <summary>
        /// Cmdlet parameters.
        /// </summary>
        IEnumerable<KeyValuePair<string, object>> Parameters { get; }

        /// <summary>
        /// Thread-safe `WriteVerbose` function.
        /// </summary>
        /// <param name="message"></param>
        void WriteVerbose(string message);

        /// <summary>
        /// Asynchronous, thread-safe `ShouldProcess` function.
        /// </summary>
        Task<bool> ShouldProcessAsync(string target, string action);

        /// <summary>
        /// Thread-safe `WriteVerbose` function.
        /// </summary>
        /// <param name="value"></param>
        void WriteObject(object value);

        /// <summary>
        /// Report task progress. The function is used to report current task and cmdlet progress.
        /// </summary>
        /// <param name="taskProgress"></param>
        void ReportTaskProgress(ITaskProgress taskProgress);

        /// <summary>
        /// A `New` verb.
        /// </summary>
        string VerbsNew { get; }
    }
}
