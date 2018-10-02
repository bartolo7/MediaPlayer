using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WMPLib;

namespace MediaPlayer
{
    // David Bartolome Assigment 1 C# level 3 24-10-2017

    public class ImageDetails : INotifyPropertyChanged
    {

        private string name = String.Empty;
        private string extension = String.Empty;
        private int times = 0;
        private string description = String.Empty;
        private string videoLogo = String.Empty;

        public event PropertyChangedEventHandler PropertyChanged;


        /// <summary>
        /// Constructor 
        /// </summary>
        public ImageDetails()
        {

        }


        /// <summary>
        /// A name for the image, not the file name.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { Set(ref name, value); }
        }

        /// <summary>
        /// A description for the image.
        /// </summary>
        public string Description
        {
            get { return description; }
            set { Set(ref description, value); }
        }

        /// <summary>
        /// Full path such as c:\path\to\image.png
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// The image file name such as image.png
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// The file name extension: jpg, png, mp4
        /// </summary>
        public string Extension
        {
            get { return extension; }
            set
            {
                extension = value;
                TimeSet();
            }      
        }

       

        /// <summary>
        /// The file size of the image.
        /// </summary>
        public long Size { get; set; }


        /// <summary>
        /// Show time for the file
        /// </summary>
        public int Times
        {
            get { return times; }
            set { Set(ref times, value); }
        }


        /// <summary>
        /// Properity Videologo hold the path value and it is used by listbox data trigger to know if it is picture or video
        /// Picture has a path value while movies are empty string. 
        /// </summary>
        public string VideoLogo
        {
            get
            {
                return  videoLogo;
            }
            set
            {

                videoLogo = value;
            }

        }

        /// <summary>
        /// Method to rise property changed trigger 
        /// </summary>
        /// <param name="propertyName"></param>
        public void RaisePropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }



        /// <summary>
        /// Method to compare to values and verify if they are equal, then PropertyChanged is trigger 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="storage"></param>
        /// <param name="value"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public bool Set<T>(ref T storage, T value, [CallerMemberName]string propertyName = null)
        {
            if (Equals(storage, value))
                return false;
            else
                storage = value;
            RaisePropertyChanged(propertyName);
            return true;
        }


        /// <summary>
        /// Method to set the time, picture = 3 and video = length seconds
        /// </summary>
        public void TimeSet()
        {
            if ((Extension as string).Contains(@"mp4"))
            {
                VideoTimeSpan(Path);
            }
            else
                Times = 3;
        }


        /// <summary>
        /// Method to calculate video length 
        /// </summary>
        /// <param name="videoPath"></param>
        public void VideoTimeSpan(string videoPath)
        {
            var player = new WindowsMediaPlayer();
            var clip = player.newMedia(videoPath);
            Times = (int)clip.duration;
        }

    }
}
