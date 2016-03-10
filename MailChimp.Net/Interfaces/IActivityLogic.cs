﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IActivityLogic.cs" company="Brandon Seydel">
//   N/A
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using MailChimp.Net.Core;
using MailChimp.Net.Models;

namespace MailChimp.Net.Interfaces
{
    /// <summary>
    /// The ActivityLogic interface.
    /// </summary>
    public interface IActivityLogic
    {
        /// <summary>
        /// The get all async.
        /// </summary>
        /// <param name="listId">
        /// The list id.
        /// </param>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<IEnumerable<Activity>> GetAllAsync(string listId, BaseRequest request);
    }
}