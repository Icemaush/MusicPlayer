using System.Windows.Forms;

namespace MusicPlayer
{
    partial class MusicPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxMusic = new System.Windows.Forms.ListBox();
            this.contextMenuStripPlaylist = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnAddSongs = new System.Windows.Forms.Button();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnPause = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.LblStatus = new System.Windows.Forms.Label();
            this.BtnRemoveSong = new System.Windows.Forms.Button();
            this.contextMenuStripPlaylist.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxMusic
            // 
            this.listBoxMusic.ContextMenuStrip = this.contextMenuStripPlaylist;
            this.listBoxMusic.FormattingEnabled = true;
            this.listBoxMusic.Location = new System.Drawing.Point(12, 12);
            this.listBoxMusic.Name = "listBoxMusic";
            this.listBoxMusic.Size = new System.Drawing.Size(239, 290);
            this.listBoxMusic.TabIndex = 0;
            this.listBoxMusic.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxMusic_MouseDoubleClick);
            this.listBoxMusic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBoxMusic_MouseDown);
            // 
            // contextMenuStripPlaylist
            // 
            this.contextMenuStripPlaylist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.contextMenuStripPlaylist.Name = "contextMenuStripPlaylist";
            this.contextMenuStripPlaylist.Size = new System.Drawing.Size(187, 48);
            this.contextMenuStripPlaylist.Opening += ContextMenuStripPlaylist_Opening;
            // 
            // playToolStripMenuItem
            // 
            this.playToolStripMenuItem.Name = "playToolStripMenuItem";
            this.playToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.playToolStripMenuItem.Text = "Play";
            this.playToolStripMenuItem.Click += new System.EventHandler(this.PlayToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.removeToolStripMenuItem.Text = "Remove from playlist";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.RemoveToolStripMenuItem_Click);
            // 
            // BtnAddSongs
            // 
            this.BtnAddSongs.Location = new System.Drawing.Point(269, 12);
            this.BtnAddSongs.Name = "BtnAddSongs";
            this.BtnAddSongs.Size = new System.Drawing.Size(122, 23);
            this.BtnAddSongs.TabIndex = 1;
            this.BtnAddSongs.Text = "Add Songs";
            this.BtnAddSongs.UseVisualStyleBackColor = true;
            this.BtnAddSongs.Click += new System.EventHandler(this.BtnAddSongs_Click);
            // 
            // BtnPlay
            // 
            this.BtnPlay.Location = new System.Drawing.Point(269, 70);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(122, 23);
            this.BtnPlay.TabIndex = 2;
            this.BtnPlay.Text = "Play";
            this.BtnPlay.UseVisualStyleBackColor = true;
            this.BtnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // BtnPause
            // 
            this.BtnPause.Location = new System.Drawing.Point(269, 100);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(122, 23);
            this.BtnPause.TabIndex = 3;
            this.BtnPause.Text = "Pause";
            this.BtnPause.UseVisualStyleBackColor = true;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Location = new System.Drawing.Point(269, 130);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(122, 23);
            this.BtnPrevious.TabIndex = 4;
            this.BtnPrevious.Text = "Previous";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Location = new System.Drawing.Point(269, 160);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(122, 23);
            this.BtnNext.TabIndex = 5;
            this.BtnNext.Text = "Next";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // LblStatus
            // 
            this.LblStatus.AutoSize = true;
            this.LblStatus.Location = new System.Drawing.Point(13, 314);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(0, 13);
            this.LblStatus.TabIndex = 6;
            // 
            // BtnRemoveSong
            // 
            this.BtnRemoveSong.Location = new System.Drawing.Point(269, 41);
            this.BtnRemoveSong.Name = "BtnRemoveSong";
            this.BtnRemoveSong.Size = new System.Drawing.Size(122, 23);
            this.BtnRemoveSong.TabIndex = 7;
            this.BtnRemoveSong.Text = "Remove Song";
            this.BtnRemoveSong.UseVisualStyleBackColor = true;
            this.BtnRemoveSong.Click += new System.EventHandler(this.BtnRemoveSong_Click);
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 339);
            this.Controls.Add(this.BtnRemoveSong);
            this.Controls.Add(this.LblStatus);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrevious);
            this.Controls.Add(this.BtnPause);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.BtnAddSongs);
            this.Controls.Add(this.listBoxMusic);
            this.Name = "MusicPlayer";
            this.Text = "MusicPlayer";
            this.contextMenuStripPlaylist.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxMusic;
        private System.Windows.Forms.Button BtnAddSongs;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.Button BtnRemoveSong;
        private ContextMenuStrip contextMenuStripPlaylist;
        private ToolStripMenuItem playToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
    }
}

