using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MVC.Fibonacci.Models
{
    public class ViewModel
    {
        [DisplayName("İndeks Değeri Giriniz.")]
        public int sayi { get; set; }

        [DisplayName("Belirtilen İndeks'te bulunan sayı:")]
        public int cikti { get; set; }
    }
}