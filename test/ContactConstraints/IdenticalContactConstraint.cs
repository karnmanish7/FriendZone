using NUnit.Framework.Constraints;

namespace test.ContactConstraints
{
    //This class contains logic to compare two contacts and use it for creating Customized Constraint for Assertion

    class IdenticalContactConstraint : Constraint
    {
        public override ConstraintResult ApplyTo<TActual>(TActual actual)
        {
            throw new System.NotImplementedException();
        }
    }
}
