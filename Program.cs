// <copyright file="Program.cs" company="PlaceholderCompany">
//     Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace SA1648DelegateRepro
{
    using System.Threading;

    /// <summary>
    ///     D.
    /// </summary>
    internal class Program
    {
        /// <summary>
        ///     A.
        /// </summary>
        /// <returns>B.</returns>
        /// <include file="docs.xml" path="Root/Documentation[@name='CancellationToken']/*"/>
        public delegate bool A(CancellationToken cancellationToken = default);
    }
}
