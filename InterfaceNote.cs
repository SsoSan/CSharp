using UnityEngine;

namespace Interface
{
    public class InterfaceNote : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            LEXUS goodCar = new LEXUS(new Good());
            goodCar.Run();

            LEXUS badCar = new LEXUS(new Bad());
            badCar.Run();
        }
    }
}