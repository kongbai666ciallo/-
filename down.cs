using System.Runtime.CompilerServices;
using UnityEngine;
public class down : MonoBehaviour
{
 
    private bool canCollect = false;
    //判断是否进入碰撞域
    private GameObject target;
    //对象target
    [SerializeField] Transform ItemSlot;
    [SerializeField] Transform Item;
    //“手”
    void Update()
    {
        
        
        //一旦检测到按下e且符合能拾取条件，就拾取
        
    }
 private void OnTriggerStay(Collider other)
    
    {
        if(Input.GetKeyDown(KeyCode.Q)){
            AudioSource audio = GetComponent<AudioSource>();
            Item.SetParent(null);
            audio.Stop();
        }
    }
}    