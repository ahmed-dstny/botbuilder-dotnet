﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Microsoft.Bot.Schema.Teams
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// Tab SuggestedActions (Only when type is 'auth' or 'silentAuth').
    /// </summary>
    public partial class TabSuggestedActions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TabSuggestedActions"/> class.
        /// </summary>
        public TabSuggestedActions()
        {
            CustomInit();
        }

        /// <summary>
        /// Gets actions for a card tab response.
        /// </summary>
        /// <value>
        /// Actions for this <see cref="TabSuggestedActions"/>.
        /// </value>
        [JsonProperty(PropertyName = "actions")]
        public IList<CardAction> Actions { get; private set; } = new List<CardAction>();

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults.
        /// </summary>
        partial void CustomInit();
    }
}
