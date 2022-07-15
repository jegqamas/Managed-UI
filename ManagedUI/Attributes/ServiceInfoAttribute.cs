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
using System.ComponentModel.Composition;

namespace ManagedUI
{
    /// <summary>
    /// Attribute descripes a service
    /// </summary>
    [MetadataAttribute]
    public class ServiceInfoAttribute : Attribute
    {
        /// <summary>
        /// Attribute descripes a service. This will be used for the service metadata
        /// </summary>
        /// <param name="name">The name of this service.</param>
        /// <param name="id">The id of this service.</param>
        /// <param name="shortDesc">A short description about this service.</param>
        /// <param name="isDefault">Indicate if this service is default. Default services cannot be disabled. (NOT IMPLEMENTED, reserved for future use)</param>
        public ServiceInfoAttribute(string name, string id, string shortDesc, bool isDefault)
        {
            Name = name;
            ID = id;
            Description = shortDesc;
            IsDefault = isDefault;
        }
        /// <summary>
        /// Attribute descripes a service. This will be used for the service metadata
        /// </summary>
        /// <param name="name">The name of this service.</param>
        /// <param name="id">The id of this service.</param>
        /// <param name="shortDesc">A short description about this service.</param>
        public ServiceInfoAttribute(string name, string id, string shortDesc)
        {
            Name = name;
            ID = id;
            Description = shortDesc;
            IsDefault = false;
        }
        /// <summary>
        /// Get the name of this service.
        /// </summary>
        public string Name { get; private set; }
        /// <summary>
        /// Get the id of this service.
        /// </summary>
        public string ID { get; private set; }
        /// <summary>
        /// Get a short description about this service.
        /// </summary>
        public string Description { get; private set; }
        /// <summary>
        /// Get if this service is default. Default services cannot be disabled.
        /// </summary>
        public bool IsDefault { get; private set; }
    }
}
