﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AgeOfVillagers
{
    class OpenVillage : ICommand
    {
        public void execute()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            FileStream fs = (FileStream)openFileDialog1.OpenFile();
            using (StreamReader sr = new StreamReader(fs))
            {
                JsonSerializer serializer = new JsonSerializer();
                //VillageState state = new VillageState();
                serializer.Deserialize(sr, null);
            }
        }
    }
}
