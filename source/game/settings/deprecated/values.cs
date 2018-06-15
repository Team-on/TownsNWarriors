﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TownsAndWarriors.game.settings {
	public static class values {
		public static byte locateMemory_SizeForTowns = 12;
		public static byte locateMemory_SizeForUnits = 12;

		public static Random rnd { get; private set; }
		public static int seedField;
		public static int seed {
			get => seedField;
			set {
				seedField = value;
				rnd = new Random(seed);
			}
		}

		public static ushort fieldSizeX = 10;
		public static ushort fieldSizeY = 10;
		public static ushort milisecondsPerTick = 20;

		public static ushort style_Num = 1;

		public static byte bot_rushBot_Tick_IgnoreFirstN = 200;
		public static byte bot_rushBot_Tick_React = (byte)(25);
		public static bool bot_rushBot_IsProtectSities = true;
		public static byte bot_rushBot_Protect_MinimumUnitsLeft = 2;
		public static bool bot_rushBot_IsDropOvercapacityUnits = true;
		public static byte bot_rushBot_Overcapacity_NearValue = 1;
		public static bool bot_rushBot_IsMoveUnitsToWeakSities = true;
		public static byte bot_rushBot_Rush_Cnt = 4;
		public static List<KeyValuePair<byte, byte>> bot_rushBot_RushWaves_Chance = new List<KeyValuePair<byte, byte>>() {
			new KeyValuePair<byte, byte>(1, 25),
			new KeyValuePair<byte, byte>(2, 25),
			new KeyValuePair<byte, byte>(3, 25),
			new KeyValuePair<byte, byte>(4, 25),
		};
		public static byte bot_rushBot_Rush_MinimumMore = 1;
	}
}
