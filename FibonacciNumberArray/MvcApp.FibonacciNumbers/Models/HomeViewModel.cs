using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MvcApp.FibonacciNumbers.Models
{
    public class HomeViewModel
    {
        [DisplayName("İndeks Değeri Giriniz.")]
        public int IndexNumber { get; set; }

        [DisplayName("Belirtilen İndeks'te bulunan sayı:")]
        public int ResultNumber { get; set; }
    }
}