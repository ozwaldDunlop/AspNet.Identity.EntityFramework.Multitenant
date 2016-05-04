﻿// //-----------------------------------------------------------------------
// // <copyright company="James Skimming">
// //     Copyright (c) 2016 James Skimming
// //     Additional Changes by Oliver Dunthorne 2016
// // </copyright>
// //-----------------------------------------------------------------------
namespace AspNet.Identity.EntityFramework.Multitenant
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.AspNet.Identity;

    /// <summary>
    ///     Interface defining a multi-tenant user.
    /// </summary>
    /// <typeparam name="TKey">The type of <see cref="IUser{TKey}.Id" /> for a user.</typeparam>
    /// <typeparam name="TTenantKey">The type of <see cref="TenantId" /> for a user.</typeparam>
    public interface IMultitenantUser<out TKey, TTenantKey> : IUser<TKey>
    {
        /// <summary>
        ///     Gets or sets the unique identifier of the tenant.
        /// </summary>
        TTenantKey TenantId { get; set; }
    }
}