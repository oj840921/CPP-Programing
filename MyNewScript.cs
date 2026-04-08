using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    /*
     * 변수 데이터 형식
     * - 각각의 변수는 데이터 형식을 갖는다.
     * - int, float, bool, string, Vector3
     * ex
     *  - int(정수 또는 자연수) = -3, -2, -1, 0, 1, 2, 3 ...
     *  - float(소수 또는 부동소수점) = 3.14, 0.5, -1.5 ...
     *  - bool(참/거짓) = true, flase(1 혹은 0)
     *  - string(문자열) = "a", "Hello World", "피터팬" ...
     *  - Vector3(위치값) = (0, 0, 0), (10, 2, 1) //3는 3차원, 2는 2차원, 1은 1차원 // X, Y, Z축을 표현
     */
    // 변수 선언
    public string playerName = "피터팬";     // 문자열
    public int playerHealth = 100;          // 상수(정수 : 소수점이 없는 것), ex. 점수, HP, MP
    public float playerMP = 100;            // 상수(실수 : 소수점이 있는 것)
    public Vector3 position = Vector3.zero; // 객체(구, 캡슐, 평지 등)의 위치, 회전, 크기 
    public float value = 0.5f;              // 변수(실수) : 소수점이 있는 것


    // 열거형을 사용해 가능한 상태를 정의한다.
    public enum EnemyState { CHASE, FLEE, FIGHT, HIDE };

    // 적의 현재 상태
    public EnemyState ActiveState = EnemyState.CHASE;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*
        playerMP = playerMP * value;

        Debug.Log("플레이어의 : " + playerMP);
        */
    }

    // Update is called once per frame
    void Update()
    {
        /* playerHealth를 검사한다. 한 줄짜리의 내용의 if문에서 중괄호는 옵션이다.
         *      if (조건문)
         *      {
         *          실행문;
         *      }
         */
        /*
         if (playerHealth == 100)
         {
            Debug.Log("Player has full health.");
         }
        */

        /*
         * 
         */

        /*
        if (playerHealth > 100)
        {
            Debug.Log("Player has full health.");
        }
        else
        {
            Debug.Log("Player has not full health.");
        }
        */

        /*
         * 또는( = or, ||) : A or B, A나 B중에 하나라도 맞으면 OK
         * 그리고 ( = and, &&) : A and B, A하고 B가 모두 맞아야 OK
         * 같지 않다면(!=) : A != B, A와 B가 같지 않다면 OK
         * 같다(==) : A == B, A와 B가 같다면 OK
         */

        /*
        if (playerHealth >= 0 && playerHealth <= 100 && playerHealth != 50)
        {
            Debug.Log("Player has full health.");
        }
        else
        {
            Debug.Log("Player has not full health.");
        }
        */

        /* Switch문 : Unity6(C#)
         * 여러 조건 중 하나를 선택해 실행할 때 if~else보다 가독성 좋게 코드를 작성할 수 있게 해줌
         * 게임 상태(State) 또는 아이템 등급 등을 구분할 때 자주 사용
         * 
         * 1. 기본 Switch 문(Classic)
         * 특정 변수의 값에 따라 다른 행동을 하게 할 때 사용
         * case 끝에는 반드시 break;가 필요하다
         * 
         * 예) enum : 열거형
         * 
         * public enum playerState = { Idle, Walk, Jump, Die }
         * public playerState currentState = playerState.Idle;
         * 
         * void Update()
         * {
         *      switch (currentState)
         *      {
         *          case playerState.Idle:
         *              Debug.Log("대기 애니메이션 재생");
         *              break;
         *              case playerState.Walk:
         *              Debug.Log("걷기 애니메이션 재생");
         *              break;
         *              case playerState.Jump:
         *              Debug.Log("점프 애니메이션 재생");
         *              break;
         *              case playerState.Die:
         *              Debug.Log("사망 애니메이션 재생");
         *              break;
         *          defalt:
         *              Debug.Log("Player의 춤추는 애니메이션 재생");
         *              break;
         *      }
         *          
         *         예 2)
         *         
         *         int state = 1;
         *         
         *         // state의 조건에 따른 문자열을 바로 대입
         *         
         *         string playerState = state switch 
         *         {
         *              1 => "대기 애니메이션 재생",
         *              2 => "걷기 애니메이션 재생",
         *              3 => "점프 애니메이션 재생",
         *              4 => "사망 애니메이션 재생",
         *         }
         *      
         * }
         */

        switch (ActiveState)
        {
            case EnemyState.CHASE:
                {
                    // FLIGHT 코드를 여기서 실행한다
                    Debug.Log("CHASE");    
                }
                break;
            case EnemyState.FLEE:
                {
                    // FLIGHT 코드를 여기서 실행한다
                    Debug.Log("FLEE");
                }
                break;
            case EnemyState.FIGHT:
                {
                    // FLIGHT 코드를 여기서 실행한다
                    Debug.Log("FIGHT");
                }
                break;
            case EnemyState.HIDE:
                {
                    // FLIGHT 코드를 여기서 실행한다
                    Debug.Log("HIDE");
                }
                break;
        }
    }
}
