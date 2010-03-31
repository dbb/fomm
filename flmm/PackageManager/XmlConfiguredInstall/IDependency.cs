﻿using System;

namespace Fomm.PackageManager.XmlConfiguredInstall
{
	/// <summary>
	/// Defines the interface for a dependency
	/// </summary>
	public interface IDependency
	{
		/// <summary>
		/// Gets whether or not the dependency is fufilled.
		/// </summary>
		/// <value>Whether or not the dependency is fufilled.</value>
		bool IsFufilled { get; }
	}
}