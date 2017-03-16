using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    public class StrShift
    {
        private String Stored;


        public StrShift(String toStore)
        {
            this.Stored = toStore;
        }

        public static StrShift operator <<(StrShift a, int shift)

        {
            if (a == null)
            {
                throw new Exception("Can't shift null object");
            }

            //  "Microsoft" length
            int length = a.Stored.Length;
            if (shift > length)
            {
                shift = shift % length;
            }

            if(shift < 0)
            {
                return a >> -shift;
            }



            string str = a.Stored.Substring(length - shift, shift) + a.Stored.Substring(0, length - shift);
            return new StrShift(str);

        }

        public static StrShift operator >>(StrShift a, int shift)

        {
            if (a == null)
            {
                throw new Exception("Can't shift null object");
            }

            //  "Microsoft" length
            int length = a.Stored.Length;
            if (shift > length)
            {
                shift = shift % length;
            }

            if (shift < 0)
            {
                return a << -shift;
            }

            string str = a.Stored.Substring(shift, length - shift) + a.Stored.Substring(0, shift);
            return new StrShift(str);

        }

        public static implicit operator StrShift(string stringValue)
        {
            return new StrShift(stringValue);
        }

        public static bool operator ==(StrShift a, StrShift b)
        {
            // If both are null, or both are same instance, return true.
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            // Return true if the fields match:
            return a.Stored == b.Stored;
        }

        public static bool operator !=(StrShift a, StrShift b)
        {
            return !(a.Stored == b.Stored);
        }

        public override String ToString()
        {
            return "" + this.Stored;
        }

        public override bool Equals(System.Object obj)
        {
            // If parameter is null return false.
            if (obj == null)
            {
                return false;
            }

            // If parameter cannot be cast to Point return false.
            StrShift p = obj as StrShift;
            if ((System.Object)p == null)
            {
                return false;
            }

            // Return true if the fields match:
            return this.Stored == p.Stored;
        }

        public override int GetHashCode()
        {
            return Stored.GetHashCode();
        }

    }
}
