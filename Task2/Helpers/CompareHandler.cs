﻿using cwiczenia2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cwiczenia2.Helpers
{
    class CompareHandler : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
           
            return StringComparer.CurrentCultureIgnoreCase.Equals($"{x.Name} {x.Surname} {x.Index}", $"{y.Name} {y.Surname} {y.Index}");
        }

        public int GetHashCode([DisallowNull] Student student)
        {
            return StringComparer.CurrentCultureIgnoreCase.GetHashCode($"{student.Name} {student.Surname} {student.Index}");
        }
    }
}
