﻿// ManagedUI (Managed User Interface)
// A managed user interface framework for .net desktop applications.
// 
// Copyright © Alaa Ibrahim Hadid 2021 - 2022 - 2022
//
// This program is free software; you can redistribute it and/or modify 
// it under the terms of the GNU Lesser General Public License as published 
// by the Free Software Foundation; either version 3 of the License, 
// or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful, but 
// WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
// or FITNESS FOR A PARTICULAR PURPOSE.See the GNU Lesser General Public 
// License for more details.
//
// You should have received a copy of the GNU Lesser General Public License 
// along with this library; if not, write to the Free Software Foundation, 
// Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
// 
// Author email: mailto:alaahadidfreeware@gmail.com
//
using System;

namespace ManagedUI
{
    /// <summary>
    /// Attribute descripe the info of a menu item when not using resources.
    /// </summary>
    public class MIRNoResourcePropertiesAttribute : Attribute
    {
        /// <summary>
        /// Attribute descripe the info of a menu item when not using resources.
        /// </summary>
        /// <param name="displayName">The display name of this item</param>
        public MIRNoResourcePropertiesAttribute(string displayName)
        {
            DisplayName = displayName;
            ToolTip = "";
        }
        /// <summary>
        /// Attribute descripe the info of a menu item when not using resources.
        /// </summary>
        /// <param name="displayName">The display name of this item</param>
        /// <param name="tooltip">The tooltip of this item</param>
        public MIRNoResourcePropertiesAttribute(string displayName, string tooltip)
        {
            DisplayName = displayName;
            ToolTip = tooltip;
        }
        /// <summary>
        /// Get the display name.
        /// </summary>
        public string DisplayName { get; private set; }
        /// <summary>
        /// Get the tool tip
        /// </summary>
        public string ToolTip { get; private set; }
    }
}
