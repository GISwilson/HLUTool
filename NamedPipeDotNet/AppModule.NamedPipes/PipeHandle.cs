// HLUTool is used to view and maintain habitat and land use GIS data.
// Copyright © 2011 Hampshire Biodiversity Information Centre
// 
// This file is part of HLUTool.
// 
// HLUTool is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// HLUTool is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with HLUTool.  If not, see <http://www.gnu.org/licenses/>.

using System;

using AppModule.InterProcessComm;

namespace AppModule.NamedPipes
{
    #region Comments
    /// <summary>
    /// Holds the operating system native handle and the current state of the pipe connection.
    /// </summary>
    #endregion
    public sealed class PipeHandle
    {
        #region Comments
        /// <summary>
        /// The operating system native handle.
        /// </summary>
        #endregion
        public IntPtr Handle;

        #region Comments
        /// <summary>
        /// The current state of the pipe connection.
        /// </summary>
        #endregion
        public InterProcessConnectionState State;

        #region Comments
        /// <summary>
        /// Creates a PipeHandle instance using the passed native handle.
        /// </summary>
        /// <param name="hnd">The native handle.</param>
        #endregion
        public PipeHandle(int hnd)
        {
            this.Handle = new IntPtr(hnd);
            this.State = InterProcessConnectionState.NotSet;
        }

        #region Comments
        /// <summary>
        /// Creates a PipeHandle instance using the provided native handle and state.
        /// </summary>
        /// <param name="hnd">The native handle.</param>
        /// <param name="state">The state of the pipe connection.</param>
        #endregion
        public PipeHandle(int hnd, InterProcessConnectionState state)
        {
            this.Handle = new IntPtr(hnd);
            this.State = state;
        }

        #region Comments
        /// <summary>
        /// Creates a PipeHandle instance with an invalid native handle.
        /// </summary>
        #endregion
        public PipeHandle()
        {
            this.Handle = new IntPtr(NamedPipeNative.INVALID_HANDLE_VALUE);
            this.State = InterProcessConnectionState.NotSet;
        }
    }
}