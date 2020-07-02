# Class InteractableGrabber

Attempts to grab the given interactable to the given interactor.

## Contents

* [Inheritance]
* [Namespace]
* [Syntax]
* [Properties]
  * [Interactable]
  * [Interactor]
* [Methods]
  * [DoGrab()]

## Details

##### Inheritance

* System.Object
* InteractableGrabber

##### Namespace

* [Tilia.Interactions.PointerInteractors]

##### Syntax

```
public class InteractableGrabber : MonoBehaviour
```

### Properties

#### Interactable

The interactable to grab.

##### Declaration

```
public InteractableFacade Interactable { get; set; }
```

#### Interactor

The interactor to grab to.

##### Declaration

```
public InteractorFacade Interactor { get; set; }
```

### Methods

#### DoGrab()

Attempts to grab the [Interactable] to the [Interactor].

##### Declaration

```
public virtual void DoGrab()
```

[Tilia.Interactions.PointerInteractors]: README.md
[Interactable]: InteractableGrabber.md#Interactable
[Interactor]: InteractableGrabber.md#Interactor
[Inheritance]: #Inheritance
[Namespace]: #Namespace
[Syntax]: #Syntax
[Properties]: #Properties
[Interactable]: #Interactable
[Interactor]: #Interactor
[Methods]: #Methods
[DoGrab()]: #DoGrab
