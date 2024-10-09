﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPDesign.Jukebox;

public static class JukeBoxEnum
{
    public enum EPlayingType
    {
        OnlyOnce,
        RepeatCurrent,
        RepeatAllOnlyOnce,
        RepeatCircleForever,
    }
}
