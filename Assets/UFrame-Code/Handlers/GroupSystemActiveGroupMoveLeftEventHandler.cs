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
    
    
    public class GroupSystemActiveGroupMoveLeftEventHandler {
        
        public GroupComponent Group;
        
        private TetrisDB.ActiveGroupMoveLeftEvent _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private bool ActionNode58_value = default( System.Boolean );
        
        private TetrisDB.GroupComponent ActionNode55_component = default( TetrisDB.GroupComponent );
        
        public TetrisDB.ActiveGroupMoveLeftEvent Event {
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
            ActionNode58_value = Group.isActive;
            // ActionNode
            while (this.DebugInfo("291ffeaa-dbda-403c-b412-a656b50143bf","71d4a479-701a-4b9a-8af4-7c24abc004f9", this) == 1) yield return null;
            // Visit uFrame.Actions.Comparisons.IsTrue
            uFrame.Actions.Comparisons.IsTrue(ActionNode58_value, ()=> { System.StartCoroutine(ActionNode58_yes()); }, ()=> { System.StartCoroutine(ActionNode58_no()); });
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode58_yes() {
            ActionNode55_component = this.Group;
            // ActionNode
            while (this.DebugInfo("71d4a479-701a-4b9a-8af4-7c24abc004f9","e0863a58-8265-4f28-a213-98429cdb65bc", this) == 1) yield return null;
            // Visit TetrisUtils.TryMoveLeft
            TetrisUtils.TryMoveLeft(ActionNode55_component);
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode58_no() {
            yield break;
        }
    }
}
