using System;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NetCore6.Models;
using static System.Console;

namespace NetCore6;

public class ModelBindingModel : PageModel {
    // Binding Email từ dữ liệu từ nguồn tới có tên Email, email, emaIL ...
    [BindProperty]
    public string Email { get; set; }

    // Binding cho UserId từ nguồn gửi đến, dữ liệu nguồn có tên username
    [BindProperty (Name = "username")]
    public string UserId { set; get; }

    // Binding ProductID - thiết lập BINDING ngay cả khi truy cập là HTTP GÉT
    [BindProperty(SupportsGet=true)]
    public int ProductID { set; get; }

    // Binding Color
    [BindProperty]
    public string Color { set; get; }
    
        // Handler gọi khi truy vấn bằng HTTP POST
    public void OnGet(int? productID, string color)
    {
        Console.WriteLine($"ProductID: {productID}; color: {color}");
    }
    public void OnPost()
    {
        // Microsoft.AspNetCore.Http.Extensions -> GetDisplayUrl
        Console.WriteLine(Request.GetDisplayUrl());
        var req = Request;
    }

}