using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcShopping.Models
{
    public class ProductCategory
    {
        [Key]
        public int Id { get; set; }

        [DisplayName]
        [Required(ErrorMessage="请输入商品名称")]
        [MaxLength(20,ErrorMessage="商品类别不能超过20个字")]
        public string Name { get; set; }
    }
}