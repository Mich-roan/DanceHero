using UnityEngine;

public class LaneManager : MonoBehaviour
{
   [SerializeField]
   private Lane [] lanes;
   public Lane GetLane(int index)
   {
    return lanes [index];
   }
   public int GetLaneCount()
   {
      return lanes.Length;
   }
}
