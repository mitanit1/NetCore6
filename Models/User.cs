using System.ComponentModel;

namespace NetCore6.Models;

public class User{
    [DisplayName("Tên người dùng")]
public string UserName { get; set; } = "xuanthulab";
}