﻿// This file is part of AHD Subtitles Maker Professional
// A program can create and edit subtitle.
// 
// Copyright © Alaa Ibrahim Hadid 2009 - 2019
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
// GNU General Public License for more details.

// You should have received a copy of the GNU General Public License
// along with this program.If not, see<http://www.gnu.org/licenses/>.
// 
// Author email: mailto:alaahadidfreeware@gmail.com
//
using System;

namespace ManagedUI
{
    /// <summary>
    /// Event args for application exit events.
    /// </summary>
    public class ApplicationExittingArgs : EventArgs
    {
        /// <summary>
        /// Get or set if the app exiting process shoud be canceled or not.
        /// </summary>
        public bool Cancel { get; set; }
    }
}
