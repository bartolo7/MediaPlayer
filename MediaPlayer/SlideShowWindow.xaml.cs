using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Threading;
using System.Configuration;
using System.Threading;
using WMPLib;


namespace MediaPlayer
{
    // David Bartolome Assigment 1 C# level 3 24-10-2017

    public partial class SlideShowWindow : Window
    {
      
        private PlayListManager thelist;
        private DispatcherTimer timerImageChange;
        private Image[] imageControls;
        private int currentSourceIndex, currentCtrlIndex, effectIndex = 0;
     



        /// <summary>
        /// Constructor with playlistManager 
        /// </summary>
        /// <param name="thelist"></param>
        public SlideShowWindow(PlayListManager thelist)
        {
            InitializeComponent();

            this.thelist = thelist;

            imageControls = new[] { myImage, myImage2 };


            //timer is initiated and event handler 
            timerImageChange = new DispatcherTimer();
            timerImageChange.Tick += new EventHandler(timerImageChange_Tick);
            timerImageChange.IsEnabled = true;  
        }




        /// <summary>
        /// Method to tick timer and start playing image/video method 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerImageChange_Tick(object sender, EventArgs e)
        {
                PlaySlideShow();
        }


        /// <summary>
        /// Method to show/play image or video 
        /// </summary>
        public void PlaySlideShow()
        {

            string TransitionType;
            string[] TransitionEffects = new[] { "Fade" };


            try
            {

                if (thelist.Count == 0)
                    return;

                if (currentSourceIndex == thelist.Count)
                    return;

                ImageDetails afile = thelist.ElementAt(currentSourceIndex);

                var oldCtrlIndex = currentCtrlIndex;
                currentCtrlIndex = (currentCtrlIndex + 1) % 2;

                currentSourceIndex = (currentSourceIndex + 1) % thelist.Count;


                if ((afile.Path as string).Contains(@".mp4"))
                {


                    myImage.Visibility = Visibility.Collapsed;
                    myImage2.Visibility = Visibility.Collapsed;

                    myVideo.Visibility = Visibility.Visible;


                    myVideo.Source = thelist.CreateVideoSource(afile.Path);

                    myVideo.Play();

                    timerImageChange.Interval = TimeSpan.FromSeconds(afile.Times);



                }
                else
                {
                    myImage.Visibility = Visibility.Visible;
                    myImage2.Visibility = Visibility.Visible;
                    myVideo.Visibility = Visibility.Collapsed;

                    Image imgFadeOut = imageControls[oldCtrlIndex];
                    Image imgFadeIn = imageControls[currentCtrlIndex];


                    ImageSource dImage = thelist.CreateImageSource(afile.Path);

                    imgFadeIn.Source = dImage;

                    TransitionType = TransitionEffects[effectIndex].ToString();

                    Storyboard StboardFadeOut = (Resources[string.Format("{0}Out", TransitionType.ToString())] as Storyboard).Clone();
                    StboardFadeOut.Begin(imgFadeOut);
                    Storyboard StboardFadeIn = Resources[string.Format("{0}In", TransitionType.ToString())] as Storyboard;
                    StboardFadeIn.Begin(imgFadeIn);

                    timerImageChange.Interval = new TimeSpan(0, 0, afile.Times);
                }
            }
            catch{ }

          
        }
    }
}
