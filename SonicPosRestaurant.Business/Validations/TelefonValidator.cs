using FluentValidation;
using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Business.Validations
{
    public class TelefonValidator : AbstractValidator<Telefon>
    {
        public TelefonValidator()
        {
            RuleFor(c => c.Telefonu).MaximumLength(30).WithMessage("Müşteri Telefon Bilgisi 50 Karakterden Fazla Olamaz!");
            RuleFor(c => c.Telefonu).NotEmpty().WithMessage("Müşteri Telefon Bilgisi Geçilemez!");
        }
    }
}
