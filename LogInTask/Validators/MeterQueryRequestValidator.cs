using FluentValidation;
using LogInTask.Models;
using System.Text.RegularExpressions;

namespace LogInTask.Validators
{
    public class MeterQueryRequestValidator : AbstractValidator<MeterQueryRequest>
    {
        public MeterQueryRequestValidator()
        {
            RuleFor(x => x.MeterNo)
                .NotEmpty().WithMessage("رقم العداد مطلوب.")
                .Must(BeDigitsOnly).WithMessage("رقم العداد يجب أن يحتوي على أرقام فقط.")
                .Must(BeValidLength).WithMessage("رقم العداد يجب أن يكون 11 أو 13 رقمًا.");

            RuleFor(x => x.Amount)
                .NotEmpty().WithMessage("المبلغ مطلوب.")
                .InclusiveBetween(20, 500).WithMessage("المبلغ يجب أن يكون بين 20 و 500.");
        }

        private bool BeDigitsOnly(string? s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            return Regex.IsMatch(s, @"^\d+$");
        }

        private bool BeValidLength(string? s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            return s.Length == 11 || s.Length == 13;
        }
    }
}
