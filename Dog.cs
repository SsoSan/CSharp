using UnityEngine;

namespace Method
{
    public class Dog
    {
        // 필드 선언
        public static int point = 10;
        public int weight = 20;

        public void Eat()
        {
            Debug.Log("[1] 맘마");
            Digest();
        }

        public static void Drink()
        {
            Debug.Log("[2] 우유");
        }

        private void Digest()
        {
            Debug.Log("[3] 간식");
        }
    }
}