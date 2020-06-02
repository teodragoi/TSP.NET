using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using ServiceReferencePhoto;

namespace Client.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        PhotoServiceClient photoService = new PhotoServiceClient();
        public List<PhotoDTO> Photos = new List<PhotoDTO>();

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public async Task OnGetAsync()
        {
            var photos = await photoService.GetAllAsync();
            foreach(var photo in photos)
            {
                var pd = new PhotoDTO()
                {
                    Id = photo.Id,
                    Date = photo.Date,
                    Event = photo.Event,
                    Location = photo.Location,
                    PhotoUrl = photo.PhotoUrl
                };
                Photos.Add(pd);
            }
        }
    }
}
