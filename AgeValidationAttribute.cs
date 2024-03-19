using System;

namespace Attributes
{
    public class AgeValidationAttribute : Attribute
    {
        public int Age { get; }

        public AgeValidationAttribute(int age)
        {
            this.Age = age;
        }
    }
}