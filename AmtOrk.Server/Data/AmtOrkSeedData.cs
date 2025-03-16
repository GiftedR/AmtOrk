using AmtOrk.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace AmtOrk.Server.Data;


/// <summary>
/// Static methods to populate the seed data
/// </summary>
public class AmtOrkSeedData
{
	public static void PopulateClasses(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Classes>().HasData(
			new Classes{
				Id = 1,
				ClassName = "Anti-Paladin"
			},
			new Classes{
				Id = 2,
				ClassName = "Archer"
			},
			new Classes{
				Id = 3,
				ClassName = "Assassin"
			},
			new Classes{
				Id = 4,
				ClassName = "Barbarian"
			},
			new Classes{
				Id = 5,
				ClassName = "Bard"
			},
			new Classes{
				Id = 6,
				ClassName = "Color"
			},
			new Classes{
				Id = 7,
				ClassName = "Druid"
			},
			new Classes{
				Id = 8,
				ClassName = "Healer"
			},
			new Classes{
				Id = 9,
				ClassName = "Monk"
			},
			new Classes{
				Id = 10,
				ClassName = "Monster"
			},
			new Classes{
				Id = 11,
				ClassName = "Paladin"
			},
			new Classes{
				Id = 12,
				ClassName = "Peasant"
			},
			new Classes{
				Id = 13,
				ClassName = "Reeve"
			},
			new Classes{
				Id = 14,
				ClassName = "Scout"
			},
			new Classes{
				Id = 15,
				ClassName = "Warrior"
			},
			new Classes{
				Id = 16,
				ClassName = "Wizard"
			}
		);
	}

	public static void PopulateLands(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Land>().HasData(
			new Land{
				Id = 1,
				LandName = "Blade's Edge",
				LandDescription = "Blade's Edge meets three times a week:\nTuesday @ 4:00pm -Fighter Practice\nFriday @ 4:00pm - Fighter Practice\nSaturday @ 1:00pm -Park Day",
				LandLocation = "2729 Jackson Ave SE, Port Orchard, WA 98366, USA",
				KingdomId = 12
			},
			new Land{
				Id = 2,
				LandName = "Dragons of Fire Valley",
				LandDescription = "",
				LandLocation = "",
				KingdomId = 12
			},
			new Land{
				Id = 3,
				LandName = "Greenwood Keep",
				LandDescription = "",
				LandLocation = "",
				KingdomId = 12
			},
			new Land{
				Id = 4,
				LandName = "Inland Ocean",
				LandDescription = "",
				LandLocation = "",
				KingdomId = 12
			},
			new Land{
				Id = 5,
				LandName = "Lost Cove",
				LandDescription = "",
				LandLocation = "",
				KingdomId = 12
			},
			new Land{
				Id = 6,
				LandName = "Mithril Hills",
				LandDescription = "",
				LandLocation = "",
				KingdomId = 12
			},
			new Land{
				Id = 7,
				LandName = "Oceans Alley",
				LandDescription = "",
				LandLocation = "",
				KingdomId = 12
			},
			new Land{
				Id = 8,
				LandName = "Seaside Keep",
				LandDescription = "",
				LandLocation = "",
				KingdomId = 12
			},
			new Land{
				Id = 9,
				LandName = "Shrouding Mist",
				LandDescription = "",
				LandLocation = "",
				KingdomId = 12
			},
			new Land{
				Id = 10,
				LandName = "The Hollow",
				LandDescription = "",
				LandLocation = "",
				KingdomId = 12
			},
			new Land{
				Id = 11,
				LandName = "Three Lakes",
				LandDescription = "",
				LandLocation = "",
				KingdomId = 12
			}
		);
	}

	public static void PopulateKingdoms(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Kingdom>().HasData(
			new Kingdom {
				Id = 1,
				KingdomName = "13 Roads"
			},
			new Kingdom {
				Id = 2,
				KingdomName = "Kingdom of Desert Winds"
			},
			new Kingdom {
				Id = 3,
				KingdomName = "The Celestial Kingdom"
			},
			new Kingdom {
				Id = 4,
				KingdomName = "The Empire of Rivermoor"
			},
			new Kingdom {
				Id = 5,
				KingdomName = "The Empire of the Iron Mountains"
			},
			new Kingdom {
				Id = 6,
				KingdomName = "The Freeholds of Amtgard"
			},
			new Kingdom {
				Id = 7,
				KingdomName = "The Kingdom of Blackspire"
			},
			new Kingdom {
				Id = 8,
				KingdomName = "The Kingdom of Burning Lands"
			},
			new Kingdom {
				Id = 9,
				KingdomName = "The Kingdom of Crystal Groves"
			},
			new Kingdom {
				Id = 10,
				KingdomName = "The Kingdom of Dragonspine"
			},
			new Kingdom {
				Id = 11,
				KingdomName = "The Kingdom of Goldenvale"
			},
			new Kingdom {
				Id = 12,
				KingdomName = "The Kingdom of Neverwinter"
			},
			new Kingdom {
				Id = 13,
				KingdomName = "The Kingdom of Northern Lights"
			},
			new Kingdom {
				Id = 14,
				KingdomName = "The Kingdom of Northreach"
			},
			new Kingdom {
				Id = 15,
				KingdomName = "The Kingdom of Polaris"
			},
			new Kingdom {
				Id = 16,
				KingdomName = "The Kingdom of Tal Dagore"
			},
			new Kingdom {
				Id = 17,
				KingdomName = "The Kingdom of the Emerald Hills"
			},
			new Kingdom {
				Id = 18,
				KingdomName = "The Kingdom of the Golden Plains"
			},
			new Kingdom {
				Id = 19,
				KingdomName = "The Kingdom of the Nine Blades"
			},
			new Kingdom {
				Id = 20,
				KingdomName = "The Kingdom of the Rising Winds"
			},
			new Kingdom {
				Id = 21,
				KingdomName = "The Kingdom of the Wetlands"
			},
			new Kingdom {
				Id = 22,
				KingdomName = "The Kingdom of Viridian Outlands"
			},
			new Kingdom {
				Id = 23,
				KingdomName = "The Kingdom of Westmarch"
			},
			new Kingdom {
				Id = 24,
				KingdomName = "The Kingdom of Winters Edge"
			}
		);
	}
}