using FluentValidation;
using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Business.Validations
{
    public class OdemeTuruValidator:AbstractValidator<OdemeTuru>
    {
        public OdemeTuruValidator()
        {
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Ödeme Adı 50 Karakterden Fazla Olamaz!");
            RuleFor(c => c.Adi).NotEmpty().WithMessage("Ödeme Adı Boş Geçilemez!");
        }
    }
}
