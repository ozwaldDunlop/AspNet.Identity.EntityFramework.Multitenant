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
    using Microsoft.AspNet.Identity.EntityFramework;

    /// <summary>
    /// Minimal class for a <see cref="MultitenantIdentityUserLogin{TKey, TTenant}"/> with a <see cref="string"/> user
    /// <see cref="IdentityUserLogin{TKey}.UserId"/>
    /// and <see cref="MultitenantIdentityUserLogin{TKey, TTenant}.TenantId"/>.
    /// </summary>
    public class MultitenantIdentityUserLogin : MultitenantIdentityUserLogin<string, string>
    {
    }
}
