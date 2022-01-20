using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ListsConsole
{
    public class StudentSurnameEqualityComparer : IEqualityComparer<Student>
    {
        public bool Equals([AllowNull] Student x, [AllowNull] Student y)
        {
            return x.LastName.Equals(y.LastName);
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            return obj.LastName.GetHashCode();
        }
    }
}
