using NUnit.Framework.Constraints;
using System.Collections.Generic;

namespace test.ContactConstraints
{
    // This class contains Constraint extension for comparing two contacts using Custom Constraints

    static class IdenticalContactExtensions
    {
        public static IdenticalContactListConstraint IdenticalTo(this ConstraintExpression expression, List<Contact> expectedList)
        {

        }
        public static IdenticalContactConstraint IdenticalTo(this ConstraintExpression expression, Contact expected)
        {

        }

    }
}
