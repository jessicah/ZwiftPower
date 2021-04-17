﻿using System.Collections.Generic;

namespace ZwiftPower
{
	// Routes/RouteLinks key == `rt` key in `zwift_event_list.json`
	public static class Routes
	{
		// Many routes are still missing, Zwift hasn't updated ZwiftPower
		public static Dictionary<string, string> RouteNames = new Dictionary<string, string>
		{
			// Watopia
			{ "4240327959", "11.1 Ocean Blvd" }, // running
			{ "3819095753", "5K Loop" }, // running
			{ "3921412335", "Big Foot Hills" },
			{ "2947111049", "Big Loop" },
			{ "4107844490", "Big Loop Reverse" },
			{ "2139708890", "Bigger Loop" },
			{ "1373909093", "Chili Pepper" }, // running
			{ "3694952104", "Chili Pepper Rev" }, // running
			{ "2675063596", "Dust In The Wind" },
			{ "3811569265", "Flat Route Reverse" },
			{ "2878180967", "Four Horsemen" },
			{ "107363867", "Hilly Route Reverse" },
			{ "136957568", "Jon's Route" }, // running
			{ "743730361", "Jungle Circuit" },
			{ "2587199457", "Jungle Circuit Old" },
			{ "2839057126", "Jungle Circuit Reverse" },
			{ "3012588561", "May Field" }, // running
			{ "2139465450", "Muir And The Mountain" },
			{ "2314974816", "Ocean Loop" },
			{ "2748657713", "Out And Back Again" },
			{ "2969952077", "Quatch Quest" },
			{ "3701568815", "Road to Ruins" },
			{ "2967612381", "Road To Ruins Reverse" },
			{ "2663908549", "Road to Sky" },
			{ "772562418", "Run Path Reverse" }, // running
			{ "604330868", "Sand And Sequoias" },
			{ "3454338139", "Seaside Sprint" },
			{ "2128890027", "Tempus Fugit" },
			{ "263936293", "That's Amore" }, // running
			{ "1586193601", "That's Amore Rev" }, // running
			{ "2207442179", "The Magnificent 8" },
			{ "3848492017", "The Mega Pretzel" },
			{ "1475638265", "The Uber Pretzel" },
			{ "4142772830", "Three Sisters" },
			{ "4263172118", "Three Sisters Reverse" },
			{ "3366225080", "Tick Tock" },
			{ "1766405776", "Tour of Fire and Ice" },
			{ "686828068", "Volcano Circuit" },
			{ "3866241330", "Volcano Circuit CCW" },
			{ "849508252", "Volcano Climb" },
			{ "3994934674", "Volcano Flat" },
			{ "387309391", "Volcano Flat KOM" },
			{ "1397026382", "Volcano Flat Reverse" },
			{ "3382019812", "Watopia Figure 8" },
			{ "553661379", "Watopia Figure 8 Reverse" },
			{ "3395698268", "Watopia Flat Route" },
			{ "2737483381", "Watopia Hilly Route" },
			{ "2966818006", "Watopia Mountain" },
			{ "3219074012", "Watopia Mountain 8" },
			{ "2494975884", "Watopia Pretzel" },
			{ "1064303857", "Watopia's Waistband" },
			{ "2218409282", "WBR Climbing Series" },
			{ "982239385", "Whole Lotta Lava" },
			{ "3621162212", "Zwift Bambino Fondo" },
			{ "242381847", "Zwift Gran Fondo" },
			{ "3748780161", "Zwift Medio Fondo" },
			// Richmond
			{ "4194352271", "Cobbled Climbs Reverse" },
			{ "54700404", "Libby Hill After Party" },
			{ "1638640398", "Richmond Flat Roads" },
			{ "1545087483", "Richmond Hilly Roads" },
			{ "948831673", "Richmond Rollercoaster" },
			{ "1039983620", "Richmond UCI Reverse" },
			{ "2196019512", "Richmond UCI Worlds" },
			// London
			{ "87055383", "Greater London 8" },
			{ "928793662", "Greater London Flat" },
			{ "3276403604", "Greater London Loop" },
			{ "474781994", "Greater London Loop Reverse" },
			{ "1880443431", "Greatest London Flat" },
			{ "3853654821", "Greatest London Loop" },
			{ "3976402826", "Greatest London Loop Reverse" },
			{ "3569674525", "Keith Hill After Party" },
			{ "1230300449", "Leith Hill After Party" },
			{ "4012646479", "London 8" },
			{ "2165880404", "London 8 Reverse" },
			{ "2694166390", "London Classique" },
			{ "3599973269", "London Classique Reverse" },
			{ "913172163", "London Loop" },
			{ "1788889233", "London Loop Reverse" },
			{ "2204461619", "London PRL FULL" },
			{ "764532081", "London PRL Half" },
			{ "3707791029", "Surrey Hills" },
			{ "457851589", "Thames Loop" }, // running?
			{ "163688809", "The London Pretzel" },
			{ "4210048937", "Triple Loops" },
			// New York
			{ "1509089537", "Astoria Line 8" },
			{ "1790569309", "Couch To Sky K" }, // running
			{ "1327665278", "Everything Bagel" },
			{ "711818913", "Flat Irons" }, // running
			{ "480315274", "Gotham Grind" },
			{ "352245150", "Gotham Grind Reverse" },
			{ "2945813240", "Grand Central" },
			{ "3687251774", "Grand Central Rev" },
			{ "3665959404", "Hudson Roll" }, // running
			{ "2954366662", "Knickerbocker" },
			{ "2001106885", "Knickerbocker Reverse" },
			{ "5103974", "Lady Liberty" },
			{ "2422779354", "Laguardia Loop" },
			{ "3774003351", "Laguardia Loop Rev" },
			{ "3066145251", "Lake Loop" }, // running? but present
			{ "3872978134", "Mighty Metropolitan" },
			{ "2372883204", "NYC KOM After Party" },
			{ "1919980508", "Park Perimeter Loop" },
			{ "2202609830", "Park Perimeter Rev" },
			{ "1378559127", "Park To Peak" }, // running
			{ "3078665969", "Rising Empire" },
			{ "2590569306", "Shuman Trail Loop" }, // running
			{ "274775181", "Shuman Trail Rev" }, // running
			{ "3597939700", "The 6 Train" },
			{ "274639515", "The 6 Train Rev" },
			{ "1732356505", "The Highline" },
			{ "1763213625", "The Highline Rev" },
			// Innsbruck
			{ "4009235104", "Achterbahn" },
			{ "275458969", "Inn Loop" },
			{ "2592027600", "Innsbruckring" },
			{ "3649347250", "Innsbruckring KOM" },
			{ "156457316", "Lutscher" },
			{ "3801241714", "Lutscher CCW" },
			{ "3114603308", "UCI Worlds Short Lap" },
			// Bologna
			{ "2843604888", "Bologna Time Trial" },
			// Yorkshire
			{ "2007026433", "2019 UCI Worlds Harrogate Circuit" },
			{ "1233527301", "Duchy Estate" },
			{ "620436060", "Harrogate Circuit Reverse" },
			{ "3007266671", "Queen's Highway" },
			{ "2905381067", "Royal Pump Room 8" },
			{ "1086718516", "Tour Of Tewit Well" },
			// France
			{ "3919912289", "Casse-Pattes" },
			{ "986252325", "Douce France" },
			{ "1433431343", "La Reine" },
			{ "2852153296", "Petit Boucle" },
			{ "1776635757", "R.G.V." },
			{ "872351836", "Roule Ma Poule" },
			{ "2413440572", "Tire-Bouchon" },
			{ "2573468147", "Ven-Top" },
			// Paris
			{ "3364574135", "Champs-Élysées" },
			{ "1236439870", "Lutece Express" },
			// Crit City
			{ "947394567", "Downtown Dolphin" },
			{ "2875658892", "The Bell Lap" }
		};

		public static Dictionary<string, string> RouteLinks = new Dictionary<string, string>
		{
			{ "4240327959", "11.1 Ocean Blvd" },
			{ "3819095753", "5K Loop" },
			{ "3921412335", "https://zwiftinsider.com/route/big-foot-hills/" },
			{ "2947111049", "https://zwiftinsider.com/route/big-loop/" },
			{ "4107844490", "https://zwiftinsider.com/route/big-loop-reverse/" },
			{ "2139708890", "https://zwiftinsider.com/route/bigger-loop/" },
			{ "1373909093", "Chili Pepper" },
			{ "3694952104", "Chili Pepper Rev" },
			{ "2675063596", "https://zwiftinsider.com/route/dust-in-the-wind/" },
			{ "3811569265", "https://zwiftinsider.com/route/flat-route-reverse/" },
			{ "2878180967", "https://zwiftinsider.com/route/four-horsemen/" },
			{ "107363867", "https://zwiftinsider.com/route/hilly-route-reverse/" },
			{ "136957568", "https://zwiftinsider.com/route/jons-route/" },
			{ "743730361", "https://zwiftinsider.com/route/jungle-circuit/" },
			{ "2587199457", "https://zwiftinsider.com/route/jungle-circuit/" },
			{ "2839057126", "https://zwiftinsider.com/route/jungle-circuit-reverse/" },
			{ "3012588561", "https://zwiftinsider.com/route/may-field/" },
			{ "2139465450", "https://zwiftinsider.com/route/muir-and-the-mountain/" },
			//{ "2314974816", "https://zwiftinsider.com/route/ocean-loop/" },
			{ "2748657713", "https://zwiftinsider.com/route/out-and-back-again/" },
			{ "2969952077", "https://zwiftinsider.com/route/quatch-quest/" },
			{ "3701568815", "https://zwiftinsider.com/route/road-to-ruins/" },
			{ "2967612381", "https://zwiftinsider.com/route/road-to-ruins-reverse/" },
			{ "2663908549", "https://zwiftinsider.com/route/road-to-sky/" },
			{ "772562418", "https://zwiftinsider.com/route/run-path-reverse/" },
			{ "604330868", "https://zwiftinsider.com/route/sand-and-sequoias/" },
			{ "3454338139", "https://zwiftinsider.com/route/seaside-sprint/" },
			{ "2128890027", "https://zwiftinsider.com/route/tempus-fugit/" },
			{ "263936293", "https://zwiftinsider.com/route/thats-amore/" },
			{ "1586193601", "https://zwiftinsider.com/route/thats-amore-reverse/" },
			{ "2207442179", "https://zwiftinsider.com/route/the-magnificent-8/" },
			{ "3848492017", "https://zwiftinsider.com/route/the-mega-pretzel/" },
			{ "1475638265", "https://zwiftinsider.com/route/the-uber-pretzel/" },
			{ "4142772830", "https://zwiftinsider.com/route/three-sisters/" },
			{ "4263172118", "https://zwiftinsider.com/route/three-sisters-reverse/" },
			{ "3366225080", "https://zwiftinsider.com/route/tick-tock/" },
			{ "1766405776", "https://zwiftinsider.com/route/tour-of-fire-and-ice/" },
			{ "686828068", "https://zwiftinsider.com/route/volcano-circuit/" },
			{ "3866241330", "https://zwiftinsider.com/route/volcano-circuit-ccw/" },
			{ "849508252", "https://zwiftinsider.com/route/volcano-climb/" },
			{ "3994934674", "https://zwiftinsider.com/route/volcano-flat/" },
			{ "387309391", "https://zwiftinsider.com/volcano-after-party/" },
			{ "1397026382", "https://zwiftinsider.com/route/volcano-flat-reverse/" },
			{ "3382019812", "https://zwiftinsider.com/route/figure-8/" },
			{ "553661379", "https://zwiftinsider.com/route/figure-8-reverse/" },
			{ "3395698268", "https://zwiftinsider.com/route/flat-route/" },
			{ "2737483381", "https://zwiftinsider.com/route/hilly-route/" },
			{ "2966818006", "https://zwiftinsider.com/route/mountain-route/" },
			{ "3219074012", "https://zwiftinsider.com/route/mountain-8/" },
			{ "2494975884", "https://zwiftinsider.com/route/the-pretzel/" },
			{ "1064303857", "https://zwiftinsider.com/route/watopias-waistband/" },
			{ "2218409282", "https://zwiftinsider.com/route/wbr-climbing-series/" },
			{ "982239385", "https://zwiftinsider.com/route/whole-lotta-lava/" },
			{ "3621162212", "https://zwiftinsider.com/route/bambino-fondo/" },
			{ "242381847", "https://zwiftinsider.com/route/gran-fondo/" },
			{ "3748780161", "https://zwiftinsider.com/route/medio-fondo/" },
			{ "4194352271", "https://zwiftinsider.com/route/cobbled-climbs-reverse/" },
			{ "54700404", "https://zwiftinsider.com/route/libby-hill-after-party/" },
			{ "1638640398", "https://zwiftinsider.com/route/the-fan-flats/" },
			{ "1545087483", "https://zwiftinsider.com/route/cobbled-climbs/" },
			{ "948831673", "https://zwiftinsider.com/route/richmond-rollercoaster/" },
			{ "1039983620", "https://zwiftinsider.com/route/richmond-uci-reverse/" },
			{ "2196019512", "https://zwiftinsider.com/route/2015-uci-worlds-course/" },
			{ "87055383", "https://zwiftinsider.com/route/greater-london-8/" },
			{ "928793662", "https://zwiftinsider.com/route/greater-london-flat/" },
			{ "3276403604", "https://zwiftinsider.com/route/greater-london-loop/" },
			{ "474781994", "https://zwiftinsider.com/route/greater-london-loop-reverse/" },
			{ "1880443431", "https://zwiftinsider.com/route/greatest-london-flat/" },
			{ "3853654821", "https://zwiftinsider.com/route/greatest-london-loop/" },
			{ "3976402826", "https://zwiftinsider.com/route/greatest-london-loop-reverse/" },
			{ "3569674525", "https://zwiftinsider.com/route/keith-hill-after-party/" },
			{ "1230300449", "https://zwiftinsider.com/route/leith-hill-after-party/" },
			{ "4012646479", "https://zwiftinsider.com/route/london-8/" },
			{ "2165880404", "https://zwiftinsider.com/route/london-8-reverse/" },
			{ "2694166390", "https://zwiftinsider.com/route/classique/" },
			{ "3599973269", "https://zwiftinsider.com/route/classique-reverse/" },
			{ "913172163", "https://zwiftinsider.com/route/london-loop/" },
			{ "1788889233", "https://zwiftinsider.com/route/london-loop-reverse/" },
			{ "2204461619", "https://zwiftinsider.com/route/london-the-prl-full/" },
			{ "764532081", "https://zwiftinsider.com/route/the-prl-half/" },
			{ "3707791029", "https://zwiftinsider.com/route/surrey-hills/" },
			//{ "457851589", "https://zwiftinsider.com/route/thames-loop/" },
			{ "163688809", "https://zwiftinsider.com/route/the-london-pretzel/" },
			{ "4210048937", "https://zwiftinsider.com/route/triple-loops/" },
			{ "1509089537", "https://zwiftinsider.com/route/astoria-line-8/" },
			{ "1790569309", "https://zwiftinsider.com/route/couch-to-sky-k/" },
			{ "1327665278", "https://zwiftinsider.com/route/everything-bagel/" },
			{ "711818913", "https://zwiftinsider.com/route/flat-irons/" },
			{ "480315274", "https://zwiftinsider.com/route/gotham-grind/" },
			{ "352245150", "https://zwiftinsider.com/route/gotham-grind-reverse/" },
			{ "2945813240", "https://zwiftinsider.com/route/grand-central-circuit/" },
			{ "3687251774", "https://zwiftinsider.com/route/grand-central-circuit-reverse/" },
			{ "3665959404", "https://zwiftinsider.com/route/hudson-roll/" },
			{ "2954366662", "https://zwiftinsider.com/route/knickerbocker/" },
			{ "2001106885", "https://zwiftinsider.com/route/knickerbocker-reverse/" },
			{ "5103974", "https://zwiftinsider.com/route/lady-liberty/" },
			{ "2422779354", "https://zwiftinsider.com/route/laguardia-loop/" },
			{ "3774003351", "https://zwiftinsider.com/route/laguardia-loop-reverse/" },
			//{ "3066145251", "https://zwiftinsider.com/route/lake-loop/" },
			{ "3872978134", "https://zwiftinsider.com/route/mighty-metropolitan/" },
			{ "2372883204", "https://zwiftinsider.com/route/nyc-kom-after-party/" },
			{ "1919980508", "https://zwiftinsider.com/route/park-perimeter-loop/" },
			{ "2202609830", "https://zwiftinsider.com/route/park-perimeter-reverse/" },
			{ "1378559127", "https://zwiftinsider.com/route/park-to-peak/" },
			{ "3078665969", "https://zwiftinsider.com/route/rising-empire/" },
			{ "2590569306", "https://zwiftinsider.com/route/shuman-trail-loop/" },
			{ "274775181", "https://zwiftinsider.com/route/shuman-trail-loop-reverse/" },
			{ "3597939700", "https://zwiftinsider.com/route/the-6-train/" },
			{ "274639515", "https://zwiftinsider.com/route/the-6-train-reverse/" },
			{ "1732356505", "https://zwiftinsider.com/route/the-highline/" },
			{ "1763213625", "https://zwiftinsider.com/route/the-highline-reverse/" },
			{ "4009235104", "https://zwiftinsider.com/route/achterbahn/" },
			//{ "275458969", "https://zwiftinsider.com/route/inn-loop/" },
			{ "2592027600", "https://zwiftinsider.com/route/innsbruckring/" },
			{ "3649347250", "https://zwiftinsider.com/route/kom-after-party/" },
			{ "156457316", "https://zwiftinsider.com/route/lutscher/" },
			{ "3801241714", "https://zwiftinsider.com/route/lutscher-ccw/" },
			{ "3114603308", "https://zwiftinsider.com/route/2018-uci-worlds-course-short-lap/" },
			{ "2843604888", "https://zwiftinsider.com/route/bologna-time-triallap/" },
			{ "2007026433", "https://zwiftinsider.com/route/2019-uci-worlds-harrogate-circuit/" },
			{ "1233527301", "https://zwiftinsider.com/route/duchy-estate/" },
			{ "620436060", "https://zwiftinsider.com/route/harrogate-circuit-reverse/" },
			{ "3007266671", "https://zwiftinsider.com/route/queen's-highway/" },
			{ "2905381067", "https://zwiftinsider.com/route/royal-pump-room-8/" },
			{ "1086718516", "https://zwiftinsider.com/route/tour-of-tewit-well/" },
			{ "3919912289", "https://zwiftinsider.com/route/casse-pattes/" },
			{ "986252325", "https://zwiftinsider.com/route/douce-france/" },
			{ "1433431343", "https://zwiftinsider.com/route/la-reine/" },
			{ "2852153296", "https://zwiftinsider.com/route/petit-boucle/" },
			{ "1776635757", "https://zwiftinsider.com/route/rgv/" },
			{ "872351836", "https://zwiftinsider.com/route/roule-ma-poule/" },
			{ "2413440572", "https://zwiftinsider.com/route/tire-bouchon/" },
			{ "2573468147", "https://zwiftinsider.com/route/ven-top/" },
			{ "3364574135", "https://zwiftinsider.com/route/champs-elysees/" },
			{ "1236439870", "https://zwiftinsider.com/route/lutece-express/" },
			{ "947394567", "https://zwiftinsider.com/route/downtown-dolphin/" },
			{ "2875658892", "https://zwiftinsider.com/route/bell-lap/" }
		};
	}
}
