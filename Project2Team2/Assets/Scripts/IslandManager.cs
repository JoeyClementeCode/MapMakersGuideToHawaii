using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace team2
{
    public class IslandManager : MonoBehaviour
    {
        public List<Snapping> regionHolders;
        public List<DraggableObjects> regions;
        public static bool inExplorationMode = false;

        public void Explore()
        {
            foreach (var region in regions)
            {
                if (!region.set)
                {
                    inExplorationMode = false;
                }
            }

            inExplorationMode = true;
        }
        
        
    }
}
