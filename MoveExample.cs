using UnityEngine;

public class MoveExample : MonoBehaviour
{
    public float speed = 5.0f;


    // Update is called once per frame
    void Update()
    {
        // 1. 키보드 입력 받기(Horizontal: 좌우, Vertical : 상하/앞뒤)
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // 2. 이동 방향 계산
        Vector3 moveDir = new Vector3(h, 0, v);

        // 3. Translate()함수로 위치 이동(Time.deltaTime을 곱하여 프레임 레이트 독립성 확보)
        transform.Translate(moveDir * speed * Time.deltaTime);
    }
}
