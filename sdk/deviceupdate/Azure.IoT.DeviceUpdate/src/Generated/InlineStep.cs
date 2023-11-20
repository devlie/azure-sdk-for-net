// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.IoT.DeviceUpdate
{
    /// <summary> Installation instruction step that performs code execution. </summary>
    public partial class InlineStep : Step
    {
        /// <summary> Initializes a new instance of InlineStep. </summary>
        /// <param name="handler"> Identity of handler that will execute this step. Required if step type is inline. </param>
        /// <param name="files"> Collection of file names to be passed to handler during execution. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="handler"/> or <paramref name="files"/> is null. </exception>
        internal InlineStep(string handler, IEnumerable<string> files)
        {
            Argument.AssertNotNull(handler, nameof(handler));
            Argument.AssertNotNull(files, nameof(files));

            Type = StepType.Inline;
            Handler = handler;
            HandlerProperties = new ChangeTrackingDictionary<string, BinaryData>();
            Files = files.ToList();
        }

        /// <summary> Initializes a new instance of InlineStep. </summary>
        /// <param name="type"> Step type. </param>
        /// <param name="description"> Step description. </param>
        /// <param name="handler"> Identity of handler that will execute this step. Required if step type is inline. </param>
        /// <param name="handlerProperties"> Parameters to be passed to handler during execution. </param>
        /// <param name="files"> Collection of file names to be passed to handler during execution. </param>
        internal InlineStep(StepType type, string description, string handler, IReadOnlyDictionary<string, BinaryData> handlerProperties, IReadOnlyList<string> files) : base(type, description)
        {
            Handler = handler;
            HandlerProperties = handlerProperties;
            Files = files;
        }

        /// <summary> Identity of handler that will execute this step. Required if step type is inline. </summary>
        public string Handler { get; }
        /// <summary>
        /// Parameters to be passed to handler during execution.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public IReadOnlyDictionary<string, BinaryData> HandlerProperties { get; }
        /// <summary> Collection of file names to be passed to handler during execution. </summary>
        public IReadOnlyList<string> Files { get; }
    }
}
