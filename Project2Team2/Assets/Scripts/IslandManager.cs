using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace team2
{
    public class IslandManager : MonoBehaviour
    {
        public List<NewSnapping> regionHolders;
        public List<DraggableObject2> regions;
        public bool inExplorationMode = false;

        public bool Explore()
        {
            for (int i = 0; i < regions.Count; i++)
            {
                if (regions[i].set == false)
                {
                    return false;
                }
            }

            return true;
        }
        
        
    }
}
