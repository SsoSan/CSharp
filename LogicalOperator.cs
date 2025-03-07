using UnityEngine;

public class LogicalOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 3;
        int j = 5;
        bool r = false;

        r = (i == 3) && (j != 3); // true && true
        Debug.Log("r: " + r);

        r = (i != 3) || (j == 3);   // false || false
        Debug.Log("r: " + r);   // => false

        r = (i >= 5);           // false
        Debug.Log("!r: " + !r); // => true


        Debug.Log((1 == 1) || (1 != 1));    // => true || false

        //
        bool bln1 = true;
        bool bln2 = false;

        Debug.Log(bln1 && bln2);    // true && false
        Debug.Log(bln1 || bln2);    // true || false

    }
}