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
        public bool region1Explored = false;
        public bool region2Explored = false;
        public bool region3Explored = false;
        public bool region4Explored = false;
        public bool Explore()
        {
            for (int i = 0; i < regions.Count; i++)
            {
                if (!region1Explored)
                {
                    return false;
                }
                
                if (!region2Explored)
                {
                    return false;
                }
                
                if (!region3Explored)
                {
                    return false;
                }
                
                if (!region4Explored)
                {
                    return false;
                }
            }

            if (!DataManager.Instance.sceneManager.explorationShown)
            {
                DataManager.Instance.info.ExplorationDisplay();
                DataManager.Instance.sceneManager.explorationShown = true;
            }
            return true;
        }
        
        
    }
}
