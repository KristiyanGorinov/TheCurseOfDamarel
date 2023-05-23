namespace TheCurseOfDamarel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //character stats
            int hp = 0;
            int dmg = 0;
            int atsp = 0;
            int def = 0;
            string CharacterClass = "";
            //paths
            bool gora = false;
            bool polq = false;
            //wolves stats
            int wolvehp = 275;
            int wolvedmg = 25;
            int wolveatsp = 30;
            int wolvedef = 0;
            //bear stats
            int bearhp = 500;
            int beardmg = 50;
            int bearatsp = 5;
            int beardef = 5;
            //gromp stats
            int gromphp = 375;
            int grompdmg = 65;
            int grompatsp = 5;
            int grompdef = 10;
            //slime stats
            int slimehp = 200;
            int slimedmg = 35;
            int slimeatsp = 35;
            int slimedef = 1;
            //fungi stats
            int fungihp = 250;
            int fungidmg = 40;
            int fungiatsp = 15;
            int fungidef = 0;
            //earthgolem stats
            int earthgolemhp = 675;
            int earthgolemdmg = 45;
            int earthgolematsp = 0;
            int earthgolemdef = 5;
            //Baubaustats
            int baubauhp = 1000;
            int baubaudmg = 60;
            int baubaudatsp = 80;
            int baubauddef = 0;
            //BlobGlobstats
            int blobglobhp = 1500;
            int blobglobdmg = 45;
            int blobglobatsp = 10;
            int blobglobdef = 10;


            GameStart();
            Console.ReadKey();
            Console.Clear();
            CharacterSelect();
            Console.ReadKey();
            Console.Clear();
            ChooseClass(ref CharacterClass, ref hp, ref atsp, ref def);
            int currenthp = hp;

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(CharacterClass);
            StarterWeaponBox(CharacterClass, ref dmg);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine($"Tvoite statove sa:");
            Console.WriteLine("");
            Console.WriteLine($"HIT POINTS: {hp}");
            Console.WriteLine($"ATTACK SPEED: {atsp} ");
            Console.WriteLine($"DEFENSE: {def}");
            Console.WriteLine($"DAMAGE: {dmg}");
            Console.WriteLine("");
            Console.WriteLine("Press any button to continue");
            Console.ReadKey();
            Console.Clear();




            PathSelect(ref gora, ref polq);
            //koda za patana gorata
            if (gora == true || polq == true)
            {
                Console.WriteLine("Press any button to start your adventure");
                Console.ReadKey();
                Console.Clear();
                Forest(gora, polq, ref atsp, wolveatsp, ref currenthp, ref dmg, ref def, wolvedmg, wolvehp, wolvedef, slimehp, slimedef, slimeatsp, slimedmg, bearatsp, beardmg, bearhp, beardef, fungiatsp, fungidmg, fungihp, fungidef, grompatsp, grompdmg, gromphp, grompdef, earthgolematsp, earthgolemdmg, earthgolemdef, earthgolemhp, hp);
            }


            if (gora == true)
            {
                Baubau(baubauhp, baubaudmg, baubaudatsp, baubauddef, ref currenthp, ref dmg, ref atsp, ref def,hp);
            }
            else if (polq)
            {
                BlobGlob(blobglobhp, blobglobdmg, blobglobatsp, blobglobdef, ref currenthp, ref dmg, ref atsp, ref def,hp);

            }

            Console.Clear();
            Console.WriteLine(" _____ _                 _           __                    _             _             ");
            Console.WriteLine("/__   \\ |__   __ _ _ __ | | _____   / _| ___  _ __   _ __ | | __ _ _   _(_)_ __   __ _ ");
            Console.WriteLine("  / /\\/ '_ \\ / _` | '_ \\| |/ / __| | |_ / _ \\| '__| | '_ \\| |/ _` | | | | | '_ \\ / _` |");
            Console.WriteLine(" / /  | | | | (_| | | | |   <\\__ \\ |  _| (_) | |    | |_) | | (_| | |_| | | | | | (_| |");
            Console.WriteLine(" \\/   |_| |_|\\__,_|_| |_|_|\\_\\___/ |_|  \\___/|_|    | .__/|_|\\__,_|\\__, |_|_| |_|\\__, |");
            Console.WriteLine("                                                    |_|            |___/         |___/ ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Credits:            Made by:");
            Console.WriteLine("             Kristiyan and Kristiyan ");
            /*
 
            //koda za pata na polqta
            else if (polq == true)
            {
                Console.WriteLine("Press any button to start your adventure");
                Console.ReadKey();
                Console.Clear();
                Planes(gora, polq);
            }
 
            */

        }

        static void GameStart()
        {
            Console.WriteLine(" __      _____________.____   _________  ________      _____  ___________");
            Console.WriteLine("/  \\    /  \\_   _____/|    |  \\_   ___ \\ \\_____  \\    /     \\ \\_   _____/");
            Console.WriteLine("\\   \\/\\/   /|    __)_ |    |  /    \\  \\/  /   |   \\  /  \\ /  \\ |    __)_  ");
            Console.WriteLine(" \\        / |        \\|    |__\\     \\____/    |    \\/    Y    \\|        \\ ");
            Console.WriteLine("  \\__/\\  / /_______  /|_______ \\______  /\\_______  /\\____|__  /_______  / ");
            Console.WriteLine("       \\/          \\/         \\/      \\/         \\/         \\/        \\/");
            Console.WriteLine("               .___                    __                                 ");
            Console.WriteLine("   _____     __| _/__  __ ____   _____/  |_ __ _________   ___________    ");
            Console.WriteLine("   \\__  \\   / __ |\\  \\/ // __ \\ /    \\   __\\  |  \\_  __ \\_/ __ \\_  __ \\   ");
            Console.WriteLine("    / __ \\_/ /_/ | \\   /\\  ___/|   |  \\  | |  |  /|  | \\/\\  ___/|  | \\/   ");
            Console.WriteLine("   (____  /\\____ |  \\_/  \\___  >___|  /__| |____/ |__|    \\___  >__|      ");
            Console.WriteLine("        \\/      \\/           \\/     \\/                        \\/          ");
        }

        static void MaleC()
        {

        }

        static void FemaleC()
        {

        }
        static void CharacterSelect()
        {
            Console.WriteLine("Molq predi da zapochnete izberete pol natiskaiki {m} za male i {f} za female");
            while (true)
            {
                string pol = Console.ReadLine();
                if (pol == "m")
                {
                    Console.WriteLine("ti veche si muj");
                    MaleC();
                    break;
                }
                else if (pol == "f")
                {
                    Console.WriteLine("ti veche si jena");
                    FemaleC();
                    break;
                }
                else
                {
                    Console.WriteLine("ti si 2pac kazahme m ili f, OPITAI PAK KRETEN TAKUV");
                    continue;
                }
            }

            Console.WriteLine("Press any button to continue");

        }

        /*
.----------------.  .----------------.  .----------------.  .----------------.  .----------------.
| .--------------. || .--------------. || .--------------. || .--------------. || .--------------. |
| |     __       | || |    _____     | || |    ______    | || |   _    _     | || |   _______    | |
| |    /  |      | || |   / ___ `.   | || |   / ____ `.  | || |  | |  | |    | || |  |  _____|   | |
| |    `| |      | || |  |_/___) |   | || |   `'  __) |  | || |  | |__| |_   | || |  | |____     | |
| |     | |      | || |   .'____.'   | || |   _  |__ '.  | || |  |____   _|  | || |  '_.____''.  | |
| |    _| |_     | || |  / /____     | || |  | \____) |  | || |      _| |_   | || |  | \____) |  | |
| |   |_____|    | || |  |_______|   | || |   \______.'  | || |     |_____|  | || |   \______.'  | |
| |              | || |              | || |              | || |              | || |              | |
| '--------------' || '--------------' || '--------------' || '--------------' || '--------------' |
 '----------------'  '----------------'  '----------------'  '----------------'  '----------------'
         * 
         * */











        static string ChooseClass(ref string CharacterClass, ref int hp, ref int atsp, ref int def)
        {
            Console.WriteLine("Sega e vreme da si izberesh klasa");
            Console.WriteLine("");
            Console.WriteLine("      Swordsman            Archer             Berserker          Lumberjack           Spearman");
            Console.WriteLine(" .----------------.  .----------------.  .----------------.  .----------------.  .----------------.");
            Console.WriteLine("| .--------------. || .--------------. || .--------------. || .--------------. || .--------------. |");
            Console.WriteLine("| |     __       | || |    _____     | || |    ______    | || |   _    _     | || |   _______    | |");
            Console.WriteLine("| |    /  |      | || |   / ___ `.   | || |   / ____ `.  | || |  | |  | |    | || |  |  _____|   | |");
            Console.WriteLine("| |    `| |      | || |  |_/___) |   | || |   `'  __) |  | || |  | |__| |_   | || |  | |____     | |");
            Console.WriteLine("| |     | |      | || |   .'____.'   | || |   _  |__ '.  | || |  |____   _|  | || |  '_.____''.  | |");
            Console.WriteLine("| |    _| |_     | || |  / /____     | || |  | \\____) |  | || |      _| |_   | || |  | \\____) |  | |");
            Console.WriteLine("| |   |_____|    | || |  |_______|   | || |   \\______.'  | || |     |_____|  | || |   \\______.'  | |");
            Console.WriteLine("| |              | || |              | || |              | || |              | || |              | |");
            Console.WriteLine("| '--------------' || '--------------' || '--------------' || '--------------' || '--------------' |");
            Console.WriteLine("'----------------'  '----------------'  '----------------'  '----------------'  '----------------'");
            Console.WriteLine("   hp = 500            hp = 375            hp = 825            hp = 475            hp = 625");
            Console.WriteLine("   atsp = 50           atsp = 100          atsp = 0            atsp = 75           atsp = 80");
            Console.WriteLine("   def = 20            def = 20            def = 5             def = 15            def = 15");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" Napishi chislo ot 1 do 5 za da izberesh klasa si");
            Console.WriteLine("1 = Swordsman");
            Console.WriteLine("2 = Archer");
            Console.WriteLine("3 = Berserker");
            Console.WriteLine("4 = Lumberjack");
            Console.WriteLine("5 = Spearman");
            while (true)
            {


                string chislozaizbiranenaklas = Console.ReadLine();
                if (chislozaizbiranenaklas == "1")
                {
                    CharacterClass = "Swordsman";
                    hp = 500;
                    atsp = 50;
                    def = 20;
                    break;

                }
                else if (chislozaizbiranenaklas == "2")
                {
                    CharacterClass = "Archer";
                    hp = 375;
                    atsp = 100;
                    def = 20;
                    break;

                }
                else if (chislozaizbiranenaklas == "3")
                {
                    CharacterClass = "Berserker";
                    hp = 825;
                    atsp = 0;
                    def = 5;
                    break;
                }
                else if (chislozaizbiranenaklas == "4")
                {
                    CharacterClass = "Lumberjack";
                    hp = 475;
                    atsp = 75;
                    def = 15;
                    break;
                }
                else if (chislozaizbiranenaklas == "5")
                {
                    CharacterClass = "Spearman";
                    hp = 625;
                    atsp = 80;
                    def = 15;
                    break;
                }
                else
                {
                    Console.WriteLine("ti si 2pac, opitai pak karakonjul");
                    continue;
                }
            }
            Console.WriteLine($"Tvoqt klas e {CharacterClass}, sega e vreme za tvoeto orujie");
            Console.WriteLine("Press any button to continue");
            return CharacterClass;

        }



        static void StarterWeaponBox(string CharacterClass, ref int dmg)
        {
            Random rand = new Random();
            Console.WriteLine("Sega e vreme da vidim kakvo orujie shte poluchite");
            Console.WriteLine("Press any key to open");
            Console.ReadKey();
            //common
            if (rand.Next(0, 100) <= 40)
            {
                if (CharacterClass == "Swordsman")
                {
                    Console.WriteLine("Poluchi common mech");
                    Sword1(ref dmg);
                }
                if (CharacterClass == "Archer")
                {
                    Console.WriteLine("Poluchi common luk");
                    Bow1(ref dmg);
                }
                if (CharacterClass == "Berserker")
                {
                    Console.WriteLine("Poluchi common golqm mech");
                    Gut1(ref dmg);
                }
                if (CharacterClass == "Lumberjack")
                {
                    Console.WriteLine("Poluchi common bradva");
                    Axe1(ref dmg);
                }
                if (CharacterClass == "Spearman")
                {
                    Console.WriteLine("Poluchi common kopie");
                    Spear1(ref dmg);
                }

            }
            //uncommon
            else if (rand.Next(0, 100) <= 57)
            {
                if (CharacterClass == "Swordsman")
                {
                    Console.WriteLine("Poluchi uncommon mech");
                    Sword2(ref dmg);
                }
                if (CharacterClass == "Archer")
                {
                    Console.WriteLine("Poluchi uncommon luk");
                    Bow2(ref dmg);
                }
                if (CharacterClass == "Berserker")
                {
                    Console.WriteLine("Poluchi uncommon golqm mech");
                    //Console.WriteLine("i hate niggers");
                    Gut2(ref dmg);
                }
                if (CharacterClass == "Lumberjack")
                {
                    Console.WriteLine("Poluchi uncommon bradva");
                    Axe2(ref dmg);
                }
                if (CharacterClass == "Spearman")
                {
                    Console.WriteLine("Poluchi uncommon kopie");
                    Spear2(ref dmg);
                }
            }
            //rare
            else if (rand.Next(0, 100) <= 77)
            {
                if (CharacterClass == "Swordsman")
                {
                    Console.WriteLine("Poluchi rare mech");
                    Sword3(ref dmg);
                }
                if (CharacterClass == "Archer")
                {
                    Console.WriteLine("Poluchi rare luk");
                    Bow3(ref dmg);
                }
                if (CharacterClass == "Berserker")
                {
                    Console.WriteLine("Poluchi rare golqm mech");
                    Gut3(ref dmg);
                }
                if (CharacterClass == "Lumberjack")
                {
                    Console.WriteLine("Poluchi rare bradva");
                    Axe3(ref dmg);
                }
                if (CharacterClass == "Spearman")
                {
                    Console.WriteLine("Poluchi rare kopie");
                    Spear3(ref dmg);
                }
            }
            //epic
            else if (rand.Next(0, 100) <= 90)
            {
                if (CharacterClass == "Swordsman")
                {
                    Console.WriteLine("Poluchi epic mech");
                    Sword4(ref dmg);
                }
                if (CharacterClass == "Archer")
                {
                    Console.WriteLine("Poluchi epic luk");
                    Bow4(ref dmg);
                }
                if (CharacterClass == "Berserker")
                {
                    Console.WriteLine("Poluchi epic golqm mech");
                    Gut4(ref dmg);
                }
                if (CharacterClass == "Lumberjack")
                {
                    Console.WriteLine("Poluchi epic bradva");
                    Axe4(ref dmg);
                }
                if (CharacterClass == "Spearman")
                {
                    Console.WriteLine("Poluchi epic kopie");
                    Spear4(ref dmg);
                }
            }
            //legendary
            else
            {
                if (CharacterClass == "Swordsman")
                {
                    Console.WriteLine("Poluchi legendary mech");
                    Sword5(ref dmg);
                }
                if (CharacterClass == "Archer")
                {
                    Console.WriteLine("Poluchi legendary luk");
                    Bow5(ref dmg);
                }
                if (CharacterClass == "Berserker")
                {
                    Console.WriteLine("Poluchi legendary golqm mech");
                    Gut5(ref dmg);
                }
                if (CharacterClass == "Lumberjack")
                {
                    Console.WriteLine("Poluchi legendary bradva");
                    Axe5(ref dmg);
                }
                if (CharacterClass == "Spearman")
                {
                    Console.WriteLine("Poluchi legendary kopie");
                    Spear5(ref dmg);
                }
            }
        }
        static void PathSelect(ref bool gora, ref bool polq)
        {
            //textart za gora i polq
            Console.WriteLine("Sega priklucheneco e v reme da si izberesh putq po koito shte zapochne tvoeto puteshestvie!!!");
            Console.WriteLine("");
            Console.WriteLine("Ot lqvo se namira gorata kudeto shte namerite mistichni suszdaniq i finalniq boss BAUBAU ");
            Console.WriteLine("");
            Console.WriteLine("Ot dqsno se ne namira poleto kudeto shte namerite ne tolkova mitichni suzdaniq i finalniq boz BLOBGLOB");
            Console.WriteLine("");
            Console.WriteLine("Molq natisnete {l} za gorata i {r} za poletata");
            Console.WriteLine("");
            while (true)
            {
                string pathselect = Console.ReadLine();
                if (pathselect == "l")
                {
                    gora = true;
                    Console.WriteLine("Taka priklucheneco, ti zapochna tvoeto puteshestvie v gorata");
                    break;
                }
                else if (pathselect == "r")
                {
                    polq = true;
                    Console.WriteLine("Taka priklucheneco, ti zapochna tvoeto puteshestvie v polqnata");
                    break;
                }
                else
                {
                    Console.WriteLine("ti su oligufren, opitai pak");
                    continue;
                }
            }

        }
        //forest enemyta
        static void Forest(bool gora, bool polq, ref int atsp, int wolveatsp, ref int currenthp, ref int dmg, ref int def, int wolvedmg, int wolvehp, int wolvedef, int slimehp, int slimedef, int slimeatsp, int slimedmg, int bearsatsp, int bearsdmg, int bearshp, int bearsdef, int fungiatsp, int fungidmg, int fungihp, int fungidef, int grompatsp, int grompdmg, int gromphp, int grompdef, int earthgolematsp, int earthgolemdmg, int earthgolemdef, int earthgolemhp, int hp)
        {
            Console.WriteLine("Ti vleze v gorata i beshe atakuvan ot glutnica vulci. Trqbva da se biesh za da se spasish");
            Console.WriteLine("Press any button to start the fight");
            Console.ReadKey();
            Console.Clear();
            firstfight(gora, polq, wolveatsp, ref atsp, ref currenthp, ref def, ref dmg, wolvedmg, wolvehp, wolvedef, slimehp, slimedef, slimeatsp, slimedmg,hp); //MAIKA TI PROSTA
            // random buff/nerf ili heal
            Console.Clear();
            secondfight(gora, polq, bearsatsp, bearsdmg, bearshp, bearsdef, fungihp, fungidef, fungiatsp, fungidmg, ref atsp, ref dmg, ref currenthp, ref def,hp);
            // random buff/nerf ili heal
            Console.Clear();
            thirdfight(gora, polq, grompatsp, grompdmg, gromphp, grompdef, earthgolemhp, earthgolemdef, earthgolematsp, earthgolemdmg, ref atsp, ref dmg, ref currenthp, ref def,hp);
            // random buff/nerf ili heal
            //consola clear
        }

        static void wolves()
        {

        }
        static void bears()
        {

        }
        static void gromp()
        {

        }

        //polq enemita
        static void Planes(bool gora, bool polq)
        {

        }
        static void slime()
        {

        }
        static void fungi()
        {

        }
        static void earthgolem()
        {

        }
        //fights
        static void firstfight(bool gora, bool polq, int wolveatsp, ref int atsp, ref int currenthp, ref int def, ref int dmg, int wolvedmg, int wolvehp, int wolvedef, int slimehp, int slimedef, int slimeatsp, int slimedmg, int hp)
        {
            if (gora == true)
            {

                if (wolveatsp < atsp)
                {

                    bool proverkaJivot = false;
                    //weat1st
                    while (currenthp >= 0 && wolvehp >= 0)
                    {
                        
                        wolvehp -= ((dmg - wolvedef));
                        if (wolvehp < 0)
                        {
                            wolvehp = 0;
                            proverkaJivot = false;
                            Console.WriteLine($"You attacked and dealt {dmg - wolvedef} DMG");
                            Console.WriteLine($"wolve HP is now = {wolvehp}");
                            break;
                        }
                        Console.WriteLine($"You attacked and dealt {dmg - wolvedef} DMG");
                        Console.WriteLine($"wolve HP is now = {wolvehp}");
                        Console.ReadKey();
                        Console.WriteLine();
                        // tuka slagame visual modelite

                        currenthp -= (wolvedmg - def);
                        if (currenthp < 0)
                        {
                            currenthp = 0;
                            proverkaJivot = true;
                            Console.WriteLine($"The wolves slashed you and dealt {wolvedmg - def} DMG");
                            Console.WriteLine($"Your HP is now = {currenthp}");
                            break;
                        }
                        Console.WriteLine($"The wolves slashed you and dealt {wolvedmg - def} DMG");
                        Console.WriteLine($"Your HP is now = {currenthp}");
                        Console.ReadKey();
                        Console.Clear();

                    }
                    if (proverkaJivot == false)
                    {
                        Console.WriteLine("You defeated the wolves, Congratulations!");
                        Console.WriteLine("");
                        Buffs(hp, ref currenthp, ref dmg, ref def, ref atsp);
                        Console.WriteLine("Press any button to continue along with your adventure");
                        Console.ReadKey();
                    }
                    else if (proverkaJivot)
                    {
                        Console.WriteLine("The wolves got you. Game over");
                        Environment.Exit(0);
                    }
                }
                else if (wolveatsp == atsp)
                {
                    //te at purvi
                    bool proverkaJivot = false;
                    while (currenthp >= 0 && wolvehp >= 0)
                    {
                        currenthp -= (wolvedmg - def);
                        if (currenthp < 0)
                        {
                            currenthp = 0;
                            proverkaJivot = true;
                            Console.WriteLine($"The wolves slashed you and dealt {wolvedmg - def} DMG");
                            Console.WriteLine($"Your HP is now = {currenthp}");
                            break;
                        }
                        Console.WriteLine($"The wolves slashed you and dealt {wolvedmg - def} DMG");
                        Console.WriteLine($"Your HP is now = {currenthp}");
                        Console.ReadKey();
                        Console.WriteLine();
                        //pak visualli

                        wolvehp -= (dmg - wolvedef);
                        if (wolvehp < 0)
                        {
                            wolvehp = 0;
                            proverkaJivot = false;
                            Console.WriteLine($"You attacked and dealt {dmg - wolvedef} DMG");
                            Console.WriteLine($"wolve HP is now = {wolvehp}");
                            break;
                        }
                        Console.WriteLine($"You attacked and dealt {dmg - wolvedef} DMG");
                        Console.WriteLine($"wolve HP is now = {wolvehp}");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    if (proverkaJivot == false)
                    {
                        Console.WriteLine("You defeated the wolves, Congratulations!");
                        Console.WriteLine("");
                        Buffs(hp, ref currenthp, ref dmg, ref def, ref atsp);
                        Console.WriteLine("Press any button to continue along with your adventure");
                        Console.ReadKey();
                    }
                    else if (proverkaJivot)
                    {
                        Console.WriteLine("The wolves got you. Game over");
                        Environment.Exit(0);
                    }

                }
                else
                {
                    //te at
                    bool proverkaJivot = false;
                    while (currenthp >= 0 && wolvehp >= 0)
                    {
                        currenthp -= (wolvedmg - def);
                        if (currenthp < 0)
                        {
                            currenthp = 0;
                            proverkaJivot = true;
                            Console.WriteLine($"The wolves slashed you and dealt {wolvedmg - def} DMG");
                            Console.WriteLine($"Your HP is now = {currenthp}");
                            break;
                        }
                        Console.WriteLine($"The wolves slashed you and dealt {wolvedmg - def} DMG");
                        Console.WriteLine($"Your HP is now = {currenthp}");
                        Console.ReadKey();
                        Console.WriteLine();
                        //pak visualli

                        wolvehp -= (dmg - wolvedef);
                        if (wolvehp < 0)
                        {
                            wolvehp = 0;
                            proverkaJivot = false;
                            Console.WriteLine($"You attacked and dealt {dmg - wolvedef} DMG");
                            Console.WriteLine($"wolve HP is now = {wolvehp}");
                            break;
                        }
                        Console.WriteLine($"You attacked and dealt {dmg - wolvedef} DMG");
                        Console.WriteLine($"wolve HP is now = {wolvehp}");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    if (proverkaJivot == false)
                    {
                        Console.WriteLine("You defeated the wolves, Congratulations!");
                        Console.WriteLine("");
                        Buffs(hp, ref currenthp, ref dmg, ref def, ref atsp);
                        Console.WriteLine("Press any button to continue along with your adventure");
                        Console.ReadKey();
                    }
                    else if (proverkaJivot)
                    {
                        Console.WriteLine("The wolves got you. Game over");
                        Environment.Exit(0);
                    }
                }
            }
            else if (polq == true)
            {
                if (slimeatsp < atsp)
                {
                    //weat1st
                    bool proverkaJivot = false;
                    while (currenthp >= 0 && slimehp >= 0)
                    {
                        slimehp -= (dmg - slimedef);
                        if (slimehp < 0)
                        {
                            slimehp = 0;
                            proverkaJivot = false;
                            Console.WriteLine($"You attacked and dealt {dmg - slimedef} DMG");
                            Console.WriteLine($"slime HP is now = {slimehp}");
                            break;
                        }
                        Console.WriteLine($"You attacked and dealt {dmg - slimedef} DMG");
                        Console.WriteLine($"slime HP = {slimehp}");
                        Console.ReadKey();
                        Console.WriteLine();
                        // tuka slagame visual modelite

                        currenthp -= (slimedmg - def);
                        if (currenthp < 0)
                        {
                            currenthp = 0;
                            proverkaJivot = true;
                            Console.WriteLine($"You got hit by a slime and took {slimedmg - def}  DMG");
                            Console.WriteLine($"Your HP is : {currenthp}");
                            break;
                        }
                        Console.WriteLine($"You got hit by a slime and took {slimedmg - def}  DMG");
                        Console.WriteLine($"Your HP is : {currenthp}");
                        Console.ReadKey();
                        Console.Clear();

                    }
                    if (proverkaJivot == false)
                    {
                        Console.WriteLine("You defeated the slime, Congratulations!");
                        Console.WriteLine("");
                        Buffs(hp, ref currenthp, ref dmg, ref def, ref atsp);
                        Console.WriteLine("Press any button to continue along with your adventure");
                        Console.ReadKey();
                    }
                    else if (proverkaJivot)
                    {
                        Console.WriteLine("The slime got you. Game over");
                        Environment.Exit(0);
                    }
                }
                else if (slimeatsp == atsp)
                {
                    //te at purvi
                    bool proverkaJivot = false;
                    while (currenthp >= 0 && slimehp >= 0)
                    {
                        currenthp -= (slimedmg - def);
                        if (currenthp < 0)
                        {
                            currenthp = 0;
                            proverkaJivot = true;
                            Console.WriteLine($"You got hit by a slime and took {slimedmg - def}  DMG");
                            Console.WriteLine($"Your HP is : {currenthp}");
                            break;
                        }
                        Console.WriteLine($"You got hit by a slime and took {slimedmg - def} DMG");
                        Console.WriteLine($"Your HP is= {currenthp}");
                        Console.ReadKey();
                        Console.Clear();
                        // tuka slagame visual modelite

                        slimehp -= (dmg - slimedef);
                        if (slimehp < 0)
                        {
                            slimehp = 0;
                            proverkaJivot = false;
                            Console.WriteLine($"You attacked and dealt {dmg - slimedef} DMG");
                            Console.WriteLine($"slime HP is now = {slimehp}");
                            break;
                        }
                        Console.WriteLine($"You attacked and dealt {dmg - slimedef} DMG");
                        Console.WriteLine($"slime HP = {slimehp}");
                        Console.ReadKey();
                        Console.WriteLine();
                    }
                    if (proverkaJivot == false)
                    {
                        Console.WriteLine("You defeated the slime, Congratulations!");
                        Console.WriteLine("");
                        Buffs(hp, ref currenthp, ref dmg, ref def, ref atsp);
                        Console.WriteLine("Press any button to continue along with your adventure");
                        Console.ReadKey();
                    }
                    else if (proverkaJivot)
                    {
                        Console.WriteLine("The slime got you. Game over");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    //te at
                    bool proverkaJivot = false;
                    while (currenthp >= 0 && slimehp >= 0)
                    {
                        currenthp -= (slimedmg - def);
                        if (currenthp < 0)
                        {
                            currenthp = 0;
                            proverkaJivot = true;
                            Console.WriteLine($"You got hit by a slime and took {slimedmg - def}  DMG");
                            Console.WriteLine($"Your HP is : {currenthp}");
                            break;
                        }
                        Console.WriteLine($"You got hit by a slime and took {slimedmg - def} DMG");
                        Console.WriteLine($"Your HP is = {currenthp}");
                        Console.ReadKey();
                        Console.Clear();
                        // tuka slagame visual modelite

                        slimehp -= (dmg - slimedef);
                        if (slimehp < 0)
                        {
                            slimehp = 0;
                            proverkaJivot = false;
                            Console.WriteLine($"You attacked and dealt {dmg - slimedef} DMG");
                            Console.WriteLine($"slime HP is now = {slimehp}");
                            break;
                        }
                        Console.WriteLine($"You attacked and dealt {dmg - slimedef} DMG");
                        Console.WriteLine($"slime HP = {slimehp}");
                        Console.ReadKey();
                        Console.WriteLine();
                    }
                    if (proverkaJivot == false)
                    {
                        Console.WriteLine("You defeated the slime, Congratulations!");
                        Console.WriteLine("");
                        Buffs(hp, ref currenthp, ref dmg, ref def, ref atsp);
                        Console.WriteLine("Press any button to continue along with your adventure");
                        Console.ReadKey();
                    }
                    else if (proverkaJivot)
                    {
                        Console.WriteLine("The slime got you. Game over");
                        Environment.Exit(0);
                    }
                }
            }
        }
        static void secondfight(bool gora, bool polq, int bearsatsp, int bearsdmg, int bearshp, int bearsdef, int fungihp, int fungidef, int fungiatsp, int fungidmg, ref int atsp, ref int dmg, ref int currenthp, ref int def, int hp)
        {
            if (gora == true)
            {
                if (bearsatsp < atsp)
                {
                    //weat1st
                    bool proverkaJivot = false;
                    while (currenthp >= 0 && bearshp >= 0)
                    {
                        bearshp -= (dmg - bearsdef);
                        if (bearshp < 0)
                        {
                            bearshp = 0;
                            proverkaJivot = false;
                            Console.WriteLine($"You attacked and dealt {dmg - bearsdef} DMG");
                            Console.WriteLine($"bear HP is now = {bearshp}");
                            break;
                        }
                        Console.WriteLine($"You attacked and dealt {dmg - bearsdef} DMG");
                        Console.WriteLine($"bears HP = {bearshp}");
                        Console.ReadKey();
                        Console.WriteLine();
                        // tuka slagame visual modelite

                        currenthp -= (bearsdmg - def);
                        if (currenthp < 0)
                        {
                            currenthp = 0;
                            proverkaJivot = true;
                            Console.WriteLine($"You got slashed by the bear and took {bearsdmg - def} DMG");
                            Console.WriteLine($"Your HP is : {currenthp}");
                            break;
                        }
                        Console.WriteLine($"You got slashed by the bear and took {bearsdmg - def} DMG");
                        Console.WriteLine($"Your HP is = {currenthp}");
                        Console.ReadKey();
                        Console.Clear();

                    }
                    if (proverkaJivot == false)
                    {
                        Console.WriteLine("You defeated the bear, Congratulations!");
                        Console.WriteLine("");
                        Buffs(hp, ref currenthp, ref dmg, ref def, ref atsp);
                        Console.WriteLine("Press any button to continue along with your adventure");
                        Console.ReadKey();
                    }
                    else if (proverkaJivot)
                    {
                        Console.WriteLine("The bear got you. Game over");
                        Environment.Exit(0);
                    }
                }
                else if (bearsatsp == atsp)
                {
                    //te at purvi
                    bool proverkaJivot = false;
                    while (currenthp >=0 && bearshp >=0)
                    {
                        currenthp -= (bearsdmg - def);
                        if (currenthp < 0)
                        {
                            currenthp = 0;
                            proverkaJivot = true;
                            Console.WriteLine($"You got slashed by the bear and took {bearsdmg - def} DMG");
                            Console.WriteLine($"Your HP is : {currenthp}");
                            break;
                        }
                        Console.WriteLine($"You got slashed by the bear and took {bearsdmg - def} DMG");
                        Console.WriteLine($"Your HP is = {currenthp}");
                        Console.ReadKey();
                        Console.Clear();
                        // tuka slagame visual modelite

                        bearshp -= (dmg - bearsdef);
                        if (bearshp < 0)
                        {
                            bearshp = 0;
                            proverkaJivot = false;
                            Console.WriteLine($"You attacked and dealt {dmg - bearsdef} DMG");
                            Console.WriteLine($"bear HP is now = {bearshp}");
                            break;
                        }
                        Console.WriteLine($"You attacked and dealt {dmg - bearsdef} DMG");
                        Console.WriteLine($"bears HP = {bearshp}");
                        Console.ReadKey();
                        Console.WriteLine();
                    }
                    if (proverkaJivot == false)
                    {
                        Console.WriteLine("You defeated the bear, Congratulations!");
                        Console.WriteLine("");
                        Buffs(hp, ref currenthp, ref dmg, ref def, ref atsp);
                        Console.WriteLine("Press any button to continue along with your adventure");
                        Console.ReadKey();
                    }
                    else if (proverkaJivot)
                    {
                        Console.WriteLine("The bear got you. Game over");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    //te at
                    bool proverkaJivot = false;
                    while (currenthp >= 0 && bearshp >= 0)
                    {
                        currenthp -= (bearsdmg - def);
                        if (currenthp < 0)
                        {
                            currenthp = 0;
                            proverkaJivot = true;
                            Console.WriteLine($"You got slashed by the bear and took {bearsdmg - def} DMG");
                            Console.WriteLine($"Your HP is : {currenthp}");
                            break;
                        }
                        Console.WriteLine($"You got slashed by the bear and took {bearsdmg - def} DMG");
                        Console.WriteLine($"Your HP is = {currenthp}");
                        Console.ReadKey();
                        Console.Clear();
                        // tuka slagame visual modelite

                        bearshp -= (dmg - bearsdef);
                        if (bearshp < 0)
                        {
                            bearshp = 0;
                            proverkaJivot = false;
                            Console.WriteLine($"You attacked and dealt {dmg - bearsdef} DMG");
                            Console.WriteLine($"bear HP is now = {bearshp}");
                            break;
                        }
                        Console.WriteLine($"You attacked and dealt {dmg - bearsdef} DMG");
                        Console.WriteLine($"bears HP = {bearshp}");
                        Console.ReadKey();
                        Console.WriteLine();
                    }
                    if (proverkaJivot == false)
                    {
                        Console.WriteLine("You defeated the bear, Congratulations!");
                        Console.WriteLine("");
                        Buffs(hp, ref currenthp, ref dmg, ref def, ref atsp);
                        Console.WriteLine("Press any button to continue along with your adventure");
                        Console.ReadKey();
                    }
                    else if (proverkaJivot)
                    {
                        Console.WriteLine("The bear got you. Game over");
                        Environment.Exit(0);
                    }
                }
            }
            else if (polq == true)
            {
                if (fungiatsp < atsp)
                {
                    bool proverkaJivot = false;
                    //weat1st
                    while (currenthp >= 0 && fungihp >= 0)
                    {
                        fungihp -= (dmg - fungidef);
                        if (fungihp < 0)
                        {
                            fungihp = 0;
                            proverkaJivot = false;
                            Console.WriteLine($"You attacked and dealt {dmg - fungidef} DMG");
                            Console.WriteLine($"fungi HP is now = {fungihp}");
                            break;
                        }
                        Console.WriteLine($"You attacked and dealt {dmg - fungidef} DMG");
                        Console.WriteLine($"fungi HP = {fungihp}");
                        Console.ReadKey();
                        Console.WriteLine();
                        // tuka slagame visual modelite

                        currenthp -= (fungidmg - def);
                        if (currenthp < 0)
                        {
                            currenthp = 0;
                            proverkaJivot = true;
                            Console.WriteLine($"You got flushed by the fungi and took {fungidmg - def} DMG");
                            Console.WriteLine($"Your HP is : {currenthp}");
                            break;
                        }
                        Console.WriteLine($"You got flushed by the fungi and took {fungidmg - def} DMG");
                        Console.WriteLine($"Your HP is = {currenthp}");
                        Console.ReadKey();
                        Console.Clear();

                    }
                    if (proverkaJivot == false)
                    {
                        Console.WriteLine("You defeated the fungi, Congratulations!");
                        Console.WriteLine("");
                        Buffs(hp, ref currenthp, ref dmg, ref def, ref atsp);
                        Console.WriteLine("Press any button to continue along with your adventure");
                        Console.ReadKey();
                    }
                    else if (proverkaJivot)
                    {
                        Console.WriteLine("The fungi got you. Game over");
                        Environment.Exit(0);
                    }
                }
                else if (fungiatsp == atsp)
                {
                    //te at purvi
                    bool proverkaJivot = false;
                    while (currenthp >= 0 && fungihp >= 0)
                    {
                        currenthp -= (fungidmg - def);
                        if (currenthp < 0)
                        {
                            currenthp = 0;
                            proverkaJivot = true;
                            Console.WriteLine($"You got flushed by the fungi and took {fungidmg - def} DMG");
                            Console.WriteLine($"Your HP is : {currenthp}");
                            break;
                        }
                        Console.WriteLine($"You got flushed by the fungi and took {fungidmg - def} DMG");
                        Console.WriteLine($"Your HP is = {currenthp}");
                        Console.ReadKey();
                        Console.Clear();
                        // tuka slagame visual modelite

                        fungihp -= (dmg - fungidef);
                        if (fungihp < 0)
                        {
                            fungihp = 0;
                            proverkaJivot = false;
                            Console.WriteLine($"You attacked and dealt {dmg - fungidef} DMG");
                            Console.WriteLine($"fungi HP is now = {fungihp}");
                            break;
                        }
                        Console.WriteLine($"You attacked and dealt {dmg - fungidef} DMG");
                        Console.WriteLine($"fungi HP = {fungihp}");
                        Console.ReadKey();
                        Console.WriteLine();
                    }
                    if (proverkaJivot == false)
                    {
                        Console.WriteLine("You defeated the fungi, Congratulations!");
                        Console.WriteLine("");
                        Buffs(hp, ref currenthp, ref dmg, ref def, ref atsp);
                        Console.WriteLine("Press any button to continue along with your adventure");
                        Console.ReadKey();
                    }
                    else if (proverkaJivot)
                    {
                        Console.WriteLine("The fungi got you. Game over");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    //te at
                    bool proverkaJivot = false;
                    while (currenthp >= 0 && fungihp >= 0)
                    {
                        currenthp -= (fungidmg - def);
                        if (currenthp < 0)
                        {
                            currenthp = 0;
                            proverkaJivot = true;
                            Console.WriteLine($"You got flushed by the fungi and took {fungidmg - def} DMG");
                            Console.WriteLine($"Your HP is : {currenthp}");
                            break;
                        }
                        Console.WriteLine($"You got flushed by the fungi and took {fungidmg - def} DMG");
                        Console.WriteLine($"Your HP is = {currenthp}");
                        Console.ReadKey();
                        Console.Clear();
                        // tuka slagame visual modelite

                        fungihp -= (dmg - fungidef);
                        if (fungihp < 0)
                        {
                            fungihp = 0;
                            proverkaJivot = false;
                            Console.WriteLine($"You attacked and dealt {dmg - fungidef} DMG");
                            Console.WriteLine($"fungi HP is now = {fungihp}");
                            break;
                        }
                        Console.WriteLine($"You attacked and dealt {dmg - fungidef} DMG");
                        Console.WriteLine($"fungi HP = {fungihp}");
                        Console.ReadKey();
                        Console.WriteLine();
                    }
                    if (proverkaJivot == false)
                    {
                        Console.WriteLine("You defeated the fungi, Congratulations!");
                        Console.WriteLine("");
                        Buffs(hp, ref currenthp, ref dmg, ref def, ref atsp);
                        Console.WriteLine("Press any button to continue along with your adventure");
                        Console.ReadKey();
                    }
                    else if (proverkaJivot)
                    {
                        Console.WriteLine("The fungi got you. Game over");
                        Environment.Exit(0);
                    }
                }
            }
        }
        static void thirdfight(bool gora, bool polq, int grompatsp, int grompdmg, int gromphp, int grompdef, int earthgolemhp, int earthgolemdef, int earthgolematsp, int earthgolemdmg, ref int atsp, ref int dmg,ref int currenthp,ref int def, int hp)
        {
            if (gora == true)
            {
                if (grompatsp < atsp)
                {
                    //weat1st
                    bool proverkaJivot = false;
                    while (currenthp >= 0 && gromphp >= 0)
                    {
                        gromphp -= (dmg - grompdef);
                        if (gromphp < 0)
                        {
                            gromphp = 0;
                            proverkaJivot = false;
                            Console.WriteLine($"You attacked and dealt {dmg - grompdef} DMG");
                            Console.WriteLine($"gromp HP is now = {gromphp}");
                            break;
                        }
                        Console.WriteLine($"You attacked and dealt {dmg - grompdef} DMG");
                        Console.WriteLine($"gromp HP = {gromphp}");
                        Console.ReadKey();
                        Console.WriteLine();
                        // tuka slagame visual modelite

                        currenthp -= (grompdmg - def);
                        if (currenthp < 0)
                        {
                            currenthp = 0;
                            proverkaJivot = true;
                            Console.WriteLine($"You got spitted by the gromp and took {grompdmg - def} DMG");
                            Console.WriteLine($"Your HP is : {currenthp}");
                            break;
                        }
                        Console.WriteLine($"You got spitted by the gromp and took {grompdmg - def} DMG");
                        Console.WriteLine($"Your HP is = {currenthp}");
                        Console.ReadKey();
                        Console.Clear();

                    }
                    if (proverkaJivot == false)
                    {
                        Console.WriteLine("You defeated the gromp, Congratulations!");
                        Console.WriteLine("");
                        Buffs(hp, ref currenthp, ref dmg, ref def, ref atsp);
                        Console.WriteLine("Press any button to fight the finall boss");
                        Console.ReadKey();
                    }
                    else if (proverkaJivot)
                    {
                        Console.WriteLine("The gromp got you. Game over");
                        Environment.Exit(0);
                    }
                }
                else if (grompatsp == atsp)
                {
                    //te at purvi
                    bool proverkaJivot = false;
                    while (currenthp >= 0 && grompatsp >= 0)
                    {
                        currenthp -= (grompdmg - def);
                        if (currenthp < 0)
                        {
                            currenthp = 0;
                            proverkaJivot = true;
                            Console.WriteLine($"You got spitted by the gromp and took {grompdmg - def} DMG");
                            Console.WriteLine($"Your HP is : {currenthp}");
                            break;
                        }
                        Console.WriteLine($"You got spitted by the gromp and took {grompdmg - def} DMG");
                        Console.WriteLine($"Your HP is = {currenthp}");
                        Console.ReadKey();
                        Console.Clear();
                        // tuka slagame visual modelite

                        gromphp -= (dmg - grompdef);
                        if (gromphp < 0)
                        {
                            gromphp = 0;
                            proverkaJivot = false;
                            Console.WriteLine($"You attacked and dealt {dmg - grompdef} DMG");
                            Console.WriteLine($"gromp HP is now = {gromphp}");
                            break;
                        }
                        Console.WriteLine($"You attacked and dealt {dmg - grompdef} DMG");
                        Console.WriteLine($"gromp HP = {gromphp}");
                        Console.ReadKey();
                        Console.WriteLine();
                    }
                    if (proverkaJivot == false)
                    {
                        Console.WriteLine("You defeated the gromp, Congratulations!");
                        Console.WriteLine("");
                        Buffs(hp, ref currenthp, ref dmg, ref def, ref atsp);
                        Console.WriteLine("Press any button to fight the finall boss");
                        Console.ReadKey();
                    }
                    else if (proverkaJivot)
                    {
                        Console.WriteLine("The gromp got you. Game over");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    //te at
                    bool proverkaJivot = false;
                    while (currenthp >= 0 && grompatsp >= 0)
                    {
                        currenthp -= (grompdmg - def);
                        if (currenthp < 0)
                        {
                            currenthp = 0;
                            proverkaJivot = true;
                            Console.WriteLine($"You got spitted by the gromp and took {grompdmg - def} DMG");
                            Console.WriteLine($"Your HP is : {currenthp}");
                            break;
                        }
                        Console.WriteLine($"You got spitted by the gromp and took {grompdmg - def} DMG");
                        Console.WriteLine($"Your HP is = {currenthp}");
                        Console.ReadKey();
                        Console.Clear();
                        // tuka slagame visual modelite

                        gromphp -= (dmg - grompdef);
                        if (gromphp < 0)
                        {
                            gromphp = 0;
                            proverkaJivot = false;
                            Console.WriteLine($"You attacked and dealt {dmg - grompdef} DMG");
                            Console.WriteLine($"gromp HP is now = {gromphp}");
                            break;
                        }
                        Console.WriteLine($"You attacked and dealt {dmg - grompdef} DMG");
                        Console.WriteLine($"gromp HP = {gromphp}");
                        Console.ReadKey();
                        Console.WriteLine();
                    }
                    if (proverkaJivot == false)
                    {
                        Console.WriteLine("You defeated the gromp, Congratulations!");
                        Console.WriteLine("");
                        Buffs(hp, ref currenthp, ref dmg, ref def, ref atsp);
                        Console.WriteLine("Press any button to fight the finall boss");
                        Console.ReadKey();
                    }
                    else if (proverkaJivot)
                    {
                        Console.WriteLine("The gromp got you. Game over");
                        Environment.Exit(0);
                    }
                }
            }
            else if (polq == true)
            {
                if (earthgolematsp < atsp)
                {
                    bool proverkaJivot = false;
                    //weat1st
                    while (currenthp >= 0 && earthgolemhp >= 0)
                    {
                        earthgolemhp -= (dmg - earthgolemdef);
                        if (earthgolemhp < 0)
                        {
                            earthgolemhp = 0;
                            proverkaJivot = false;
                            Console.WriteLine($"You attacked and dealt {dmg - earthgolemdef} DMG");
                            Console.WriteLine($"earthgolem HP is now = {earthgolemhp}");
                            break;
                        }
                        Console.WriteLine($"You attacked and dealt {dmg - earthgolemdef} DMG");
                        Console.WriteLine($"earthgolem HP = {earthgolemhp}");
                        Console.ReadKey();
                        Console.WriteLine();
                        // tuka slagame visual modelite

                        currenthp -= (earthgolemdmg - def);
                        if (currenthp < 0)
                        {
                            currenthp = 0;
                            proverkaJivot = true;
                            Console.WriteLine($"You got hit by a rock and took {earthgolemdmg - def} DMG");
                            Console.WriteLine($"Your HP is : {currenthp}");
                            break;
                        }
                        Console.WriteLine($"You got hit by a rock and took {earthgolemdmg - def} DMG");
                        Console.WriteLine($"Your HP is = {currenthp}");
                        Console.ReadKey();
                        Console.Clear();

                    }
                    if (proverkaJivot == false)
                    {
                        Console.WriteLine("You defeated the earhgolem, Congratulations!");
                        Console.WriteLine("");
                        Buffs(hp, ref currenthp, ref dmg, ref def, ref atsp);
                        Console.WriteLine("Press any button to fight the final boss");
                        Console.ReadKey();
                    }
                    else if (proverkaJivot)
                    {
                        Console.WriteLine("The earthgolem got you. Game over");
                        Environment.Exit(0);
                    }
                }
                else if (earthgolematsp == atsp)
                {
                    //te at purvi
                    bool proverkaJivot = false;
                    while (currenthp >= 0 && earthgolemhp >= 0)
                    {
                        currenthp -= (earthgolemdmg - def);
                        if (currenthp < 0)
                        {
                            currenthp = 0;
                            proverkaJivot = true;
                            Console.WriteLine($"You got hit by a rock and took {earthgolemdmg - def} DMG");
                            Console.WriteLine($"Your HP is : {currenthp}");
                            break;
                        }
                        Console.WriteLine($"You got hit by a rock and took {earthgolemdmg - def} DMG");
                        Console.WriteLine($"Your HP is = {currenthp}");
                        Console.ReadKey();
                        Console.Clear();
                        // tuka slagame visual modelite

                        earthgolemhp -= (dmg - earthgolemdef);
                        if (earthgolemhp < 0)
                        {
                            earthgolemhp = 0;
                            proverkaJivot = false;
                            Console.WriteLine($"You attacked and dealt {dmg - earthgolemdef} DMG");
                            Console.WriteLine($"earthgolem HP is now = {earthgolemhp}");
                            break;
                        }
                        Console.WriteLine($"You attacked and dealt {dmg - earthgolemdef} DMG");
                        Console.WriteLine($"earthgolem HP = {earthgolemhp}");
                        Console.ReadKey();
                        Console.WriteLine();
                    }
                    if (proverkaJivot == false)
                    {
                        Console.WriteLine("You defeated the earhgolem, Congratulations!");
                        Console.WriteLine("");
                        Buffs(hp, ref currenthp, ref dmg, ref def, ref atsp);
                        Console.WriteLine("Press any button to fight the final boss");
                        Console.ReadKey();
                    }
                    else if (proverkaJivot)
                    {
                        Console.WriteLine("The earthgolem got you. Game over");
                        Environment.Exit(0);
                    }
                }
                else
                {
                    //te at
                    bool proverkaJivot = false;
                    while (currenthp >= 0 && earthgolemhp >= 0)
                    {
                        currenthp -= (earthgolemdmg - def);
                        if (currenthp < 0)
                        {
                            currenthp = 0;
                            proverkaJivot = true;
                            Console.WriteLine($"You got hit by a rock and took {earthgolemdmg - def} DMG");
                            Console.WriteLine($"Your HP is : {currenthp}");
                            break;
                        }
                        Console.WriteLine($"You got hit by a rock and took {earthgolemdmg - def} DMG");
                        Console.WriteLine($"Your HP is = {currenthp}");
                        Console.ReadKey();
                        Console.Clear();
                        // tuka slagame visual modelite

                        earthgolemhp -= (dmg - earthgolemdef);
                        if (earthgolemhp < 0)
                        {
                            earthgolemhp = 0;
                            proverkaJivot = false;
                            Console.WriteLine($"You attacked and dealt {dmg - earthgolemdef} DMG");
                            Console.WriteLine($"earthgolem HP is now = {earthgolemhp}");
                            break;
                        }
                        Console.WriteLine($"You attacked and dealt {dmg - earthgolemdef} DMG");
                        Console.WriteLine($"earthgolem HP = {earthgolemhp}");
                        Console.ReadKey();
                        Console.WriteLine();
                    }
                    if (proverkaJivot == false)
                    {
                        Console.WriteLine("You defeated the earhgolem, Congratulations!");
                        Console.WriteLine("");
                        Buffs(hp, ref currenthp, ref dmg, ref def, ref atsp);
                        Console.WriteLine("Press any button to fight the final boss");
                        Console.ReadKey();
                    }
                    else if (proverkaJivot)
                    {
                        Console.WriteLine("The earthgolem got you. Game over");
                        Environment.Exit(0);
                    }
                }
            }
        }


        //boss fights//

        static void Baubau(int baubauhp, int baubaudmg, int baubaudatsp, int baubauddef, ref int currenthp, ref int dmg, ref int atsp,ref int def, int hp)
        {
            Console.WriteLine($"Tova e finalniqt bos BauBau !!!∙Ї╒╘ . Kogato si gotov da se biesh s nego, natisni nqkoi buton.(bez power btn)");
            Console.ReadKey();
            Console.Clear();
            if (baubaudatsp < atsp)
            {
                //weat1st
                bool proverkaJivot = false;
                while (currenthp >=0 && baubauhp >= 0)
                {
                    
                    baubauhp -= (dmg - baubauddef);
                    if (baubauhp < 0)
                    {
                        baubauhp = 0;
                        proverkaJivot = false;
                        Console.WriteLine($"You attacked and dealt {dmg - baubauddef} DMG");
                        Console.WriteLine($"Baubau HP is now = {baubauhp}");
                        break;
                    }
                    Console.WriteLine($"You attacked and dealt {dmg - baubauddef} DMG");
                    Console.WriteLine($"Baubau HP = {baubauhp}");
                    Console.ReadKey();
                    Console.WriteLine();
                    // tuka slagame visual modelite

                    currenthp -= (baubaudmg - def);
                    if (currenthp < 0)
                    {
                        currenthp = 0;
                        proverkaJivot = true;
                        Console.WriteLine($"You got hit by Baubau and took {baubaudmg - def} DMG");
                        Console.WriteLine($"Your HP is : {currenthp}");
                        break;
                    }
                    Console.WriteLine($"You got hit by Baubau and took {baubaudmg - def} DMG");
                    Console.WriteLine($"Your HP is = {currenthp}");
                    Console.ReadKey();
                    Console.Clear();

                }
                if (proverkaJivot == false)
                {
                    Console.WriteLine("You defeated the BAUBAU, Congratulations!");
                    Console.WriteLine("");
                    Console.WriteLine("Press any button to end the game");
                    Console.ReadKey();
                }
                else if (proverkaJivot)
                {
                    Console.WriteLine("The BAUBAU got you. Game over");
                    Environment.Exit(0);
                }
            }
            else if (baubaudatsp == atsp)
            {
                //te at purvi
                bool proverkaJivot = false;
                while (currenthp >= 0 && baubauhp >= 0)
                {
                    currenthp -= (baubaudmg - def);
                    if (currenthp < 0)
                    {
                        currenthp = 0;
                        proverkaJivot = true;
                        Console.WriteLine($"You got hit by Baubau and took {baubaudmg - def} DMG");
                        Console.WriteLine($"Your HP is : {currenthp}");
                        break;
                    }
                    Console.WriteLine($"You got hit by Baubau and took {baubaudmg - def} DMG");
                    Console.WriteLine($"Your HP is = {currenthp}");
                    Console.ReadKey();
                    Console.Clear();
                    // tuka slagame visual modelite

                    baubauhp -= (dmg - baubauddef);
                    if (baubauhp < 0)
                    {
                        baubauhp = 0;
                        proverkaJivot = false;
                        Console.WriteLine($"You attacked and dealt {dmg - baubauddef} DMG");
                        Console.WriteLine($"Baubau HP is now = {baubauhp}");
                        break;
                    }
                    Console.WriteLine($"You attacked and dealt {dmg - baubauddef} DMG");
                    Console.WriteLine($"Baubau HP = {baubauhp}");
                    Console.ReadKey();
                    Console.WriteLine();
                }
                if (proverkaJivot == false)
                {
                    Console.WriteLine("You defeated the BAUBAU, Congratulations!");
                    Console.WriteLine("");
                    Console.WriteLine("Press any button to end the game");
                    Console.ReadKey();
                }
                else if (proverkaJivot)
                {
                    Console.WriteLine("The BAUBAU got you. Game over");
                    Environment.Exit(0);
                }
            }
            else
            {
                //te at
                bool proverkaJivot = false;
                while (currenthp >= 0 && baubauhp >= 0)
                {
                    currenthp -= (baubaudmg - def);
                    if (currenthp < 0)
                    {
                        currenthp = 0;
                        proverkaJivot = true;
                        Console.WriteLine($"You got hit by Baubau and took {baubaudmg - def} DMG");
                        Console.WriteLine($"Your HP is : {currenthp}");
                        break;
                    }
                    Console.WriteLine($"You got hit by Baubau and took {baubaudmg - def} DMG");
                    Console.WriteLine($"Your HP is = {currenthp}");
                    Console.ReadKey();
                    Console.Clear();
                    // tuka slagame visual modelite

                    baubauhp -= (dmg - baubauddef);
                    if (baubauhp < 0)
                    {
                        baubauhp = 0;
                        proverkaJivot = false;
                        Console.WriteLine($"You attacked and dealt {dmg - baubauddef} DMG");
                        Console.WriteLine($"Baubau HP is now = {baubauhp}");
                        break;
                    }
                    Console.WriteLine($"You attacked and dealt {dmg - baubauddef} DMG");
                    Console.WriteLine($"Baubau HP = {baubauhp}");
                    Console.ReadKey();
                    Console.WriteLine();
                }
                if (proverkaJivot == false)
                {
                    Console.WriteLine("You defeated the BAUBAU, Congratulations!");
                    Console.WriteLine("");
                    Console.WriteLine("Press any button to end the game");
                    Console.ReadKey();
                }
                else if (proverkaJivot)
                {
                    Console.WriteLine("The BAUBAU got you. Game over");
                    Environment.Exit(0);
                }
            }
        }

        static void BlobGlob(int blobglobhp, int blobglobdmg, int blobglobatsp, int blobglobdef, ref int currenthp,ref int dmg, ref int atsp,ref int def, int hp)
        {
            Console.WriteLine($"Tova e finalniqt bos BLOBGLOB !!!∙Ї╒╘ . Kogato si gotov da se biesh s nego, natisni nqkoi buton.(bez power btn)");
            Console.ReadKey();
            Console.Clear();
            if (blobglobatsp < atsp)
            {
                //weat1st
                bool proverkaJivot = false;
                while (currenthp >= 0 && blobglobhp >= 0)
                {
                    blobglobhp -= (dmg - blobglobdef);
                    if (blobglobhp < 0)
                    {
                        blobglobhp = 0;
                        proverkaJivot = false;
                        Console.WriteLine($"You attacked and dealt {dmg - blobglobdef} DMG");
                        Console.WriteLine($"The BlobGlob HP is now = {blobglobhp}");
                        break;
                    }
                    Console.WriteLine($"You attacked and dealt {dmg - blobglobdef} DMG");
                    Console.WriteLine($"The BlobGlob HP = {blobglobhp}");
                    Console.ReadKey();
                    Console.WriteLine();
                    // tuka slagame visual modelite

                    currenthp -= (blobglobdmg - def);
                    if (currenthp < 0)
                    {
                        currenthp = 0;
                        proverkaJivot = true;
                        Console.WriteLine($"You got hit by The BlobGlob and took {blobglobdmg - def} DMG");
                        Console.WriteLine($"Your HP is : {currenthp}");
                        break;
                    }
                    Console.WriteLine($"You got hit by The BlobGlob and took {blobglobdmg - def} DMG");
                    Console.WriteLine($"Your HP is = {currenthp}");
                    Console.ReadKey();
                    Console.Clear();

                }
                if (proverkaJivot == false)
                {
                    Console.WriteLine("You defeated the BlobGlob, Congratulations!");
                    Console.WriteLine("");
                    Console.WriteLine("Press any button to end the game");
                    Console.ReadKey();
                }
                else if (proverkaJivot)
                {
                    Console.WriteLine("The BlobGlob got you. Game over");
                    Environment.Exit(0);
                }
            }
            else if (blobglobatsp == atsp)
            {
                //te at purvi
                bool proverkaJivot = false;
                while (currenthp >= 0 && blobglobhp >= 0)
                {
                    currenthp -= (blobglobdmg - def);
                    if (currenthp < 0)
                    {
                        currenthp = 0;
                        proverkaJivot = true;
                        Console.WriteLine($"You got hit by The BlobGlob and took {blobglobdmg - def} DMG");
                        Console.WriteLine($"Your HP is : {currenthp}");
                        break;
                    }
                    Console.WriteLine($"You got hit by The BlobGlob and took {blobglobdmg - def} DMG");
                    Console.WriteLine($"Your HP is = {currenthp}");
                    Console.ReadKey();
                    Console.Clear();
                    // tuka slagame visual modelite

                    blobglobhp -= (dmg - blobglobdef);
                    if (blobglobhp < 0)
                    {
                        blobglobhp = 0;
                        proverkaJivot = false;
                        Console.WriteLine($"You attacked and dealt {dmg - blobglobdef} DMG");
                        Console.WriteLine($"The BlobGlob HP is now = {blobglobhp}");
                        break;
                    }
                    Console.WriteLine($"You attacked and dealt {dmg - blobglobdef} DMG");
                    Console.WriteLine($"The BlobGlob HP = {blobglobhp}");
                    Console.ReadKey();
                    Console.WriteLine();
                }
                if (proverkaJivot == false)
                {
                    Console.WriteLine("You defeated the BlobGlob, Congratulations!");
                    Console.WriteLine("");
                    Console.WriteLine("Press any button to end the game");
                    Console.ReadKey();
                }
                else if (proverkaJivot)
                {
                    Console.WriteLine("The BlobGlob got you. Game over");
                    Environment.Exit(0);
                }
            }
            else
            {
                //te at
                bool proverkaJivot = false;
                while (currenthp >= 0 && blobglobhp >= 0)
                {
                    currenthp -= (blobglobdmg - def);
                    if (currenthp < 0)
                    {
                        currenthp = 0;
                        proverkaJivot = true;
                        Console.WriteLine($"You got hit by The BlobGlob and took {blobglobdmg - def} DMG");
                        Console.WriteLine($"Your HP is : {currenthp}");
                        break;
                    }
                    Console.WriteLine($"You got hit by The BlobGlob and took {blobglobdmg - def} DMG");
                    Console.WriteLine($"Your HP is = {currenthp}");
                    Console.ReadKey();
                    Console.Clear();
                    // tuka slagame visual modelite

                    blobglobhp -= (dmg - blobglobdef);
                    if (blobglobhp < 0)
                    {
                        blobglobhp = 0;
                        proverkaJivot = false;
                        Console.WriteLine($"You attacked and dealt {dmg - blobglobdef} DMG");
                        Console.WriteLine($"The BlobGlob HP is now = {blobglobhp}");
                        break;
                    }
                    Console.WriteLine($"You attacked and dealt {dmg - blobglobdef} DMG");
                    Console.WriteLine($"The BlobGlob HP = {blobglobhp}");
                    Console.ReadKey();
                    Console.WriteLine();
                }
                if (proverkaJivot == false)
                {
                    Console.WriteLine("You defeated the BlobGlob, Congratulations!");
                    Console.WriteLine("");
                    Console.WriteLine("Press any button to end the game");
                    Console.ReadKey();
                }
                else if (proverkaJivot)
                {
                    Console.WriteLine("The BlobGlob got you. Game over");
                    Environment.Exit(0);
                }
            }

        }

        //buffs
        static void Buffs(int hp, ref int currenthp, ref int dmg, ref int def, ref int atsp )
        {
            Random buff = new Random();
            int randomValue1 = buff.Next(0, 99);
            if (randomValue1 <27)
            {
                currenthp += 215;
                if (currenthp > hp) { currenthp = hp; }
                Console.WriteLine("You received 215 points of hp. Press any button to continue");
                Console.ReadKey();
            }
            else if (randomValue1 < 47)
            {
                atsp += (atsp*33)/100;
                Console.WriteLine("You received atsp buff. Press any button to continue");
                Console.ReadKey();
            }
            else if (randomValue1 < 67)
            {
                def += (def * 25) / 100;
                Console.WriteLine("You received def buff. Press any button to continue");
                Console.ReadKey();
            }
            else if (randomValue1 < 87)
            {
                dmg += (dmg * 10) / 100;
                Console.WriteLine("You received dmg buff. Press any button to continue");
                Console.ReadKey();
            }
            else
            {
                currenthp += 215;
                atsp += (atsp * 33) / 100;
                def += (def * 25) / 100;
                dmg += (dmg * 10) / 100;
                Console.WriteLine("Congratulations, You received the rare buff. Now all of your stats are buffed. Press any button to continue");
                Console.ReadKey();
            }
            
        }

        //swords//
        static void Sword1(ref int dmg)
        {
            dmg = 65;
        }
        static void Sword2(ref int dmg)
        {
            dmg = 70;
        }
        static void Sword3(ref int dmg)
        {
            dmg = 75;
        }
        static void Sword4(ref int dmg)
        {
            dmg = 80;
        }
        static void Sword5(ref int dmg)
        {
            dmg = 90;
        }



        //bows//
        static void Bow1(ref int dmg)
        {
            dmg = 105;
        }
        static void Bow2(ref int dmg)
        {
            dmg = 110;
        }
        static void Bow3(ref int dmg)
        {
            dmg = 115;
        }
        static void Bow4(ref int dmg)
        {
            dmg = 120;
        }
        static void Bow5(ref int dmg)
        {
            dmg = 130;
        }



        //GUTS
        static void Gut1(ref int dmg)
        {
            dmg = 110;
        }
        static void Gut2(ref int dmg)
        {
            dmg = 115;
        }
        static void Gut3(ref int dmg)
        {
            dmg = 120;
        }
        static void Gut4(ref int dmg)
        {
            dmg = 125;
        }
        static void Gut5(ref int dmg)
        {
            dmg = 135;
        }



        //axe
        static void Axe1(ref int dmg)
        {
            dmg = 75;
        }
        static void Axe2(ref int dmg)
        {
            dmg = 80;
        }
        static void Axe3(ref int dmg)
        {
            dmg = 85;
        }
        static void Axe4(ref int dmg)
        {
            dmg = 90;
        }
        static void Axe5(ref int dmg)
        {
            dmg = 100;
        }




        //Spear
        static void Spear1(ref int dmg)
        {
            dmg = 65;
        }
        static void Spear2(ref int dmg)
        {
            dmg = 70;
        }
        static void Spear3(ref int dmg)
        {
            dmg = 75;
        }
        static void Spear4(ref int dmg)
        {
            dmg = 80;
        }
        static void Spear5(ref int dmg)
        {
            dmg = 90;
        }

        static void WeaponBoxGrapth()
        {

        }



    }
}
/*
 *
 *
 *  dmg = 65;
            dmg = 105;
            dmg = 110;
            dmg = 70;
            dmg = 65;
 
da slojim ikoni na mech/luk/berserk/bradva/kopie
 .----------------.  .----------------.  .----------------.  .----------------.  .----------------.
| .--------------. || .--------------. || .--------------. || .--------------. || .--------------. |
| |     __       | || |    _____     | || |    ______    | || |   _    _     | || |   _______    | |
| |    /  |      | || |   / ___ `.   | || |   / ____ `.  | || |  | |  | |    | || |  |  _____|   | |
| |    `| |      | || |  |_/___) |   | || |   `'  __) |  | || |  | |__| |_   | || |  | |____     | |
| |     | |      | || |   .'____.'   | || |   _  |__ '.  | || |  |____   _|  | || |  '_.____''.  | |
| |    _| |_     | || |  / /____     | || |  | \____) |  | || |      _| |_   | || |  | \____) |  | |
| |   |_____|    | || |  |_______|   | || |   \______.'  | || |     |_____|  | || |   \______.'  | |
| |              | || |              | || |              | || |              | || |              | |
| '--------------' || '--------------' || '--------------' || '--------------' || '--------------' |
 '----------------'  '----------------'  '----------------'  '----------------'  '----------------'
 /
buff 
20% dmg
max heal

 
 br =0
sleep 1
br++
consoleclear
cw br
 
 
max hp = 1000
max dmg = 150
max atsp = 100
max def = 50
 
 
Console.WriteLine($"Tvoite statove sa:");
            Console.WriteLine($"HIT POINTS: {hp}");
            Console.WriteLine($"ATTACK SPEED: {atsp} ");
            Console.WriteLine($"DEFENSE: {def}");

                              .
                              ))
        )\\                  //
       _``\`,- '''' ''- ,,,/ /
  .---'a> , < ,<' << ,<, ' / \
  `v^w   ' , << ,< ' <  <  / \
   ````--' \  ,,,---''/ <' //
            !! ;;    ( '  / \
       fL   !!</       \ `\ /
          <</          / /</
                      <</


http://www.heartnsoul.com/ascii_art/swords.txt



 
 
sled vseki fight
imash izbor
 
 
ako dmg==def
defensa se chupi za 1/2 hoda
 
i se regenerira sled tqh
 */
/*
penis
penis
penis
penis
penis
penis
penis
penispenis
penis
penis
penis
penis
penis
penis
penis
penis
penis
penis
penis
penis

Lumberchak - nai mn krit 33%  
archer - 1 na 5
spearman - 1 na 4
sworsman - 1 na 4

*/