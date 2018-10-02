using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Collections.ObjectModel;
using System.Collections;


namespace MediaPlayer
{// David Bartolome Assigment 1 C# level 3 24-10-2017

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        
        /// <summary>
        /// New instance from playlistManager that inherets ObservableCollection
        /// </summary>
        PlayListManager newFile = new PlayListManager();

      


        /// <summary>
        /// Constructor 
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            InitializeGUI();
            RetrieveComputerDrives();
           
        }


        /// <summary>
        /// Property to retrieve selected folder/drive in the treeview 
        /// </summary>
        public string SelectedImagePath { get; set; }


        /// <summary>
        /// Property to retieve the file selected in the datagrid playlist, (file = Name, extension, path,..)
        /// </summary>
        public ImageDetails SelectedFile { get; set; }



        /// <summary>
        /// Method to initialize the GUI
        /// </summary>
        public void InitializeGUI()
        {
            //daGPlaylist.ItemsSource = newFile;
            //All media player buttons are disable until an item is selected in the datagrid
            btnAddToPlayList.IsEnabled = false;
            btnRemoveFromPlayList.IsEnabled = false;
            btnMoveUpOnePlace.IsEnabled = false;
            btnMoveDownOnePlace.IsEnabled = false;
        }


        /// <summary>
        /// Method to retrieve PC drives and to populate TreeView
        /// </summary>
        public void RetrieveComputerDrives()
        {
             object dummyNode = null;

            foreach (string drive in Directory.GetLogicalDrives())
            {
                TreeViewItem item = new TreeViewItem();
                item.Header = drive;
                item.Tag = drive;
                item.FontWeight = FontWeights.Normal;
                item.Items.Add(dummyNode);
                item.Expanded += new RoutedEventHandler(TreeViewItem_Expanded);
                trvStructure.Items.Add(item);
            }

        }

        /// <summary>
        /// Method to expand treeview if the user select a drive or folder 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TreeViewItem_Expanded(object sender, RoutedEventArgs e)
        {
            object dummyNode = null;

            TreeViewItem item = e.Source as TreeViewItem;
            if (item.Items.Count == 1 && item.Items[0] == dummyNode)
            {
                item.Items.Clear();
                try
                {
                    foreach (string folder in Directory.GetDirectories(item.Tag.ToString()))
                    {
                        TreeViewItem subitem = new TreeViewItem();
                        subitem.Header = folder.Substring(folder.LastIndexOf("\\") + 1);
                        subitem.Tag = folder;
                        subitem.FontWeight = FontWeights.Normal;
                        subitem.Items.Add(dummyNode);
                        subitem.Expanded += new RoutedEventHandler(TreeViewItem_Expanded);
                        item.Items.Add(subitem);
                    }
                }
                catch (Exception) { }
            }

        }


        /// <summary>
        /// Method to know which drive/folder is selected in the TreeView 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TreeViewItem_IsSelected(object sender, RoutedPropertyChangedEventArgs<object> e)
        {

            RemoveAllItemListBoxPreview();

            TreeView tree = (TreeView)sender;
            TreeViewItem itemSelected = ((TreeViewItem)tree.SelectedItem);

            if (itemSelected == null)
                return;

            SelectedImagePath = "";
            string temp1 = "";
            string temp2 = "";

            while (true)
            {
                temp1 = itemSelected.Header.ToString();
                if (temp1.Contains(@"\"))
                {
                    temp2 = "";
                }

                SelectedImagePath = temp1 + temp2 + SelectedImagePath;

                if (itemSelected.Parent.GetType().Equals(typeof(TreeView)))
                {
                    break;
                }

                itemSelected = ((TreeViewItem)itemSelected.Parent);
                temp2 = @"\";

       
            }
         
             PopulateListView();
        }


        /// <summary>
        /// Method to clear listbox preview 
        /// </summary>
        public void RemoveAllItemListBoxPreview()
        {

            lstThumbNails.Items.Clear();
        }

        /// <summary>
        /// Method to populate listview with the video/image preview from the selected folder/drive in the treeview
        /// </summary>
        private void PopulateListView()
        {
           
                RetriveImagesJPG();
                RetriveImagesPNG();
                RetiveVideoMP4();   
        }


        /// <summary>
        /// Method to retrive images JPG and add to listbox preview 
        /// </summary>
        public void RetriveImagesJPG()
        {
            if (chkJPG.IsChecked == false)
                return;

            DirectoryInfo folder = new DirectoryInfo(SelectedImagePath);


                FileInfo[] imagesJPG = folder.GetFiles("*.jpg");

                foreach (FileInfo img in imagesJPG)
                {

                    ImageDetails id = new ImageDetails()
                    {
                        Path = img.FullName,
                        FileName = System.IO.Path.GetFileName(img.Name),
                        Name = System.IO.Path.GetFileNameWithoutExtension(img.Name),
                        Extension = System.IO.Path.GetExtension(img.Extension)
                    };

                    id.Size = img.Length;
                    id.VideoLogo = img.FullName; // videologo is equla to fullname for pic and empty string for videos
                  

                    lstThumbNails.Items.Add(id);

                
            }
        }


        /// <summary>
        /// Method to retrive images PNG and add to listbox preview 
        /// </summary>
        public void RetriveImagesPNG()
        {
            if (chkPNG.IsChecked == false)
                return;

            DirectoryInfo folder = new DirectoryInfo(SelectedImagePath);


            FileInfo[] imagesJPG = folder.GetFiles("*.png");

            foreach (FileInfo img in imagesJPG)
            {

                ImageDetails id = new ImageDetails()
                {
                    Path = img.FullName,
                    FileName = System.IO.Path.GetFileName(img.Name),
                    Name = System.IO.Path.GetFileNameWithoutExtension(img.Name),
                    Extension = System.IO.Path.GetExtension(img.Extension)
                };

                id.Size = img.Length;
                id.VideoLogo = img.FullName; // videologo is equla to fullname for pic and empty string for videos
             
                lstThumbNails.Items.Add(id);
            }

        }



        /// <summary>
        /// Method to retrive video MP4 and add to listbox preview 
        /// </summary>
        public void RetiveVideoMP4()
        {
            if (chkMP4.IsChecked == false)
                return;

            DirectoryInfo folder = new DirectoryInfo(SelectedImagePath);
            FileInfo[] videos = folder.GetFiles("*.mp4");

            foreach (FileInfo img in videos)
                {

                ImageDetails id = new ImageDetails()
                {
                    Path = img.FullName,
                    FileName = System.IO.Path.GetFileName(img.Name),
                    Name = System.IO.Path.GetFileNameWithoutExtension(img.Name),
                    Extension = System.IO.Path.GetExtension(img.Extension)
                };

                id.VideoLogo = string.Empty;
                id.Size = img.Length;
               
                lstThumbNails.Items.Add(id);

            }


        }

        /// <summary>
        /// Method Add selected image/video to playlist and 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddToPlayList_Click(object sender, RoutedEventArgs e)
        {

            ImageDetails selectedFileInTheListBox = SelectedFile;

            newFile.Add(selectedFileInTheListBox);
            daGPlaylist.ItemsSource = newFile;
            UpdateGUI();
        }



        /// <summary>
        /// Method to know which file (video/images) is selected in the listbox thumbnails
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstThumbNails_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            ListBox a = (ListBox)sender;

            int selectedIndexInTheListBox = a.SelectedIndex;

            btnAddToPlayList.IsEnabled = true;
            btnAddToPlayList.Focus();

           

            SelectedFile = (ImageDetails)lstThumbNails.SelectedItem;
           
        }



     
        /// <summary>
        /// Method to delete files from the playlist datagrid after selection 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemoveFromPlayList_Click(object sender, RoutedEventArgs e)
        {
            
            ImageDetails selectedItem = (ImageDetails)daGPlaylist.SelectedItem;

            newFile.Remove(selectedItem);
            daGPlaylist.SelectedIndex = -1;
            UpdateGUI();

        }



        /// <summary>
        /// Method to move one index up the file in the playlist datagrid 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoveDownOnePlace_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = daGPlaylist.SelectedIndex;
            int moveToIndex = selectedIndex + 1;

            //newFile.MoveDown(this.daGPlaylist.SelectedIndex);

            if (moveToIndex == newFile.Count) // check to avoid crash when trying to move down the last row 
                return;

               newFile.Move(selectedIndex, moveToIndex);


            UpdateGUI();
        }


        /// <summary>
        /// Method to move one file down in the playlist datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoveUpOnePlace_Click(object sender, RoutedEventArgs e)
        {
            int selectedIndex = daGPlaylist.SelectedIndex;
            int moveToIndex = selectedIndex - 1;

            //newFile.MoveUp(this.daGPlaylist.SelectedIndex);
            newFile.Move(selectedIndex, moveToIndex);

            UpdateGUI();
        }


        /// <summary>
        /// Method to update the GUI controller to initial state
        /// </summary>
        public void UpdateGUI()
        {
            lstThumbNails.SelectedIndex = -1;
            //lstThumbNails.IsEnabled = true;

            this.daGPlaylist.SelectedIndex = -1;
            //daGPlaylist.IsEnabled = true;

            btnAddToPlayList.IsEnabled = false;
            btnMoveDownOnePlace.IsEnabled = false;
            btnMoveUpOnePlace.IsEnabled = false;
            btnRemoveFromPlayList.IsEnabled = false;
        }


        /// <summary>
        /// Method to enable/disable media player button base on the datagrid selection row
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void daGPlaylist_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = daGPlaylist.SelectedIndex;

            btnRemoveFromPlayList.IsEnabled = true;

            if (index != 0)
                btnMoveUpOnePlace.IsEnabled = true;

            if (index != daGPlaylist.Items.Count)
                if (daGPlaylist.Items.Count != 1)
                    btnMoveDownOnePlace.IsEnabled = true;
        }


        /// <summary>
        /// Method to send the playlist to slideshow window and start it
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            SlideShowWindow showPlayList = new SlideShowWindow(newFile);
            showPlayList.Closed += SlideShowWindowClose;
            showPlayList.Show();
            btnPlay.IsEnabled = false;
            btnAddToPlayList.IsEnabled = false;
            btnMoveDownOnePlace.IsEnabled = false;
            btnMoveUpOnePlace.IsEnabled = false;
            btnRemoveFromPlayList.IsEnabled = false;
            lstThumbNails.IsEnabled = false;
            daGPlaylist.IsEnabled = false;
            trvStructure.IsEnabled = false;
            
        }


        /// <summary>
        /// Method to check that slideshow is close so the user and edite the playlist. Buttons are enabled again. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SlideShowWindowClose(object sender, EventArgs e)
        {
            //daGPlaylist.SelectedIndex = -1:
            btnPlay.IsEnabled = true;
            //btnAddToPlayList.IsEnabled = false;
            //btnMoveDownOnePlace.IsEnabled = false;
            //btnMoveUpOnePlace.IsEnabled = false;
            //btnRemoveFromPlayList.IsEnabled = true;
            lstThumbNails.IsEnabled = true;
            daGPlaylist.IsEnabled =  true;
            trvStructure.IsEnabled = true;
            UpdateGUI();
        }
    }
}
 
