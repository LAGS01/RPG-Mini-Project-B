using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Mini_Project_B {
    public class WinScreen {
        public void Screen() {
            Console.ForegroundColor = ConsoleColor.Green;
            string winScreen = @"██╗   ██╗ ██████╗ ██╗   ██╗     █████╗ ██████╗ ███████╗    ██╗    ██╗██╗███╗   ██╗███╗   ██╗███████╗██████╗ ██╗
╚██╗ ██╔╝██╔═══██╗██║   ██║    ██╔══██╗██╔══██╗██╔════╝    ██║    ██║██║████╗  ██║████╗  ██║██╔════╝██╔══██╗██║
 ╚████╔╝ ██║   ██║██║   ██║    ███████║██████╔╝█████╗      ██║ █╗ ██║██║██╔██╗ ██║██╔██╗ ██║█████╗  ██████╔╝██║
  ╚██╔╝  ██║   ██║██║   ██║    ██╔══██║██╔══██╗██╔══╝      ██║███╗██║██║██║╚██╗██║██║╚██╗██║██╔══╝  ██╔══██╗╚═╝
   ██║   ╚██████╔╝╚██████╔╝    ██║  ██║██║  ██║███████╗    ╚███╔███╔╝██║██║ ╚████║██║ ╚████║███████╗██║  ██║██╗
   ╚═╝    ╚═════╝  ╚═════╝     ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝     ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝╚═╝  ╚═══╝╚══════╝╚═╝  ╚═╝╚═╝
";
            foreach (string line in winScreen.Split(Environment.NewLine)) {
                Console.WriteLine(line);
                Thread.Sleep(1);
            }
            Console.ResetColor();
        }
    }
}