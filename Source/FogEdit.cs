﻿using Verse;

namespace MapEditTools
{
    class Designator_AddFog : MapEditDesignator
    {
        public Designator_AddFog() : base()
        {
            this.defaultLabel = "MapEditTools.DesignatorAddFog".Translate().Resolve();
            this.defaultDesc = "MapEditTools.DesignatorAddFogDesc".Translate().Resolve();
        }

        public override AcceptanceReport CanDesignateCell(IntVec3 loc)
        {
            return !Map.fogGrid.IsFogged(loc);
        }

        public override void DesignateSingleCell(IntVec3 c)
        {
            Map.fogGrid.Refog(CellRect.SingleCell(c));
        }
    }

    class Designator_RemoveFog : MapEditDesignator
    {
        public Designator_RemoveFog() : base()
        {
            this.defaultLabel = "MapEditTools.DesignatorRemoveFog".Translate().Resolve();
            this.defaultDesc = "MapEditTools.DesignatorRemoveFogDesc".Translate().Resolve();
        }

        public override AcceptanceReport CanDesignateCell(IntVec3 loc)
        {
            return Map.fogGrid.IsFogged(loc);
        }

        public override void DesignateSingleCell(IntVec3 c)
        {
            Map.fogGrid.Unfog(c);
        }
    }
}
