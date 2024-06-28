<h1 align="left">Dynamic Objects</h3>

<div align="left">

[![Status](https://img.shields.io/badge/status-active-success.svg)]()
[![GitHub Issues](https://img.shields.io/github/issues/datlycan/DynamicObjects.svg)](https://github.com/DatLycan/DynamicObjects/issues)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](/LICENSE)

</div>

---

<p align="left"> A designer friendly ScriptableObject framework for a faster and more dynamic workflow.
    <br> 
</p>

## 📝 Table of Contents

- [Getting Started](#getting_started)
- [Documentation](#documentation)
- [Usage](#usage)
- [Demo](#demo)
- [Acknowledgments](#acknowledgement)

## 🏁 Getting Started <a name = "getting_started"></a>

### Installing

Simply download the [latest release](https://github.com/DatLycan/DynamicObjects/releases) and [import](https://docs.unity3d.com/Manual/AssetPackagesImport.html) the package it into your project.

## 📦 Documentation <a name = "documentation"></a>

| Name              	| Inheritance      	| Description                                                                                                                                                              	|
|-------------------------	|------------------	|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------	|
| DynamicSignal           	| ScriptableObject 	| Stores a list of DynamicSignalListener's and Invokes their stored [UnityEvent](https://docs.unity3d.com/Manual/UnityEvents.html).                                        	|
| DynamicSignalListener   	| MonoBehaviour    	| Stores a reference to a DynamicSignal and a custom [UnityEvent](https://docs.unity3d.com/Manual/UnityEvents.html).                                                       	|
| DynamicVariable         	| ScriptableObject 	| Stores a single variable and optionally a reference to a DynamicSignal that can be emitted whenever the variable changes.                                                	|
| DynamicReference        	|                  	| References a DynamicVariable and allows the editing of it. It also stores a local variable allowing it to dynamically change between the global data and the local data. 	|
| DynamicRuntimeSet       	| ScriptableObject 	| Stores a list of object's.                                                                                                                                               	|
| DynamicRuntimeSetMember 	| MonoBehaviour    	| Stores a reference to a DynamicRuntimeSet and adds itself to the list of it.                                                                                             	|

## 🎈 Usage <a name="usage"></a>

*Everything can be managed in the inspector!*

<br>

---

### DynamicSignal, DynamicVariable, DynamicRuntimeSet
1. In your project tab:<br>
1. **Create > Dynamic Objects > [Object you want to create]** 


### SignalListener

1. Create a GameObject and attach a script and a **Signal Listener**.
2. Create a Method that the listener can invoke:<br>

   ```C#
    //Example function
    public void OnSignalReceived() => Debug.Log("Signal received!");
   ```
3. In the `Signal` field **select a DynamicSignal object**.
4. In the `response` field **Drag & drop your GameObject into it**. 
5. In the `function` field **Select the created Method**.


### DynamicRuntimeSetMember

1. Create a GameObject and attach a **Runtime Set Member**.
2. In the *Runtime Set* field **select the RuntimeSet this object should belong too**.<br>

### DynamicReference

1. In your script **create a serialized DynamicReference**.<br>
   
   ```C#
    [SerializedField] private DynamicFloatReference;
    [SerializedField] private DynamicBoolReference;
    // [. . .]
   ```
2. In the Inspector **select a DynamicVariable**.

---

<br>

## 🎥 Demo <a name = "acknowledgement"></a>

An example can be found in the [Example](https://github.com/DatLycan/DynamicObjects/tree/main/Example) folder.


## 🎉 Acknowledgements <a name = "acknowledgement"></a>

- *Inspired by [Ryan Hipple's amazing presentation at Unite Austin 2017](https://youtu.be/raQ3iHhE_Kk?si=wGoeG4MiWgoMsI4S).*<br>
- *Some snippets taken from [jheiling's unity-signals project](https://github.com/jheiling/unity-signals/tree/master).*

