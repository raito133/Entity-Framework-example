namespace RecordLabelDB
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxArtists = new System.Windows.Forms.GroupBox();
            this.textBoxArtistIdEdit = new System.Windows.Forms.TextBox();
            this.labelEditArtistId = new System.Windows.Forms.Label();
            this.labelEditArtist = new System.Windows.Forms.Label();
            this.buttonEditArtist = new System.Windows.Forms.Button();
            this.labelArtistCountryId = new System.Windows.Forms.Label();
            this.textBoxArtistCountryId = new System.Windows.Forms.TextBox();
            this.buttonAddArtist = new System.Windows.Forms.Button();
            this.labelArtistBirthday = new System.Windows.Forms.Label();
            this.labelArtistSecondName = new System.Windows.Forms.Label();
            this.labelArtistFirstName = new System.Windows.Forms.Label();
            this.dateTimePickerArtistBirthdate = new System.Windows.Forms.DateTimePicker();
            this.textBoxArtistLastName = new System.Windows.Forms.TextBox();
            this.textBoxArtistFirstName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxTracks = new System.Windows.Forms.GroupBox();
            this.textBoxTrackIdEdit = new System.Windows.Forms.TextBox();
            this.labelTrackIdEdit = new System.Windows.Forms.Label();
            this.labelEditTrack = new System.Windows.Forms.Label();
            this.buttonEditTrack = new System.Windows.Forms.Button();
            this.textBoxTrackAlbumId = new System.Windows.Forms.TextBox();
            this.labelTrackAlbumId = new System.Windows.Forms.Label();
            this.textBoxTrackLength = new System.Windows.Forms.TextBox();
            this.buttonAddTrack = new System.Windows.Forms.Button();
            this.labelTrackLength = new System.Windows.Forms.Label();
            this.labelTrackName = new System.Windows.Forms.Label();
            this.textBoxTrackName = new System.Windows.Forms.TextBox();
            this.groupBoxStudioAlbums = new System.Windows.Forms.GroupBox();
            this.labelAlbumArtistId = new System.Windows.Forms.Label();
            this.textBoxAlbumArtistId = new System.Windows.Forms.TextBox();
            this.textBoxAlbumIdEdit = new System.Windows.Forms.TextBox();
            this.labelAlbumIdEdit = new System.Windows.Forms.Label();
            this.labelEditAlbum = new System.Windows.Forms.Label();
            this.buttonEditAlbum = new System.Windows.Forms.Button();
            this.labelAlbumGenreId = new System.Windows.Forms.Label();
            this.textBoxAlbumGenreId = new System.Windows.Forms.TextBox();
            this.dateTimePickerAlbumReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.buttonAddAlbum = new System.Windows.Forms.Button();
            this.labelAlbumReleaseDate = new System.Windows.Forms.Label();
            this.labelAlbumsAlbumName = new System.Windows.Forms.Label();
            this.textBoxAlbumName = new System.Windows.Forms.TextBox();
            this.dataGridViewArtists = new System.Windows.Forms.DataGridView();
            this.labelAllArtists = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDeleteAlbum = new System.Windows.Forms.Button();
            this.buttonDeleteTrack = new System.Windows.Forms.Button();
            this.labelAllCountries = new System.Windows.Forms.Label();
            this.dataGridViewCountries = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridViewTracks = new System.Windows.Forms.DataGridView();
            this.buttonDeleteArtist = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridViewGenres = new System.Windows.Forms.DataGridView();
            this.labelAllStudioAlbums = new System.Windows.Forms.Label();
            this.dataGridViewAlbums = new System.Windows.Forms.DataGridView();
            this.groupBoxArtists.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxTracks.SuspendLayout();
            this.groupBoxStudioAlbums.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtists)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTracks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlbums)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxArtists
            // 
            this.groupBoxArtists.Controls.Add(this.textBoxArtistIdEdit);
            this.groupBoxArtists.Controls.Add(this.labelEditArtistId);
            this.groupBoxArtists.Controls.Add(this.labelEditArtist);
            this.groupBoxArtists.Controls.Add(this.buttonEditArtist);
            this.groupBoxArtists.Controls.Add(this.labelArtistCountryId);
            this.groupBoxArtists.Controls.Add(this.textBoxArtistCountryId);
            this.groupBoxArtists.Controls.Add(this.buttonAddArtist);
            this.groupBoxArtists.Controls.Add(this.labelArtistBirthday);
            this.groupBoxArtists.Controls.Add(this.labelArtistSecondName);
            this.groupBoxArtists.Controls.Add(this.labelArtistFirstName);
            this.groupBoxArtists.Controls.Add(this.dateTimePickerArtistBirthdate);
            this.groupBoxArtists.Controls.Add(this.textBoxArtistLastName);
            this.groupBoxArtists.Controls.Add(this.textBoxArtistFirstName);
            this.groupBoxArtists.Location = new System.Drawing.Point(3, 3);
            this.groupBoxArtists.Name = "groupBoxArtists";
            this.groupBoxArtists.Size = new System.Drawing.Size(240, 240);
            this.groupBoxArtists.TabIndex = 0;
            this.groupBoxArtists.TabStop = false;
            this.groupBoxArtists.Text = "Artyści";
            // 
            // textBoxArtistIdEdit
            // 
            this.textBoxArtistIdEdit.Location = new System.Drawing.Point(77, 180);
            this.textBoxArtistIdEdit.Name = "textBoxArtistIdEdit";
            this.textBoxArtistIdEdit.Size = new System.Drawing.Size(145, 20);
            this.textBoxArtistIdEdit.TabIndex = 13;
            // 
            // labelEditArtistId
            // 
            this.labelEditArtistId.AutoSize = true;
            this.labelEditArtistId.Location = new System.Drawing.Point(17, 182);
            this.labelEditArtistId.Name = "labelEditArtistId";
            this.labelEditArtistId.Size = new System.Drawing.Size(41, 13);
            this.labelEditArtistId.TabIndex = 9;
            this.labelEditArtistId.Text = "Artist id";
            // 
            // labelEditArtist
            // 
            this.labelEditArtist.AutoSize = true;
            this.labelEditArtist.Location = new System.Drawing.Point(6, 151);
            this.labelEditArtist.Name = "labelEditArtist";
            this.labelEditArtist.Size = new System.Drawing.Size(50, 13);
            this.labelEditArtist.TabIndex = 12;
            this.labelEditArtist.Text = "Edit artist";
            // 
            // buttonEditArtist
            // 
            this.buttonEditArtist.Location = new System.Drawing.Point(77, 206);
            this.buttonEditArtist.Name = "buttonEditArtist";
            this.buttonEditArtist.Size = new System.Drawing.Size(145, 23);
            this.buttonEditArtist.TabIndex = 11;
            this.buttonEditArtist.Text = "Update";
            this.buttonEditArtist.UseVisualStyleBackColor = true;
            this.buttonEditArtist.Click += new System.EventHandler(this.buttonEditArtist_Click);
            // 
            // labelArtistCountryId
            // 
            this.labelArtistCountryId.AutoSize = true;
            this.labelArtistCountryId.Location = new System.Drawing.Point(16, 106);
            this.labelArtistCountryId.Name = "labelArtistCountryId";
            this.labelArtistCountryId.Size = new System.Drawing.Size(54, 13);
            this.labelArtistCountryId.TabIndex = 10;
            this.labelArtistCountryId.Text = "Country id";
            // 
            // textBoxArtistCountryId
            // 
            this.textBoxArtistCountryId.Location = new System.Drawing.Point(77, 103);
            this.textBoxArtistCountryId.Name = "textBoxArtistCountryId";
            this.textBoxArtistCountryId.Size = new System.Drawing.Size(145, 20);
            this.textBoxArtistCountryId.TabIndex = 9;
            // 
            // buttonAddArtist
            // 
            this.buttonAddArtist.Location = new System.Drawing.Point(77, 129);
            this.buttonAddArtist.Name = "buttonAddArtist";
            this.buttonAddArtist.Size = new System.Drawing.Size(145, 23);
            this.buttonAddArtist.TabIndex = 8;
            this.buttonAddArtist.Text = "Add";
            this.buttonAddArtist.UseVisualStyleBackColor = true;
            this.buttonAddArtist.Click += new System.EventHandler(this.buttonAddArtist_Click);
            // 
            // labelArtistBirthday
            // 
            this.labelArtistBirthday.AutoSize = true;
            this.labelArtistBirthday.Location = new System.Drawing.Point(26, 80);
            this.labelArtistBirthday.Name = "labelArtistBirthday";
            this.labelArtistBirthday.Size = new System.Drawing.Size(45, 13);
            this.labelArtistBirthday.TabIndex = 6;
            this.labelArtistBirthday.Text = "Birthday";
            // 
            // labelArtistSecondName
            // 
            this.labelArtistSecondName.AutoSize = true;
            this.labelArtistSecondName.Location = new System.Drawing.Point(17, 54);
            this.labelArtistSecondName.Name = "labelArtistSecondName";
            this.labelArtistSecondName.Size = new System.Drawing.Size(56, 13);
            this.labelArtistSecondName.TabIndex = 5;
            this.labelArtistSecondName.Text = "Last name";
            // 
            // labelArtistFirstName
            // 
            this.labelArtistFirstName.AutoSize = true;
            this.labelArtistFirstName.Location = new System.Drawing.Point(35, 28);
            this.labelArtistFirstName.Name = "labelArtistFirstName";
            this.labelArtistFirstName.Size = new System.Drawing.Size(35, 13);
            this.labelArtistFirstName.TabIndex = 4;
            this.labelArtistFirstName.Text = "Name";
            // 
            // dateTimePickerArtistBirthdate
            // 
            this.dateTimePickerArtistBirthdate.Location = new System.Drawing.Point(77, 77);
            this.dateTimePickerArtistBirthdate.Name = "dateTimePickerArtistBirthdate";
            this.dateTimePickerArtistBirthdate.Size = new System.Drawing.Size(145, 20);
            this.dateTimePickerArtistBirthdate.TabIndex = 2;
            // 
            // textBoxArtistLastName
            // 
            this.textBoxArtistLastName.Location = new System.Drawing.Point(77, 51);
            this.textBoxArtistLastName.Name = "textBoxArtistLastName";
            this.textBoxArtistLastName.Size = new System.Drawing.Size(145, 20);
            this.textBoxArtistLastName.TabIndex = 1;
            // 
            // textBoxArtistFirstName
            // 
            this.textBoxArtistFirstName.Location = new System.Drawing.Point(77, 25);
            this.textBoxArtistFirstName.Name = "textBoxArtistFirstName";
            this.textBoxArtistFirstName.Size = new System.Drawing.Size(145, 20);
            this.textBoxArtistFirstName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.groupBoxTracks);
            this.panel1.Controls.Add(this.groupBoxStudioAlbums);
            this.panel1.Controls.Add(this.groupBoxArtists);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 258);
            this.panel1.TabIndex = 11;
            // 
            // groupBoxTracks
            // 
            this.groupBoxTracks.Controls.Add(this.textBoxTrackIdEdit);
            this.groupBoxTracks.Controls.Add(this.labelTrackIdEdit);
            this.groupBoxTracks.Controls.Add(this.labelEditTrack);
            this.groupBoxTracks.Controls.Add(this.buttonEditTrack);
            this.groupBoxTracks.Controls.Add(this.textBoxTrackAlbumId);
            this.groupBoxTracks.Controls.Add(this.labelTrackAlbumId);
            this.groupBoxTracks.Controls.Add(this.textBoxTrackLength);
            this.groupBoxTracks.Controls.Add(this.buttonAddTrack);
            this.groupBoxTracks.Controls.Add(this.labelTrackLength);
            this.groupBoxTracks.Controls.Add(this.labelTrackName);
            this.groupBoxTracks.Controls.Add(this.textBoxTrackName);
            this.groupBoxTracks.Location = new System.Drawing.Point(503, 3);
            this.groupBoxTracks.Name = "groupBoxTracks";
            this.groupBoxTracks.Size = new System.Drawing.Size(253, 209);
            this.groupBoxTracks.TabIndex = 10;
            this.groupBoxTracks.TabStop = false;
            this.groupBoxTracks.Text = "Tracks";
            // 
            // textBoxTrackIdEdit
            // 
            this.textBoxTrackIdEdit.Location = new System.Drawing.Point(96, 151);
            this.textBoxTrackIdEdit.Name = "textBoxTrackIdEdit";
            this.textBoxTrackIdEdit.Size = new System.Drawing.Size(145, 20);
            this.textBoxTrackIdEdit.TabIndex = 21;
            // 
            // labelTrackIdEdit
            // 
            this.labelTrackIdEdit.AutoSize = true;
            this.labelTrackIdEdit.Location = new System.Drawing.Point(22, 154);
            this.labelTrackIdEdit.Name = "labelTrackIdEdit";
            this.labelTrackIdEdit.Size = new System.Drawing.Size(46, 13);
            this.labelTrackIdEdit.TabIndex = 18;
            this.labelTrackIdEdit.Text = "Track id";
            // 
            // labelEditTrack
            // 
            this.labelEditTrack.AutoSize = true;
            this.labelEditTrack.Location = new System.Drawing.Point(22, 129);
            this.labelEditTrack.Name = "labelEditTrack";
            this.labelEditTrack.Size = new System.Drawing.Size(52, 13);
            this.labelEditTrack.TabIndex = 20;
            this.labelEditTrack.Text = "Edit track";
            // 
            // buttonEditTrack
            // 
            this.buttonEditTrack.Location = new System.Drawing.Point(96, 177);
            this.buttonEditTrack.Name = "buttonEditTrack";
            this.buttonEditTrack.Size = new System.Drawing.Size(145, 23);
            this.buttonEditTrack.TabIndex = 19;
            this.buttonEditTrack.Text = "Update";
            this.buttonEditTrack.UseVisualStyleBackColor = true;
            this.buttonEditTrack.Click += new System.EventHandler(this.buttonEditTrack_Click);
            // 
            // textBoxTrackAlbumId
            // 
            this.textBoxTrackAlbumId.Location = new System.Drawing.Point(84, 78);
            this.textBoxTrackAlbumId.Name = "textBoxTrackAlbumId";
            this.textBoxTrackAlbumId.Size = new System.Drawing.Size(145, 20);
            this.textBoxTrackAlbumId.TabIndex = 11;
            // 
            // labelTrackAlbumId
            // 
            this.labelTrackAlbumId.AutoSize = true;
            this.labelTrackAlbumId.Location = new System.Drawing.Point(25, 81);
            this.labelTrackAlbumId.Name = "labelTrackAlbumId";
            this.labelTrackAlbumId.Size = new System.Drawing.Size(47, 13);
            this.labelTrackAlbumId.TabIndex = 10;
            this.labelTrackAlbumId.Text = "Album id";
            // 
            // textBoxTrackLength
            // 
            this.textBoxTrackLength.Location = new System.Drawing.Point(84, 52);
            this.textBoxTrackLength.Name = "textBoxTrackLength";
            this.textBoxTrackLength.Size = new System.Drawing.Size(145, 20);
            this.textBoxTrackLength.TabIndex = 9;
            // 
            // buttonAddTrack
            // 
            this.buttonAddTrack.Location = new System.Drawing.Point(84, 104);
            this.buttonAddTrack.Name = "buttonAddTrack";
            this.buttonAddTrack.Size = new System.Drawing.Size(145, 23);
            this.buttonAddTrack.TabIndex = 8;
            this.buttonAddTrack.Text = "Add";
            this.buttonAddTrack.UseVisualStyleBackColor = true;
            this.buttonAddTrack.Click += new System.EventHandler(this.buttonAddTrack_Click);
            // 
            // labelTrackLength
            // 
            this.labelTrackLength.AutoSize = true;
            this.labelTrackLength.Location = new System.Drawing.Point(30, 54);
            this.labelTrackLength.Name = "labelTrackLength";
            this.labelTrackLength.Size = new System.Drawing.Size(40, 13);
            this.labelTrackLength.TabIndex = 5;
            this.labelTrackLength.Text = "Length";
            // 
            // labelTrackName
            // 
            this.labelTrackName.AutoSize = true;
            this.labelTrackName.Location = new System.Drawing.Point(38, 29);
            this.labelTrackName.Name = "labelTrackName";
            this.labelTrackName.Size = new System.Drawing.Size(35, 13);
            this.labelTrackName.TabIndex = 4;
            this.labelTrackName.Text = "Name";
            // 
            // textBoxTrackName
            // 
            this.textBoxTrackName.Location = new System.Drawing.Point(84, 26);
            this.textBoxTrackName.Name = "textBoxTrackName";
            this.textBoxTrackName.Size = new System.Drawing.Size(145, 20);
            this.textBoxTrackName.TabIndex = 0;
            // 
            // groupBoxStudioAlbums
            // 
            this.groupBoxStudioAlbums.Controls.Add(this.labelAlbumArtistId);
            this.groupBoxStudioAlbums.Controls.Add(this.textBoxAlbumArtistId);
            this.groupBoxStudioAlbums.Controls.Add(this.textBoxAlbumIdEdit);
            this.groupBoxStudioAlbums.Controls.Add(this.labelAlbumIdEdit);
            this.groupBoxStudioAlbums.Controls.Add(this.labelEditAlbum);
            this.groupBoxStudioAlbums.Controls.Add(this.buttonEditAlbum);
            this.groupBoxStudioAlbums.Controls.Add(this.labelAlbumGenreId);
            this.groupBoxStudioAlbums.Controls.Add(this.textBoxAlbumGenreId);
            this.groupBoxStudioAlbums.Controls.Add(this.dateTimePickerAlbumReleaseDate);
            this.groupBoxStudioAlbums.Controls.Add(this.buttonAddAlbum);
            this.groupBoxStudioAlbums.Controls.Add(this.labelAlbumReleaseDate);
            this.groupBoxStudioAlbums.Controls.Add(this.labelAlbumsAlbumName);
            this.groupBoxStudioAlbums.Controls.Add(this.textBoxAlbumName);
            this.groupBoxStudioAlbums.Location = new System.Drawing.Point(249, 3);
            this.groupBoxStudioAlbums.Name = "groupBoxStudioAlbums";
            this.groupBoxStudioAlbums.Size = new System.Drawing.Size(248, 240);
            this.groupBoxStudioAlbums.TabIndex = 9;
            this.groupBoxStudioAlbums.TabStop = false;
            this.groupBoxStudioAlbums.Text = "Albums";
            // 
            // labelAlbumArtistId
            // 
            this.labelAlbumArtistId.AutoSize = true;
            this.labelAlbumArtistId.Location = new System.Drawing.Point(20, 110);
            this.labelAlbumArtistId.Name = "labelAlbumArtistId";
            this.labelAlbumArtistId.Size = new System.Drawing.Size(41, 13);
            this.labelAlbumArtistId.TabIndex = 19;
            this.labelAlbumArtistId.Text = "Artist id";
            // 
            // textBoxAlbumArtistId
            // 
            this.textBoxAlbumArtistId.Location = new System.Drawing.Point(84, 107);
            this.textBoxAlbumArtistId.Name = "textBoxAlbumArtistId";
            this.textBoxAlbumArtistId.Size = new System.Drawing.Size(145, 20);
            this.textBoxAlbumArtistId.TabIndex = 18;
            // 
            // textBoxAlbumIdEdit
            // 
            this.textBoxAlbumIdEdit.Location = new System.Drawing.Point(84, 183);
            this.textBoxAlbumIdEdit.Name = "textBoxAlbumIdEdit";
            this.textBoxAlbumIdEdit.Size = new System.Drawing.Size(145, 20);
            this.textBoxAlbumIdEdit.TabIndex = 17;
            // 
            // labelAlbumIdEdit
            // 
            this.labelAlbumIdEdit.AutoSize = true;
            this.labelAlbumIdEdit.Location = new System.Drawing.Point(20, 187);
            this.labelAlbumIdEdit.Name = "labelAlbumIdEdit";
            this.labelAlbumIdEdit.Size = new System.Drawing.Size(47, 13);
            this.labelAlbumIdEdit.TabIndex = 14;
            this.labelAlbumIdEdit.Text = "Album id";
            // 
            // labelEditAlbum
            // 
            this.labelEditAlbum.AutoSize = true;
            this.labelEditAlbum.Location = new System.Drawing.Point(11, 158);
            this.labelEditAlbum.Name = "labelEditAlbum";
            this.labelEditAlbum.Size = new System.Drawing.Size(56, 13);
            this.labelEditAlbum.TabIndex = 16;
            this.labelEditAlbum.Text = "Edit album";
            // 
            // buttonEditAlbum
            // 
            this.buttonEditAlbum.Location = new System.Drawing.Point(84, 209);
            this.buttonEditAlbum.Name = "buttonEditAlbum";
            this.buttonEditAlbum.Size = new System.Drawing.Size(145, 23);
            this.buttonEditAlbum.TabIndex = 15;
            this.buttonEditAlbum.Text = "Update";
            this.buttonEditAlbum.UseVisualStyleBackColor = true;
            this.buttonEditAlbum.Click += new System.EventHandler(this.buttonEditAlbum_Click);
            // 
            // labelAlbumGenreId
            // 
            this.labelAlbumGenreId.AutoSize = true;
            this.labelAlbumGenreId.Location = new System.Drawing.Point(20, 83);
            this.labelAlbumGenreId.Name = "labelAlbumGenreId";
            this.labelAlbumGenreId.Size = new System.Drawing.Size(47, 13);
            this.labelAlbumGenreId.TabIndex = 10;
            this.labelAlbumGenreId.Text = "Genre id";
            // 
            // textBoxAlbumGenreId
            // 
            this.textBoxAlbumGenreId.Location = new System.Drawing.Point(84, 80);
            this.textBoxAlbumGenreId.Name = "textBoxAlbumGenreId";
            this.textBoxAlbumGenreId.Size = new System.Drawing.Size(145, 20);
            this.textBoxAlbumGenreId.TabIndex = 9;
            // 
            // dateTimePickerAlbumReleaseDate
            // 
            this.dateTimePickerAlbumReleaseDate.Location = new System.Drawing.Point(84, 54);
            this.dateTimePickerAlbumReleaseDate.Name = "dateTimePickerAlbumReleaseDate";
            this.dateTimePickerAlbumReleaseDate.Size = new System.Drawing.Size(145, 20);
            this.dateTimePickerAlbumReleaseDate.TabIndex = 9;
            // 
            // buttonAddAlbum
            // 
            this.buttonAddAlbum.Location = new System.Drawing.Point(84, 129);
            this.buttonAddAlbum.Name = "buttonAddAlbum";
            this.buttonAddAlbum.Size = new System.Drawing.Size(145, 23);
            this.buttonAddAlbum.TabIndex = 8;
            this.buttonAddAlbum.Text = "Add";
            this.buttonAddAlbum.UseVisualStyleBackColor = true;
            this.buttonAddAlbum.Click += new System.EventHandler(this.buttonAddAlbum_Click);
            // 
            // labelAlbumReleaseDate
            // 
            this.labelAlbumReleaseDate.AutoSize = true;
            this.labelAlbumReleaseDate.Location = new System.Drawing.Point(6, 54);
            this.labelAlbumReleaseDate.Name = "labelAlbumReleaseDate";
            this.labelAlbumReleaseDate.Size = new System.Drawing.Size(70, 13);
            this.labelAlbumReleaseDate.TabIndex = 5;
            this.labelAlbumReleaseDate.Text = "Release date";
            // 
            // labelAlbumsAlbumName
            // 
            this.labelAlbumsAlbumName.AutoSize = true;
            this.labelAlbumsAlbumName.Location = new System.Drawing.Point(38, 29);
            this.labelAlbumsAlbumName.Name = "labelAlbumsAlbumName";
            this.labelAlbumsAlbumName.Size = new System.Drawing.Size(35, 13);
            this.labelAlbumsAlbumName.TabIndex = 4;
            this.labelAlbumsAlbumName.Text = "Name";
            // 
            // textBoxAlbumName
            // 
            this.textBoxAlbumName.Location = new System.Drawing.Point(84, 26);
            this.textBoxAlbumName.Name = "textBoxAlbumName";
            this.textBoxAlbumName.Size = new System.Drawing.Size(145, 20);
            this.textBoxAlbumName.TabIndex = 0;
            // 
            // dataGridViewArtists
            // 
            this.dataGridViewArtists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArtists.Location = new System.Drawing.Point(3, 34);
            this.dataGridViewArtists.Name = "dataGridViewArtists";
            this.dataGridViewArtists.Size = new System.Drawing.Size(368, 235);
            this.dataGridViewArtists.TabIndex = 12;
            // 
            // labelAllArtists
            // 
            this.labelAllArtists.AutoSize = true;
            this.labelAllArtists.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAllArtists.Location = new System.Drawing.Point(100, 0);
            this.labelAllArtists.Name = "labelAllArtists";
            this.labelAllArtists.Size = new System.Drawing.Size(82, 24);
            this.labelAllArtists.TabIndex = 14;
            this.labelAllArtists.Text = "All artists";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoScrollMargin = new System.Drawing.Size(1, 1);
            this.panel2.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.panel2.Controls.Add(this.buttonDeleteAlbum);
            this.panel2.Controls.Add(this.buttonDeleteTrack);
            this.panel2.Controls.Add(this.labelAllCountries);
            this.panel2.Controls.Add(this.dataGridViewCountries);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.dataGridViewTracks);
            this.panel2.Controls.Add(this.buttonDeleteArtist);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.dataGridViewGenres);
            this.panel2.Controls.Add(this.labelAllStudioAlbums);
            this.panel2.Controls.Add(this.dataGridViewAlbums);
            this.panel2.Controls.Add(this.dataGridViewArtists);
            this.panel2.Controls.Add(this.labelAllArtists);
            this.panel2.Location = new System.Drawing.Point(12, 276);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(779, 332);
            this.panel2.TabIndex = 16;
            // 
            // buttonDeleteAlbum
            // 
            this.buttonDeleteAlbum.Location = new System.Drawing.Point(377, 275);
            this.buttonDeleteAlbum.Name = "buttonDeleteAlbum";
            this.buttonDeleteAlbum.Size = new System.Drawing.Size(128, 23);
            this.buttonDeleteAlbum.TabIndex = 29;
            this.buttonDeleteAlbum.Text = "Delete album";
            this.buttonDeleteAlbum.UseVisualStyleBackColor = true;
            this.buttonDeleteAlbum.Click += new System.EventHandler(this.buttonDeleteAlbum_Click);
            // 
            // buttonDeleteTrack
            // 
            this.buttonDeleteTrack.Location = new System.Drawing.Point(751, 275);
            this.buttonDeleteTrack.Name = "buttonDeleteTrack";
            this.buttonDeleteTrack.Size = new System.Drawing.Size(108, 23);
            this.buttonDeleteTrack.TabIndex = 28;
            this.buttonDeleteTrack.Text = "Delete track";
            this.buttonDeleteTrack.UseVisualStyleBackColor = true;
            this.buttonDeleteTrack.Click += new System.EventHandler(this.buttonDeleteTrack_Click);
            // 
            // labelAllCountries
            // 
            this.labelAllCountries.AutoSize = true;
            this.labelAllCountries.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAllCountries.Location = new System.Drawing.Point(1247, -3);
            this.labelAllCountries.Name = "labelAllCountries";
            this.labelAllCountries.Size = new System.Drawing.Size(113, 24);
            this.labelAllCountries.TabIndex = 26;
            this.labelAllCountries.Text = "All countries";
            // 
            // dataGridViewCountries
            // 
            this.dataGridViewCountries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCountries.Location = new System.Drawing.Point(1125, 34);
            this.dataGridViewCountries.Name = "dataGridViewCountries";
            this.dataGridViewCountries.Size = new System.Drawing.Size(368, 235);
            this.dataGridViewCountries.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(877, -3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 24);
            this.label14.TabIndex = 24;
            this.label14.Text = "All tracks";
            // 
            // dataGridViewTracks
            // 
            this.dataGridViewTracks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTracks.Location = new System.Drawing.Point(751, 34);
            this.dataGridViewTracks.Name = "dataGridViewTracks";
            this.dataGridViewTracks.Size = new System.Drawing.Size(368, 235);
            this.dataGridViewTracks.TabIndex = 23;
            // 
            // buttonDeleteArtist
            // 
            this.buttonDeleteArtist.Location = new System.Drawing.Point(3, 275);
            this.buttonDeleteArtist.Name = "buttonDeleteArtist";
            this.buttonDeleteArtist.Size = new System.Drawing.Size(108, 23);
            this.buttonDeleteArtist.TabIndex = 22;
            this.buttonDeleteArtist.Text = "Delete artist";
            this.buttonDeleteArtist.UseVisualStyleBackColor = true;
            this.buttonDeleteArtist.Click += new System.EventHandler(this.buttonDeleteArtist_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(1588, -3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 24);
            this.label15.TabIndex = 21;
            this.label15.Text = "All genres";
            // 
            // dataGridViewGenres
            // 
            this.dataGridViewGenres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGenres.Location = new System.Drawing.Point(1499, 34);
            this.dataGridViewGenres.Name = "dataGridViewGenres";
            this.dataGridViewGenres.Size = new System.Drawing.Size(368, 235);
            this.dataGridViewGenres.TabIndex = 20;
            // 
            // labelAllStudioAlbums
            // 
            this.labelAllStudioAlbums.AutoSize = true;
            this.labelAllStudioAlbums.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAllStudioAlbums.Location = new System.Drawing.Point(483, 0);
            this.labelAllStudioAlbums.Name = "labelAllStudioAlbums";
            this.labelAllStudioAlbums.Size = new System.Drawing.Size(97, 24);
            this.labelAllStudioAlbums.TabIndex = 17;
            this.labelAllStudioAlbums.Text = "All albums";
            // 
            // dataGridViewAlbums
            // 
            this.dataGridViewAlbums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlbums.Location = new System.Drawing.Point(377, 34);
            this.dataGridViewAlbums.Name = "dataGridViewAlbums";
            this.dataGridViewAlbums.Size = new System.Drawing.Size(368, 235);
            this.dataGridViewAlbums.TabIndex = 16;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 619);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "Record label";
            this.groupBoxArtists.ResumeLayout(false);
            this.groupBoxArtists.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBoxTracks.ResumeLayout(false);
            this.groupBoxTracks.PerformLayout();
            this.groupBoxStudioAlbums.ResumeLayout(false);
            this.groupBoxStudioAlbums.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtists)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCountries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTracks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlbums)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxArtists;
        private System.Windows.Forms.DateTimePicker dateTimePickerArtistBirthdate;
        private System.Windows.Forms.TextBox textBoxArtistLastName;
        private System.Windows.Forms.TextBox textBoxArtistFirstName;
        private System.Windows.Forms.Button buttonAddArtist;
        private System.Windows.Forms.Label labelArtistBirthday;
        private System.Windows.Forms.Label labelArtistSecondName;
        private System.Windows.Forms.Label labelArtistFirstName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxStudioAlbums;
        private System.Windows.Forms.Button buttonAddAlbum;
        private System.Windows.Forms.Label labelAlbumReleaseDate;
        private System.Windows.Forms.Label labelAlbumsAlbumName;
        private System.Windows.Forms.TextBox textBoxAlbumName;
        private System.Windows.Forms.DataGridView dataGridViewArtists;
        private System.Windows.Forms.Label labelAllArtists;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridViewGenres;
        private System.Windows.Forms.Label labelAllStudioAlbums;
        private System.Windows.Forms.DataGridView dataGridViewAlbums;
        private System.Windows.Forms.GroupBox groupBoxTracks;
        private System.Windows.Forms.Button buttonAddTrack;
        private System.Windows.Forms.Label labelTrackLength;
        private System.Windows.Forms.Label labelTrackName;
        private System.Windows.Forms.TextBox textBoxTrackName;
        private System.Windows.Forms.DateTimePicker dateTimePickerAlbumReleaseDate;
        private System.Windows.Forms.Label labelAlbumGenreId;
        private System.Windows.Forms.TextBox textBoxAlbumGenreId;
        private System.Windows.Forms.TextBox textBoxTrackAlbumId;
        private System.Windows.Forms.Label labelTrackAlbumId;
        private System.Windows.Forms.TextBox textBoxTrackLength;
        private System.Windows.Forms.Button buttonDeleteAlbum;
        private System.Windows.Forms.Button buttonDeleteTrack;
        private System.Windows.Forms.Label labelAllCountries;
        private System.Windows.Forms.DataGridView dataGridViewCountries;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dataGridViewTracks;
        private System.Windows.Forms.Button buttonDeleteArtist;
        private System.Windows.Forms.Label labelArtistCountryId;
        private System.Windows.Forms.TextBox textBoxArtistCountryId;
        private System.Windows.Forms.TextBox textBoxArtistIdEdit;
        private System.Windows.Forms.Label labelEditArtistId;
        private System.Windows.Forms.Label labelEditArtist;
        private System.Windows.Forms.Button buttonEditArtist;
        private System.Windows.Forms.TextBox textBoxTrackIdEdit;
        private System.Windows.Forms.Label labelTrackIdEdit;
        private System.Windows.Forms.Label labelEditTrack;
        private System.Windows.Forms.Button buttonEditTrack;
        private System.Windows.Forms.TextBox textBoxAlbumIdEdit;
        private System.Windows.Forms.Label labelAlbumIdEdit;
        private System.Windows.Forms.Label labelEditAlbum;
        private System.Windows.Forms.Button buttonEditAlbum;
        private System.Windows.Forms.Label labelAlbumArtistId;
        private System.Windows.Forms.TextBox textBoxAlbumArtistId;
    }
}

