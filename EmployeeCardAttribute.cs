using System;

namespace Attributes
{
    public class EmployeeCardAttribute : Attribute
    {
        public string Label { get; set; }
        public EmployeeCardAttribute(string Label) 
        {
            this.Label = Label;
        }
    }
}