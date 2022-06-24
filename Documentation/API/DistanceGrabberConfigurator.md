# Class DistanceGrabberConfigurator

Sets up the DistanceGrabber Prefab based on the provided user settings.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [cachedInteractorPrecognitionValue]
  * [cachedKinematicState]
  * [checkInteractableActiveRoutine]
  * [grabPoint]
  * [hasSubscribedToInteractorEvents]
  * [ValidConfigurators]
* [Properties]
  * [AlwaysCreateGrabPoint]
  * [DisablePointerOnInteractorTouch]
  * [EnablePointerContainer]
  * [EnablePointerLogic]
  * [Facade]
  * [ForceKinematicOnTransition]
  * [Grabber]
  * [GrabListener]
  * [GrabProxy]
  * [GrabProxyActions]
  * [Pointer]
  * [PointerContainer]
  * [PropertyApplier]
  * [ReactivatePointerTimer]
  * [ShouldIgnoreEnablePointer]
  * [SimulatedInteractor]
  * [SimulateGrabContainer]
  * [SimulateTouchContainer]
  * [TargetValidityRules]
  * [UngrabListener]
* [Methods]
  * [CancelCheckInteractableActiveRoutine()]
  * [CanCreateGrabPoint(GrabInteractableAction)]
  * [CheckGrabValidity(SurfaceData)]
  * [CheckInteractableIsNotActiveAtEndOfFrame(InteractableFacade)]
  * [ConfigureInteractor()]
  * [ConfigurePointerRules()]
  * [ConfigurePropertyApplier()]
  * [ConfigureReactivatePointerTimer()]
  * [CreateGrabPoint(RaycastHit)]
  * [DestroyGrabPoint()]
  * [HasTouched(InteractableFacade)]
  * [HasUntouched(InteractableFacade)]
  * [MakeInteractableKinematic()]
  * [NotifyAfterGrabbed(InteractableFacade)]
  * [NotifyBeforeGrabbed(InteractableFacade)]
  * [NotifyGrabCanceled()]
  * [OnDisable()]
  * [OnEnable()]
  * [PerformGrab(InteractableFacade)]
  * [PerformUngrab(InteractableFacade)]
  * [RegisterInteractorListeners()]
  * [RestoreCachedInteractableKinematicState()]
  * [RestoreInteractorPrecognitionValue()]
  * [SimulateTouch(InteractableFacade)]
  * [SimulateUntouch(InteractableFacade)]
  * [Start()]
  * [UnregisterInteractorListeners()]

## Details

##### Inheritance

* System.Object
* DistanceGrabberConfigurator

##### Namespace

* [Tilia.Interactions.PointerInteractors]

##### Syntax

```
public class DistanceGrabberConfigurator : MonoBehaviour
```

### Fields

#### cachedInteractorPrecognitionValue

The current grab precognition value for the associated Interactor.

##### Declaration

```
protected float cachedInteractorPrecognitionValue
```

#### cachedKinematicState

The kinematic state of the InteractableFacade.InteractableRigidbody before the transition period.

##### Declaration

```
protected bool cachedKinematicState
```

#### checkInteractableActiveRoutine

A coroutine for managing the if interactable is active check.

##### Declaration

```
protected Coroutine checkInteractableActiveRoutine
```

#### grabPoint

The point at which to use as the grab point offset for the transition.

##### Declaration

```
protected GameObject grabPoint
```

#### hasSubscribedToInteractorEvents

Whether the Interactor events have been subscribed to.

##### Declaration

```
protected bool hasSubscribedToInteractorEvents
```

#### ValidConfigurators

A global static list of [DistanceGrabberConfigurator] for look up.

##### Declaration

```
public static List<DistanceGrabberConfigurator> ValidConfigurators
```

### Properties

#### AlwaysCreateGrabPoint

Determines whether the grab point will be created always or only if the InteractableFacade has a follow action that is set to GrabInteractableFollowAction.OffsetType.PrecisionPoint.

##### Declaration

```
public bool AlwaysCreateGrabPoint { get; set; }
```

#### DisablePointerOnInteractorTouch

Whether to disable the pointer logic when the Facade.Interactor touches the InteractableFacade.

##### Declaration

```
public bool DisablePointerOnInteractorTouch { get; set; }
```

#### EnablePointerContainer

The container for the logic that enables the pointer.

##### Declaration

```
public GameObject EnablePointerContainer { get; protected set; }
```

#### EnablePointerLogic

The logic that enables the pointer.

##### Declaration

```
public EmptyEventProxyEmitter EnablePointerLogic { get; protected set; }
```

#### Facade

The public facade.

##### Declaration

```
public DistanceGrabberFacade Facade { get; protected set; }
```

#### ForceKinematicOnTransition

Forces the InteractableFacade.InteractableRigidbody to be kinematic during the transition.

##### Declaration

```
public bool ForceKinematicOnTransition { get; set; }
```

#### Grabber

The InteractableGrabber that initiates the grabbing.

##### Declaration

```
public InteractableGrabber Grabber { get; protected set; }
```

#### GrabListener

The EmptyEventProxyEmitter that runs the grab logic.

##### Declaration

```
public EmptyEventProxyEmitter GrabListener { get; protected set; }
```

#### GrabProxy

The BooleanAction that proxies the Interactor's grab action.

##### Declaration

```
public BooleanAction GrabProxy { get; protected set; }
```

#### GrabProxyActions

The EmptyEventProxyEmitter that is executed on the Interactor's grab action.

##### Declaration

```
public EmptyEventProxyEmitter GrabProxyActions { get; protected set; }
```

#### Pointer

The PointerFacade to initiate the grabbing.

##### Declaration

```
public PointerFacade Pointer { get; protected set; }
```

#### PointerContainer

The containing GameObject of the pointer logic.

##### Declaration

```
public GameObject PointerContainer { get; protected set; }
```

#### PropertyApplier

The TransformPropertyApplier that transitions the Interactable to the Interactor.

##### Declaration

```
public TransformPropertyApplier PropertyApplier { get; protected set; }
```

#### ReactivatePointerTimer

The CountdownTimer that controls when the pointer is reactivated.

##### Declaration

```
public CountdownTimer ReactivatePointerTimer { get; protected set; }
```

#### ShouldIgnoreEnablePointer

Whether to ignore the re-enabling of the pointer logic when the Facade.Interactor untouches.

##### Declaration

```
public bool ShouldIgnoreEnablePointer { get; set; }
```

#### SimulatedInteractor

An InteractorFacade that is used to simulate touch events with the pointer.

##### Declaration

```
public InteractorFacade SimulatedInteractor { get; protected set; }
```

#### SimulateGrabContainer

The container for the simulate grab logic.

##### Declaration

```
public GameObject SimulateGrabContainer { get; protected set; }
```

#### SimulateTouchContainer

The container for the simulate touch logic.

##### Declaration

```
public GameObject SimulateTouchContainer { get; protected set; }
```

#### TargetValidityRules

The RuleContainerObservableList that controls pointer target validity.

##### Declaration

```
public RuleContainerObservableList TargetValidityRules { get; protected set; }
```

#### UngrabListener

The EmptyEventProxyEmitter that runs the ungrab logic.

##### Declaration

```
public EmptyEventProxyEmitter UngrabListener { get; protected set; }
```

### Methods

#### CancelCheckInteractableActiveRoutine()

Cancels the if interactable is active coroutine check.

##### Declaration

```
protected virtual void CancelCheckInteractableActiveRoutine()
```

#### CanCreateGrabPoint(GrabInteractableAction)

Determines whether the grab point can be created for the given action.

##### Declaration

```
protected virtual bool CanCreateGrabPoint(GrabInteractableAction action)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| GrabInteractableAction | action | The action to check whether a grab point can be created for. |

##### Returns

| Type | Description |
| --- | --- |
| System.Boolean | Whether the grab point can be created. |

#### CheckGrabValidity(SurfaceData)

##### Declaration

```
public virtual void CheckGrabValidity(SurfaceData data)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| SurfaceData | data | n/a |

#### CheckInteractableIsNotActiveAtEndOfFrame(InteractableFacade)

Checks if the given interactable is not active after the end of the frame and peforms an ungrab if it is no longer active.

##### Declaration

```
protected virtual IEnumerator CheckInteractableIsNotActiveAtEndOfFrame(InteractableFacade interactable)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InteractableFacade | interactable | The interactable to check. |

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.IEnumerator | An Enumerator to manage the running of the Coroutine. |

#### ConfigureInteractor()

Configures the relevant components that require knowledge of the Interactor.

##### Declaration

```
public virtual void ConfigureInteractor()
```

#### ConfigurePointerRules()

Configures the rules on the pointer.

##### Declaration

```
public virtual void ConfigurePointerRules()
```

#### ConfigurePropertyApplier()

Configures the property applier.

##### Declaration

```
public virtual void ConfigurePropertyApplier()
```

#### ConfigureReactivatePointerTimer()

Configures the reactivate pointer timer.

##### Declaration

```
public virtual void ConfigureReactivatePointerTimer()
```

#### CreateGrabPoint(RaycastHit)

Creates the grab point offset to transition the target Interactable towards.

##### Declaration

```
public virtual void CreateGrabPoint(RaycastHit hitData)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| RaycastHit | hitData | The data to create the point with. |

#### DestroyGrabPoint()

Destroys any existing grab point.

##### Declaration

```
public virtual void DestroyGrabPoint()
```

#### HasTouched(InteractableFacade)

Handles the Facade.Interactor touching state.

##### Declaration

```
protected virtual void HasTouched(InteractableFacade interactable)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InteractableFacade | interactable | The Interactable being touched. |

#### HasUntouched(InteractableFacade)

Handles the Facade.Interactor untouching state.

##### Declaration

```
protected virtual void HasUntouched(InteractableFacade interactable)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InteractableFacade | interactable | The Interactable being touched. |

#### MakeInteractableKinematic()

Makes the InteractableFacade.InteractableRigidbody kinematic.

##### Declaration

```
public virtual void MakeInteractableKinematic()
```

#### NotifyAfterGrabbed(InteractableFacade)

Emits the Facade.AfterGrabbed event.

##### Declaration

```
public virtual void NotifyAfterGrabbed(InteractableFacade interactable)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InteractableFacade | interactable | The payload to emit with. |

#### NotifyBeforeGrabbed(InteractableFacade)

Emits the Facade.BeforeGrabbed event.

##### Declaration

```
public virtual void NotifyBeforeGrabbed(InteractableFacade interactable)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InteractableFacade | interactable | The payload to emit with. |

#### NotifyGrabCanceled()

Emits the Facade.GrabCanceled event.

##### Declaration

```
public virtual void NotifyGrabCanceled()
```

#### OnDisable()

##### Declaration

```
protected virtual void OnDisable()
```

#### OnEnable()

##### Declaration

```
protected virtual void OnEnable()
```

#### PerformGrab(InteractableFacade)

Performs the grab logic.

##### Declaration

```
protected virtual void PerformGrab(InteractableFacade interactable)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InteractableFacade | interactable | The Interactable being grabbed. |

#### PerformUngrab(InteractableFacade)

Performs the ungrab logic.

##### Declaration

```
protected virtual void PerformUngrab(InteractableFacade interactable)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InteractableFacade | interactable | The Interactable being grabbed. |

#### RegisterInteractorListeners()

Registers the Interactor listeners.

##### Declaration

```
protected virtual void RegisterInteractorListeners()
```

#### RestoreCachedInteractableKinematicState()

Restores the InteractableFacade.InteractableRigidbody kinematic state to the value of [cachedKinematicState].

##### Declaration

```
public virtual void RestoreCachedInteractableKinematicState()
```

#### RestoreInteractorPrecognitionValue()

Restores the cached Interactor precognition value.

##### Declaration

```
protected virtual void RestoreInteractorPrecognitionValue()
```

#### SimulateTouch(InteractableFacade)

Simulates a touch on the given Interactable.

##### Declaration

```
public virtual void SimulateTouch(InteractableFacade interactable)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InteractableFacade | interactable | The Interactable to simulate the touch on. |

#### SimulateUntouch(InteractableFacade)

Simulates an untouch on the given Interactable.

##### Declaration

```
public virtual void SimulateUntouch(InteractableFacade interactable)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InteractableFacade | interactable | The Interactable to simulate the untouch on. |

#### Start()

##### Declaration

```
protected virtual IEnumerator Start()
```

##### Returns

| Type | Description |
| --- | --- |
| System.Collections.IEnumerator | n/a |

#### UnregisterInteractorListeners()

Unregisters the Interactor listeners.

##### Declaration

```
protected virtual void UnregisterInteractorListeners()
```

[Tilia.Interactions.PointerInteractors]: README.md
[DistanceGrabberConfigurator]: DistanceGrabberConfigurator.md
[DistanceGrabberFacade]: DistanceGrabberFacade.md
[cachedKinematicState]: DistanceGrabberConfigurator.md#cachedKinematicState
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[cachedInteractorPrecognitionValue]: #cachedInteractorPrecognitionValue
[cachedKinematicState]: #cachedKinematicState
[checkInteractableActiveRoutine]: #checkInteractableActiveRoutine
[grabPoint]: #grabPoint
[hasSubscribedToInteractorEvents]: #hasSubscribedToInteractorEvents
[ValidConfigurators]: #ValidConfigurators
[Properties]: #Properties
[AlwaysCreateGrabPoint]: #AlwaysCreateGrabPoint
[DisablePointerOnInteractorTouch]: #DisablePointerOnInteractorTouch
[EnablePointerContainer]: #EnablePointerContainer
[EnablePointerLogic]: #EnablePointerLogic
[Facade]: #Facade
[ForceKinematicOnTransition]: #ForceKinematicOnTransition
[Grabber]: #Grabber
[GrabListener]: #GrabListener
[GrabProxy]: #GrabProxy
[GrabProxyActions]: #GrabProxyActions
[Pointer]: #Pointer
[PointerContainer]: #PointerContainer
[PropertyApplier]: #PropertyApplier
[ReactivatePointerTimer]: #ReactivatePointerTimer
[ShouldIgnoreEnablePointer]: #ShouldIgnoreEnablePointer
[SimulatedInteractor]: #SimulatedInteractor
[SimulateGrabContainer]: #SimulateGrabContainer
[SimulateTouchContainer]: #SimulateTouchContainer
[TargetValidityRules]: #TargetValidityRules
[UngrabListener]: #UngrabListener
[Methods]: #Methods
[CancelCheckInteractableActiveRoutine()]: #CancelCheckInteractableActiveRoutine
[CanCreateGrabPoint(GrabInteractableAction)]: #CanCreateGrabPointGrabInteractableAction
[CheckGrabValidity(SurfaceData)]: #CheckGrabValiditySurfaceData
[CheckInteractableIsNotActiveAtEndOfFrame(InteractableFacade)]: #CheckInteractableIsNotActiveAtEndOfFrameInteractableFacade
[ConfigureInteractor()]: #ConfigureInteractor
[ConfigurePointerRules()]: #ConfigurePointerRules
[ConfigurePropertyApplier()]: #ConfigurePropertyApplier
[ConfigureReactivatePointerTimer()]: #ConfigureReactivatePointerTimer
[CreateGrabPoint(RaycastHit)]: #CreateGrabPointRaycastHit
[DestroyGrabPoint()]: #DestroyGrabPoint
[HasTouched(InteractableFacade)]: #HasTouchedInteractableFacade
[HasUntouched(InteractableFacade)]: #HasUntouchedInteractableFacade
[MakeInteractableKinematic()]: #MakeInteractableKinematic
[NotifyAfterGrabbed(InteractableFacade)]: #NotifyAfterGrabbedInteractableFacade
[NotifyBeforeGrabbed(InteractableFacade)]: #NotifyBeforeGrabbedInteractableFacade
[NotifyGrabCanceled()]: #NotifyGrabCanceled
[OnDisable()]: #OnDisable
[OnEnable()]: #OnEnable
[PerformGrab(InteractableFacade)]: #PerformGrabInteractableFacade
[PerformUngrab(InteractableFacade)]: #PerformUngrabInteractableFacade
[RegisterInteractorListeners()]: #RegisterInteractorListeners
[RestoreCachedInteractableKinematicState()]: #RestoreCachedInteractableKinematicState
[RestoreInteractorPrecognitionValue()]: #RestoreInteractorPrecognitionValue
[SimulateTouch(InteractableFacade)]: #SimulateTouchInteractableFacade
[SimulateUntouch(InteractableFacade)]: #SimulateUntouchInteractableFacade
[Start()]: #Start
[UnregisterInteractorListeners()]: #UnregisterInteractorListeners
