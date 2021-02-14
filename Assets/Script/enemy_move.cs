using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class enemy_move : MonoBehaviour
{
    public float speed;
    public Route route;
    public GameObject Player_Hp=null;
    public int player_hp=10;
 
    private int pointIndex;
 
    // Start is called before the first frame update
    void Start()
    {
        transform.position = route.points[0].transform.position;
    }
 
    // Update is called once per frame
    void Update()
    {
        Text hp_text=Player_Hp.GetComponent<Text>();
        var v = route.points[pointIndex + 1].transform.position - route.points[pointIndex].transform.position;
        transform.position += v.normalized * speed * Time.deltaTime;
 
        var pv = transform.position - route.points[pointIndex].transform.position;
        if (pv.magnitude >= v.magnitude)
        {
            pointIndex++;

            if(pointIndex>=route.points.Length-1){//敵が防衛ラインまで到達したら
                Destroy(gameObject);
                player_hp--;//PlayerのHP-1
                hp_text.text=player_hp.ToString();
            }
        }
    }
}
