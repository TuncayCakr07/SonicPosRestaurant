using FluentValidation;
using SonicPosRestaurant.Entities.Tables;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Business.Validations
{
    public class UrunValidator:AbstractValidator<Urun>
    {
        public UrunValidator()
        {
            RuleFor(c => c.Adi).NotEmpty().WithMessage("Ürün Adı Boş Geçilemez!").MaximumLength(50).WithMessage("50 Karakterden Fazla Girilemez!");
            RuleFor(c => c.Barkod).NotEmpty().WithMessage("Ürün Barkodu Boş Geçilemez!").MaximumLength(20).WithMessage("Barkod Bilgisi 20 Karakterden Fazla Girilemez!");

        }
    }
}
