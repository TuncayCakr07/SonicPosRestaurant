using FluentValidation;
using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Business.Validations
{
    public class MasaValidator:AbstractValidator<Masa>
    {
        public MasaValidator()
        {
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Masa Adı 50 Karakterden Fazla Olamaz!");
        }
    }
}
