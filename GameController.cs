using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject ball; //BowlingBall
    private float maxWidth;
    private float time = 2;
    private GameObject newball;
	// Use this for initialization
	void Start ()
    {
        //将屏幕宽度转换成世界坐标
        Vector3 screenPos = new Vector3(Screen.width, 0, 0);
        Vector3 moveWidth = Camera.main.ScreenToViewportPoint(screenPos);
        //获取保留球自身宽度
        float ballWidth = ball.GetComponent<Renderer>().bounds.extents.x;
        //计算保龄球实例化的位置的宽度
        maxWidth = moveWidth.x - ballWidth;
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        time -= Time.deltaTime;
        if(time<0)
        {
            //产生一个随机数，代表实例化下一个保龄球所需时间
            time = Random.Range(1.5f, 2.0f);
            /*在保龄球实例化位置宽度内产生一个随机数，来控制实例化的保龄球的位置*/
            float posX = Random.Range(-maxWidth, maxWidth);
            Vector3 spawnPosition = new Vector3(posX, transform.position.y, 0);
            //实例化保龄球
            newball = (GameObject)Instantiate(ball, spawnPosition, Quaternion.identity);
            Destroy(newball, 10);
        }
	}
}
