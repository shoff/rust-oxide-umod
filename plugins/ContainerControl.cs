﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Oxide.Plugins
{
    [Info("ContainerControl", "Hamster", "1.0.0")]
    [Description("Allows you to restrict types of items which can be put in a certain kind of containers")]
    class ContainerControl : RustPlugin
    {

        #region Config
        private PluginConfig config;
        private class PluginConfig
        {
            [JsonProperty("Settings: Container - items")]
            public Dictionary<string, string[]> ListItem { get; set; }
        }
        protected override void LoadDefaultConfig()
        {
            PrintWarning("Сreate a new configuration file");
            config = new PluginConfig()
            {
                ListItem = new Dictionary<string, string[]>()
                {
                    ["cupboard.tool.deployed"] = new[] 
                    {
                        "cloth",
                        "scrap",
                        "sulfur",
                        "sulfur.ore",
                        "charcoal",
                        "hq.metal.ore",
                        "fat.animal",
                        "leather",
                        "crude.oil",
                        "gunpowder",
                        "metal.ore",
                        "lowgradefuel"
                    },
                    ["campfire"] = new[]
                    {
                        "metal.ore",
                        "fat.animal",
                        "stones",
                        "cctv.camera",
                        "leather",
                        "targeting.computer",
                        "metal.refined",
                        "scrap",
                        "bone.fragments",
                        "gunpowder",
                        "sulfur",
                        "sulfur.ore",
                        "crude.oil",
                        "lowgradefuel",
                        "jackhammer",
                        "cloth",
                        "chainsaw",
                        "explosive.timed",
                        "stone.pickaxe",
                        "stonehatchet",
                        "pickaxe",
                        "hatchet",
                        "icepick.salvaged",
                        "hammer.salvaged",
                        "axe.salvaged",
                        "explosive.satchel",
                        "flare",
                        "flashlight.held",
                        "waterjug",
                        "supply.signal",
                        "bandage",
                        "syringe.medical",
                        "largemedkit",
                        "antiradpills",
                        "ammo.nailgun.nails",
                        "arrow.wooden",
                        "arrow.bone",
                        "arrow.hv",
                        "arrow.fire",
                        "ammo.shotgun",
                        "ammo.shotgun.fire",
                        "ammo.shotgun.slug",
                        "ammo.pistol",
                        "ammo.pistol.fire",
                        "ammo.pistol.hv",
                        "ammo.handmade.shell",
                        "ammo.rocket.basic",
                        "ammo.rocket.smoke",
                        "ammo.rocket.fire",
                        "ammo.rocket.hv",
                        "ammo.rifle",
                        "ammo.rifle.hv",
                        "ammo.rifle.explosive",
                        "ammo.rifle.incendiary",
                        "autoturret",
                        "flameturret",
                        "trap.bear",
                        "trap.landmine",
                        "spikes.floor",
                        "guntrap",
                        "tarp",
                        "rope",
                        "roadsigns",
                        "riflebody",
                        "smgbody",
                        "semibody",
                        "sheetmetal",
                        "metalspring",
                        "metalpipe",
                        "metalblade",
                        "sewingkit",
                        "propanetank",
                        "techparts",
                        "gears",
                        "fuse",
                        "smg.mp5",
                        "crossbow",
                        "grenade.beancan",
                        "mace",
                        "rifle.bolt",
                        "pistol.nailgun",
                        "grenade.f1",
                        "shotgun.double",
                        "shotgun.spas12",
                        "pistol.m92",
                        "flamethrower",
                        "smg.thompson",
                        "weapon.mod.flashlight",
                        "rifle.semiauto",
                        "pistol.semiauto",
                        "shotgun.pump",
                        "lmg.m249",
                        "rocket.launcher",
                        "pistol.revolver",
                        "pistol.python",
                        "shotgun.waterpipe",
                        "smg.2",
                        "salvaged.cleaver",
                        "rifle.ak",
                        "rifle.lr300",
                        "metal.fragments",
                        "explosives",
                        "hq.metal.ore"
                    },
                    ["bbq.deployed"] = new[]
                    {
                        "metal.ore",
                        "fat.animal",
                        "stones",
                        "cctv.camera",
                        "leather",
                        "targeting.computer",
                        "metal.refined",
                        "scrap",
                        "bone.fragments",
                        "gunpowder",
                        "sulfur",
                        "sulfur.ore",
                        "crude.oil",
                        "lowgradefuel",
                        "jackhammer",
                        "cloth",
                        "chainsaw",
                        "explosive.timed",
                        "stone.pickaxe",
                        "stonehatchet",
                        "pickaxe",
                        "hatchet",
                        "icepick.salvaged",
                        "hammer.salvaged",
                        "axe.salvaged",
                        "explosive.satchel",
                        "flare",
                        "flashlight.held",
                        "waterjug",
                        "supply.signal",
                        "bandage",
                        "syringe.medical",
                        "largemedkit",
                        "antiradpills",
                        "ammo.nailgun.nails",
                        "arrow.wooden",
                        "arrow.bone",
                        "arrow.hv",
                        "arrow.fire",
                        "ammo.shotgun",
                        "ammo.shotgun.fire",
                        "ammo.shotgun.slug",
                        "ammo.pistol",
                        "ammo.pistol.fire",
                        "ammo.pistol.hv",
                        "ammo.handmade.shell",
                        "ammo.rocket.basic",
                        "ammo.rocket.smoke",
                        "ammo.rocket.fire",
                        "ammo.rocket.hv",
                        "ammo.rifle",
                        "ammo.rifle.hv",
                        "ammo.rifle.explosive",
                        "ammo.rifle.incendiary",
                        "autoturret",
                        "flameturret",
                        "trap.bear",
                        "trap.landmine",
                        "spikes.floor",
                        "guntrap",
                        "tarp",
                        "rope",
                        "roadsigns",
                        "riflebody",
                        "smgbody",
                        "semibody",
                        "sheetmetal",
                        "metalspring",
                        "metalpipe",
                        "metalblade",
                        "sewingkit",
                        "propanetank",
                        "techparts",
                        "gears",
                        "fuse",
                        "smg.mp5",
                        "crossbow",
                        "grenade.beancan",
                        "mace",
                        "rifle.bolt",
                        "pistol.nailgun",
                        "grenade.f1",
                        "shotgun.double",
                        "shotgun.spas12",
                        "pistol.m92",
                        "flamethrower",
                        "smg.thompson",
                        "weapon.mod.flashlight",
                        "rifle.semiauto",
                        "pistol.semiauto",
                        "shotgun.pump",
                        "lmg.m249",
                        "rocket.launcher",
                        "pistol.revolver",
                        "pistol.python",
                        "shotgun.waterpipe",
                        "smg.2",
                        "salvaged.cleaver",
                        "rifle.ak",
                        "rifle.lr300",
                        "metal.fragments",
                        "explosives",
                        "hq.metal.ore"
                    },
                    ["dropbox.deployed"] = new[]
                    {
                        "metal.ore",
                        "fat.animal",
                        "stones",
                        "leather",
                        "metal.refined",
                        "scrap",
                        "bone.fragments",
                        "gunpowder",
                        "sulfur",
                        "sulfur.ore",
                        "crude.oil",
                        "lowgradefuel",
                        "cloth",
                        "explosive.timed",
                        "explosive.satchel",
                        "grenade.beancan",
                        "grenade.f1",
                        "explosives"
                    },
                    ["furnace"] = new[]
                    {
                        "fat.animal",
                        "stones",
                        "cctv.camera",
                        "leather",
                        "targeting.computer",
                        "bone.fragments",
                        "crude.oil",
                        "gunpowder",
                        "lowgradefuel",
                        "jackhammer",
                        "cloth",
                        "chainsaw",
                        "explosive.timed",
                        "stone.pickaxe",
                        "stonehatchet",
                        "pickaxe",
                        "hatchet",
                        "icepick.salvaged",
                        "hammer.salvaged",
                        "axe.salvaged",
                        "explosive.satchel",
                        "flare",
                        "flashlight.held",
                        "waterjug",
                        "supply.signal",
                        "bandage",
                        "syringe.medical",
                        "largemedkit",
                        "antiradpills",
                        "ammo.nailgun.nails",
                        "arrow.wooden",
                        "arrow.bone",
                        "arrow.hv",
                        "arrow.fire",
                        "ammo.shotgun",
                        "ammo.shotgun.fire",
                        "ammo.shotgun.slug",
                        "ammo.pistol",
                        "ammo.pistol.fire",
                        "ammo.pistol.hv",
                        "ammo.handmade.shell",
                        "ammo.rocket.basic",
                        "ammo.rocket.smoke",
                        "ammo.rocket.fire",
                        "ammo.rocket.hv",
                        "ammo.rifle",
                        "ammo.rifle.hv",
                        "ammo.rifle.explosive",
                        "ammo.rifle.incendiary",
                        "autoturret",
                        "flameturret",
                        "trap.bear",
                        "trap.landmine",
                        "spikes.floor",
                        "guntrap",
                        "tarp",
                        "rope",
                        "roadsigns",
                        "riflebody",
                        "smgbody",
                        "semibody",
                        "sheetmetal",
                        "metalspring",
                        "metalpipe",
                        "metalblade",
                        "sewingkit",
                        "propanetank",
                        "techparts",
                        "gears",
                        "fuse",
                        "smg.mp5",
                        "crossbow",
                        "grenade.beancan",
                        "mace",
                        "rifle.bolt",
                        "pistol.nailgun",
                        "grenade.f1",
                        "shotgun.double",
                        "shotgun.spas12",
                        "pistol.m92",
                        "flamethrower",
                        "smg.thompson",
                        "weapon.mod.flashlight",
                        "rifle.semiauto",
                        "pistol.semiauto",
                        "shotgun.pump",
                        "lmg.m249",
                        "rocket.launcher",
                        "pistol.revolver",
                        "pistol.python",
                        "shotgun.waterpipe",
                        "smg.2",
                        "salvaged.cleaver",
                        "rifle.ak",
                        "rifle.lr300",
                        "explosives"
                    },
                    ["furnace.large"] = new[]
                    {
                        "fat.animal",
                        "stones",
                        "cctv.camera",
                        "leather",
                        "targeting.computer",
                        "bone.fragments",
                        "crude.oil",
                        "gunpowder",
                        "lowgradefuel",
                        "jackhammer",
                        "cloth",
                        "chainsaw",
                        "explosive.timed",
                        "stone.pickaxe",
                        "stonehatchet",
                        "pickaxe",
                        "hatchet",
                        "icepick.salvaged",
                        "hammer.salvaged",
                        "axe.salvaged",
                        "explosive.satchel",
                        "flare",
                        "flashlight.held",
                        "waterjug",
                        "supply.signal",
                        "bandage",
                        "syringe.medical",
                        "largemedkit",
                        "antiradpills",
                        "ammo.nailgun.nails",
                        "arrow.wooden",
                        "arrow.bone",
                        "arrow.hv",
                        "arrow.fire",
                        "ammo.shotgun",
                        "ammo.shotgun.fire",
                        "ammo.shotgun.slug",
                        "ammo.pistol",
                        "ammo.pistol.fire",
                        "ammo.pistol.hv",
                        "ammo.handmade.shell",
                        "ammo.rocket.basic",
                        "ammo.rocket.smoke",
                        "ammo.rocket.fire",
                        "ammo.rocket.hv",
                        "ammo.rifle",
                        "ammo.rifle.hv",
                        "ammo.rifle.explosive",
                        "ammo.rifle.incendiary",
                        "autoturret",
                        "flameturret",
                        "trap.bear",
                        "trap.landmine",
                        "spikes.floor",
                        "guntrap",
                        "tarp",
                        "rope",
                        "roadsigns",
                        "riflebody",
                        "smgbody",
                        "semibody",
                        "sheetmetal",
                        "metalspring",
                        "metalpipe",
                        "metalblade",
                        "sewingkit",
                        "propanetank",
                        "techparts",
                        "gears",
                        "fuse",
                        "smg.mp5",
                        "crossbow",
                        "grenade.beancan",
                        "mace",
                        "rifle.bolt",
                        "pistol.nailgun",
                        "grenade.f1",
                        "shotgun.double",
                        "shotgun.spas12",
                        "pistol.m92",
                        "flamethrower",
                        "smg.thompson",
                        "weapon.mod.flashlight",
                        "rifle.semiauto",
                        "pistol.semiauto",
                        "shotgun.pump",
                        "lmg.m249",
                        "rocket.launcher",
                        "pistol.revolver",
                        "pistol.python",
                        "shotgun.waterpipe",
                        "smg.2",
                        "salvaged.cleaver",
                        "rifle.ak",
                        "rifle.lr300",
                        "explosives"
                    }
                }
            };
        }
        protected override void LoadConfig()
        {
            base.LoadConfig();
            config = Config.ReadObject<PluginConfig>();
        }
        protected override void SaveConfig()
        {
            Config.WriteObject(config);
        }

        #endregion

        #region Oxide hook

        private void Loaded()
        {
            LoadConfig();
        }

        private ItemContainer.CanAcceptResult? CanAcceptItem(ItemContainer container, Item item, int targetPos)
        {
            if (container == null || item == null) return null;
            BaseEntity baseEntity = container.entityOwner;
            if (baseEntity == null) return null;
            if (baseEntity.OwnerID <= 76560000000000000L) return null;
            string[] values;
            var configHasItem = config.ListItem.TryGetValue(baseEntity.ShortPrefabName, out values);
            if (configHasItem)
            {
                foreach (var name in values)
                {
                    if (item.info.shortname == name)
                    {
                        return ItemContainer.CanAcceptResult.CannotAccept;
                    }
                }
            }
            return null;
        }


        #endregion

    }
}