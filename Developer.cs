using UnityEngine;

namespace Override
{
    public class Developer : System.Object
    {
        public override string ToString()
        {
            return "개발자";
        }
    }

    public class WedDeneloper : Developer
    {
        public override string ToString()
        {
            return "웹 개발자";
        }
    }

    public class MobileDeveloper : Developer
    {
        public override string ToString()
        {
            return "모바일 개발자";
        }
    }
}