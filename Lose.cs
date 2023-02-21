using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RPG_Mini_Project_B {
    public class Lose {
        public void LoseScreen() {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            string loseScreen = @"▓██   ██▓ ▒█████   █    ██     ▄▄▄       ██▀███  ▓█████     ██▓     ▒█████    ██████ ▓█████  ██▀███   ▐██▌ 
 ▒██  ██▒▒██▒  ██▒ ██  ▓██▒   ▒████▄    ▓██ ▒ ██▒▓█   ▀    ▓██▒    ▒██▒  ██▒▒██    ▒ ▓█   ▀ ▓██ ▒ ██▒ ▐██▌ 
  ▒██ ██░▒██░  ██▒▓██  ▒██░   ▒██  ▀█▄  ▓██ ░▄█ ▒▒███      ▒██░    ▒██░  ██▒░ ▓██▄   ▒███   ▓██ ░▄█ ▒ ▐██▌ 
  ░ ▐██▓░▒██   ██░▓▓█  ░██░   ░██▄▄▄▄██ ▒██▀▀█▄  ▒▓█  ▄    ▒██░    ▒██   ██░  ▒   ██▒▒▓█  ▄ ▒██▀▀█▄   ▓██▒ 
  ░ ██▒▓░░ ████▓▒░▒▒█████▓     ▓█   ▓██▒░██▓ ▒██▒░▒████▒   ░██████▒░ ████▓▒░▒██████▒▒░▒████▒░██▓ ▒██▒ ▒▄▄  
   ██▒▒▒ ░ ▒░▒░▒░ ░▒▓▒ ▒ ▒     ▒▒   ▓▒█░░ ▒▓ ░▒▓░░░ ▒░ ░   ░ ▒░▓  ░░ ▒░▒░▒░ ▒ ▒▓▒ ▒ ░░░ ▒░ ░░ ▒▓ ░▒▓░ ░▀▀▒ 
 ▓██ ░▒░   ░ ▒ ▒░ ░░▒░ ░ ░      ▒   ▒▒ ░  ░▒ ░ ▒░ ░ ░  ░   ░ ░ ▒  ░  ░ ▒ ▒░ ░ ░▒  ░ ░ ░ ░  ░  ░▒ ░ ▒░ ░  ░ 
 ▒ ▒ ░░  ░ ░ ░ ▒   ░░░ ░ ░      ░   ▒     ░░   ░    ░        ░ ░   ░ ░ ░ ▒  ░  ░  ░     ░     ░░   ░     ░ 
 ░ ░         ░ ░     ░              ░  ░   ░        ░  ░       ░  ░    ░ ░        ░     ░  ░   ░      ░    
 ░ ░                                                                                                       
";
            foreach (string line in loseScreen.Split(Environment.NewLine)) {
                Console.WriteLine(line);
                Thread.Sleep(1);
            }
            Console.ResetColor();
        }
    }
}