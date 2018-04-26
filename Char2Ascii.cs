using System;
using System.Collections.Generic;

namespace fc_tetris_core
{
    public static class Char2Ascii
    {
        /***
        *     _____   __    _____   _____     ___   _____    ____   ______  _____   _____                                                                                                                                     
        *    |  _  | /  |  / __  \ |____ |   /   | |  ___|  / ___| |___  / |  _  | |  _  |                                                                                                                                    
        *    | |/' | `| |  `' / /'     / /  / /| | |___ \  / /___     / /   \ V /  | |_| |                                                                                                                                    
        *    |  /| |  | |    / /       \ \ / /_| |     \ \ | ___ \   / /    / _ \  \____ |                                                                                                                                    
        *    \ |_/ / _| |_ ./ /___ .___/ / \___  | /\__/ / | \_/ | ./ /    | |_| | .___/ /                                                                                                                                    
        *     \___/  \___/ \_____/ \____/      |_/ \____/  \_____/ \_/     \_____/ \____/                                                                                                                                     
        *                                                                                                                                                                                                                     
        *                                                                                                                                                                                                                     
        *             _                  _           __           _       _     _   _      _                                                            _                                                                     
        *            | |                | |         / _|         | |     (_)   (_) | |    | |                                                          | |                                                                    
        *      __ _  | |__     ___    __| |   ___  | |_    __ _  | |__    _     _  | | __ | |  _ __ ___    _ __     ___    _ __     __ _   _ __   ___  | |_   _   _  __   __ __  __ __      __  _   _   ____                  
        *     / _` | | '_ \   / __|  / _` |  / _ \ |  _|  / _` | | '_ \  | |   | | | |/ / | | | '_ ` _ \  | '_ \   / _ \  | '_ \   / _` | | '__| / __| | __| | | | | \ \ / / \ \/ / \ \ /\ / / | | | | |_  /                  
        *    | (_| | | |_) | | (__  | (_| | |  __/ | |   | (_| | | | | | | |   | | |   <  | | | | | | | | | | | | | (_) | | |_) | | (_| | | |    \__ \ | |_  | |_| |  \ V /   >  <   \ V  V /  | |_| |  / /                   
        *     \__,_| |_.__/   \___|  \__,_|  \___| |_|    \__, | |_| |_| |_|   | | |_|\_\ |_| |_| |_| |_| |_| |_|  \___/  | .__/   \__, | |_|    |___/  \__|  \__,_|   \_/   /_/\_\   \_/\_/    \__, | /___|                  
        *                                                  __/ |              _/ |                                        | |         | |                                                        __/ |                        
        *                                                 |___/              |__/                                         |_|         |_|                                                       |___/                         
        *      ___   ______   _____  ______   _____  ______   _____   _   _   _____     ___   _   __  _      ___  ___  _   _   _____  ______   _____  ______   _____   _____   _   _   _   _  __   __  _    _  __   __  ______
        *     / _ \  | ___ \ /  __ \ |  _  \ |  ___| |  ___| |  __ \ | | | | |_   _|   |_  | | | / / | |     |  \/  | | \ | | |  _  | | ___ \ |  _  | | ___ \ /  ___| |_   _| | | | | | | | | \ \ / / | |  | | \ \ / / |___  /
        *    / /_\ \ | |_/ / | /  \/ | | | | | |__   | |_    | |  \/ | |_| |   | |       | | | |/ /  | |     | .  . | |  \| | | | | | | |_/ / | | | | | |_/ / \ `--.    | |   | | | | | | | |  \ V /  | |  | |  \ V /     / / 
        *    |  _  | | ___ \ | |     | | | | |  __|  |  _|   | | __  |  _  |   | |       | | |    \  | |     | |\/| | | . ` | | | | | |  __/  | | | | |    /   `--. \   | |   | | | | | | | |  /   \  | |/\| |   \ /     / /  
        *    | | | | | |_/ / | \__/\ | |/ /  | |___  | |     | |_\ \ | | | |  _| |_  /\__/ / | |\  \ | |____ | |  | | | |\  | \ \_/ / | |     \ \/' / | |\ \  /\__/ /   | |   | |_| | \ \_/ / / /^\ \ \  /\  /   | |   ./ /___
        *    \_| |_/ \____/   \____/ |___/   \____/  \_|      \____/ \_| |_/  \___/  \____/  \_| \_/ \_____/ \_|  |_/ \_| \_/  \___/  \_|      \_/\_\ \_| \_| \____/    \_/    \___/   \___/  \/   \/  \/  \/    \_/   \_____/
        *                                                                                                                                                                                                                     
        *                                                                                                                                                                                                                     
        */

        /// <summary>
        /// Print a char c on x,y position
        /// </summary>
        /// <param name="c">Character to print</param>
        /// <param name="x">Initial X position</param>
        /// <param name="y">Initial Y position</param>
        public static void drawChar(char c, int x, int y){
            // TODO: Implement String Printing
            // TODO: Implement all characters
            List<string> Lines = new List<string>();
            switch (c)
            {
                case '0':
                    Lines.Add(" _____ ");
                    Lines.Add("|  _  |");
                    Lines.Add("| |/' |");
                    Lines.Add("|  /| |");
                    Lines.Add("\\ |_/ /");
                    Lines.Add(" \\___/ ");
                    break;
                case '1':
                    Lines.Add(" __  ");
                    Lines.Add("/  | ");
                    Lines.Add("`| | ");
                    Lines.Add(" | | ");
                    Lines.Add("_| |_");
                    Lines.Add("\\___/");
                    break;
                case '2':
                    Lines.Add(" _____ ");
                    Lines.Add("/ __  \\");
                    Lines.Add("`' / /'");
                    Lines.Add("  / /  ");
                    Lines.Add("./ /___");
                    Lines.Add("\\_____/");
                    break;
                case '3':
                    Lines.Add(" _____ ");
                    Lines.Add("|____ |");
                    Lines.Add("    / /");
                    Lines.Add("    \\ \\");
                    Lines.Add(".___/ /");
                    Lines.Add("\\____/ ");
                    break;
                case '4':

                    Lines.Add("   ___ ");
                    Lines.Add("  /   |");
                    Lines.Add(" / /| |");
                    Lines.Add("/ /_| |");
                    Lines.Add("\\___  |");
                    Lines.Add("    |_/");
                    break;
                case '5':
                    Lines.Add(" _____ ");
                    Lines.Add("|  ___|");
                    Lines.Add("|___ \\ ");
                    Lines.Add("    \\ \\");
                    Lines.Add("/\\__/ /");
                    Lines.Add("\\____/ ");
                    break;
                case '6':
                    Lines.Add("  ____ ");
                    Lines.Add(" / ___|");
                    Lines.Add("/ /___ ");
                    Lines.Add("| ___ \\");
                    Lines.Add("| \\_/ |");
                    Lines.Add("\\_____/");
                    break;
                case '7':
                    Lines.Add(" ______");
                    Lines.Add("|___  /");
                    Lines.Add("   / / ");
                    Lines.Add("  / /  ");
                    Lines.Add("./ /   ");
                    Lines.Add("\\_/    ");
                    break;
                case '8':
                    Lines.Add(" _____ ");
                    Lines.Add("|  _  |");
                    Lines.Add(" \\ V / ");
                    Lines.Add(" / _ \\ ");
                    Lines.Add("| |_| |");
                    Lines.Add("\\_____/");
                    break;
                case '9':
                    Lines.Add(" _____ ");
                    Lines.Add("|  _  |");
                    Lines.Add("| |_| |");
                    Lines.Add("\\____ |");
                    Lines.Add(".___/ /");
                    Lines.Add("\\____/ ");
                    break;
                case 'A':
                    Lines.Add("");
                    break;
                case 'B':
                    Lines.Add("");
                    break;
                case 'C':
                    Lines.Add("");
                    break;
                case 'D':
                    Lines.Add("");
                    break;
                case 'E':
                    Lines.Add("");
                    break;
                case 'F':
                    Lines.Add("");
                    break;
                case 'G':
                    Lines.Add("");
                    break;
            }

            for (int i = 0; i < Lines.Count; i++)
            {
                Console.SetCursorPosition(x, y + i);
                System.Console.Write(Lines[i]);
            }

        }
    }
}