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
        

    }

    public class BangladeshiNation : INation
    {
        

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
        public Color getColor()
        {
            return Color.Green;
        }
    }

    public class ArabBedouinNation : INation
    {
        

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
        public Color getColor()
        {
            return Color.YellowGreen;
            
        }
    }
    public class EgyptianKingNation : INation
    {
        

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

    public class NullNation : INation
    {
        public void setRadiobutton(VillageEditorWindow villageEditor)
        {
            villageEditor.rdButtonHouse.Enabled = true;
            villageEditor.rdButtonTree.Enabled = true;
            villageEditor.rdButtonWaterSrc.Enabled = true;
        }

        public void setTerrain(VillageEditorWindow villageEditor)
        {
            villageEditor.Panel1.BackColor = Color.White;
        }
    }









}
