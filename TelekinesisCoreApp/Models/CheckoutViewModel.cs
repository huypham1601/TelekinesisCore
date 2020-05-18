using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelekinesisCoreApp.Application.ViewModels.Common;
using TelekinesisCoreApp.Application.ViewModels.Product;
using TelekinesisCoreApp.Data.Enums;
using TelekinesisCoreApp.Utilities.Extensions;

namespace TelekinesisCoreApp.Models
{
    public class CheckoutViewModel : BillViewModel
    {
        public List<ShoppingCartViewModel> Carts { get; set; }
        public List<EnumModel> PaymentMethods
        {
            get
            {
                return ((PaymentMethod[])Enum.GetValues(typeof(PaymentMethod)))
                    .Select(c => new EnumModel
                    {
                        Value = (int)c,
                        Name = c.GetDescription()
                    }).ToList();
            }
        }
    }
}
