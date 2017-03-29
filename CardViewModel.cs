using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Braintree;

namespace adr.Web.Models.ViewModels
{
    public class CardViewModel : BaseViewModel
    {
        public string clientToken { get; set; }
        public bool status { get; set; }
        public string errorMessages { get; set; }
        public Transaction transaction { get; set; }
    }
}