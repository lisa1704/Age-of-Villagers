using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_Of_Villagers
{
    public interface INation
    {
        void setTerrain(VillageEditorWindow villageEditor);
        void setRadiobutton(VillageEditorWindow villageEditor);
        string getColor();

    }

    public class BangladeshiNation : INation
    {
        public string getColor()
        {
            return "green";
        }

        public void setRadiobutton(VillageEditorWindow villageEditor)
        {
            villageEditor.rdButtonHouse.Enabled = true;
            villageEditor.rdButtonTree.Enabled = true;
            villageEditor.rdButtonWaterSrc.Enabled = true;

        }

        public void setTerrain(VillageEditorWindow villageEditor)
        {
            villageEditor.Panel1.BackColor = Color.Green;
        }
    }

    public class ArabBedouinNation : INation
    {
        public string getColor()
        {
            throw new NotImplementedException();
        }

        public void setRadiobutton(VillageEditorWindow villageEditor)
        {
            villageEditor.rdButtonHouse.Enabled = true;
            villageEditor.rdButtonTree.Enabled = true;
            villageEditor.rdButtonWaterSrc.Enabled = false;

        }

        public void setTerrain(VillageEditorWindow villageEditor)
        {
            villageEditor.Panel1.BackColor = Color.YellowGreen;
        }
    }
    public class EgyptianKingNation : INation
    {
        public string getColor()
        {
            throw new NotImplementedException();
        }

        public void setRadiobutton(VillageEditorWindow villageEditor)
        {
            villageEditor.rdButtonHouse.Enabled = true;
            villageEditor.rdButtonTree.Enabled = true;
            villageEditor.rdButtonWaterSrc.Enabled = true;

        }

        public void setTerrain(VillageEditorWindow villageEditor)
        {
            villageEditor.Panel1.BackColor = Color.Yellow;
        }
    }

    public class InuitHunterNation : INation
    {
        public string getColor()
        {
            throw new NotImplementedException();
        }

        public void setRadiobutton(VillageEditorWindow villageEditor)
        {
            villageEditor.rdButtonHouse.Enabled = true;
            villageEditor.rdButtonTree.Enabled = false;
            villageEditor.rdButtonWaterSrc.Enabled = false;

        }

        public void setTerrain(VillageEditorWindow villageEditor)
        {
            villageEditor.Panel1.BackColor = Color.White;
        }
    }









}
