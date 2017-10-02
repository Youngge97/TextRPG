using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGtextgame
{
    class Art
    {
        public void knight()
        {
            string knight = @"
                                 _A_
                                / | \
                               |.-=-.|
                               )\_|_/(
                            .=='\   /`==.
                          .'\   (`:')   /`.
                        _/_ |_.-' : `-._|__\_
                       <___>'\    :   / `<___>
                       /  /   >=======<  /  /
                     _/ .'   /  ,-:-.  \/=,'
                    / _/    |__/v^v^v\__) \
                    \(\)     |V^V^V^V^V|\_/
                     (\\     \`---|---'/
                       \\     \-._|_,-/
                        \\     |__|__|
                         \\   <___X___>
                          \\   \..|../
                           \\   \ | /
                            \\  /V|V\
                             \|/  |  \
                              '--' `--`  
";

            Console.WriteLine(knight);
        }
    }
}
