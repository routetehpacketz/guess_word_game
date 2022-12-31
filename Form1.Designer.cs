using System;
using System.Collections.Generic;
//using System.Diagnostics.Tracing;
//using System.Linq;
//using System.Security.Cryptography;
using System.Windows.Forms;
//using System.Windows.Forms.VisualStyles;

namespace guess_word_game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private static string[] words_array = { "ABACK","ABASE","ABASH","ABATE","ABBEY","ABBOT","ABHOR","ABIDE","ABODE","ABORT","ABOUT","ABOVE","ABUSE","ABYSS","ACHED","ACHES","ACIDS","ACING","ACORN","ACRES","ACRID","ACTED","ACTOR","ACUTE","ADAPT","ADDED","ADDER","ADEPT","ADMIT","ADOPT","ADORE","ADORN","ADULT","AFFIX","AFIRE","AFOOT","AFOUL","AFTER","AGAIN","AGAPE","AGENT","AGILE","AGING","AGLOW","AGONY","AGREE","AHEAD","AIDED","AIDER","AILED","AIMED","AIMER","AIRED","AISLE","ALARM","ALBUM","ALERT","ALGAE","ALIAS","ALIBI","ALIEN","ALIGN","ALIKE","ALIVE","ALLEY","ALLOW","ALLOY","ALOFT","ALONE","ALONG","ALOOF","ALOUD","ALTAR","ALTER","ALTOS","AMASS","AMAZE","AMBER","AMBLE","AMEND","AMINO","AMISS","AMONG","AMPLE","AMPLY","AMUSE","ANGEL","ANGER","ANGLE","ANGRY","ANGST","ANION","ANISE","ANKLE","ANNEX","ANNOY","ANNUL","ANODE","ANTIC","ANVIL","AORTA","APACE","APART","APPLE","APPLY","APRON","APTLY","ARBOR","ARDOR","AREAS","ARENA","ARGUE","ARISE","ARMED","ARMOR","AROMA","AROSE","ARRAY","ARROW","ARSON","ASHEN","ASHES","ASIDE","ASKED","ASKER","ASKEW","ASSAY","ASSET","ATLAS","ATOLL","ATOMS","ATONE","ATTIC","AUDIO","AUDIT","AUGER","AUGHT","AUGUR","AUNTS","AURAL","AURAS","AUTOS","AVAIL","AVERS","AVERT","AVIAN","AVOID","AVOWS","AWAIT","AWAKE","AWARD","AWARE","AWASH","AWFUL","AWING","AWOKE","AXIAL","AXING","AXIOM","AXLES","AXONS","AZURE","BABES","BACKS","BACON","BADGE","BADLY","BAGEL","BAGGY","BAITS","BAKED","BAKER","BAKES","BALED","BALER","BALES","BALKS","BALKY","BALLS","BALMS","BALMY","BALSA","BANAL","BANDS","BANDY","BANGS","BANJO","BANKS","BARBS","BARDS","BARED","BARER","BARES","BARGE","BARKS","BARNS","BARON","BASED","BASER","BASES","BASIC","BASIL","BASIN","BASIS","BASSO","BASTE","BATCH","BATED","BATHE","BATHS","BATON","BAWDY","BAWLS","BAYED","BAYOU","BEACH","BEADS","BEADY","BEAKS","BEAMS","BEANS","BEARD","BEARS","BEAST","BEATS","BEECH","BEEFS","BEEFY","BEEPS","BEERS","BEETS","BEFIT","BEFOG","BEGAN","BEGET","BEGIN","BEGOT","BEGUN","BEIGE","BEING","BELAY","BELCH","BELIE","BELLE","BELLS","BELLY","BELOW","BELTS","BENCH","BENDS","BENTS","BERET","BERRY","BERTH","BESTS","BETAS","BIBLE","BIDDY","BIDED","BIDES","BIGLY","BIGOT","BIKED","BIKER","BIKES","BILGE","BILLS","BINDS","BINGE","BINGO","BIPED","BIRCH","BIRDS","BIRTH","BISON","BITER","BITES","BLABS","BLACK","BLADE","BLAME","BLAND","BLANK","BLARE","BLAST","BLAZE","BLEAK","BLEAR","BLEAT","BLEED","BLEND","BLESS","BLIMP","BLIND","BLINK","BLIPS","BLISS","BLITZ","BLOAT","BLOBS","BLOCK","BLOKE","BLOND","BLOOD","BLOOM","BLOTS","BLOWN","BLOWS","BLUER","BLUES","BLUFF","BLUNT","BLURB","BLURS","BLURT","BLUSH","BOARD","BOAST","BOATS","BOBBY","BODED","BODES","BOGUS","BOILS","BOLTS","BOMBS","BONDS","BONED","BONES","BONNY","BONUS","BOOKS","BOOMS","BOORS","BOOST","BOOTH","BOOTS","BOOTY","BOOZE","BORAX","BORED","BORER","BORES","BORIC","BORNE","BORON","BOTCH","BOUGH","BOUND","BOUTS","BOWED","BOWEL","BOWER","BOWLS","BOXED","BOXER","BOXES","BRACE","BRAGS","BRAID","BRAIN","BRAKE","BRAND","BRASH","BRASS","BRATS","BRAVE","BRAVO","BRAWL","BRAWN","BRAYS","BRAZE","BREAD","BREAK","BREED","BREWS","BRIAR","BRIBE","BRICK","BRIDE","BRIEF","BRINE","BRING","BRINK","BRISK","BROAD","BROIL","BROKE","BROOD","BROOK","BROOM","BROTH","BROWN","BROWS","BRUNT","BRUSH","BRUTE","BUCKS","BUDDY","BUDGE","BUFFS","BUGGY","BUGLE","BUILD","BUILT","BULBS","BULGE","BULKS","BULKY","BULLS","BULLY","BUMPS","BUNCH","BUNKS","BUNNY","BUNTS","BUOYS","BURLY","BURNS","BURNT","BURPS","BURRS","BURST","BUSHY","BUSTS","BUTTS","BUYER","BYLAW","BYTES","BYWAY","CABIN","CABLE","CACHE","CACTI","CAFES","CAGED","CAGES","CAKED","CAKES","CALLS","CALMS","CAMEL","CAMPS","CANAL","CANDY","CANED","CANES","CANOE","CANON","CAPER","CAPES","CARDS","CARED","CARES","CARGO","CAROL","CARRY","CARTS","CARVE","CASED","CASES","CASKS","CASTS","CATCH","CATER","CAUSE","CAVED","CAVES","CAWED","CEASE","CEDAR","CELLS","CENTS","CHAFE","CHAFF","CHAIN","CHAIR","CHALK","CHANT","CHAOS","CHAPS","CHARM","CHARS","CHART","CHASE","CHASM","CHATS","CHEAP","CHEAT","CHECK","CHEEK","CHEER","CHEFS","CHESS","CHEST","CHEWS","CHICK","CHIDE","CHIEF","CHILD","CHILL","CHIME","CHINK","CHINS","CHIPS","CHIRP","CHOCK","CHOIR","CHOKE","CHOPS","CHORD","CHORE","CHOSE","CHUCK","CHUMP","CHUMS","CHUNK","CHURN","CHUTE","CIDER","CIGAR","CITED","CITES","CIVIC","CIVIL","CLAIM","CLAMP","CLAMS","CLANG","CLANS","CLAPS","CLASH","CLASP","CLASS","CLAWS","CLAYS","CLEAN","CLEAR","CLEFT","CLERK","CLICK","CLIFF","CLIMB","CLIME","CLING","CLINK","CLIPS","CLOAK","CLOCK","CLODS","CLOGS","CLONE","CLOSE","CLOTH","CLOUD","CLOUT","CLOVE","CLOWN","CLUBS","CLUCK","CLUES","CLUMP","CLUNG","COACH","COALS","COAST","COATS","COCOA","CODED","CODER","CODES","COILS","COINS","COKES","COLDS","COLON","COLOR","COLTS","COMBO","COMBS","COMER","COMES","COMET","COMIC","COMMA","CONED","CONES","COOKS","COOLS","COONS","COOPS","COPED","COPES","CORAL","CORDS","CORED","CORER","CORES","CORNS","CORPS","COSTS","COUCH","COUGH","COULD","COUNT","COURT","COVER","COVES","COVET","COWED","COWER","COWLS","CRABS","CRACK","CRAFT","CRAGS","CRAMP","CRAMS","CRANE","CRANK","CRASH","CRATE","CRAVE","CRAWL","CRAZE","CRAZY","CREAK","CREAM","CREED","CREEK","CREEP","CREPE","CREPT","CREST","CREWS","CRIBS","CRIED","CRIER","CRIES","CRIME","CRISP","CROAK","CROOK","CROPS","CROSS","CROWD","CROWN","CROWS","CRUDE","CRUEL","CRUMB","CRUSH","CRUST","CUBED","CUBES","CUBIC","CUFFS","CUING","CULLS","CULTS","CURBS","CURDS","CURED","CURER","CURES","CURLS","CURLY","CURRY","CURSE","CURVE","CUSPS","CUTER","CUTES","CYCLE","CYSTS","DADDY","DAILY","DAIRY","DAISY","DALES","DAMPS","DANCE","DANDY","DARED","DARER","DARES","DARKS","DARNS","DARTS","DATED","DATER","DATES","DAUNT","DAWNS","DAZED","DAZES","DEALS","DEALT","DEANS","DEARS","DEATH","DEBTS","DEBUG","DECAY","DECKS","DECOY","DEEDS","DEEMS","DEEPS","DEFER","DEIGN","DEITY","DELAY","DELLS","DELTA","DELVE","DEMON","DEMOS","DENSE","DENTS","DEPOT","DEPTH","DERBY","DESKS","DEVIL","DEWED","DIALS","DIARY","DICER","DICES","DIETS","DIGIT","DIMES","DIMLY","DINED","DINER","DINES","DINGY","DIODE","DIRER","DIRGE","DIRTY","DISCS","DISKS","DITCH","DIVAN","DIVED","DIVER","DIVES","DIZZY","DOCKS","DODGE","DOERS","DOGMA","DOING","DOLED","DOLES","DOLLS","DOLLY","DOMED","DOMES","DOOMS","DOORS","DOPED","DOPER","DOPES","DOSED","DOSES","DOTED","DOTER","DOTES","DOUBT","DOUGH","DOUSE","DOVES","DOWNS","DOWNY","DOZED","DOZEN","DOZER","DOZES","DRABS","DRAFT","DRAGS","DRAIN","DRAKE","DRAMA","DRANK","DRAPE","DRAWL","DRAWN","DRAWS","DREAD","DREAM","DREGS","DRESS","DRIED","DRIER","DRIES","DRIFT","DRILL","DRILY","DRINK","DRIPS","DRIVE","DRONE","DROOL","DROOP","DROPS","DROVE","DROWN","DRUGS","DRUMS","DRUNK","DRYLY","DUALS","DUCKS","DUELS","DUKES","DULLS","DULLY","DUMMY","DUMPS","DUNCE","DUNES","DUSKY","DUSTS","DUSTY","DWARF","DWELL","DYERS","DYING","EAGER","EAGLE","EARED","EARLS","EARLY","EARNS","EARTH","EASED","EASES","EATEN","EATER","EAVES","EBBED","EBONY","EDGED","EDGER","EDGES","EDICT","EDITS","EERIE","EGGED","EGGER","EIGHT","EJECT","ELATE","ELBOW","ELDER","ELECT","ELUDE","ELVES","EMAIL","EMBED","EMBER","EMERY","EMITS","EMPTY","ENACT","ENDED","ENDER","ENDOW","ENEMY","ENJOY","ENSUE","ENTER","ENTRY","ENVOY","EPICS","EPOCH","EQUAL","EQUIP","ERASE","ERECT","ERRED","ERROR","ESSAY","ETHIC","EVADE","EVENS","EVENT","EVERY","EVICT","EVILS","EVOKE","EXACT","EXALT","EXAMS","EXCEL","EXERT","EXILE","EXIST","EXITS","EXPEL","EXTOL","EXTRA","EXULT","EYING","FABLE","FACED","FACER","FACES","FACET","FACTS","FADED","FADER","FADES","FAILS","FAINT","FAIRS","FAIRY","FAITH","FAKED","FAKER","FAKES","FALLS","FALSE","FAMED","FAMES","FANCY","FANGS","FARCE","FARED","FARER","FARES","FARMS","FASTS","FATAL","FATED","FATES","FATLY","FAULT","FAVOR","FAWNS","FEARS","FEAST","FEATS","FEEDS","FEELS","FEIGN","FELLS","FELTS","FEMUR","FENCE","FERNS","FERRY","FETCH","FETUS","FEUDS","FEVER","FEWER","FIBER","FIELD","FIEND","FIERY","FIFTH","FIFTY","FIGHT","FILED","FILER","FILES","FILLS","FILMS","FILTH","FINAL","FINDS","FINED","FINER","FINES","FIRED","FIRER","FIRES","FIRMS","FIRST","FIRTH","FISTS","FITLY","FIVES","FIXED","FIXER","FIXES","FLAGS","FLAKE","FLAME","FLANK","FLAPS","FLARE","FLASH","FLASK","FLATS","FLAWS","FLEAS","FLEER","FLEES","FLEET","FLESH","FLEWS","FLICK","FLIER","FLIES","FLING","FLINT","FLIPS","FLIRT","FLITS","FLOAT","FLOCK","FLOOD","FLOOR","FLOPS","FLORA","FLOSS","FLOUR","FLOWN","FLOWS","FLUID","FLUNG","FLUNK","FLUSH","FLUTE","FLYER","FOAMS","FOCAL","FOCUS","FOGGY","FOILS","FOLDS","FOLKS","FOLLY","FONTS","FOODS","FOOLS","FOOTS","FORAY","FORCE","FORDS","FORGE","FORKS","FORMS","FORTE","FORTH","FORTS","FORTY","FORUM","FOULS","FOUND","FOURS","FOWLS","FOXED","FOXES","FRAIL","FRAME","FRANC","FRANK","FRAUD","FRAYS","FREAK","FREED","FREER","FREES","FRESH","FRETS","FRIAR","FRIED","FRIES","FRILL","FRISK","FROCK","FROGS","FRONT","FROST","FROTH","FROWN","FROZE","FRUIT","FUELS","FULLY","FUMED","FUMES","FUNDS","FUNNY","FUSED","FUSES","FUZZY","GABLE","GAILY","GAINS","GAITS","GALES","GALLS","GAMED","GAMES","GAMMA","GANGS","GAPED","GAPER","GAPES","GASES","GASPS","GATED","GATES","GAUDY","GAUGE","GAUNT","GAUZE","GAYER","GAZED","GAZER","GAZES","GEARS","GEESE","GENES","GENRE","GENUS","GERMS","GHOST","GIANT","GIDDY","GIFTS","GILDS","GILLS","GIRLS","GIRTH","GIVEN","GIVER","GIVES","GIZMO","GLADE","GLAND","GLARE","GLASS","GLAZE","GLEAM","GLEAN","GLEES","GLENS","GLIDE","GLINT","GLOBE","GLOOM","GLORY","GLOSS","GLOVE","GLOWS","GLUED","GLUER","GLUES","GNATS","GNAWS","GOADS","GOALS","GOATS","GODLY","GOING","GONER","GONGS","GOODS","GOODY","GOOSE","GORED","GORES","GORGE","GOUGE","GOWNS","GRABS","GRACE","GRADE","GRAFT","GRAIN","GRAMS","GRAND","GRANT","GRAPE","GRAPH","GRASP","GRASS","GRATE","GRAVE","GRAVY","GRAYS","GRAZE","GREAT","GREED","GREEN","GREET","GRIDS","GRIEF","GRILL","GRIND","GRINS","GRIPE","GRIPS","GRITS","GROAN","GROOM","GROPE","GROSS","GROUP","GROVE","GROWL","GROWN","GROWS","GRUBS","GRUFF","GRUNT","GUARD","GUESS","GUEST","GUIDE","GUILD","GUILE","GUILT","GUISE","GULCH","GULFS","GULLS","GULLY","GULPS","GURUS","GUSTS","GYPSY","HABIT","HACKS","HAILS","HAIRS","HAIRY","HALLS","HALTS","HALVE","HANDS","HANDY","HANGS","HAPLY","HAPPY","HARDY","HARES","HARKS","HARMS","HARPS","HARRY","HARSH","HASTE","HASTY","HATCH","HATED","HATER","HATES","HAULS","HAUNT","HAVEN","HAVES","HAVOC","HAWKS","HAZED","HAZEL","HAZER","HAZES","HEADS","HEALS","HEAPS","HEARD","HEARS","HEART","HEATH","HEATS","HEAVE","HEAVY","HEDGE","HEEDS","HEELS","HEIRS","HELLO","HELLS","HELPS","HENCE","HERBS","HERDS","HERON","HIDED","HIDER","HIDES","HIKED","HIKER","HIKES","HILLS","HILTS","HINDS","HINGE","HINTS","HIRED","HIRER","HIRES","HITCH","HIVES","HOARD","HOARY","HOBBY","HOIST","HOLDS","HOLED","HOLES","HOLLY","HOMED","HOMER","HOMES","HONED","HONES","HONEY","HONOR","HOODS","HOOFS","HOOKS","HOOPS","HOOTS","HOPED","HOPER","HOPES","HORDE","HORNS","HORSE","HOSED","HOSES","HOSTS","HOTEL","HOTLY","HOUND","HOURS","HOUSE","HOVEL","HOVER","HOWLS","HULLS","HUMAN","HUMID","HUMOR","HUMPS","HUNCH","HUNKS","HUNTS","HURRY","HURTS","HUSKS","HUSKY","HYMNS","HYPED","HYPER","HYPES","ICIER","ICING","ICONS","IDEAL","IDEAS","IDIOT","IDLED","IDLER","IDLES","IDOLS","IMAGE","IMPEL","IMPLY","INANE","INAPT","INCUR","INDEX","INERT","INFER","INFIX","INGOT","INKED","INKER","INLET","INNER","INPUT","IRATE","IRKED","IRONS","IRONY","ISLES","ISLET","ISSUE","ITEMS","IVIED","IVIES","IVORY","JACKS","JADED","JADES","JAILS","JAUNT","JAWED","JEANS","JEEPS","JEERS","JELLY","JENNY","JERKS","JERKY","JESTS","JEWEL","JOCKS","JOHNS","JOINS","JOINT","JOKED","JOKER","JOKES","JOLLY","JOLTS","JOUST","JUDGE","JUICE","JUICY","JUMPS","JUMPY","JUNKS","JUNKY","JUROR","KEELS","KEEPS","KEYED","KICKS","KILLS","KINDS","KINGS","KITES","KITTY","KNACK","KNAVE","KNEAD","KNEED","KNEEL","KNEES","KNELL","KNELT","KNIFE","KNITS","KNOBS","KNOCK","KNOLL","KNOTS","KNOWN","KNOWS","LABOR","LACED","LACER","LACES","LACKS","LADED","LADEN","LAGER","LAIRS","LAKES","LAMBS","LAMED","LAMER","LAMES","LAMPS","LANCE","LANDS","LANES","LAPEL","LAPSE","LARDS","LARGE","LARKS","LARVA","LASER","LASTS","LATCH","LATER","LATEX","LAUGH","LAWNS","LAYER","LAZED","LEADS","LEAFS","LEAFY","LEAKS","LEANS","LEAPS","LEAPT","LEARN","LEASE","LEASH","LEAST","LEAVE","LEDGE","LEECH","LEFTS","LEGAL","LEMON","LENDS","LEVEE","LEVEL","LEVER","LIARS","LIEGE","LIENS","LIFTS","LIGHT","LIKED","LIKEN","LIKER","LIKES","LILAC","LIMBS","LIMES","LIMIT","LIMPS","LINED","LINEN","LINER","LINES","LINKS","LIONS","LISPS","LISTS","LITER","LITHE","LIVED","LIVEN","LIVER","LIVES","LOAFS","LOANS","LOATH","LOBBY","LOBED","LOBES","LOCAL","LOCKS","LOCUS","LODGE","LOFTS","LOFTY","LOGIC","LOGIN","LOINS","LONER","LONGS","LOOKS","LOOMS","LOOPS","LOOSE","LOOTS","LORDS","LOSER","LOSES","LOTUS","LOUSY","LOVED","LOVER","LOVES","LOWER","LOWLY","LOYAL","LUCKS","LUCKY","LULLS","LUMPS","LUNAR","LUNCH","LUNGS","LURCH","LURED","LURES","LURKS","LUSTS","LUSTY","LUTES","LYING","LYMPH","LYNCH","LYRES","LYRIC","MACES","MACRO","MADAM","MADLY","MAGIC","MAIDS","MAILS","MAIMS","MAINS","MAJOR","MAKER","MAKES","MALES","MALLS","MALTS","MANES","MANLY","MANOR","MAPLE","MARCH","MARES","MARKS","MARRY","MARSH","MARTS","MASKS","MASON","MASTS","MATCH","MATED","MATER","MATES","MAYBE","MAYOR","MAZES","MEADS","MEALS","MEANS","MEANT","MEATS","MEDAL","MEDIA","MEDIC","MEETS","MELDS","MELON","MELTS","MEMOS","MENDS","MENUS","MERCY","MERGE","MERIT","MERRY","MESSY","METAL","METED","METER","METES","MEWED","MIDST","MIFFS","MIGHT","MILES","MILKS","MILKY","MILLS","MIMIC","MINCE","MINDS","MINED","MINER","MINES","MINKS","MINOR","MINTS","MINUS","MIRED","MIRES","MIRTH","MISER","MISTS","MISTY","MITER","MITES","MIXED","MIXER","MIXES","MOANS","MOATS","MOCKS","MODAL","MODEL","MODEM","MODES","MODUS","MOIST","MOLDS","MOLDY","MOLES","MONEY","MONKS","MONTH","MOODS","MOODY","MOONS","MOORS","MOOSE","MOPED","MORAL","MORES","MOSSY","MOTEL","MOTIF","MOTOR","MOTTO","MOULD","MOUND","MOUNT","MOURN","MOUSE","MOUTH","MOVED","MOVER","MOVES","MOVIE","MOWED","MOWER","MUCKS","MUDDY","MUFFS","MULES","MUMMY","MUNCH","MURAL","MURKY","MUSED","MUSES","MUSHY","MUSIC","MUSTS","MUSTY","MUTED","MUTER","MUTES","NAILS","NAIVE","NAKED","NAMED","NAMES","NASAL","NASTY","NAVAL","NEARS","NECKS","NEEDS","NEEDY","NEIGH","NERVE","NESTS","NEVER","NEWER","NEWLY","NEWTS","NICER","NICHE","NICKS","NIECE","NIFTY","NIGHT","NINES","NINTH","NIXED","NIXES","NOBLE","NOBLY","NODES","NOISE","NOISY","NOOKS","NORMS","NORTH","NOSED","NOSES","NOTCH","NOTED","NOTES","NOUNS","NOVEL","NUMBS","NURSE","NYMPH","OAKEN","OARED","OASIS","OATEN","OATER","OATHS","OBEYS","OCCUR","OCEAN","OCTAL","ODDER","ODDLY","ODORS","OFFER","OFTEN","OILED","OILER","OKAYS","OLDEN","OLDER","OLIVE","OMENS","OMITS","ONION","ONSET","OOZED","OOZES","OPALS","OPENS","OPERA","OPTED","OPTIC","ORALS","ORBIT","ORDER","OTHER","OTTER","OUGHT","OUNCE","OUTER","OVALS","OVARY","OVENS","OVERT","OWING","OWNED","OWNER","OXIDE","PACED","PACER","PACES","PACKS","PACTS","PADDY","PAGAN","PAGED","PAGER","PAGES","PAILS","PAINS","PAINT","PAIRS","PALED","PALER","PALES","PALMS","PANDA","PANEL","PANES","PANGS","PANIC","PANSY","PANTS","PANTY","PAPAL","PAPER","PARCH","PARES","PARKS","PARRY","PARSE","PARTS","PARTY","PASTE","PASTS","PATCH","PATED","PATHS","PATTY","PAUSE","PAVED","PAVER","PAVES","PAWED","PAWNS","PAYER","PEACE","PEACH","PEAKS","PEALS","PEARL","PEARS","PECKS","PEEKS","PEELS","PEEPS","PEERS","PEEVE","PELTS","PENCE","PENNY","PERCH","PERIL","PESTS","PETAL","PETER","PETTY","PHASE","PHONE","PHOTO","PIANO","PICKS","PIECE","PIERS","PIETY","PIKER","PIKES","PILED","PILES","PILLS","PILOT","PINCH","PINED","PINES","PINKS","PINTS","PIOUS","PIPED","PIPER","PIPES","PIQUE","PITCH","PITHY","PIVOT","PIXEL","PLACE","PLAID","PLAIN","PLAIT","PLANE","PLANK","PLANS","PLANT","PLATE","PLAYS","PLEAD","PLEAS","PLIED","PLIES","PLODS","PLOTS","PLOWS","PLOYS","PLUCK","PLUGS","PLUMB","PLUME","PLUMP","PLUMS","PLUSH","POACH","POEMS","POETS","POINT","POISE","POKED","POKER","POKES","POLAR","POLED","POLES","POLLS","PONDS","POOLS","POPES","POPPY","PORCH","PORED","PORES","PORTS","POSED","POSER","POSES","POSIT","POSTS","POUCH","POUND","POURS","POUTS","POWER","POXES","PRANK","PRATE","PRAYS","PRESS","PREYS","PRICE","PRICK","PRIDE","PRIED","PRIER","PRIES","PRINT","PRIOR","PRISM","PRIVY","PRIZE","PROBE","PRONE","PRONG","PROOF","PROPS","PROSE","PROUD","PROVE","PROWL","PROWS","PRUNE","PSALM","PSHAW","PSYCH","PUBES","PUBIC","PUCKS","PUDGY","PUFFS","PUFFY","PUKED","PUKES","PULLS","PULPS","PULPY","PULSE","PUMAS","PUMPS","PUNCH","PUNKS","PUNTS","PUPAE","PUPAS","PUPIL","PUPPY","PUREE","PURER","PURGE","PURLS","PURRS","PURSE","PURSY","PUSHY","PUTTS","PUTTY","PYGMY","PYLON","PYRES","QUACK","QUADS","QUAFF","QUAIL","QUAKE","QUAKY","QUALM","QUANT","QUARK","QUART","QUASH","QUASI","QUEEN","QUEER","QUELL","QUERY","QUEST","QUEUE","QUICK","QUIET","QUILL","QUILT","QUIPS","QUIRE","QUIRK","QUITE","QUITS","QUOTA","QUOTE","RABBI","RABID","RACED","RACER","RACES","RACKS","RADAR","RADII","RADIO","RADIX","RADON","RAFTS","RAGES","RAIDS","RAILS","RAINS","RAINY","RAISE","RAKED","RAKES","RALLY","RAMEN","RAMPS","RANCH","RANGE","RANGY","RANKS","RAPID","RARER","RASPS","RASPY","RATED","RATER","RATES","RATIO","RATTY","RAVED","RAVEL","RAVEN","RAVES","RAWER","RAYED","RAYON","RAZED","RAZES","RAZOR","REACH","REACT","READS","READY","REALM","REAMS","REAPS","REARM","REARS","REBAR","REBEL","REBID","REBUS","REBUT","RECAP","RECON","RECTA","RECTO","RECUR","REDID","REDUB","REEDS","REEDY","REEFS","REEKS","REELS","REEVE","REFER","REFIT","REFRY","REGAL","REHAB","REIFY","REIGN","REINS","REKEY","RELAX","RELAY","RELIC","RELIT","REMAP","REMIT","REMIX","RENAL","RENDS","RENEW","RENTS","REPAY","REPEL","REPLY","REPOS","REPOT","REPRO","RERAN","RERUN","RESET","RESIN","RESTS","RETAG","RETCH","RETIE","RETRO","RETRY","REUSE","REVEL","REVUE","REWET","REXES","RHINO","RHYME","RICER","RICKS","RIDER","RIDES","RIDGE","RIFER","RIFFS","RIFLE","RIFTS","RIGHT","RIGID","RIGOR","RILED","RILES","RILEY","RILLS","RIMED","RIMES","RINDS","RINGS","RINKS","RINSE","RIOTS","RIPEN","RIPER","RISEN","RISER","RISES","RISKS","RISKY","RITES","RITZY","RIVAL","RIVED","RIVER","RIVES","RIVET","RIYAL","ROACH","ROADS","ROAMS","ROANS","ROARS","ROAST","ROBED","ROBES","ROBIN","ROBOT","ROCKS","ROCKY","RODEO","ROGER","ROGUE","ROLES","ROLLS","ROMAN","ROMPS","RONDO","ROODS","ROOFS","ROOKS","ROOKY","ROOMS","ROOMY","ROOST","ROOTS","ROPED","ROPER","ROPES","ROPEY","ROSES","ROSIN","ROTES","ROTOR","ROUGE","ROUGH","ROUND","ROUSE","ROUST","ROUTE","ROUTS","ROVED","ROVER","ROVES","ROWAN","ROWDY","ROWED","ROWER","ROYAL","RUBES","RUCHE","RUDDY","RUDER","RUFFS","RUGBY","RUINS","RULED","RULER","RULES","RUMBA","RUMEN","RUMMY","RUMOR","RUMPS","RUNES","RUNGS","RUNIC","RUNNY","RUNTS","RUNTY","RUPEE","RURAL","RUSES","RUSTS","RUSTY","RUTTY","SABER","SABLE","SABOT","SACKS","SACRA","SADLY","SAFER","SAFES","SAGAS","SAGER","SAGES","SAGGY","SAILS","SAINT","SAKES","SALAD","SALES","SALLY","SALON","SALSA","SALTS","SALTY","SALVE","SALVO","SAMBA","SANDS","SANDY","SANER","SAPID","SAPPY","SARAN","SARIS","SASSY","SATED","SATES","SATIN","SAUCE","SAUCY","SAUNA","SAVED","SAVER","SAVES","SAVOR","SAVVY","SAWED","SAXES","SCABS","SCADS","SCALD","SCALE","SCALP","SCALY","SCAMP","SCAMS","SCANS","SCANT","SCARE","SCARF","SCARP","SCARS","SCARY","SCATS","SCENE","SCENT","SCOFF","SCOLD","SCONE","SCOOP","SCOOT","SCOPE","SCORE","SCORN","SCOUR","SCOUT","SCOWL","SCOWS","SCRAM","SCRAP","SCREW","SCRIM","SCRUB","SCRUM","SCUBA","SCUFF","SCULL","SEALS","SEAMS","SEAMY","SEARS","SEATS","SECTS","SEDAN","SEDGE","SEDUM","SEEDS","SEEDY","SEEKS","SEEMS","SEEPS","SEERS","SEGUE","SEINE","SEISM","SEIZE","SELLS","SEMIS","SENDS","SENSE","SEPAL","SEPIA","SEPTA","SERER","SERFS","SERGE","SERIF","SERUM","SERVE","SETUP","SEVEN","SEVER","SEWED","SEWER","SEXES","SHACK","SHADE","SHADY","SHAFT","SHAKE","SHAKY","SHALE","SHALL","SHAME","SHAMS","SHANK","SHAPE","SHARD","SHARE","SHARK","SHARP","SHAVE","SHAWL","SHAYS","SHEAF","SHEAR","SHEDS","SHEEN","SHEEP","SHEER","SHEET","SHEIK","SHELF","SHELL","SHIED","SHIER","SHIES","SHIFT","SHIMS","SHINE","SHINS","SHINY","SHIPS","SHIRE","SHIRT","SHOCK","SHOED","SHOES","SHONE","SHOOK","SHOOS","SHOOT","SHOPS","SHORE","SHORT","SHOTS","SHOUT","SHOVE","SHOWN","SHOWS","SHOWY","SHRED","SHREW","SHRUB","SHRUG","SHUCK","SHUNS","SHUNT","SHUSH","SHUTS","SHYER","SHYLY","SIDED","SIDES","SIDLE","SIEGE","SIEVE","SIFTS","SIGHS","SIGHT","SIGMA","SIGNS","SILKS","SILKY","SILLS","SILLY","SILOS","SILTS","SINCE","SINEW","SINGE","SINGS","SINKS","SINUS","SIRED","SIREN","SIRES","SISSY","SITAR","SITED","SITES","SIXES","SIXTH","SIXTY","SIZED","SIZES","SKATE","SKEIN","SKEWS","SKIDS","SKIED","SKIER","SKIES","SKILL","SKIMS","SKINK","SKINS","SKIPS","SKIRT","SKITS","SKULK","SKULL","SKUNK","SLABS","SLACK","SLAIN","SLAKE","SLAMS","SLANG","SLANT","SLAPS","SLASH","SLATE","SLATS","SLAVE","SLAWS","SLAYS","SLEDS","SLEEK","SLEEP","SLEET","SLEPT","SLEWS","SLICE","SLICK","SLIDE","SLIER","SLIME","SLIMS","SLIMY","SLING","SLINK","SLIPS","SLITS","SLOBS","SLOGS","SLOPE","SLOPS","SLOSH","SLOTH","SLOTS","SLOWS","SLUED","SLUGS","SLUMP","SLUMS","SLUNG","SLUNK","SLURP","SLURS","SLUSH","SLYER","SLYLY","SMACK","SMALL","SMARM","SMART","SMASH","SMEAR","SMELL","SMELT","SMILE","SMIRK","SMITE","SMITH","SMOCK","SMOKE","SMOKY","SMOTE","SMUTS","SNACK","SNAFU","SNAGS","SNAIL","SNAKE","SNAKY","SNAPS","SNARE","SNARL","SNEAK","SNEER","SNICK","SNIDE","SNIFF","SNIPE","SNIPS","SNITS","SNOBS","SNOOD","SNOOP","SNOOT","SNORE","SNORT","SNOTS","SNOUT","SNOWS","SNOWY","SNUBS","SNUCK","SNUFF","SOAKS","SOAPS","SOAPY","SOARS","SOAVE","SOBER","SOCKS","SODAS","SOFAS","SOFTY","SOGGY","SOILS","SOLAR","SOLED","SOLES","SOLID","SOLON","SOLOS","SOLVE","SONAR","SONGS","SONIC","SONNY","SOOTY","SOPPY","SORBS","SORER","SORES","SORRY","SORTS","SOUGH","SOUKS","SOULS","SOUND","SOUPS","SOUPY","SOURS","SOUSE","SOUTH","SOWED","SPACE","SPADE","SPANK","SPANS","SPARE","SPARK","SPARS","SPASM","SPATE","SPATS","SPAWN","SPAYS","SPEAK","SPEAR","SPECK","SPECS","SPEED","SPELL","SPELT","SPEND","SPENT","SPEWS","SPICE","SPICK","SPICY","SPIED","SPIEL","SPIES","SPIFF","SPIKE","SPIKY","SPILL","SPILT","SPINE","SPINS","SPINY","SPIRE","SPITE","SPITS","SPLAT","SPLAY","SPLIT","SPOIL","SPOKE","SPOOF","SPOOK","SPOOL","SPOON","SPOOR","SPORE","SPORT","SPOTS","SPOUT","SPRAT","SPRAY","SPREE","SPRIG","SPRIT","SPUDS","SPUME","SPUNK","SPURN","SPURS","SPURT","SPUTA","SQUAB","SQUAD","SQUAT","SQUAW","SQUIB","SQUID","STABS","STACK","STAFF","STAGE","STAGS","STAGY","STAID","STAIN","STAIR","STAKE","STALE","STALK","STALL","STAMP","STAND","STANK","STAPH","STARE","STARK","STARS","START","STASH","STATE","STATS","STAVE","STAYS","STEAD","STEAK","STEAL","STEAM","STEED","STEEL","STEEP","STEER","STEIN","STEMS","STENO","STENT","STEPS","STERN","STETS","STEWS","STICK","STIES","STIFF","STILE","STILL","STILT","STING","STINK","STINT","STIRS","STOAT","STOCK","STOGY","STOIC","STOKE","STOLE","STOMA","STOMP","STONE","STONY","STOOD","STOOL","STOOP","STOPS","STORE","STORK","STORM","STORY","STOUP","STOUT","STOVE","STOWS","STRAP","STRAW","STRAY","STREP","STREW","STRIP","STROP","STRUM","STRUT","STUBS","STUCK","STUDS","STUDY","STUFF","STUMP","STUNG","STUNK","STUNS","STUNT","STYLE","SUAVE","SUCKS","SUDSY","SUEDE","SUGAR","SUING","SUITE","SUITS","SULFA","SULKS","SULKY","SULLY","SUNNY","SUNUP","SUPER","SURER","SURFS","SURGE","SUSHI","SUTRA","SWABS","SWAGE","SWAGS","SWAIN","SWALE","SWAMI","SWAMP","SWANK","SWANS","SWAPS","SWARD","SWARM","SWART","SWASH","SWATH","SWATS","SWAYS","SWEAR","SWEAT","SWEEP","SWEET","SWELL","SWEPT","SWIFT","SWIGS","SWILL","SWIMS","SWINE","SWING","SWIPE","SWIRL","SWISH","SWOON","SWOOP","SWOPS","SWORD","SWORE","SWORN","SWUNG","SYLPH","SYNCH","SYNCS","SYNOD","SYRUP","SYSOP","TABBY","TABLE","TABOO","TABOR","TACIT","TACKS","TACKY","TACOS","TAFFY","TAIGA","TAILS","TAINT","TAKEN","TAKER","TAKES","TALES","TALKS","TALKY","TALLY","TALON","TALUS","TAMED","TAMER","TAMES","TAMPS","TANGO","TANGS","TANGY","TANKS","TANSY","TAPAS","TAPED","TAPER","TAPES","TAPIR","TARDY","TARES","TARNS","TAROS","TAROT","TARPS","TARRY","TARSI","TARTS","TASKS","TASTE","TASTY","TATER","TATTY","TAUNT","TAUPE","TAWNY","TAXED","TAXES","TAXIS","TEACH","TEAKS","TEALS","TEAMS","TEARS","TEARY","TEASE","TEATS","TECHS","TEDDY","TEEMS","TEENS","TEENY","TEETH","TELLS","TEMPI","TEMPO","TEMPS","TEMPT","TENDS","TENET","TENOR","TENSE","TENTH","TENTS","TEPID","TERMS","TERRA","TERRY","TERSE","TESTS","TESTY","TETRA","TEXTS","THANE","THANK","THAWS","THEBE","THECA","THEFT","THEIR","THEME","THERE","THESE","THETA","THICK","THIEF","THIGH","THING","THINK","THINS","THIRD","THONG","THORN","THORP","THOSE","THREE","THREW","THROB","THROE","THROW","THRUM","THUDS","THUGS","THUMB","THUMP","THYME","TIARA","TIBIA","TICKS","TIDAL","TIDED","TIDES","TIERS","TIFFS","TIGER","TIGHT","TIKES","TILDE","TILED","TILES","TILLS","TILTS","TIMED","TIMER","TIMES","TIMID","TINED","TINES","TINGE","TINGS","TINNY","TINTS","TIPPY","TIPSY","TIRED","TIRES","TITAN","TITER","TITHE","TITLE","TIZZY","TOADS","TOADY","TOAST","TODAY","TOGAS","TOILS","TOKAY","TOKEN","TOKES","TOLLS","TOMBS","TOMES","TONAL","TONED","TONER","TONES","TONGS","TONIC","TONUS","TOOLS","TOOTH","TOOTS","TOPAZ","TOPED","TOPER","TOPES","TOPIC","TOQUE","TORAH","TORCH","TORSI","TORSO","TORTE","TORTS","TORUS","TOTAL","TOTED","TOTEM","TOTES","TOUCH","TOUGH","TOURS","TOUTS","TOWED","TOWEL","TOWER","TOWNS","TOXIC","TOXIN","TOYED","TRACE","TRACK","TRACT","TRADE","TRAIL","TRAIN","TRAIT","TRAMP","TRAMS","TRANS","TRAPS","TRASH","TRAWL","TRAYS","TREAD","TREAT","TREED","TREES","TREKS","TREND","TRESS","TREYS","TRIAD","TRIAL","TRIBE","TRICE","TRICK","TRIED","TRIES","TRIGS","TRILL","TRIMS","TRINE","TRIOS","TRIPE","TRIPS","TRITE","TROLL","TROMP","TROOP","TROPE","TROTH","TROTS","TROUT","TROVE","TRUCE","TRUCK","TRUED","TRUER","TRULY","TRUMP","TRUNK","TRUSS","TRUST","TRUTH","TRYST","TSARS","TUBAL","TUBAS","TUBBY","TUBER","TUBES","TUCKS","TUFFS","TUFTS","TULIP","TULLE","TUMID","TUMMY","TUMOR","TUNAS","TUNED","TUNER","TUNES","TUNIC","TUQUE","TURBO","TURFS","TURNS","TUTEE","TUTOR","TUTUS","TUXES","TWAIN","TWANG","TWATS","TWEAK","TWEED","TWEET","TWERP","TWICE","TWIGS","TWILL","TWINE","TWINS","TWIRL","TWIST","TWITS","TWIXT","TYING","TYKES","TYPED","TYPES","TYPOS","TYROS","UDDER","ULCER","ULNAE","ULNAS","ULTRA","UMBEL","UMBER","UMBRA","UNAPT","UNARM","UNARY","UNBAN","UNBAR","UNCAP","UNCLE","UNCUT","UNDER","UNDID","UNDUE","UNFED","UNFIT","UNFIX","UNHIP","UNIFY","UNION","UNITE","UNITS","UNITY","UNLIT","UNMAN","UNMET","UNPIN","UNRIG","UNSAY","UNSET","UNSEX","UNTIE","UNTIL","UNWED","UNZIP","UPEND","UPPED","UPPER","UPSET","URBAN","UREIC","URGED","URGES","URINE","USAGE","USERS","USHER","USING","USUAL","USURP","USURY","UTERI","UTILE","UTTER","UVULA","VAGUE","VALES","VALET","VALID","VALOR","VALUE","VALVE","VAMPS","VAMPY","VANES","VAPID","VAPOR","VASES","VATIC","VAULT","VAUNT","VEERS","VEGAN","VEILS","VEINS","VELAR","VELDT","VELUM","VENAL","VENDS","VENIN","VENOM","VENTS","VENUE","VERBS","VERGE","VERSE","VERSO","VERVE","VESTS","VETCH","VEXED","VEXES","VIALS","VIAND","VIBES","VICAR","VICES","VIDEO","VIEWS","VIGIL","VIGOR","VILER","VILLA","VINES","VINYL","VIOLA","VIOLS","VIPER","VIRAL","VIREO","VIRUS","VISAS","VISES","VISIT","VISOR","VISTA","VITAE","VITAL","VIVID","VIXEN","VOCAL","VODKA","VOGUE","VOICE","VOIDS","VOILA","VOLES","VOLTE","VOLTS","VOMIT","VOTED","VOTER","VOTES","VOUCH","VOWED","VOWEL","VROOM","VYING","WACKY","WADED","WADER","WADES","WAFER","WAFTS","WAGED","WAGER","WAGES","WAGON","WAIFS","WAILS","WAIST","WAITS","WAIVE","WAKED","WAKEN","WAKES","WALKS","WALLS","WALTZ","WANDS","WANED","WANES","WANLY","WANTS","WARDS","WARES","WARMS","WARNS","WARPS","WARTS","WARTY","WASHY","WASPS","WASTE","WATCH","WATER","WATTS","WAVED","WAVER","WAVES","WAXED","WAXEN","WAXES","WEALD","WEANS","WEARS","WEARY","WEAVE","WEBBY","WEDGE","WEEDS","WEEDY","WEEKS","WEEPS","WEEPY","WEFTS","WEIGH","WEIRD","WEIRS","WELDS","WELLS","WELSH","WELTS","WENCH","WENDS","WETLY","WHACK","WHALE","WHAMS","WHAPS","WHARF","WHEAL","WHEAT","WHEEL","WHELK","WHELM","WHELP","WHERE","WHETS","WHICH","WHIFF","WHILE","WHIMS","WHINE","WHINY","WHIPS","WHIRL","WHIRR","WHIRS","WHISH","WHISK","WHIST","WHITE","WHIZZ","WHOLE","WHOOP","WHOPS","WHORE","WHORL","WHOSE","WHOSO","WICKS","WIDEN","WIDER","WIDOW","WIDTH","WIELD","WILDS","WILED","WILES","WILLS","WILTS","WIMPS","WIMPY","WINCE","WINCH","WINDS","WINDY","WINED","WINES","WINEY","WINGS","WINKS","WINOS","WINZE","WIPED","WIPER","WIPES","WIRED","WIRER","WIRES","WIRRA","WISED","WISER","WISES","WISPS","WISPY","WITAN","WITCH","WITHY","WITTY","WIVES","WIZEN","WODGE","WOKEN","WOLFS","WOMAN","WOMBS","WOMEN","WONKS","WONKY","WOODS","WOODY","WOOED","WOOER","WOOFS","WOOLS","WOOLY","WOOPS","WOOZY","WORDS","WORDY","WORKS","WORLD","WORMS","WORMY","WORRY","WORSE","WORST","WORTH","WOULD","WOUND","WOVEN","WOWED","WRACK","WRAPS","WRATH","WREAK","WRECK","WRENS","WREST","WRIER","WRING","WRIST","WRITE","WRITS","WRONG","WROTE","WROTH","WRUNG","WRYER","WRYLY","XEBEC","XENIA","XENON","XERIC","XYLEM","YAHOO","YANKS","YAPOK","YARDS","YARER","YARNS","YAWED","YAWLS","YAWNS","YAWPS","YEANS","YEARN","YEARS","YEAST","YECCH","YELPS","YENTA","YERBA","YESES","YETIS","YIELD","YIKES","YODEL","YOGHS","YOGIC","YOGIS","YOKED","YOKEL","YOKES","YOLKS","YOLKY","YOUNG","YOURS","YOUTH","YOWLS","YUCCA","YUCKY","YUMMY","YURTS","ZAMIA","ZAPPY","ZARFS","ZEBRA","ZEBUS","ZEROS","ZESTS","ZESTY","ZETAS","ZILCH","ZINCS","ZINGS","ZINGY","ZIPPY","ZONAL","ZONED","ZONES","ZOOMS" };
        private static List<string> words_list = new List<string>(words_array);
        private static Random rnd = new Random();
        private static int r = rnd.Next(words_list.Count);
        // Select secret word at random from words_list
        private static string secret_word = words_list[r];
        // Uncomment this line for testing purposes
        // Overwrites randomly selected word with "GUESS"
        //private string secret_word = "GUESS";
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.guess1_0 = new System.Windows.Forms.RichTextBox();
            this.guess1_1 = new System.Windows.Forms.RichTextBox();
            this.guess1_2 = new System.Windows.Forms.RichTextBox();
            this.guess1_3 = new System.Windows.Forms.RichTextBox();
            this.guess1_4 = new System.Windows.Forms.RichTextBox();
            this.guess2_4 = new System.Windows.Forms.RichTextBox();
            this.guess2_3 = new System.Windows.Forms.RichTextBox();
            this.guess2_2 = new System.Windows.Forms.RichTextBox();
            this.guess2_1 = new System.Windows.Forms.RichTextBox();
            this.guess2_0 = new System.Windows.Forms.RichTextBox();
            this.guess3_4 = new System.Windows.Forms.RichTextBox();
            this.guess3_3 = new System.Windows.Forms.RichTextBox();
            this.guess3_2 = new System.Windows.Forms.RichTextBox();
            this.guess3_1 = new System.Windows.Forms.RichTextBox();
            this.guess3_0 = new System.Windows.Forms.RichTextBox();
            this.guess4_4 = new System.Windows.Forms.RichTextBox();
            this.guess4_3 = new System.Windows.Forms.RichTextBox();
            this.guess4_2 = new System.Windows.Forms.RichTextBox();
            this.guess4_1 = new System.Windows.Forms.RichTextBox();
            this.guess4_0 = new System.Windows.Forms.RichTextBox();
            this.guess5_4 = new System.Windows.Forms.RichTextBox();
            this.guess5_3 = new System.Windows.Forms.RichTextBox();
            this.guess5_2 = new System.Windows.Forms.RichTextBox();
            this.guess5_1 = new System.Windows.Forms.RichTextBox();
            this.guess5_0 = new System.Windows.Forms.RichTextBox();
            this.guess6_4 = new System.Windows.Forms.RichTextBox();
            this.guess6_3 = new System.Windows.Forms.RichTextBox();
            this.guess6_2 = new System.Windows.Forms.RichTextBox();
            this.guess6_1 = new System.Windows.Forms.RichTextBox();
            this.guess6_0 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.alphaA = new System.Windows.Forms.Label();
            this.alphaB = new System.Windows.Forms.Label();
            this.alphaD = new System.Windows.Forms.Label();
            this.alphaC = new System.Windows.Forms.Label();
            this.alphaF = new System.Windows.Forms.Label();
            this.alphaE = new System.Windows.Forms.Label();
            this.alphaL = new System.Windows.Forms.Label();
            this.alphaK = new System.Windows.Forms.Label();
            this.alphaJ = new System.Windows.Forms.Label();
            this.alphaI = new System.Windows.Forms.Label();
            this.alphaH = new System.Windows.Forms.Label();
            this.alphaG = new System.Windows.Forms.Label();
            this.alphaT = new System.Windows.Forms.Label();
            this.alphaS = new System.Windows.Forms.Label();
            this.alphaR = new System.Windows.Forms.Label();
            this.alphaQ = new System.Windows.Forms.Label();
            this.alphaP = new System.Windows.Forms.Label();
            this.alphaO = new System.Windows.Forms.Label();
            this.alphaN = new System.Windows.Forms.Label();
            this.alphaM = new System.Windows.Forms.Label();
            this.alphaZ = new System.Windows.Forms.Label();
            this.alphaY = new System.Windows.Forms.Label();
            this.alphaX = new System.Windows.Forms.Label();
            this.alphaW = new System.Windows.Forms.Label();
            this.alphaV = new System.Windows.Forms.Label();
            this.alphaU = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guess1_0
            // 
            this.guess1_0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess1_0.DetectUrls = false;
            this.guess1_0.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess1_0.Location = new System.Drawing.Point(14, 12);
            this.guess1_0.MaxLength = 1;
            this.guess1_0.Multiline = false;
            this.guess1_0.Name = "guess1_0";
            this.guess1_0.Size = new System.Drawing.Size(81, 79);
            this.guess1_0.TabIndex = 0;
            this.guess1_0.Text = "";
            this.guess1_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess1_1
            // 
            this.guess1_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess1_1.DetectUrls = false;
            this.guess1_1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess1_1.Location = new System.Drawing.Point(101, 12);
            this.guess1_1.MaxLength = 1;
            this.guess1_1.Name = "guess1_1";
            this.guess1_1.Size = new System.Drawing.Size(81, 79);
            this.guess1_1.TabIndex = 1;
            this.guess1_1.Text = "";
            this.guess1_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess1_2
            // 
            this.guess1_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess1_2.DetectUrls = false;
            this.guess1_2.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess1_2.Location = new System.Drawing.Point(188, 12);
            this.guess1_2.MaxLength = 1;
            this.guess1_2.Name = "guess1_2";
            this.guess1_2.Size = new System.Drawing.Size(81, 79);
            this.guess1_2.TabIndex = 2;
            this.guess1_2.Text = "";
            this.guess1_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess1_3
            // 
            this.guess1_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess1_3.DetectUrls = false;
            this.guess1_3.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess1_3.Location = new System.Drawing.Point(275, 12);
            this.guess1_3.MaxLength = 1;
            this.guess1_3.Name = "guess1_3";
            this.guess1_3.Size = new System.Drawing.Size(81, 79);
            this.guess1_3.TabIndex = 3;
            this.guess1_3.Text = "";
            this.guess1_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess1_4
            // 
            this.guess1_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess1_4.DetectUrls = false;
            this.guess1_4.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess1_4.Location = new System.Drawing.Point(362, 12);
            this.guess1_4.MaxLength = 1;
            this.guess1_4.Name = "guess1_4";
            this.guess1_4.Size = new System.Drawing.Size(81, 79);
            this.guess1_4.TabIndex = 4;
            this.guess1_4.Text = "";
            this.guess1_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess2_4
            // 
            this.guess2_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess2_4.DetectUrls = false;
            this.guess2_4.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess2_4.Location = new System.Drawing.Point(362, 96);
            this.guess2_4.MaxLength = 1;
            this.guess2_4.Name = "guess2_4";
            this.guess2_4.Size = new System.Drawing.Size(81, 83);
            this.guess2_4.TabIndex = 9;
            this.guess2_4.Text = "";
            this.guess2_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess2_3
            // 
            this.guess2_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess2_3.DetectUrls = false;
            this.guess2_3.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess2_3.Location = new System.Drawing.Point(275, 96);
            this.guess2_3.MaxLength = 1;
            this.guess2_3.Name = "guess2_3";
            this.guess2_3.Size = new System.Drawing.Size(81, 83);
            this.guess2_3.TabIndex = 8;
            this.guess2_3.Text = "";
            this.guess2_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess2_2
            // 
            this.guess2_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess2_2.DetectUrls = false;
            this.guess2_2.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess2_2.Location = new System.Drawing.Point(188, 96);
            this.guess2_2.MaxLength = 1;
            this.guess2_2.Name = "guess2_2";
            this.guess2_2.Size = new System.Drawing.Size(81, 83);
            this.guess2_2.TabIndex = 7;
            this.guess2_2.Text = "";
            this.guess2_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess2_1
            // 
            this.guess2_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess2_1.DetectUrls = false;
            this.guess2_1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess2_1.Location = new System.Drawing.Point(101, 96);
            this.guess2_1.MaxLength = 1;
            this.guess2_1.Name = "guess2_1";
            this.guess2_1.Size = new System.Drawing.Size(81, 83);
            this.guess2_1.TabIndex = 6;
            this.guess2_1.Text = "";
            this.guess2_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess2_0
            // 
            this.guess2_0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess2_0.DetectUrls = false;
            this.guess2_0.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess2_0.Location = new System.Drawing.Point(14, 96);
            this.guess2_0.MaxLength = 1;
            this.guess2_0.Name = "guess2_0";
            this.guess2_0.Size = new System.Drawing.Size(81, 83);
            this.guess2_0.TabIndex = 5;
            this.guess2_0.Text = "";
            this.guess2_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess3_4
            // 
            this.guess3_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess3_4.DetectUrls = false;
            this.guess3_4.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess3_4.Location = new System.Drawing.Point(362, 181);
            this.guess3_4.MaxLength = 1;
            this.guess3_4.Name = "guess3_4";
            this.guess3_4.Size = new System.Drawing.Size(81, 83);
            this.guess3_4.TabIndex = 14;
            this.guess3_4.Text = "";
            this.guess3_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess3_3
            // 
            this.guess3_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess3_3.DetectUrls = false;
            this.guess3_3.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess3_3.Location = new System.Drawing.Point(275, 181);
            this.guess3_3.MaxLength = 1;
            this.guess3_3.Name = "guess3_3";
            this.guess3_3.Size = new System.Drawing.Size(81, 83);
            this.guess3_3.TabIndex = 13;
            this.guess3_3.Text = "";
            this.guess3_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess3_2
            // 
            this.guess3_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess3_2.DetectUrls = false;
            this.guess3_2.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess3_2.Location = new System.Drawing.Point(188, 181);
            this.guess3_2.MaxLength = 1;
            this.guess3_2.Name = "guess3_2";
            this.guess3_2.Size = new System.Drawing.Size(81, 83);
            this.guess3_2.TabIndex = 12;
            this.guess3_2.Text = "";
            this.guess3_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess3_1
            // 
            this.guess3_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess3_1.DetectUrls = false;
            this.guess3_1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess3_1.Location = new System.Drawing.Point(101, 181);
            this.guess3_1.MaxLength = 1;
            this.guess3_1.Name = "guess3_1";
            this.guess3_1.Size = new System.Drawing.Size(81, 83);
            this.guess3_1.TabIndex = 11;
            this.guess3_1.Text = "";
            this.guess3_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess3_0
            // 
            this.guess3_0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess3_0.DetectUrls = false;
            this.guess3_0.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess3_0.Location = new System.Drawing.Point(14, 181);
            this.guess3_0.MaxLength = 1;
            this.guess3_0.Name = "guess3_0";
            this.guess3_0.Size = new System.Drawing.Size(81, 83);
            this.guess3_0.TabIndex = 10;
            this.guess3_0.Text = "";
            this.guess3_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess4_4
            // 
            this.guess4_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess4_4.DetectUrls = false;
            this.guess4_4.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess4_4.Location = new System.Drawing.Point(362, 266);
            this.guess4_4.MaxLength = 1;
            this.guess4_4.Name = "guess4_4";
            this.guess4_4.Size = new System.Drawing.Size(81, 83);
            this.guess4_4.TabIndex = 19;
            this.guess4_4.Text = "";
            this.guess4_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess4_3
            // 
            this.guess4_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess4_3.DetectUrls = false;
            this.guess4_3.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess4_3.Location = new System.Drawing.Point(275, 266);
            this.guess4_3.MaxLength = 1;
            this.guess4_3.Name = "guess4_3";
            this.guess4_3.Size = new System.Drawing.Size(81, 83);
            this.guess4_3.TabIndex = 18;
            this.guess4_3.Text = "";
            this.guess4_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess4_2
            // 
            this.guess4_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess4_2.DetectUrls = false;
            this.guess4_2.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess4_2.Location = new System.Drawing.Point(188, 266);
            this.guess4_2.MaxLength = 1;
            this.guess4_2.Name = "guess4_2";
            this.guess4_2.Size = new System.Drawing.Size(81, 83);
            this.guess4_2.TabIndex = 17;
            this.guess4_2.Text = "";
            this.guess4_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess4_1
            // 
            this.guess4_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess4_1.DetectUrls = false;
            this.guess4_1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess4_1.Location = new System.Drawing.Point(101, 266);
            this.guess4_1.MaxLength = 1;
            this.guess4_1.Name = "guess4_1";
            this.guess4_1.Size = new System.Drawing.Size(81, 83);
            this.guess4_1.TabIndex = 16;
            this.guess4_1.Text = "";
            this.guess4_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess4_0
            // 
            this.guess4_0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess4_0.DetectUrls = false;
            this.guess4_0.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess4_0.Location = new System.Drawing.Point(14, 266);
            this.guess4_0.MaxLength = 1;
            this.guess4_0.Name = "guess4_0";
            this.guess4_0.Size = new System.Drawing.Size(81, 83);
            this.guess4_0.TabIndex = 15;
            this.guess4_0.Text = "";
            this.guess4_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess5_4
            // 
            this.guess5_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess5_4.DetectUrls = false;
            this.guess5_4.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess5_4.Location = new System.Drawing.Point(362, 351);
            this.guess5_4.MaxLength = 1;
            this.guess5_4.Name = "guess5_4";
            this.guess5_4.Size = new System.Drawing.Size(81, 83);
            this.guess5_4.TabIndex = 24;
            this.guess5_4.Text = "";
            this.guess5_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess5_3
            // 
            this.guess5_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess5_3.DetectUrls = false;
            this.guess5_3.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess5_3.Location = new System.Drawing.Point(275, 351);
            this.guess5_3.MaxLength = 1;
            this.guess5_3.Name = "guess5_3";
            this.guess5_3.Size = new System.Drawing.Size(81, 83);
            this.guess5_3.TabIndex = 23;
            this.guess5_3.Text = "";
            this.guess5_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess5_2
            // 
            this.guess5_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess5_2.DetectUrls = false;
            this.guess5_2.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess5_2.Location = new System.Drawing.Point(188, 351);
            this.guess5_2.MaxLength = 1;
            this.guess5_2.Name = "guess5_2";
            this.guess5_2.Size = new System.Drawing.Size(81, 83);
            this.guess5_2.TabIndex = 22;
            this.guess5_2.Text = "";
            this.guess5_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess5_1
            // 
            this.guess5_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess5_1.DetectUrls = false;
            this.guess5_1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess5_1.Location = new System.Drawing.Point(101, 351);
            this.guess5_1.MaxLength = 1;
            this.guess5_1.Name = "guess5_1";
            this.guess5_1.Size = new System.Drawing.Size(81, 83);
            this.guess5_1.TabIndex = 21;
            this.guess5_1.Text = "";
            this.guess5_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess5_0
            // 
            this.guess5_0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess5_0.DetectUrls = false;
            this.guess5_0.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess5_0.Location = new System.Drawing.Point(14, 351);
            this.guess5_0.MaxLength = 1;
            this.guess5_0.Name = "guess5_0";
            this.guess5_0.Size = new System.Drawing.Size(81, 83);
            this.guess5_0.TabIndex = 20;
            this.guess5_0.Text = "";
            this.guess5_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess6_4
            // 
            this.guess6_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess6_4.DetectUrls = false;
            this.guess6_4.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess6_4.Location = new System.Drawing.Point(362, 440);
            this.guess6_4.MaxLength = 1;
            this.guess6_4.Name = "guess6_4";
            this.guess6_4.Size = new System.Drawing.Size(81, 79);
            this.guess6_4.TabIndex = 29;
            this.guess6_4.Text = "";
            this.guess6_4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess6_3
            // 
            this.guess6_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess6_3.DetectUrls = false;
            this.guess6_3.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess6_3.Location = new System.Drawing.Point(275, 440);
            this.guess6_3.MaxLength = 1;
            this.guess6_3.Name = "guess6_3";
            this.guess6_3.Size = new System.Drawing.Size(81, 79);
            this.guess6_3.TabIndex = 28;
            this.guess6_3.Text = "";
            this.guess6_3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess6_2
            // 
            this.guess6_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess6_2.DetectUrls = false;
            this.guess6_2.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess6_2.Location = new System.Drawing.Point(188, 440);
            this.guess6_2.MaxLength = 1;
            this.guess6_2.Name = "guess6_2";
            this.guess6_2.Size = new System.Drawing.Size(81, 79);
            this.guess6_2.TabIndex = 27;
            this.guess6_2.Text = "";
            this.guess6_2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess6_1
            // 
            this.guess6_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess6_1.DetectUrls = false;
            this.guess6_1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess6_1.Location = new System.Drawing.Point(101, 440);
            this.guess6_1.MaxLength = 1;
            this.guess6_1.Name = "guess6_1";
            this.guess6_1.Size = new System.Drawing.Size(81, 79);
            this.guess6_1.TabIndex = 26;
            this.guess6_1.Text = "";
            this.guess6_1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // guess6_0
            // 
            this.guess6_0.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guess6_0.DetectUrls = false;
            this.guess6_0.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess6_0.Location = new System.Drawing.Point(14, 440);
            this.guess6_0.MaxLength = 1;
            this.guess6_0.Name = "guess6_0";
            this.guess6_0.Size = new System.Drawing.Size(81, 79);
            this.guess6_0.TabIndex = 25;
            this.guess6_0.Text = "";
            this.guess6_0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Guess_KeyPress);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(115, 686);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(239, 82);
            this.button1.TabIndex = 30;
            this.button1.Text = "Submit guess";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // alphaA
            // 
            this.alphaA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaA.Location = new System.Drawing.Point(40, 532);
            this.alphaA.Name = "alphaA";
            this.alphaA.Size = new System.Drawing.Size(36, 36);
            this.alphaA.TabIndex = 31;
            this.alphaA.Text = "A";
            this.alphaA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaB
            // 
            this.alphaB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaB.Location = new System.Drawing.Point(78, 532);
            this.alphaB.Name = "alphaB";
            this.alphaB.Size = new System.Drawing.Size(36, 36);
            this.alphaB.TabIndex = 32;
            this.alphaB.Text = "B";
            this.alphaB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaD
            // 
            this.alphaD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaD.Location = new System.Drawing.Point(154, 532);
            this.alphaD.Name = "alphaD";
            this.alphaD.Size = new System.Drawing.Size(36, 36);
            this.alphaD.TabIndex = 34;
            this.alphaD.Text = "D";
            this.alphaD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaC
            // 
            this.alphaC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaC.Location = new System.Drawing.Point(116, 532);
            this.alphaC.Name = "alphaC";
            this.alphaC.Size = new System.Drawing.Size(36, 36);
            this.alphaC.TabIndex = 33;
            this.alphaC.Text = "C";
            this.alphaC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaF
            // 
            this.alphaF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaF.Location = new System.Drawing.Point(230, 532);
            this.alphaF.Name = "alphaF";
            this.alphaF.Size = new System.Drawing.Size(36, 36);
            this.alphaF.TabIndex = 36;
            this.alphaF.Text = "F";
            this.alphaF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaE
            // 
            this.alphaE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaE.Location = new System.Drawing.Point(192, 532);
            this.alphaE.Name = "alphaE";
            this.alphaE.Size = new System.Drawing.Size(36, 36);
            this.alphaE.TabIndex = 35;
            this.alphaE.Text = "E";
            this.alphaE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaL
            // 
            this.alphaL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaL.Location = new System.Drawing.Point(78, 577);
            this.alphaL.Name = "alphaL";
            this.alphaL.Size = new System.Drawing.Size(36, 36);
            this.alphaL.TabIndex = 42;
            this.alphaL.Text = "L";
            this.alphaL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaK
            // 
            this.alphaK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaK.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaK.Location = new System.Drawing.Point(40, 577);
            this.alphaK.Name = "alphaK";
            this.alphaK.Size = new System.Drawing.Size(36, 36);
            this.alphaK.TabIndex = 41;
            this.alphaK.Text = "K";
            this.alphaK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaJ
            // 
            this.alphaJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaJ.Location = new System.Drawing.Point(382, 532);
            this.alphaJ.Name = "alphaJ";
            this.alphaJ.Size = new System.Drawing.Size(36, 36);
            this.alphaJ.TabIndex = 40;
            this.alphaJ.Text = "J";
            this.alphaJ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaI
            // 
            this.alphaI.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaI.Location = new System.Drawing.Point(344, 532);
            this.alphaI.Name = "alphaI";
            this.alphaI.Size = new System.Drawing.Size(36, 36);
            this.alphaI.TabIndex = 39;
            this.alphaI.Text = "I";
            this.alphaI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaH
            // 
            this.alphaH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaH.Location = new System.Drawing.Point(306, 532);
            this.alphaH.Name = "alphaH";
            this.alphaH.Size = new System.Drawing.Size(36, 36);
            this.alphaH.TabIndex = 38;
            this.alphaH.Text = "H";
            this.alphaH.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaG
            // 
            this.alphaG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaG.Location = new System.Drawing.Point(268, 532);
            this.alphaG.Name = "alphaG";
            this.alphaG.Size = new System.Drawing.Size(36, 36);
            this.alphaG.TabIndex = 37;
            this.alphaG.Text = "G";
            this.alphaG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaT
            // 
            this.alphaT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaT.Location = new System.Drawing.Point(382, 577);
            this.alphaT.Name = "alphaT";
            this.alphaT.Size = new System.Drawing.Size(36, 36);
            this.alphaT.TabIndex = 50;
            this.alphaT.Text = "T";
            this.alphaT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaS
            // 
            this.alphaS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaS.Location = new System.Drawing.Point(344, 577);
            this.alphaS.Name = "alphaS";
            this.alphaS.Size = new System.Drawing.Size(36, 36);
            this.alphaS.TabIndex = 49;
            this.alphaS.Text = "S";
            this.alphaS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaR
            // 
            this.alphaR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaR.Location = new System.Drawing.Point(306, 577);
            this.alphaR.Name = "alphaR";
            this.alphaR.Size = new System.Drawing.Size(36, 36);
            this.alphaR.TabIndex = 48;
            this.alphaR.Text = "R";
            this.alphaR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaQ
            // 
            this.alphaQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaQ.Location = new System.Drawing.Point(268, 577);
            this.alphaQ.Name = "alphaQ";
            this.alphaQ.Size = new System.Drawing.Size(36, 36);
            this.alphaQ.TabIndex = 47;
            this.alphaQ.Text = "Q";
            this.alphaQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaP
            // 
            this.alphaP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaP.Location = new System.Drawing.Point(230, 577);
            this.alphaP.Name = "alphaP";
            this.alphaP.Size = new System.Drawing.Size(36, 36);
            this.alphaP.TabIndex = 46;
            this.alphaP.Text = "P";
            this.alphaP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaO
            // 
            this.alphaO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaO.Location = new System.Drawing.Point(192, 577);
            this.alphaO.Name = "alphaO";
            this.alphaO.Size = new System.Drawing.Size(36, 36);
            this.alphaO.TabIndex = 45;
            this.alphaO.Text = "O";
            this.alphaO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaN
            // 
            this.alphaN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaN.Location = new System.Drawing.Point(154, 577);
            this.alphaN.Name = "alphaN";
            this.alphaN.Size = new System.Drawing.Size(36, 36);
            this.alphaN.TabIndex = 44;
            this.alphaN.Text = "N";
            this.alphaN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaM
            // 
            this.alphaM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaM.Location = new System.Drawing.Point(116, 577);
            this.alphaM.Name = "alphaM";
            this.alphaM.Size = new System.Drawing.Size(36, 36);
            this.alphaM.TabIndex = 43;
            this.alphaM.Text = "M";
            this.alphaM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaZ
            // 
            this.alphaZ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaZ.Location = new System.Drawing.Point(317, 624);
            this.alphaZ.Name = "alphaZ";
            this.alphaZ.Size = new System.Drawing.Size(36, 36);
            this.alphaZ.TabIndex = 56;
            this.alphaZ.Text = "Z";
            this.alphaZ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaY
            // 
            this.alphaY.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaY.Location = new System.Drawing.Point(274, 624);
            this.alphaY.Name = "alphaY";
            this.alphaY.Size = new System.Drawing.Size(36, 36);
            this.alphaY.TabIndex = 55;
            this.alphaY.Text = "Y";
            this.alphaY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaX
            // 
            this.alphaX.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaX.Location = new System.Drawing.Point(231, 624);
            this.alphaX.Name = "alphaX";
            this.alphaX.Size = new System.Drawing.Size(36, 36);
            this.alphaX.TabIndex = 54;
            this.alphaX.Text = "X";
            this.alphaX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaW
            // 
            this.alphaW.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaW.Location = new System.Drawing.Point(188, 624);
            this.alphaW.Name = "alphaW";
            this.alphaW.Size = new System.Drawing.Size(36, 36);
            this.alphaW.TabIndex = 53;
            this.alphaW.Text = "W";
            this.alphaW.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaV
            // 
            this.alphaV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaV.Location = new System.Drawing.Point(145, 624);
            this.alphaV.Name = "alphaV";
            this.alphaV.Size = new System.Drawing.Size(36, 36);
            this.alphaV.TabIndex = 52;
            this.alphaV.Text = "V";
            this.alphaV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alphaU
            // 
            this.alphaU.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.alphaU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alphaU.Location = new System.Drawing.Point(102, 624);
            this.alphaU.Name = "alphaU";
            this.alphaU.Size = new System.Drawing.Size(36, 36);
            this.alphaU.TabIndex = 51;
            this.alphaU.Text = "U";
            this.alphaU.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 826);
            this.Controls.Add(this.alphaZ);
            this.Controls.Add(this.alphaY);
            this.Controls.Add(this.alphaX);
            this.Controls.Add(this.alphaW);
            this.Controls.Add(this.alphaV);
            this.Controls.Add(this.alphaU);
            this.Controls.Add(this.alphaT);
            this.Controls.Add(this.alphaS);
            this.Controls.Add(this.alphaR);
            this.Controls.Add(this.alphaQ);
            this.Controls.Add(this.alphaP);
            this.Controls.Add(this.alphaO);
            this.Controls.Add(this.alphaN);
            this.Controls.Add(this.alphaM);
            this.Controls.Add(this.alphaL);
            this.Controls.Add(this.alphaK);
            this.Controls.Add(this.alphaJ);
            this.Controls.Add(this.alphaI);
            this.Controls.Add(this.alphaH);
            this.Controls.Add(this.alphaG);
            this.Controls.Add(this.alphaF);
            this.Controls.Add(this.alphaE);
            this.Controls.Add(this.alphaD);
            this.Controls.Add(this.alphaC);
            this.Controls.Add(this.alphaB);
            this.Controls.Add(this.alphaA);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.guess6_4);
            this.Controls.Add(this.guess6_3);
            this.Controls.Add(this.guess6_2);
            this.Controls.Add(this.guess6_1);
            this.Controls.Add(this.guess6_0);
            this.Controls.Add(this.guess5_4);
            this.Controls.Add(this.guess5_3);
            this.Controls.Add(this.guess5_2);
            this.Controls.Add(this.guess5_1);
            this.Controls.Add(this.guess5_0);
            this.Controls.Add(this.guess4_4);
            this.Controls.Add(this.guess4_3);
            this.Controls.Add(this.guess4_2);
            this.Controls.Add(this.guess4_1);
            this.Controls.Add(this.guess4_0);
            this.Controls.Add(this.guess3_4);
            this.Controls.Add(this.guess3_3);
            this.Controls.Add(this.guess3_2);
            this.Controls.Add(this.guess3_1);
            this.Controls.Add(this.guess3_0);
            this.Controls.Add(this.guess2_4);
            this.Controls.Add(this.guess2_3);
            this.Controls.Add(this.guess2_2);
            this.Controls.Add(this.guess2_1);
            this.Controls.Add(this.guess2_0);
            this.Controls.Add(this.guess1_4);
            this.Controls.Add(this.guess1_3);
            this.Controls.Add(this.guess1_2);
            this.Controls.Add(this.guess1_1);
            this.Controls.Add(this.guess1_0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Guess the Word";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox guess1_0;
        private System.Windows.Forms.RichTextBox guess1_1;
        private System.Windows.Forms.RichTextBox guess1_2;
        private System.Windows.Forms.RichTextBox guess1_3;
        private System.Windows.Forms.RichTextBox guess1_4;
        private System.Windows.Forms.RichTextBox guess2_4;
        private System.Windows.Forms.RichTextBox guess2_3;
        private System.Windows.Forms.RichTextBox guess2_2;
        private System.Windows.Forms.RichTextBox guess2_1;
        private System.Windows.Forms.RichTextBox guess2_0;
        private System.Windows.Forms.RichTextBox guess3_4;
        private System.Windows.Forms.RichTextBox guess3_3;
        private System.Windows.Forms.RichTextBox guess3_2;
        private System.Windows.Forms.RichTextBox guess3_1;
        private System.Windows.Forms.RichTextBox guess3_0;
        private System.Windows.Forms.RichTextBox guess4_4;
        private System.Windows.Forms.RichTextBox guess4_3;
        private System.Windows.Forms.RichTextBox guess4_2;
        private System.Windows.Forms.RichTextBox guess4_1;
        private System.Windows.Forms.RichTextBox guess4_0;
        private System.Windows.Forms.RichTextBox guess5_4;
        private System.Windows.Forms.RichTextBox guess5_3;
        private System.Windows.Forms.RichTextBox guess5_2;
        private System.Windows.Forms.RichTextBox guess5_1;
        private System.Windows.Forms.RichTextBox guess5_0;
        private System.Windows.Forms.RichTextBox guess6_4;
        private System.Windows.Forms.RichTextBox guess6_3;
        private System.Windows.Forms.RichTextBox guess6_2;
        private System.Windows.Forms.RichTextBox guess6_1;
        private System.Windows.Forms.RichTextBox guess6_0;
        private Button button1;
        private Label alphaA;
        private Label alphaB;
        private Label alphaD;
        private Label alphaC;
        private Label alphaF;
        private Label alphaE;
        private Label alphaL;
        private Label alphaK;
        private Label alphaJ;
        private Label alphaI;
        private Label alphaH;
        private Label alphaG;
        private Label alphaT;
        private Label alphaS;
        private Label alphaR;
        private Label alphaQ;
        private Label alphaP;
        private Label alphaO;
        private Label alphaN;
        private Label alphaM;
        private Label alphaZ;
        private Label alphaY;
        private Label alphaX;
        private Label alphaW;
        private Label alphaV;
        private Label alphaU;
        private RichTextBox[] guess1_letter_list;
        private RichTextBox[] guess2_letter_list;
        private RichTextBox[] guess3_letter_list;
        private RichTextBox[] guess4_letter_list;
        private RichTextBox[] guess5_letter_list;
        private RichTextBox[] guess6_letter_list;
        private Label[] alphabet;
    }
}

