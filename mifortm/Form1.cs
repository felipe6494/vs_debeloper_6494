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
    public partial class Form1 : Form
    {
        private readonly
        IUnitOfWork _playlist;
        public Form1()
        {   
            InitializeComponent();
            _playlist = new UnitOfWork(new DatabaseContext());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbplaylist.DisplayMember = "Name";
            cmbplaylist.ValueMember = "PlaylistId";
            cmbplaylist.DataSource = _playlist.playlist.GetAll();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void cmbplaylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            var playlist = Convert.ToInt32(cmbplaylist.SelectedValue);
            var listaTracks = _playlist.Tracks.GETbyplaylist(playlist);
            var bindingList = new BindingList<Track>(listaTracks.ToList());
            var bindingsouce = new BindingSource(bindingList, null);
            dataTracks.DataSource = bindingsouce;
         }
    }
}
