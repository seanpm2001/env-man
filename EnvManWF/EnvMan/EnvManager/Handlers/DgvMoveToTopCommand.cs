//------------------------------------------------------------------------
// <copyright file="DgvMoveToTopCommand.cs" company="SETCHIN Freelance Consulting">
// Copyright (C) 2006-2011 SETCHIN Freelance Consulting
// </copyright>
// <author>
// Vlad Setchin
// </author>
//------------------------------------------------------------------------

// EnvMan - The Open-Source Windows Environment Variables Manager
// Copyright (C) 2006-2011 SETCHIN Freelance Consulting 
// <http://www.setchinfc.com.au>
// EnvMan Development Group: <mailto:envman-dev@googlegroups.com>
//  
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace EnvManager.Handlers
{
    /// <summary>
    /// Data Grid View Move to top command
    /// </summary>
    public class DgvMoveToTopCommand : DgvCommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DgvMoveToTopCommand"/> class.
        /// </summary>
        /// <param name="dgvHandler">The DGV handler.</param>
        public DgvMoveToTopCommand(DgvHandler dgvHandler)
            : base(dgvHandler, "Move Value to Top")
        {
        }

        /// <summary>
        /// Executes this instance.
        /// </summary>
        public override void Execute()
        {
            this.CurrentRowIndex = this.Handler.CurrentRowIndex;
            this.NewRowIndex = 0;
            Redo();
        }
    }
}
