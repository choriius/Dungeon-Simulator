using System;
    
  class Program {
        private const int V = 0;

        static void Main(string[] args)
        {
            //Start Menu
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  _____                                        _____ _                 _       _             ");
            Console.WriteLine(" |  __ \\                                      / ____(_)               | |     | |            ");
            Console.WriteLine(" | |  | |_   _ _ __   __ _  ___  ___  _ __   | (___  _ _ __ ___  _   _| | __ _| |_ ___  _ __ ");
            Console.WriteLine(" | |  | | | | | '_ \\ / _` |/ _ \\/ _ \\| '_ \\   \\___ \\| | '_ ` _ \\| | | | |/ _` | __/ _ \\| '__|");
            Console.WriteLine(" | |__| | |_| | | | | (_| |  __| (_) | | | |  ____) | | | | | | | |_| | | (_| | || (_) | |   ");
            Console.WriteLine(" |_____/ \\__,_|_| |_|\\__, |\\___|\\___/|_| |_| |_____/|_|_| |_| |_|\\__,_|_|\\__,_|\\__\\___/|_|      ");
            Console.WriteLine("                      __/ |                                                                   By churro_");
            Console.WriteLine("                     |____/");
            ResetTextWhite();

            Enter();

            Console.WriteLine("  ~  ~  ~  ~  ~  ~  ~  ~  ~  ~  ~  ~  ~  ~  ~  ~  ~  ~  ~  ~  ~  ~  ~  ~  ~  ~  ~  ~  ~  ~  ~  ~  ~  ");

            Random randm = new Random();
            int OpponentAtkIncrease = 0;
            int RegenerateHPExtra = 0;
            int PlayerAttackTimesExtra = 0;

            int Wave = 0;

            Enter();
            Enter();
            ContinueClear();

            //Tip

            Console.WriteLine("  *Tip: Please try to type exactly what is displayed when selecting options.");
            Enter();
            Console.WriteLine("  Like when you're asked to choose 1, 2, or 3, don't put 4...  You know :/");

            Enter();
            Enter();
            ContinueClear();


            //PlayerName

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("  [Door Keeper]: ");
            ResetTextWhite();
            Console.WriteLine("What is your name?");
            Enter();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  *enter your name");
            ResetTextWhite();
            Enter();


            string PlayerName = Console.ReadLine();
            Enter();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("  [Door Keeper]: ");
            ResetTextWhite();

            Console.WriteLine("Welcome, " + PlayerName + ", good luck on your endevours.");
            Enter();
            Enter();

            ContinueClear();

            //Tutorial
            Enter();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" > This is the tutorial for Dungeon Simulator. Do you want to skip? (Y/N)");
            ResetTextWhite();
            Enter();
            Enter();

            //Decides what's displayed based on input (Y/N)
            switch (Console.ReadLine())
            {
                case "Y":
                    Console.WriteLine("  Ok, go on then :D");
                    break;
                case "y":
                    Console.WriteLine("  Ok, go on then :D");
                    break;

                case "N":
                    Console.WriteLine("  Ok, basically, for each \"turn\", you can choose to attack 2 opponents. ");
                    Enter();

                    Console.Write("  Also, press any key to progress when you see \"");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" > Next");
                    ResetTextWhite();
                    Console.WriteLine("\".");
                    Enter();

                    Console.ReadKey();
                    Enter();
                    Enter();

                    Enter();
                    Console.WriteLine("  When attacking your opponents, you can choose which to attack by selecting 1, 2, or 3.");
                    Enter();
                    Console.WriteLine(" - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
                    Enter();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("  1. [Opponent 1]         2. [Opponent 2]         3. [Opponent 3]");
                    ResetTextWhite();

                    Enter();

                    Console.WriteLine("  HP: 8                   HP: 16                  HP: 8");
                    Console.WriteLine("  Atk: 4                  Atk: 2                  Atk: 2");
                    Enter();
                    Console.WriteLine(" - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
                    Enter();
                    Enter();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("  Try it yourself (1, 2, or 3): ");
                    ResetTextWhite();

                    int Tutorialselect1 = Convert.ToInt32(Console.ReadLine());
                    Enter();

                    Console.WriteLine("  Great, you've selected Opponent " + Tutorialselect1 + ".");
                    Enter();
                    Enter();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("  You also have the option to heal by selecting 4 on of your turns.");
                    Enter();
                    Console.WriteLine("  You will heal randomly from 0 - 4 HP. ");
                    ResetTextWhite();

                    Enter();
                    Next();
                    Enter();

                    Console.WriteLine("  You can upgrade your stats every 3 waves, and also access a special upgrade every 9 waves");
                    Enter();
                    Next();
                    Enter();

                    Console.WriteLine("  Also be careful, as you progress in the dungeon, your opponents will get stronger. ");
                    Enter();
                    Console.Write("  Every time you see ");

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(" << Difficulty Increase >>  ");
                    ResetTextWhite();

                    Console.WriteLine(", the Opponents' Atk will increase by 1."); ;


                    Enter();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("  Go ahead and try the real thing now :)");
                    ResetTextWhite();
                    break;

                case "n":
                    Console.WriteLine("  Ok, basically, for each \"turn\", you can choose to attack 2 opponents. ");
                    Enter();

                    Console.Write("  Also, press any key to progress when you see \"");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" > Next");
                    ResetTextWhite();
                    Console.WriteLine("\".");
                    Enter();

                    Console.ReadKey();
                    Enter();
                    Enter();

                    Enter();
                    Console.WriteLine("  When attacking your opponents, you can choose which to attack by selecting 1, 2, or 3.");
                    Enter();
                    Console.WriteLine(" - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
                    Enter();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("  1. [Opponent 1]         2. [Opponent 2]         3. [Opponent 3]");
                    ResetTextWhite();

                    Enter();

                    Console.WriteLine("  HP: 8                   HP: 16                  HP: 8");
                    Console.WriteLine("  Atk: 4                  Atk: 2                  Atk: 2");
                    Enter();
                    Console.WriteLine(" - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
                    Enter();
                    Enter();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("  Try it yourself (1, 2, or 3): ");
                    ResetTextWhite();

                    string Tutorialselect2 = Console.ReadLine();
                    Enter();

                    Console.WriteLine("  Great, you've selected Opponent " + Tutorialselect2 + ".");
                    Enter();
                    Enter();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("  You also have the option to heal by selecting 4 on of your turns.");
                    Enter();
                    Console.WriteLine("  You will heal randomly from 0 - 4 HP. ");
                    ResetTextWhite();

                    Enter();
                    Next();
                    Enter();

                    Console.WriteLine("  You can upgrade your stats every 4 waves, and also access a special upgrade every 12 waves");
                    Enter();
                    Next();
                    Enter();

                    Console.WriteLine("  Also be careful, as you progress in the dungeon, your opponents will get stronger. ");
                    Enter();
                    Console.Write("  Every time you see ");

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(" << Difficulty Increase >>  ");
                    ResetTextWhite();

                    Console.WriteLine(", the Opponents' Atk will increase by 1."); ;


                    Enter();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("  Go ahead and try the real thing now :)");
                    ResetTextWhite();
                    break;

            }

            Enter();
            Enter();
            ContinueClear();

            //CharacterBuild
            Enter();
            Console.WriteLine(" << Select Your Class >>");
            Enter();

            Console.WriteLine(" - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
            Enter();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  1. [Knight]            2. [Wizard]            3. [Archer]   ");
            ResetTextWhite();
            Enter();

            Console.WriteLine("  HP: 40                 HP: 16                 HP: 24");
            Console.WriteLine("  Atk: 8                 Atk: 16                Atk: 4");
            Enter();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("  Attacks                Attacks 1-2 times.      Attacks");
            Console.WriteLine("  2-3 times.             Heals 1 - 6 HP.         4-5 times.");
            Console.WriteLine("                         Acts First.");


            ResetTextWhite();
            Enter();

            Console.WriteLine(" - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");


            Enter();
            Enter();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  *Enter Number (1, 2, or 3)");
            ResetTextWhite();
            Enter();


            int PlayerClassChoice = (int)Convert.ToInt64(Console.ReadLine());
            int PlayerHP = 0;
            int PlayerAtk = 0;
            string PlayerClass = "null";

            //Decides default Stats for each class
            switch (PlayerClassChoice)
            {
                case 1:
                    PlayerHP = 40;
                    PlayerAtk = 8;
                    PlayerClass = "Knight";

                    Enter();
                    Console.WriteLine("  " + PlayerName + ", your class is " + PlayerClass + "; Your HP is " + PlayerHP + ", your atk is " + PlayerAtk + ".");

                    break;

                case 2:
                    PlayerHP = 16;
                    PlayerAtk = 16;
                    PlayerClass = "Wizard";

                    Enter();
                    Console.WriteLine("  " + PlayerName + ", your class is " + PlayerClass + "; Your HP is " + PlayerHP + ", your atk is " + PlayerAtk + ".");

                    break;

                case 3:
                    PlayerHP = 24;
                    PlayerAtk = 4;
                    PlayerClass = "Archer";

                    Enter();
                    Console.WriteLine("  " + PlayerName + ", your class is " + PlayerClass + "; Your HP is " + PlayerHP + ", your atk is " + PlayerAtk + ".");

                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Please select valid class # :(");
                    ResetTextWhite();
                    ContinueClear();
                    break;

            }

            Enter();
            Enter();
            ContinueClear();

            //DungeonDefinedVariables

            int PlayerHPleft = PlayerHP;
            int Round = 1;

            string Opp1 = "null";
            int Opp1HP = 0;
            int Opp1Atk = 0;

            string Opp2 = "null";
            int Opp2HP = 0;
            int Opp2Atk = 0;

            string Opp3 = "null";
            int Opp3HP = 0;
            int Opp3Atk = 0;

            //DungeonStart
            while (PlayerHPleft >= 0)
            {
                Wave++;
                int RoundperWave = 0;


                string[] OpponentType = { "Zombie", "Slime", "Spider", "Witch", "Skeleton ", "Pillager" };
                int OpponentRNG = 0;
                int OpponentHP = 0;
                int OpponentAtk = 0;
                int OpponentTypeNum = 0;

                //OpponentGeneration
                OpponentRNG = randm.Next(0, 6);
                OpponentRandomGen(OpponentRNG, ref OpponentHP, ref OpponentAtk, ref OpponentTypeNum);
                Opp1 = OpponentType[OpponentTypeNum];
                Opp1HP = OpponentHP;
                Opp1Atk = OpponentAtk;
                
                OpponentRNG = randm.Next(0, 6);
                OpponentRandomGen(OpponentRNG, ref OpponentHP, ref OpponentAtk, ref OpponentTypeNum);
                Opp2 = OpponentType[OpponentTypeNum];
                Opp2HP = OpponentHP;
                Opp2Atk = OpponentAtk;

                OpponentRNG = randm.Next(0, 6);
                OpponentRandomGen(OpponentRNG, ref OpponentHP, ref OpponentAtk, ref OpponentTypeNum);
                Opp3 = OpponentType[OpponentTypeNum];
                Opp3HP = OpponentHP;
                Opp3Atk = OpponentAtk;

                //OpponetHP Reset
                int Opp1HPleft = Opp1HP;
                int Opp2HPleft = Opp2HP;
                int Opp3HPleft = Opp3HP;

                //GAME
                while (Opp1HPleft + Opp2HPleft + Opp3HPleft != 0)
                {
                    if (PlayerHPleft <= 0)
                    {
                        break;
                    }

                    Enter();
                    Interface(PlayerName, PlayerHP, PlayerAtk, PlayerClass, PlayerHPleft, Round, Wave);
                    Enter();

                    //Difficulty Increase

                    if (Round % 12 ==0 && Round>= 40)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(" << Difficulty Increase >>  ");
                        ResetTextWhite();
                        Console.WriteLine("Opponent Atk increased by 1. Opponent Hp increased by 2");
                        Enter();
                        OpponentAtkIncrease ++;

                    }

                    else if (Round % 12 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(" << Difficulty Increase >>  ");
                        ResetTextWhite();
                        Console.WriteLine("Opponent Atk increased by 1.");
                        Enter();
                        OpponentAtkIncrease++;

                    }

                    if (Opp1HPleft > 0 && RoundperWave == 0) { Opp1Atk = Opp1Atk + OpponentAtkIncrease; }
                    if (Opp2HPleft > 0 && RoundperWave == 0) { Opp2Atk = Opp2Atk + OpponentAtkIncrease; }
                    if (Opp3HPleft > 0 && RoundperWave == 0) { Opp3Atk = Opp3Atk + OpponentAtkIncrease; }

                    //BattleInterface

                    BattleInterface(Opp1, Opp1HP, Opp1Atk, Opp2, Opp2HP, Opp2Atk, Opp3, Opp3HP, Opp3Atk, Opp1HPleft, Opp2HPleft, Opp3HPleft);

                    Console.WriteLine(" - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");
                    Enter();

                    int OppAttack;
                    int OppAttackValue = 0;

                    //For Wizards
                    if (PlayerClassChoice == 2)
                    {
                        //PlayerAction
                        int PlayerAttackTimes = 0;
                        string PlayerAttackChoice = "0";
                        int PlayerAttackExtra = randm.Next(-1, 2);

                        if (PlayerAttackExtra == -1)
                        {
                            PlayerAttackExtra = 0;
                        }

                        //Decides how many times player attacks according to their class.
                        switch (PlayerClassChoice)
                        {
                            case 1:
                                PlayerAttackTimes = 2 + PlayerAttackExtra + PlayerAttackTimesExtra;

                                break;

                            case 2:
                                PlayerAttackTimes = 1 + PlayerAttackExtra + PlayerAttackTimesExtra;
                                break;

                            case 3:
                                PlayerAttackTimes = 4 + PlayerAttackExtra + PlayerAttackTimesExtra;
                                break;
                        }
                        Enter();

                        //Actions for each turn.

                        for (int PlayerAttackTimesleft = 1; PlayerAttackTimesleft <= PlayerAttackTimes; PlayerAttackTimesleft++)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("  Your Turn " + PlayerAttackTimesleft + "/" + PlayerAttackTimes + ":");
                            ResetTextWhite();
                            Enter();

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("  *Choose Action (1, 2, 3, or 4): ");
                            ResetTextWhite();

                            PlayerAttackChoice = Console.ReadLine();
                            Enter();

                            //Crit Generator
                            int PlayerAttackCrit = randm.Next(-1, 3);

                            if (PlayerAttackCrit <= 0)
                            {
                                PlayerAttackCrit = 0;
                            }

                            //Crit or NoCrit
                            int RegenerateHP = 0;

                            RegenerateHP = randm.Next(2, 5);

                            if (PlayerClassChoice == 3)
                            {
                                RegenerateHP = randm.Next(1, 9);
                            }

                            RegenerateHP = RegenerateHP + RegenerateHPExtra;


                            switch (PlayerAttackCrit)
                            {
                                case 0:
                                    //No Crit 
                                    switch (PlayerAttackChoice)
                                    {
                                        case "1":
                                            Console.WriteLine("You attacked The " + Opp1 + ", dealt " + PlayerAtk + " damage.");

                                            Opp1HPleft = Opp1HPleft - PlayerAtk;
                                            Opp1HPleft = Opp1HPleft - PlayerAttackCrit;
                                            break;

                                        case "2":
                                            Console.WriteLine("You attacked The " + Opp2 + ", dealt " + PlayerAtk + " damage.");

                                            Opp2HPleft = Opp2HPleft - PlayerAtk;
                                            Opp2HPleft = Opp2HPleft - PlayerAttackCrit;
                                            break;

                                        case "3":
                                            Console.WriteLine("You attacked The " + Opp3 + ", dealt " + PlayerAtk + " damage.");

                                            Opp3HPleft = Opp3HPleft - PlayerAtk;
                                            Opp3HPleft = Opp3HPleft - PlayerAttackCrit;
                                            break;

                                        //heal
                                        case "4":
                                            PlayerHPleft = PlayerHPleft + RegenerateHP;

                                            Console.WriteLine("You chose to heal. " + RegenerateHP + " HP regenerated");
                                            break;

                                        default:
                                            Console.WriteLine("  Please choose a valid opponent number. Turn skipped.");
                                            break;
                                    }

                                    break;

                                default:
                                    //Default Attack + Crit
                                    switch (PlayerAttackChoice)
                                    {
                                        case "1":
                                            Console.WriteLine("You attacked The " + Opp1 + ", dealt " + PlayerAtk + " + " + PlayerAttackCrit + " damage.");

                                            Opp1HPleft = Opp1HPleft - PlayerAtk;
                                            Opp1HPleft = Opp1HPleft - PlayerAttackCrit;
                                            break;

                                        case "2":
                                            Console.WriteLine("You attacked The " + Opp2 + ", dealt " + PlayerAtk + " + " + PlayerAttackCrit + " damage.");

                                            Opp2HPleft = Opp2HPleft - PlayerAtk;
                                            Opp2HPleft = Opp2HPleft - PlayerAttackCrit;
                                            break;

                                        case "3":
                                            Console.WriteLine("You attacked The " + Opp3 + ", dealt " + PlayerAtk + " + " + PlayerAttackCrit + " damage.");

                                            Opp3HPleft = Opp3HPleft - PlayerAtk;
                                            Opp3HPleft = Opp3HPleft - PlayerAttackCrit;
                                            break;

                                        //heal
                                        case "4":
                                            PlayerHPleft = PlayerHPleft + RegenerateHP;

                                            Console.WriteLine("You chose to heal. " + RegenerateHP + " HP regenerated");
                                            break;

                                        default:
                                            Console.WriteLine("  Please choose a valid opponent number. Turn skipped.");
                                            break;
                                    }

                                    break;
                            }

                            Enter();


                        }
                        Enter();

                    }

                    //DeadOpponents
                    if (Opp1HPleft <= 0)
                    {
                        Opp1HPleft = 0;
                        Opp1Atk = 0;
                    }
                    if (Opp2HPleft <= 0)
                    {
                        Opp2HPleft = 0;
                        Opp2Atk = 0;
                    }
                    if (Opp3HPleft <= 0)
                    {
                        Opp3HPleft = 0;
                        Opp3Atk = 0;
                    }

                    //OpponentAttack

                    int RoundTurnsGen = 1;
                    RoundTurnsGen = randm.Next(1, 3);

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("   << Opponent Turn >>");
                    ResetTextWhite();
                    Enter();

                    for (int RoundTurns = 1; RoundTurns <= RoundTurnsGen; RoundTurns++)
                    {
                        if (PlayerHPleft <= 0)
                        {
                            break;
                        }

                        //Randoml generates 4 different attack scenario.
                        OppAttack = randm.Next(1, 5);

                        switch (OppAttack)
                        {
                            case 1:
                                OppAttackValue = Opp1Atk;
                                PlayerHPleft -= OppAttackValue;

                                Console.WriteLine("  1. [" + Opp1 + "] dealt " + Opp1Atk + " damage.");

                                Enter();
                                break;

                            case 2:
                                OppAttackValue = Opp2Atk;
                                PlayerHPleft -= OppAttackValue;

                                Console.WriteLine("  2. [" + Opp2 + "] dealth " + Opp2Atk + " damage.");

                                Enter();
                                break;

                            case 3:
                                OppAttackValue = Opp3Atk;
                                PlayerHPleft -= OppAttackValue;


                                Console.WriteLine("  3. [" + Opp3 + "] dealth " + Opp3Atk + " damage.");

                                Enter();
                                break;

                            case 4:
                                OppAttackValue = 0;
                                PlayerHPleft -= OppAttackValue;

                                Console.WriteLine("  4. The incomming attack missed! No damage dealt.");
                                Enter();
                                break;
                        }

                        Enter();
                    }

                    if (PlayerClassChoice == 2) { Next(); }

                    //For Knights and Archers
                    if (PlayerClassChoice == 1 || PlayerClassChoice == 3)
                    {
                        //PlayerAction
                        int PlayerAttackTimes = 0;
                        string PlayerAttackChoice = "0";
                        int PlayerAttackExtra = randm.Next(-1, 2);

                        if (PlayerAttackExtra == -1)
                        {
                            PlayerAttackExtra = 0;
                        }

                        //Decides how many times player attacks according to their class.
                        switch (PlayerClassChoice)
                        {
                            case 1:
                                PlayerAttackTimes = 2 + PlayerAttackExtra + PlayerAttackTimesExtra;

                                break;

                            case 2:
                                PlayerAttackTimes = 1 + PlayerAttackExtra + PlayerAttackTimesExtra;
                                break;

                            case 3:
                                PlayerAttackTimes = 4 + PlayerAttackExtra + PlayerAttackTimesExtra;
                                break;
                        }
                        Enter();

                        //Actions for each turn.

                        for (int PlayerAttackTimesleft = 1; PlayerAttackTimesleft <= PlayerAttackTimes; PlayerAttackTimesleft++)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("  Your Turn " + PlayerAttackTimesleft + "/" + PlayerAttackTimes + ":");
                            ResetTextWhite();
                            Enter();

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("  *Choose Action (1, 2, 3, or 4): ");
                            ResetTextWhite();

                            PlayerAttackChoice = Console.ReadLine();
                            Enter();

                            //Crit Generator
                            int PlayerAttackCrit = randm.Next(-1, 3);

                            if (PlayerAttackCrit <= 0)
                            {
                                PlayerAttackCrit = 0;
                            }

                            //Crit or NoCrit
                            int RegenerateHP = 0;

                            if (PlayerClassChoice == 3)
                            {
                                RegenerateHP = randm.Next(1, 7);
                            }

                            RegenerateHP = randm.Next(1, 5);
                            RegenerateHP = RegenerateHP + RegenerateHPExtra;


                            switch (PlayerAttackCrit)
                            {
                                case 0:
                                    //No Crit 
                                    switch (PlayerAttackChoice)
                                    {
                                        case "1":
                                            Console.WriteLine("You attacked The " + Opp1 + ", dealt " + PlayerAtk + " damage.");

                                            Opp1HPleft = Opp1HPleft - PlayerAtk;
                                            Opp1HPleft = Opp1HPleft - PlayerAttackCrit;
                                            break;

                                        case "2":
                                            Console.WriteLine("You attacked The " + Opp2 + ", dealt " + PlayerAtk + " damage.");

                                            Opp2HPleft = Opp2HPleft - PlayerAtk;
                                            Opp2HPleft = Opp2HPleft - PlayerAttackCrit;
                                            break;

                                        case "3":
                                            Console.WriteLine("You attacked The " + Opp3 + ", dealt " + PlayerAtk + " damage.");

                                            Opp3HPleft = Opp3HPleft - PlayerAtk;
                                            Opp3HPleft = Opp3HPleft - PlayerAttackCrit;
                                            break;

                                        //heal
                                        case "4":
                                            PlayerHPleft = PlayerHPleft + RegenerateHP;

                                            Console.WriteLine("You chose to heal. " + RegenerateHP + " HP regenerated");
                                            break;

                                        default:
                                            Console.WriteLine("  Please choose a valid opponent number. Turn skipped.");
                                            break;
                                    }

                                    break;

                                default:
                                    //Default Attack + Crit
                                    switch (PlayerAttackChoice)
                                    {
                                        case "1":
                                            Console.WriteLine("You attacked The " + Opp1 + ", dealt " + PlayerAtk + " + " + PlayerAttackCrit + " damage.");

                                            Opp1HPleft = Opp1HPleft - PlayerAtk;
                                            Opp1HPleft = Opp1HPleft - PlayerAttackCrit;
                                            break;

                                        case "2":
                                            Console.WriteLine("You attacked The " + Opp2 + ", dealt " + PlayerAtk + " + " + PlayerAttackCrit + " damage.");

                                            Opp2HPleft = Opp2HPleft - PlayerAtk;
                                            Opp2HPleft = Opp2HPleft - PlayerAttackCrit;
                                            break;

                                        case "3":
                                            Console.WriteLine("You attacked The " + Opp3 + ", dealt " + PlayerAtk + " + " + PlayerAttackCrit + " damage.");

                                            Opp3HPleft = Opp3HPleft - PlayerAtk;
                                            Opp3HPleft = Opp3HPleft - PlayerAttackCrit;
                                            break;

                                        //heal
                                        case "4":
                                            PlayerHPleft = PlayerHPleft + RegenerateHP;

                                            Console.WriteLine("You chose to heal. " + RegenerateHP + " HP regenerated");
                                            break;

                                        default:
                                            Console.WriteLine("  Please choose a valid opponent number. Turn skipped.");
                                            break;
                                    }

                                    break;
                            }

                            Enter();


                        }

                    }

                    //DeadOpponents
                    if (Opp1HPleft <= 0)
                    {
                        Opp1HPleft = 0;
                        Opp1Atk = 0;
                    }
                    if (Opp2HPleft <= 0)
                    {
                        Opp2HPleft = 0;
                        Opp2Atk = 0;
                    }
                    if (Opp3HPleft <= 0)
                    {
                        Opp3HPleft = 0;
                        Opp3Atk = 0;
                    }

                    //Round Ended
                    if (PlayerHPleft >= PlayerHP)
                    {
                        PlayerHPleft = PlayerHP;
                    }

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("  << Round ended. Your health is at " + PlayerHPleft + " >>");
                    ResetTextWhite();
                    Enter();
                    Enter();
                    ContinueClear();

                    //PlayerUpgrade

                        if (Wave % 3 == 0 && RoundperWave == 0)
                        {
                            Enter();
                            Console.WriteLine("  Current Stat:");
                            Enter();
                            Interface(PlayerName, PlayerHP, PlayerAtk, PlayerClass, PlayerHPleft, Round, Wave);
                            Enter();
                            Console.WriteLine("   Would you like to increase your HP cap or Atk? ");
                            Enter();

                            switch (Console.ReadLine())

                            {
                                case "hp":
                                    Enter();
                                    PlayerHP += 2;
                                    PlayerHPleft += 2;
                                    Console.WriteLine("  Your HP has increased by 2.");
                                    break;

                                case "HP":
                                    Enter();
                                    PlayerHP += 2;
                                    PlayerHPleft += 2;
                                    Console.WriteLine("  Your HP has increased by 2.");
                                    break;

                                case "atk":
                                    Enter();
                                    PlayerAtk++;
                                    Console.WriteLine("Your Atk has increased by 1.");
                                    break;

                                case "Atk":
                                    Enter();
                                    PlayerAtk++;
                                    Console.WriteLine("Your Atk has increased by 1.");
                                    break;
                            }

                            Enter();
                            Console.WriteLine("  New Stat:");
                            Enter();
                            Interface(PlayerName, PlayerHP, PlayerAtk, PlayerClass, PlayerHPleft, Round, Wave);
                            Enter();

                            ContinueClear();

                            //SpecialUpgrade
                            if (Wave % 9 == 0)
                            {

                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write(" << Special Upgrade >>");
                                ResetTextWhite();
                                Console.WriteLine("  Select the upgrade you want: ");
                                Enter();

                                Console.WriteLine("   1. Increase # of Turns    2. Decrease Opponent Atk");
                                Enter();
                                Console.WriteLine("   3. Increase Heal Amount    4. Heal to full health");
                                Enter();

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                switch (Console.ReadLine())
                                {
                                    case "1":
                                        PlayerAttackTimesExtra++;
                                        Enter();

                                        Console.WriteLine("  You can now attack 1 more times.");
                                        break;

                                    case "2":
                                        OpponentAtkIncrease -= 2;
                                        Enter();

                                        Console.WriteLine("  Opponent Atk has been decreased by 2.");
                                        break;

                                    case "3":
                                        RegenerateHPExtra += 2;
                                        Enter();

                                        Console.WriteLine("  You can now heal 2 more HP on average.");
                                        break;

                                    case "4":
                                        PlayerHPleft = PlayerHP;
                                        Enter();

                                        Console.WriteLine("  You have been healed to full health.");
                                        break;

                                    default:
                                        Console.WriteLine("  Please choose a valid #.");
                                        break;

                                }
                                ResetTextWhite();
                                Enter();
                                Enter();
                                ContinueClear();
                            }
                        }

                    Round++;
                    RoundperWave++;

                    //slime

                    if (Opp1 == "Slime" && Opp1HPleft > 0 && Wave >= 4)
                    {
                        Opp1Atk++;
                    }
                    if (Opp2 == "Slime" && Opp2HPleft > 0 && Wave >= 4)
                    {
                        Opp2Atk++;
                    }
                    if (Opp3 == "Slime" && Opp3HPleft > 0 && Wave >= 4)
                    {
                        Opp3Atk++;
                    }

                    if (PlayerHPleft <= 0 || Opp1HPleft + Opp2HPleft + Opp3HPleft == 0)
                    {
                        break;
                    }
                }

            }

            //End of Game
            Enter();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  You died. . .   You reached round " + Round + ".");
            Enter();
            Console.WriteLine("  You reached wave " + Wave); 
            Enter();
            ContinueClear();
        }

        private static void ResetTextWhite()
        {
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void BattleInterface(string Opp1, int Opp1HP, int Opp1Atk, string Opp2, int Opp2HP, int Opp2Atk, string Opp3, int Opp3HP, int Opp3Atk, int Opp1HPleft, int Opp2HPleft, int Opp3HPleft)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  1. [" + Opp1 + "]          2. [" + Opp2 + "]          3. [" + Opp3 + "]   ");
            Console.ForegroundColor = ConsoleColor.White;
            Enter();

            Console.WriteLine("  HP: " + Opp1HPleft + "/" + Opp1HP + "               HP: " + Opp2HPleft + "/" + Opp2HP + "               HP: " + Opp3HPleft + "/" + Opp3HP);
            Console.WriteLine("  Atk: " + Opp1Atk + "                  Atk: " + Opp2Atk + "                  Atk: " + Opp3Atk);
            Enter();

        }

        //Displays the upper part of interface with player info.
        private static void Interface(string PlayerName, int PlayerHP, int PlayerAtk, string PlayerClass, int PlayerHPleft, int Round, int Wave)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("  [" + PlayerName + "]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("  -  " + PlayerClass + "                        ");

            Console.Write("  HP: " + PlayerHPleft + "/" + PlayerHP + "     ");

            Console.WriteLine("  Atk:" + PlayerAtk);
            Enter();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("  Round " + Round + "                                                   Wave " + Wave);
            Console.ForegroundColor = ConsoleColor.White;
            Enter();

            Console.WriteLine(" - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - ");

        }

        private static void OpponentRandomGen(int OpponentRNG, ref int OpponentHP, ref int OpponentAtk, ref int OpponentTypeNum)
        {
            switch (OpponentRNG)
            {
                case 0:
                    //zombie
                    OpponentTypeNum = 0;
                    OpponentHP = 24;
                    OpponentAtk = 2;
                    break;

                case 1:
                    //slime
                    OpponentTypeNum = 1;
                    OpponentHP = 32;
                    OpponentAtk = 1;
                    break;

                case 2:
                    //cave spider
                    OpponentTypeNum = 2;
                    OpponentHP = 8;
                    OpponentAtk = 4;
                    break;

                case 3:
                    //witch
                    OpponentTypeNum = 3;
                    OpponentHP = 12;
                    OpponentAtk = 8;
                    break;

                case 4:
                    //skeleton
                    OpponentTypeNum = 4;
                    OpponentHP = 16;
                    OpponentAtk = 1;
                    break;

                case 5:
                    //pillager
                    OpponentTypeNum = 5;
                    OpponentHP = 16;
                    OpponentAtk = 4;
                    break;
            }
        }

        //Skips a line displayed in console.
        private static void Enter()
        {
            Console.WriteLine("");
        }
        
        //Press any key to continue to next section, and clears the console of text.
        private static void ContinueClear()
        {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(" >  Press any key to Continue ");
                Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
            Console.Clear();
                Enter();
        }

        //Press any key to continue to next part, but doesn't clear the console of text.
        private static void Next()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" >  Next");
            Console.ForegroundColor = ConsoleColor.White;
            Enter();
            Console.ReadKey();
            Enter();
        }
}
