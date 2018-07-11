using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using TagLib;


namespace ID3Editor
{
    public partial class ID3Editor : Form
    {

        public String directory = "";
        public String[] Files;
        public int selected = 0;
        public ID3Editor()
        {
            InitializeComponent();
        }
        public void chooseFolder()
        {
            FolderBrowserDialog fbd_songDirectory = new FolderBrowserDialog();
            if (fbd_songDirectory.ShowDialog() == DialogResult.OK)
            {
                txt_folder.Text = fbd_songDirectory.SelectedPath;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void txt_songName_TextChanged(object sender, EventArgs e)
        {
        }
        private void txt_folder_TextChanged(object sender, EventArgs e)
        {
           string[] Files = Directory.GetFiles(@txt_folder.Text,"*.mp3");
            Console.WriteLine("{0} Total MP3 Files found", Files.Length);
           for(int i = 0; i < Files.Length;i++)
           {
                lbx_songList.Items.Add(Files[i].Substring(txt_folder.TextLength + 1));
                //Console.WriteLine(Files[i]);
           }
            lbx_songList.SetSelected(selected,true);
        }

        //CheckBoxs To check to make sure if the 
        private void chkbx_writeArtist_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbx_writeArtist.Checked == true)
            {
                txt_artistName.Enabled = true;
            }
            else
            {
                txt_artistName.Enabled = false;
                txt_artistName.Text = "";
            }
        }

        private void chkbx_writeSong_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_writeSong.Checked == true)
            {
                txt_songName.Enabled = true;
            }
            else
            {
                txt_songName.Enabled = false;
                txt_songName.Text = "";
            }
        }
        private void chkbx_writeYear_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_writeYear.Checked == true)
            {
                txt_yearMade.Enabled = true;
            }
            else
            {
                txt_yearMade.Enabled = false;
                txt_yearMade.Text = "";
            }
        }
        private void chkbx_albumName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbx_albumName.Checked == true)
            {
                txt_albumName.Enabled = true;
            }
            else
            {
                txt_albumName.Enabled = false;
                txt_albumName.Text = "";
            }
        }
        private void btn_getFolder_Click(object sender, EventArgs e)
        {
            chooseFolder();
        }
        private void lbx_songList_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_selectedSong.Text = lbx_songList.SelectedItem.ToString();
        }
        
        private void lbl_nextSong_Click(object sender, EventArgs e)
        {
            if (selected < lbx_songList.Items.Count - 1)
            {
                selected++;
                lbx_songList.SetSelected(selected, true);
            }
            else return;
        }

        private void lbl_previousSong_Click(object sender, EventArgs e)
        {
            if (selected == 0)
            {
                return;
            }
            else
            {
                selected--;
                lbx_songList.SetSelected(selected, true);
            }

        }

        private void lbl_writeData_Click(object sender, EventArgs e)
        {
            TagLib.File metaFile = TagLib.File.Create(txt_folder.Text + "/" + txt_selectedSong.Text);

            // Write Title ID3 to File
            if (chkbx_writeSong.Checked == true)
            {
                metaFile.Tag.Title = txt_songName.Text;
            }

        
            // Write Artist ID3 to File
            if(chkbx_writeArtist.Checked == true)
            {
              metaFile.Tag.Performers =  new string[1] { txt_artistName.Text };
            }

            //Write Year ID3 to File
            if (chkbx_writeYear.Checked == true)
            {
                metaFile.Tag.Year = Convert.ToUInt32(txt_yearMade.Text);
            }

            //Write Album ID3 to File
            if (chkbx_albumName.Checked == true)
            {
                metaFile.Tag.Album = txt_albumName.Text;
            }

            metaFile.Save();


            
        }

        private void txt_selectedSong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
