using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyThree.Models;

namespace VidlyThree.ViewModels {
    public class RandomViewModel {
        public List<Customer> Customers { get; set; }
        public Movie Movie { get; set; }
    }
}