using UnityEngine;

//RelationalOperator(������ ������, �� ������)
// < (����), <= (�۰ų� ����), > (ŭ), >= (ũ�ų� ����), == (����), != (�ٸ�)
// ��� : true(��), false(����)
public class RelationalOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = 5;

        Debug.Log(x < y); //x(3)�� y(5)���� ������? -> true 
        Debug.Log(x <= y); //x(3)�� y(5)���� �۰ų� ������? ->
        Debug.Log(x > y); //x(3)�� y(5)���� ũ��? ->
        Debug.Log(x >= y); //x(3)�� y(5)���� ũ�ų� ������? ->
        Debug.Log(x == y); //x(3)�� y(5)���� ������? ->
        Debug.Log(x != y); //x(3)�� y(5)���� �ٸ���? ->

        Debug.Log("AAA" == "aaa"); //

    }
}