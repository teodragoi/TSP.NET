using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferencePhoto;

namespace Client.Pages.Photos
{
    public class DeleteModel : PageModel
    {
        PhotoServiceClient photoService = new PhotoServiceClient();

        [BindProperty]
        public PhotoDTO PhotoDTO { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
                return NotFound();
            var photo = await photoService.GetByIdAsync(id.Value);
            if (photo != null)
            {
                PhotoDTO = new PhotoDTO()
                {
                    Id = photo.Id,
                    Date = photo.Date,
                    Event = photo.Event,
                    Location = photo.Location,
                    PhotoUrl = photo.PhotoUrl
                };
                return Page();
            }
            else
            {
                return NotFound();
            }
        }

        public async Task OnPostAsync(int? id)
        {
            try
            {
                await photoService.DeleteAsync(id.Value);
            }
            catch
            {
                RedirectToPage("/Error");
            }

            RedirectToPage("./Index");
        }
    }
}