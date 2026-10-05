using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TvcLesson08DF.Models;

public partial class Publisher
{
    [Display(Name = "Mã NXB")]
    public int PublisherId { get; set; }

    [Display(Name = "Tên nhà xuất bản")]
    [Required(ErrorMessage = "Vui lòng nhập tên nhà xuất bản")]
    [StringLength(200, ErrorMessage = "Tên nhà xuất bản không vượt quá 200 ký tự")]
    public string? PublisherName { get; set; }

    [Display(Name = "Số điện thoại")]
    [StringLength(30, ErrorMessage = "Số điện thoại không vượt quá 30 ký tự")]
    [RegularExpression(@"^[0-9\+\-\s\.\(\)]{7,30}$", ErrorMessage = "Số điện thoại không đúng định dạng")]
    public string? Phone { get; set; }

    [Display(Name = "Địa chỉ")]
    [StringLength(200, ErrorMessage = "Địa chỉ không vượt quá 200 ký tự")]
    public string? Address { get; set; }

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}

