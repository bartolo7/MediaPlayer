using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace MediaPlayer
{// David Bartolome Assigment 1 C# level 3 24-10-2017

    public class PlayListManager : ObservableCollection<ImageDetails>
    {
        
        private ObservableCollection<ImageDetails> playList;


        /// <summary>
        /// Constructor that initiate the observableCollection 
        /// </summary>
        public PlayListManager()
        {
            playList = new ObservableCollection<ImageDetails>();
        }

        /// <summary>
        /// Property collection playlist 
        /// </summary>
        public ObservableCollection<ImageDetails> PlayList
        {
            get { return playList; }
            set { playList = value; }
        }

        /// <summary>
        /// Method to move up one index in the collection 
        /// </summary>
        /// <param name="selectedIndex"></param>
        public void MoveUp(int selectedIndex)
        {
            int newPosition = selectedIndex - 1;

            if(selectedIndex < playList.Count)
                playList.Move(selectedIndex, newPosition);

        }

        /// <summary>
        /// Method to move down one index in the collection
        /// </summary>
        /// <param name="selectedIndex"></param>
        public void MoveDown(int selectedIndex)
        {
            int newPosition = selectedIndex + 1;

            if (selectedIndex < playList.Count)
                playList.Move(selectedIndex, newPosition);
        }


        /// <summary>
        /// Method to generate image
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public ImageSource CreateImageSource(string file)
        {

            var image = new BitmapImage();
            image.BeginInit();
            image.UriSource = new Uri(file, UriKind.Absolute);
            image.CacheOption = BitmapCacheOption.OnLoad;
            image.EndInit();
            image.Freeze();
            return image;
        }

        /// <summary>
        /// Method to generate video 
        /// </summary>
        /// <param name="file"></param>
        /// <returns></returns>
        public Uri CreateVideoSource(string file)
        {
            return new Uri(file);
        }
    }
}
