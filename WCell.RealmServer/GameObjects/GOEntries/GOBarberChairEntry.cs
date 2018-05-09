﻿using WCell.Constants;

namespace WCell.RealmServer.GameObjects.GOEntries
{
    public class GOBarberChairEntry : GOEntry
    {
        /// <summary>MapId from Maps.dbc</summary>
        public int ChairHeight
        {
            get { return this.Fields[0]; }
        }

        /// <summary>In inches</summary>
        public int HeightOffset
        {
            get { return this.Fields[1]; }
        }

        /// <summary>The StandState when sitting in this barber chair</summary>
        public StandState SitState
        {
            get { return (StandState) ((ulong) this.ChairHeight + 4UL); }
        }
    }
}