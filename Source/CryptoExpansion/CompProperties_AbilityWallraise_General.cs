using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RimWorld;
using Verse;
using UnityEngine;

namespace CryptoExpansion
{
	public class CompProperties_AbilityWallraise_General : CompProperties_AbilityWallraise
	{
		public ThingDef wallDef = ThingDefOf.RaisedRocks;

		public Color puffColor = Color.white;
	}
}
