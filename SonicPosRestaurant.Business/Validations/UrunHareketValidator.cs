using FluentValidation;
using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Business.Validations
{
    public class UrunHareketValidator:AbstractValidator<UrunHareket>
    {
        public UrunHareketValidator()
        {
            RuleFor(c => c.Indirim).ScalePrecision(2, 5).WithMessage("İndirim İstenilen Aralıkta Değil!");
            RuleFor(c => c.Miktar).ScalePrecision(3, 8).WithMessage("Miktar İstenilen Aralıkta Değil!");
        }
    }
}
