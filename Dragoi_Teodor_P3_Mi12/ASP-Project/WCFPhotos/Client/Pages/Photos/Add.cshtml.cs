using Client.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferencePhoto;
using System;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace Client.Pages.Photos
{
    public class AddModel : PageModel
    {
        PhotoServiceClient photoService = new PhotoServiceClient();

        public WebImage photo;

        [BindProperty]
        public PhotoDTO PhotoDTO { get; set; }

        public AddModel()
        {
            this.photo = null;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task OnPostAsync()
        {
            this.photo = WebImage.GetImageFromRequest();
            var imageBytes = this.photo.GetBytes();
            var base64String = Convert.ToBase64String(imageBytes);
            Photo photo = new Photo()
            {
                Location = PhotoDTO.Location,
                Date = PhotoDTO.Date,
                Event = PhotoDTO.Event,
                PhotoUrl = base64String
            };

            await photoService.AddAsync(photo);
        }
    }
}