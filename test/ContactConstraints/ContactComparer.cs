using FriendZone.Entities;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace test.ContactConstraints
{
    // This class compares two contacts by their ids.
    // If two contacts have same ids, only then they are treated as equal  

    class ContactComparer : IComparer<Contact>
    {
        public int Compare([NotNull] Contact x, [NotNull] Contact y)
        {
            return x.ContactId.Equals(y.ContactId) == true ? 1 : 0;
        }
    }
}
