using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewEnemy",menuName = "Enemy")]
public class ScriptableObjectEnemy : ScriptableObject  
{
    // Start is called before the first frame update
    public string name;
    public string description;

    public Sprite artwork;

    public int health;
    public int damage;

    public float speed;
    

}
