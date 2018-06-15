﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TownsAndWarriors.game.basicInterfaces;
using TownsAndWarriors.game.map.generators.city;

namespace TownsAndWarriors.game.settings.generators {
	class SityPlacer14Settings : BasicSityPlaceSettings {
		public override void SetSettings(Settingable obj) {
			SityPlacer14 sityPlacer = obj as SityPlacer14;
			if (sityPlacer == null)
				throw new ApplicationException("Wrong generator in TunnelMapGeneratorSettings.SetSettings");

			base.SetSettings(obj);

			sityPlacer.maxPlaceRepeats = 3;

			sityPlacer.quadIsRoad = false;
			sityPlacer.quadCells = 25;
			sityPlacer.minQuads = 2;
			sityPlacer.citiesPerQuadMin = 2;
			sityPlacer.citiesPerQuadMax = 4;

		}
	}
}
