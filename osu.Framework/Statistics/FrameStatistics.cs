﻿// Copyright (c) 2007-2016 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

using System.Collections.Generic;

//using System.Diagnostics.PerformanceData;

namespace osu.Framework.Statistics
{
    public class FrameStatistics
    {
        internal Dictionary<PerformanceCollectionType, double> CollectedTimes = new Dictionary<PerformanceCollectionType, double>();
        //internal Dictionary<CounterType, int> CollectedCounters = new Dictionary<CounterType, int>();
        internal List<int> GarbageCollections = new List<int>();

        internal void Clear()
        {
            CollectedTimes.Clear();
            GarbageCollections.Clear();
        }
    }

    public enum PerformanceCollectionType
    {
        Update,
        Draw,
        SwapBuffer,
        WndProc,
        Debug,
        Sleep,
        Scheduler,
        IPC,
        GLReset,
        Empty,
    }
}
