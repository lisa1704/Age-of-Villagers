using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace AgeOfVillegrs 
{
	public class SaveVillage : ICommand
	{
		village village;
		public SaveVillage(village village)
		{
			this.village = village;
		}
		public  void execute ()
        {
			SaveFileDialog sfd = new SaveDialog();
			sfd.InitialDirectory = @"C:\Users\user\Desktop\Dp-assignment\age-of-villagers-swe-17\solutions\Save";
			sfd.RestoreDirectory = true;
            sfd.FileName = "*.aov";
            sfd.DefaultExt = "aov";
            sfd.Filter = "AoV file(*.aov)| *.aov";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Stream fileStream = sfd.OpenFile();
                using (StreamWriter sw = new StreamWriter(fileStream))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(sw, village);
                    sw.Close();
                }
                fileStream.Close();
            }

        }

	}
}
