using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class Csharp_Practice : MonoBehaviour
{

    void Start()
    {
        //문자열 출력
        Debug.Log("Hello World!");
        //1. 변수 : 데이터를 메모리에 저장하는 장소 or 상자
        //정수형 : 소수점이 없는 숫자
        int level = 5;
        //실수형 : 소수점이 있는 숫자
        float strength = 15.5f;
        //문자형 : 문자 하나를 저장하는 자료형
        string playerName = "나는 ROSCool";
        //논리형 : 참과 거짓을 저장하는 자료형
        bool isFullLevel = false;

        // 선언 -> 초기화 -> 호출(사용) 순으로 진행

        Debug.Log("용사의 이름은?");
        Debug.Log(playerName);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);
        Debug.Log("용사의 만렙인가?");
        Debug.Log(isFullLevel);


        //2. 그룹형 변수(배열) : 여러 개의 데이터를 하나로 묶어서 저장하는 변수
        string[] monsters = { "슬라임", "고블린", "드래곤" };
        

        Debug.Log("맵에 존재하는 몬스터");
        Debug.Log(monsters[0]);
        Debug.Log(monsters[1]);
        Debug.Log(monsters[2]);



        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 20;

        Debug.Log("맵에 존재하는 몬스터의 레벨");
        Debug.Log(monsterLevel[0]);
        Debug.Log(monsterLevel[1]);
        Debug.Log(monsterLevel[2]);



        List<string> items = new List<string>();
        items.Add("생명력 물약 30");
        items.Add("마나 물약 30");

        Debug.Log("인벤토리에 존재하는 아이템");
        Debug.Log(items[0]);
        Debug.Log(items[1]);

        //아이템 삭제
        items.RemoveAt(0);

        Debug.Log("인벤토리에 존재하는 아이템");
        Debug.Log(items[0]);


        //3. 연산자 : 데이터를 가공하는 기호
        int exp = 1500;

        exp = 1500 + 320;
        exp = exp - 10;
        level = exp / 300;
        strength = level * 3.1f;

        Debug.Log("용사의 총 경험치는?");
        Debug.Log(exp);
        Debug.Log("용사의 레벨은?");
        Debug.Log(level);
        Debug.Log("용사의 힘은?");
        Debug.Log(strength);

        //특이한 연산자 : %(나머지 연산자) : 나눗셈의 나머지를 구하는 연산자
        int nextExp = 300 - (exp % 300);
        Debug.Log("다음 레벨까지 남은 경험치는?");
        Debug.Log(nextExp);

        //문자열 연산자 : 문자열을 이어붙이는 연산자
        string title = "전설의";
        Debug.Log("용사의 이름은?");
        Debug.Log(title + " " + playerName);

        int fullLevel = 99;
        isFullLevel = level == fullLevel; //레벨이 만렙과 같은가?
        Debug.Log("용사가 만렙인가?" + isFullLevel);

        //비교 연산자
        bool isEndTutorial = level > 10;
        Debug.Log("튜토리얼이 끝난 용사입니까?" + isEndTutorial);

        int health = 30;
        int mana = 25;
        bool isBadCondition = health <= 50 && mana <= 20;
        Debug.Log("용사의 상태가 나쁩니까?" + isBadCondition);

        bool isBadCondition2 = health <= 50 || mana <= 20;
        Debug.Log("용사의 상태가 나쁩니까?" + isBadCondition2);

        string condition = isBadCondition ? "나쁨" : "좋음";

        
        
        //4. 키워드 : 프로그래밍 언어를 구성하는 특별한 단어
        // 변수 이름으로 사용할 수 없고, 값으로도 사용할 수 없다.
        //ex) int folat
        //ex2) string bool new List


        //5. 조건문 : 조건에 만족하면 로직을 실행하는 제어문
        // if : 조건이 True일 때, 로직 실행 (Bool)
        if (condition == "나쁨")
        {
            Debug.Log("플레이어 상태가 나쁘니 아이템을 사용하세요.");
        }

        else // 앞의 if가 실행되지 않으면 실행
        {
            Debug.Log("플레이어 상태가 좋습니다.");
        }

        //용사의 상태가 나쁘면서 현재 가지고 있는 아이템을 사용하는 로직

        if (isBadCondition && items[0] == "생명력 물약 30")
        {
            items.RemoveAt(0);
            health += 30;
            Debug.Log("생명포션 30을 사용하였습니다.");
        }

        else if(isBadCondition && items[0] == "마나 물약 30")
        {
            items.RemoveAt(0);
            mana += 30;
            Debug.Log("마나포션 30을 사용하였습니다.");
        }

        // switch, case : 변수의 값에 따라 로직 실행

        //switch (변수) { 케이스 값: break;}

        switch (monsters[0])
        {
            case "슬라임":
            case "사막뱀":     //이런식으로 같이 묶어서도 사용 가능
                Debug.Log("소형 몬스터가 출현!");
                break;
            case "악마":
                Debug.Log("중형 몬스터가 출현!");
                break;
            case "골렘":
                Debug.Log("대형 몬스터가 출현!");
                break;
            default:
                Debug.Log("???몬스터가 출현");
                break;


        }









    }










}
