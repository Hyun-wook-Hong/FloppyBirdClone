using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float timeDiff;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        // 어떤 FPS와 상관없이 매 1초마다 실행
        if(timer > timeDiff)
        {
            // Pipe 생성
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(6 ,Random.Range(-1.7f, 5.7f), 0);
            timer = 0;
            Destroy(newpipe, 7.0f);
        }
    }
}
