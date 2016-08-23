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
    using UniRx;
    using UnityEngine;
    
    
    public partial class GUISystemBase : uFrame.ECS.EcsSystem {
        
        private IEcsComponentManagerOf<MenuComponent> _MenuComponentManager;
        
        private IEcsComponentManagerOf<GroupComponent> _GroupComponentManager;
        
        private IEcsComponentManagerOf<GreenLightComponent> _GreenLightComponentManager;
        
        private IEcsComponentManagerOf<RedLightComponent> _RedLightComponentManager;
        
        private IEcsComponentManagerOf<SpawnComponent> _SpawnComponentManager;
        
        public IEcsComponentManagerOf<MenuComponent> MenuComponentManager {
            get {
                return _MenuComponentManager;
            }
            set {
                _MenuComponentManager = value;
            }
        }
        
        public IEcsComponentManagerOf<GroupComponent> GroupComponentManager {
            get {
                return _GroupComponentManager;
            }
            set {
                _GroupComponentManager = value;
            }
        }
        
        public IEcsComponentManagerOf<GreenLightComponent> GreenLightComponentManager {
            get {
                return _GreenLightComponentManager;
            }
            set {
                _GreenLightComponentManager = value;
            }
        }
        
        public IEcsComponentManagerOf<RedLightComponent> RedLightComponentManager {
            get {
                return _RedLightComponentManager;
            }
            set {
                _RedLightComponentManager = value;
            }
        }
        
        public IEcsComponentManagerOf<SpawnComponent> SpawnComponentManager {
            get {
                return _SpawnComponentManager;
            }
            set {
                _SpawnComponentManager = value;
            }
        }
        
        public override void Setup() {
            base.Setup();
            MenuComponentManager = ComponentSystem.RegisterComponent<MenuComponent>(4);
            GroupComponentManager = ComponentSystem.RegisterComponent<GroupComponent>(3);
            GreenLightComponentManager = ComponentSystem.RegisterComponent<GreenLightComponent>(7);
            RedLightComponentManager = ComponentSystem.RegisterComponent<RedLightComponent>(8);
            SpawnComponentManager = ComponentSystem.RegisterComponent<SpawnComponent>(1);
            this.OnEvent<TetrisDB.HandVisibleEvent>().Subscribe(_=>{ GUISystemHandVisibleRedEventFilter(_); }).DisposeWith(this);
            this.OnEvent<TetrisDB.HandVisibleEvent>().Subscribe(_=>{ GUISystemHandVisibleGreenEventFilter(_); }).DisposeWith(this);
            this.OnEvent<uFrame.Kernel.GameReadyEvent>().Subscribe(_=>{ GUISystemGameReadyFilter(_); }).DisposeWith(this);
            this.OnEvent<TetrisDB.HandInvisibleEvent>().Subscribe(_=>{ GUISystemHandInvisibleRedEventFilter(_); }).DisposeWith(this);
            this.OnEvent<TetrisDB.HandInvisibleEvent>().Subscribe(_=>{ GUISystemHandInvisibleGreenEventFilter(_); }).DisposeWith(this);
            this.OnEvent<TetrisDB.GameExitEvent>().Subscribe(_=>{ GUISystemGameExitEventFilter(_); }).DisposeWith(this);
            this.OnEvent<TetrisDB.MenuOpenEvent>().Subscribe(_=>{ GUISystemMenuOpenEventFilter(_); }).DisposeWith(this);
            this.OnEvent<TetrisDB.MenuCloseEvent>().Subscribe(_=>{ GUISystemMenuCloseEventFilter(_); }).DisposeWith(this);
        }
        
        protected virtual void GUISystemHandVisibleRedEventHandler(TetrisDB.HandVisibleEvent data, RedLightComponent group) {
            var handler = new GUISystemHandVisibleRedEventHandler();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            StartCoroutine(handler.Execute());
        }
        
        protected void GUISystemHandVisibleRedEventFilter(TetrisDB.HandVisibleEvent data) {
            var RedLightComponentItems = RedLightComponentManager.Components;
            for (var RedLightComponentIndex = 0
            ; RedLightComponentIndex < RedLightComponentItems.Count; RedLightComponentIndex++
            ) {
                if (!RedLightComponentItems[RedLightComponentIndex].Enabled) {
                    continue;
                }
                this.GUISystemHandVisibleRedEventHandler(data, RedLightComponentItems[RedLightComponentIndex]);
            }
        }
        
        protected virtual void GUISystemHandVisibleGreenEventHandler(TetrisDB.HandVisibleEvent data, GreenLightComponent group) {
            var handler = new GUISystemHandVisibleGreenEventHandler();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            StartCoroutine(handler.Execute());
        }
        
        protected void GUISystemHandVisibleGreenEventFilter(TetrisDB.HandVisibleEvent data) {
            var GreenLightComponentItems = GreenLightComponentManager.Components;
            for (var GreenLightComponentIndex = 0
            ; GreenLightComponentIndex < GreenLightComponentItems.Count; GreenLightComponentIndex++
            ) {
                if (!GreenLightComponentItems[GreenLightComponentIndex].Enabled) {
                    continue;
                }
                this.GUISystemHandVisibleGreenEventHandler(data, GreenLightComponentItems[GreenLightComponentIndex]);
            }
        }
        
        protected virtual void GUISystemGameReadyHandler(uFrame.Kernel.GameReadyEvent data, MenuComponent group) {
            var handler = new GUISystemGameReadyHandler();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            StartCoroutine(handler.Execute());
        }
        
        protected void GUISystemGameReadyFilter(uFrame.Kernel.GameReadyEvent data) {
            var MenuComponentItems = MenuComponentManager.Components;
            for (var MenuComponentIndex = 0
            ; MenuComponentIndex < MenuComponentItems.Count; MenuComponentIndex++
            ) {
                if (!MenuComponentItems[MenuComponentIndex].Enabled) {
                    continue;
                }
                this.GUISystemGameReadyHandler(data, MenuComponentItems[MenuComponentIndex]);
            }
        }
        
        protected virtual void GUISystemHandInvisibleRedEventHandler(TetrisDB.HandInvisibleEvent data, RedLightComponent group) {
            var handler = new GUISystemHandInvisibleRedEventHandler();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            StartCoroutine(handler.Execute());
        }
        
        protected void GUISystemHandInvisibleRedEventFilter(TetrisDB.HandInvisibleEvent data) {
            var RedLightComponentItems = RedLightComponentManager.Components;
            for (var RedLightComponentIndex = 0
            ; RedLightComponentIndex < RedLightComponentItems.Count; RedLightComponentIndex++
            ) {
                if (!RedLightComponentItems[RedLightComponentIndex].Enabled) {
                    continue;
                }
                this.GUISystemHandInvisibleRedEventHandler(data, RedLightComponentItems[RedLightComponentIndex]);
            }
        }
        
        protected virtual void GUISystemHandInvisibleGreenEventHandler(TetrisDB.HandInvisibleEvent data, GreenLightComponent group) {
            var handler = new GUISystemHandInvisibleGreenEventHandler();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            StartCoroutine(handler.Execute());
        }
        
        protected void GUISystemHandInvisibleGreenEventFilter(TetrisDB.HandInvisibleEvent data) {
            var GreenLightComponentItems = GreenLightComponentManager.Components;
            for (var GreenLightComponentIndex = 0
            ; GreenLightComponentIndex < GreenLightComponentItems.Count; GreenLightComponentIndex++
            ) {
                if (!GreenLightComponentItems[GreenLightComponentIndex].Enabled) {
                    continue;
                }
                this.GUISystemHandInvisibleGreenEventHandler(data, GreenLightComponentItems[GreenLightComponentIndex]);
            }
        }
        
        protected virtual void GUISystemGameExitEventHandler(TetrisDB.GameExitEvent data, MenuComponent group) {
            var handler = new GUISystemGameExitEventHandler();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            StartCoroutine(handler.Execute());
        }
        
        protected void GUISystemGameExitEventFilter(TetrisDB.GameExitEvent data) {
            var MenuComponentItems = MenuComponentManager.Components;
            for (var MenuComponentIndex = 0
            ; MenuComponentIndex < MenuComponentItems.Count; MenuComponentIndex++
            ) {
                if (!MenuComponentItems[MenuComponentIndex].Enabled) {
                    continue;
                }
                this.GUISystemGameExitEventHandler(data, MenuComponentItems[MenuComponentIndex]);
            }
        }
        
        protected virtual void GUISystemMenuOpenEventHandler(TetrisDB.MenuOpenEvent data, MenuComponent group) {
            var handler = new GUISystemMenuOpenEventHandler();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            StartCoroutine(handler.Execute());
        }
        
        protected void GUISystemMenuOpenEventFilter(TetrisDB.MenuOpenEvent data) {
            var MenuComponentItems = MenuComponentManager.Components;
            for (var MenuComponentIndex = 0
            ; MenuComponentIndex < MenuComponentItems.Count; MenuComponentIndex++
            ) {
                if (!MenuComponentItems[MenuComponentIndex].Enabled) {
                    continue;
                }
                this.GUISystemMenuOpenEventHandler(data, MenuComponentItems[MenuComponentIndex]);
            }
        }
        
        protected virtual void GUISystemMenuCloseEventHandler(TetrisDB.MenuCloseEvent data, MenuComponent group) {
            var handler = new GUISystemMenuCloseEventHandler();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            StartCoroutine(handler.Execute());
        }
        
        protected void GUISystemMenuCloseEventFilter(TetrisDB.MenuCloseEvent data) {
            var MenuComponentItems = MenuComponentManager.Components;
            for (var MenuComponentIndex = 0
            ; MenuComponentIndex < MenuComponentItems.Count; MenuComponentIndex++
            ) {
                if (!MenuComponentItems[MenuComponentIndex].Enabled) {
                    continue;
                }
                this.GUISystemMenuCloseEventHandler(data, MenuComponentItems[MenuComponentIndex]);
            }
        }
    }
    
    [uFrame.Attributes.uFrameIdentifier("f2225a07-0107-4244-a19a-b28926cfd268")]
    public partial class GUISystem : GUISystemBase {
        
        private static GUISystem _Instance;
        
        public GUISystem() {
            Instance = this;
        }
        
        public static GUISystem Instance {
            get {
                return _Instance;
            }
            set {
                _Instance = value;
            }
        }
    }
}