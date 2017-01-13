# Simple-collapsible-menu
Xamarin Forms dead simple implementation of a collapsible menu using a ListView

This is the fastest way to implement a Collapsible Menu I could think of. Right now it is just a POC.

In order to modify items shown in the menu you should modify the ``menuItems`` list in ``MenuViewModel`` constructor.

Each MenuItem has the following properties

 - Name: Text shown in the menu
 - Icon: icon path (right now is not being used)
 - Collapsed: boolean to indicate if item should be collapsed or not
 - InnerItem: boolean to indicate if it is an inner item or a collapsible item 

In order to change menu items appearance two custom cells are provided and can be modified:

 - CollapsibleMenuItem
 - InnerMenuItem
 
 
