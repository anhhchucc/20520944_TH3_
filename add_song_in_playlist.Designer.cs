namespace _20520944_TH3
{
    partial class add_song_in_playlist
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
            this.lb_danhsach = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_AddTo = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Play = new System.Windows.Forms.Button();
            this.btn_AddPlaylist = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_danhsach
            // 
            this.lb_danhsach.AutoSize = true;
            this.lb_danhsach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_danhsach.Location = new System.Drawing.Point(623, -191);
            this.lb_danhsach.Name = "lb_danhsach";
            this.lb_danhsach.Size = new System.Drawing.Size(72, 23);
            this.lb_danhsach.TabIndex = 6;
            this.lb_danhsach.Text = "Playlist";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Pink;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-1, -1);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(443, 554);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // btn_AddTo
            // 
            this.btn_AddTo.BackColor = System.Drawing.Color.Pink;
            this.btn_AddTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddTo.FlatAppearance.BorderSize = 0;
            this.btn_AddTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddTo.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddTo.Location = new System.Drawing.Point(444, 481);
            this.btn_AddTo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AddTo.Name = "btn_AddTo";
            this.btn_AddTo.Size = new System.Drawing.Size(266, 71);
            this.btn_AddTo.TabIndex = 12;
            this.btn_AddTo.Text = "Add to Playlist";
            this.btn_AddTo.UseVisualStyleBackColor = false;
            this.btn_AddTo.Click += new System.EventHandler(this.btn_AddTo_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Pink;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(444, -1);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(339, 466);
            this.listBox1.TabIndex = 13;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_Play
            // 
            this.btn_Play.BackColor = System.Drawing.Color.White;
            this.btn_Play.BackgroundImage = global::_20520944_TH3.Properties.Resources.play;
            this.btn_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Play.FlatAppearance.BorderSize = 0;
            this.btn_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Play.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Play.Location = new System.Drawing.Point(708, 481);
            this.btn_Play.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Play.Size = new System.Drawing.Size(73, 71);
            this.btn_Play.TabIndex = 17;
            this.btn_Play.UseVisualStyleBackColor = false;
            this.btn_Play.Click += new System.EventHandler(this.btn_Play_Click);
            // 
            // btn_AddPlaylist
            // 
            this.btn_AddPlaylist.BackColor = System.Drawing.Color.Pink;
            this.btn_AddPlaylist.BackgroundImage = global::_20520944_TH3.Properties.Resources.more;
            this.btn_AddPlaylist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_AddPlaylist.FlatAppearance.BorderSize = 0;
            this.btn_AddPlaylist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddPlaylist.Font = new System.Drawing.Font("Comic Sans MS", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddPlaylist.Location = new System.Drawing.Point(373, 492);
            this.btn_AddPlaylist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AddPlaylist.Name = "btn_AddPlaylist";
            this.btn_AddPlaylist.Size = new System.Drawing.Size(67, 61);
            this.btn_AddPlaylist.TabIndex = 11;
            this.btn_AddPlaylist.UseVisualStyleBackColor = false;
            this.btn_AddPlaylist.Click += new System.EventHandler(this.btn_AddPlaylist_Click);
            // 
            // exit
            // 
            this.exit.BackgroundImage = global::_20520944_TH3.Properties.Resources.exit;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Location = new System.Drawing.Point(743, -1);
            this.exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(39, 39);
            this.exit.TabIndex = 19;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // add_song_in_playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 551);
            this.ControlBox = false;
            this.Controls.Add(this.exit);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_AddTo);
            this.Controls.Add(this.btn_AddPlaylist);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lb_danhsach);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "add_song_in_playlist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_danhsach;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_AddPlaylist;
        private System.Windows.Forms.Button btn_AddTo;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Play;
        private System.Windows.Forms.Button exit;
    }
}