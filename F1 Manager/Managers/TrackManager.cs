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
		public TrackImage currentTrack;
		int trackIndex = 0;
		public TrackManager() { 
			images = getTrackImages();
			currentTrack = images[trackIndex];
		}
		public TrackImage getNextTrack()
		{
			trackIndex++;
			if(trackIndex >= images.Length)
			{
				trackIndex = 0;
			}
			return images[trackIndex];
		}
		public TrackImage getPreviousTrack()
		{
			trackIndex--;
			if (trackIndex < 0)
			{
				trackIndex = images.Length-1;
			}
			return images[trackIndex];
		}
		private TrackImage[] getTrackImages()
		{
			//fsdafsdf
			//need to fix
			string imagesPath = AppDomain.CurrentDomain.BaseDirectory;
			while 
			(!Directory.GetDirectories(imagesPath)
				.Select(Path.GetFileName).ToArray().Contains("F1 Manager")
			)
			{
				//Debug.WriteLine(string.Join(',', Directory.GetDirectories(imagesPath)));
				imagesPath = Path.GetDirectoryName(imagesPath);
				//Debug.WriteLine(imagesPath);
			}
			imagesPath = Path.Combine(imagesPath, "F1 Manager","Images","TrackImages");
			string[] files = Array.FindAll(Directory.GetFiles(imagesPath), file => Path.GetExtension(file) != ".cs");

			//-1 is because of the TrackImage.cs class
			TrackImage[] images = new TrackImage[files.Length];
			for (int i = 0; i < files.Length; i++)
			{ 
				images[i] = trackImageFromPath(files[i]);
			}

            return images;

			
		}
		private TrackImage trackImageFromPath(string trackPath)
		{
			return new TrackImage(Path.GetFileName(trackPath), trackPath);
		}
	}
}
