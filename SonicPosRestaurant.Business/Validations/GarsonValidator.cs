using FluentValidation;
using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Business.Validations
{
    public class GarsonValidator:AbstractValidator<Personel>
    {
        public GarsonValidator()
        {
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Adı 50 Karakterden Fazla Olamaz!");
            RuleFor(c => c.Soyadi).MaximumLength(50).WithMessage("Soyadı 50 Karakterden Fazla Olamaz!");
        }
    }
}
