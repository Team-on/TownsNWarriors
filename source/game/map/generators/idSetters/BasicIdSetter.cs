﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TownsAndWarriors.game.settings;

namespace TownsAndWarriors.game.map.generators.idSetters {
	abstract class BasicIdSetter : BasicGenerator, basicInterfaces.Settingable {
		public byte bots;
		public List<byte> townsPerBot;
		public byte townsPerPlayer;

		public abstract void SetId();

		public BasicIdSetter() {
			this.GetSettings(this.CreateLinkedSetting());
		}

		public virtual SettinsSetter CreateLinkedSetting() {
			return new TownsAndWarriors.game.settings.generators.BasicIdSetterSettings();
		}

		public void GetSettings(SettinsSetter settinsSetter) {
			settinsSetter.SetSettings(this);
		}
	}
}
