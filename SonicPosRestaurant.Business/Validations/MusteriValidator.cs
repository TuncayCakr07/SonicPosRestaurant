using FluentValidation;
using SonicPosRestaurant.Entities.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonicPosRestaurant.Business.Validations
{
    public class MusteriValidator:AbstractValidator<Musteri>
    {
        public MusteriValidator()
        {
            RuleFor(c => c.Adi).MaximumLength(50).WithMessage("Müşteri Adı 50 Karakterden Fazla Olamaz!");
            RuleFor(c => c.Adi).NotEmpty().WithMessage("Müşteri Adı Boş Geçilemez!");
            RuleFor(c => c.Soyadi).MaximumLength(50).WithMessage("Müşteri Soyadı 50 Karakterden Fazla Olamaz!");
            RuleFor(c => c.Soyadi).NotEmpty().WithMessage("Müşteri Soyadı Boş Geçilemez!");
            RuleFor(c => c.Sirket).MaximumLength(50).WithMessage("Müşteri Şirket Bilgisi 50 Karakterden Fazla Olamaz!");
            RuleFor(c => c.Sirket).NotEmpty().WithMessage("Müşteri Şirket Bilgisi Boş Geçilemez!");
        }
    }
}
