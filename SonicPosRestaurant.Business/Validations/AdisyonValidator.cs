using FluentValidation;
using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Business.Validations
{
    public class AdisyonValidator:AbstractValidator<Adisyon>
    {
        public AdisyonValidator()
        {
            RuleFor(c => c.Tutar).ScalePrecision(2, 10).WithMessage("Tutar İstenilen Aralıkta Değil!");
            RuleFor(c => c.Indirim).ScalePrecision(2, 5).WithMessage("İndirim İstenilen Aralıkta Değil!");
        }
    }
}
