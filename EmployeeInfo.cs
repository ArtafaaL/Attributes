using System;
using System.Reflection;

namespace Attributes
{
    [AgeValidation(16)]
    public class EmployeeInfo
    {

        [EmployeeCard("Возраст")]
        public int Age { get; set; }
        [EmployeeCard("Имя")]
        public string Name { get; set; }

        [EmployeeCard("Фамилия")]
        public string Surname { get; set; }

        public EmployeeInfo(string name, string surname, int age)
        {
            this.Name = name; this.Surname = surname; this.Age = age;
        }

        public static void GetClassInfo()
        {
            Type type = typeof(EmployeeInfo);

            Console.WriteLine("Рефлексия класса:");
            Console.WriteLine();
            foreach (MemberInfo member in type.GetMembers())
            {
                Console.WriteLine($"{member.DeclaringType} {member.MemberType} {member.Name}");
            }
            Console.WriteLine();
        }

        public void GetEmployeeInfo()
        {
            Type type = typeof(EmployeeInfo);

            foreach (var e in this.GetType().GetProperties())
            {
                var attribute = e.GetCustomAttribute<EmployeeCardAttribute>();
                Console.WriteLine(attribute.Label + ": " + e.GetValue(this));
            }

            object[] attributes = type.GetCustomAttributes(false);

            foreach (Attribute attr in attributes)
            {
                if (attr is AgeValidationAttribute ageAttribute)
                    Console.WriteLine($"Разрешение трудоустраиваться: {ageAttribute.Age <= this.Age}");
            }

            Console.WriteLine();
        }
    }
}