﻿using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;
using FluentValidation.Validators;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        //kurallar buraya yazılır
        public CarValidator()
        {
            RuleFor(c => c.CarName).NotEmpty();
            RuleFor(c => c.CarName).MinimumLength(2);
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.ModelYear).GreaterThan(1990);
        }
    }
}
