using UnityEngine;


public class Abc<T>
{
    public T var;
    public T[] array;
}


public class Csharp_Practice_Parameter_Class : MonoBehaviour
{
    Abc<string> a;
    Abc<float> b;

    void Start()
    {
        a.var = "abc";
        b.var = 4.5f;

        a.array = new string[1];
        b.array = new float[1];

        a.array[0] = "abc";
        b.array[0] = 4.5f;
    }

    
}
