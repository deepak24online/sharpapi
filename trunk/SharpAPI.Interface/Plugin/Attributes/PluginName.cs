﻿/*
 *  This file is a part of SharpAPI.
 *
 *  Copyright (C) 2010 Jack Wakefield
 *  
 *  SharpAPI is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU Lesser General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  SharpAPI is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU Lesser General Public License for more details.
 *
 *  You should have received a copy of the GNU Lesser General Public License
 *  along with SharpAPI.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;

namespace SharpAPI.Interface.Plugin.Attributes
{
    /// <summary>
    /// Used to define the plugin name for classes inheriting IPlugin
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class PluginName : Attribute
    {
        #region Properties

        /// <summary>
        /// Gets or sets the plugin name.
        /// </summary>
        /// <value>The plugin name.</value>
        public string Name { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="PluginName"/> class.
        /// </summary>
        /// <param name="name">The plugin name.</param>
        public PluginName(string name)
        {
            Name = name;
        }

        #endregion
    }
}