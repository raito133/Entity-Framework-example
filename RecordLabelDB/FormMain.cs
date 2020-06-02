using RecordLabelDB.Models;
using RecordLabelDB.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordLabelDB
{
    public partial class FormMain : Form
    {
        private readonly IRecordLabelGeneric<Artist> _artists;
        private readonly IRecordLabelGeneric<StudioAlbum> _studioAlbums;
        private readonly IRecordLabelGeneric<Track> _tracks;
        private readonly IRecordLabelGeneric<Genre> _genres;
        private readonly IRecordLabelGeneric<Country> _countries;

        public FormMain()
        {
            InitializeComponent();
            _artists = new RecordLabelGeneric<Artist>();
            _studioAlbums = new RecordLabelGeneric<StudioAlbum>();
            _tracks = new RecordLabelGeneric<Track>();
            _genres = new RecordLabelGeneric<Genre>();
            _countries = new RecordLabelGeneric<Country>();
            LoadArtists();
            LoadStudioAlbums();
            LoadTracks();
            LoadGenres();
            LoadCountries();
        }

        /// <summary>
        /// Function which loads countries from the table
        /// </summary>
        private void LoadCountries()
        {
            dataGridViewCountries.DataSource = _countries.GetAll();
        }

        /// <summary>
        /// Function which loads genres from the table
        /// </summary>
        private void LoadGenres()
        {
            dataGridViewGenres.DataSource = _genres.GetAll();
        }

        /// <summary>
        /// Function which loads tracks from the table
        /// </summary>
        private void LoadTracks()
        {
            dataGridViewTracks.DataSource = _tracks.GetAll();
        }

        /// <summary>
        /// Function which loads albums from the table
        /// </summary>
        private void LoadStudioAlbums()
        {
            dataGridViewAlbums.DataSource = _studioAlbums.GetAll();
        }

        /// <summary>
        /// Function which loads artists from the table
        /// </summary>
        private void LoadArtists()
        {
            dataGridViewArtists.DataSource = _artists.GetAll();
        }

        /// <summary>
        /// Button for adding an artist using data from textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddArtist_Click(object sender, EventArgs e)
        {
            var artistFirstName = textBoxArtistFirstName.Text;
            var artistLastName = textBoxArtistLastName.Text;
            var artistBirthdate = dateTimePickerArtistBirthdate.Text;
            var countryId = textBoxArtistCountryId.Text;

            Artist newArtist = new Artist
            {
                FirstName = artistFirstName,
                LastName = artistLastName,
                Birthdate = Convert.ToDateTime(artistBirthdate),
                CountryId = Int32.Parse(countryId)

            };
            _artists.Create(newArtist);
            _artists.Save();

            // Refresh
            LoadArtists();
        }

        /// <summary>
        /// Button for adding an album using data from textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddAlbum_Click(object sender, EventArgs e)
        {
            var albumName = textBoxAlbumName.Text;
            var albumReleaseDate = dateTimePickerAlbumReleaseDate.Text;
            var genreId = textBoxAlbumGenreId.Text;
            var artistId = textBoxAlbumArtistId.Text;

            StudioAlbum newStudioAlbum = new StudioAlbum
            {
                Name = albumName,
                ReleaseDate = Convert.ToDateTime(albumReleaseDate),
                GenreId = Int32.Parse(genreId),
                ArtistId = Int32.Parse(artistId)

            };
            _studioAlbums.Create(newStudioAlbum);
            _studioAlbums.Save();

            // Refresh
            LoadStudioAlbums();
        }

        /// <summary>
        /// Button for adding a track using data from textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddTrack_Click(object sender, EventArgs e)
        {

            var trackName = textBoxTrackName.Text;
            var trackLength = textBoxTrackLength.Text;
            var albumId = textBoxTrackAlbumId.Text;

            Track newTrack = new Track
            {
                Name = trackName,
                Length = float.Parse(trackLength),
                StudioAlbumId = Int32.Parse(albumId)

            };
            _tracks.Create(newTrack);
            _tracks.Save();

            // Refresh
            LoadTracks();
        }

        /// <summary>
        /// Button for deleting selected artist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteArtist_Click(object sender, EventArgs e)
        {
            var selectedArtistIndex = Int32.Parse(dataGridViewArtists.SelectedRows[0].Cells[0].Value.ToString());

            _artists.DeleteById(selectedArtistIndex);
            _artists.Save();

            LoadArtists();
        } 

        /// <summary>
        /// Button for deleting selected album
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteAlbum_Click(object sender, EventArgs e)
        {
            var selectedAlbumIndex = Int32.Parse(dataGridViewAlbums.SelectedRows[0].Cells[0].Value.ToString());

            _studioAlbums.DeleteById(selectedAlbumIndex);
            _studioAlbums.Save();

            LoadStudioAlbums();
        }

        /// <summary>
        /// Button for deleting selected track
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteTrack_Click(object sender, EventArgs e)
        {
            var selectedTrackIndex = Int32.Parse(dataGridViewTracks.SelectedRows[0].Cells[0].Value.ToString());

            _tracks.DeleteById(selectedTrackIndex);
            _tracks.Save();

            LoadTracks();
        }

        /// <summary>
        /// Button for editing selected artist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditArtist_Click(object sender, EventArgs e)
        {
            var artistId = textBoxArtistIdEdit.Text;
            var artistFirstName = textBoxArtistFirstName.Text;
            var artistLastName = textBoxArtistLastName.Text;
            var artistBirthdate = dateTimePickerArtistBirthdate.Text;
            var countryId = textBoxArtistCountryId.Text;

            Artist artist = _artists.GetById(Int32.Parse(artistId));
            artist.FirstName = artistFirstName;
            artist.LastName = artistLastName;
            artist.Birthdate = Convert.ToDateTime(artistBirthdate);
            artist.CountryId = Int32.Parse(countryId);

            _artists.Update(artist);
            _artists.Save();

            // Refresh
            LoadArtists();
        }

        /// <summary>
        /// Button for editing selected album
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditAlbum_Click(object sender, EventArgs e)
        {
            var albumId = textBoxAlbumIdEdit.Text;
            var albumName = textBoxAlbumName.Text;
            var albumReleaseDate = dateTimePickerAlbumReleaseDate.Text;
            var genreId = textBoxAlbumGenreId.Text;
            var artistId = textBoxAlbumArtistId.Text;

            StudioAlbum studioAlbum = _studioAlbums.GetById(Int32.Parse(albumId));
            studioAlbum.Name = albumName;
            studioAlbum.ReleaseDate = Convert.ToDateTime(albumReleaseDate);
            studioAlbum.GenreId = Int32.Parse(genreId);
            studioAlbum.ArtistId = Int32.Parse(artistId);

            _studioAlbums.Update(studioAlbum);
            _studioAlbums.Save();

            // Odświeżenie widoku po zmianie
            LoadStudioAlbums();
        }

        /// <summary>
        /// Button for editing selected track
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditTrack_Click(object sender, EventArgs e)
        {
            var trackId = textBoxTrackIdEdit.Text;
            var trackName = textBoxTrackName.Text;
            var trackLength = textBoxTrackLength.Text;
            var albumId = textBoxTrackAlbumId.Text;

            Track track = _tracks.GetById(Int32.Parse(trackId));
            track.Name = trackName;
            track.Length = float.Parse(trackLength);
            track.StudioAlbumId = Int32.Parse(albumId);
            
            _tracks.Update(track);
            _tracks.Save();

            // Refresh
            LoadTracks();
        }
    }
}
