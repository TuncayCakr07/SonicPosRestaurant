using FluentValidation;
using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Business.Validations
{
    public class PorsiyonValidator:AbstractValidator<Porsiyon>
    {
        public PorsiyonValidator()
        {
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Porsiyon Adı Bilgisi 50 Karakterden Fazla Olamaz!");
            RuleFor(c => c.Fiyat).PrecisionScale(2, 10,false).WithMessage("Fiyat Bilgisi Aralık Dışında");
            RuleFor(c => c.EkMalzemeCarpan).PrecisionScale(2,4, false).WithMessage("Çarpan Bilgisi Aralık Dışında");
        }
    }
}
