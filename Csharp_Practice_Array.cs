using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Csharp_Practice_Array : MonoBehaviour
{


    // 배열

    int[] exp = new int[5] { 1, 2, 3, 4, 5 };

    //1. arrayList : 배열과 비슷하지만 크기가 가변적, 다양한 자료형을 저장할 수 있음

    //System.Collections 의 ArrayList 클래스 사용
    //ArrayList에는 자료형이 지정되지 않으므로, 다양한 자료형을 저장할 수 있지만, 타입 안정성이 떨어질 수 있음
    //ArrayList는 부하가 크고, 성능이 떨어질 수 있으므로, 일반적으로 List<T>와 같은 제네릭 컬렉션을 사용하는 것이 좋습니다.
    ArrayList arrayList = new ArrayList();

    //2. List 
    //List : 배열과 비슷하지만 크기가 가변적, 특정 자료형만 저장할 수 있음
    //현재의 경우 정수형만 저장이 가능합니다.
    List<int> list = new List<int>();

    //3. HashTable
    //HashTable : 키와 값의 쌍으로 데이터를 저장하는 컬렉션, 키를 사용하여 값을 빠르게 검색할 수 있음
    Hashtable hashTable = new Hashtable();


    //4. Dictionary
    //Dictionary : 키와 값의 쌍으로 데이터를 저장하는 제네릭 컬렉션, 키를 사용하여 값을 빠르게 검색할 수 있음
    //Dictionary<TKey, TValue> 클래스 사용, 현재는 키가 문자열이고 값이 정수형인 Dictionary를 선언
    //Dictionary는 HashTable과 유사하지만, 제네릭 컬렉션이므로 타입 안정성이 높고, 성능이 향상될 수 있습니다.
    Dictionary<string, int> dictionary = new Dictionary<string, int>();

    //5. Queue
    //Queue : 먼저 들어온 데이터가 먼저 나가는 선입선출(FIFO (Fisrt In First Out)) 방식의 컬렉션
    //Queue 클래스 사용, 현재는 정수형 데이터를 저장하는 Queue를 선언
    //1, 2, 3이 순서대로 들어오면, 1이 먼저 나가고, 그 다음에 2, 3이 나가는 구조입니다.
    //예로 은행 대기열이 있습니다. 먼저 온 고객이 먼저 서비스를 받는 구조입니다.
    Queue<int> queue = new Queue<int>();

    //6. Stack
    //Stack : 나중에 들어온 데이터가 먼저 나가는 후입선출(LIFO (Last In First Out)) 방식의 컬렉션
    //Stack 클래스 사용, 현재는 정수형 데이터를 저장하는 Stack을 선언
    // 1, 2, 3이 순서대로 들어오면, 3이 먼저 나가고, 그 다음에 2, 1이 나가는 구조입니다.
    //예로 책 더미가 있습니다. 나중에 쌓은 책이 먼저 떨어지는 구조입니다.
    Stack<int> stack = new Stack<int>();


    void Start()
    {
        //1-1
        arrayList.Add(1); // 정수형 추가
        arrayList.Add(2); // Add는 메서드로, ArrayList에 요소를 추가하는 역할을 합니다.
        arrayList.Add(3);
        arrayList.Add("가나다라");
        arrayList.Add(4.5f);

        //print(arrayList.Length); // ArrayList는 Length 속성이 없고 Count 속성을 사용해야 합니다.
        Debug.Log(arrayList.Count); // Count는 ArrayList에 저장된 요소의 개수를 반환하는 속성입니다.\
        // 반환된 값은 5입니다.

        for (int i = 0; i < arrayList.Count; i++) // Length 대신 Count를 사용하여 ArrayList의 요소 개수를 확인해야 합니다.
        {
            Debug.Log(arrayList[i]); // for 문을 사용하여 ArrayList의 각 요소를 출력합니다. (i는 0부터 시작하여 지정된 Count까지 반복됩니다. 현재는 0~4)
            //출력 결과는 다음과 같습니다:
            // 1
            // 2
            // 3
            // 가나다라
            // 4.5
        }

        //1-2
        //ArrayList 지우기
        arrayList.Remove("가나다라"); 
        // Remove 메서드를 사용하여 ArrayList에서 특정 요소를 제거할 수 있습니다.
        // 이 경우 "가나다라"라는 문자열이 제거됩니다.
        arrayList.RemoveAt(3);
        // RemoveAt 메서드를 사용하여 ArrayList에서 특정 인덱스에 있는 요소를 제거할 수 있습니다.
        // 이 경우 인덱스 3에 있는 요소가 제거됩니다.
        // (인덱스는 0부터 시작하므로, 3은 네 번째 요소를 가리킵니다.)
        arrayList.RemoveRange(1, 3);
        //removeRange 메서드를 사용하여 ArrayList에서 특정 범위의 요소를 제거할 수 있습니다.
        // 이 경우 인덱스 1부터 시작하여 3개의 요소가 제거됩니다.
        // (인덱스 1은 두 번째 요소를 가리키며, 2개의 요소가 제거되므로 인덱스 2부터 4까지 요소가 제거됩니다.)
        arrayList.Clear();
        // Clear 메서드를 사용하여 ArrayList의 모든 요소를 제거할 수 있습니다.
        // 이 경우 ArrayList가 완전히 비워집니다.
        // Clear 메서드를 호출한 후에는 ArrayList의 Count가 0이 됩니다.

        //1-3
        //ArrayList 변경 후 출력
        arrayList[3] = 4;
        // ArrayList의 특정 인덱스에 새로운 값을 할당하여 요소를 변경할 수 있습니다.
        // 이 경우 인덱스 3에 있는 요소가 4로 변경됩니다.
        // 가나다라가 제거되고 인덱스는 4로 변경됩니다.
        arrayList.CopyTo(exp);
        // CopyTo 메서드를 사용하여 ArrayList의 요소를 다른 배열로 복사할 수 있습니다.
        // 이 경우 ArrayList의 요소가 exp 배열로 복사됩니다.

        //1-4
        // 특정 요소 포함 여부 확인
        arrayList.Contains("가나다라");
        // Contains 메서드를 사용하여 ArrayList에 특정 요소가 포함되어 있는지 확인할 수 있습니다.
        // 이 경우 "가나다라"라는 문자열이 ArrayList에 포함되어 있는지 확인합니다.
        // Contains 메서드는 true 또는 false를 반환합니다. 현재는 "가나다라"가 제거되었으므로 false가 반환됩니다.

        //1-5
        // 끼워넣기
        arrayList.Insert(1, 1.5);
        // Insert 메서드를 사용하여 ArrayList의 특정 인덱스에 새로운 요소를 삽입할 수 있습니다.
        // 이 경우 인덱스 1에 1.5라는 값을 삽입합니다.
        // 삽입된 요소는 기존 요소들을 오른쪽으로 이동시키며, 인덱스 1에 1.5가 추가됩니다.
        // 삽입된 후의 ArrayList는 다음과 같습니다:
        // 1, 1.5, 2, 3, 4.5

        
        //2-1
        //list.Add("가나다라"); 
        // List는 제네릭 컬렉션이므로, 특정 자료형을 지정하여 사용할 수 있습니다.
        // 현재는 int로 지정되어 있으므로 문자열을 추가할 수 없습니다.
        // 이 경우 컴파일 오류가 발생합니다.
        list.Add(1);
        // List에 정수형 요소를 추가할 수 있습니다. 이 경우 1이 추가됩니다.
        // List에 요소를 추가한 후에는 Count가 증가합니다. 현재는 Count가 1이 됩니다.
        // List의 요소를 출력하려면 for 문을 사용하여 인덱스를 통해 접근할 수 있습니다.
        // 예를 들어, list[0]을 출력하면 1이 출력됩니다.

        //3-1
        hashTable.Add("만", 10000);
        // HashTable에 키와 값을 추가할 수 있습니다. 이 경우 "만"이라는
        hashTable.Add("백만", 1000000);
        // HashTable에 "백만"이라는 키와 1000000이라는 값을 추가합니다.
        hashTable.Add(50, "1억");
        // HashTable에 50이라는 키와 "백만"이라는 값을 추가합니다.

        //3-2
        //Debug.Log(hashTable[0]);
        // HashTable은 키와 값의 쌍으로 데이터를 저장하므로, 인덱스를 사용하여 값을 직접 접근할 수 없습니다.
        // 이 경우 컴파일 오류가 발생합니다.
        // HashTable에서 값을 검색하려면 키를 사용해야 합니다. 예를 들어, hashTable["만"]을 출력하면 10000이 출력됩니다.

        Debug.Log(hashTable["만"]);
        // HashTable에서 "만"이라는 키에 해당하는 값을 출력합니다. 이 경우 10000이 출력됩니다.
        //HashTable에서 "백만"이라는 키에 해당하는 값을 출력하려면 hashTable["백만"]을 사용하면 됩니다. 이 경우 1000000이 출력됩니다.

        Debug.Log(hashTable[50]);
        // HashTable에서 50이라는 키에 해당하는 값을 출력합니다. 이 경우 "1억"이 출력됩니다.
        // HashTable에서 키를 사용하여 값을 검색할 때, 해당 키가 존재하지 않으면 null이 반환됩니다. 예를 들어, hashTable["십만"]을 출력하면 null이 출력됩니다.

        //3-3
        //Remove 메서드를 사용하여 HashTable에서 특정 키와 해당 값을 제거할 수 있습니다. 예를 들어, hashTable.Remove("만")을 호출하면 "만"이라는 키와 해당 값이 HashTable에서 제거됩니다.
        //RemoveAt 메서드는 HashTable에서 사용할 수 없습니다. HashTable은 키와 값의 쌍으로 데이터를 저장하므로, 특정 인덱스에 있는 요소를 제거하는 것은 불가능합니다.
        //Clear 메서드를 사용하여 HashTable의 모든 키와 값을 제거할 수 있습니다. 예를 들어, hashTable.Clear()를 호출하면 HashTable이 완전히 비워집니다.
        //ContainsKey 메서드를 사용하여 HashTable에 특정 키가 포함되어 있는지 확인할 수 있습니다.


        //4-1
        //dictionary.Add(100, 100);
        // Dictionary에 키와 값을 추가할 수 있습니다.
        // 현재 Dictionary는 string을 키로, int를 값으로 선언되어 있으므로, int형 키를 추가하려고 하면 컴파일 오류가 발생합니다.

        dictionary.Add("가", 100);

        //5-1
        //queue.Enqueue는 Queue에 요소를 추가하는 메서드입니다.
        //Enqueue 메서드를 사용하여 Queue의 끝에 요소를 추가할 수 있습니다.
        queue.Enqueue(5);
        queue.Enqueue(10) ;

        Debug.Log(queue.Dequeue());
        // Dequeue 메서드는 Queue에서 가장 먼저 들어온 요소를 제거하고 반환하는 메서드입니다.
        // 이 경우 5가 가장 먼저 들어왔으므로, Dequeue를 호출하면 5가 제거되고 반환됩니다. 따라서 출력 결과는 5입니다.
        Debug.Log(queue.Dequeue());
        // 다음으로 10이 들어왔으므로, Dequeue를 호출하면 10이 제거되고 반환됩니다. 따라서 출력 결과는 10입니다.
        // Queue에서 요소를 Dequeue한 후에는 해당 요소가 Queue에서 제거되므로, 다음 Dequeue를 호출하면 Queue가 비어있게 됩니다.
        Debug.Log(queue.Dequeue());
        // Queue가 비어있는 상태에서 Dequeue를 호출하면 InvalidOperationException이 발생합니다. 따라서 이 경우에는 예외 처리를 해주는 것이 좋습니다.
        // 조건문을 사용하여 Queue가 비어있는지 확인한 후에 Dequeue를 호출하는 것이 안전합니다.
        // 예를 들어 if(queue.Count !=0) 등의 조건문을 사용하여 Queue가 비어있지 않은 경우에만 Dequeue를 호출하도록 할 수 있습니다.

        //6-1
        //stack.Push는 Stack에 요소를 추가하는 메서드입니다.

        //stack.Push("가나다라");
        // Stack은 제네릭 컬렉션이므로, 특정 자료형을 지정하여 사용할 수 있습니다.
        // 현재 Stack은 int로 선언되어 있으므로 문자열을 추가하려고 하면 컴파일 오류가 발생합니다.
        // 이 경우 컴파일 오류가 발생합니다. Stack에 정수형 요소를 추가하려면, stack.Push(1)과 같이 정수형 값을 추가해야 합니다.
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        Debug.Log(stack.Pop());
        // Pop 메서드는 Stack에서 가장 나중에 들어온 요소를 제거하고 반환하는 메서드입니다.
        // 이 경우 3이 가장 나중에 들어왔으므로, Pop을 호출하면 3이 제거되고 반환됩니다. 따라서 출력 결과는 3입니다.
        Debug.Log(stack.Pop());
        // 다음으로 2가 들어왔으므로, Pop을 호출하면 2가 제거되고 반환됩니다. 따라서 출력 결과는 2입니다.
        Debug.Log(stack.Pop());
        // 다음으로 1이 들어왔으므로, Pop을 호출하면 1이 제거되고 반환됩니다. 따라서 출력 결과는 1입니다.
        // Stack에서 요소를 Pop한 후에는 해당 요소가 Stack에서 제거되므로, 다음 Pop을 호출하면 Stack이 비어있게 됩니다.
        Debug.Log(stack.Pop());
        // Stack이 비어있는 상태에서 Pop을 호출하면 InvalidOperationException이 발생합니다. 따라서 이 경우에는 예외 처리를 해주는 것이 좋습니다.
        // 조건문을 사용하여 Stack이 비어있는지 확인한 후에 Pop을 호출하는 것이 안전합니다.
        // 예를 들어 if(stack.Count !=0) 등의 조건문을 사용하여 Stack이 비어있지 않은 경우에만 Pop을 호출하도록 할 수 있습니다.


    }


}
