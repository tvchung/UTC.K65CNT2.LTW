using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TvcLesson07Annotation.Models
{
    /// <summary>
    /// Model class Member
    /// 
    /// Author: Chung trinhj
    /// </summary>
    public class TvcMember
    {
       
        public int Id { get; set; }

        [DisplayName("Tài khoản")]
        [Required(ErrorMessage ="Tài khoản không được để trống")]
        [StringLength(20,MinimumLength =3,ErrorMessage ="Tài khoản có độ dài trong khoảng 3-20 ký tự")]
        public string TvcUserName { get; set; }

        [DisplayName("Mật khẩu")]
        [StringLength(100,MinimumLength = 8,ErrorMessage ="Mật khẩu tối thiểu 8 ký tự")]
        public string TvcPassword { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email không được để trống")]
        [DataType(DataType.EmailAddress)]
        public string TvcEmail { get; set; }

        [DisplayName("Điện thoại")]
        [Required(ErrorMessage ="Bạn chưa nhập điện thoại")]
        [RegularExpression(@"^0\d{9,9}",ErrorMessage ="Điện phải là 10 ký tự số, bắt đầu bằng số 0 ")]
        public string TvcPhone { get; set; } 

    }
}
