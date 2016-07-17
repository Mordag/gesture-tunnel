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
    using uFrame.ECS;
    using uFrame.Kernel;
    using UnityEngine;
    
    
    public class InputSystemUpdateHandler {
        
        private uFrame.ECS.ISystemUpdate _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private string ActionNode38_name = default( System.String );
        
        private string StringNode37 = "left";
        
        private bool ActionNode38_Result = default( System.Boolean );
        
        private bool ActionNode39_value = default( System.Boolean );
        
        private TetrisDB.ActiveGroupMoveLeftEvent PublishEventNode40_Result = default( TetrisDB.ActiveGroupMoveLeftEvent );
        
        private string ActionNode42_name = default( System.String );
        
        private string StringNode44 = "right";
        
        private bool ActionNode42_Result = default( System.Boolean );
        
        private bool ActionNode43_value = default( System.Boolean );
        
        private TetrisDB.ActiveGroupMoveRightEvent PublishEventNode45_Result = default( TetrisDB.ActiveGroupMoveRightEvent );
        
        private string ActionNode46_name = default( System.String );
        
        private string StringNode47 = "down";
        
        private bool ActionNode46_Result = default( System.Boolean );
        
        private bool ActionNode48_value = default( System.Boolean );
        
        private TetrisDB.ActiveGroupDownEvent PublishEventNode49_Result = default( TetrisDB.ActiveGroupDownEvent );
        
        private string ActionNode50_name = default( System.String );
        
        private string StringNode51 = "up";
        
        private bool ActionNode50_Result = default( System.Boolean );
        
        private bool ActionNode52_value = default( System.Boolean );
        
        private TetrisDB.ActiveGroupRotateEvent PublishEventNode53_Result = default( TetrisDB.ActiveGroupRotateEvent );
        
        public uFrame.ECS.ISystemUpdate Event {
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
            ActionNode38_name = StringNode37;
            // ActionNode
            while (this.DebugInfo("aec7e0d2-50fc-4fc5-82de-67f1cecfdaa0","bbacf42e-4871-48e8-832c-7c12e11bba1d", this) == 1) yield return null;
            // Visit UnityEngine.Input.GetKeyDown
            ActionNode38_Result = UnityEngine.Input.GetKeyDown(ActionNode38_name);
            ActionNode39_value = ActionNode38_Result;
            // ActionNode
            while (this.DebugInfo("bbacf42e-4871-48e8-832c-7c12e11bba1d","5c1b868a-fe39-4964-87a8-62f33fce3966", this) == 1) yield return null;
            // Visit uFrame.Actions.Comparisons.IsTrue
            uFrame.Actions.Comparisons.IsTrue(ActionNode39_value, ()=> { System.StartCoroutine(ActionNode39_yes()); }, ()=> { System.StartCoroutine(ActionNode39_no()); });
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode39_yes() {
            // PublishEventNode
            while (this.DebugInfo("5c1b868a-fe39-4964-87a8-62f33fce3966","864abc5e-1901-454c-9b6a-534a69fc3610", this) == 1) yield return null;
            var PublishEventNode40_Event = new ActiveGroupMoveLeftEvent();
            System.Publish(PublishEventNode40_Event);
            PublishEventNode40_Result = PublishEventNode40_Event;
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode43_yes() {
            // PublishEventNode
            while (this.DebugInfo("a55abf8f-6455-4c4c-87cc-c07a86731035","78031bbd-cb18-451d-bceb-1219207fa1bd", this) == 1) yield return null;
            var PublishEventNode45_Event = new ActiveGroupMoveRightEvent();
            System.Publish(PublishEventNode45_Event);
            PublishEventNode45_Result = PublishEventNode45_Event;
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode48_yes() {
            // PublishEventNode
            while (this.DebugInfo("30021b89-76b7-40d7-abe7-bbe7766ffc1f","7caf5fe1-f99f-46cd-9b74-ee71b2f9108d", this) == 1) yield return null;
            var PublishEventNode49_Event = new ActiveGroupDownEvent();
            System.Publish(PublishEventNode49_Event);
            PublishEventNode49_Result = PublishEventNode49_Event;
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode52_yes() {
            // PublishEventNode
            while (this.DebugInfo("42a2a5ce-b3d2-40c6-a0c1-c08fbc74b8c9","bdfb8aaf-0d1c-4d8a-b0c3-60e35353a182", this) == 1) yield return null;
            var PublishEventNode53_Event = new ActiveGroupRotateEvent();
            System.Publish(PublishEventNode53_Event);
            PublishEventNode53_Result = PublishEventNode53_Event;
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode52_no() {
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode48_no() {
            ActionNode50_name = StringNode51;
            // ActionNode
            while (this.DebugInfo("7caf5fe1-f99f-46cd-9b74-ee71b2f9108d","06e1cbe5-a2ca-4993-9b32-1f575f150658", this) == 1) yield return null;
            // Visit UnityEngine.Input.GetKeyDown
            ActionNode50_Result = UnityEngine.Input.GetKeyDown(ActionNode50_name);
            ActionNode52_value = ActionNode50_Result;
            // ActionNode
            while (this.DebugInfo("06e1cbe5-a2ca-4993-9b32-1f575f150658","42a2a5ce-b3d2-40c6-a0c1-c08fbc74b8c9", this) == 1) yield return null;
            // Visit uFrame.Actions.Comparisons.IsTrue
            uFrame.Actions.Comparisons.IsTrue(ActionNode52_value, ()=> { System.StartCoroutine(ActionNode52_yes()); }, ()=> { System.StartCoroutine(ActionNode52_no()); });
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode43_no() {
            ActionNode46_name = StringNode47;
            // ActionNode
            while (this.DebugInfo("78031bbd-cb18-451d-bceb-1219207fa1bd","bb37de09-0ca3-4e60-8eb8-570ceae40bf1", this) == 1) yield return null;
            // Visit UnityEngine.Input.GetKeyDown
            ActionNode46_Result = UnityEngine.Input.GetKeyDown(ActionNode46_name);
            ActionNode48_value = ActionNode46_Result;
            // ActionNode
            while (this.DebugInfo("bb37de09-0ca3-4e60-8eb8-570ceae40bf1","30021b89-76b7-40d7-abe7-bbe7766ffc1f", this) == 1) yield return null;
            // Visit uFrame.Actions.Comparisons.IsTrue
            uFrame.Actions.Comparisons.IsTrue(ActionNode48_value, ()=> { System.StartCoroutine(ActionNode48_yes()); }, ()=> { System.StartCoroutine(ActionNode48_no()); });
            yield break;
        }
        
        private System.Collections.IEnumerator ActionNode39_no() {
            ActionNode42_name = StringNode44;
            // ActionNode
            while (this.DebugInfo("864abc5e-1901-454c-9b6a-534a69fc3610","52dfde60-2775-41b0-b3ec-f2016c0eef0c", this) == 1) yield return null;
            // Visit UnityEngine.Input.GetKeyDown
            ActionNode42_Result = UnityEngine.Input.GetKeyDown(ActionNode42_name);
            ActionNode43_value = ActionNode42_Result;
            // ActionNode
            while (this.DebugInfo("52dfde60-2775-41b0-b3ec-f2016c0eef0c","a55abf8f-6455-4c4c-87cc-c07a86731035", this) == 1) yield return null;
            // Visit uFrame.Actions.Comparisons.IsTrue
            uFrame.Actions.Comparisons.IsTrue(ActionNode43_value, ()=> { System.StartCoroutine(ActionNode43_yes()); }, ()=> { System.StartCoroutine(ActionNode43_no()); });
            yield break;
        }
    }
}
