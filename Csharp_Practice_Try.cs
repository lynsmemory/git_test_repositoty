using Mono.Cecil.Cil;
using System;
using UnityEngine;

public class Csharp_Practice_Try : MonoBehaviour
{
    int a = 5;
    int b = 0;
    int c;
    void Start()
    {
        c = a / b;
        //0으로 나눌경우 Devide By Zero Exception 오류가 발생합니다.
        //이 경우 Crash 발생과 프로그램이 강제 셧다운 될 수 있습니다.
        try
        {
            c = a / b;
        }
        catch(DivideByZeroException ie)
        //오류가 발생할 수 있는 부분에 catch(체크 할 오류 _ 변수이름) 로 작성하면 오류를 체크할 수 있습니다.
        //catch(Exception)의 경우 모든 오류를 체크합니다.
        {
            Debug.Log(ie);
            b = 1;
            c = a / b;
            Debug.Log(c);
        }
        catch(NullReferenceException ie)
        {
            Debug.Log(ie);
            Debug.Log("Null 오류");
        }
        finally
        //오류가 발생하든, 발생하지 않든 최종적으로 실행 될 마지막 코드 입니다.
        {
            Debug.Log(c);
            //5는 출력이 됩니다.
        }

        throw new Exception("강제로 오류를 발생시킨다");
        //throw는 강제로 오류를 발생시키는 키워드입니다.


    }

}
