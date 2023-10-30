using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1_Manager.Images.TrackImages
{
	public class TrackImage
	{
		public string TrackName;
		public string ImageRelativePath;
		public TrackImage(string _trackname, string _imagerelativepath) {
			TrackName = formattedTrackName(_trackname.ToList());
			ImageRelativePath = _imagerelativepath;
		}
		private string formattedTrackName(List<char> formTrack)
		{
			for (int i = 0; i < formTrack.Count; i++)
			{
				if (char.IsNumber(formTrack[i]))
				{
					formTrack.RemoveAt(i);
					i--;
					continue;
				}
				if (formTrack[i] == '.')
				{
					formTrack.RemoveRange(i, formTrack.Count - i);
					break;
				}
			}
			return new string(formTrack.ToArray());
		}
	}
}
