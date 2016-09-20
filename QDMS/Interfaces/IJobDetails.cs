﻿// -----------------------------------------------------------------------
// <copyright file="IJobDetails.cs" company="">
// Copyright 2016 Alexander Soffronow Pagonidis
// </copyright>
// -----------------------------------------------------------------------

using System;

namespace QDMS
{
    public interface IJobDetails
    {
        /// <summary>
        /// If true, updates will only happen monday through friday.
        /// </summary>
        bool WeekDaysOnly { get; set; }

        /// <summary>
        /// The time when the job runs.
        /// </summary>
        TimeSpan Time { get; set; }

        string Name { get; set; }
    }
}
