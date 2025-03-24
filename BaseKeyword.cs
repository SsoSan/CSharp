using UnityEngine;

namespace Inheritance05
{
    public class BaseKeyword : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            (new My()).Run();
            (new My("LEXUS ES 300h")).Run();
            (new Your()).Run();
        }
    }
}