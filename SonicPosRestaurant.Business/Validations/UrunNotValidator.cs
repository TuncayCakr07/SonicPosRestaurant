using FluentValidation;
using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Business.Validations
{
    public class UrunNotValidator:AbstractValidator<UrunNot>
    {
        public UrunNotValidator()
        {
            RuleFor(c => c.Notu).NotEmpty().WithMessage("Ürün Notunuz Boş Geçilemez!");
            RuleFor(c => c.Notu).MaximumLength(100).WithMessage("Notunuz 100 Karakterden Fazla Olamaz!");
        }
    }
}
