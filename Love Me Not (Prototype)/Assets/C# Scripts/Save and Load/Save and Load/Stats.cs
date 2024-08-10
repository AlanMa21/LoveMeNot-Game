using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public struct SerializableVector2
{
   public float x;
   public float y;

   public Vector2 GetPos()
   {
      return new Vector2(x,y);
   }
   
}


[System.Serializable]
public class Stats 
{
   public int life;
   public int vitality;
   public int attack;
   public int defense;

   public SerializableVector2 myPos;
   
}
