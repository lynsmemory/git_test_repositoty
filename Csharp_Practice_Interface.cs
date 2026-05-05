using UnityEngine;


abstract public class  A : MonoBehaviour
    //추상 Class (abstract)
{
    public int a;
    //class의 경우에는 변수를 선언하여 가져와 사용이 가능합니다.
    abstract public void Abc();
}

abstract public class B : MonoBehaviour
{
    abstract public void Bbc();
}

interface ITest
//다중 상속 가능, 뼈대(골격) 제공
//interface의 경우에는 변수가 올 수 없습니다. public int b; 불가
//가능한 것은 아래와 같습니다.
//함수, 프로퍼티, 인덱서, 이벤트
{
    void Cbc();

    int SalaryP {  get; set; }
    //위와 같이 뼈대만 만들어야 합니다.
}

interface ITest2 : ITest
    //interface간의 상속도 가능합니다.
{

}

public class Csharp_Practice_Interface : A, ITest //우클릭 후 빠른 작업 및 리팩터링 클릭 -> 추상클래스 구현 클릭 시 자동완성 됩니다.

//미완성인 Abc를 자식 Class에서 완성시켜야 합니다.
//class 상속은 1개만 가능합니다.
//A,B가 모두 abstract인경우 아래와 같이 불가능합니다.
//public class Csharp_Practice_Interface : A, B 처럼 작성할경우 불가능합니다.
//다중의 class를 상속받기 위해서는 Interface를 사용해야 합니다.
{
    public int SalaryP 
    { 
        get
        { 
            throw new System.NotImplementedException();
        }
        set
        {
            throw new System.NotImplementedException();
        }
    }

    public override void Abc()
    {
        a = 5;
        Debug.Log("Abc Test");
    }

    public void Cbc()
        //interface는 override를 사용하지 않습니다.
    {
        Debug.Log("Cbc Test");
    }



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
