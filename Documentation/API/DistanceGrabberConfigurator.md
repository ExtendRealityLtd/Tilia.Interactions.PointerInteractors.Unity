# Class DistanceGrabberConfigurator

Sets up the DistanceGrabber Prefab based on the provided user settings.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Fields]
  * [hasSubscribedToInteractorEvents]
* [Properties]
  * [Facade]
  * [Grabber]
  * [GrabListener]
  * [GrabProxy]
  * [Pointer]
  * [PropertyApplier]
  * [ReactivatePointerTimer]
  * [TargetValidityRules]
  * [UngrabListener]
* [Methods]
  * [ConfigureInteractor()]
  * [ConfigurePointerRules()]
  * [ConfigurePropertyApplier()]
  * [ConfigureReactivatePointerTimer()]
  * [OnDisable()]
  * [OnEnable()]
  * [PerformGrab(InteractableFacade)]
  * [PerformUngrab(InteractableFacade)]
  * [RegisterInteractorGrabListeners()]
  * [UnregisterInteractorGrabListeners()]

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

#### hasSubscribedToInteractorEvents

Whether the interactor events have been subscribed to.

##### Declaration

```
protected bool hasSubscribedToInteractorEvents
```

### Properties

#### Facade

The public facade.

##### Declaration

```
public DistanceGrabberFacade Facade { get; protected set; }
```

#### Grabber

The [InteractableGrabber] that initiates the grabbing.

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

The BooleanAction that proxies the interactor's grab action.

##### Declaration

```
public BooleanAction GrabProxy { get; protected set; }
```

#### Pointer

The PointerFacade to initiate the grabbing.

##### Declaration

```
public PointerFacade Pointer { get; protected set; }
```

#### PropertyApplier

The TransformPropertyApplier that transitions the interactable to the interactor.

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

#### ConfigureInteractor()

Configures the relevant components that require knowledge of the interactor.

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
| InteractableFacade | interactable | The interactable being grabbed. |

#### PerformUngrab(InteractableFacade)

Performs the ungrab logic.

##### Declaration

```
protected virtual void PerformUngrab(InteractableFacade interactable)
```

##### Parameters

| Type | Name | Description |
| --- | --- | --- |
| InteractableFacade | interactable | The interactable being grabbed. |

#### RegisterInteractorGrabListeners()

Registers the Interactor Grab listeners.

##### Declaration

```
protected virtual void RegisterInteractorGrabListeners()
```

#### UnregisterInteractorGrabListeners()

Unregisters the Interactor Grab listeners.

##### Declaration

```
protected virtual void UnregisterInteractorGrabListeners()
```

[Tilia.Interactions.PointerInteractors]: README.md
[DistanceGrabberFacade]: DistanceGrabberFacade.md
[InteractableGrabber]: InteractableGrabber.md
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Fields]: #Fields
[hasSubscribedToInteractorEvents]: #hasSubscribedToInteractorEvents
[Properties]: #Properties
[Facade]: #Facade
[Grabber]: #Grabber
[GrabListener]: #GrabListener
[GrabProxy]: #GrabProxy
[Pointer]: #Pointer
[PropertyApplier]: #PropertyApplier
[ReactivatePointerTimer]: #ReactivatePointerTimer
[TargetValidityRules]: #TargetValidityRules
[UngrabListener]: #UngrabListener
[Methods]: #Methods
[ConfigureInteractor()]: #ConfigureInteractor
[ConfigurePointerRules()]: #ConfigurePointerRules
[ConfigurePropertyApplier()]: #ConfigurePropertyApplier
[ConfigureReactivatePointerTimer()]: #ConfigureReactivatePointerTimer
[OnDisable()]: #OnDisable
[OnEnable()]: #OnEnable
[PerformGrab(InteractableFacade)]: #PerformGrabInteractableFacade
[PerformUngrab(InteractableFacade)]: #PerformUngrabInteractableFacade
[RegisterInteractorGrabListeners()]: #RegisterInteractorGrabListeners
[UnregisterInteractorGrabListeners()]: #UnregisterInteractorGrabListeners
