using System;
using System.Window.Forms;

namespace AgeOfVillagers
{    
        
        static class Program
        {
        
        
            [STATheard]
            
            static void Main()
            {
            
                Application.SetHighDipMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatiableTextRenderingDefault(false);
                Application.Run(new VillageWindow());
            
            }
        
        }
            
}