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
    using Invert.Json;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using uFrame.ECS;
    using UniRx;
    using UnityEngine;
    
    
    [uFrame.Attributes.ComponentId(4)]
    [uFrame.Attributes.uFrameIdentifier("0b23df42-ee1c-4959-8691-3dc3c2a00d6c")]
    public partial class MenuComponent : uFrame.ECS.EcsComponent {
        
        [UnityEngine.SerializeField()]
        private Boolean _isVisible;
        
        private Subject<PropertyChangedEvent<Boolean>> _isVisibleObservable;
        
        private PropertyChangedEvent<Boolean> _isVisibleEvent;
        
        public override int ComponentId {
            get {
                return 4;
            }
        }
        
        public IObservable<PropertyChangedEvent<Boolean>> isVisibleObservable {
            get {
                return _isVisibleObservable ?? (_isVisibleObservable = new Subject<PropertyChangedEvent<Boolean>>());
            }
        }
        
        public Boolean isVisible {
            get {
                return _isVisible;
            }
            set {
                SetisVisible(value);
            }
        }
        
        public virtual void SetisVisible(Boolean value) {
            SetProperty(ref _isVisible, value, ref _isVisibleEvent, _isVisibleObservable);
        }
    }
}
