using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /* 매 프레임마다 실행 */
        // Pipe의 Transform을 가져와 프레임마다 X좌표를 변화시킨다
        transform.position += Vector3.left * speed * Time.deltaTime; //(-1, 0, 0)
    }
}
