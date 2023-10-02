using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;
using NZWalks.API.Models.DTO;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IImageRepository imageRepository;

        public ImagesController(IImageRepository imageRepository)
        {
            this.imageRepository = imageRepository;
        }

        // POST: /api/Images/Upload
        [HttpPost]
        [Route("Upload")]
        public async Task<IActionResult> Upload([FromForm] ImageUploadRequestDto imageUploadRequest)
        {
            ValidateFileUpload(imageUploadRequest);
            if (ModelState.IsValid)
            {
                // Convert DTO to Image
                var imageDomainModel = new Image
                {
                    File = imageUploadRequest.File,
                    FileExtension = Path.GetExtension(imageUploadRequest.File.FileName),
                    FileSizeInBytes = imageUploadRequest.File.Length,
                    FileName = imageUploadRequest.FileName,
                    FileDescription = imageUploadRequest.FileDescription
                };
                // User repository to upload image
                await imageRepository.UploadAsync(imageDomainModel);
                return Ok(imageDomainModel);
            }
            return BadRequest(ModelState);
        }

        private void ValidateFileUpload(ImageUploadRequestDto imageUploadRequest)
        {
            var allowedExtensions = new string[] { ".jpg", ".jpeg", ".png" };
            if (!allowedExtensions.Contains(Path.GetExtension(imageUploadRequest.File.FileName)))
            {
                ModelState.AddModelError("file", "Unsupported file extension!");
            }
            if (imageUploadRequest.File.Length > 10485760)
            {
                ModelState.AddModelError("file", "File size is more than 10MB, please upload a smaller file.");
            }
        }
    }
}
