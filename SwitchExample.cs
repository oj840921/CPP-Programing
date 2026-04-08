using UnityEngine;

public class SwitchExample : MonoBehaviour
{
    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        // 입력받은 키에 따라 방향 설정
        // (x, y, z) : x : 좌(-1)/우(1), y : 위(1)/아래(-1), z : 앞(1)/뒤(-1)
        // (1, 1, 1)

        // 입력받은 키에 따라 방향 설정
        Vector3 direction = Vector3.zero;
        // Vector3 direction = new Vector3(0, 0, 0);

        // 어떤 키가 눌렀는지 체크
        if (Input.anyKey)
        {
            // 현재 누르고 있는 키 조합 중 하나를 예시로 switcg 처리
            // (실제로는 Input.GetAxis를 더 많이 쓰지만, switch 예시)

            if(Input.GetKey(KeyCode.W)) MovePlayer(KeyCode.W);
            else if(Input.GetKey(KeyCode.S)) MovePlayer(KeyCode.S);
            else if(Input.GetKey(KeyCode.A)) MovePlayer(KeyCode.A);
            else if(Input.GetKey(KeyCode.D)) MovePlayer(KeyCode.D);

        }
    }
void MovePlayer(KeyCode key)
    {
        Vector3 dir = key switch
        {
            KeyCode.W => Vector3.forward,
            KeyCode.S => Vector3.back,
            KeyCode.A => Vector3.left,
            KeyCode.D => Vector3.right,
            _ => Vector3.zero
        }; 

        transform.Translate(dir * speed * Time.deltaTime);
    }
}
