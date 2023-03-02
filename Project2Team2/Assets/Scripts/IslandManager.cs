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

        public void Explore()
        {
            foreach (var region in regions)
            {
                if (!region.set)
                {
                    inExplorationMode = false;
                }
            }
        }
        
        
    }
}
