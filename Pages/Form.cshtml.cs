using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Hosting;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
 public class FormModel : PageModel
{
    private readonly IWebHostEnvironment _environment;
    public FormModel(IWebHostEnvironment environment)
    {
        this._environment = environment;
    }
    public string Mesage {set; get;}
    [BindProperty]
    public CustomerInfo customerInfo {set; get;}

    [BindProperty]
    [DataType(DataType.Upload)]
    [Required(ErrorMessage = "Chon file upload")]
    [DisplayName("File Upload")]
    public IFormFile fileUpload {get; set;}
    public void OnPost() {
        if (ModelState.IsValid) {
            Mesage = "Dữ liệu Post chính xác";
            // Xử lý, chuyển hướng ...
            if(fileUpload != null)
            {
                var filePath = Path.Combine(this._environment.WebRootPath, "uploads", fileUpload.FileName);
                using(var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    fileUpload.CopyTo(fileStream);
                }
            }
        }
        else {
            Mesage = "Lỗi dữ liệu";
        }
    }
}