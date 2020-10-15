using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

/*
 * Name: Reece Pieri
 * ID: M087496
 * Date: 24/07/2020
 * Assessment: AT2 Portfolio
 * Question 1 – You need to make a Music Player for all staff to use. You need to create a program that plays audio tracks, 
 * it must have the ability to go to the start, go back one, go forward one and skip to the end. It must have a GUI and must 
 * use doubly linked lists.
 */

namespace MusicPlayer
{
    public partial class MusicPlayer : Form
    {
        private LinkedList<string> musicCollection = new LinkedList<string>();
        private WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();

        public MusicPlayer()
        {
            InitializeComponent();
        }

        // Add music to playlist
        private void BtnAddSongs_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog()
            {
                Title = "Select Music",
                Multiselect = true,
                Filter = "MP3 files (*.mp3)|*.mp3"
            };
            
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFile.FileNames)
                {
                    musicCollection.AddLast(file);
                }
                UpdatePlayList();
            }
        }

        // Remove songs from playlist
        private void BtnRemoveSong_Click(object sender, EventArgs e)
        {
            if (listBoxMusic.SelectedItem != null)
            {
                RemoveSong(listBoxMusic.SelectedItem.ToString());
                UpdatePlayList();
            }
        }

        private void PlaySong(string name)
        {
            foreach (string file in musicCollection)
            {
                if (file.Contains(name))
                {
                    player.URL = file;
                    player.controls.play();
                    LblStatus.Text = "Now playing: " + player.currentMedia.name;
                    return;
                }
            }
        }

        // Updates song names in listbox as they added/removed
        private void UpdatePlayList()
        {
            listBoxMusic.Items.Clear();
            foreach(string file in musicCollection)
            {
                listBoxMusic.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
        }

        // Remove song from playlist
        private void RemoveSong(string name)
        {
            foreach (string file in musicCollection)
            {
                if (file.Contains(name))
                {
                    if (player.currentMedia != null && player.currentMedia.sourceURL == file)
                    {
                        player.controls.stop();
                    }
                    musicCollection.Remove(file);
                    LblStatus.Text = "\"" + name + "\" removed from playlist"; 
                    return;
                }
            }
        }

        // Clear status message
        private void ClearStatus() {
            LblStatus.Text = "";
        }

        // Play song by double-clicking
        private void ListBoxMusic_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBoxMusic.SelectedIndex = listBoxMusic.IndexFromPoint(e.Location);
            if(listBoxMusic.SelectedItem != null)
            {
                PlaySong(listBoxMusic.SelectedItem.ToString());
            }
        }

        // Cancel context menu opening if no item selected
        private void ListBoxMusic_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                listBoxMusic.SelectedIndex = listBoxMusic.IndexFromPoint(e.Location);
            }
        }

        // Player controls to play, pause, next and previous
        #region PlayerControls

        private void BtnPlay_Click(object sender, EventArgs e)
        {
            if (player.currentMedia == null)
            {
                try
                {
                    if (listBoxMusic.SelectedItem == null)
                    {
                        listBoxMusic.SelectedIndex = 0;
                        ClearStatus();
                        PlaySong(listBoxMusic.SelectedItem.ToString());
                    }
                    else
                    {
                        ClearStatus();
                        PlaySong(listBoxMusic.SelectedItem.ToString());
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    LblStatus.Text = "Nothing to play.";
                }
            }
            else
            {
                if (listBoxMusic.SelectedItem != null)
                {
                    if (player.currentMedia.name == listBoxMusic.SelectedItem.ToString())
                    {
                        player.controls.play();
                    }
                    else
                    {
                        ClearStatus();
                        PlaySong(listBoxMusic.SelectedItem.ToString());
                    }
                }
                else
                {
                    listBoxMusic.SelectedIndex = 0;
                    ClearStatus();
                    PlaySong(listBoxMusic.SelectedItem.ToString());
                }
            }
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }

        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            ClearStatus();
            if (musicCollection.Count > 1 && player.currentMedia != null)
            {
                if (musicCollection.Find(player.URL).Previous != null)
                {
                    player.URL = musicCollection.Find(player.URL).Previous.Value;
                    player.controls.play();
                    listBoxMusic.SelectedItem = null;
                    listBoxMusic.SelectedItem = player.currentMedia.name;
                    LblStatus.Text = "Now playing: " + player.currentMedia.name;
                }
                else
                {
                    player.URL = musicCollection.First.Value;
                    player.controls.play();
                    LblStatus.Text = "Now playing: " + player.currentMedia.name;
                }
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            ClearStatus();
            if (musicCollection.Count > 1 && player.currentMedia != null)
            {
                if (musicCollection.Find(player.URL).Next != null)
                {
                    player.URL = musicCollection.Find(player.URL).Next.Value;
                    player.controls.play();
                    listBoxMusic.SelectedItem = null;
                    listBoxMusic.SelectedItem = player.currentMedia.name;
                    LblStatus.Text = "Now playing: " + player.currentMedia.name;
                }
            }
        }

        #endregion

        // Methods to handle playlist context menu options
        #region Playlist Context Menu

        private void PlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlaySong(listBoxMusic.SelectedItem.ToString());
        }

        private void RemoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveSong(listBoxMusic.SelectedItem.ToString());
            UpdatePlayList();
        }

        private void ContextMenuStripPlaylist_Opening(object sender, CancelEventArgs e)
        {
            if(listBoxMusic.SelectedIndex == -1)
            {
                e.Cancel = true;
            }
        }

        #endregion
    }
}
