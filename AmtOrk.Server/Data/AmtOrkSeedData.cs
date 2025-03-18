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
				KingdomId = 13,
				LandIconPath = "https://ork.amtgard.com/assets/heraldry/park/00825.jpg"
			},
			new Land{
				Id = 2,
				LandName = "Dragons of Fire Valley",
				LandDescription = "The Dragons of Fire Valley was formed in 2007 in Chehalis, Washington. The land started with three people searching for a new home. Finding a land rich with tree's and resources in Washington, they had found a new area to set up home. Voting and making it official, the land started its long journey towards prosperity, and are growing constantly each year. Finding a solid support structure within the Northern Lights, the Dragons of Fire Valley have become hosts to several large scale travel days and provide a great group of people for future growth of the Northern Lights and Dragons of Fire Valley itself.",
				LandLocation = "We meet at noon on Saturdays in Borst Park located in Centralia, Wa.",
				KingdomId = 13,
				LandIconPath = "https://ork.amtgard.com/assets/heraldry/park/00355.jpg"
			},
			new Land{
				Id = 3,
				LandName = "Greenwood Keep",
				LandDescription = "We are the Dutchy of Greenwood Keep. We meet at Wonderwood Park in Lacey at 11:00am on Sundays. We enjoy fast paced games, and adventures in the woods. Come out and see us! Very kid friendly, our few smokers are respectful of others, and we often have food! http://www.greenwoodkeep.com/",
				LandLocation = "Take College to 31st, turning East, then follow the signs for Wonderwood Park.For Fighter Practice, please check on Discord or Facebook as the location and time may change!",
				KingdomId = 13,
				LandIconPath = "https://ork.amtgard.com/assets/heraldry/park/00076.jpg"
			},
			new Land{
				Id = 4,
				LandName = "Inland Ocean",
				LandDescription = "Welcome to Inland Ocean! We play at Marymoor Park in Redmond, WA, Saturdays starting at 12! We are typically at one of the shelters near the Dog Wash in Lot D. If you are looking for us, head towards the dog park, and look for the banner and players, or check our Facebook page, as someone typically posts our exact location. We have Fighter Practice at Frank Love Elementry in the covered basketball court, in Bothell WA. 6-8pm every Thursday.",
				LandLocation = "",
				KingdomId = 13,
				LandIconPath = "https://ork.amtgard.com/assets/heraldry/park/00074.jpg"
			},
			new Land{
				Id = 5,
				LandName = "Lost Cove",
				LandDescription = "Parksville Community Park, at the gazebo by the stage\n\n(Monday fighter practice is at the Qualicum Beach community park, near Ravensong Aquatic Center)",
				LandLocation = "",
				KingdomId = 13,
				LandIconPath = "https://ork.amtgard.com/assets/heraldry/park/01043.jpg"
			},
			new Land{
				Id = 6,
				LandName = "Mithril Hills",
				LandDescription = "We play every Sunday, starting at Noon at Tam O'Shanter Park in Kelso.",
				LandLocation = "Directions to Parkn1)Take exit 39 for WA-4 W/Allen Street toward Kelson2)Turn left onto WA-4 W/Allen Stn3)Continue straight onto Allen Stn4)Turn right onto S Kelso Drn5)Turn left onto Tam O'Shanter Wayn6)Continue straight into park",
				KingdomId = 13,
				LandIconPath = "https://ork.amtgard.com/assets/heraldry/park/00124.jpg"
			},
			new Land{
				Id = 7,
				LandName = "Oceans Alley",
				LandDescription = "",
				LandLocation = "",
				KingdomId = 13,
				LandIconPath = "https://ork.amtgard.com/assets/heraldry/park/01042.jpg"
			},
			new Land{
				Id = 8,
				LandName = "Seaside Keep",
				LandDescription = "Our main Park is Central Park in Burnaby. Park days meet at the Band Stand by Swangard Stadium. We also meet regularly for crafting nights, fight practice and special events",
				LandLocation = "",
				KingdomId = 13,
				LandIconPath = "https://ork.amtgard.com/assets/heraldry/park/01006.jpg"
			},
			new Land{
				Id = 9,
				LandName = "Shrouding Mist",
				LandDescription = "We are an Amtgard land in the Kingdom of Northern Lights. Created in 1988, we meet every Sunday around noon at Sprinker Recreational Park next to Breseman Forest near the Rock Climbing structure (orginally behind the baseball fields). We hope to see you there!",
				LandLocation = "",
				KingdomId = 13,
				LandIconPath = "https://ork.amtgard.com/assets/heraldry/park/00118.jpg"
			},
			new Land{
				Id = 10,
				LandName = "The Hollow",
				LandDescription = "The Hollow Discord:\nhttps://discord.com/invite/jxQntTxenS\nFacebook Group:\nhttps://www.facebook.com/groups/120371818682/?ref=share\nFacebook Page:\nhttps://www.facebook.com/share/DZHscqVKJaRhH3QJ/?mibextid=qi2Omg\nInstagram:\nhttps://www.instagram.com/amtgard.thehollow?igsh=YWh6MnhpeHd1d3dt\nKingdom Discord:\nhttps://discord.com/invite/hxWAUQZHMs",
				LandLocation = "Sundays at noon. Take exit 186 off Interstate 5. Head East on 128th St. SE. McCollum Park will be on your Right in about a half mile. We meet at the North end of the Forest Loop Trail.",
				KingdomId = 13,
				LandIconPath = "https://ork.amtgard.com/assets/heraldry/park/00343.jpg"
			},
			new Land{
				Id = 11,
				LandName = "Three Lakes",
				LandDescription = "We meet Saturdays at 12:00pm at Vance Creek Park in Elma (Wenzel Slough Rd, Elma, WA 98541)",
				LandLocation = "",
				KingdomId = 13,
				LandIconPath = "https://ork.amtgard.com/assets/heraldry/park/01050.jpg"
			}
		);
	}

	public static void PopulateKingdoms(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Kingdom>().HasData(
			new Kingdom {
				Id = 1,
				KingdomName = "13 Roads",
				KingdomIconPath = "https://ork.amtgard.com/assets/heraldry/kingdom/0038.jpg"
			},
			new Kingdom {
				Id = 2,
				KingdomName = "Kingdom of Desert Winds",
				KingdomIconPath = "https://ork.amtgard.com/assets/heraldry/kingdom/0018.jpg"
			},
			new Kingdom {
				Id = 3,
				KingdomName = "The Celestial Kingdom",
				KingdomIconPath = "https://ork.amtgard.com/assets/heraldry/kingdom/0014.jpg"
			},
			new Kingdom {
				Id = 4,
				KingdomName = "The Empire of Rivermoor",
				KingdomIconPath = "https://ork.amtgard.com/assets/heraldry/kingdom/0022.jpg"
			},
			new Kingdom {
				Id = 5,
				KingdomName = "The Empire of the Iron Mountains",
				KingdomIconPath = "https://ork.amtgard.com/assets/heraldry/kingdom/0003.jpg"
			},
			new Kingdom {
				Id = 6,
				KingdomName = "The Freeholds of Amtgard",
				KingdomIconPath = "https://ork.amtgard.com/assets/heraldry/kingdom/0008.jpg"
			},
			new Kingdom {
				Id = 7,
				KingdomName = "The Kingdom of Blackspire",
				KingdomIconPath = "https://ork.amtgard.com/assets/heraldry/kingdom/0016.jpg"
			},
			new Kingdom {
				Id = 8,
				KingdomName = "The Kingdom of Burning Lands",
				KingdomIconPath = "https://ork.amtgard.com/assets/heraldry/kingdom/0007.jpg"
			},
			new Kingdom {
				Id = 9,
				KingdomName = "The Kingdom of Crystal Groves",
				KingdomIconPath = "https://ork.amtgard.com/assets/heraldry/kingdom/0017.jpg"
			},
			new Kingdom {
				Id = 10,
				KingdomName = "The Kingdom of Dragonspine",
				KingdomIconPath = "https://ork.amtgard.com/assets/heraldry/kingdom/0012.jpg"
			},
			new Kingdom {
				Id = 11,
				KingdomName = "The Kingdom of Goldenvale",
				KingdomIconPath = "https://ork.amtgard.com/assets/heraldry/kingdom/0004.jpg"
			},
			new Kingdom {
				Id = 12,
				KingdomName = "The Kingdom of Neverwinter",
				KingdomIconPath = "https://ork.amtgard.com/assets/heraldry/kingdom/0005.jpg"
			},
			new Kingdom {
				Id = 13,
				KingdomName = "The Kingdom of Northern Lights",
				KingdomIconPath = "https://ork.amtgard.com/assets/heraldry/kingdom/0020.jpg",
			},
			new Kingdom {
				Id = 14,
				KingdomName = "The Kingdom of Northreach",
				KingdomIconPath = "https://ork.amtgard.com/assets/heraldry/kingdom/0036.jpg"
			},
			new Kingdom {
				Id = 15,
				KingdomName = "The Kingdom of Polaris",
				KingdomIconPath = "https://ork.amtgard.com/assets/heraldry/kingdom/0027.jpg"
			},
			new Kingdom {
				Id = 16,
				KingdomName = "The Kingdom of Tal Dagore",
				KingdomIconPath = "https://ork.amtgard.com/assets/heraldry/kingdom/0019.jpg"
			},
			new Kingdom {
				Id = 17,
				KingdomName = "The Kingdom of the Emerald Hills",
				KingdomIconPath = "https://ork.amtgard.com/assets/heraldry/kingdom/0006.jpg"
			},
			new Kingdom {
				Id = 18,
				KingdomName = "The Kingdom of the Golden Plains",
				KingdomIconPath = "https://ork.amtgard.com/assets/heraldry/kingdom/0011.jpg"
			},
			new Kingdom {
				Id = 19,
				KingdomName = "The Kingdom of the Nine Blades",
				KingdomIconPath = "https://ork.amtgard.com/assets/heraldry/kingdom/0031.jpg"
			},
			new Kingdom {
				Id = 20,
				KingdomName = "The Kingdom of the Rising Winds",
				KingdomIconPath = "https://ork.amtgard.com/assets/heraldry/kingdom/0010.jpg"
			},
			new Kingdom {
				Id = 21,
				KingdomName = "The Kingdom of the Wetlands",
				KingdomIconPath = "https://ork.amtgard.com/assets/heraldry/kingdom/0001.jpg"
			},
			new Kingdom {
				Id = 22,
				KingdomName = "The Kingdom of Viridian Outlands",
				KingdomIconPath = "https://ork.amtgard.com/assets/heraldry/kingdom/0025.jpg"
			},
			new Kingdom {
				Id = 23,
				KingdomName = "The Kingdom of Westmarch",
				KingdomIconPath = "https://ork.amtgard.com/assets/heraldry/kingdom/0021.jpg"
			},
			new Kingdom {
				Id = 24,
				KingdomName = "The Kingdom of Winters Edge",
				KingdomIconPath = "https://ork.amtgard.com/assets/heraldry/kingdom/0024.jpg"
			}
		);
	}
}