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
    
    
    public class GroupSystemActiveGroupRotateEventHandler {
        
        public GroupComponent Group;
        
        private TetrisDB.ActiveGroupRotateEvent _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private bool ActionNode65_value = default( System.Boolean );
        
        private TetrisDB.GroupComponent ActionNode66_component = default( TetrisDB.GroupComponent );
        
        private object ActionNode125_message = default( System.Object );
        
        private string StringNode126 = "rotate";
        
        public TetrisDB.ActiveGroupRotateEvent Event {
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
            ActionNode65_value = Group.isActive;
            // ActionNode
            while (this.DebugInfo("9cbc95df-ea2c-4181-9c07-104f64e2c26c","542028e0-4e42-43d3-887e-68fdf506858a", this) == 1) yield return null;
            // Visit uFrame.Actions.Comparisons.IsTrue
            uFrame.Actions.Comparisons.IsTrue(ActionNode65_value, ()=> { System.StartCoroutine(ActionNode65_yes()); }, ()=> { System.StartCoroutine(ActionNode65_no()); });
            ActionNode125_message = StringNode126;
            // ActionNode
            while (this.DebugInfo("aec7e0d2-50fc-4fc5-82de-67f1cecfdaa0","b2ad6fce-fbce-434c-85b3-e9976fbed7a4", this) == 1) yield return null;
            // Visit uFrame.Actions.DebugLibrary.LogMessage
            uFrame.Actions.DebugLibrary.LogMessage(ActionNode125_message);
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode65_yes() {
            ActionNode66_component = this.Group;
            // ActionNode
            while (this.DebugInfo("542028e0-4e42-43d3-887e-68fdf506858a","aec7e0d2-50fc-4fc5-82de-67f1cecfdaa0", this) == 1) yield return null;
            // Visit TetrisUtils.TryRotate
            TetrisUtils.TryRotate(ActionNode66_component);
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode65_no() {
            yield break;
        }
    }
}
