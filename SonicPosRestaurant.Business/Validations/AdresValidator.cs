using FluentValidation;
using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Business.Validations
{
    public class AdresValidator : AbstractValidator<Adres>
    {
        public AdresValidator()
        {
            RuleFor(c => c.Il).MaximumLength(50).WithMessage("İl Bilgisi 50 Karakterden Fazla Olamaz!");
            RuleFor(c => c.Il).NotEmpty().WithMessage("İl Bilgisi Geçilemez!");
        }
    }
}
