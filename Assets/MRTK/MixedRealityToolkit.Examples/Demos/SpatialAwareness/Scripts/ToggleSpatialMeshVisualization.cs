﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.MixedReality.Toolkit.SpatialAwareness;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.Examples.Demos
{
    /// <summary>
    /// This class controls the visualization of the spatial mesh.
    /// </summary>
    public class ToggleSpatialMeshVisualization : MonoBehaviour
    {
        /// <summary>
        /// Toggles the state of the mesh display option.
        /// </summary>
        public void ToggleSpatialMeshVisual(bool mode)
        {
            // Cast the Spatial Awareness system to IMixedRealityDataProviderAccess to get an Observer
            var access = CoreServices.SpatialAwarenessSystem as IMixedRealityDataProviderAccess;

            // Get the first Mesh Observer available, generally we have only one registered
            var observer = access.GetDataProvider<IMixedRealitySpatialAwarenessMeshObserver>();

            if (mode == true)
            {
                // Set to visible
                observer.DisplayOption = SpatialAwarenessMeshDisplayOptions.Visible;
            }
            else
            {
                // Set to not visible
                observer.DisplayOption = SpatialAwarenessMeshDisplayOptions.None;
            }
        }
    }
}