using F1_Manager.Images.TrackImages;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace F1_Manager.Managers
{
	public class TrackManager
	{
		public TrackImage[] images;
		public TrackManager() { 
			images = getTrackImages();
		}

		private TrackImage[] getTrackImages()
		{
			//fsdafsdf
			//need to fix
			string imagesPath = AppDomain.CurrentDomain.BaseDirectory;
			while (!Directory.GetDirectories(imagesPath).Contains("F1 Manager")) {
				Debug.WriteLine(string.Join(',', Directory.GetDirectories(imagesPath)));
				imagesPath = Path.GetDirectoryName(imagesPath);
				Debug.WriteLine(imagesPath);
			}
			imagesPath = Path.Combine(imagesPath, "Images","TrackImages");
			string[] files = Array.FindAll(Directory.GetFiles(imagesPath), file => Path.GetExtension(file) != ".cs");

			//-1 is because of the TrackImage.cs class
			TrackImage[] images = new TrackImage[files.Length];
			for (int i = 0; i < files.Length; i++)
			{ 
				images[i] = trackImageFromPath(Path.Join(imagesPath, files[i]));
			}

            return images;

			
		}
		private TrackImage trackImageFromPath(string trackPath)
		{
			return new TrackImage(Path.GetFileName(trackPath), trackPath);
		}
	}
}
