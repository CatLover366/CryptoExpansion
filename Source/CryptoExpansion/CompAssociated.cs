using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;

namespace CryptoExpansion
{
    public class CompAssociated : ThingComp
    {
        public override void PostExposeData()
        {
            Scribe_References.Look(ref pawn, "pawn");
        }

        public Pawn pawn;

    }
}
