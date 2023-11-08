using FluentValidation;
using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Business.Validations
{
    public class EkMalzemeHareketValidator:AbstractValidator<EkMalzemeHareket>
    {
        public EkMalzemeHareketValidator()
        {
            RuleFor(c => c.Fiyat).ScalePrecision(2, 10).WithMessage("Fiyat Belirtilen Aralıkta Değil!");
        }
    }
}
