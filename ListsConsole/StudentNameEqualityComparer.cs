using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ListsConsole
{
    public class StudentNameEqualityComparer : IEqualityComparer<Student>
    {
        public bool Equals([AllowNull] Student x, [AllowNull] Student y)
        {
            return x.FirstName == y.FirstName;
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            return obj.FirstName.GetHashCode();
        }
    }
}
