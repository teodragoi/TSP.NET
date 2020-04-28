using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WCFPhotos;

namespace WCFClient
{
    public partial class Form1 : Form
    {

        private readonly PersonServiceClient personClient;
        private readonly PhotoServiceClient photoClient;

        private string base64Image;

        public Form1()
        {
            personClient = new PersonServiceClient();
            photoClient = new PhotoServiceClient();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var people = personClient.GetAll().Select(person =>
            new {
                Id = person.Id,
                FirstName = person.FirstName,
                LastName = person.LastName
            }).ToList();
            peopleGrid.DataSource = people;

            var photosGridSource = photoClient.GetAll().Select(photo =>
            new
            {
                Id = photo.Id,
                Location = photo.Location,
                Date = photo.Date,
                Event = photo.Event
            }).ToList();
            photoGrid.DataSource = photosGridSource;
        }

        private void uploadImageButton_Click(object sender, EventArgs e)
        {
            var openfd = new OpenFileDialog();
            openfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (openfd.ShowDialog() == DialogResult.OK)
            {
                addPictureBox.Image = new Bitmap(openfd.FileName);

                var imageArray = System.IO.File.ReadAllBytes(openfd.FileName);
                base64Image = Convert.ToBase64String(imageArray);
            }
        }

        private Bitmap Base64StringToBitmap(string base64String)
        {
            byte[] byteBuffer = Convert.FromBase64String(base64String);
            var memoryStream = new MemoryStream(byteBuffer);

            memoryStream.Position = 0;

            var bmpReturn = (Bitmap)Bitmap.FromStream(memoryStream);

            memoryStream.Close();

            return bmpReturn;
        }

        private void savePhotoButton_Click(object sender, EventArgs e)
        {
            var newPhoto = new Photo()
            {
                Location = addLocationTextBox.Text,
                Event = addEventTextBox.Text,
                Date = addDateTextBox.Text,
                PhotoUrl = base64Image
            };

            photoClient.Add(newPhoto);
            photoGrid.DataSource = photoClient.GetAll().Select(photo => new
            {
                Id = photo.Id,
                Location = photo.Location,
                Date = photo.Date,
                Event = photo.Event
            });

            this.tabControl.SelectedTab = this.photosTab;
        }

        private void photoGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.tabControl.SelectedTab = this.photoDetailsTab;
            locationTextBox.Text = this.photoGrid.Rows[e.RowIndex].Cells["Location"].Value.ToString();
            eventTextBox.Text = this.photoGrid.Rows[e.RowIndex].Cells["Event"].Value.ToString();
            dateTextBox.Text = this.photoGrid.Rows[e.RowIndex].Cells["Date"].Value.ToString();

            var id = this.photoGrid.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            idTextBox.Text = id;

            var picture = photoClient.GetById(Convert.ToInt32(id));
            taggedPeopleTextBox.Text = "";
            foreach (Person person in picture.People)
            {
                taggedPeopleTextBox.Text += person.FirstName + " ";
            }

            var pictureString = photoClient.GetById(Convert.ToInt32(id)).PhotoUrl;

            pictureBox.Image = Base64StringToBitmap(pictureString);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var updatedPhoto = new Photo()
            {
                Id = Convert.ToInt32(idTextBox.Text),
                Location = locationTextBox.Text,
                Date = dateTextBox.Text,
                Event = eventTextBox.Text
            };

            photoClient.Update(updatedPhoto);
            this.tabControl.SelectedTab = this.photosTab;
        }

        private void peopleGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var person = personClient.GetById(Convert.ToInt32(peopleGrid.Rows[e.RowIndex].Cells["Id"].Value));
            photoClient.TagPerson(Convert.ToInt32(idTextBox.Text), person);
        }
    }
}
