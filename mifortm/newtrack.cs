using DataAccess;
using DataAccess.repositories;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mifortm
{
    public partial class newtrack : Form
    {
        private readonly
     IUnitOfWork _UnitOfWork;
        public newtrack()
        {
            InitializeComponent();
            _UnitOfWork = new UnitOfWork(new DatabaseContext());
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void newtrack_Load(object sender, EventArgs e)
        {
            cbGenre.DisplayMember = "Name";
            cbGenre.ValueMember = "GenreId";
            cbGenre.DataSource = _UnitOfWork.Genre.GetAll().OrderBy(g=>g.Name).ToList();
            cbMedia.DisplayMember = "Name";
            cbMedia.ValueMember = "MediaTypeId";
            cbMedia.DataSource = _UnitOfWork.MediaType.GetAll();
            cbAlbum.DisplayMember = "Title";
            cbAlbum.ValueMember = "AlbumId";
            cbAlbum.DataSource = _UnitOfWork.Album.GetAll();
        }

        private void btguardar_Click(object sender, EventArgs e)
        {
            var track = new Track();
            track.Name = Nametxt.Text.ToString();
            track.GenreId = Convert.ToInt32(cbGenre.SelectedValue);
            track.MediaTypeId= Convert.ToInt32(cbMedia.SelectedValue);
            track.AlbumId= Convert.ToInt32(cbAlbum.SelectedValue);
            track.Milliseconds= Convert.ToInt32(Militxt.Text.ToString());
            track.UnitPrice = Convert.ToDecimal(unirpricetxt.Text.ToString());

            _UnitOfWork.Tracks.Add(track);
            _UnitOfWork.complete();

            Nametxt.Text = "";
            Militxt.Text = "";
            unirpricetxt.Text = "";

            
            
        }
    }
}
