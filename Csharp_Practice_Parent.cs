using UnityEngine;

abstract public class Csharp_Practice_Parent : MonoBehaviour
//추상함수를 쓸 경우, 반드시 Class도 (추상)abstract가 추가되어야 합니다.
{
    protected string humanName;
    protected int humanAge;

    //public의 경우 타 Class 모두 변수에 접근이 가능합니다.
    //protected의 경우 상속받은 Child 클래스만 사용이 가능합니다.

    protected void info()
    {
        Debug.Log("나는 인간입니다.");
    }

    protected virtual void info2()
        //Child 클래스에서 변경 가능한 가상함수
    {
        Debug.Log("나는 아침을 먹었습니다.");
    }

    //추상함수
    abstract protected void Name();
}
