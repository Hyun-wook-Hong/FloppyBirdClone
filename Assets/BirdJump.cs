using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower;
    // Start is called before the first frame update
    void Start()
    {
        // 게임이 최초 init될때 1회 실행
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // 게임에서 매 프레임(fps)마다 실행
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * jumpPower; // Vector2.up: (0,1) | Vector2.up * 3: (0,3)
        }
    }
    // 콜라이더들이 물리적으로 부딪혔을때 이벤트 발동
    private void OnCollisionEnter2D(Collision2D other) {
        if(Score.score > Score.bestScore){
            Score.bestScore = Score.score;
        }
        // 게임오버 씬으로 이동
        SceneManager.LoadScene("GameOverScene");   
    }
}
