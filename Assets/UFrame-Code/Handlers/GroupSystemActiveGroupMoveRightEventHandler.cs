// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace TetrisDB {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using TetrisDB;
    using uFrame.ECS;
    using uFrame.Kernel;
    using UnityEngine;
    
    
    public class GroupSystemActiveGroupMoveRightEventHandler {
        
        public GroupComponent Group;
        
        private TetrisDB.ActiveGroupMoveRightEvent _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private bool ActionNode59_value = default( System.Boolean );
        
        private TetrisDB.GroupComponent ActionNode57_component = default( TetrisDB.GroupComponent );
        
        public TetrisDB.ActiveGroupMoveRightEvent Event {
            get {
                return _Event;
            }
            set {
                _Event = value;
            }
        }
        
        public uFrame.ECS.EcsSystem System {
            get {
                return _System;
            }
            set {
                _System = value;
            }
        }
        
        public virtual System.Collections.IEnumerator Execute() {
            ActionNode59_value = Group.isActive;
            // ActionNode
            while (this.DebugInfo("e3f5e492-b904-4a14-8c5a-b773be0bbca3","c106d901-8085-4995-8e51-1204e30ca6bd", this) == 1) yield return null;
            // Visit uFrame.Actions.Comparisons.IsTrue
            uFrame.Actions.Comparisons.IsTrue(ActionNode59_value, ()=> { System.StartCoroutine(ActionNode59_yes()); }, ()=> { System.StartCoroutine(ActionNode59_no()); });
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode59_yes() {
            ActionNode57_component = this.Group;
            // ActionNode
            while (this.DebugInfo("c106d901-8085-4995-8e51-1204e30ca6bd","62601496-7546-4d76-abee-44aa4608e5bc", this) == 1) yield return null;
            // Visit TetrisUtils.TryMoveRight
            TetrisUtils.TryMoveRight(ActionNode57_component);
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode59_no() {
            yield break;
        }
    }
}
