using FluentValidation;
using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Business.Validations
{
    public class EkMalzemeValidator:AbstractValidator<EkMalzeme>
    {
        public EkMalzemeValidator()
        {
            RuleFor(c => c.Adi).NotEmpty().WithMessage("Adı Alanı Boş Geçilemez!");
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Adı Alanı 50 Karakterden Fazla Olamaz!");
            RuleFor(c => c.Fiyat).PrecisionScale(2,10,false).WithMessage("Fiyat Bilgisi Aralık Dışında");

        }
    }
}
