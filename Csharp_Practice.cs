using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEditor.iOS.Xcode;

public class Csharp_Practice : MonoBehaviour // MonoBehaviour : 유니티에서 제공하는 클래스, Csharp_Practice 클래스가 MonoBehaviour 클래스를 상속받음
{
    //7-2 전역변수 : 함수 밖에서 선언된 변수, 함수 안에서도 보이는 변수
    //참고 : void Start 내에 변수로 있으므로 중복됨
    int health = 30;
    string title = "전설의";
    string playerName = "나는 ROSCool";
    int level = 5;
    float strength = 15.5f;
    int exp = 1500;
    int mana = 25;
    bool isFullLevel = false;







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

        // ! (논리 NOT) : 참을 거짓으로, 거짓을 참으로 바꾸는 연산자
        //비교 연산자
        bool isEndTutorial = level > 10;
        Debug.Log("튜토리얼이 끝난 용사입니까?" + isEndTutorial);

        int health = 30;
        int mana = 25;
        // &&(논리 AND) : 양쪽이 모두 참일 때 참
        bool isBadCondition = health <= 50 && mana <= 20;
        Debug.Log("용사의 상태가 나쁩니까?" + isBadCondition);
        // ||(논리 OR) : 양쪽 중 하나라도 참이면 참
        bool isBadCondition2 = health <= 50 || mana <= 20;
        Debug.Log("용사의 상태가 나쁩니까?" + isBadCondition2);
        // ?: (삼항 연산자) : 조건식 ? 참일 때의 값 : 거짓일 때의 값
        string condition = isBadCondition ? "나쁨" : "좋음";
        Debug.Log("용사의 상태가 나쁩니까?" + isBadCondition);



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

        else if (isBadCondition && items[0] == "마나 물약 30")
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

        //6. 반복문 : 조건에 만족하면 특정 로직을 반복해서 실행하는 제어문

        //while문 : 조건이 True인 동안 로직 실행
        //while (조건) 
        //health--;
        //Debug.Log("독 데미지를 입었습니다. " + health);

        while (health > 0)
        {
            health--;
            if (health > 0)
            {
                Debug.Log("독 데미지를 입었습니다. " + health);

            }
            else
            {
                Debug.Log("용사가 사망하였습니다.");
            }

            if (health == 10)
            {
                Debug.Log("해독제를 사용합니다.");
                break;
            }
        }

        //for문 : 변수를 연산하면서 로직 반복 실행
        //for (연산될 변수 ; 조건 ; 연산){ 로직 }

        for (int count = 0; count < 10; count++)
        {
            health++;
            Debug.Log("붕대로 치료중... " + health);
        }
        //그룹형 변수의 길이 : Length(배열), Count(리스트)
        for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("이 지역에 있는 몬스터" + monsters[index]);
        }

        //foreach문 : for의 그룹형 변수 탐색 특화(요소를 하나씩 꺼내서 로직 반복 실행)
        //새로운 변수를 만들어서 연산으로 돌리는것이 아닌, 그룹형 변수에 있는 요소를 하나씩 꺼내서 로직 반복 실행
        foreach (string monster in monsters)
        {
            Debug.Log("이 지역에 있는 몬스터" + monster);
        }
        //매개변수 : 함수가 실행될 때, 함수 안으로 들어가는 값
        health = Heal(health);

        //Heal2 함수는 매개변수가 없지만, 전역변수 health를 사용하기 때문에, health가 10 증가하는 효과가 있다.
        Heal2();

        //Battle 함수는 몬스터의 레벨을 매개변수로 받아서, 용사가 이겼는지 졌는지 결과를 문자열로 반환하는 함수입니다.
        for (int index = 0; index < monsters.Length; index++)
        {
            Debug.Log("용사는" + monsters[index] + "에게" + Battle(monsterLevel[index]));
        }

        //8. 클래스 : 하나의 사물(오브젝트)와 대응하는 로직
        //8-1 Csharp_Practice_Class 참고
        //인스턴스 : 정의된 클래스를 변수 초기화로 실체화
        //클래스 이름, 변수명, = , new 클래스();
        Csharp_Practice_Class player = new Csharp_Practice_Class();
        player.id = 0;
        player.name = "나는 ROSCool2";
        player.title = "현명한";
        player.strength = 2.4f;
        player.weapon = "나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은" + player.level + "입니다.");

        //8-2 상속 : 부모 클래스의 기능을 자식 클래스가 물려받는 것
        Csharp_Practice_Class2 player2 = new Csharp_Practice_Class2();
        player.id = 0;
        player.name = "나는 ROSCool2";
        player.title = "현명한";
        player.strength = 2.4f;
        player.weapon = "나무 지팡이";
        Debug.Log(player.Talk());
        Debug.Log(player.HasWeapon());

        player.LevelUp();
        Debug.Log(player.name + "의 레벨은" + player.level + "입니다.");



    }

    //7. 함수 : 여러가지 기능을 편리하게 사용할 수 있도록 구성된 영역
    //return : 함수의 결과값을 반환하는 키워드
    //함수의 매개변수 이름은 실제 넣을 이름과 같지 않아도 된다. 함수 안에서만 사용되는 이름이기 때문에, 함수 밖에서는 보이지 않는다.
    int Heal(int currentHealth)
    {
        currentHealth += 10;
        Debug.Log("힐을 받았습니다. " + currentHealth);
        return currentHealth;
    }
    //void : 반환 데이터가 없는 함수 타입
    //지역변수 : 함수 안에서 선언된 변수, 함수 밖에서는 보이지 않는다.
    //지역변수를 사용하려면 전역변수로 만들어야 한다. (함수 밖에서 선언된 변수, 함수 안에서도 보이는 변수)
    //8, 9줄 참고
    void Heal2()
    {
        health += 10;
        Debug.Log("힐을 받았습니다. " + health);
    }

    string Battle(int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)
            result = "이겼습니다.";
        else
            result = "졌습니다.";

        return result;
    }






}