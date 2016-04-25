﻿using System.Collections.Generic;

using Windows.Foundation;

using UniversalMapControl.Projections;

namespace UniversalMapControl.Interfaces
{
	public interface IProjection
	{
		ILocation ToLocation(CartesianPoint point, bool sanitize = true);
		CartesianPoint ToCartesian(ILocation location, bool sanitize = true);
		CartesianPoint ToCartesian(ILocation location, double referenceLong, bool sanitize = true);
		CartesianPoint SanitizeCartesian(CartesianPoint value);

		double GetZoomFactor(double zoomLevel);

		/// <summary>
		/// This ZoomLevel implementation is based on the Zoomlevels use in online maps. If the zoomlevel is increased by 1 the scale factor doubles.
		/// </summary>
		double GetZoomLevel(double zoomFactor);
	}
}