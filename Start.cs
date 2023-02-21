namespace RPG_Mini_Project_B {
    class Start {
        static void Main(){
            Console.WriteLine(@"
                                 __  ____  __ _    _  _  _  _   __  ____    ____  __  
                                (  )(    \(  / )  / )( \/ )( \ / _\(_  _)  (_  _)/  \ 
                                 )(  ) D ( )  (   \ /\ /) __ (/    \ )(      )( (  O )
                                (__)(____/(__\_)  (_/\_)\_)(_/\_/\_/(__)    (__) \__/ 
                                     ___   __   __    __      ____  _  _  __  ____        
                                    / __) / _\ (  )  (  )    (_  _)/ )( \(  )/ ___)       
                                   ( (__ /    \/ (_/\/ (_/\    )(  ) __ ( )( \___ \       
                                    \___)\_/\_/\____/\____/   (__) \_)(_/(__)(____/       
                                                  ___   __   _  _  ____                                
                                                 / __) / _\ ( \/ )(  __)                               
                                                ( (_ \/    \/ \/ \ ) _)                                
                                                 \___/\_/\_/\_)(_/(____)   

                                                                                                            
                                                        >_ New Game
                                                        >  Continue"
            );
            
            
            Console.WriteLine("New Game? (y/n)");
            string user = Console.ReadLine().ToLower();
            if (user == "y") {
                Intro();
            }
            else {
                Environment.Exit(0);
            }
        }

        static void Intro() {
            string dialogue = @"

'Hello?!
Hellooooooo!
...
Anybody here? Please help!'";
            for (int i = 0; i<dialogue.Length; i++) {
                Console.Write(dialogue[i]);
                System.Threading.Thread.Sleep(40);
            }
            System.Threading.Thread.Sleep(500);
            dialogue = @"

You're woken up by various people yelling for help.
You get out of the house to see what is going on.
The yelling seems to come from town square. Two men come
storming your way.";
            for (int i = 0; i<dialogue.Length; i++) {
                Console.Write(dialogue[i]);
                System.Threading.Thread.Sleep(40);
            }
            System.Threading.Thread.Sleep(500);
            dialogue = @"

'You! Please we need thy help! The people of our town
have been terrorized by giant spiders, no one dares to
leave their house anymore!'";
            for (int i = 0; i<dialogue.Length; i++) {
                Console.Write(dialogue[i]);
                System.Threading.Thread.Sleep(40);
            }
            System.Threading.Thread.Sleep(500);
            dialogue = @"

As you heard, the people of this town have been
terrorized by enormous spiders. It is your task to help
the people regain the upperhand over their town again.";
            for (int i = 0; i<dialogue.Length; i++) {
                Console.Write(dialogue[i]);
                System.Threading.Thread.Sleep(40);
            }
            System.Threading.Thread.Sleep(500);
            // Location.Townsquare(); ignore this tbh lol :p
            // Van hier > naar Lucy's map (start in house)
        }
    }
}