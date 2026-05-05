using System.Collections;
using UnityEngine;

public class Csharp_Practice_Coroutine : MonoBehaviour
{

    Coroutine myCoroutine1;
    Coroutine myCoroutine2;
    
    private IEnumerator myCoroutine3;



    void Start()
    {
        LoopA();
        LoopB();
        //위의 경우 LoopA 함수의 모든 조건을 끝내고 LoopB 함수로 넘어갑니다. (1 2 3 ... 1 2 3 ...)
        
        myCoroutine1 = StartCoroutine(LoopC());
        myCoroutine2 = StartCoroutine(LoopD());
        //Coroutine은 StartCoroutine이라는 메소드를 입력 후 그 안에 넣어줘야 합니다.
        //위의 경우 LoopC, LoopD 모두 1초마다 실행하도록 하였으므로, i와 x값이 1초마다 출력됩니다. ( 1 1 2 2 3 3 ...)

        StartCoroutine(Stooop());
        //StopCoroutine을 사용할 경우, Coroutine Class에 대입 후 사용해야 합니다.

        StartCoroutine("LoopE");
        //Coroutine은 문자열로 지정하여 시작할수도 있습니다. (단, 정지시에도 해당 문자열을 입력해야합니다.
        //문자열로 할 경우 일반식에 비해 부하가 큽니다.

        StartCoroutine(Stooop2());

        myCoroutine3 = LoopF();
        StartCoroutine(myCoroutine3);
        //위 방법은 IEnumerator를 미리 선언한 후 Coroutine을 실행하는 방법입니다.
        //이 방법은 Parameter가 많을 때 유리합니다.


    }
    //#은 전처리 기능입니다. #region 지정이름 / endregion 지정이름
    #region Loop 
    void LoopA()
    {
        for (int i = 0; i < 100; i++)
        {
            Debug.Log("i의 값 = " + i);
        }
    }

    void LoopB()
    {
        for (int x = 0; x < 100; x++)
        {
            Debug.Log("x의 값 = " + x);
        }
    }

    IEnumerator LoopC()
    {
        for (int i = 0; i < 100; i++)
        {
            Debug.Log("i의 값 = " + i);
            yield return new WaitForSeconds(1f);
            //Coroutine의 경우 반드시 시간과 관련된 문법이 있습니다.
            //yeild return : 일정 시간만큼 대기시켜주는 문법입니다.
            //null;을 입력할 경우 1프레임을 대기합니다.
            //new WaitForSecond()를 입력할 경우 괄호 안의 시간만큼 대기합니다.
            //ex) 1f = 1초 0.1f = 0.1초
        }
    }

    IEnumerator LoopD()
    {
        for (int x = 0; x < 100; x++)
        {
            Debug.Log("x의 값 = " + x);
            yield return new WaitForSeconds(1f);
        }
    }
    #endregion Loop
    IEnumerator Stooop()
    {
        yield return new WaitForSeconds(2f);
        //StopCoroutine(LoopC());
        //위와 같이 작성할 경우 StopCoroutine은 실행되지 않습니다.
        //반드시 Coroutine Class를 만들어야 합니다. - Coroutine myCoroutine1;
        StopCoroutine(myCoroutine1);


        yield return new WaitForSeconds(2f);
        StopCoroutine (myCoroutine2);
    }


    IEnumerator LoopE()
    {
        for (int i = 0; i < 100; i++)
        {
            Debug.Log("i의 값 = " + i);
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator LoopF()
    {
        for (int x = 0; x < 100; x++)
        {
            Debug.Log("x의 값 = " + x);
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator Stooop2()
    {
        yield return new WaitForSeconds(2f);
        
        StopCoroutine("LoopE");


        yield return new WaitForSeconds(2f);
        StopCoroutine(myCoroutine3);

        yield return new WaitForSeconds(1f);
        StopAllCoroutines();
        //StopAllCoroutines은 해당 class에서 동작중인 모든 Coroutine을 정지합니다.
    }


}
