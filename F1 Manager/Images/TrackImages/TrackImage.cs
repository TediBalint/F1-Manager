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
			TrackName = _trackname;
			ImageRelativePath = _imagerelativepath;
		}
	}
}
